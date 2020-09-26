using Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static BTDeviceTemparatureMonitor.Models.DataModel;

namespace BTDeviceTemparatureMonitor
{

    public partial class Mainform : Form, IMainformView
    {
        System.Windows.Forms.Timer notificationTimer = new System.Windows.Forms.Timer();
        ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
        string displaytext;
        List<string> DataText = new List<string>(50);

        private bool DeviceConnectedStatus =false;
        EmailAlert emailalertclient;
        Thread FilesaverThread;

        public Mainform()
        {
            InitializeComponent();

            emailalertclient = new EmailAlert();
            notificationTimer.Tick += new EventHandler(notificationTimer_Tick);
            notificationTimer.Interval = 2000;
        }

        private void notificationTimer_Tick(object sender, EventArgs e)
        {
            queue.TryDequeue(out displaytext);
            if (displaytext != null)
            {
                lblNotification.Text = displaytext;
                lblNotification.Visible = true;
            }
            else
            {
                lblNotification.Visible = false;
                notificationTimer.Stop();
            }
        }

        public event EventHandler ConnectClicked;
        public event EventHandler DiscoverClicked;
        public event EventHandler DisconnectClicked;
        public event EventHandler SelectedIndexChanged;

        private void Form1_Load(object sender, EventArgs e)
        {
            chartTemparature.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chartTemparature.Series["LiveTemparature"].ChartType = SeriesChartType.FastLine;
            chartTemparature.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                          chartTemparature.ChartAreas["ChartArea1"].AxisY.Interval = 10;
            chartTemparature.Series["LiveTemparature"].Color = Color.Navy;
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            if (DiscoverClicked != null)
                DiscoverClicked(sender, e);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (ConnectClicked != null && cbBTDevices.SelectedIndex != -1 && !DeviceConnectedStatus)
                ConnectClicked(sender, e);
        }

        private void cTimer_Tick(object sender, EventArgs e)
        {

        }

        private void cbBTDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBTDevices.SelectedIndex != -1)
            {
                SelectedIndexChanged(sender, e);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (DisconnectClicked != null && DeviceConnectedStatus)
                DisconnectClicked(sender, e);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
        }

        public void UpdateDashboardUI()
        {

        }

        public void OnDiscoveryCompleted(BluetoothAdapter btAdapter)
        {            
            txtDisplay.AppendText("Discovery Completed\r\n");
            this.cbBTDevices.DisplayMember = "DeviceName";
            this.cbBTDevices.ValueMember = null;
            this.cbBTDevices.DataSource = btAdapter.Peers;

            btnDiscover.Enabled = true;

            if (cbBTDevices.Items.Count != 0)
                btnConnect.Enabled = true;
            else
                btnConnect.Enabled = false;
        }

        public void DiscoveryStarted()
        {
            txtDisplay.AppendText("Discovery InProgress\r\n");
            btnDiscover.Enabled = false;
            btnConnect.Enabled = false;
        }

        public void ExecuteDelegateOnUIThread(Delegate action)
        {
            this.Invoke(action);
        }

        public void OnDeviceConnected(BluetoothDeviceInfo btdevice)
        {
            txtDisplay.AppendText("\nDevice connected\r\n");  //line added for the exercise 1
            lbConnectionStatus.Text = $"Connected to \n{btdevice.DeviceName }";
            btnDiscover.Enabled = true;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = true;
            DeviceConnectedStatus = true;
            grpBoxSettings.Enabled = false;

            FilesaverThread = new Thread(new ThreadStart(WriteDataToTextFile));
            FilesaverThread.Start();
        }

        public void OnDeviceDisconnected()
        {
            txtDisplay.AppendText("\nDevice disconnected\r\n");  //line added for the exercise 1
            lbConnectionStatus.Text = $" Device Disconnected";
            DeviceConnectedStatus = false;
            grpBoxSettings.Enabled = true;
            FilesaverThread.Abort();
        }

