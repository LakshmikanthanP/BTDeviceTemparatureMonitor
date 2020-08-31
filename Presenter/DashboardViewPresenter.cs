using BTDeviceTemparatureMonitor.Models;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDeviceTemparatureMonitor.Presenter
{
    public class DashboardViewPresenter
    {
        private readonly IMainformView _view;
        private readonly IDataModel _dataValuerespository;
        AutoResetEvent discoverevent = new AutoResetEvent(false);

        Thread pollingthread;

        public DashboardViewPresenter(IMainformView view, IDataModel dataValuerespository)
        {
            _view = view;
            _dataValuerespository = dataValuerespository;

            _view.ConnectClicked += OnConnectDevice;
            _view.DiscoverClicked += OnDiscoverDevices;
            _view.DisconnectClicked += OnDisconnectDevice;
            _view.SelectedIndexChanged += OnSelectedIndexChanged;

            _dataValuerespository.CurrentTemparatureChanged += _view.OnCurrentTemparatureChanged;
            _dataValuerespository.HighestTemparatureChanged += _view.OnHighestTemparatureChanged;
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var cmbDevices = sender as ComboBox;
            _dataValuerespository.BtAdapter.Device = (BluetoothDeviceInfo) cmbDevices.SelectedItem;
        }

        private void OnDisconnectDevice(object sender, EventArgs e)
        {
            _dataValuerespository.DisConnectDevice();
            pollingthread.Abort();
            _view.ExecuteDelegateOnUIThread(new Action(() => _view.DeviceDisconnected()));
        }

        private void OnDiscoverDevices(object sender, EventArgs e)
        {
            discoverevent = new AutoResetEvent(false);
            Thread t_discover = new Thread(new ThreadStart(Discover));
            Thread t_discoverend = new Thread(new ThreadStart(Discoverend));
            t_discover.Start();
            t_discoverend.Start();
            _view.ExecuteDelegateOnUIThread(new Action(() => _view.DiscoveryStarted()));
        }

        private void Discoverend()
        {
            discoverevent.WaitOne();
            _view.ExecuteDelegateOnUIThread(new Action(() => _view.DiscoveryCompleted(_dataValuerespository.BtAdapter)));
        }

        private void Discover()
        {
            _dataValuerespository.DiscoverDevices();
            discoverevent.Set();
        }

        private void OnConnectDevice(object sender, EventArgs e)
        {
            _dataValuerespository.ConnectDevice();
            _view.ExecuteDelegateOnUIThread(new Action(() => _view.DeviceConnected(_dataValuerespository.BtAdapter.Device)));
            pollingthread = new Thread(new ThreadStart(DevicePollingThread));
            pollingthread.Start();
        }

        private void DevicePollingThread()
        {
            try
            {
                while (true)
                {
                   var currenttemp =  _dataValuerespository.ReadTemparature();                      
                    Thread.Sleep(100);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
