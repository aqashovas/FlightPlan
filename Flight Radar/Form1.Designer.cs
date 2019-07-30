namespace Flight_Radar
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrF = new System.Windows.Forms.Timer(this.components);
            this.tmrP = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.pbLine = new System.Windows.Forms.PictureBox();
            this.pBfire = new System.Windows.Forms.PictureBox();
            this.pBAmbulance = new System.Windows.Forms.PictureBox();
            this.cmbtransportation = new System.Windows.Forms.ComboBox();
            this.tmrA = new System.Windows.Forms.Timer(this.components);
            this.timerE = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.tmr3 = new System.Windows.Forms.Timer(this.components);
            this.lblT = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblSF = new System.Windows.Forms.Label();
            this.lblWF = new System.Windows.Forms.Label();
            this.lblEF = new System.Windows.Forms.Label();
            this.lblNF = new System.Windows.Forms.Label();
            this.lblSA = new System.Windows.Forms.Label();
            this.lblWA = new System.Windows.Forms.Label();
            this.lblEA = new System.Windows.Forms.Label();
            this.lblNA = new System.Windows.Forms.Label();
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pBplane2 = new System.Windows.Forms.PictureBox();
            this.pBplane3 = new System.Windows.Forms.PictureBox();
            this.pBplane4 = new System.Windows.Forms.PictureBox();
            this.tmrP2 = new System.Windows.Forms.Timer(this.components);
            this.tmrP3 = new System.Windows.Forms.Timer(this.components);
            this.tmrP4 = new System.Windows.Forms.Timer(this.components);
            this.lblT2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblST2 = new System.Windows.Forms.Label();
            this.lblWT2 = new System.Windows.Forms.Label();
            this.lblET2 = new System.Windows.Forms.Label();
            this.lblNT2 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.lblT3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblST3 = new System.Windows.Forms.Label();
            this.lblWT3 = new System.Windows.Forms.Label();
            this.lblET3 = new System.Windows.Forms.Label();
            this.lblNT3 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.lblST4 = new System.Windows.Forms.Label();
            this.lblWT4 = new System.Windows.Forms.Label();
            this.lblET4 = new System.Windows.Forms.Label();
            this.lblNT4 = new System.Windows.Forms.Label();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblT4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAmbulance)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBplane2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBplane3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBplane4)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrF
            // 
            this.tmrF.Interval = 1000;
            this.tmrF.Tick += new System.EventHandler(this.tmrF_Tick);
            // 
            // tmrP
            // 
            this.tmrP.Interval = 1000;
            this.tmrP.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(243, 595);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(953, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(224, 46);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.BackColor = System.Drawing.Color.Transparent;
            this.lblN.Location = new System.Drawing.Point(892, 28);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(15, 13);
            this.lblN.TabIndex = 3;
            this.lblN.Text = "N";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.BackColor = System.Drawing.Color.Transparent;
            this.lblE.Location = new System.Drawing.Point(938, 62);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(14, 13);
            this.lblE.TabIndex = 4;
            this.lblE.Text = "E";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.BackColor = System.Drawing.Color.Transparent;
            this.lblS.Location = new System.Drawing.Point(892, 92);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(14, 13);
            this.lblS.TabIndex = 6;
            this.lblS.Text = "S";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.BackColor = System.Drawing.Color.Transparent;
            this.lblW.Location = new System.Drawing.Point(846, 60);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(18, 13);
            this.lblW.TabIndex = 5;
            this.lblW.Text = "W";
            // 
            // pbLine
            // 
            this.pbLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLine.BackgroundImage")));
            this.pbLine.Location = new System.Drawing.Point(0, 0);
            this.pbLine.Name = "pbLine";
            this.pbLine.Size = new System.Drawing.Size(847, 565);
            this.pbLine.TabIndex = 7;
            this.pbLine.TabStop = false;
            this.pbLine.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            this.pbLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            this.pbLine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbLine_MouseDoubleClick);
            // 
            // pBfire
            // 
            this.pBfire.BackColor = System.Drawing.Color.Transparent;
            this.pBfire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBfire.BackgroundImage")));
            this.pBfire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBfire.Location = new System.Drawing.Point(122, 605);
            this.pBfire.Name = "pBfire";
            this.pBfire.Size = new System.Drawing.Size(29, 15);
            this.pBfire.TabIndex = 8;
            this.pBfire.TabStop = false;
            // 
            // pBAmbulance
            // 
            this.pBAmbulance.BackColor = System.Drawing.Color.Transparent;
            this.pBAmbulance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBAmbulance.BackgroundImage")));
            this.pBAmbulance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBAmbulance.Location = new System.Drawing.Point(51, 607);
            this.pBAmbulance.Name = "pBAmbulance";
            this.pBAmbulance.Size = new System.Drawing.Size(29, 13);
            this.pBAmbulance.TabIndex = 9;
            this.pBAmbulance.TabStop = false;
            // 
            // cmbtransportation
            // 
            this.cmbtransportation.FormattingEnabled = true;
            this.cmbtransportation.Location = new System.Drawing.Point(853, 0);
            this.cmbtransportation.Name = "cmbtransportation";
            this.cmbtransportation.Size = new System.Drawing.Size(121, 21);
            this.cmbtransportation.TabIndex = 10;
            this.cmbtransportation.SelectionChangeCommitted += new System.EventHandler(this.cmbtransportation_SelectionChangeCommitted);
            // 
            // tmrA
            // 
            this.tmrA.Tick += new System.EventHandler(this.tmrA_Tick);
            // 
            // timerE
            // 
            this.timerE.Interval = 1000;
            this.timerE.Tick += new System.EventHandler(this.timerE_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(950, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Təyyarə";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(950, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yanğınsöndürən";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(953, 431);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(224, 48);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(950, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Təcili tibbi yardım";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(953, 541);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(224, 46);
            this.richTextBox3.TabIndex = 14;
            this.richTextBox3.Text = "";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Blue;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOk.Location = new System.Drawing.Point(980, 0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tmr2
            // 
            this.tmr2.Interval = 1000;
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // tmr3
            // 
            this.tmr3.Interval = 1000;
            this.tmr3.Tick += new System.EventHandler(this.tmr3_Tick);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(1012, 27);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(0, 13);
            this.lblT.TabIndex = 17;
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(1042, 415);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(0, 13);
            this.lblF.TabIndex = 18;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(1037, 521);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 19;
            // 
            // lblSF
            // 
            this.lblSF.AutoSize = true;
            this.lblSF.BackColor = System.Drawing.Color.Transparent;
            this.lblSF.Location = new System.Drawing.Point(892, 495);
            this.lblSF.Name = "lblSF";
            this.lblSF.Size = new System.Drawing.Size(14, 13);
            this.lblSF.TabIndex = 23;
            this.lblSF.Text = "S";
            // 
            // lblWF
            // 
            this.lblWF.AutoSize = true;
            this.lblWF.BackColor = System.Drawing.Color.Transparent;
            this.lblWF.Location = new System.Drawing.Point(846, 463);
            this.lblWF.Name = "lblWF";
            this.lblWF.Size = new System.Drawing.Size(18, 13);
            this.lblWF.TabIndex = 22;
            this.lblWF.Text = "W";
            // 
            // lblEF
            // 
            this.lblEF.AutoSize = true;
            this.lblEF.BackColor = System.Drawing.Color.Transparent;
            this.lblEF.Location = new System.Drawing.Point(938, 465);
            this.lblEF.Name = "lblEF";
            this.lblEF.Size = new System.Drawing.Size(14, 13);
            this.lblEF.TabIndex = 21;
            this.lblEF.Text = "E";
            // 
            // lblNF
            // 
            this.lblNF.AutoSize = true;
            this.lblNF.BackColor = System.Drawing.Color.Transparent;
            this.lblNF.Location = new System.Drawing.Point(892, 431);
            this.lblNF.Name = "lblNF";
            this.lblNF.Size = new System.Drawing.Size(15, 13);
            this.lblNF.TabIndex = 20;
            this.lblNF.Text = "N";
            // 
            // lblSA
            // 
            this.lblSA.AutoSize = true;
            this.lblSA.BackColor = System.Drawing.Color.Transparent;
            this.lblSA.Location = new System.Drawing.Point(892, 589);
            this.lblSA.Name = "lblSA";
            this.lblSA.Size = new System.Drawing.Size(14, 13);
            this.lblSA.TabIndex = 27;
            this.lblSA.Text = "S";
            // 
            // lblWA
            // 
            this.lblWA.AutoSize = true;
            this.lblWA.BackColor = System.Drawing.Color.Transparent;
            this.lblWA.Location = new System.Drawing.Point(846, 557);
            this.lblWA.Name = "lblWA";
            this.lblWA.Size = new System.Drawing.Size(18, 13);
            this.lblWA.TabIndex = 26;
            this.lblWA.Text = "W";
            // 
            // lblEA
            // 
            this.lblEA.AutoSize = true;
            this.lblEA.BackColor = System.Drawing.Color.Transparent;
            this.lblEA.Location = new System.Drawing.Point(938, 559);
            this.lblEA.Name = "lblEA";
            this.lblEA.Size = new System.Drawing.Size(14, 13);
            this.lblEA.TabIndex = 25;
            this.lblEA.Text = "E";
            // 
            // lblNA
            // 
            this.lblNA.AutoSize = true;
            this.lblNA.BackColor = System.Drawing.Color.Transparent;
            this.lblNA.Location = new System.Drawing.Point(892, 521);
            this.lblNA.Name = "lblNA";
            this.lblNA.Size = new System.Drawing.Size(15, 13);
            this.lblNA.TabIndex = 24;
            this.lblNA.Text = "N";
            // 
            // timerAlarm
            // 
            this.timerAlarm.Interval = 1000;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "san";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "m/san";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Hesabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(57, 58);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(55, 20);
            this.txtS.TabIndex = 33;
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(57, 29);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(55, 20);
            this.txtT.TabIndex = 32;
            // 
            // txtV
            // 
            this.txtV.Location = new System.Drawing.Point(57, 3);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(55, 20);
            this.txtV.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "s=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "t=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "v=";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtV);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtT);
            this.panel1.Location = new System.Drawing.Point(575, 569);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 144);
            this.panel1.TabIndex = 39;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Düstur";
            // 
            // pBplane2
            // 
            this.pBplane2.BackColor = System.Drawing.Color.Transparent;
            this.pBplane2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBplane2.BackgroundImage")));
            this.pBplane2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBplane2.Location = new System.Drawing.Point(302, 595);
            this.pBplane2.Name = "pBplane2";
            this.pBplane2.Size = new System.Drawing.Size(35, 25);
            this.pBplane2.TabIndex = 40;
            this.pBplane2.TabStop = false;
            // 
            // pBplane3
            // 
            this.pBplane3.BackColor = System.Drawing.Color.Transparent;
            this.pBplane3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBplane3.BackgroundImage")));
            this.pBplane3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBplane3.Location = new System.Drawing.Point(368, 595);
            this.pBplane3.Name = "pBplane3";
            this.pBplane3.Size = new System.Drawing.Size(35, 25);
            this.pBplane3.TabIndex = 41;
            this.pBplane3.TabStop = false;
            // 
            // pBplane4
            // 
            this.pBplane4.BackColor = System.Drawing.Color.Transparent;
            this.pBplane4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBplane4.BackgroundImage")));
            this.pBplane4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBplane4.Location = new System.Drawing.Point(444, 595);
            this.pBplane4.Name = "pBplane4";
            this.pBplane4.Size = new System.Drawing.Size(35, 25);
            this.pBplane4.TabIndex = 42;
            this.pBplane4.TabStop = false;
            // 
            // tmrP2
            // 
            this.tmrP2.Interval = 1000;
            this.tmrP2.Tick += new System.EventHandler(this.tmrP2_Tick);
            // 
            // tmrP3
            // 
            this.tmrP3.Interval = 1000;
            this.tmrP3.Tick += new System.EventHandler(this.tmrP3_Tick);
            // 
            // tmrP4
            // 
            this.tmrP4.Interval = 1000;
            this.tmrP4.Tick += new System.EventHandler(this.tmrP4_Tick);
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Location = new System.Drawing.Point(1012, 116);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(0, 13);
            this.lblT2.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(950, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Təyyarə";
            // 
            // lblST2
            // 
            this.lblST2.AutoSize = true;
            this.lblST2.BackColor = System.Drawing.Color.Transparent;
            this.lblST2.Location = new System.Drawing.Point(892, 181);
            this.lblST2.Name = "lblST2";
            this.lblST2.Size = new System.Drawing.Size(14, 13);
            this.lblST2.TabIndex = 47;
            this.lblST2.Text = "S";
            // 
            // lblWT2
            // 
            this.lblWT2.AutoSize = true;
            this.lblWT2.BackColor = System.Drawing.Color.Transparent;
            this.lblWT2.Location = new System.Drawing.Point(846, 149);
            this.lblWT2.Name = "lblWT2";
            this.lblWT2.Size = new System.Drawing.Size(18, 13);
            this.lblWT2.TabIndex = 46;
            this.lblWT2.Text = "W";
            // 
            // lblET2
            // 
            this.lblET2.AutoSize = true;
            this.lblET2.BackColor = System.Drawing.Color.Transparent;
            this.lblET2.Location = new System.Drawing.Point(938, 151);
            this.lblET2.Name = "lblET2";
            this.lblET2.Size = new System.Drawing.Size(14, 13);
            this.lblET2.TabIndex = 45;
            this.lblET2.Text = "E";
            // 
            // lblNT2
            // 
            this.lblNT2.AutoSize = true;
            this.lblNT2.BackColor = System.Drawing.Color.Transparent;
            this.lblNT2.Location = new System.Drawing.Point(892, 117);
            this.lblNT2.Name = "lblNT2";
            this.lblNT2.Size = new System.Drawing.Size(15, 13);
            this.lblNT2.TabIndex = 44;
            this.lblNT2.Text = "N";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(953, 132);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(224, 46);
            this.richTextBox4.TabIndex = 43;
            this.richTextBox4.Text = "";
            // 
            // lblT3
            // 
            this.lblT3.AutoSize = true;
            this.lblT3.Location = new System.Drawing.Point(1012, 202);
            this.lblT3.Name = "lblT3";
            this.lblT3.Size = new System.Drawing.Size(0, 13);
            this.lblT3.TabIndex = 56;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(950, 202);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Təyyarə";
            // 
            // lblST3
            // 
            this.lblST3.AutoSize = true;
            this.lblST3.BackColor = System.Drawing.Color.Transparent;
            this.lblST3.Location = new System.Drawing.Point(892, 267);
            this.lblST3.Name = "lblST3";
            this.lblST3.Size = new System.Drawing.Size(14, 13);
            this.lblST3.TabIndex = 54;
            this.lblST3.Text = "S";
            // 
            // lblWT3
            // 
            this.lblWT3.AutoSize = true;
            this.lblWT3.BackColor = System.Drawing.Color.Transparent;
            this.lblWT3.Location = new System.Drawing.Point(846, 235);
            this.lblWT3.Name = "lblWT3";
            this.lblWT3.Size = new System.Drawing.Size(18, 13);
            this.lblWT3.TabIndex = 53;
            this.lblWT3.Text = "W";
            // 
            // lblET3
            // 
            this.lblET3.AutoSize = true;
            this.lblET3.BackColor = System.Drawing.Color.Transparent;
            this.lblET3.Location = new System.Drawing.Point(938, 237);
            this.lblET3.Name = "lblET3";
            this.lblET3.Size = new System.Drawing.Size(14, 13);
            this.lblET3.TabIndex = 52;
            this.lblET3.Text = "E";
            // 
            // lblNT3
            // 
            this.lblNT3.AutoSize = true;
            this.lblNT3.BackColor = System.Drawing.Color.Transparent;
            this.lblNT3.Location = new System.Drawing.Point(892, 203);
            this.lblNT3.Name = "lblNT3";
            this.lblNT3.Size = new System.Drawing.Size(15, 13);
            this.lblNT3.TabIndex = 51;
            this.lblNT3.Text = "N";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(953, 218);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(224, 46);
            this.richTextBox5.TabIndex = 50;
            this.richTextBox5.Text = "";
            // 
            // lblST4
            // 
            this.lblST4.AutoSize = true;
            this.lblST4.BackColor = System.Drawing.Color.Transparent;
            this.lblST4.Location = new System.Drawing.Point(892, 371);
            this.lblST4.Name = "lblST4";
            this.lblST4.Size = new System.Drawing.Size(14, 13);
            this.lblST4.TabIndex = 61;
            this.lblST4.Text = "S";
            // 
            // lblWT4
            // 
            this.lblWT4.AutoSize = true;
            this.lblWT4.BackColor = System.Drawing.Color.Transparent;
            this.lblWT4.Location = new System.Drawing.Point(846, 339);
            this.lblWT4.Name = "lblWT4";
            this.lblWT4.Size = new System.Drawing.Size(18, 13);
            this.lblWT4.TabIndex = 60;
            this.lblWT4.Text = "W";
            // 
            // lblET4
            // 
            this.lblET4.AutoSize = true;
            this.lblET4.BackColor = System.Drawing.Color.Transparent;
            this.lblET4.Location = new System.Drawing.Point(938, 341);
            this.lblET4.Name = "lblET4";
            this.lblET4.Size = new System.Drawing.Size(14, 13);
            this.lblET4.TabIndex = 59;
            this.lblET4.Text = "E";
            // 
            // lblNT4
            // 
            this.lblNT4.AutoSize = true;
            this.lblNT4.BackColor = System.Drawing.Color.Transparent;
            this.lblNT4.Location = new System.Drawing.Point(892, 307);
            this.lblNT4.Name = "lblNT4";
            this.lblNT4.Size = new System.Drawing.Size(15, 13);
            this.lblNT4.TabIndex = 58;
            this.lblNT4.Text = "N";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(953, 322);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(224, 46);
            this.richTextBox6.TabIndex = 57;
            this.richTextBox6.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(950, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Təyyarə";
            // 
            // lblT4
            // 
            this.lblT4.AutoSize = true;
            this.lblT4.Location = new System.Drawing.Point(1001, 307);
            this.lblT4.Name = "lblT4";
            this.lblT4.Size = new System.Drawing.Size(0, 13);
            this.lblT4.TabIndex = 63;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(161, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 21);
            this.comboBox2.TabIndex = 64;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.lblT4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblST4);
            this.Controls.Add(this.lblWT4);
            this.Controls.Add(this.lblET4);
            this.Controls.Add(this.lblNT4);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.lblT3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblST3);
            this.Controls.Add(this.lblWT3);
            this.Controls.Add(this.lblET3);
            this.Controls.Add(this.lblNT3);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.lblT2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblST2);
            this.Controls.Add(this.lblWT2);
            this.Controls.Add(this.lblET2);
            this.Controls.Add(this.lblNT2);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.pBplane4);
            this.Controls.Add(this.pBplane3);
            this.Controls.Add(this.pBplane2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSA);
            this.Controls.Add(this.lblWA);
            this.Controls.Add(this.lblEA);
            this.Controls.Add(this.lblNA);
            this.Controls.Add(this.lblSF);
            this.Controls.Add(this.lblWF);
            this.Controls.Add(this.lblEF);
            this.Controls.Add(this.lblNF);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbtransportation);
            this.Controls.Add(this.pBAmbulance);
            this.Controls.Add(this.pBfire);
            this.Controls.Add(this.pbLine);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAmbulance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBplane2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBplane3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBplane4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrF;
        private System.Windows.Forms.Timer tmrP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.PictureBox pbLine;
        private System.Windows.Forms.PictureBox pBfire;
        private System.Windows.Forms.PictureBox pBAmbulance;
        private System.Windows.Forms.ComboBox cmbtransportation;
        private System.Windows.Forms.Timer tmrA;
        private System.Windows.Forms.Timer timerE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Timer tmr2;
        private System.Windows.Forms.Timer tmr3;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblSF;
        private System.Windows.Forms.Label lblWF;
        private System.Windows.Forms.Label lblEF;
        private System.Windows.Forms.Label lblNF;
        private System.Windows.Forms.Label lblSA;
        private System.Windows.Forms.Label lblWA;
        private System.Windows.Forms.Label lblEA;
        private System.Windows.Forms.Label lblNA;
        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pBplane2;
        private System.Windows.Forms.PictureBox pBplane3;
        private System.Windows.Forms.PictureBox pBplane4;
        private System.Windows.Forms.Timer tmrP2;
        private System.Windows.Forms.Timer tmrP3;
        private System.Windows.Forms.Timer tmrP4;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblST2;
        private System.Windows.Forms.Label lblWT2;
        private System.Windows.Forms.Label lblET2;
        private System.Windows.Forms.Label lblNT2;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label lblT3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblST3;
        private System.Windows.Forms.Label lblWT3;
        private System.Windows.Forms.Label lblET3;
        private System.Windows.Forms.Label lblNT3;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label lblST4;
        private System.Windows.Forms.Label lblWT4;
        private System.Windows.Forms.Label lblET4;
        private System.Windows.Forms.Label lblNT4;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblT4;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

