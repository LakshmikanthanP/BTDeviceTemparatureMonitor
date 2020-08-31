using Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BTDeviceTemparatureMonitor.Models.TemparatureDataModel;

namespace BTDeviceTemparatureMonitor
{
    public interface IMainformView
    {
        event EventHandler ConnectClicked;
        event EventHandler DiscoverClicked;
        event EventHandler DisconnectClicked;
        event EventHandler SelectedIndexChanged;

        void OnCurrentTemparatureChanged(object sender, TemparatureEventArgs e);
        void OnHighestTemparatureChanged(object sender, TemparatureEventArgs e);

        void UpdateDashboardUI();

        void DiscoveryStarted();

        void DeviceConnected(BluetoothDeviceInfo btDevice);

        void DeviceDisconnected();

        void DiscoveryCompleted(BluetoothAdapter btAdapter);

        void ExecuteDelegateOnUIThread(Delegate action);
    }
}
