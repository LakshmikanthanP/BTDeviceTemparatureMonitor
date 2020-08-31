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
            this.cbBTDevices = new System.Windows.Forms.ComboBox();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDashBoard = new System.Windows.Forms.TabControl();
            this.pgConnectivity = new System.Windows.Forms.TabPage();
            this.lbConnectionStatus = new System.Windows.Forms.Label();
            this.pgConnectionTest = new System.Windows.Forms.TabPage();
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
            this.grpBoxFeatures = new System.Windows.Forms.GroupBox();
            this.chckBoxEmailAlert = new System.Windows.Forms.CheckBox();
            this.chckBoxSMSAlert = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabDashBoard.SuspendLayout();
            this.pgConnectivity.SuspendLayout();
            this.pgConnectionTest.SuspendLayout();
            this.tempDisplayPanel.SuspendLayout();
            this.grpBoxFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBTDevices
            // 
            this.cbBTDevices.FormattingEnabled = true;
            this.cbBTDevices.Location = new System.Drawing.Point(33, 29);
            this.cbBTDevices.Name = "cbBTDevices";
            this.cbBTDevices.Size = new System.Drawing.Size(142, 21);
            this.cbBTDevices.TabIndex = 0;
            this.cbBTDevices.SelectedIndexChanged += new System.EventHandler(this.cbBTDevices_SelectedIndexChanged);
            // 
            // btnDiscover
            // 
            this.btnDiscover.Location = new System.Drawing.Point(181, 27);
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
            this.btnConnect.Location = new System.Drawing.Point(262, 27);
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
            this.btnDisconnect.Location = new System.Drawing.Point(343, 27);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(33, 92);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(364, 192);
            this.txtDisplay.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(322, 303);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(34, 303);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(282, 20);
            this.txtSend.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output Display";
            // 
            // tabDashBoard
            // 
            this.tabDashBoard.Controls.Add(this.pgConnectivity);
            this.tabDashBoard.Controls.Add(this.pgConnectionTest);
            this.tabDashBoard.Location = new System.Drawing.Point(12, 12);
            this.tabDashBoard.Name = "tabDashBoard";
            this.tabDashBoard.SelectedIndex = 0;
            this.tabDashBoard.Size = new System.Drawing.Size(1011, 483);
            this.tabDashBoard.TabIndex = 8;
            // 
            // pgConnectivity
            // 
            this.pgConnectivity.Controls.Add(this.grpBoxFeatures);
            this.pgConnectivity.Controls.Add(this.lbConnectionStatus);
            this.pgConnectivity.Controls.Add(this.cbBTDevices);
            this.pgConnectivity.Controls.Add(this.label1);
            this.pgConnectivity.Controls.Add(this.btnDiscover);
            this.pgConnectivity.Controls.Add(this.txtSend);
            this.pgConnectivity.Controls.Add(this.btnConnect);
            this.pgConnectivity.Controls.Add(this.btnSend);
            this.pgConnectivity.Controls.Add(this.btnDisconnect);
            this.pgConnectivity.Controls.Add(this.txtDisplay);
            this.pgConnectivity.Location = new System.Drawing.Point(4, 22);
            this.pgConnectivity.Name = "pgConnectivity";
            this.pgConnectivity.Padding = new System.Windows.Forms.Padding(3);
            this.pgConnectivity.Size = new System.Drawing.Size(1003, 457);
            this.pgConnectivity.TabIndex = 0;
            this.pgConnectivity.Text = "Connectivity";
            this.pgConnectivity.UseVisualStyleBackColor = true;
            // 
            // lbConnectionStatus
            // 
            this.lbConnectionStatus.AutoSize = true;
            this.lbConnectionStatus.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectionStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbConnectionStatus.Location = new System.Drawing.Point(441, 145);
            this.lbConnectionStatus.Name = "lbConnectionStatus";
            this.lbConnectionStatus.Size = new System.Drawing.Size(210, 27);
            this.lbConnectionStatus.TabIndex = 8;
            this.lbConnectionStatus.Text = "Connection Status";
            // 
            // pgConnectionTest
            // 
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
            this.pgConnectionTest.Size = new System.Drawing.Size(1003, 457);
            this.pgConnectionTest.TabIndex = 1;
            this.pgConnectionTest.Text = "DashBoard";
            this.pgConnectionTest.UseVisualStyleBackColor = true;
            // 
            // tempDisplayPanel
            // 
            this.tempDisplayPanel.BackColor = System.Drawing.Color.DarkGray;
            this.tempDisplayPanel.Controls.Add(this.labelTempDisplay);
            this.tempDisplayPanel.Location = new System.Drawing.Point(288, 122);
            this.tempDisplayPanel.Name = "tempDisplayPanel";
            this.tempDisplayPanel.Size = new System.Drawing.Size(352, 116);
            this.tempDisplayPanel.TabIndex = 8;
            // 
            // labelTempDisplay
            // 
            this.labelTempDisplay.AutoSize = true;
            this.labelTempDisplay.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempDisplay.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelTempDisplay.Location = new System.Drawing.Point(55, 25);
            this.labelTempDisplay.Name = "labelTempDisplay";
            this.labelTempDisplay.Size = new System.Drawing.Size(228, 66);
            this.labelTempDisplay.TabIndex = 0;
            this.labelTempDisplay.Text = "33.40";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "0 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Highest Temparature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current Temparature";
            // 
            // pgBarHighestTemp
            // 
            this.pgBarHighestTemp.Location = new System.Drawing.Point(288, 313);
            this.pgBarHighestTemp.Name = "pgBarHighestTemp";
            this.pgBarHighestTemp.Size = new System.Drawing.Size(352, 28);
            this.pgBarHighestTemp.TabIndex = 3;
            // 
            // pgBarCurrentTemp
            // 
            this.pgBarCurrentTemp.Location = new System.Drawing.Point(288, 264);
            this.pgBarCurrentTemp.Name = "pgBarCurrentTemp";
            this.pgBarCurrentTemp.Size = new System.Drawing.Size(352, 28);
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
            // grpBoxFeatures
            // 
            this.grpBoxFeatures.Controls.Add(this.button1);
            this.grpBoxFeatures.Controls.Add(this.textBox1);
            this.grpBoxFeatures.Controls.Add(this.label8);
            this.grpBoxFeatures.Controls.Add(this.chckBoxSMSAlert);
            this.grpBoxFeatures.Controls.Add(this.chckBoxEmailAlert);
            this.grpBoxFeatures.Location = new System.Drawing.Point(454, 27);
            this.grpBoxFeatures.Name = "grpBoxFeatures";
            this.grpBoxFeatures.Size = new System.Drawing.Size(409, 82);
            this.grpBoxFeatures.TabIndex = 9;
            this.grpBoxFeatures.TabStop = false;
            this.grpBoxFeatures.Text = "Features";
            // 
            // chckBoxEmailAlert
            // 
            this.chckBoxEmailAlert.AutoSize = true;
            this.chckBoxEmailAlert.Location = new System.Drawing.Point(18, 59);
            this.chckBoxEmailAlert.Name = "chckBoxEmailAlert";
            this.chckBoxEmailAlert.Size = new System.Drawing.Size(75, 17);
            this.chckBoxEmailAlert.TabIndex = 0;
            this.chckBoxEmailAlert.Text = "Email Alert";
            this.chckBoxEmailAlert.UseVisualStyleBackColor = true;
            // 
            // chckBoxSMSAlert
            // 
            this.chckBoxSMSAlert.AutoSize = true;
            this.chckBoxSMSAlert.Location = new System.Drawing.Point(99, 59);
            this.chckBoxSMSAlert.Name = "chckBoxSMSAlert";
            this.chckBoxSMSAlert.Size = new System.Drawing.Size(73, 17);
            this.chckBoxSMSAlert.TabIndex = 1;
            this.chckBoxSMSAlert.Text = "SMS Alert";
            this.chckBoxSMSAlert.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "AlertTemp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 498);
            this.Controls.Add(this.tabDashBoard);
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.Name = "Mainform";
            this.Text = "MiniBTProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabDashBoard.ResumeLayout(false);
            this.pgConnectivity.ResumeLayout(false);
            this.pgConnectivity.PerformLayout();
            this.pgConnectionTest.ResumeLayout(false);
            this.pgConnectionTest.PerformLayout();
            this.tempDisplayPanel.ResumeLayout(false);
            this.tempDisplayPanel.PerformLayout();
            this.grpBoxFeatures.ResumeLayout(false);
            this.grpBoxFeatures.PerformLayout();
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
        private System.Windows.Forms.TabControl tabDashBoard;
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
    }
}

