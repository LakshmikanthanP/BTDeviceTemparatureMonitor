using Bluetooth;
using System;
using static BTDeviceTemparatureMonitor.Models.DataModel;

namespace BTDeviceTemparatureMonitor.Models
{
    public interface IDataModel
    {
        double CurrentTemparature { get; set; }
        double HighestTemparature { get; set; }

        double CurrentHumidity{ get; set; }

        BluetoothAdapter BtAdapter { get; set; }

        event TempartureChangeEventHandler CurrentTemparatureChanged;
        event TempartureChangeEventHandler HighestTemparatureChanged;

        event HumidityChangeEventHandler CurrentHumidityChanged;

        void DiscoverDevices();

        void ConnectDevice();

        void DisConnectDevice();

        void ReadDataStream();

        void PollSensorData();

    }
}