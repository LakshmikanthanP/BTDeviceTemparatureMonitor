using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluetooth
{
    public interface IBluetoothInterface
    {
        bool Connect();

        bool Disconnect();

        BluetoothDeviceInfo[] DiscoverDevices();
    }
}
