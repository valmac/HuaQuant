using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x0200000B RID: 11
	public class BarFilterItemListEditor : CollectionEditor
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000046 RID: 70 RVA: 0x000028A7 File Offset: 0x000018A7
		// (remove) Token: 0x06000047 RID: 71 RVA: 0x000028BE File Offset: 0x000018BE
		public static event EventHandler ListChanged;

		// Token: 0x06000048 RID: 72 RVA: 0x000028D5 File Offset: 0x000018D5
		public BarFilterItemListEditor() : base(typeof(List<BarFilterItem>))
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000028E7 File Offset: 0x000018E7
		protected override CollectionEditor.CollectionForm CreateCollectionForm()
		{
			this.form = base.CreateCollectionForm();
			this.form.FormClosed += this.form_FormClosed;
			return this.form;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002912 File Offset: 0x00001912
		private void form_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.form.DialogResult == DialogResult.OK && BarFilterItemListEditor.ListChanged != null)
			{
				BarFilterItemListEditor.ListChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x0400001A RID: 26
		private CollectionEditor.CollectionForm form;
	}
}
