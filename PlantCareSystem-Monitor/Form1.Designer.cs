namespace PlantCareSystem_Monitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoisture = new System.Windows.Forms.TextBox();
            this.txtMovement = new System.Windows.Forms.TextBox();
            this.txtLight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sliderFanSpeed = new System.Windows.Forms.TrackBar();
            this.sliderTargetTemperature = new System.Windows.Forms.TrackBar();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblFanSpeed = new System.Windows.Forms.Label();
            this.btnFanStop = new System.Windows.Forms.Button();
            this.cmbLightColors = new System.Windows.Forms.ComboBox();
            this.lblLightTarget = new System.Windows.Forms.Label();
            this.sliderLightTarget = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLightTime = new System.Windows.Forms.TextBox();
            this.lightTimer = new System.Windows.Forms.Timer(this.components);
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.radioBtnOff = new System.Windows.Forms.RadioButton();
            this.radioBtnOn = new System.Windows.Forms.RadioButton();
            this.txtBuzzerTime = new System.Windows.Forms.TextBox();
            this.cmbMoisture = new System.Windows.Forms.ComboBox();
            this.lblMoistureTarget = new System.Windows.Forms.Label();
            this.sliderMoistureTarget = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.moistureTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.progressLight = new System.Windows.Forms.ProgressBar();
            this.progressMotion = new System.Windows.Forms.ProgressBar();
            this.progressMoisture = new System.Windows.Forms.ProgressBar();
            this.progressTimerLight = new System.Windows.Forms.Timer(this.components);
            this.progressTimerMotion = new System.Windows.Forms.Timer(this.components);
            this.progressTimerMoisture = new System.Windows.Forms.Timer(this.components);
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFanSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTargetTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLightTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMoistureTarget)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.BackColor = System.Drawing.Color.White;
            this.cmbSerialPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSerialPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(73, 33);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(205, 24);
            this.cmbSerialPorts.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Teal;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.Location = new System.Drawing.Point(73, 63);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 27);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Red;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisconnect.Location = new System.Drawing.Point(165, 63);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(113, 27);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Moisture";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Motion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Light";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMoisture
            // 
            this.txtMoisture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(41)))));
            this.txtMoisture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoisture.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMoisture.ForeColor = System.Drawing.Color.White;
            this.txtMoisture.Location = new System.Drawing.Point(8, 40);
            this.txtMoisture.Multiline = true;
            this.txtMoisture.Name = "txtMoisture";
            this.txtMoisture.ReadOnly = true;
            this.txtMoisture.Size = new System.Drawing.Size(272, 42);
            this.txtMoisture.TabIndex = 12;
            this.txtMoisture.Text = "0";
            this.txtMoisture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMoisture.TextChanged += new System.EventHandler(this.txtMoisture_TextChanged);
            // 
            // txtMovement
            // 
            this.txtMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtMovement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMovement.ForeColor = System.Drawing.Color.White;
            this.txtMovement.Location = new System.Drawing.Point(7, 40);
            this.txtMovement.Multiline = true;
            this.txtMovement.Name = "txtMovement";
            this.txtMovement.ReadOnly = true;
            this.txtMovement.Size = new System.Drawing.Size(285, 42);
            this.txtMovement.TabIndex = 11;
            this.txtMovement.Text = "0";
            this.txtMovement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMovement.TextChanged += new System.EventHandler(this.txtMovement_TextChanged);
            // 
            // txtLight
            // 
            this.txtLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(41)))));
            this.txtLight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLight.ForeColor = System.Drawing.Color.White;
            this.txtLight.Location = new System.Drawing.Point(7, 40);
            this.txtLight.Multiline = true;
            this.txtLight.Name = "txtLight";
            this.txtLight.ReadOnly = true;
            this.txtLight.Size = new System.Drawing.Size(284, 42);
            this.txtLight.TabIndex = 10;
            this.txtLight.Text = "0";
            this.txtLight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLight.TextChanged += new System.EventHandler(this.txtLight_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Temperature";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTemperature
            // 
            this.txtTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTemperature.ForeColor = System.Drawing.Color.White;
            this.txtTemperature.Location = new System.Drawing.Point(10, 41);
            this.txtTemperature.Multiline = true;
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.ReadOnly = true;
            this.txtTemperature.Size = new System.Drawing.Size(282, 41);
            this.txtTemperature.TabIndex = 16;
            this.txtTemperature.Text = "0";
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTemperature.TextChanged += new System.EventHandler(this.txtTemperature_TextChanged);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(8, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fan Speed";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label6.Location = new System.Drawing.Point(12, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Target Temperature";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sliderFanSpeed
            // 
            this.sliderFanSpeed.Location = new System.Drawing.Point(12, 226);
            this.sliderFanSpeed.Maximum = 255;
            this.sliderFanSpeed.Name = "sliderFanSpeed";
            this.sliderFanSpeed.Size = new System.Drawing.Size(282, 45);
            this.sliderFanSpeed.TabIndex = 22;
            this.sliderFanSpeed.TickFrequency = 5;
            this.sliderFanSpeed.Value = 255;
            this.sliderFanSpeed.Scroll += new System.EventHandler(this.sliderFanSpeed_Scroll);
            // 
            // sliderTargetTemperature
            // 
            this.sliderTargetTemperature.Location = new System.Drawing.Point(16, 119);
            this.sliderTargetTemperature.Maximum = 50;
            this.sliderTargetTemperature.Name = "sliderTargetTemperature";
            this.sliderTargetTemperature.Size = new System.Drawing.Size(278, 45);
            this.sliderTargetTemperature.TabIndex = 23;
            this.sliderTargetTemperature.Value = 50;
            this.sliderTargetTemperature.Scroll += new System.EventHandler(this.sliderTargetTemperature_Scroll);
            // 
            // lblTarget
            // 
            this.lblTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarget.ForeColor = System.Drawing.Color.White;
            this.lblTarget.Location = new System.Drawing.Point(12, 155);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(123, 36);
            this.lblTarget.TabIndex = 24;
            this.lblTarget.Text = "TempeTemp";
            this.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFanSpeed
            // 
            this.lblFanSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFanSpeed.ForeColor = System.Drawing.Color.White;
            this.lblFanSpeed.Location = new System.Drawing.Point(8, 264);
            this.lblFanSpeed.Name = "lblFanSpeed";
            this.lblFanSpeed.Size = new System.Drawing.Size(286, 27);
            this.lblFanSpeed.TabIndex = 25;
            this.lblFanSpeed.Text = "FanSpeedTemp";
            this.lblFanSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFanStop
            // 
            this.btnFanStop.BackColor = System.Drawing.Color.Firebrick;
            this.btnFanStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFanStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFanStop.ForeColor = System.Drawing.Color.Black;
            this.btnFanStop.Location = new System.Drawing.Point(7, 298);
            this.btnFanStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnFanStop.Name = "btnFanStop";
            this.btnFanStop.Size = new System.Drawing.Size(288, 64);
            this.btnFanStop.TabIndex = 28;
            this.btnFanStop.Text = "Stop Fan";
            this.btnFanStop.UseVisualStyleBackColor = false;
            this.btnFanStop.Visible = false;
            this.btnFanStop.Click += new System.EventHandler(this.btnFanStop_Click);
            // 
            // cmbLightColors
            // 
            this.cmbLightColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLightColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbLightColors.FormattingEnabled = true;
            this.cmbLightColors.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Purple"});
            this.cmbLightColors.Location = new System.Drawing.Point(10, 226);
            this.cmbLightColors.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLightColors.Name = "cmbLightColors";
            this.cmbLightColors.Size = new System.Drawing.Size(281, 28);
            this.cmbLightColors.TabIndex = 29;
            this.cmbLightColors.Text = "Temp";
            // 
            // lblLightTarget
            // 
            this.lblLightTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLightTarget.ForeColor = System.Drawing.Color.White;
            this.lblLightTarget.Location = new System.Drawing.Point(6, 159);
            this.lblLightTarget.Name = "lblLightTarget";
            this.lblLightTarget.Size = new System.Drawing.Size(285, 28);
            this.lblLightTarget.TabIndex = 32;
            this.lblLightTarget.Text = "LightTemp";
            this.lblLightTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sliderLightTarget
            // 
            this.sliderLightTarget.Location = new System.Drawing.Point(7, 119);
            this.sliderLightTarget.Maximum = 1023;
            this.sliderLightTarget.Name = "sliderLightTarget";
            this.sliderLightTarget.Size = new System.Drawing.Size(284, 45);
            this.sliderLightTarget.TabIndex = 31;
            this.sliderLightTarget.TickFrequency = 20;
            this.sliderLightTarget.Scroll += new System.EventHandler(this.sliderLightTarget_Scroll);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label8.Location = new System.Drawing.Point(6, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Target Light Intensity";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLightTime
            // 
            this.txtLightTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLightTime.Location = new System.Drawing.Point(12, 300);
            this.txtLightTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtLightTime.Name = "txtLightTime";
            this.txtLightTime.Size = new System.Drawing.Size(175, 26);
            this.txtLightTime.TabIndex = 33;
            this.txtLightTime.Text = "5";
            this.txtLightTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLightTime.TextChanged += new System.EventHandler(this.txtLightTime_TextChanged);
            // 
            // lightTimer
            // 
            this.lightTimer.Tick += new System.EventHandler(this.lightTimer_Tick);
            // 
            // movementTimer
            // 
            this.movementTimer.Interval = 5000;
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // radioBtnOff
            // 
            this.radioBtnOff.AutoSize = true;
            this.radioBtnOff.Checked = true;
            this.radioBtnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBtnOff.ForeColor = System.Drawing.Color.White;
            this.radioBtnOff.Location = new System.Drawing.Point(112, 123);
            this.radioBtnOff.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnOff.Name = "radioBtnOff";
            this.radioBtnOff.Size = new System.Drawing.Size(38, 17);
            this.radioBtnOff.TabIndex = 34;
            this.radioBtnOff.TabStop = true;
            this.radioBtnOff.Text = "Off";
            this.radioBtnOff.UseVisualStyleBackColor = true;
            this.radioBtnOff.Click += new System.EventHandler(this.radioBtnOff_Click);
            // 
            // radioBtnOn
            // 
            this.radioBtnOn.AutoSize = true;
            this.radioBtnOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBtnOn.ForeColor = System.Drawing.Color.White;
            this.radioBtnOn.Location = new System.Drawing.Point(153, 123);
            this.radioBtnOn.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnOn.Name = "radioBtnOn";
            this.radioBtnOn.Size = new System.Drawing.Size(38, 17);
            this.radioBtnOn.TabIndex = 35;
            this.radioBtnOn.Text = "On";
            this.radioBtnOn.UseVisualStyleBackColor = true;
            this.radioBtnOn.Click += new System.EventHandler(this.radioBtnOn_Click);
            // 
            // txtBuzzerTime
            // 
            this.txtBuzzerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBuzzerTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuzzerTime.Location = new System.Drawing.Point(10, 182);
            this.txtBuzzerTime.Name = "txtBuzzerTime";
            this.txtBuzzerTime.Size = new System.Drawing.Size(173, 26);
            this.txtBuzzerTime.TabIndex = 36;
            this.txtBuzzerTime.Text = "5";
            this.txtBuzzerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuzzerTime.TextChanged += new System.EventHandler(this.txtBuzzerTime_TextChanged);
            // 
            // cmbMoisture
            // 
            this.cmbMoisture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMoisture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMoisture.FormattingEnabled = true;
            this.cmbMoisture.Items.AddRange(new object[] {
            "Some",
            "Medium",
            "Much"});
            this.cmbMoisture.Location = new System.Drawing.Point(7, 226);
            this.cmbMoisture.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMoisture.Name = "cmbMoisture";
            this.cmbMoisture.Size = new System.Drawing.Size(274, 28);
            this.cmbMoisture.TabIndex = 37;
            this.cmbMoisture.Text = "Temp";
            // 
            // lblMoistureTarget
            // 
            this.lblMoistureTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoistureTarget.ForeColor = System.Drawing.Color.White;
            this.lblMoistureTarget.Location = new System.Drawing.Point(6, 162);
            this.lblMoistureTarget.Name = "lblMoistureTarget";
            this.lblMoistureTarget.Size = new System.Drawing.Size(275, 25);
            this.lblMoistureTarget.TabIndex = 40;
            this.lblMoistureTarget.Text = "MoistureTemp";
            this.lblMoistureTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sliderMoistureTarget
            // 
            this.sliderMoistureTarget.Location = new System.Drawing.Point(6, 119);
            this.sliderMoistureTarget.Maximum = 1023;
            this.sliderMoistureTarget.Name = "sliderMoistureTarget";
            this.sliderMoistureTarget.Size = new System.Drawing.Size(272, 45);
            this.sliderMoistureTarget.TabIndex = 39;
            this.sliderMoistureTarget.TickFrequency = 20;
            this.sliderMoistureTarget.Scroll += new System.EventHandler(this.sliderMoistureTarget_Scroll);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label9.Location = new System.Drawing.Point(6, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 22);
            this.label9.TabIndex = 38;
            this.label9.Text = "Target Moisture";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moistureTimer
            // 
            this.moistureTimer.Tick += new System.EventHandler(this.moistureTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 100);
            this.panel1.TabIndex = 41;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.panel11.Controls.Add(this.label22);
            this.panel11.Controls.Add(this.cmbSerialPorts);
            this.panel11.Controls.Add(this.btnConnect);
            this.panel11.Controls.Add(this.btnDisconnect);
            this.panel11.Controls.Add(this.pictureBox6);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(900, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(290, 100);
            this.panel11.TabIndex = 5;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(-21, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(116, 82);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 100);
            this.panel6.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label7.Location = new System.Drawing.Point(3, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Plant Care System";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btnFanStop);
            this.panel2.Controls.Add(this.txtTemperature);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.sliderFanSpeed);
            this.panel2.Controls.Add(this.sliderTargetTemperature);
            this.panel2.Controls.Add(this.lblTarget);
            this.panel2.Controls.Add(this.lblFanSpeed);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 467);
            this.panel2.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(130, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 36);
            this.label14.TabIndex = 35;
            this.label14.Text = "Celcius";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 367);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 100);
            this.panel7.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label10.Location = new System.Drawing.Point(3, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(294, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "Air And Temperature";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 62);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.progressLight);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.cmbLightColors);
            this.panel3.Controls.Add(this.txtLight);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.sliderLightTarget);
            this.panel3.Controls.Add(this.lblLightTarget);
            this.panel3.Controls.Add(this.txtLightTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(300, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 467);
            this.panel3.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(192, 302);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 24);
            this.label17.TabIndex = 38;
            this.label17.Text = "Seconds";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label16.Location = new System.Drawing.Point(8, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(286, 24);
            this.label16.TabIndex = 37;
            this.label16.Text = "Light Duration";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label15.Location = new System.Drawing.Point(6, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(286, 24);
            this.label15.TabIndex = 36;
            this.label15.Text = "Light Color";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.pictureBox3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 367);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 100);
            this.panel8.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label11.Location = new System.Drawing.Point(3, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(294, 29);
            this.label11.TabIndex = 4;
            this.label11.Text = "Light";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(294, 62);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.progressMotion);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtMovement);
            this.panel4.Controls.Add(this.radioBtnOff);
            this.panel4.Controls.Add(this.radioBtnOn);
            this.panel4.Controls.Add(this.txtBuzzerTime);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(600, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 467);
            this.panel4.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(189, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 24);
            this.label20.TabIndex = 39;
            this.label20.Text = "Seconds";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label19.Location = new System.Drawing.Point(6, 151);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(285, 24);
            this.label19.TabIndex = 39;
            this.label19.Text = "Sound Duration";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label18.Location = new System.Drawing.Point(6, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(285, 24);
            this.label18.TabIndex = 38;
            this.label18.Text = "Detection";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel9.Controls.Add(this.label12);
            this.panel9.Controls.Add(this.pictureBox4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 367);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 100);
            this.panel9.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label12.Location = new System.Drawing.Point(3, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(294, 29);
            this.label12.TabIndex = 4;
            this.label12.Text = "Motion Detection";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(294, 62);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.panel5.Controls.Add(this.progressMoisture);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.txtMoisture);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cmbMoisture);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.sliderMoistureTarget);
            this.panel5.Controls.Add(this.lblMoistureTarget);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(900, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 467);
            this.panel5.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label21.Location = new System.Drawing.Point(3, 199);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(285, 24);
            this.label21.TabIndex = 40;
            this.label21.Text = "Water Amount";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.pictureBox5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 367);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(300, 100);
            this.panel10.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label13.Location = new System.Drawing.Point(-4, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(294, 29);
            this.label13.TabIndex = 4;
            this.label13.Text = "Moisture And Water";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(294, 62);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // progressLight
            // 
            this.progressLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.progressLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.progressLight.Location = new System.Drawing.Point(10, 338);
            this.progressLight.Maximum = 5;
            this.progressLight.Name = "progressLight";
            this.progressLight.Size = new System.Drawing.Size(281, 23);
            this.progressLight.Step = 1;
            this.progressLight.TabIndex = 39;
            this.progressLight.Visible = false;
            // 
            // progressMotion
            // 
            this.progressMotion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.progressMotion.Location = new System.Drawing.Point(10, 338);
            this.progressMotion.Maximum = 5;
            this.progressMotion.Name = "progressMotion";
            this.progressMotion.Size = new System.Drawing.Size(281, 23);
            this.progressMotion.Step = 1;
            this.progressMotion.TabIndex = 40;
            this.progressMotion.Visible = false;
            // 
            // progressMoisture
            // 
            this.progressMoisture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.progressMoisture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.progressMoisture.Location = new System.Drawing.Point(10, 338);
            this.progressMoisture.Maximum = 3;
            this.progressMoisture.Name = "progressMoisture";
            this.progressMoisture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressMoisture.Size = new System.Drawing.Size(268, 23);
            this.progressMoisture.Step = 1;
            this.progressMoisture.TabIndex = 41;
            this.progressMoisture.Visible = false;
            // 
            // progressTimerLight
            // 
            this.progressTimerLight.Tick += new System.EventHandler(this.progressTimerLight_Tick);
            // 
            // progressTimerMotion
            // 
            this.progressTimerMotion.Tick += new System.EventHandler(this.progressTimerMotion_Tick);
            // 
            // progressTimerMoisture
            // 
            this.progressTimerMoisture.Tick += new System.EventHandler(this.progressTimerMoisture_Tick);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label22.Location = new System.Drawing.Point(72, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(208, 24);
            this.label22.TabIndex = 42;
            this.label22.Text = "Selected Port";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1190, 567);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "PlantCareSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sliderFanSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTargetTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLightTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMoistureTarget)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoisture;
        private System.Windows.Forms.TextBox txtMovement;
        private System.Windows.Forms.TextBox txtLight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar sliderFanSpeed;
        private System.Windows.Forms.TrackBar sliderTargetTemperature;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblFanSpeed;
        private System.Windows.Forms.Button btnFanStop;
        private System.Windows.Forms.ComboBox cmbLightColors;
        private System.Windows.Forms.Label lblLightTarget;
        private System.Windows.Forms.TrackBar sliderLightTarget;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLightTime;
        private System.Windows.Forms.Timer lightTimer;
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.RadioButton radioBtnOff;
        private System.Windows.Forms.RadioButton radioBtnOn;
        private System.Windows.Forms.TextBox txtBuzzerTime;
        private System.Windows.Forms.ComboBox cmbMoisture;
        private System.Windows.Forms.Label lblMoistureTarget;
        private System.Windows.Forms.TrackBar sliderMoistureTarget;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer moistureTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ProgressBar progressMotion;
        private System.Windows.Forms.ProgressBar progressMoisture;
        private System.Windows.Forms.Timer progressTimerLight;
        private System.Windows.Forms.Timer progressTimerMotion;
        private System.Windows.Forms.Timer progressTimerMoisture;
        private System.Windows.Forms.ProgressBar progressLight;
        private System.Windows.Forms.Label label22;
    }
}

