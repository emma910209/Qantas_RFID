using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RfidApiLib;

namespace Demo
{
    public partial class Form1 : Form
    {
        DesktopRfidApi.RfidApi Api = new DesktopRfidApi.RfidApi();
        //RfidApi Api = new RfidApi();
        //  public byte IsoReading = 0;
        public byte EpcReading = 0;
        public byte UserReading = 0;
        public int TagCnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            

            int status;
            byte v1 = 0;
            byte v2 = 0;
            string s = "";

            //status = Api.OpenCommPort(cCommPort.SelectedItem.ToString());
            status = Api.OpenCommPort("COM3");
            status = Api.GetFirmwareVersion(ref v1, ref v2);

            Console.WriteLine("Connect the reader success!");
            s = string.Format("The reader's firmware version is:V{0:d2}.{1:d2}", v1, v2);
            // lInfo.Items.Add(s);
            Console.WriteLine(s);

        }

        public static string epcM;
        public static string epcM2;
        private readonly object F1D;

        public void bEpcRead_Click(object sender, EventArgs e)
        {

            UserM_groupBox.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            EPCM_groupBox.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            byte[] value = new byte[200];


            string EpcNoIntotal = "";
            byte[] IntEpcNo = new byte[32];
            int result = Api.EpcRead((byte)1, (byte)2, (byte)7, ref IntEpcNo);
            if (result == 0)
            {

                for (int i = 0; i < 14; i++)
                {
                    string EpcNo = string.Format("{0:X2}", IntEpcNo[i]);
                    EpcNoIntotal += EpcNo;
                    EPCM_tBox.Text = EpcNoIntotal;
                    EPCM_tBox.Enabled = true;
                }
                lInfo.Items.Add("EPC Memory is:" + EpcNoIntotal);
                epcM = EpcNoIntotal;
             Information_transfer(epcM);
            }

            else
            { lInfo.Items.Add("EPC Memory Read failed!"); }
           




            string UserNoIntotal = "";
            byte[] IntUsercNo = new byte[32];


            int Uresult = Api.EpcRead((byte)3, (byte)2, (byte)9, ref IntUsercNo);
            if (Uresult == 0)
            {

                for (int i = 0; i < 18; i++)
                {
                    string UserNo = string.Format("{0:X2}", IntUsercNo[i]);
                    UserNoIntotal += UserNo;
                    Console.WriteLine(UserNoIntotal);
                    //this.txtUser.Text = EpcNoIntotal;
                    UserM_tBox.Enabled = true;
                }
                int result1 = Api.EpcRead((byte)3, (byte)11, (byte)9, ref IntUsercNo);
                if (result1 == 0)
                {

                    for (int i = 0; i < 18; i++)
                    {
                       
                        string UserNo1 = string.Format("{0:X2}", IntUsercNo[i]);
                        UserNoIntotal += UserNo1;
                        Console.WriteLine(UserNoIntotal);
                        //this.txtUser.Text = EpcNoIntotal;
                        UserM_tBox.Enabled = true;
                    }
                    int result2 = Api.EpcRead((byte)3, (byte)20, (byte)8, ref IntUsercNo);
                    if (result2 == 0)
                    {

                        for (int i = 0; i < 18; i++)
                        { 
                            
                            string UserNo2 = string.Format("{0:X2}", IntUsercNo[i]);
                            if (UserNo2 == "00" || UserNo2.Length == 0)
                            {
                                break;
                            }
                            UserNoIntotal += UserNo2;
                            Console.WriteLine("Usernt" +UserNoIntotal);
                            //this.txtUser.Text = EpcNoIntotal;
                            UserM_tBox.Enabled = true;
                        }

                        UserM_tBox.Text = UserNoIntotal;
                        lInfo.Items.Add("User Memory is:" + UserNoIntotal);
                        epcM2 = UserNoIntotal;
                        Information_transfer2(epcM2);
                    }

                    else { lInfo.Items.Add("User Memory Read failed!"); }
                   
                }


                  

                //Decode_transfer(epcM);

            }


        }


