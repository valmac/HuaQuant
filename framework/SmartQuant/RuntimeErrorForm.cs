using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace SmartQuant
{
	// Token: 0x02000038 RID: 56
	internal partial class RuntimeErrorForm : Form
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00004B35 File Offset: 0x00003B35
		internal RuntimeErrorForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004B43 File Offset: 0x00003B43
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.tbxDetails.Select(0, 0);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000050A4 File Offset: 0x000040A4
		internal void SetError(RuntimeError error)
		{
			this.lblLevel.Text = error.Level.ToString();
			this.lblDescription.Text = error.Description;
			this.lblSource.Text = ((error.Source == null) ? "Not defined." : error.Source.ToString());
			this.tbxDetails.Text = error.Details;
		}
	}
}
