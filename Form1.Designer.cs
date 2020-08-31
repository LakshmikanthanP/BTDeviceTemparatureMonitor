namespace Bluetooth
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbBTDevices = new System.Windows.Forms.ComboBox();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBTconnection = new System.Windows.Forms.TabControl();
            this.pgConnectivity = new System.Windows.Forms.TabPage();
            this.lbConnectionStatus = new System.Windows.Forms.Label();
            this.pgConnectionTest = new System.Windows.Forms.TabPage();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.chartReceive = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabBTconnection.SuspendLayout();
            this.pgConnectivity.SuspendLayout();
            this.pgConnectionTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSend)).BeginInit();
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
            // tabBTconnection
            // 
            this.tabBTconnection.Controls.Add(this.pgConnectivity);
            this.tabBTconnection.Controls.Add(this.pgConnectionTest);
            this.tabBTconnection.Location = new System.Drawing.Point(12, 12);
            this.tabBTconnection.Name = "tabBTconnection";
            this.tabBTconnection.SelectedIndex = 0;
            this.tabBTconnection.Size = new System.Drawing.Size(1011, 483);
            this.tabBTconnection.TabIndex = 8;
            // 
            // pgConnectivity
            // 
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
            this.pgConnectionTest.Controls.Add(this.label3);
            this.pgConnectionTest.Controls.Add(this.label2);
            this.pgConnectionTest.Controls.Add(this.btStop);
            this.pgConnectionTest.Controls.Add(this.btStart);
            this.pgConnectionTest.Controls.Add(this.chartReceive);
            this.pgConnectionTest.Controls.Add(this.chartSend);
            this.pgConnectionTest.Location = new System.Drawing.Point(4, 22);
            this.pgConnectionTest.Name = "pgConnectionTest";
            this.pgConnectionTest.Padding = new System.Windows.Forms.Padding(3);
            this.pgConnectionTest.Size = new System.Drawing.Size(1003, 457);
            this.pgConnectionTest.TabIndex = 1;
            this.pgConnectionTest.Text = "Connection Test";
            this.pgConnectionTest.UseVisualStyleBackColor = true;
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(26, 145);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(26, 66);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // chartReceive
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.Name = "ChartArea1";
            this.chartReceive.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartReceive.Legends.Add(legend3);
            this.chartReceive.Location = new System.Drawing.Point(546, 37);
            this.chartReceive.Name = "chartReceive";
            series3.ChartArea = "ChartArea1";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartReceive.Series.Add(series3);
            this.chartReceive.Size = new System.Drawing.Size(400, 300);
            this.chartReceive.TabIndex = 1;
            this.chartReceive.Text = "chartReceive";
            // 
            // chartSend
            // 
            this.chartSend.BorderlineColor = System.Drawing.Color.Black;
            this.chartSend.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.IsStartedFromZero = false;
            chartArea4.AxisX.MaximumAutoSize = 15F;
            chartArea4.Name = "ChartArea1";
            this.chartSend.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSend.Legends.Add(legend4);
            this.chartSend.Location = new System.Drawing.Point(134, 37);
            this.chartSend.Name = "chartSend";
            series4.ChartArea = "ChartArea1";
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartSend.Series.Add(series4);
            this.chartSend.Size = new System.Drawing.Size(374, 307);
            this.chartSend.TabIndex = 0;
            this.chartSend.Text = "chartSend";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(256, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sent Data >>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(668, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "<< Received Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 509);
            this.Controls.Add(this.tabBTconnection);
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.Name = "Form1";
            this.Text = "MiniBTProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabBTconnection.ResumeLayout(false);
            this.pgConnectivity.ResumeLayout(false);
            this.pgConnectivity.PerformLayout();
            this.pgConnectionTest.ResumeLayout(false);
            this.pgConnectionTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSend)).EndInit();
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
        private System.Windows.Forms.TabControl tabBTconnection;
        private System.Windows.Forms.TabPage pgConnectivity;
        private System.Windows.Forms.TabPage pgConnectionTest;
        private System.Windows.Forms.Label lbConnectionStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReceive;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSend;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

