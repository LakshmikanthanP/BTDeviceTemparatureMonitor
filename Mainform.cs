using Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BTDeviceTemparatureMonitor.Models.TemparatureDataModel;

namespace BTDeviceTemparatureMonitor
{
    public static class ProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar p, int state)
        {
            SendMessage(p.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }

    public partial class Mainform : Form, IMainformView
    {
        private bool DeviceConnectedStatus =false;

        public Mainform()
        {
            InitializeComponent();
        }

        public event EventHandler ConnectClicked;
        public event EventHandler DiscoverClicked;
        public event EventHandler DisconnectClicked;
        public event EventHandler SelectedIndexChanged;

        private void Form1_Load(object sender, EventArgs e)
        {

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

        public void DiscoveryCompleted(BluetoothAdapter btAdapter)
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

        public void DeviceConnected(BluetoothDeviceInfo btdevice)
        {
            txtDisplay.AppendText("\nDevice connected\r\n");  //line added for the exercise 1
            lbConnectionStatus.Text = $"Connected to \n{btdevice.DeviceName }";
            btnDiscover.Enabled = true;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = true;
            DeviceConnectedStatus = true;
        }

        public void DeviceDisconnected()
        {
            txtDisplay.AppendText("\nDevice disconnected\r\n");  //line added for the exercise 1
            lbConnectionStatus.Text = $" Device Disconnected";
            DeviceConnectedStatus = false;
        }

        public void OnCurrentTemparatureChanged(object sender, TemparatureEventArgs e)
        {
            if (this.InvokeRequired)
            {
                var currenttemp = e.currrentTemp;
                this.BeginInvoke(new Action(() => { txtDisplay.AppendText($">>{currenttemp}\r\n"); }));
                this.BeginInvoke(new Action(() => { labelTempDisplay.Text = $"{currenttemp.ToString("0.##")}"; }));
                this.BeginInvoke(new Action(() => { pgBarCurrentTemp.Value = (int)currenttemp; }));
                if (currenttemp > 45)
                    labelTempDisplay.ForeColor = Color.Red;
                else
                    labelTempDisplay.ForeColor = Color.Green;

            }
        }

        public void OnHighestTemparatureChanged(object sender, TemparatureEventArgs e)
        {
            if (this.InvokeRequired)
            {
                IAsyncResult asyncResult = this.BeginInvoke(new Action(() => { txtDisplay.AppendText($">>{e.HighestTemp}\r\n"); }));
                this.BeginInvoke(new Action(() => {
                    pgBarHighestTemp.Value = (int)e.HighestTemp;
                    ProgressBarColor.SetState(pgBarHighestTemp, 2);
                }));
            }
        }
    }
}
