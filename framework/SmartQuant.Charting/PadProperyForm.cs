using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace SmartQuant.Charting
{
	// Token: 0x02000048 RID: 72
	public partial class PadProperyForm : Form
	{
		// Token: 0x0600044E RID: 1102 RVA: 0x0000F80C File Offset: 0x0000E80C
		public PadProperyForm(object Object, Pad Pad)
		{
			this.InitializeComponent();
			this.fObject = Object;
			this.fPad = Pad;
			this.Text = Object.GetType().Name + " properties";
			this.PropertyGrid.SelectedObject = Object;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000F9DB File Offset: 0x0000E9DB
		private void PropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			this.fPad.Update();
		}

		// Token: 0x040001BB RID: 443
		private object fObject;

		// Token: 0x040001BC RID: 444
		private Pad fPad;
	}
}
