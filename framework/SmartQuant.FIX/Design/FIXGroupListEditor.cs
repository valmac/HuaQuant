using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace SmartQuant.FIX.Design
{
	// Token: 0x02000049 RID: 73
	public class FIXGroupListEditor : CollectionEditor
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000F66 RID: 3942 RVA: 0x00011F35 File Offset: 0x00010F35
		// (remove) Token: 0x06000F67 RID: 3943 RVA: 0x00011F4C File Offset: 0x00010F4C
		public static event EventHandler ListChanged;

		// Token: 0x06000F68 RID: 3944 RVA: 0x00011F63 File Offset: 0x00010F63
		protected FIXGroupListEditor(Type type) : base(type)
		{
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00011F6C File Offset: 0x00010F6C
		public FIXGroupListEditor() : this(typeof(FIXGroupList))
		{
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00011F7E File Offset: 0x00010F7E
		protected override CollectionEditor.CollectionForm CreateCollectionForm()
		{
			this.form = base.CreateCollectionForm();
			this.form.Closed += this.form_Closed;
			return this.form;
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00011FA9 File Offset: 0x00010FA9
		private void form_Closed(object sender, EventArgs e)
		{
			if (this.form.DialogResult == DialogResult.OK && FIXGroupListEditor.ListChanged != null)
			{
				FIXGroupListEditor.ListChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x04000181 RID: 385
		private CollectionEditor.CollectionForm form;
	}
}
