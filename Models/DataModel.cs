using Bluetooth;
using System;
using System.Collections.Concurrent;
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
    public class DataModel: IDataModel
    {
        BluetoothAdapter btAdapter ;
        Stream peerStream = null;
        ConcurrentQueue<int[]> packetstream = new ConcurrentQueue<int[]>();

        private double mCurrentTemparature;
        private double mHighestTemparature;

        private double mCurrentHumidity;

        public event TempartureChangeEventHandler CurrentTemparatureChanged;
        public event TempartureChangeEventHandler HighestTemparatureChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public event HumidityChangeEventHandler CurrentHumidityChanged;

        public delegate void TempartureChangeEventHandler(
         object sender, TemparatureEventArgs args);

        public delegate void HumidityChangeEventHandler(
         object sender, HumidityEventArgs args);

        public class TemparatureEventArgs : EventArgs
        {
            public double currrentTemp { get; set; }
            public double HighestTemp { get; set; }
        }

        public class HumidityEventArgs : EventArgs
        {
            public double currentHumid { get; set; }
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

        public DataModel()
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

        public double CurrentHumidity
        {
            get
            {
                return this.mCurrentHumidity;
            }

            set
            {
                if (value != this.mCurrentHumidity)
                {
                    this.mCurrentHumidity = value;
                    //NotifyPropertyChanged();
                    var args = new HumidityEventArgs();
                    args.currentHumid = this.CurrentHumidity;
                    CurrentHumidityChanged(this, args);
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

        public void PollSensorData()
        {
            int[] receivedpacket;

            
            packetstream.TryDequeue(out receivedpacket);

            if (receivedpacket != null)
            {
                int j = 0;
                var query = from s in receivedpacket
                            let num = j++
                            group s by num / 2 into g
                            select g.ToArray();
                var results = query.ToArray();

                var firstsensordata = results[0];
                var secondsensordata = results[1];

                int humidity = firstsensordata[1] << 8 | firstsensordata[0];
                humidity = humidity / 100;

                CurrentHumidity = humidity;


                var tempsensorvalue = secondsensordata[1] << 8 | secondsensordata[0];
                var fTempVoltageValue = (tempsensorvalue / 4095.0) * 3.3;
                var fTempValue = -0.193 * (fTempVoltageValue * 1000) + 212.009;

                if (fTempValue != CurrentTemparature)
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
            }

        }

        public void ReadDataStream()
        {
            int[] sensordata;
            int i;

            byte[] data = new byte[100];
            int blocklength = 0;
            sensordata = new int[100];
            int[] datapacket = new int[20];
            i = 0;
            int currentdata = 0;

            if (peerStream.CanRead)
            {
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

                packetstream.Enqueue(sensordata.Take(blocklength * 2).ToArray());
            }

        }

    }
}