        private void Information_transfer(string epcM)
        {
            string time;
                EPCM_tBox.Text = epcM;
                string EPCMemory = EPCM_tBox.Text;
                string[] EPCMArray = EPCMemory.Split(new string[] { "34C10C2105", "2202" }, StringSplitOptions.RemoveEmptyEntries);
                LicensePN_tBox.Text = EPCMArray[0].ToString();
               string UserTime = EPCMArray[1].ToString();
            // if (UserTime.Substring(3, 1)
            if (UserTime.LastIndexOf("F") >= 0 )
            {
                time = UserTime.Substring(0, 3);
                //time = UserTime.Substring(0, 3);
                Console.WriteLine("TimeF" + time);
            }
            else
            {
                time = EPCMArray[1].PadLeft(3,'0');
                Console.WriteLine("time" + time);
            }
            Console.WriteLine("timestring------->" + Convert.ToDouble(time).ToString());
            FlightDate_tBox.Text = new DateTime(DateTime.Now.Year, 1, 1).AddDays(Convert.ToDouble(time)-1).ToShortDateString();
               // Console.WriteLine(EPCMArray);
            
        }

        private void Information_transfer2(string epcM2)
        {
               if (epcM2.Length < 84)
            {
                epcM2 = epcM2.PadRight(84, '0');
            }
               else  if (epcM2.Length < 104)
                {
                    epcM2 = epcM2.PadRight(104, '0');
                }
            else if (epcM2.Length < 106)
            {
                epcM2 = epcM2.PadRight(106, '0');
            }

            string UserMemory = epcM2;
                string[] USERMArray = UserMemory.Split(new string[] { "0C2F7007", "2801","47", "3402"}, StringSplitOptions.RemoveEmptyEntries);

                QBTN_tBox.Text = USERMArray[0].ToString();
                 QFFT_tBox.Text = USERMArray[1].ToString();
                 
                string PassagerN = USERMArray[2].ToString();
               //int PasLength = Int32.Parse(PassagerN.Substring(0, 2));
                int PasLength = PassagerN.Substring(2).Length;

                PassagerN_tBox.Text = Decode(PassagerN.Substring(2), PasLength);
                string Ori = USERMArray[3].Substring(0,4).ToString();
                if (Ori.Length == 4)
                {
                    int hi = Convert.ToInt32(Ori.Substring(0, 2), 16);
                    int low = Convert.ToInt32(Ori.Substring(2, 2), 16);
                    string origin = Decode_Origin(hi, low);
                    Origin_tBox.Text = origin;
                }

                string FlightData = USERMArray[3].Substring(6).ToString();
                int FDLength = FlightData.Length;
                string FDT = Decode(FlightData.Substring(2), FDLength);
      
                if(FDT != null)
            {
                if (FDT.Length > 26 && FDT.Substring(26,1) == "Q")
                {
                    string FDTS = FDT.Substring(0, 39);
                    Flight_Data_T.Text = FDT ;
                    Flight_1_tBox.Text = FDT.Substring(0, 6);
                    Console.WriteLine("F1TIME------>" + FDT.Substring(6, 3));
                    String F1T = FDTS.Substring(6);
                    F1Date_tBox.Text = new DateTime(DateTime.Now.Year, 1, 1).AddDays(Convert.ToDouble(F1T.Substring(0, F1T.Length - 30).ToString()) - 1).ToShortDateString();
                    F1Destination_tBox.Text = FDT.Substring(9, 3);
                    F1CabinC_tBox.Text = FDT.Substring(12,1);
                    Flight_2_tBox.Text = FDT.Substring(13, 6);
                    String F2T = FDTS.Substring(19);
                    F2Date_tBox.Text = new DateTime(DateTime.Now.Year, 1, 1).AddDays(Convert.ToDouble(F2T.Substring(0, F2T.Length - 17).ToString()) - 1).ToShortDateString();
                    F2Destination_tBox.Text = FDT.Substring(22, 3);
                    Console.WriteLine(FDT.Substring(22, 3));
                   F2CabinC_tBox.Text = FDT.Substring(25, 1);
                   Console.WriteLine(FDT.Substring(25, 1));
                    Flight_3_tBox.Text = FDT.Substring(26, 6);
                    String F3T = FDTS.Substring(32);
                    F3Date_tBox.Text = new DateTime(DateTime.Now.Year, 1, 1).AddDays(Convert.ToDouble(F3T.Substring(0, F3T.Length - 4).ToString()) - 1).ToShortDateString();
                    F3Destination_tBox.Text = FDT.Substring(35, 3);
                    F3CabinC_tBox.Text = FDT.Substring(38, 1);
                }
                else if  (FDT.Length >13 && FDT.Substring(13, 1) == "Q")
                {
                    string FDTS = FDT.Substring(0, 26);
                    Flight_Data_T.Text = FDT.Substring(0, 26);
                    Flight_1_tBox.Text = FDT.Substring(0, 6);
                    String F1T = FDTS.Substring(6);
                    F1Date_tBox.Text = new DateTime(DateTime.Now.Year, 1, 1).AddDays(Convert.ToDouble(F1T.Substring(0, F1T.Length - 17).ToString()) - 1).ToShortDateString();
                    F1Destination_tBox.Text = FDT.Substring(9, 3);
                    F1CabinC_tBox.Text = FDT.Substring(12, 1);
                    Flight_2_tBox.Text = FDT.Substring(13, 6);
                    String F2T = FDTS.Substring(19);
                    F2Date_tBox.Text = new DateTime(DateTime.Now.Year, 1, 1).AddDays(Convert.ToDouble(F2T.Substring(0, F2T.Length - 4).ToString()) - 1).ToShortDateString();
                    F2Destination_tBox.Text = FDT.Substring(22, 3);
                    Console.WriteLine("FDTDEST----"+FDT.Substring(22, 3));
                   F2CabinC_tBox.Text = FDT.Substring(25, 1);
                   Console.WriteLine("FDTCAB------"+FDT.Substring(22, 3));
                }
                else
                {
                    Flight_Data_T.Text = FDT;
                    Flight_1_tBox.Text = FDT.Substring(0, 6);
                    String F1T = FDT.Substring(6);
                    F1Date_tBox.Text = new DateTime(DateTime.Now.Year, 1, 1).AddDays(Convert.ToDouble(F1T.Substring(0, F1T.Length-4).ToString()) - 1).ToShortDateString();
                    F1Destination_tBox.Text = FDT.Substring(8, 3);
                    F1CabinC_tBox.Text = FDT.Substring(11, 1);
                }
            }

            


        }

