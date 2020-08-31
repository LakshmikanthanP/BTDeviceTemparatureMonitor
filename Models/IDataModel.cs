using Bluetooth;
using System;
using static BTDeviceTemparatureMonitor.Models.TemparatureDataModel;

namespace BTDeviceTemparatureMonitor.Models
{
    public interface IDataModel
    {
        double CurrentTemparature { get; set; }
        double HighestTemparature { get; set; }
        BluetoothAdapter BtAdapter { get; set; }

         event TempartureChangeEventHandler CurrentTemparatureChanged;
         event TempartureChangeEventHandler HighestTemparatureChanged;

        void DiscoverDevices();

        void ConnectDevice();

        void DisConnectDevice();

        double ReadTemparature();
    }
}