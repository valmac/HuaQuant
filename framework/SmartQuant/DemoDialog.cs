using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace SmartQuant
{
	// Token: 0x02000007 RID: 7
	internal partial class DemoDialog : Form
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002748 File Offset: 0x00001748
		public DemoDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002B1D File Offset: 0x00001B1D
		public void SetText(string text)
		{
			this.lblText.Text = text;
		}
	}
}
