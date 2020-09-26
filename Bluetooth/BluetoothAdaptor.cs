using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluetooth
{
    public class BluetoothAdapter: IBluetoothInterface
    {
        private BluetoothClient cli;
        private BluetoothEndPoint ep;
        private BluetoothDeviceInfo[] peers;

        public BluetoothAdapter()
        {
        }

        public BluetoothAdapter(BluetoothDeviceInfo deviceInfo)
        {
            Client = new BluetoothClient();
            ep = new BluetoothEndPoint(deviceInfo.DeviceAddress, BluetoothService.SerialPort);

        }

        public BluetoothAdapter(BluetoothClient cli, BluetoothEndPoint ep)
        {
            this.Client = cli;
            this.ep = ep;
        }

        public BluetoothDeviceInfo Device { get; set; }
        public BluetoothClient Client { get => cli; set => cli = value; }
        public BluetoothDeviceInfo[] Peers { get => peers; set => peers = value; }

        public bool Connect()
        {
            bool connected = false;
            try
            {
                if (ep == null)
                {
                    ep = new BluetoothEndPoint(Device.DeviceAddress, BluetoothService.SerialPort);
                }
                if (Client == null)
                {
                    Client = new BluetoothClient();
                }

                Client.Connect(ep);
                connected = true;
            }
            catch (Exception ex)
            {
                connected = false;
                throw;
            }

            return connected;
        }

        public bool Disconnect()
        {

            bool disconnected = false;
            try
            {
                Client.Dispose();
                ep = null;
                Client = null;
                disconnected = true;
            }
            catch (Exception ex)
            {                
                throw;
            }

            return disconnected;   
        }

        public BluetoothDeviceInfo[] DiscoverDevices()
        {
            if (Client == null)
            {
                Client = new BluetoothClient();
            }
            Peers = Client.DiscoverDevices();
            return Peers;
        }
    }
}
