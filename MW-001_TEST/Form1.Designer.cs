namespace MW_001_TEST
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.button_COM = new System.Windows.Forms.Button();
            this.textBox_USER = new System.Windows.Forms.TextBox();
            this.listBox_LOG = new System.Windows.Forms.ListBox();
            this.button_END = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_NAME = new System.Windows.Forms.TextBox();
            this.textBox_RECEIVEAD = new System.Windows.Forms.TextBox();
            this.textBox_RECEIVER = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_VENDERAD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_SIMNUM = new System.Windows.Forms.TextBox();
            this.textBox_terminalID = new System.Windows.Forms.TextBox();
            this.textBox_VENDER = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ADDRESS = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TELLNUM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CITYID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_TESTNUM = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_IMEI = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_DIST = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_VOLT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_TEMP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_STFW = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_STFWPASS = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_COUNT = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_WNC = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button_STFW = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox_memo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_TESTDIS = new System.Windows.Forms.TextBox();
            this.textBox_STFWVER = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_voltage = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Location = new System.Drawing.Point(399, 364);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(77, 20);
            this.comboBox_COM.TabIndex = 0;
            // 
            // button_COM
            // 
            this.button_COM.Location = new System.Drawing.Point(399, 390);
            this.button_COM.Name = "button_COM";
            this.button_COM.Size = new System.Drawing.Size(77, 22);
            this.button_COM.TabIndex = 1;
            this.button_COM.Text = "接続";
            this.button_COM.UseVisualStyleBackColor = true;
            this.button_COM.Click += new System.EventHandler(this.button_COM_Click);
            // 
            // textBox_USER
            // 
            this.textBox_USER.Location = new System.Drawing.Point(66, 19);
            this.textBox_USER.Name = "textBox_USER";
            this.textBox_USER.Size = new System.Drawing.Size(200, 19);
            this.textBox_USER.TabIndex = 2;
            this.textBox_USER.TabStop = false;
            this.textBox_USER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox_LOG
            // 
            this.listBox_LOG.FormattingEnabled = true;
            this.listBox_LOG.ItemHeight = 12;
            this.listBox_LOG.Location = new System.Drawing.Point(7, 364);
            this.listBox_LOG.Name = "listBox_LOG";
            this.listBox_LOG.Size = new System.Drawing.Size(386, 112);
            this.listBox_LOG.TabIndex = 3;
            this.listBox_LOG.TabStop = false;
            // 
            // button_END
            // 
            this.button_END.Location = new System.Drawing.Point(399, 479);
            this.button_END.Name = "button_END";
            this.button_END.Size = new System.Drawing.Size(77, 25);
            this.button_END.TabIndex = 6;
            this.button_END.Text = "終わり";
            this.button_END.UseVisualStyleBackColor = true;
            this.button_END.Click += new System.EventHandler(this.button_END_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "所有者";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_NAME);
            this.groupBox1.Controls.Add(this.textBox_RECEIVEAD);
            this.groupBox1.Controls.Add(this.textBox_RECEIVER);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_VENDERAD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_SIMNUM);
            this.groupBox1.Controls.Add(this.textBox_terminalID);
            this.groupBox1.Controls.Add(this.textBox_VENDER);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_ADDRESS);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_TELLNUM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_CITYID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_USER);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(197, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 268);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "水位計情報";
            // 
            // textBox_NAME
            // 
            this.textBox_NAME.Location = new System.Drawing.Point(66, 114);
            this.textBox_NAME.Name = "textBox_NAME";
            this.textBox_NAME.Size = new System.Drawing.Size(200, 19);
            this.textBox_NAME.TabIndex = 22;
            this.textBox_NAME.TabStop = false;
            // 
            // textBox_RECEIVEAD
            // 
            this.textBox_RECEIVEAD.Location = new System.Drawing.Point(66, 239);
            this.textBox_RECEIVEAD.Name = "textBox_RECEIVEAD";
            this.textBox_RECEIVEAD.Size = new System.Drawing.Size(200, 19);
            this.textBox_RECEIVEAD.TabIndex = 20;
            this.textBox_RECEIVEAD.TabStop = false;
            // 
            // textBox_RECEIVER
            // 
            this.textBox_RECEIVER.Location = new System.Drawing.Point(66, 214);
            this.textBox_RECEIVER.Name = "textBox_RECEIVER";
            this.textBox_RECEIVER.Size = new System.Drawing.Size(200, 19);
            this.textBox_RECEIVER.TabIndex = 18;
            this.textBox_RECEIVER.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "連絡先";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "送付先";
            // 
            // textBox_VENDERAD
            // 
            this.textBox_VENDERAD.Location = new System.Drawing.Point(66, 189);
            this.textBox_VENDERAD.Name = "textBox_VENDERAD";
            this.textBox_VENDERAD.Size = new System.Drawing.Size(200, 19);
            this.textBox_VENDERAD.TabIndex = 16;
            this.textBox_VENDERAD.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "連絡先";
            // 
            // textBox_SIMNUM
            // 
            this.textBox_SIMNUM.Location = new System.Drawing.Point(158, 69);
            this.textBox_SIMNUM.Name = "textBox_SIMNUM";
            this.textBox_SIMNUM.Size = new System.Drawing.Size(108, 19);
            this.textBox_SIMNUM.TabIndex = 0;
            this.textBox_SIMNUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_SIMNUM.TextChanged += new System.EventHandler(this.textBox_SIMNUM_TextChanged);
            // 
            // textBox_terminalID
            // 
            this.textBox_terminalID.Location = new System.Drawing.Point(172, 44);
            this.textBox_terminalID.Name = "textBox_terminalID";
            this.textBox_terminalID.Size = new System.Drawing.Size(94, 19);
            this.textBox_terminalID.TabIndex = 14;
            this.textBox_terminalID.TabStop = false;
            this.textBox_terminalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_VENDER
            // 
            this.textBox_VENDER.Location = new System.Drawing.Point(66, 164);
            this.textBox_VENDER.Name = "textBox_VENDER";
            this.textBox_VENDER.Size = new System.Drawing.Size(200, 19);
            this.textBox_VENDER.TabIndex = 12;
            this.textBox_VENDER.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "施工業者";
            // 
            // textBox_ADDRESS
            // 
            this.textBox_ADDRESS.Location = new System.Drawing.Point(66, 139);
            this.textBox_ADDRESS.Name = "textBox_ADDRESS";
            this.textBox_ADDRESS.Size = new System.Drawing.Size(200, 19);
            this.textBox_ADDRESS.TabIndex = 10;
            this.textBox_ADDRESS.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 11;
            this.label20.Text = "設置位置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "名称";
            // 
            // textBox_TELLNUM
            // 
            this.textBox_TELLNUM.Location = new System.Drawing.Point(66, 69);
            this.textBox_TELLNUM.Name = "textBox_TELLNUM";
            this.textBox_TELLNUM.Size = new System.Drawing.Size(86, 19);
            this.textBox_TELLNUM.TabIndex = 8;
            this.textBox_TELLNUM.TabStop = false;
            this.textBox_TELLNUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "送信局ID";
            // 
            // textBox_CITYID
            // 
            this.textBox_CITYID.Location = new System.Drawing.Point(66, 44);
            this.textBox_CITYID.Name = "textBox_CITYID";
            this.textBox_CITYID.Size = new System.Drawing.Size(100, 19);
            this.textBox_CITYID.TabIndex = 6;
            this.textBox_CITYID.TabStop = false;
            this.textBox_CITYID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "水位計ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_TESTNUM);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBox_IMEI);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox_DIST);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox_VOLT);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox_TEMP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_STFW);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 170);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "テスト結果";
            // 
            // textBox_TESTNUM
            // 
            this.textBox_TESTNUM.BackColor = System.Drawing.Color.White;
            this.textBox_TESTNUM.Location = new System.Drawing.Point(71, 19);
            this.textBox_TESTNUM.Name = "textBox_TESTNUM";
            this.textBox_TESTNUM.Size = new System.Drawing.Size(100, 19);
            this.textBox_TESTNUM.TabIndex = 1;
            this.textBox_TESTNUM.TabStop = false;
            this.textBox_TESTNUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_TESTNUM.TextChanged += new System.EventHandler(this.textBox_TESTNUM_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 12);
            this.label15.TabIndex = 37;
            this.label15.Text = "TELL NUM";
            // 
            // textBox_IMEI
            // 
            this.textBox_IMEI.Location = new System.Drawing.Point(71, 144);
            this.textBox_IMEI.Name = "textBox_IMEI";
            this.textBox_IMEI.Size = new System.Drawing.Size(100, 19);
            this.textBox_IMEI.TabIndex = 0;
            this.textBox_IMEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_IMEI.TextChanged += new System.EventHandler(this.textBox_IMEI_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "IMEI";
            // 
            // textBox_DIST
            // 
            this.textBox_DIST.Location = new System.Drawing.Point(71, 119);
            this.textBox_DIST.Name = "textBox_DIST";
            this.textBox_DIST.Size = new System.Drawing.Size(100, 19);
            this.textBox_DIST.TabIndex = 28;
            this.textBox_DIST.TabStop = false;
            this.textBox_DIST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "DIST";
            // 
            // textBox_VOLT
            // 
            this.textBox_VOLT.Location = new System.Drawing.Point(71, 94);
            this.textBox_VOLT.Name = "textBox_VOLT";
            this.textBox_VOLT.Size = new System.Drawing.Size(100, 19);
            this.textBox_VOLT.TabIndex = 26;
            this.textBox_VOLT.TabStop = false;
            this.textBox_VOLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "VOLT";
            // 
            // textBox_TEMP
            // 
            this.textBox_TEMP.Location = new System.Drawing.Point(71, 69);
            this.textBox_TEMP.Name = "textBox_TEMP";
            this.textBox_TEMP.Size = new System.Drawing.Size(100, 19);
            this.textBox_TEMP.TabIndex = 24;
            this.textBox_TEMP.TabStop = false;
            this.textBox_TEMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "TEMP";
            // 
            // textBox_STFW
            // 
            this.textBox_STFW.Location = new System.Drawing.Point(71, 44);
            this.textBox_STFW.Name = "textBox_STFW";
            this.textBox_STFW.Size = new System.Drawing.Size(100, 19);
            this.textBox_STFW.TabIndex = 22;
            this.textBox_STFW.TabStop = false;
            this.textBox_STFW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "STFW";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_STFWPASS);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.textBox_COUNT);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBox_WNC);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(7, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 72);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "情報";
            // 
            // textBox_STFWPASS
            // 
            this.textBox_STFWPASS.Location = new System.Drawing.Point(256, 43);
            this.textBox_STFWPASS.Name = "textBox_STFWPASS";
            this.textBox_STFWPASS.Size = new System.Drawing.Size(200, 19);
            this.textBox_STFWPASS.TabIndex = 43;
            this.textBox_STFWPASS.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(196, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 12);
            this.label19.TabIndex = 44;
            this.label19.Text = "ST FW";
            // 
            // textBox_COUNT
            // 
            this.textBox_COUNT.Location = new System.Drawing.Point(71, 28);
            this.textBox_COUNT.Name = "textBox_COUNT";
            this.textBox_COUNT.Size = new System.Drawing.Size(100, 19);
            this.textBox_COUNT.TabIndex = 42;
            this.textBox_COUNT.TabStop = false;
            this.textBox_COUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 41;
            this.label18.Text = "製造数";
            // 
            // textBox_WNC
            // 
            this.textBox_WNC.Location = new System.Drawing.Point(256, 18);
            this.textBox_WNC.Name = "textBox_WNC";
            this.textBox_WNC.Size = new System.Drawing.Size(200, 19);
            this.textBox_WNC.TabIndex = 22;
            this.textBox_WNC.TabStop = false;
            this.textBox_WNC.Text = "M14A6_v20.96.183151_02_00_00_00_96_LO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(196, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 12);
            this.label17.TabIndex = 23;
            this.label17.Text = "WNC FW";
            // 
            // button_STFW
            // 
            this.button_STFW.Location = new System.Drawing.Point(399, 418);
            this.button_STFW.Name = "button_STFW";
            this.button_STFW.Size = new System.Drawing.Size(77, 25);
            this.button_STFW.TabIndex = 2;
            this.button_STFW.Text = "FW書込";
            this.button_STFW.UseVisualStyleBackColor = true;
            this.button_STFW.Click += new System.EventHandler(this.button_STFW_Click);
            // 
            // textBox_memo
            // 
            this.textBox_memo.Location = new System.Drawing.Point(7, 482);
            this.textBox_memo.Name = "textBox_memo";
            this.textBox_memo.Size = new System.Drawing.Size(386, 19);
            this.textBox_memo.TabIndex = 45;
            this.textBox_memo.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 12);
            this.label16.TabIndex = 39;
            this.label16.Text = "テスト距離";
            // 
            // textBox_TESTDIS
            // 
            this.textBox_TESTDIS.Location = new System.Drawing.Point(71, 13);
            this.textBox_TESTDIS.Name = "textBox_TESTDIS";
            this.textBox_TESTDIS.Size = new System.Drawing.Size(100, 19);
            this.textBox_TESTDIS.TabIndex = 40;
            this.textBox_TESTDIS.TabStop = false;
            this.textBox_TESTDIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_STFWVER
            // 
            this.textBox_STFWVER.Location = new System.Drawing.Point(71, 38);
            this.textBox_STFWVER.Name = "textBox_STFWVER";
            this.textBox_STFWVER.Size = new System.Drawing.Size(100, 19);
            this.textBox_STFWVER.TabIndex = 46;
            this.textBox_STFWVER.TabStop = false;
            this.textBox_STFWVER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 12);
            this.label14.TabIndex = 45;
            this.label14.Text = "STFW VER.";
            // 
            // textBox_voltage
            // 
            this.textBox_voltage.Location = new System.Drawing.Point(71, 63);
            this.textBox_voltage.Name = "textBox_voltage";
            this.textBox_voltage.Size = new System.Drawing.Size(100, 19);
            this.textBox_voltage.TabIndex = 48;
            this.textBox_voltage.TabStop = false;
            this.textBox_voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 12);
            this.label21.TabIndex = 47;
            this.label21.Text = "BATTERY";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.textBox_voltage);
            this.groupBox4.Controls.Add(this.textBox_TESTDIS);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBox_STFWVER);
            this.groupBox4.Location = new System.Drawing.Point(7, 188);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 92);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "設定";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 511);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox_memo);
            this.Controls.Add(this.button_STFW);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_END);
            this.Controls.Add(this.listBox_LOG);
            this.Controls.Add(this.button_COM);
            this.Controls.Add(this.comboBox_COM);
            this.Name = "Form1";
            this.Text = "MW-001";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_COM;
        private System.Windows.Forms.Button button_COM;
        private System.Windows.Forms.TextBox textBox_USER;
        private System.Windows.Forms.ListBox listBox_LOG;
        private System.Windows.Forms.Button button_END;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_RECEIVEAD;
        private System.Windows.Forms.TextBox textBox_RECEIVER;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_VENDERAD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_SIMNUM;
        private System.Windows.Forms.TextBox textBox_terminalID;
        private System.Windows.Forms.TextBox textBox_VENDER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ADDRESS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TELLNUM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CITYID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_TESTNUM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_IMEI;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_DIST;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_VOLT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_TEMP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_STFW;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_WNC;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_COUNT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button_STFW;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox_STFWPASS;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_memo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_TESTDIS;
        private System.Windows.Forms.TextBox textBox_STFWVER;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_NAME;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_voltage;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

