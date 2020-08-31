using BTDeviceTemparatureMonitor.Models;
using BTDeviceTemparatureMonitor.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDeviceTemparatureMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new Mainform();
            var presenter = new DashboardViewPresenter(mainForm, new TemparatureDataModel());

            Application.Run(mainForm);
        }
    }
}
