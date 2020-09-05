using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDeviceTemparatureMonitor
{
	public class VerticalProgressBar : ProgressBar
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003F34 File Offset: 0x00002134
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.Style |= 4;
				return createParams;
			}
		}
	}
}