        public void OnCurrentTemparatureChanged(object sender, TemparatureEventArgs e)
        {
            if (this.InvokeRequired)
            {
                if (e != null)
                {
                    var currenttemp = e.currrentTemp;
                    this.BeginInvoke(new Action(()=>
                    {
                        //Maindisplay
                        var datarecord = $">>CurrentTemparature: {currenttemp}\r\n";
                        txtDisplay.AppendText(datarecord);
                        DataText.Add(datarecord);
                        labelTempDisplay.Text = $"{currenttemp.ToString("0.##")}";

                        //Dashboard
                        if (currenttemp < 100.00)
                            pgBarCurrentTemp.Value = Convert.ToInt32(currenttemp);
                        if (currenttemp > 45)
                            labelTempDisplay.ForeColor = Color.Red;
                        else
                            labelTempDisplay.ForeColor = Color.Green;

                        //gauge
                        gaugeTemparature.Value = Convert.ToInt32(currenttemp);
                        verticalProgressBar1.Value = Convert.ToInt32(currenttemp);

                        //chart
                        if (chartTemparature.Series["LiveTemparature"].Points.Count > 1)
                        {
                            chartTemparature.Series["LiveTemparature"].Points.RemoveAt(0);
                        }
                        //chartTemparature.Series["LiveTemparature"].Points.RemoveAt(0);
                        chartTemparature.Series["LiveTemparature"].Points.AddY(currenttemp);

                        int alertval;
                        int.TryParse(txtAlertVal.Text, out alertval);
                        if ((chkEmail.Checked || chkSMS.Checked || chkTelegram.Checked) && txtAlertVal != null && currenttemp >= alertval)
                        {
                            SendAlerts(currenttemp, alertval);
                        }
                    }));
                }
            }
        }

        private void SendAlerts(double currenttemp, int alertval)
        {
            notificationTimer.Start();

            if (chkEmail.Checked)
            {
                var emailsent = emailalertclient.SendMail("lakshmikanthanp87@gmail.com", "Alert: SetTemparature Reached", $" set temparature of {currenttemp} is reached");

                if (emailsent)
                {
                    queue.Enqueue("Alert Email Sent");
                }
            }

            if (chkSMS.Checked)
            {
                SMSAlert.SendSMS($"Alert : Your set temparature reached {currenttemp}", "+6597208220");
                queue.Enqueue("Alert SMS Sent");
            }

            if (chkTelegram.Checked)
            {
                TelegramBot.SendAlert($"Alert : Your set temparature reached {currenttemp}");
                queue.Enqueue("Alert Telegram Sent");
            }
        }

        public void OnHighestTemparatureChanged(object sender, TemparatureEventArgs e)
        {
            if (this.InvokeRequired)
            {
              //  IAsyncResult asyncResult = this.BeginInvoke(new Action(() => { txtDisplay.AppendText($">>{e.HighestTemp}\r\n"); }));
                this.BeginInvoke(new Action(() => {
                    var hightemp = (int)e.HighestTemp;

                    if (hightemp <100.00)
                        pgBarHighestTemp.Value = (int)e.HighestTemp;
                    ProgressBarColor.SetState(pgBarHighestTemp, 2);
                }));
            }
        }

        private void chartTemparature_Click(object sender, EventArgs e)
        {

        }

        public void OnCurrentHumidityChanged(object sender, HumidityEventArgs args)
        {
            StringBuilder humidtext = new StringBuilder();

            if (this.InvokeRequired)
            {
                if (args != null)
                {
                    var latesthumidity = args.currentHumid;
                    var intlastesthumidty = Convert.ToInt32(latesthumidity);
                    this.BeginInvoke(new Action(() =>
                    {
                        ////Maindisplay
                        var datarecord = $">>CurrentHumidity: {latesthumidity}\r\n";
                        txtDisplay.AppendText(datarecord);
                        DataText.Add(datarecord);
                        humidtext.Append(latesthumidity.ToString());
                        humidtext.Append("%");

                        lblHumidity.Text = humidtext.ToString();
                        //Dashboard
                        pgHumidProgress.Value = intlastesthumidty;

                        if (latesthumidity > 92)
                            lblHumidity.ForeColor = Color.Red;
                        else
                            lblHumidity.ForeColor = Color.Green;

                        //Gauge
                        gaugeHumidity.Value = intlastesthumidty;
                        verticalProgressBar2.Value = intlastesthumidty;

                        ////chart
                        if (chartHumidity.Series["LiveHumidity"].Points.Count > 1)
                        {
                            chartHumidity.Series["LiveHumidity"].Points.RemoveAt(0);
                        }
                        //chartTemparature.Series["LiveTemparature"].Points.RemoveAt(0);
                        chartHumidity.Series["LiveHumidity"].Points.AddY(latesthumidity);
                    }));
                }
            }
        }

        public void WriteDataToTextFile()
        {
            while (true)
            {
                if (DataText != null && DataText.Count == 15)
                {
                    var the_array = DataText.Select(i => i.ToString()).ToArray();
                    DataText.Clear();

                    // WriteAllLines creates a file, writes a collection of strings to the file,
                    // and then closes the file.  You do NOT need to call Flush() or Close().

                    var systemPath = System.Environment.
                             GetFolderPath(
                                 Environment.SpecialFolder.CommonApplicationData
                             );
                    var complete = Path.Combine(systemPath, "SensorLogs.txt");

                    System.IO.File.AppendAllLines(@complete, the_array);
                }
            }
        }
    }

    public static class ProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar p, int state)
        {
            SendMessage(p.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }

}
