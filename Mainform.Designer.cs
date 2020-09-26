namespace BTDeviceTemparatureMonitor
{
    partial class Mainform
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.cbBTDevices = new System.Windows.Forms.ComboBox();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabChart = new System.Windows.Forms.TabControl();
            this.pgConnectivity = new System.Windows.Forms.TabPage();
            this.panelAlerts = new System.Windows.Forms.Panel();
            this.lblNotification = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBoxSettings = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkTelegram = new System.Windows.Forms.CheckBox();
            this.chkSMS = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.txtAlertVal = new System.Windows.Forms.TextBox();
            this.lblAlertValue = new System.Windows.Forms.Label();
            this.lbConnectionStatus = new System.Windows.Forms.Label();
            this.pgConnectionTest = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.pgHumidProgress = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tempDisplayPanel = new System.Windows.Forms.Panel();
            this.labelTempDisplay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pgBarHighestTemp = new System.Windows.Forms.ProgressBar();
            this.pgBarCurrentTemp = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gaugeTemparature = new System.Windows.Forms.AGauge();
            this.verticalProgressBar1 = new BTDeviceTemparatureMonitor.VerticalProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartHumidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTemparature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpBoxFeatures = new System.Windows.Forms.GroupBox();
            this.chckBoxEmailAlert = new System.Windows.Forms.CheckBox();
            this.chckBoxSMSAlert = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.gaugeHumidity = new BTDeviceTemparatureMonitor.CircularProgressBar();
            this.verticalProgressBar2 = new BTDeviceTemparatureMonitor.VerticalProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabChart.SuspendLayout();
            this.pgConnectivity.SuspendLayout();
            this.panelAlerts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxSettings.SuspendLayout();
            this.pgConnectionTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tempDisplayPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemparature)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBTDevices
            // 
            this.cbBTDevices.FormattingEnabled = true;
            this.cbBTDevices.Location = new System.Drawing.Point(18, 21);
            this.cbBTDevices.Name = "cbBTDevices";
            this.cbBTDevices.Size = new System.Drawing.Size(142, 21);
            this.cbBTDevices.TabIndex = 0;
            this.cbBTDevices.SelectedIndexChanged += new System.EventHandler(this.cbBTDevices_SelectedIndexChanged);
            // 
            // btnDiscover
            // 
            this.btnDiscover.Location = new System.Drawing.Point(166, 19);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(75, 23);
            this.btnDiscover.TabIndex = 1;
            this.btnDiscover.Text = "Discover";
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(247, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(328, 19);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(33, 103);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(364, 264);
            this.txtDisplay.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(325, 386);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(37, 386);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(282, 20);
            this.txtSend.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(34, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output Display";
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.pgConnectivity);
            this.tabChart.Controls.Add(this.pgConnectionTest);
            this.tabChart.Controls.Add(this.tabPage1);
            this.tabChart.Controls.Add(this.tabPage2);
            this.tabChart.Location = new System.Drawing.Point(12, 12);
            this.tabChart.Name = "tabChart";
            this.tabChart.SelectedIndex = 0;
            this.tabChart.Size = new System.Drawing.Size(725, 474);
            this.tabChart.TabIndex = 8;
            // 
            // pgConnectivity
            // 
            this.pgConnectivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pgConnectivity.Controls.Add(this.panelAlerts);
            this.pgConnectivity.Controls.Add(this.groupBox1);
            this.pgConnectivity.Controls.Add(this.grpBoxSettings);
            this.pgConnectivity.Controls.Add(this.lbConnectionStatus);
            this.pgConnectivity.Controls.Add(this.label1);
            this.pgConnectivity.Controls.Add(this.txtSend);
            this.pgConnectivity.Controls.Add(this.btnSend);
            this.pgConnectivity.Controls.Add(this.txtDisplay);
            this.pgConnectivity.Cursor = System.Windows.Forms.Cursors.Default;
            this.pgConnectivity.Location = new System.Drawing.Point(4, 22);
            this.pgConnectivity.Name = "pgConnectivity";
            this.pgConnectivity.Padding = new System.Windows.Forms.Padding(3);
            this.pgConnectivity.Size = new System.Drawing.Size(717, 448);
            this.pgConnectivity.TabIndex = 0;
            this.pgConnectivity.Text = "Connectivity";
            // 
            // panelAlerts
            // 
            this.panelAlerts.Controls.Add(this.lblNotification);
            this.panelAlerts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlerts.ForeColor = System.Drawing.Color.Yellow;
            this.panelAlerts.Location = new System.Drawing.Point(3, 3);
            this.panelAlerts.Name = "panelAlerts";
            this.panelAlerts.Size = new System.Drawing.Size(711, 19);
            this.panelAlerts.TabIndex = 11;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.Location = new System.Drawing.Point(247, 1);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(148, 18);
            this.lblNotification.TabIndex = 0;
            this.lblNotification.Text = "AlertNotificationPanel";
            this.lblNotification.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnDiscover);
            this.groupBox1.Controls.Add(this.cbBTDevices);
            this.groupBox1.Location = new System.Drawing.Point(16, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 55);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DeviceConnection";
            // 
            // grpBoxSettings
            // 
            this.grpBoxSettings.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxSettings.Controls.Add(this.label12);
            this.grpBoxSettings.Controls.Add(this.chkTelegram);
            this.grpBoxSettings.Controls.Add(this.chkSMS);
            this.grpBoxSettings.Controls.Add(this.chkEmail);
            this.grpBoxSettings.Controls.Add(this.txtAlertVal);
            this.grpBoxSettings.Controls.Add(this.lblAlertValue);
            this.grpBoxSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxSettings.Location = new System.Drawing.Point(457, 29);
            this.grpBoxSettings.Name = "grpBoxSettings";
            this.grpBoxSettings.Size = new System.Drawing.Size(236, 90);
            this.grpBoxSettings.TabIndex = 9;
            this.grpBoxSettings.TabStop = false;
            this.grpBoxSettings.Text = "Settings";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(129, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "celsius";
            // 
            // chkTelegram
            // 
            this.chkTelegram.AutoSize = true;
            this.chkTelegram.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkTelegram.Location = new System.Drawing.Point(122, 53);
            this.chkTelegram.Name = "chkTelegram";
            this.chkTelegram.Size = new System.Drawing.Size(70, 17);
            this.chkTelegram.TabIndex = 4;
            this.chkTelegram.Text = "Telegram";
            this.chkTelegram.UseVisualStyleBackColor = true;
            // 
            // chkSMS
            // 
            this.chkSMS.AutoSize = true;
            this.chkSMS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkSMS.Location = new System.Drawing.Point(67, 53);
            this.chkSMS.Name = "chkSMS";
            this.chkSMS.Size = new System.Drawing.Size(49, 17);
            this.chkSMS.TabIndex = 3;
            this.chkSMS.Text = "SMS";
            this.chkSMS.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkEmail.Location = new System.Drawing.Point(10, 53);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(51, 17);
            this.chkEmail.TabIndex = 2;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // txtAlertVal
            // 
            this.txtAlertVal.Location = new System.Drawing.Point(69, 20);
            this.txtAlertVal.Name = "txtAlertVal";
            this.txtAlertVal.Size = new System.Drawing.Size(54, 20);
            this.txtAlertVal.TabIndex = 1;
            this.txtAlertVal.Text = "48";
            // 
            // lblAlertValue
            // 
            this.lblAlertValue.AutoSize = true;
            this.lblAlertValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAlertValue.Location = new System.Drawing.Point(7, 20);
            this.lblAlertValue.Name = "lblAlertValue";
            this.lblAlertValue.Size = new System.Drawing.Size(55, 13);
            this.lblAlertValue.TabIndex = 0;
            this.lblAlertValue.Text = "AlertValue";
            // 
            // lbConnectionStatus
            // 
            this.lbConnectionStatus.AutoSize = true;
            this.lbConnectionStatus.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectionStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbConnectionStatus.Location = new System.Drawing.Point(447, 219);
            this.lbConnectionStatus.Name = "lbConnectionStatus";
            this.lbConnectionStatus.Size = new System.Drawing.Size(210, 27);
            this.lbConnectionStatus.TabIndex = 8;
            this.lbConnectionStatus.Text = "Connection Status";
            // 
            // pgConnectionTest
            // 
            this.pgConnectionTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pgConnectionTest.Controls.Add(this.label11);
            this.pgConnectionTest.Controls.Add(this.pgHumidProgress);
            this.pgConnectionTest.Controls.Add(this.pictureBox2);
            this.pgConnectionTest.Controls.Add(this.panel2);
            this.pgConnectionTest.Controls.Add(this.pictureBox1);
            this.pgConnectionTest.Controls.Add(this.tempDisplayPanel);
            this.pgConnectionTest.Controls.Add(this.label7);
            this.pgConnectionTest.Controls.Add(this.label6);
            this.pgConnectionTest.Controls.Add(this.label5);
            this.pgConnectionTest.Controls.Add(this.label4);
            this.pgConnectionTest.Controls.Add(this.pgBarHighestTemp);
            this.pgConnectionTest.Controls.Add(this.pgBarCurrentTemp);
            this.pgConnectionTest.Controls.Add(this.label3);
            this.pgConnectionTest.Controls.Add(this.label2);
            this.pgConnectionTest.Location = new System.Drawing.Point(4, 22);
            this.pgConnectionTest.Name = "pgConnectionTest";
            this.pgConnectionTest.Padding = new System.Windows.Forms.Padding(3);
            this.pgConnectionTest.Size = new System.Drawing.Size(717, 448);
            this.pgConnectionTest.TabIndex = 1;
            this.pgConnectionTest.Text = "DashBoard";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(388, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Current Humidity";
            // 
            // pgHumidProgress
            // 
            this.pgHumidProgress.Location = new System.Drawing.Point(478, 294);
            this.pgHumidProgress.Name = "pgHumidProgress";
            this.pgHumidProgress.Size = new System.Drawing.Size(192, 28);
            this.pgHumidProgress.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::BTDeviceTemparatureMonitor.Properties.Resources.suntemp1;
            this.pictureBox2.Location = new System.Drawing.Point(77, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 90);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblHumidity);
            this.panel2.Location = new System.Drawing.Point(406, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 99);
            this.panel2.TabIndex = 9;
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblHumidity.Location = new System.Drawing.Point(26, 14);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(188, 66);
            this.lblHumidity.TabIndex = 1;
            this.lblHumidity.Text = "33 %";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::BTDeviceTemparatureMonitor.Properties.Resources.Humidity1;
            this.pictureBox1.Location = new System.Drawing.Point(443, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 130);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tempDisplayPanel
            // 
            this.tempDisplayPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tempDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempDisplayPanel.Controls.Add(this.labelTempDisplay);
            this.tempDisplayPanel.Location = new System.Drawing.Point(66, 170);
            this.tempDisplayPanel.Name = "tempDisplayPanel";
            this.tempDisplayPanel.Size = new System.Drawing.Size(264, 99);
            this.tempDisplayPanel.TabIndex = 8;
            // 
            // labelTempDisplay
            // 
            this.labelTempDisplay.AutoSize = true;
            this.labelTempDisplay.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempDisplay.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelTempDisplay.Location = new System.Drawing.Point(18, 14);
            this.labelTempDisplay.Name = "labelTempDisplay";
            this.labelTempDisplay.Size = new System.Drawing.Size(228, 66);
            this.labelTempDisplay.TabIndex = 0;
            this.labelTempDisplay.Text = "33.40";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(16, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Highest Temparature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(16, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current Temparature";
            // 
            // pgBarHighestTemp
            // 
            this.pgBarHighestTemp.Location = new System.Drawing.Point(126, 343);
            this.pgBarHighestTemp.Name = "pgBarHighestTemp";
            this.pgBarHighestTemp.Size = new System.Drawing.Size(204, 28);
            this.pgBarHighestTemp.TabIndex = 3;
            // 
            // pgBarCurrentTemp
            // 
            this.pgBarCurrentTemp.Location = new System.Drawing.Point(126, 294);
            this.pgBarCurrentTemp.Name = "pgBarCurrentTemp";
            this.pgBarCurrentTemp.Size = new System.Drawing.Size(204, 28);
            this.pgBarCurrentTemp.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.verticalProgressBar2);
            this.tabPage1.Controls.Add(this.gaugeHumidity);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.verticalProgressBar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 448);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Gauge";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(295, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(303, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.gaugeTemparature);
            this.panel1.Location = new System.Drawing.Point(24, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 230);
            this.panel1.TabIndex = 2;
            // 
            // gaugeTemparature
            // 
            this.gaugeTemparature.AllowDrop = true;
            this.gaugeTemparature.BackColor = System.Drawing.Color.Cornsilk;
            this.gaugeTemparature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gaugeTemparature.BaseArcColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gaugeTemparature.BaseArcRadius = 80;
            this.gaugeTemparature.BaseArcStart = 135;
            this.gaugeTemparature.BaseArcSweep = 270;
            this.gaugeTemparature.BaseArcWidth = 2;
            this.gaugeTemparature.Center = new System.Drawing.Point(100, 100);
            this.gaugeTemparature.Location = new System.Drawing.Point(20, 21);
            this.gaugeTemparature.MaxValue = 100F;
            this.gaugeTemparature.MinValue = 0F;
            this.gaugeTemparature.Name = "gaugeTemparature";
            this.gaugeTemparature.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.gaugeTemparature.NeedleColor2 = System.Drawing.Color.Olive;
            this.gaugeTemparature.NeedleRadius = 80;
            this.gaugeTemparature.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.gaugeTemparature.NeedleWidth = 2;
            this.gaugeTemparature.ScaleLinesInterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gaugeTemparature.ScaleLinesInterInnerRadius = 73;
            this.gaugeTemparature.ScaleLinesInterOuterRadius = 80;
            this.gaugeTemparature.ScaleLinesInterWidth = 1;
            this.gaugeTemparature.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaugeTemparature.ScaleLinesMajorInnerRadius = 70;
            this.gaugeTemparature.ScaleLinesMajorOuterRadius = 80;
            this.gaugeTemparature.ScaleLinesMajorStepValue = 10F;
            this.gaugeTemparature.ScaleLinesMajorWidth = 2;
            this.gaugeTemparature.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gaugeTemparature.ScaleLinesMinorInnerRadius = 75;
            this.gaugeTemparature.ScaleLinesMinorOuterRadius = 80;
            this.gaugeTemparature.ScaleLinesMinorTicks = 9;
            this.gaugeTemparature.ScaleLinesMinorWidth = 1;
            this.gaugeTemparature.ScaleNumbersColor = System.Drawing.Color.Olive;
            this.gaugeTemparature.ScaleNumbersFormat = null;
            this.gaugeTemparature.ScaleNumbersRadius = 95;
            this.gaugeTemparature.ScaleNumbersRotation = 0;
            this.gaugeTemparature.ScaleNumbersStartScaleLine = 0;
            this.gaugeTemparature.ScaleNumbersStepScaleLines = 1;
            this.gaugeTemparature.Size = new System.Drawing.Size(205, 196);
            this.gaugeTemparature.TabIndex = 0;
            this.gaugeTemparature.Text = "aGauge1";
            this.gaugeTemparature.Value = 0F;
            // 
            // verticalProgressBar1
            // 
            this.verticalProgressBar1.Location = new System.Drawing.Point(298, 77);
            this.verticalProgressBar1.Name = "verticalProgressBar1";
            this.verticalProgressBar1.Size = new System.Drawing.Size(23, 193);
            this.verticalProgressBar1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.chartHumidity);
            this.tabPage2.Controls.Add(this.chartTemparature);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 448);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Chart";
            // 
            // chartHumidity
            // 
            chartArea3.AxisX.LineColor = System.Drawing.Color.ForestGreen;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Firebrick;
            chartArea3.AxisY.Maximum = 100D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chartHumidity.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartHumidity.Legends.Add(legend3);
            this.chartHumidity.Location = new System.Drawing.Point(358, 59);
            this.chartHumidity.Name = "chartHumidity";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "LiveHumidity";
            dataPoint13.IsEmpty = true;
            dataPoint14.IsEmpty = true;
            dataPoint15.IsEmpty = true;
            dataPoint16.IsEmpty = true;
            dataPoint17.IsEmpty = true;
            dataPoint18.IsEmpty = true;
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            series3.Points.Add(dataPoint16);
            series3.Points.Add(dataPoint17);
            series3.Points.Add(dataPoint18);
            this.chartHumidity.Series.Add(series3);
            this.chartHumidity.Size = new System.Drawing.Size(346, 324);
            this.chartHumidity.TabIndex = 1;
            this.chartHumidity.Text = "chart1";
            // 
            // chartTemparature
            // 
            chartArea4.AxisX.LineColor = System.Drawing.Color.ForestGreen;
            chartArea4.AxisY.LineColor = System.Drawing.Color.Firebrick;
            chartArea4.AxisY.Maximum = 100D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.chartTemparature.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTemparature.Legends.Add(legend4);
            this.chartTemparature.Location = new System.Drawing.Point(6, 59);
            this.chartTemparature.Name = "chartTemparature";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "LiveTemparature";
            dataPoint19.IsEmpty = true;
            dataPoint20.IsEmpty = true;
            dataPoint21.IsEmpty = true;
            dataPoint22.IsEmpty = true;
            dataPoint23.IsEmpty = true;
            dataPoint24.IsEmpty = true;
            series4.Points.Add(dataPoint19);
            series4.Points.Add(dataPoint20);
            series4.Points.Add(dataPoint21);
            series4.Points.Add(dataPoint22);
            series4.Points.Add(dataPoint23);
            series4.Points.Add(dataPoint24);
            this.chartTemparature.Series.Add(series4);
            this.chartTemparature.Size = new System.Drawing.Size(346, 324);
            this.chartTemparature.TabIndex = 0;
            this.chartTemparature.Text = "chart1";
            this.chartTemparature.Click += new System.EventHandler(this.chartTemparature_Click);
            // 
            // grpBoxFeatures
            // 
            this.grpBoxFeatures.Location = new System.Drawing.Point(0, 0);
            this.grpBoxFeatures.Name = "grpBoxFeatures";
            this.grpBoxFeatures.Size = new System.Drawing.Size(200, 100);
            this.grpBoxFeatures.TabIndex = 0;
            this.grpBoxFeatures.TabStop = false;
            // 
            // chckBoxEmailAlert
            // 
            this.chckBoxEmailAlert.Location = new System.Drawing.Point(0, 0);
            this.chckBoxEmailAlert.Name = "chckBoxEmailAlert";
            this.chckBoxEmailAlert.Size = new System.Drawing.Size(104, 24);
            this.chckBoxEmailAlert.TabIndex = 0;
            // 
            // chckBoxSMSAlert
            // 
            this.chckBoxSMSAlert.Location = new System.Drawing.Point(0, 0);
            this.chckBoxSMSAlert.Name = "chckBoxSMSAlert";
            this.chckBoxSMSAlert.Size = new System.Drawing.Size(104, 24);
            this.chckBoxSMSAlert.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(40, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Current Temparature Gauge";
            // 
            // gaugeHumidity
            // 
            this.gaugeHumidity.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gaugeHumidity.Location = new System.Drawing.Point(414, 53);
            this.gaugeHumidity.Maximum = ((long)(100));
            this.gaugeHumidity.MinimumSize = new System.Drawing.Size(100, 100);
            this.gaugeHumidity.Name = "gaugeHumidity";
            this.gaugeHumidity.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.gaugeHumidity.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.gaugeHumidity.ProgressShape = BTDeviceTemparatureMonitor.CircularProgressBar._ProgressShape.Round;
            this.gaugeHumidity.Size = new System.Drawing.Size(230, 230);
            this.gaugeHumidity.TabIndex = 7;
            this.gaugeHumidity.Text = "circularProgressBar1";
            this.gaugeHumidity.Value = ((long)(0));
            // 
            // verticalProgressBar2
            // 
            this.verticalProgressBar2.Location = new System.Drawing.Point(676, 74);
            this.verticalProgressBar2.Name = "verticalProgressBar2";
            this.verticalProgressBar2.Size = new System.Drawing.Size(23, 193);
            this.verticalProgressBar2.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(682, 289);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 19);
            this.label14.TabIndex = 9;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(672, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 19);
            this.label15.TabIndex = 10;
            this.label15.Text = "100";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(434, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Current Humidity Gauge";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 488);
            this.Controls.Add(this.tabChart);
            this.MaximumSize = new System.Drawing.Size(800, 530);
            this.Name = "Mainform";
            this.Text = "EnviTracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabChart.ResumeLayout(false);
            this.pgConnectivity.ResumeLayout(false);
            this.pgConnectivity.PerformLayout();
            this.panelAlerts.ResumeLayout(false);
            this.panelAlerts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpBoxSettings.ResumeLayout(false);
            this.grpBoxSettings.PerformLayout();
            this.pgConnectionTest.ResumeLayout(false);
            this.pgConnectionTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tempDisplayPanel.ResumeLayout(false);
            this.tempDisplayPanel.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemparature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBTDevices;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabChart;
        private System.Windows.Forms.TabPage pgConnectivity;
        private System.Windows.Forms.TabPage pgConnectionTest;
        private System.Windows.Forms.Label lbConnectionStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pgBarHighestTemp;
        private System.Windows.Forms.ProgressBar pgBarCurrentTemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel tempDisplayPanel;
        private System.Windows.Forms.Label labelTempDisplay;
        private System.Windows.Forms.GroupBox grpBoxFeatures;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chckBoxSMSAlert;
        private System.Windows.Forms.CheckBox chckBoxEmailAlert;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.AGauge gaugeTemparature;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemparature;
        private VerticalProgressBar verticalProgressBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHumidity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar pgHumidProgress;
        private System.Windows.Forms.GroupBox grpBoxSettings;
        private System.Windows.Forms.Label lblAlertValue;
        private System.Windows.Forms.CheckBox chkTelegram;
        private System.Windows.Forms.CheckBox chkSMS;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.TextBox txtAlertVal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelAlerts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private VerticalProgressBar verticalProgressBar2;
        private CircularProgressBar gaugeHumidity;
    }
}