        private string Decode(string passagerN, int Length)
        {
            string s = passagerN;
            Console.WriteLine("DECODE S-----" + s);
            List<string> list = new List<string>();
            for (int i = 0; i < s.Length - 1; i += 2)
            {

                list.Add(s.Substring(i, 2));

            }

            var s8 = new List<string>();

            foreach (var a in list)
            {
                var s1 = Convert.ToString(Convert.ToByte(a, 16), 2).PadLeft(8, '0');
                if (s1 == "00000000") { break; }
                s8.Add(s1);
                Console.WriteLine("DECODE s1 -----" + s1);
            }

            var s6 = string.Concat(s8.ToArray());
            var pad = Math.Ceiling((double)s6.Length / 6) * 6;
            s6 = s6.PadRight((int)pad, '0');
            var result = "";
            byte[] buffer = new byte[25];
            string[] items = new string[s6.Length / 6];
            byte[] array = new byte[100];

            for (int i = 0; i < pad / 6; i++)
            {

                items[i] = s6.Substring(i * 6, 6).ToString();
                int n = Convert.ToInt32(items[i], 2);
                int c = n < 47 ? n + 64 : n;
                result += (Char)c;
                Console.WriteLine("DECODE result i-----" + i);
                Console.WriteLine("DECODE RESULT-----" + result);
                Console.WriteLine("DECODE result length--------" + result.Length);
            }

            return result;


        }

        private string Decode_Origin(int a, int b)
        {

            byte[] buffer = new byte[3];
            int f = a << 8 | b;

            for (int i = 0; i < 3; i++)
            {
                int aa = f >> (0x10 - 0x5 * (i + 1));
                int bb = (aa & 0x1F) | 0x40;
                buffer[i] = (byte)bb;
            }
            return ASCIIEncoding.ASCII.GetString(buffer);
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            lInfo.Items.Clear();
            //lvTagList.Items.Clear();
        }

