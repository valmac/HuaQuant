using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace SmartQuant.Providers.Design
{
	// Token: 0x0200003B RID: 59
	public class BarFactoryItemListEditor : CollectionEditor
	{
		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000161 RID: 353 RVA: 0x00004A17 File Offset: 0x00003A17
		// (remove) Token: 0x06000162 RID: 354 RVA: 0x00004A2E File Offset: 0x00003A2E
		public static event EventHandler ListChanged;

		// Token: 0x06000163 RID: 355 RVA: 0x00004A45 File Offset: 0x00003A45
		public BarFactoryItemListEditor() : base(typeof(BarFactoryItemList))
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00004A57 File Offset: 0x00003A57
		protected override CollectionEditor.CollectionForm CreateCollectionForm()
		{
			this.form = base.CreateCollectionForm();
			this.form.Closed += this.form_Closed;
			return this.form;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00004A82 File Offset: 0x00003A82
		private void form_Closed(object sender, EventArgs e)
		{
			if (this.form.DialogResult == DialogResult.OK && BarFactoryItemListEditor.ListChanged != null)
			{
				BarFactoryItemListEditor.ListChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x04000094 RID: 148
		private CollectionEditor.CollectionForm form;
	}
}
