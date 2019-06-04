namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lInfo = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.bEpcInit = new System.Windows.Forms.Button();
            this.bEpcWrite = new System.Windows.Forms.Button();
            this.bEpcRead = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.EPCM_groupBox = new System.Windows.Forms.GroupBox();
            this.EPCM_tBox = new System.Windows.Forms.TextBox();
            this.FlightDate_tBox = new System.Windows.Forms.TextBox();
            this.LicensePN_tBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserM_groupBox = new System.Windows.Forms.GroupBox();
            this.Flight_Data_T = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.UserM_tBox = new System.Windows.Forms.TextBox();
            this.F3CabinC_tBox = new System.Windows.Forms.TextBox();
            this.F2CabinC_tBox = new System.Windows.Forms.TextBox();
            this.F1CabinC_tBox = new System.Windows.Forms.TextBox();
            this.F3Destination_tBox = new System.Windows.Forms.TextBox();
            this.F2Destination_tBox = new System.Windows.Forms.TextBox();
            this.F1Destination_tBox = new System.Windows.Forms.TextBox();
            this.F3Date_tBox = new System.Windows.Forms.TextBox();
            this.F2Date_tBox = new System.Windows.Forms.TextBox();
            this.F1Date_tBox = new System.Windows.Forms.TextBox();
            this.Flight_3_tBox = new System.Windows.Forms.TextBox();
            this.Flight_2_tBox = new System.Windows.Forms.TextBox();
            this.Flight_1_tBox = new System.Windows.Forms.TextBox();
            this.Origin_tBox = new System.Windows.Forms.TextBox();
            this.PassagerN_tBox = new System.Windows.Forms.TextBox();
            this.QFFT_tBox = new System.Windows.Forms.TextBox();
            this.QBTN_tBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EPCM_CLEAR_button = new System.Windows.Forms.Button();
            this.USERM_CLEAR_button = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.EPCM_groupBox.SuspendLayout();
            this.UserM_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lInfo
            // 
            this.lInfo.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lInfo.FormattingEnabled = true;
            this.lInfo.HorizontalScrollbar = true;
            this.lInfo.ItemHeight = 12;
            this.lInfo.Location = new System.Drawing.Point(6, 22);
            this.lInfo.Name = "lInfo";
            this.lInfo.ScrollAlwaysVisible = true;
            this.lInfo.Size = new System.Drawing.Size(346, 436);
            this.lInfo.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clear_button);
            this.groupBox6.Controls.Add(this.bEpcInit);
            this.groupBox6.Controls.Add(this.bEpcWrite);
            this.groupBox6.Controls.Add(this.bEpcRead);
            this.groupBox6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(358, 150);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ISO18000-6C(EPC G2)";
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.SlateGray;
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear_button.ForeColor = System.Drawing.Color.Gold;
            this.clear_button.Location = new System.Drawing.Point(253, 36);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(99, 43);
            this.clear_button.TabIndex = 30;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // bEpcInit
            // 
            this.bEpcInit.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcInit.ForeColor = System.Drawing.Color.Gold;
            this.bEpcInit.Location = new System.Drawing.Point(20, 96);
            this.bEpcInit.Name = "bEpcInit";
            this.bEpcInit.Size = new System.Drawing.Size(90, 43);
            this.bEpcInit.TabIndex = 29;
            this.bEpcInit.Text = "Init";
            this.bEpcInit.UseVisualStyleBackColor = false;
            this.bEpcInit.Visible = false;
            // 
            // bEpcWrite
            // 
            this.bEpcWrite.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcWrite.ForeColor = System.Drawing.Color.Gold;
            this.bEpcWrite.Location = new System.Drawing.Point(20, 36);
            this.bEpcWrite.Name = "bEpcWrite";
            this.bEpcWrite.Size = new System.Drawing.Size(90, 43);
            this.bEpcWrite.TabIndex = 7;
            this.bEpcWrite.Text = "Write";
            this.bEpcWrite.UseVisualStyleBackColor = false;
            this.bEpcWrite.Click += new System.EventHandler(this.bEpcWrite_Click);
            // 
            // bEpcRead
            // 
            this.bEpcRead.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcRead.ForeColor = System.Drawing.Color.Gold;
            this.bEpcRead.Location = new System.Drawing.Point(134, 36);
            this.bEpcRead.Name = "bEpcRead";
            this.bEpcRead.Size = new System.Drawing.Size(99, 43);
            this.bEpcRead.TabIndex = 6;
            this.bEpcRead.Text = "Read";
            this.bEpcRead.UseVisualStyleBackColor = false;
            this.bEpcRead.Click += new System.EventHandler(this.bEpcRead_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkFilter);
            this.groupBox7.Controls.Add(this.btnDetail);
            this.groupBox7.Controls.Add(this.btnList);
            this.groupBox7.Controls.Add(this.bClear);
            this.groupBox7.Controls.Add(this.lInfo);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox7.Location = new System.Drawing.Point(12, 184);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(358, 471);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Opration Info.";
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkFilter.ForeColor = System.Drawing.Color.Yellow;
            this.chkFilter.Location = new System.Drawing.Point(9, 661);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(126, 20);
            this.chkFilter.TabIndex = 9;
            this.chkFilter.Text = "Filter Same";
            this.chkFilter.UseVisualStyleBackColor = true;
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.SlateGray;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDetail.ForeColor = System.Drawing.Color.Gold;
            this.btnDetail.Location = new System.Drawing.Point(213, 657);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(77, 37);
            this.btnDetail.TabIndex = 13;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Visible = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.SlateGray;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnList.ForeColor = System.Drawing.Color.Gold;
            this.btnList.Location = new System.Drawing.Point(134, 657);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(77, 37);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Visible = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.SlateGray;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bClear.ForeColor = System.Drawing.Color.Gold;
            this.bClear.Location = new System.Drawing.Point(296, 657);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(77, 37);
            this.bClear.TabIndex = 11;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SlateGray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(12, 661);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 34);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EPCM_groupBox
            // 
            this.EPCM_groupBox.Controls.Add(this.EPCM_CLEAR_button);
            this.EPCM_groupBox.Controls.Add(this.EPCM_tBox);
            this.EPCM_groupBox.Controls.Add(this.FlightDate_tBox);
            this.EPCM_groupBox.Controls.Add(this.LicensePN_tBox);
            this.EPCM_groupBox.Controls.Add(this.label2);
            this.EPCM_groupBox.Controls.Add(this.label3);
            this.EPCM_groupBox.Controls.Add(this.label4);
            this.EPCM_groupBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EPCM_groupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EPCM_groupBox.Location = new System.Drawing.Point(442, 12);
            this.EPCM_groupBox.Name = "EPCM_groupBox";
            this.EPCM_groupBox.Size = new System.Drawing.Size(755, 188);
            this.EPCM_groupBox.TabIndex = 9;
            this.EPCM_groupBox.TabStop = false;
            this.EPCM_groupBox.Text = "EPC Memory";
            // 
            // EPCM_tBox
            // 
            this.EPCM_tBox.Location = new System.Drawing.Point(217, 106);
            this.EPCM_tBox.Name = "EPCM_tBox";
            this.EPCM_tBox.Size = new System.Drawing.Size(366, 26);
            this.EPCM_tBox.TabIndex = 28;
            // 
            // FlightDate_tBox
            // 
            this.FlightDate_tBox.Location = new System.Drawing.Point(217, 63);
            this.FlightDate_tBox.Name = "FlightDate_tBox";
            this.FlightDate_tBox.Size = new System.Drawing.Size(366, 26);
            this.FlightDate_tBox.TabIndex = 27;
            // 
            // LicensePN_tBox
            // 
            this.LicensePN_tBox.Location = new System.Drawing.Point(217, 20);
            this.LicensePN_tBox.Name = "LicensePN_tBox";
            this.LicensePN_tBox.Size = new System.Drawing.Size(366, 26);
            this.LicensePN_tBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "License Plate Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "EPC Memory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Flight date";
            // 
            // UserM_groupBox
            // 
            this.UserM_groupBox.Controls.Add(this.USERM_CLEAR_button);
            this.UserM_groupBox.Controls.Add(this.Flight_Data_T);
            this.UserM_groupBox.Controls.Add(this.label25);
            this.UserM_groupBox.Controls.Add(this.UserM_tBox);
            this.UserM_groupBox.Controls.Add(this.F3CabinC_tBox);
            this.UserM_groupBox.Controls.Add(this.F2CabinC_tBox);
            this.UserM_groupBox.Controls.Add(this.F1CabinC_tBox);
            this.UserM_groupBox.Controls.Add(this.F3Destination_tBox);
            this.UserM_groupBox.Controls.Add(this.F2Destination_tBox);
            this.UserM_groupBox.Controls.Add(this.F1Destination_tBox);
            this.UserM_groupBox.Controls.Add(this.F3Date_tBox);
            this.UserM_groupBox.Controls.Add(this.F2Date_tBox);
            this.UserM_groupBox.Controls.Add(this.F1Date_tBox);
            this.UserM_groupBox.Controls.Add(this.Flight_3_tBox);
            this.UserM_groupBox.Controls.Add(this.Flight_2_tBox);
            this.UserM_groupBox.Controls.Add(this.Flight_1_tBox);
            this.UserM_groupBox.Controls.Add(this.Origin_tBox);
            this.UserM_groupBox.Controls.Add(this.PassagerN_tBox);
            this.UserM_groupBox.Controls.Add(this.QFFT_tBox);
            this.UserM_groupBox.Controls.Add(this.QBTN_tBox);
            this.UserM_groupBox.Controls.Add(this.label24);
            this.UserM_groupBox.Controls.Add(this.label23);
            this.UserM_groupBox.Controls.Add(this.label22);
            this.UserM_groupBox.Controls.Add(this.label21);
            this.UserM_groupBox.Controls.Add(this.label20);
            this.UserM_groupBox.Controls.Add(this.label19);
            this.UserM_groupBox.Controls.Add(this.label18);
            this.UserM_groupBox.Controls.Add(this.label13);
            this.UserM_groupBox.Controls.Add(this.label12);
            this.UserM_groupBox.Controls.Add(this.label11);
            this.UserM_groupBox.Controls.Add(this.label10);
            this.UserM_groupBox.Controls.Add(this.label9);
            this.UserM_groupBox.Controls.Add(this.label8);
            this.UserM_groupBox.Controls.Add(this.label7);
            this.UserM_groupBox.Controls.Add(this.label1);
            this.UserM_groupBox.Controls.Add(this.label5);
            this.UserM_groupBox.Controls.Add(this.label6);
            this.UserM_groupBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserM_groupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserM_groupBox.Location = new System.Drawing.Point(442, 225);
            this.UserM_groupBox.Name = "UserM_groupBox";
            this.UserM_groupBox.Size = new System.Drawing.Size(755, 538);
            this.UserM_groupBox.TabIndex = 10;
            this.UserM_groupBox.TabStop = false;
            this.UserM_groupBox.Text = "User Memory";
            // 
            // Flight_Data_T
            // 
            this.Flight_Data_T.Location = new System.Drawing.Point(110, 391);
            this.Flight_Data_T.Name = "Flight_Data_T";
            this.Flight_Data_T.Size = new System.Drawing.Size(611, 26);
            this.Flight_Data_T.TabIndex = 58;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(8, 394);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 16);
            this.label25.TabIndex = 57;
            this.label25.Text = "Flight Data";
            // 
            // UserM_tBox
            // 
            this.UserM_tBox.Location = new System.Drawing.Point(111, 431);
            this.UserM_tBox.Name = "UserM_tBox";
            this.UserM_tBox.Size = new System.Drawing.Size(610, 26);
            this.UserM_tBox.TabIndex = 56;
            // 
            // F3CabinC_tBox
            // 
            this.F3CabinC_tBox.Location = new System.Drawing.Point(592, 349);
            this.F3CabinC_tBox.Name = "F3CabinC_tBox";
            this.F3CabinC_tBox.Size = new System.Drawing.Size(129, 26);
            this.F3CabinC_tBox.TabIndex = 55;
            // 
            // F2CabinC_tBox
            // 
            this.F2CabinC_tBox.Location = new System.Drawing.Point(358, 346);
            this.F2CabinC_tBox.Name = "F2CabinC_tBox";
            this.F2CabinC_tBox.Size = new System.Drawing.Size(129, 26);
            this.F2CabinC_tBox.TabIndex = 54;
            // 
            // F1CabinC_tBox
            // 
            this.F1CabinC_tBox.Location = new System.Drawing.Point(110, 349);
            this.F1CabinC_tBox.Name = "F1CabinC_tBox";
            this.F1CabinC_tBox.Size = new System.Drawing.Size(129, 26);
            this.F1CabinC_tBox.TabIndex = 53;
            // 
            // F3Destination_tBox
            // 
            this.F3Destination_tBox.Location = new System.Drawing.Point(592, 307);
            this.F3Destination_tBox.Name = "F3Destination_tBox";
            this.F3Destination_tBox.Size = new System.Drawing.Size(129, 26);
            this.F3Destination_tBox.TabIndex = 52;
            // 
            // F2Destination_tBox
            // 
            this.F2Destination_tBox.Location = new System.Drawing.Point(358, 304);
            this.F2Destination_tBox.Name = "F2Destination_tBox";
            this.F2Destination_tBox.Size = new System.Drawing.Size(129, 26);
            this.F2Destination_tBox.TabIndex = 51;
            // 
            // F1Destination_tBox
            // 
            this.F1Destination_tBox.Location = new System.Drawing.Point(110, 304);
            this.F1Destination_tBox.Name = "F1Destination_tBox";
            this.F1Destination_tBox.Size = new System.Drawing.Size(129, 26);
            this.F1Destination_tBox.TabIndex = 50;
            // 
            // F3Date_tBox
            // 
            this.F3Date_tBox.Location = new System.Drawing.Point(592, 262);
            this.F3Date_tBox.Name = "F3Date_tBox";
            this.F3Date_tBox.Size = new System.Drawing.Size(129, 26);
            this.F3Date_tBox.TabIndex = 49;
            // 
            // F2Date_tBox
            // 
            this.F2Date_tBox.Location = new System.Drawing.Point(358, 259);
            this.F2Date_tBox.Name = "F2Date_tBox";
            this.F2Date_tBox.Size = new System.Drawing.Size(129, 26);
            this.F2Date_tBox.TabIndex = 48;
            // 
            // F1Date_tBox
            // 
            this.F1Date_tBox.Location = new System.Drawing.Point(111, 259);
            this.F1Date_tBox.Name = "F1Date_tBox";
            this.F1Date_tBox.Size = new System.Drawing.Size(129, 26);
            this.F1Date_tBox.TabIndex = 47;
            // 
            // Flight_3_tBox
            // 
            this.Flight_3_tBox.Location = new System.Drawing.Point(592, 209);
            this.Flight_3_tBox.Name = "Flight_3_tBox";
            this.Flight_3_tBox.Size = new System.Drawing.Size(129, 26);
            this.Flight_3_tBox.TabIndex = 46;
            // 
            // Flight_2_tBox
            // 
            this.Flight_2_tBox.Location = new System.Drawing.Point(358, 209);
            this.Flight_2_tBox.Name = "Flight_2_tBox";
            this.Flight_2_tBox.Size = new System.Drawing.Size(129, 26);
            this.Flight_2_tBox.TabIndex = 45;
            // 
            // Flight_1_tBox
            // 
            this.Flight_1_tBox.Location = new System.Drawing.Point(110, 209);
            this.Flight_1_tBox.Name = "Flight_1_tBox";
            this.Flight_1_tBox.Size = new System.Drawing.Size(129, 26);
            this.Flight_1_tBox.TabIndex = 44;
            // 
            // Origin_tBox
            // 
            this.Origin_tBox.Location = new System.Drawing.Point(230, 159);
            this.Origin_tBox.Name = "Origin_tBox";
            this.Origin_tBox.Size = new System.Drawing.Size(366, 26);
            this.Origin_tBox.TabIndex = 43;
            // 
            // PassagerN_tBox
            // 
            this.PassagerN_tBox.Location = new System.Drawing.Point(230, 120);
            this.PassagerN_tBox.Name = "PassagerN_tBox";
            this.PassagerN_tBox.Size = new System.Drawing.Size(366, 26);
            this.PassagerN_tBox.TabIndex = 42;
            // 
            // QFFT_tBox
            // 
            this.QFFT_tBox.Location = new System.Drawing.Point(230, 81);
            this.QFFT_tBox.Name = "QFFT_tBox";
            this.QFFT_tBox.Size = new System.Drawing.Size(366, 26);
            this.QFFT_tBox.TabIndex = 41;
            // 
            // QBTN_tBox
            // 
            this.QBTN_tBox.Location = new System.Drawing.Point(230, 44);
            this.QBTN_tBox.Name = "QBTN_tBox";
            this.QBTN_tBox.Size = new System.Drawing.Size(366, 26);
            this.QBTN_tBox.TabIndex = 40;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(6, 436);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 16);
            this.label24.TabIndex = 39;
            this.label24.Text = "User Memory";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(493, 349);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(96, 16);
            this.label23.TabIndex = 38;
            this.label23.Text = "Cabin Class";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(256, 349);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 16);
            this.label22.TabIndex = 37;
            this.label22.Text = "Cabin Class";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(493, 307);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 16);
            this.label21.TabIndex = 36;
            this.label21.Text = "Destination";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(256, 307);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 16);
            this.label20.TabIndex = 35;
            this.label20.Text = "Destination";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(493, 265);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 16);
            this.label19.TabIndex = 34;
            this.label19.Text = "Flight Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(256, 262);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 16);
            this.label18.TabIndex = 33;
            this.label18.Text = "Flight Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(493, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Flight 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(8, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Origin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(8, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Flight 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(8, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Flight Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(8, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Destination";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Cabin Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(256, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Flight 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Qantas Bag Tag Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(8, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Passager Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(8, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Qantas Frequent Flyer Tier";
            // 
            // EPCM_CLEAR_button
            // 
            this.EPCM_CLEAR_button.BackColor = System.Drawing.Color.SlateGray;
            this.EPCM_CLEAR_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EPCM_CLEAR_button.ForeColor = System.Drawing.Color.Gold;
            this.EPCM_CLEAR_button.Location = new System.Drawing.Point(589, 139);
            this.EPCM_CLEAR_button.Name = "EPCM_CLEAR_button";
            this.EPCM_CLEAR_button.Size = new System.Drawing.Size(160, 43);
            this.EPCM_CLEAR_button.TabIndex = 31;
            this.EPCM_CLEAR_button.Text = "EPC Memory Clear";
            this.EPCM_CLEAR_button.UseVisualStyleBackColor = false;
            this.EPCM_CLEAR_button.Click += new System.EventHandler(this.EPCM_CLEAR_button_Click);
            // 
            // USERM_CLEAR_button
            // 
            this.USERM_CLEAR_button.BackColor = System.Drawing.Color.SlateGray;
            this.USERM_CLEAR_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.USERM_CLEAR_button.ForeColor = System.Drawing.Color.Gold;
            this.USERM_CLEAR_button.Location = new System.Drawing.Point(532, 475);
            this.USERM_CLEAR_button.Name = "USERM_CLEAR_button";
            this.USERM_CLEAR_button.Size = new System.Drawing.Size(189, 43);
            this.USERM_CLEAR_button.TabIndex = 59;
            this.USERM_CLEAR_button.Text = "USER Memory Clear";
            this.USERM_CLEAR_button.UseVisualStyleBackColor = false;
            this.USERM_CLEAR_button.Click += new System.EventHandler(this.USERM_CLEAR_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1217, 775);
            this.Controls.Add(this.UserM_groupBox);
            this.Controls.Add(this.EPCM_groupBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Name = "Form1";
            this.Text = "UHF Reader Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.EPCM_groupBox.ResumeLayout(false);
            this.EPCM_groupBox.PerformLayout();
            this.UserM_groupBox.ResumeLayout(false);
            this.UserM_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lInfo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button bEpcWrite;
        private System.Windows.Forms.Button bEpcRead;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button bEpcInit;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox EPCM_groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox UserM_groupBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EPCM_tBox;
        private System.Windows.Forms.TextBox FlightDate_tBox;
        private System.Windows.Forms.TextBox LicensePN_tBox;
        private System.Windows.Forms.TextBox UserM_tBox;
        private System.Windows.Forms.TextBox F3CabinC_tBox;
        private System.Windows.Forms.TextBox F2CabinC_tBox;
        private System.Windows.Forms.TextBox F1CabinC_tBox;
        private System.Windows.Forms.TextBox F3Destination_tBox;
        private System.Windows.Forms.TextBox F2Destination_tBox;
        private System.Windows.Forms.TextBox F1Destination_tBox;
        private System.Windows.Forms.TextBox F3Date_tBox;
        private System.Windows.Forms.TextBox F2Date_tBox;
        private System.Windows.Forms.TextBox F1Date_tBox;
        private System.Windows.Forms.TextBox Flight_3_tBox;
        private System.Windows.Forms.TextBox Flight_2_tBox;
        private System.Windows.Forms.TextBox Flight_1_tBox;
        private System.Windows.Forms.TextBox Origin_tBox;
        private System.Windows.Forms.TextBox PassagerN_tBox;
        private System.Windows.Forms.TextBox QFFT_tBox;
        private System.Windows.Forms.TextBox QBTN_tBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Flight_Data_T;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button EPCM_CLEAR_button;
        private System.Windows.Forms.Button USERM_CLEAR_button;
    }
}