       /* private void bEpcInit_Click(object sender, EventArgs e)
        {
            int status;

            status = Api.EpcInitEpc(96);

            if (status == 0)
            {
                lInfo.Items.Add("Init tag success!");
            }
            else
            {
                lInfo.Items.Add("Init tag failed!");
            }
        }*/

        private void bEpcWrite_Click(object sender, EventArgs e)
        {
            
          
                DateTime Dt = Convert.ToDateTime(FlightDate_tBox.Text);
                TimeSpan FD = Dt - new DateTime(DateTime.Now.Year, 1, 1);
                string time = (FD.Days + 1).ToString();
                string EPCM = "34C10C2105" + LicensePN_tBox.Text + "2202" + time.PadLeft(3,'0').PadRight(4, 'F');
                EPCM_tBox.Text = EPCM;
                lInfo.Items.Add("EPC Memory is " + EPCM);
 
                string PASN = PassagerN_tBox.Text;
            Console.WriteLine("PASN1" + PASN);
            PASN = Encode(PASN);
            Console.WriteLine("PASN2" + PASN);
            // byte[] namebyte = Encoding.Default.GetBytes(PASN);
            Console.WriteLine("PASNlength" + PASN.Length);
           // int nameLength = PASN.Length/2;
            string nameLength = Convert.ToString(PASN.Length / 2, 16).PadLeft(2, '0');
            Console.WriteLine("namelength" + nameLength);
            string Origin = Origin_tBox.Text;
                Origin = Encode_Origin(Origin, byte.Parse("0"));
            Console.WriteLine("Origin" + Origin);
            string F1T = "";
            string F2T= "";
            string F3T= "";
            string FDT= "";
            string FDTLength = "";


            if (Flight_3_tBox.Text != "" && F3Date_tBox.Text  != "" && F3Destination_tBox.Text != "" && F3CabinC_tBox.Text != "")
            {
                DateTime F3t = Convert.ToDateTime(F3Date_tBox.Text);
                TimeSpan F3D = F3t - new DateTime(DateTime.Now.Year, 1, 1);
                F3T = Flight_3_tBox.Text + (F3D.Days + 1).ToString() + F3Destination_tBox.Text + F3CabinC_tBox.Text;
                DateTime F2t = Convert.ToDateTime(F2Date_tBox.Text);
                TimeSpan F2D = F2t - new DateTime(DateTime.Now.Year, 1, 1);
                F2T = Flight_2_tBox.Text + (F2D.Days + 1).ToString() + F2Destination_tBox.Text + F2CabinC_tBox.Text;
                DateTime F1t = Convert.ToDateTime(F1Date_tBox.Text);
                TimeSpan F1D = F1t - new DateTime(DateTime.Now.Year, 1, 1);
                F1T = Flight_1_tBox.Text + (F1D.Days + 1).ToString() + F1Destination_tBox.Text + F1CabinC_tBox.Text;
                FDT = F1T + F2T + F3T;
                
                Flight_Data_T.Text = FDT;
                FDT = Encode(FDT);
                FDTLength = Convert.ToString(FDT.Length / 2, 16);
            }
            else if (Flight_2_tBox.Text != "" && F2Date_tBox.Text  != "" && F2Destination_tBox.Text != "" && F2CabinC_tBox.Text != "")
            {
                DateTime F2t = Convert.ToDateTime(F2Date_tBox.Text);
                TimeSpan F2D = F2t - new DateTime(DateTime.Now.Year, 1, 1);
                F2T = Flight_2_tBox.Text + (F2D.Days + 1).ToString() + F2Destination_tBox.Text + F2CabinC_tBox.Text;
                DateTime F1t = Convert.ToDateTime(F1Date_tBox.Text);
                TimeSpan F1D = F1t - new DateTime(DateTime.Now.Year, 1, 1);
                F1T = Flight_1_tBox.Text + (F1D.Days + 1).ToString() + F1Destination_tBox.Text + F1CabinC_tBox.Text;
                FDT = F1T + F2T;
                Flight_Data_T.Text = FDT;
                FDT = Encode(FDT);
                FDTLength = Convert.ToString(FDT.Length / 2, 16);
            }
            else
            {
                DateTime F1t = Convert.ToDateTime(F1Date_tBox.Text);
                TimeSpan F1D = F1t - new DateTime(DateTime.Now.Year, 1, 1);
                F1T = Flight_1_tBox.Text + (F1D.Days + 1).ToString() + F1Destination_tBox.Text + F1CabinC_tBox.Text;
                FDT = F1T;
                Flight_Data_T.Text = FDT;
                FDT = Encode(FDT);
                FDTLength = Convert.ToString(FDT.Length / 2, 16);
            }

            
              Console.WriteLine("FDT" + FDT);
            Console.WriteLine("FDTLENGTH" + FDTLength);
            string userM = "0C2F7007" + QBTN_tBox.Text.PadRight(14,'F') + "2801" + QFFT_tBox.Text.PadRight(2,'F') + "47" + nameLength + PASN + "3402" + Origin + "46" + FDTLength.PadLeft(2,'0') + FDT;
            Console.WriteLine("USERM" + userM);
            lInfo.Items.Add("User Memory is :" + userM);
                UserM_tBox.Text = userM;
          
            
            ushort[] value = new ushort[16];
            int a = 0;
            if (EPCM_tBox.TextLength == 0)
            {
                MessageBox.Show("Please input data needed");
                return;
            }
         
            string no = EPCM_tBox.Text.Trim();
            string no1 = InsertFormat(no, 4, " ");
            string[] EPCNoSplit = no1.Split(' ');
            foreach (string EPC in EPCNoSplit)
            {
                int EPCNo = Convert.ToInt32(EPC, 16);

                value[a++] = (ushort)EPCNo;
            }
            for (int i = 0; i < 7; i++)
            {
                int result = Api.EpcWrite((byte)1, (byte)(2 + i), value[i]);

                if (result != 0)
                {
                    MessageBox.Show("Write EPC failed!");
                    //this.lstBoxshow.Items.Add("写入EPC失败");
                    return;
                }

            }
            lInfo.Items.Add("Write EPC success!" + EPCM_tBox.Text.Trim());
            EPCM_tBox.Clear();

            ushort[] value1 = new ushort[51];
            int b = 0;
            if (UserM_tBox.TextLength == 0)
            {
                MessageBox.Show("Please input data needed");
                return;
            }

            string no2 = UserM_tBox.Text.Trim();
            string no12 = InsertFormat1(no2, 4, " ");
            string[] UserNoSplit = no12.Split(' ');
            foreach (string User in UserNoSplit)
            {
                int UserNo = Convert.ToInt32(User, 16);
                Console.WriteLine(UserNo);
                value1[b++] = (ushort)UserNo;
                
            }
            for (int i = 0; i < 28; i++)
            {
                int result1 = Api.EpcWrite((byte)3, (byte)(2 + i), value1[i]);
                Console.WriteLine(value1[i]);

                if (result1 != 0)
                {
                    MessageBox.Show("Write UserM failed!");
                    //this.lstBoxshow.Items.Add("写入EPC失败");
                    return;
                }

            }
            lInfo.Items.Add("Write User success!" + UserM_tBox.Text.Trim());
            UserM_tBox.Clear();




        }

