using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDeviceTemparatureMonitor
{
    public sealed class DummyDevice : IBlueToothDevice
    {
        public bool connect()
        {
            return true;
        }

        public bool disconnect()
        {
            return true;
        }

        public byte[] ReadData()
        {

            return new byte[] { 0xA5, 0x02, 0xBD, 0x01, 0x2B, 0x03,0x5A };
        }

        public void WriteData()
        {
        }
    }
}
