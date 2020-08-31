using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDeviceTemparatureMonitor
{
    public interface IBlueToothDevice
    {
        bool connect();

        void WriteData();

        byte[] ReadData();

        bool disconnect();
    }
}