        public static string InsertFormat(string input, int interval, string value)
        {
            for (int i = interval; i < input.Length; i += interval + 1)
                input = input.Insert(i, value);
            return input;
        }
        public static string InsertFormat1(string input, int interval, string value)
        {
            for (int i = interval; i < input.Length; i += interval + 1)
                input = input.Insert(i, value);
            return input;
        }

        private string Encode_Origin(string strInput, byte bu)
            {
                byte[] buffer = ASCIIEncoding.ASCII.GetBytes(strInput);
                int ff = 0;
                for (int i = 0; i < 3; i++)
                {
                    int aa = buffer[i] & 0x1F;
                    int bb = aa << (0x5 * (2 - i) + 1);
                    ff |= bb;
                }
                ff |= bu;

                byte hi = (byte)(ff >> 0x8);
                byte low = (byte)(ff & 0xFF);

                string res = Convert.ToString(hi, 16).PadLeft(2, '0') + Convert.ToString(low, 16).PadLeft(2, '0');
                return res;
            }

            private void Code_transfer(string TransferData)
            {
                string ss = TransferData;
                if (ss.Length != 0)
                {
                    try
                    {
                        string kk = Encode(ss);
                    Console.WriteLine(" Encodess ==> " + ss);
                    Console.WriteLine(" Encode ==> " + kk);

                    }

                    catch
                    {
                        Console.WriteLine("Input data error");
                    }


                }
                else
                {
                    Console.WriteLine("Input data error");
                }

            }

            
            private void button1_Click(object sender, EventArgs e)
            {
                string s = FlightDate_tBox.Text.ToString();
                bool b = ValidateDataTime(s);
                string rs = "";
                if (b)
                {
                    rs = "true";
                }
                else
                {
                    rs = "false";
                }
                MessageBox.Show(rs);
            }
            //验证方法-格式为：YYYY-MM-DD
            public static bool ValidateDataTime(string InputStr)
            {
                if (InputStr.Length > 0)
                {
                    if (Regex.IsMatch(InputStr.Trim(), @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                return false;
            }



            private void btnList_Click(object sender, EventArgs e)
            {
                //  lvTagList.Visible = true;
                lInfo.Visible = false;
            }

            private void btnDetail_Click(object sender, EventArgs e)
            {
                // lvTagList.Visible = false;
                lInfo.Visible = true;
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                if (Api.Opened)
                {

                    Api.CloseCommPort();
                    Api.CloseCommPort();
                    bEpcRead.Enabled = false;
                    bEpcWrite.Enabled = false;
                    bEpcInit.Enabled = false;
                }
                this.Close();
            }

            private void Origin_comboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                while (true)
                {

                    string ss = Origin_tBox.Text;
                    if (ss.Length == 3)
                    {
                        try
                        {
                            string kk = Encode_Origin(ss, byte.Parse("0"));
                            Console.WriteLine("Origin Encode ==> " + kk);
                        }
                        catch
                        {
                            Console.WriteLine("Input data error");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Data length error");
                    }

                    Console.Clear();
                }
            }





            /* private static string Encode_Origin(string strInput, byte bu)
             {
                 byte[] buffer = ASCIIEncoding.ASCII.GetBytes(strInput);
                 int ff = 0;
                 for (int i = 0; i < 3; i++)
                 {
                     int aa = buffer[i] & 0x1F;
                     int bb = aa << (0x5 * (2 - i) + 1);
                     ff |= bb;
                 }
                 ff |= bu;

                 byte hi = (byte)(ff >> 0x8);
                 byte low = (byte)(ff & 0xFF);

                 string res = Convert.ToString(hi, 16).PadLeft(2, '0') + Convert.ToString(low, 16).PadLeft(2, '0');
                 return res;
             }*/


            public static string Encode(string strInput)
            {
                     
                var s6 = new List<string>();
                foreach (var c in strInput.ToCharArray())
                {
                    var s = Convert.ToString(((byte)c - 64), 2).PadLeft(6, '0');
                    s = s.Substring(s.Length - 6, 6);
                    s6.Add(s);
                }

                var s8 = string.Concat(s6.ToArray());
                var pad = Math.Ceiling((double)s8.Length / 8) * 8;
                s8 = s8.PadRight((int)pad, '0');
                var result = "";
                for (int i = 0; i < pad / 8; i++)
                {
                    result += Convert.ToString(Convert.ToInt32(s8.Substring(i * 8, 8), 2), 16).PadLeft(2, '0');
                Console.WriteLine("ENCOD Eresult i-----" + i);
                Console.WriteLine("ENCODE RESULT-----" +result);
                Console.WriteLine("ENCODE Result length--------" + result.Length);
            }

                return result;
            }

            private void exit_button_Click(object sender, EventArgs e)
            {
                if (Api.Opened)
                {

                    Api.CloseCommPort();
                    Api.CloseCommPort();
                }

                this.Close();
            }

        private void clear_button_Click(object sender, EventArgs e)
        {
          foreach(Control c in EPCM_groupBox.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
            foreach (Control c in UserM_groupBox.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void EPCM_CLEAR_button_Click(object sender, EventArgs e)
        {
            foreach (Control c in EPCM_groupBox.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void USERM_CLEAR_button_Click(object sender, EventArgs e)
        {
            foreach (Control c in UserM_groupBox.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
    }
    }
    









