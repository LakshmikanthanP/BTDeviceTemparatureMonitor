using Bluetooth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDeviceTemparatureMonitor.Models
{
    public class TemparatureDataModel: IDataModel
    {
        BluetoothAdapter btAdapter ;
        Stream peerStream = null;

        private double mCurrentTemparature;
        private double mHighestTemparature;

        public event TempartureChangeEventHandler CurrentTemparatureChanged;
        public event TempartureChangeEventHandler HighestTemparatureChanged;
        public event PropertyChangedEventHandler PropertyChanged;


        public delegate void TempartureChangeEventHandler(
    object sender, TemparatureEventArgs args);

        public class TemparatureEventArgs : EventArgs
        {
            public double currrentTemp { get; set; }
            public double HighestTemp { get; set; }
        }

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public TemparatureDataModel()
        {
            BtAdapter = new BluetoothAdapter();
        }

        public double CurrentTemparature
        {
            get
            {
                return this.mCurrentTemparature;
            }

            set
            {
                if (value != this.mCurrentTemparature)
                {
                    this.mCurrentTemparature = value;
                    //NotifyPropertyChanged();
                    var args = new TemparatureEventArgs();
                    args.currrentTemp = this.CurrentTemparature;
                    args.HighestTemp = this.HighestTemparature;
                    CurrentTemparatureChanged(this, args);
                }
            }
        }

        public double HighestTemparature
        {
            get
            {
                return this.mHighestTemparature;
            }

            set
            {
                if (value != this.mHighestTemparature)
                {
                    this.mHighestTemparature = value;
                    //NotifyPropertyChanged();
                    var args = new TemparatureEventArgs();
                    args.currrentTemp = this.CurrentTemparature;
                    args.HighestTemp = this.HighestTemparature;
                    HighestTemparatureChanged(this, args);
                }
            }
        }

        public BluetoothAdapter BtAdapter { get => btAdapter; set => btAdapter = value; }

        public void DiscoverDevices()
        {
            BtAdapter.DiscoverDevices();
        }

        public void ConnectDevice()
        {
            BtAdapter.Connect();
            peerStream = btAdapter.Client.GetStream();
        }

        public void DisConnectDevice()
        {
            BtAdapter.Disconnect();
        }

        public double ReadTemparature()
        {
            byte[] data = new byte[100];
            int blocklength = 0;
            int[] sensordata = new int[100];
            int i = 0;
            int currentdata = 0; 
            
            var currentbyte = peerStream.ReadByte();

            if (currentbyte == 0xA5)
            {
                blocklength = (int)peerStream.ReadByte();
            }

            do
            {
                sensordata[i] = peerStream.ReadByte();
                currentdata = sensordata[i];
                i++;
            } while (currentdata != 0x5a);

            var tempsensorvalue = sensordata[i - 2] << 8 | sensordata[i - 3];
            var fTempVoltageValue = (tempsensorvalue / 4095.0) * 3.3;
            var fTempValue = -0.193 * (fTempVoltageValue * 1000) + 212.009;

            if (fTempValue !=CurrentTemparature)
            {
                CurrentTemparature = fTempValue;
                if (HighestTemparature == 0)
                {
                    HighestTemparature = CurrentTemparature;
                }
            }

            if (CurrentTemparature > HighestTemparature)
            {
                HighestTemparature = CurrentTemparature;
            }
            return fTempValue;
        }
    }
}
