namespace ECTunes.H_CAN_tester {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbbCONPort = new System.Windows.Forms.ComboBox();
            this.lblCONPort = new System.Windows.Forms.Label();
            this.btnCONRefresh = new System.Windows.Forms.Button();
            this.cbbCONBaudrate = new System.Windows.Forms.ComboBox();
            this.lblCONBaudrate = new System.Windows.Forms.Label();
            this.cbbCONType = new System.Windows.Forms.ComboBox();
            this.lblCONType = new System.Windows.Forms.Label();
            this.btnCONInit = new System.Windows.Forms.Button();
            this.btnCONRelease = new System.Windows.Forms.Button();
            this.gbxConnection = new System.Windows.Forms.GroupBox();
            this.lblCONDevice = new System.Windows.Forms.Label();
            this.cbbCONDevice = new System.Windows.Forms.ComboBox();
            this.chkVolFromXml = new System.Windows.Forms.CheckBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.gbxSendData = new System.Windows.Forms.GroupBox();
            this.btnSDSend = new System.Windows.Forms.Button();
            this.chkSDExtended = new System.Windows.Forms.CheckBox();
            this.lblSDData = new System.Windows.Forms.Label();
            this.lblSDLength = new System.Windows.Forms.Label();
            this.lblSDID = new System.Windows.Forms.Label();
            this.nudSDLength = new System.Windows.Forms.NumericUpDown();
            this.tbxSDB7 = new System.Windows.Forms.TextBox();
            this.tbxSDB6 = new System.Windows.Forms.TextBox();
            this.tbxSDB5 = new System.Windows.Forms.TextBox();
            this.tbxSDB4 = new System.Windows.Forms.TextBox();
            this.tbxSDB3 = new System.Windows.Forms.TextBox();
            this.tbxSDB2 = new System.Windows.Forms.TextBox();
            this.tbxSDB1 = new System.Windows.Forms.TextBox();
            this.tbxSDB0 = new System.Windows.Forms.TextBox();
            this.tbxSDID = new System.Windows.Forms.TextBox();
            this.gbxControls = new System.Windows.Forms.GroupBox();
            this.btnSDAdvanced = new System.Windows.Forms.Button();
            this.btnCTRLLoadFile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCTRLControls = new System.Windows.Forms.TabPage();
            this.pnlCTRLControls = new System.Windows.Forms.Panel();
            this.pnlCTRLSIndexF = new System.Windows.Forms.Panel();
            this.lblCTRLSIndexF = new System.Windows.Forms.Label();
            this.nudCTRLSIndexF = new System.Windows.Forms.NumericUpDown();
            this.pnlCTRLIndicator = new System.Windows.Forms.Panel();
            this.lblCTRLIndicator = new System.Windows.Forms.Label();
            this.btnCTRLIndicatorR = new System.Windows.Forms.Button();
            this.btnCTRLIndicatorL = new System.Windows.Forms.Button();
            this.btnCTRLIndicatorOff = new System.Windows.Forms.Button();
            this.pnlCTRLThrottle = new System.Windows.Forms.Panel();
            this.btnCTRLThrottle50percent = new System.Windows.Forms.Button();
            this.btnCTRLThrottle100percent = new System.Windows.Forms.Button();
            this.btnCTRLThrottle75percent = new System.Windows.Forms.Button();
            this.btnCTRLThrottle25percent = new System.Windows.Forms.Button();
            this.btnCTRLThrottle0percent = new System.Windows.Forms.Button();
            this.lblCTRLThrottle = new System.Windows.Forms.Label();
            this.lblCTRLThrottleValue = new System.Windows.Forms.Label();
            this.tkbCTRLThrottle = new System.Windows.Forms.TrackBar();
            this.pnlCTRLSIndexR = new System.Windows.Forms.Panel();
            this.lblCTRLSIndexR = new System.Windows.Forms.Label();
            this.nudCTRLSIndexR = new System.Windows.Forms.NumericUpDown();
            this.pnlCTRLVolRear = new System.Windows.Forms.Panel();
            this.btnCTRLVolRear50percent = new System.Windows.Forms.Button();
            this.btnCTRLVolRear100percent = new System.Windows.Forms.Button();
            this.btnCTRLVolRear75percent = new System.Windows.Forms.Button();
            this.btnCTRLVolRear25percent = new System.Windows.Forms.Button();
            this.btnCTRLVolRear0percent = new System.Windows.Forms.Button();
            this.lblCTRLVolRear = new System.Windows.Forms.Label();
            this.tkbCTRLVolRear = new System.Windows.Forms.TrackBar();
            this.lblCTRLVolRearValue = new System.Windows.Forms.Label();
            this.pnlCTRLVolFront = new System.Windows.Forms.Panel();
            this.btnCTRLVolFront50percent = new System.Windows.Forms.Button();
            this.btnCTRLVolFront100percent = new System.Windows.Forms.Button();
            this.btnCTRLVolFront75percent = new System.Windows.Forms.Button();
            this.btnCTRLVolFront25percent = new System.Windows.Forms.Button();
            this.btnCTRLVolFront0percent = new System.Windows.Forms.Button();
            this.tkbCTRLVolFront = new System.Windows.Forms.TrackBar();
            this.lblCTRLVolFront = new System.Windows.Forms.Label();
            this.lblCTRLVolFrontValue = new System.Windows.Forms.Label();
            this.pnlCTRLRpm = new System.Windows.Forms.Panel();
            this.btnCTRLRpm200percent = new System.Windows.Forms.Button();
            this.btnCTRLRpm100percent = new System.Windows.Forms.Button();
            this.btnCTRLRpm110percent = new System.Windows.Forms.Button();
            this.btnCTRLRpm90percent = new System.Windows.Forms.Button();
            this.btnCTRLRpm10percent = new System.Windows.Forms.Button();
            this.btnCTRLRpm0percent = new System.Windows.Forms.Button();
            this.lblCTRLRpm = new System.Windows.Forms.Label();
            this.tkbCTRLRpm = new System.Windows.Forms.TrackBar();
            this.lblCTRLRpmValue = new System.Windows.Forms.Label();
            this.chkCTRLIce = new System.Windows.Forms.CheckBox();
            this.chkCTRLReady = new System.Windows.Forms.CheckBox();
            this.lblCTRLSIndex = new System.Windows.Forms.Label();
            this.lblIngition = new System.Windows.Forms.Label();
            this.btnCTRLOff = new System.Windows.Forms.Button();
            this.btnCTRLOn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCTRLGear = new System.Windows.Forms.Label();
            this.btnCTRLDrive = new System.Windows.Forms.Button();
            this.btnCTRLNeutral = new System.Windows.Forms.Button();
            this.btnCTRLReverse = new System.Windows.Forms.Button();
            this.tbxCTRLGearValue = new System.Windows.Forms.TextBox();
            this.lblCTRLSelCar = new System.Windows.Forms.Label();
            this.cbbCTRLSelCar = new System.Windows.Forms.ComboBox();
            this.tabCTRLtbxXml = new System.Windows.Forms.TabPage();
            this.tbxCTRLXml = new System.Windows.Forms.TextBox();
            this.ttCTRLTkb = new System.Windows.Forms.ToolTip(this.components);
            this.tbxCanMsg = new System.Windows.Forms.TextBox();
            this.lblCanMsg = new System.Windows.Forms.Label();
            this.pnlCanMsg = new System.Windows.Forms.Panel();
            this.gbxConnection.SuspendLayout();
            this.gbxSendData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSDLength)).BeginInit();
            this.gbxControls.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCTRLControls.SuspendLayout();
            this.pnlCTRLControls.SuspendLayout();
            this.pnlCTRLSIndexF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCTRLSIndexF)).BeginInit();
            this.pnlCTRLIndicator.SuspendLayout();
            this.pnlCTRLThrottle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCTRLThrottle)).BeginInit();
            this.pnlCTRLSIndexR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCTRLSIndexR)).BeginInit();
            this.pnlCTRLVolRear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCTRLVolRear)).BeginInit();
            this.pnlCTRLVolFront.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCTRLVolFront)).BeginInit();
            this.pnlCTRLRpm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCTRLRpm)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabCTRLtbxXml.SuspendLayout();
            this.pnlCanMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbCONPort
            // 
            this.cbbCONPort.FormattingEnabled = true;
            this.cbbCONPort.Location = new System.Drawing.Point(103, 36);
            this.cbbCONPort.Name = "cbbCONPort";
            this.cbbCONPort.Size = new System.Drawing.Size(121, 21);
            this.cbbCONPort.TabIndex = 0;
            this.cbbCONPort.Text = "0";
            // 
            // lblCONPort
            // 
            this.lblCONPort.AutoSize = true;
            this.lblCONPort.Location = new System.Drawing.Point(103, 20);
            this.lblCONPort.Name = "lblCONPort";
            this.lblCONPort.Size = new System.Drawing.Size(53, 13);
            this.lblCONPort.TabIndex = 1;
            this.lblCONPort.Text = "COM Port";
            // 
            // btnCONRefresh
            // 
            this.btnCONRefresh.Location = new System.Drawing.Point(227, 33);
            this.btnCONRefresh.Name = "btnCONRefresh";
            this.btnCONRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnCONRefresh.TabIndex = 1;
            this.btnCONRefresh.Text = "Refresh";
            this.btnCONRefresh.UseVisualStyleBackColor = true;
            this.btnCONRefresh.Click += new System.EventHandler(this.btnCONRefresh_Click);
            // 
            // cbbCONBaudrate
            // 
            this.cbbCONBaudrate.FormattingEnabled = true;
            this.cbbCONBaudrate.Location = new System.Drawing.Point(308, 36);
            this.cbbCONBaudrate.Name = "cbbCONBaudrate";
            this.cbbCONBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cbbCONBaudrate.TabIndex = 2;
            // 
            // lblCONBaudrate
            // 
            this.lblCONBaudrate.AutoSize = true;
            this.lblCONBaudrate.Location = new System.Drawing.Point(308, 20);
            this.lblCONBaudrate.Name = "lblCONBaudrate";
            this.lblCONBaudrate.Size = new System.Drawing.Size(50, 13);
            this.lblCONBaudrate.TabIndex = 4;
            this.lblCONBaudrate.Text = "Baudrate";
            // 
            // cbbCONType
            // 
            this.cbbCONType.FormattingEnabled = true;
            this.cbbCONType.Location = new System.Drawing.Point(435, 36);
            this.cbbCONType.Name = "cbbCONType";
            this.cbbCONType.Size = new System.Drawing.Size(36, 21);
            this.cbbCONType.TabIndex = 3;
            // 
            // lblCONType
            // 
            this.lblCONType.AutoSize = true;
            this.lblCONType.Location = new System.Drawing.Point(432, 20);
            this.lblCONType.Name = "lblCONType";
            this.lblCONType.Size = new System.Drawing.Size(31, 13);
            this.lblCONType.TabIndex = 6;
            this.lblCONType.Text = "Type";
            // 
            // btnCONInit
            // 
            this.btnCONInit.Location = new System.Drawing.Point(484, 34);
            this.btnCONInit.Name = "btnCONInit";
            this.btnCONInit.Size = new System.Drawing.Size(75, 23);
            this.btnCONInit.TabIndex = 4;
            this.btnCONInit.Text = "Initialize";
            this.btnCONInit.UseVisualStyleBackColor = true;
            this.btnCONInit.Click += new System.EventHandler(this.btnCONInit_Click);
            // 
            // btnCONRelease
            // 
            this.btnCONRelease.Enabled = false;
            this.btnCONRelease.Location = new System.Drawing.Point(565, 34);
            this.btnCONRelease.Name = "btnCONRelease";
            this.btnCONRelease.Size = new System.Drawing.Size(75, 23);
            this.btnCONRelease.TabIndex = 5;
            this.btnCONRelease.Text = "Release";
            this.btnCONRelease.UseVisualStyleBackColor = true;
            this.btnCONRelease.Click += new System.EventHandler(this.btnCONRelease_Click);
            // 
            // gbxConnection
            // 
            this.gbxConnection.Controls.Add(this.lblCONDevice);
            this.gbxConnection.Controls.Add(this.cbbCONDevice);
            this.gbxConnection.Controls.Add(this.chkVolFromXml);
            this.gbxConnection.Controls.Add(this.chkDebug);
            this.gbxConnection.Controls.Add(this.lblCONType);
            this.gbxConnection.Controls.Add(this.btnCONRelease);
            this.gbxConnection.Controls.Add(this.lblCONBaudrate);
            this.gbxConnection.Controls.Add(this.cbbCONPort);
            this.gbxConnection.Controls.Add(this.btnCONInit);
            this.gbxConnection.Controls.Add(this.lblCONPort);
            this.gbxConnection.Controls.Add(this.btnCONRefresh);
            this.gbxConnection.Controls.Add(this.cbbCONType);
            this.gbxConnection.Controls.Add(this.cbbCONBaudrate);
            this.gbxConnection.Location = new System.Drawing.Point(12, 12);
            this.gbxConnection.Name = "gbxConnection";
            this.gbxConnection.Size = new System.Drawing.Size(658, 75);
            this.gbxConnection.TabIndex = 0;
            this.gbxConnection.TabStop = false;
            this.gbxConnection.Text = "Connection";
            // 
            // lblCONDevice
            // 
            this.lblCONDevice.AutoSize = true;
            this.lblCONDevice.Location = new System.Drawing.Point(16, 19);
            this.lblCONDevice.Name = "lblCONDevice";
            this.lblCONDevice.Size = new System.Drawing.Size(41, 13);
            this.lblCONDevice.TabIndex = 12;
            this.lblCONDevice.Text = "Device";
            // 
            // cbbCONDevice
            // 
            this.cbbCONDevice.Enabled = false;
            this.cbbCONDevice.FormattingEnabled = true;
            this.cbbCONDevice.Items.AddRange(new object[] {
            "H-CAN",
            "PEAK"});
            this.cbbCONDevice.Location = new System.Drawing.Point(16, 36);
            this.cbbCONDevice.Name = "cbbCONDevice";
            this.cbbCONDevice.Size = new System.Drawing.Size(81, 21);
            this.cbbCONDevice.TabIndex = 11;
            // 
            // chkVolFromXml
            // 
            this.chkVolFromXml.AutoSize = true;
            this.chkVolFromXml.Location = new System.Drawing.Point(424, 6);
            this.chkVolFromXml.Name = "chkVolFromXml";
            this.chkVolFromXml.Size = new System.Drawing.Size(92, 17);
            this.chkVolFromXml.TabIndex = 10;
            this.chkVolFromXml.Text = "Vol From XML";
            this.chkVolFromXml.UseVisualStyleBackColor = true;
            this.chkVolFromXml.CheckedChanged += new System.EventHandler(this.chkVolFromXml_CheckedChanged);
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(572, 6);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(58, 17);
            this.chkDebug.TabIndex = 9;
            this.chkDebug.Text = "Debug";
            this.chkDebug.UseVisualStyleBackColor = true;
            this.chkDebug.Visible = false;
            this.chkDebug.CheckedChanged += new System.EventHandler(this.chkDebug_CheckedChanged);
            // 
            // gbxSendData
            // 
            this.gbxSendData.Controls.Add(this.btnSDSend);
            this.gbxSendData.Controls.Add(this.chkSDExtended);
            this.gbxSendData.Controls.Add(this.lblSDData);
            this.gbxSendData.Controls.Add(this.lblSDLength);
            this.gbxSendData.Controls.Add(this.lblSDID);
            this.gbxSendData.Controls.Add(this.nudSDLength);
            this.gbxSendData.Controls.Add(this.tbxSDB7);
            this.gbxSendData.Controls.Add(this.tbxSDB6);
            this.gbxSendData.Controls.Add(this.tbxSDB5);
            this.gbxSendData.Controls.Add(this.tbxSDB4);
            this.gbxSendData.Controls.Add(this.tbxSDB3);
            this.gbxSendData.Controls.Add(this.tbxSDB2);
            this.gbxSendData.Controls.Add(this.tbxSDB1);
            this.gbxSendData.Controls.Add(this.tbxSDB0);
            this.gbxSendData.Controls.Add(this.tbxSDID);
            this.gbxSendData.Location = new System.Drawing.Point(12, 94);
            this.gbxSendData.Name = "gbxSendData";
            this.gbxSendData.Size = new System.Drawing.Size(658, 81);
            this.gbxSendData.TabIndex = 1;
            this.gbxSendData.TabStop = false;
            this.gbxSendData.Text = "Send Data";
            // 
            // btnSDSend
            // 
            this.btnSDSend.Location = new System.Drawing.Point(565, 47);
            this.btnSDSend.Name = "btnSDSend";
            this.btnSDSend.Size = new System.Drawing.Size(75, 23);
            this.btnSDSend.TabIndex = 11;
            this.btnSDSend.Text = "Send";
            this.btnSDSend.UseVisualStyleBackColor = true;
            this.btnSDSend.Click += new System.EventHandler(this.btnSDSend_Click);
            // 
            // chkSDExtended
            // 
            this.chkSDExtended.AutoSize = true;
            this.chkSDExtended.Location = new System.Drawing.Point(91, 49);
            this.chkSDExtended.Name = "chkSDExtended";
            this.chkSDExtended.Size = new System.Drawing.Size(71, 17);
            this.chkSDExtended.TabIndex = 1;
            this.chkSDExtended.Text = "Extended";
            this.chkSDExtended.UseVisualStyleBackColor = true;
            // 
            // lblSDData
            // 
            this.lblSDData.AutoSize = true;
            this.lblSDData.Location = new System.Drawing.Point(270, 30);
            this.lblSDData.Name = "lblSDData";
            this.lblSDData.Size = new System.Drawing.Size(80, 13);
            this.lblSDData.TabIndex = 12;
            this.lblSDData.Text = "Data ( bit 0...7 )";
            // 
            // lblSDLength
            // 
            this.lblSDLength.AutoSize = true;
            this.lblSDLength.Location = new System.Drawing.Point(193, 30);
            this.lblSDLength.Name = "lblSDLength";
            this.lblSDLength.Size = new System.Drawing.Size(40, 13);
            this.lblSDLength.TabIndex = 11;
            this.lblSDLength.Text = "Length";
            // 
            // lblSDID
            // 
            this.lblSDID.AutoSize = true;
            this.lblSDID.Location = new System.Drawing.Point(16, 31);
            this.lblSDID.Name = "lblSDID";
            this.lblSDID.Size = new System.Drawing.Size(46, 13);
            this.lblSDID.TabIndex = 10;
            this.lblSDID.Text = "ID (Hex)";
            // 
            // nudSDLength
            // 
            this.nudSDLength.Location = new System.Drawing.Point(193, 47);
            this.nudSDLength.Name = "nudSDLength";
            this.nudSDLength.Size = new System.Drawing.Size(47, 20);
            this.nudSDLength.TabIndex = 2;
            this.nudSDLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // tbxSDB7
            // 
            this.tbxSDB7.Location = new System.Drawing.Point(445, 47);
            this.tbxSDB7.Name = "tbxSDB7";
            this.tbxSDB7.Size = new System.Drawing.Size(19, 20);
            this.tbxSDB7.TabIndex = 10;
            this.tbxSDB7.Text = "00";
            // 
            // tbxSDB6
            // 
            this.tbxSDB6.Location = new System.Drawing.Point(420, 47);
            this.tbxSDB6.Name = "tbxSDB6";
            this.tbxSDB6.Size = new System.Drawing.Size(19, 20);
            this.tbxSDB6.TabIndex = 9;
            this.tbxSDB6.Text = "00";
            // 
            // tbxSDB5
            // 
            this.tbxSDB5.Location = new System.Drawing.Point(395, 47);
            this.tbxSDB5.Name = "tbxSDB5";
            this.tbxSDB5.Size = new System.Drawing.Size(19, 20);
            this.tbxSDB5.TabIndex = 8;
            this.tbxSDB5.Text = "00";
            // 
            // tbxSDB4
            // 
            this.tbxSDB4.Location = new System.Drawing.Point(370, 47);
            this.tbxSDB4.Name = "tbxSDB4";
            this.tbxSDB4.Size = new System.Drawing.Size(19, 20);
            this.tbxSDB4.TabIndex = 7;
            this.tbxSDB4.Text = "00";
            // 
            // tbxSDB3
            // 
            this.tbxSDB3.Location = new System.Drawing.Point(345, 47);
            this.tbxSDB3.Name = "tbxSDB3";
            this.tbxSDB3.Size = new System.Drawing.Size(19, 20);
            this.tbxSDB3.TabIndex = 6;
            this.tbxSDB3.Text = "00";
            // 
            // tbxSDB2
            // 
            this.tbxSDB2.Location = new System.Drawing.Point(320, 47);
            this.tbxSDB2.Name = "tbxSDB2";
            this.tbxSDB2.Size = new System.Drawing.Size(19, 20);
            this.tbxSDB2.TabIndex = 5;
            this.tbxSDB2.Text = "00";
            // 
            // tbxSDB1
            // 
            this.tbxSDB1.Location = new System.Drawing.Point(295, 47);
            this.tbxSDB1.Name = "tbxSDB1";
            this.tbxSDB1.Size = new System.Drawing.Size(19, 20);
            this.tbxSDB1.TabIndex = 4;
            this.tbxSDB1.Text = "00";
            // 
            // tbxSDB0
            // 
            this.tbxSDB0.Location = new System.Drawing.Point(270, 47);
            this.tbxSDB0.Name = "tbxSDB0";
            this.tbxSDB0.Size = new System.Drawing.Size(19, 20);
            this.tbxSDB0.TabIndex = 3;
            this.tbxSDB0.Text = "00";
            // 
            // tbxSDID
            // 
            this.tbxSDID.Location = new System.Drawing.Point(16, 47);
            this.tbxSDID.Name = "tbxSDID";
            this.tbxSDID.Size = new System.Drawing.Size(68, 20);
            this.tbxSDID.TabIndex = 0;
            // 
            // gbxControls
            // 
            this.gbxControls.Controls.Add(this.btnSDAdvanced);
            this.gbxControls.Controls.Add(this.btnCTRLLoadFile);
            this.gbxControls.Controls.Add(this.tabControl1);
            this.gbxControls.Location = new System.Drawing.Point(12, 182);
            this.gbxControls.Name = "gbxControls";
            this.gbxControls.Size = new System.Drawing.Size(658, 328);
            this.gbxControls.TabIndex = 2;
            this.gbxControls.TabStop = false;
            this.gbxControls.Text = "Controls";
            // 
            // btnSDAdvanced
            // 
            this.btnSDAdvanced.Location = new System.Drawing.Point(445, 20);
            this.btnSDAdvanced.Name = "btnSDAdvanced";
            this.btnSDAdvanced.Size = new System.Drawing.Size(92, 23);
            this.btnSDAdvanced.TabIndex = 0;
            this.btnSDAdvanced.Text = "Simple";
            this.btnSDAdvanced.UseVisualStyleBackColor = true;
            this.btnSDAdvanced.Click += new System.EventHandler(this.btnSDAdvanced_Click);
            // 
            // btnCTRLLoadFile
            // 
            this.btnCTRLLoadFile.Location = new System.Drawing.Point(564, 20);
            this.btnCTRLLoadFile.Name = "btnCTRLLoadFile";
            this.btnCTRLLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnCTRLLoadFile.TabIndex = 0;
            this.btnCTRLLoadFile.Text = "Load File";
            this.btnCTRLLoadFile.UseVisualStyleBackColor = true;
            this.btnCTRLLoadFile.Click += new System.EventHandler(this.btnCTRLLoadFile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCTRLControls);
            this.tabControl1.Controls.Add(this.tabCTRLtbxXml);
            this.tabControl1.Location = new System.Drawing.Point(10, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 292);
            this.tabControl1.TabIndex = 2;
            // 
            // tabCTRLControls
            // 
            this.tabCTRLControls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCTRLControls.Controls.Add(this.pnlCTRLControls);
            this.tabCTRLControls.Controls.Add(this.lblCTRLSelCar);
            this.tabCTRLControls.Controls.Add(this.cbbCTRLSelCar);
            this.tabCTRLControls.Location = new System.Drawing.Point(4, 22);
            this.tabCTRLControls.Name = "tabCTRLControls";
            this.tabCTRLControls.Padding = new System.Windows.Forms.Padding(3);
            this.tabCTRLControls.Size = new System.Drawing.Size(624, 266);
            this.tabCTRLControls.TabIndex = 0;
            this.tabCTRLControls.Text = "Controls";
            // 
            // pnlCTRLControls
            // 
            this.pnlCTRLControls.Controls.Add(this.pnlCTRLSIndexF);
            this.pnlCTRLControls.Controls.Add(this.pnlCTRLIndicator);
            this.pnlCTRLControls.Controls.Add(this.pnlCTRLThrottle);
            this.pnlCTRLControls.Controls.Add(this.pnlCTRLSIndexR);
            this.pnlCTRLControls.Controls.Add(this.pnlCTRLVolRear);
            this.pnlCTRLControls.Controls.Add(this.pnlCTRLVolFront);
            this.pnlCTRLControls.Controls.Add(this.pnlCTRLRpm);
            this.pnlCTRLControls.Controls.Add(this.chkCTRLIce);
            this.pnlCTRLControls.Controls.Add(this.chkCTRLReady);
            this.pnlCTRLControls.Controls.Add(this.lblCTRLSIndex);
            this.pnlCTRLControls.Controls.Add(this.lblIngition);
            this.pnlCTRLControls.Controls.Add(this.btnCTRLOff);
            this.pnlCTRLControls.Controls.Add(this.btnCTRLOn);
            this.pnlCTRLControls.Controls.Add(this.panel1);
            this.pnlCTRLControls.Enabled = false;
            this.pnlCTRLControls.Location = new System.Drawing.Point(0, 26);
            this.pnlCTRLControls.Name = "pnlCTRLControls";
            this.pnlCTRLControls.Size = new System.Drawing.Size(624, 240);
            this.pnlCTRLControls.TabIndex = 2;
            // 
            // pnlCTRLSIndexF
            // 
            this.pnlCTRLSIndexF.Controls.Add(this.lblCTRLSIndexF);
            this.pnlCTRLSIndexF.Controls.Add(this.nudCTRLSIndexF);
            this.pnlCTRLSIndexF.Location = new System.Drawing.Point(538, 8);
            this.pnlCTRLSIndexF.Name = "pnlCTRLSIndexF";
            this.pnlCTRLSIndexF.Size = new System.Drawing.Size(78, 25);
            this.pnlCTRLSIndexF.TabIndex = 10;
            // 
            // lblCTRLSIndexF
            // 
            this.lblCTRLSIndexF.AutoSize = true;
            this.lblCTRLSIndexF.Location = new System.Drawing.Point(6, 5);
            this.lblCTRLSIndexF.Name = "lblCTRLSIndexF";
            this.lblCTRLSIndexF.Size = new System.Drawing.Size(31, 13);
            this.lblCTRLSIndexF.TabIndex = 1;
            this.lblCTRLSIndexF.Text = "Front";
            // 
            // nudCTRLSIndexF
            // 
            this.nudCTRLSIndexF.Location = new System.Drawing.Point(39, 3);
            this.nudCTRLSIndexF.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudCTRLSIndexF.Name = "nudCTRLSIndexF";
            this.nudCTRLSIndexF.Size = new System.Drawing.Size(35, 20);
            this.nudCTRLSIndexF.TabIndex = 0;
            this.nudCTRLSIndexF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCTRLSIndexF.ValueChanged += new System.EventHandler(this.nudCTRLSIndexF_ValueChanged);
            // 
            // pnlCTRLIndicator
            // 
            this.pnlCTRLIndicator.Controls.Add(this.lblCTRLIndicator);
            this.pnlCTRLIndicator.Controls.Add(this.btnCTRLIndicatorR);
            this.pnlCTRLIndicator.Controls.Add(this.btnCTRLIndicatorL);
            this.pnlCTRLIndicator.Controls.Add(this.btnCTRLIndicatorOff);
            this.pnlCTRLIndicator.Location = new System.Drawing.Point(4, 194);
            this.pnlCTRLIndicator.Name = "pnlCTRLIndicator";
            this.pnlCTRLIndicator.Size = new System.Drawing.Size(617, 40);
            this.pnlCTRLIndicator.TabIndex = 9;
            // 
            // lblCTRLIndicator
            // 
            this.lblCTRLIndicator.AutoSize = true;
            this.lblCTRLIndicator.Location = new System.Drawing.Point(5, 12);
            this.lblCTRLIndicator.Name = "lblCTRLIndicator";
            this.lblCTRLIndicator.Size = new System.Drawing.Size(48, 13);
            this.lblCTRLIndicator.TabIndex = 26;
            this.lblCTRLIndicator.Text = "Indicator";
            // 
            // btnCTRLIndicatorR
            // 
            this.btnCTRLIndicatorR.Location = new System.Drawing.Point(175, 9);
            this.btnCTRLIndicatorR.Name = "btnCTRLIndicatorR";
            this.btnCTRLIndicatorR.Size = new System.Drawing.Size(81, 23);
            this.btnCTRLIndicatorR.TabIndex = 2;
            this.btnCTRLIndicatorR.Text = "→";
            this.btnCTRLIndicatorR.UseVisualStyleBackColor = true;
            this.btnCTRLIndicatorR.Click += new System.EventHandler(this.btnCTRLIndicatorR_Click);
            // 
            // btnCTRLIndicatorL
            // 
            this.btnCTRLIndicatorL.Location = new System.Drawing.Point(61, 9);
            this.btnCTRLIndicatorL.Name = "btnCTRLIndicatorL";
            this.btnCTRLIndicatorL.Size = new System.Drawing.Size(81, 23);
            this.btnCTRLIndicatorL.TabIndex = 0;
            this.btnCTRLIndicatorL.Text = "←";
            this.btnCTRLIndicatorL.UseVisualStyleBackColor = true;
            this.btnCTRLIndicatorL.Click += new System.EventHandler(this.btnCTRLIndicatorL_Click);
            // 
            // btnCTRLIndicatorOff
            // 
            this.btnCTRLIndicatorOff.BackColor = System.Drawing.Color.Transparent;
            this.btnCTRLIndicatorOff.Location = new System.Drawing.Point(145, 9);
            this.btnCTRLIndicatorOff.Name = "btnCTRLIndicatorOff";
            this.btnCTRLIndicatorOff.Size = new System.Drawing.Size(27, 23);
            this.btnCTRLIndicatorOff.TabIndex = 1;
            this.btnCTRLIndicatorOff.Text = "■";
            this.btnCTRLIndicatorOff.UseVisualStyleBackColor = false;
            this.btnCTRLIndicatorOff.Click += new System.EventHandler(this.btnCTRLIndicatorOff_Click);
            // 
            // pnlCTRLThrottle
            // 
            this.pnlCTRLThrottle.Controls.Add(this.btnCTRLThrottle50percent);
            this.pnlCTRLThrottle.Controls.Add(this.btnCTRLThrottle100percent);
            this.pnlCTRLThrottle.Controls.Add(this.btnCTRLThrottle75percent);
            this.pnlCTRLThrottle.Controls.Add(this.btnCTRLThrottle25percent);
            this.pnlCTRLThrottle.Controls.Add(this.btnCTRLThrottle0percent);
            this.pnlCTRLThrottle.Controls.Add(this.lblCTRLThrottle);
            this.pnlCTRLThrottle.Controls.Add(this.lblCTRLThrottleValue);
            this.pnlCTRLThrottle.Controls.Add(this.tkbCTRLThrottle);
            this.pnlCTRLThrottle.Location = new System.Drawing.Point(4, 162);
            this.pnlCTRLThrottle.Name = "pnlCTRLThrottle";
            this.pnlCTRLThrottle.Size = new System.Drawing.Size(617, 40);
            this.pnlCTRLThrottle.TabIndex = 8;
            // 
            // btnCTRLThrottle50percent
            // 
            this.btnCTRLThrottle50percent.Location = new System.Drawing.Point(416, 7);
            this.btnCTRLThrottle50percent.Name = "btnCTRLThrottle50percent";
            this.btnCTRLThrottle50percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLThrottle50percent.TabIndex = 28;
            this.btnCTRLThrottle50percent.Text = "50%";
            this.btnCTRLThrottle50percent.UseVisualStyleBackColor = true;
            this.btnCTRLThrottle50percent.Click += new System.EventHandler(this.btnCTRLThrottle50percent_Click);
            // 
            // btnCTRLThrottle100percent
            // 
            this.btnCTRLThrottle100percent.Location = new System.Drawing.Point(548, 7);
            this.btnCTRLThrottle100percent.Name = "btnCTRLThrottle100percent";
            this.btnCTRLThrottle100percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLThrottle100percent.TabIndex = 27;
            this.btnCTRLThrottle100percent.Text = "100%";
            this.btnCTRLThrottle100percent.UseVisualStyleBackColor = true;
            this.btnCTRLThrottle100percent.Click += new System.EventHandler(this.btnCTRLThrottle100percent_Click);
            // 
            // btnCTRLThrottle75percent
            // 
            this.btnCTRLThrottle75percent.Location = new System.Drawing.Point(482, 7);
            this.btnCTRLThrottle75percent.Name = "btnCTRLThrottle75percent";
            this.btnCTRLThrottle75percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLThrottle75percent.TabIndex = 26;
            this.btnCTRLThrottle75percent.Text = "75%";
            this.btnCTRLThrottle75percent.UseVisualStyleBackColor = true;
            this.btnCTRLThrottle75percent.Click += new System.EventHandler(this.btnCTRLThrottle75percent_Click);
            // 
            // btnCTRLThrottle25percent
            // 
            this.btnCTRLThrottle25percent.Location = new System.Drawing.Point(350, 7);
            this.btnCTRLThrottle25percent.Name = "btnCTRLThrottle25percent";
            this.btnCTRLThrottle25percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLThrottle25percent.TabIndex = 25;
            this.btnCTRLThrottle25percent.Text = "25%";
            this.btnCTRLThrottle25percent.UseVisualStyleBackColor = true;
            this.btnCTRLThrottle25percent.Click += new System.EventHandler(this.btnCTRLThrottle25percent_Click);
            // 
            // btnCTRLThrottle0percent
            // 
            this.btnCTRLThrottle0percent.Location = new System.Drawing.Point(284, 7);
            this.btnCTRLThrottle0percent.Name = "btnCTRLThrottle0percent";
            this.btnCTRLThrottle0percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLThrottle0percent.TabIndex = 24;
            this.btnCTRLThrottle0percent.Text = "0%";
            this.btnCTRLThrottle0percent.UseVisualStyleBackColor = true;
            this.btnCTRLThrottle0percent.Click += new System.EventHandler(this.btnCTRLThrottle0percent_Click);
            // 
            // lblCTRLThrottle
            // 
            this.lblCTRLThrottle.AutoSize = true;
            this.lblCTRLThrottle.Location = new System.Drawing.Point(5, 12);
            this.lblCTRLThrottle.Name = "lblCTRLThrottle";
            this.lblCTRLThrottle.Size = new System.Drawing.Size(43, 13);
            this.lblCTRLThrottle.TabIndex = 23;
            this.lblCTRLThrottle.Text = "Throttle";
            // 
            // lblCTRLThrottleValue
            // 
            this.lblCTRLThrottleValue.AutoSize = true;
            this.lblCTRLThrottleValue.Location = new System.Drawing.Point(252, 12);
            this.lblCTRLThrottleValue.Name = "lblCTRLThrottleValue";
            this.lblCTRLThrottleValue.Size = new System.Drawing.Size(13, 13);
            this.lblCTRLThrottleValue.TabIndex = 22;
            this.lblCTRLThrottleValue.Text = "0";
            // 
            // tkbCTRLThrottle
            // 
            this.tkbCTRLThrottle.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.tkbCTRLThrottle.Location = new System.Drawing.Point(63, 0);
            this.tkbCTRLThrottle.Name = "tkbCTRLThrottle";
            this.tkbCTRLThrottle.Size = new System.Drawing.Size(183, 45);
            this.tkbCTRLThrottle.TabIndex = 21;
            this.tkbCTRLThrottle.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tkbCTRLThrottle.ValueChanged += new System.EventHandler(this.tkbCTRLThrottle_ValueChanged);
            // 
            // pnlCTRLSIndexR
            // 
            this.pnlCTRLSIndexR.Controls.Add(this.lblCTRLSIndexR);
            this.pnlCTRLSIndexR.Controls.Add(this.nudCTRLSIndexR);
            this.pnlCTRLSIndexR.Location = new System.Drawing.Point(538, 34);
            this.pnlCTRLSIndexR.Name = "pnlCTRLSIndexR";
            this.pnlCTRLSIndexR.Size = new System.Drawing.Size(78, 25);
            this.pnlCTRLSIndexR.TabIndex = 11;
            // 
            // lblCTRLSIndexR
            // 
            this.lblCTRLSIndexR.AutoSize = true;
            this.lblCTRLSIndexR.Location = new System.Drawing.Point(6, 5);
            this.lblCTRLSIndexR.Name = "lblCTRLSIndexR";
            this.lblCTRLSIndexR.Size = new System.Drawing.Size(30, 13);
            this.lblCTRLSIndexR.TabIndex = 1;
            this.lblCTRLSIndexR.Text = "Rear";
            // 
            // nudCTRLSIndexR
            // 
            this.nudCTRLSIndexR.Location = new System.Drawing.Point(39, 3);
            this.nudCTRLSIndexR.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudCTRLSIndexR.Name = "nudCTRLSIndexR";
            this.nudCTRLSIndexR.Size = new System.Drawing.Size(35, 20);
            this.nudCTRLSIndexR.TabIndex = 0;
            this.nudCTRLSIndexR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCTRLSIndexR.ValueChanged += new System.EventHandler(this.nudCTRLSIndexR_ValueChanged);
            // 
            // pnlCTRLVolRear
            // 
            this.pnlCTRLVolRear.Controls.Add(this.btnCTRLVolRear50percent);
            this.pnlCTRLVolRear.Controls.Add(this.btnCTRLVolRear100percent);
            this.pnlCTRLVolRear.Controls.Add(this.btnCTRLVolRear75percent);
            this.pnlCTRLVolRear.Controls.Add(this.btnCTRLVolRear25percent);
            this.pnlCTRLVolRear.Controls.Add(this.btnCTRLVolRear0percent);
            this.pnlCTRLVolRear.Controls.Add(this.lblCTRLVolRear);
            this.pnlCTRLVolRear.Controls.Add(this.tkbCTRLVolRear);
            this.pnlCTRLVolRear.Controls.Add(this.lblCTRLVolRearValue);
            this.pnlCTRLVolRear.Location = new System.Drawing.Point(4, 130);
            this.pnlCTRLVolRear.Name = "pnlCTRLVolRear";
            this.pnlCTRLVolRear.Size = new System.Drawing.Size(617, 40);
            this.pnlCTRLVolRear.TabIndex = 7;
            // 
            // btnCTRLVolRear50percent
            // 
            this.btnCTRLVolRear50percent.Location = new System.Drawing.Point(416, 7);
            this.btnCTRLVolRear50percent.Name = "btnCTRLVolRear50percent";
            this.btnCTRLVolRear50percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLVolRear50percent.TabIndex = 25;
            this.btnCTRLVolRear50percent.Text = "50%";
            this.btnCTRLVolRear50percent.UseVisualStyleBackColor = true;
            this.btnCTRLVolRear50percent.Click += new System.EventHandler(this.btnCTRLVolRear50percent_Click);
            // 
            // btnCTRLVolRear100percent
            // 
            this.btnCTRLVolRear100percent.Location = new System.Drawing.Point(548, 7);
            this.btnCTRLVolRear100percent.Name = "btnCTRLVolRear100percent";
            this.btnCTRLVolRear100percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLVolRear100percent.TabIndex = 24;
            this.btnCTRLVolRear100percent.Text = "100%";
            this.btnCTRLVolRear100percent.UseVisualStyleBackColor = true;
            this.btnCTRLVolRear100percent.Click += new System.EventHandler(this.btnCTRLVolRear100percent_Click);
            // 
            // btnCTRLVolRear75percent
            // 
            this.btnCTRLVolRear75percent.Location = new System.Drawing.Point(482, 7);
            this.btnCTRLVolRear75percent.Name = "btnCTRLVolRear75percent";
            this.btnCTRLVolRear75percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLVolRear75percent.TabIndex = 23;
            this.btnCTRLVolRear75percent.Text = "75%";
            this.btnCTRLVolRear75percent.UseVisualStyleBackColor = true;
            this.btnCTRLVolRear75percent.Click += new System.EventHandler(this.btnCTRLVolRear75percent_Click);
            // 
            // btnCTRLVolRear25percent
            // 
            this.btnCTRLVolRear25percent.Location = new System.Drawing.Point(350, 7);
            this.btnCTRLVolRear25percent.Name = "btnCTRLVolRear25percent";
            this.btnCTRLVolRear25percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLVolRear25percent.TabIndex = 22;
            this.btnCTRLVolRear25percent.Text = "25%";
            this.btnCTRLVolRear25percent.UseVisualStyleBackColor = true;
            this.btnCTRLVolRear25percent.Click += new System.EventHandler(this.btnCTRLVolRear25percent_Click);
            // 
            // btnCTRLVolRear0percent
            // 
            this.btnCTRLVolRear0percent.Location = new System.Drawing.Point(284, 7);
            this.btnCTRLVolRear0percent.Name = "btnCTRLVolRear0percent";
            this.btnCTRLVolRear0percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLVolRear0percent.TabIndex = 21;
            this.btnCTRLVolRear0percent.Text = "0%";
            this.btnCTRLVolRear0percent.UseVisualStyleBackColor = true;
            this.btnCTRLVolRear0percent.Click += new System.EventHandler(this.btnCTRLVolRear0percent_Click);
            // 
            // lblCTRLVolRear
            // 
            this.lblCTRLVolRear.AutoSize = true;
            this.lblCTRLVolRear.Location = new System.Drawing.Point(5, 12);
            this.lblCTRLVolRear.Name = "lblCTRLVolRear";
            this.lblCTRLVolRear.Size = new System.Drawing.Size(65, 13);
            this.lblCTRLVolRear.TabIndex = 20;
            this.lblCTRLVolRear.Text = "Vol Reverse";
            // 
            // tkbCTRLVolRear
            // 
            this.tkbCTRLVolRear.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.tkbCTRLVolRear.Location = new System.Drawing.Point(63, 0);
            this.tkbCTRLVolRear.Name = "tkbCTRLVolRear";
            this.tkbCTRLVolRear.Size = new System.Drawing.Size(183, 45);
            this.tkbCTRLVolRear.TabIndex = 18;
            this.tkbCTRLVolRear.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tkbCTRLVolRear.ValueChanged += new System.EventHandler(this.tkbCTRLVolRear_ValueChanged);
            // 
            // lblCTRLVolRearValue
            // 
            this.lblCTRLVolRearValue.AutoSize = true;
            this.lblCTRLVolRearValue.Location = new System.Drawing.Point(252, 12);
            this.lblCTRLVolRearValue.Name = "lblCTRLVolRearValue";
            this.lblCTRLVolRearValue.Size = new System.Drawing.Size(13, 13);
            this.lblCTRLVolRearValue.TabIndex = 19;
            this.lblCTRLVolRearValue.Text = "0";
            // 
            // pnlCTRLVolFront
            // 
            this.pnlCTRLVolFront.Controls.Add(this.btnCTRLVolFront50percent);
            this.pnlCTRLVolFront.Controls.Add(this.btnCTRLVolFront100percent);
            this.pnlCTRLVolFront.Controls.Add(this.btnCTRLVolFront75percent);
            this.pnlCTRLVolFront.Controls.Add(this.btnCTRLVolFront25percent);
            this.pnlCTRLVolFront.Controls.Add(this.btnCTRLVolFront0percent);
            this.pnlCTRLVolFront.Controls.Add(this.tkbCTRLVolFront);
            this.pnlCTRLVolFront.Controls.Add(this.lblCTRLVolFront);
            this.pnlCTRLVolFront.Controls.Add(this.lblCTRLVolFrontValue);
            this.pnlCTRLVolFront.Location = new System.Drawing.Point(4, 98);
            this.pnlCTRLVolFront.Name = "pnlCTRLVolFront";
            this.pnlCTRLVolFront.Size = new System.Drawing.Size(617, 40);
            this.pnlCTRLVolFront.TabIndex = 6;
            // 
            // btnCTRLVolFront50percent
            // 
            this.btnCTRLVolFront50percent.Location = new System.Drawing.Point(416, 7);
            this.btnCTRLVolFront50percent.Name = "btnCTRLVolFront50percent";
            this.btnCTRLVolFront50percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLVolFront50percent.TabIndex = 17;
            this.btnCTRLVolFront50percent.Text = "50%";
            this.btnCTRLVolFront50percent.UseVisualStyleBackColor = true;
            this.btnCTRLVolFront50percent.Click += new System.EventHandler(this.btnCTRLVolFront50percent_Click);
            // 
            // btnCTRLVolFront100percent
            // 
            this.btnCTRLVolFront100percent.Location = new System.Drawing.Point(548, 7);
            this.btnCTRLVolFront100percent.Name = "btnCTRLVolFront100percent";
            this.btnCTRLVolFront100percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLVolFront100percent.TabIndex = 16;
            this.btnCTRLVolFront100percent.Text = "100%";
            this.btnCTRLVolFront100percent.UseVisualStyleBackColor = true;
            this.btnCTRLVolFront100percent.Click += new System.EventHandler(this.btnCTRLVolFront100percent_Click);
            // 
            // btnCTRLVolFront75percent
            // 
            this.btnCTRLVolFront75percent.Location = new System.Drawing.Point(482, 7);
            this.btnCTRLVolFront75percent.Name = "btnCTRLVolFront75percent";
            this.btnCTRLVolFront75percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLVolFront75percent.TabIndex = 15;
            this.btnCTRLVolFront75percent.Text = "75%";
            this.btnCTRLVolFront75percent.UseVisualStyleBackColor = true;
            this.btnCTRLVolFront75percent.Click += new System.EventHandler(this.btnCTRLVolFront75percent_Click);
            // 
            // btnCTRLVolFront25percent
            // 
            this.btnCTRLVolFront25percent.Location = new System.Drawing.Point(350, 7);
            this.btnCTRLVolFront25percent.Name = "btnCTRLVolFront25percent";
            this.btnCTRLVolFront25percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLVolFront25percent.TabIndex = 14;
            this.btnCTRLVolFront25percent.Text = "25%";
            this.btnCTRLVolFront25percent.UseVisualStyleBackColor = true;
            this.btnCTRLVolFront25percent.Click += new System.EventHandler(this.btnCTRLVolFront25percent_Click);
            // 
            // btnCTRLVolFront0percent
            // 
            this.btnCTRLVolFront0percent.Location = new System.Drawing.Point(284, 7);
            this.btnCTRLVolFront0percent.Name = "btnCTRLVolFront0percent";
            this.btnCTRLVolFront0percent.Size = new System.Drawing.Size(63, 23);
            this.btnCTRLVolFront0percent.TabIndex = 13;
            this.btnCTRLVolFront0percent.Text = "0%";
            this.btnCTRLVolFront0percent.UseVisualStyleBackColor = true;
            this.btnCTRLVolFront0percent.Click += new System.EventHandler(this.btnCTRLVolFront0percent_Click);
            // 
            // tkbCTRLVolFront
            // 
            this.tkbCTRLVolFront.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.tkbCTRLVolFront.Location = new System.Drawing.Point(63, 0);
            this.tkbCTRLVolFront.Name = "tkbCTRLVolFront";
            this.tkbCTRLVolFront.Size = new System.Drawing.Size(183, 45);
            this.tkbCTRLVolFront.TabIndex = 10;
            this.tkbCTRLVolFront.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tkbCTRLVolFront.ValueChanged += new System.EventHandler(this.tkbCTRLVolFront_ValueChanged);
            // 
            // lblCTRLVolFront
            // 
            this.lblCTRLVolFront.AutoSize = true;
            this.lblCTRLVolFront.Location = new System.Drawing.Point(5, 12);
            this.lblCTRLVolFront.Name = "lblCTRLVolFront";
            this.lblCTRLVolFront.Size = new System.Drawing.Size(50, 13);
            this.lblCTRLVolFront.TabIndex = 11;
            this.lblCTRLVolFront.Text = "Vol Drive";
            // 
            // lblCTRLVolFrontValue
            // 
            this.lblCTRLVolFrontValue.AutoSize = true;
            this.lblCTRLVolFrontValue.Location = new System.Drawing.Point(252, 12);
            this.lblCTRLVolFrontValue.Name = "lblCTRLVolFrontValue";
            this.lblCTRLVolFrontValue.Size = new System.Drawing.Size(13, 13);
            this.lblCTRLVolFrontValue.TabIndex = 12;
            this.lblCTRLVolFrontValue.Text = "0";
            // 
            // pnlCTRLRpm
            // 
            this.pnlCTRLRpm.Controls.Add(this.btnCTRLRpm200percent);
            this.pnlCTRLRpm.Controls.Add(this.btnCTRLRpm100percent);
            this.pnlCTRLRpm.Controls.Add(this.btnCTRLRpm110percent);
            this.pnlCTRLRpm.Controls.Add(this.btnCTRLRpm90percent);
            this.pnlCTRLRpm.Controls.Add(this.btnCTRLRpm10percent);
            this.pnlCTRLRpm.Controls.Add(this.btnCTRLRpm0percent);
            this.pnlCTRLRpm.Controls.Add(this.lblCTRLRpm);
            this.pnlCTRLRpm.Controls.Add(this.tkbCTRLRpm);
            this.pnlCTRLRpm.Controls.Add(this.lblCTRLRpmValue);
            this.pnlCTRLRpm.Location = new System.Drawing.Point(4, 66);
            this.pnlCTRLRpm.Name = "pnlCTRLRpm";
            this.pnlCTRLRpm.Size = new System.Drawing.Size(617, 40);
            this.pnlCTRLRpm.TabIndex = 5;
            // 
            // btnCTRLRpm200percent
            // 
            this.btnCTRLRpm200percent.Location = new System.Drawing.Point(559, 7);
            this.btnCTRLRpm200percent.Name = "btnCTRLRpm200percent";
            this.btnCTRLRpm200percent.Size = new System.Drawing.Size(52, 23);
            this.btnCTRLRpm200percent.TabIndex = 6;
            this.btnCTRLRpm200percent.Text = "200%";
            this.btnCTRLRpm200percent.UseVisualStyleBackColor = true;
            this.btnCTRLRpm200percent.Click += new System.EventHandler(this.btnCTRLRpm200percent_Click);
            // 
            // btnCTRLRpm100percent
            // 
            this.btnCTRLRpm100percent.Location = new System.Drawing.Point(449, 7);
            this.btnCTRLRpm100percent.Name = "btnCTRLRpm100percent";
            this.btnCTRLRpm100percent.Size = new System.Drawing.Size(52, 23);
            this.btnCTRLRpm100percent.TabIndex = 4;
            this.btnCTRLRpm100percent.Text = "100%";
            this.btnCTRLRpm100percent.UseVisualStyleBackColor = true;
            this.btnCTRLRpm100percent.Click += new System.EventHandler(this.btnCTRLRpm100percent_Click);
            // 
            // btnCTRLRpm110percent
            // 
            this.btnCTRLRpm110percent.Location = new System.Drawing.Point(504, 7);
            this.btnCTRLRpm110percent.Name = "btnCTRLRpm110percent";
            this.btnCTRLRpm110percent.Size = new System.Drawing.Size(52, 23);
            this.btnCTRLRpm110percent.TabIndex = 5;
            this.btnCTRLRpm110percent.Text = "110%";
            this.btnCTRLRpm110percent.UseVisualStyleBackColor = true;
            this.btnCTRLRpm110percent.Click += new System.EventHandler(this.btnCTRLRpm110percent_Click);
            // 
            // btnCTRLRpm90percent
            // 
            this.btnCTRLRpm90percent.Location = new System.Drawing.Point(394, 7);
            this.btnCTRLRpm90percent.Name = "btnCTRLRpm90percent";
            this.btnCTRLRpm90percent.Size = new System.Drawing.Size(52, 23);
            this.btnCTRLRpm90percent.TabIndex = 3;
            this.btnCTRLRpm90percent.Text = "90%";
            this.btnCTRLRpm90percent.UseVisualStyleBackColor = true;
            this.btnCTRLRpm90percent.Click += new System.EventHandler(this.btnCTRLRpm90percent_Click);
            // 
            // btnCTRLRpm10percent
            // 
            this.btnCTRLRpm10percent.Location = new System.Drawing.Point(339, 7);
            this.btnCTRLRpm10percent.Name = "btnCTRLRpm10percent";
            this.btnCTRLRpm10percent.Size = new System.Drawing.Size(52, 23);
            this.btnCTRLRpm10percent.TabIndex = 2;
            this.btnCTRLRpm10percent.Text = "10%";
            this.btnCTRLRpm10percent.UseVisualStyleBackColor = true;
            this.btnCTRLRpm10percent.Click += new System.EventHandler(this.btnCTRLRpm10percent_Click);
            // 
            // btnCTRLRpm0percent
            // 
            this.btnCTRLRpm0percent.Location = new System.Drawing.Point(284, 7);
            this.btnCTRLRpm0percent.Name = "btnCTRLRpm0percent";
            this.btnCTRLRpm0percent.Size = new System.Drawing.Size(52, 23);
            this.btnCTRLRpm0percent.TabIndex = 1;
            this.btnCTRLRpm0percent.Text = "0%";
            this.btnCTRLRpm0percent.UseVisualStyleBackColor = true;
            this.btnCTRLRpm0percent.Click += new System.EventHandler(this.btnCTRLRpm0percent_Click);
            // 
            // lblCTRLRpm
            // 
            this.lblCTRLRpm.AutoSize = true;
            this.lblCTRLRpm.Location = new System.Drawing.Point(5, 12);
            this.lblCTRLRpm.Name = "lblCTRLRpm";
            this.lblCTRLRpm.Size = new System.Drawing.Size(31, 13);
            this.lblCTRLRpm.TabIndex = 7;
            this.lblCTRLRpm.Text = "RPM";
            // 
            // tkbCTRLRpm
            // 
            this.tkbCTRLRpm.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.tkbCTRLRpm.Location = new System.Drawing.Point(63, 0);
            this.tkbCTRLRpm.Name = "tkbCTRLRpm";
            this.tkbCTRLRpm.Size = new System.Drawing.Size(183, 45);
            this.tkbCTRLRpm.TabIndex = 7;
            this.tkbCTRLRpm.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tkbCTRLRpm.ValueChanged += new System.EventHandler(this.tkbCTRLRpm_ValueChanged);
            // 
            // lblCTRLRpmValue
            // 
            this.lblCTRLRpmValue.AutoSize = true;
            this.lblCTRLRpmValue.Location = new System.Drawing.Point(252, 12);
            this.lblCTRLRpmValue.Name = "lblCTRLRpmValue";
            this.lblCTRLRpmValue.Size = new System.Drawing.Size(13, 13);
            this.lblCTRLRpmValue.TabIndex = 8;
            this.lblCTRLRpmValue.Text = "0";
            // 
            // chkCTRLIce
            // 
            this.chkCTRLIce.AutoSize = true;
            this.chkCTRLIce.Location = new System.Drawing.Point(258, 12);
            this.chkCTRLIce.Name = "chkCTRLIce";
            this.chkCTRLIce.Size = new System.Drawing.Size(43, 17);
            this.chkCTRLIce.TabIndex = 3;
            this.chkCTRLIce.Text = "ICE";
            this.chkCTRLIce.UseVisualStyleBackColor = true;
            this.chkCTRLIce.CheckedChanged += new System.EventHandler(this.chkCTRLIce_CheckedChanged);
            // 
            // chkCTRLReady
            // 
            this.chkCTRLReady.AutoSize = true;
            this.chkCTRLReady.Location = new System.Drawing.Point(194, 12);
            this.chkCTRLReady.Name = "chkCTRLReady";
            this.chkCTRLReady.Size = new System.Drawing.Size(63, 17);
            this.chkCTRLReady.TabIndex = 2;
            this.chkCTRLReady.Text = "READY";
            this.chkCTRLReady.UseVisualStyleBackColor = true;
            this.chkCTRLReady.CheckedChanged += new System.EventHandler(this.chkCTRLReady_CheckedChanged);
            // 
            // lblCTRLSIndex
            // 
            this.lblCTRLSIndex.AutoSize = true;
            this.lblCTRLSIndex.Location = new System.Drawing.Point(465, 13);
            this.lblCTRLSIndex.Name = "lblCTRLSIndex";
            this.lblCTRLSIndex.Size = new System.Drawing.Size(67, 13);
            this.lblCTRLSIndex.TabIndex = 15;
            this.lblCTRLSIndex.Text = "Sound Index";
            // 
            // lblIngition
            // 
            this.lblIngition.AutoSize = true;
            this.lblIngition.Location = new System.Drawing.Point(8, 13);
            this.lblIngition.Name = "lblIngition";
            this.lblIngition.Size = new System.Drawing.Size(41, 13);
            this.lblIngition.TabIndex = 2;
            this.lblIngition.Text = "Ignition";
            // 
            // btnCTRLOff
            // 
            this.btnCTRLOff.Location = new System.Drawing.Point(128, 8);
            this.btnCTRLOff.Name = "btnCTRLOff";
            this.btnCTRLOff.Size = new System.Drawing.Size(59, 23);
            this.btnCTRLOff.TabIndex = 1;
            this.btnCTRLOff.Text = "OFF";
            this.btnCTRLOff.UseVisualStyleBackColor = true;
            // 
            // btnCTRLOn
            // 
            this.btnCTRLOn.Location = new System.Drawing.Point(66, 8);
            this.btnCTRLOn.Name = "btnCTRLOn";
            this.btnCTRLOn.Size = new System.Drawing.Size(59, 23);
            this.btnCTRLOn.TabIndex = 0;
            this.btnCTRLOn.Text = "ON";
            this.btnCTRLOn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCTRLGear);
            this.panel1.Controls.Add(this.btnCTRLDrive);
            this.panel1.Controls.Add(this.btnCTRLNeutral);
            this.panel1.Controls.Add(this.btnCTRLReverse);
            this.panel1.Controls.Add(this.tbxCTRLGearValue);
            this.panel1.Location = new System.Drawing.Point(4, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 40);
            this.panel1.TabIndex = 4;
            // 
            // lblCTRLGear
            // 
            this.lblCTRLGear.AutoSize = true;
            this.lblCTRLGear.Location = new System.Drawing.Point(4, 12);
            this.lblCTRLGear.Name = "lblCTRLGear";
            this.lblCTRLGear.Size = new System.Drawing.Size(30, 13);
            this.lblCTRLGear.TabIndex = 3;
            this.lblCTRLGear.Text = "Gear";
            // 
            // btnCTRLDrive
            // 
            this.btnCTRLDrive.Location = new System.Drawing.Point(61, 9);
            this.btnCTRLDrive.Name = "btnCTRLDrive";
            this.btnCTRLDrive.Size = new System.Drawing.Size(59, 23);
            this.btnCTRLDrive.TabIndex = 0;
            this.btnCTRLDrive.Text = "Drive";
            this.btnCTRLDrive.UseVisualStyleBackColor = true;
            this.btnCTRLDrive.Click += new System.EventHandler(this.btnCTRLDrive_Click);
            // 
            // btnCTRLNeutral
            // 
            this.btnCTRLNeutral.Location = new System.Drawing.Point(124, 9);
            this.btnCTRLNeutral.Name = "btnCTRLNeutral";
            this.btnCTRLNeutral.Size = new System.Drawing.Size(59, 23);
            this.btnCTRLNeutral.TabIndex = 1;
            this.btnCTRLNeutral.Text = "Neutral";
            this.btnCTRLNeutral.UseVisualStyleBackColor = true;
            this.btnCTRLNeutral.Click += new System.EventHandler(this.btnCTRLNeutral_Click);
            // 
            // btnCTRLReverse
            // 
            this.btnCTRLReverse.Location = new System.Drawing.Point(187, 9);
            this.btnCTRLReverse.Name = "btnCTRLReverse";
            this.btnCTRLReverse.Size = new System.Drawing.Size(59, 23);
            this.btnCTRLReverse.TabIndex = 2;
            this.btnCTRLReverse.Text = "Reverse";
            this.btnCTRLReverse.UseVisualStyleBackColor = true;
            this.btnCTRLReverse.Click += new System.EventHandler(this.btnCTRLReverse_Click);
            // 
            // tbxCTRLGearValue
            // 
            this.tbxCTRLGearValue.Location = new System.Drawing.Point(250, 10);
            this.tbxCTRLGearValue.Name = "tbxCTRLGearValue";
            this.tbxCTRLGearValue.ReadOnly = true;
            this.tbxCTRLGearValue.Size = new System.Drawing.Size(17, 20);
            this.tbxCTRLGearValue.TabIndex = 25;
            this.tbxCTRLGearValue.Text = "N";
            this.tbxCTRLGearValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCTRLSelCar
            // 
            this.lblCTRLSelCar.AutoSize = true;
            this.lblCTRLSelCar.Location = new System.Drawing.Point(8, 9);
            this.lblCTRLSelCar.Name = "lblCTRLSelCar";
            this.lblCTRLSelCar.Size = new System.Drawing.Size(56, 13);
            this.lblCTRLSelCar.TabIndex = 1;
            this.lblCTRLSelCar.Text = "Select Car";
            // 
            // cbbCTRLSelCar
            // 
            this.cbbCTRLSelCar.FormattingEnabled = true;
            this.cbbCTRLSelCar.Location = new System.Drawing.Point(68, 6);
            this.cbbCTRLSelCar.Name = "cbbCTRLSelCar";
            this.cbbCTRLSelCar.Size = new System.Drawing.Size(143, 21);
            this.cbbCTRLSelCar.TabIndex = 0;
            this.cbbCTRLSelCar.SelectedIndexChanged += new System.EventHandler(this.cbbCTRLSelCar_SelectedIndexChanged);
            // 
            // tabCTRLtbxXml
            // 
            this.tabCTRLtbxXml.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCTRLtbxXml.Controls.Add(this.tbxCTRLXml);
            this.tabCTRLtbxXml.Location = new System.Drawing.Point(4, 22);
            this.tabCTRLtbxXml.Name = "tabCTRLtbxXml";
            this.tabCTRLtbxXml.Padding = new System.Windows.Forms.Padding(3);
            this.tabCTRLtbxXml.Size = new System.Drawing.Size(624, 266);
            this.tabCTRLtbxXml.TabIndex = 1;
            this.tabCTRLtbxXml.Text = "XML View";
            // 
            // tbxCTRLXml
            // 
            this.tbxCTRLXml.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxCTRLXml.Location = new System.Drawing.Point(7, 7);
            this.tbxCTRLXml.Multiline = true;
            this.tbxCTRLXml.Name = "tbxCTRLXml";
            this.tbxCTRLXml.ReadOnly = true;
            this.tbxCTRLXml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxCTRLXml.Size = new System.Drawing.Size(614, 256);
            this.tbxCTRLXml.TabIndex = 1;
            // 
            // tbxCanMsg
            // 
            this.tbxCanMsg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxCanMsg.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCanMsg.Location = new System.Drawing.Point(94, 4);
            this.tbxCanMsg.Name = "tbxCanMsg";
            this.tbxCanMsg.ReadOnly = true;
            this.tbxCanMsg.Size = new System.Drawing.Size(237, 20);
            this.tbxCanMsg.TabIndex = 12;
            // 
            // lblCanMsg
            // 
            this.lblCanMsg.AutoSize = true;
            this.lblCanMsg.Location = new System.Drawing.Point(9, 7);
            this.lblCanMsg.Name = "lblCanMsg";
            this.lblCanMsg.Size = new System.Drawing.Size(78, 13);
            this.lblCanMsg.TabIndex = 13;
            this.lblCanMsg.Text = "CAN Message:";
            // 
            // pnlCanMsg
            // 
            this.pnlCanMsg.Controls.Add(this.tbxCanMsg);
            this.pnlCanMsg.Controls.Add(this.lblCanMsg);
            this.pnlCanMsg.Location = new System.Drawing.Point(12, 512);
            this.pnlCanMsg.Name = "pnlCanMsg";
            this.pnlCanMsg.Size = new System.Drawing.Size(339, 27);
            this.pnlCanMsg.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 545);
            this.Controls.Add(this.pnlCanMsg);
            this.Controls.Add(this.gbxControls);
            this.Controls.Add(this.gbxSendData);
            this.Controls.Add(this.gbxConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ECT CAN Tester";
            this.gbxConnection.ResumeLayout(false);
            this.gbxConnection.PerformLayout();
            this.gbxSendData.ResumeLayout(false);
            this.gbxSendData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSDLength)).EndInit();
            this.gbxControls.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCTRLControls.ResumeLayout(false);
            this.tabCTRLControls.PerformLayout();
            this.pnlCTRLControls.ResumeLayout(false);
            this.pnlCTRLControls.PerformLayout();
            this.pnlCTRLSIndexF.ResumeLayout(false);
            this.pnlCTRLSIndexF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCTRLSIndexF)).EndInit();
            this.pnlCTRLIndicator.ResumeLayout(false);
            this.pnlCTRLIndicator.PerformLayout();
            this.pnlCTRLThrottle.ResumeLayout(false);
            this.pnlCTRLThrottle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCTRLThrottle)).EndInit();
            this.pnlCTRLSIndexR.ResumeLayout(false);
            this.pnlCTRLSIndexR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCTRLSIndexR)).EndInit();
            this.pnlCTRLVolRear.ResumeLayout(false);
            this.pnlCTRLVolRear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCTRLVolRear)).EndInit();
            this.pnlCTRLVolFront.ResumeLayout(false);
            this.pnlCTRLVolFront.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCTRLVolFront)).EndInit();
            this.pnlCTRLRpm.ResumeLayout(false);
            this.pnlCTRLRpm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCTRLRpm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabCTRLtbxXml.ResumeLayout(false);
            this.tabCTRLtbxXml.PerformLayout();
            this.pnlCanMsg.ResumeLayout(false);
            this.pnlCanMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConnection;
        private System.Windows.Forms.ComboBox cbbCONPort;
        private System.Windows.Forms.Label lblCONPort;
        private System.Windows.Forms.Button btnCONRefresh;
        private System.Windows.Forms.ComboBox cbbCONBaudrate;
        private System.Windows.Forms.Label lblCONBaudrate;
        private System.Windows.Forms.ComboBox cbbCONType;
        private System.Windows.Forms.Label lblCONType;
        private System.Windows.Forms.Button btnCONInit;
        private System.Windows.Forms.Button btnCONRelease;

        private System.Windows.Forms.GroupBox gbxSendData;
        private System.Windows.Forms.TextBox tbxSDB7;
        private System.Windows.Forms.TextBox tbxSDB6;
        private System.Windows.Forms.TextBox tbxSDB5;
        private System.Windows.Forms.TextBox tbxSDB4;
        private System.Windows.Forms.TextBox tbxSDB3;
        private System.Windows.Forms.TextBox tbxSDB2;
        private System.Windows.Forms.TextBox tbxSDB1;
        private System.Windows.Forms.TextBox tbxSDB0;
        private System.Windows.Forms.TextBox tbxSDID;
        private System.Windows.Forms.NumericUpDown nudSDLength;
        private System.Windows.Forms.Label lblSDData;
        private System.Windows.Forms.Label lblSDLength;
        private System.Windows.Forms.Label lblSDID;
        private System.Windows.Forms.CheckBox chkSDExtended;
        private System.Windows.Forms.Button btnSDSend;

        private System.Windows.Forms.GroupBox gbxControls;
        private System.Windows.Forms.Button btnCTRLLoadFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCTRLControls;
        private System.Windows.Forms.TabPage tabCTRLtbxXml;
        private System.Windows.Forms.TextBox tbxCTRLXml;
        private System.Windows.Forms.Label lblCTRLSelCar;
        private System.Windows.Forms.ComboBox cbbCTRLSelCar;
        private System.Windows.Forms.Panel pnlCTRLControls;
        private System.Windows.Forms.Button btnCTRLOff;
        private System.Windows.Forms.Button btnCTRLOn;
        private System.Windows.Forms.Label lblIngition;
        private System.Windows.Forms.Button btnCTRLReverse;
        private System.Windows.Forms.Button btnCTRLNeutral;
        private System.Windows.Forms.Button btnCTRLDrive;
        private System.Windows.Forms.Label lblCTRLGear;
        private System.Windows.Forms.TrackBar tkbCTRLRpm;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.Label lblCTRLRpm;
        private System.Windows.Forms.ToolTip ttCTRLTkb;
        private System.Windows.Forms.Label lblCTRLRpmValue;
        private System.Windows.Forms.Label lblCTRLVolFront;
        private System.Windows.Forms.TrackBar tkbCTRLVolFront;
        private System.Windows.Forms.Label lblCTRLVolFrontValue;
        private System.Windows.Forms.TextBox tbxCanMsg;
        private System.Windows.Forms.Label lblCanMsg;
        private System.Windows.Forms.Label lblCTRLSIndexR;
        private System.Windows.Forms.Label lblCTRLSIndexF;
        private System.Windows.Forms.Label lblCTRLSIndex;
        private System.Windows.Forms.NumericUpDown nudCTRLSIndexR;
        private System.Windows.Forms.NumericUpDown nudCTRLSIndexF;
        private System.Windows.Forms.Label lblCTRLVolRear;
        private System.Windows.Forms.Label lblCTRLVolRearValue;
        private System.Windows.Forms.TrackBar tkbCTRLVolRear;
        private System.Windows.Forms.Label lblCTRLThrottle;
        private System.Windows.Forms.Label lblCTRLThrottleValue;
        private System.Windows.Forms.TrackBar tkbCTRLThrottle;
        private System.Windows.Forms.CheckBox chkCTRLReady;
        private System.Windows.Forms.TextBox tbxCTRLGearValue;
        private System.Windows.Forms.Button btnCTRLIndicatorR;
        private System.Windows.Forms.Button btnCTRLIndicatorOff;
        private System.Windows.Forms.Button btnCTRLIndicatorL;
        private System.Windows.Forms.Label lblCTRLIndicator;
        private System.Windows.Forms.CheckBox chkCTRLIce;
        private System.Windows.Forms.Button btnSDAdvanced;
        private System.Windows.Forms.Panel pnlCanMsg;
        private System.Windows.Forms.CheckBox chkVolFromXml;
        private System.Windows.Forms.Panel pnlCTRLVolFront;
        private System.Windows.Forms.Panel pnlCTRLRpm;
        private System.Windows.Forms.Panel pnlCTRLVolRear;
        private System.Windows.Forms.Panel pnlCTRLThrottle;
        private System.Windows.Forms.Panel pnlCTRLIndicator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCTRLSIndexF;
        private System.Windows.Forms.Panel pnlCTRLSIndexR;
        private System.Windows.Forms.Button btnCTRLRpm200percent;
        private System.Windows.Forms.Button btnCTRLRpm100percent;
        private System.Windows.Forms.Button btnCTRLRpm110percent;
        private System.Windows.Forms.Button btnCTRLRpm90percent;
        private System.Windows.Forms.Button btnCTRLRpm10percent;
        private System.Windows.Forms.Button btnCTRLRpm0percent;
        private System.Windows.Forms.Button btnCTRLThrottle50percent;
        private System.Windows.Forms.Button btnCTRLThrottle100percent;
        private System.Windows.Forms.Button btnCTRLThrottle75percent;
        private System.Windows.Forms.Button btnCTRLThrottle25percent;
        private System.Windows.Forms.Button btnCTRLThrottle0percent;
        private System.Windows.Forms.Button btnCTRLVolRear50percent;
        private System.Windows.Forms.Button btnCTRLVolRear100percent;
        private System.Windows.Forms.Button btnCTRLVolRear75percent;
        private System.Windows.Forms.Button btnCTRLVolRear25percent;
        private System.Windows.Forms.Button btnCTRLVolRear0percent;
        private System.Windows.Forms.Button btnCTRLVolFront50percent;
        private System.Windows.Forms.Button btnCTRLVolFront100percent;
        private System.Windows.Forms.Button btnCTRLVolFront75percent;
        private System.Windows.Forms.Button btnCTRLVolFront25percent;
        private System.Windows.Forms.Button btnCTRLVolFront0percent;
        private System.Windows.Forms.Label lblCONDevice;
        private System.Windows.Forms.ComboBox cbbCONDevice;
    }
}

