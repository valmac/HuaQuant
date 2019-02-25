using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SmartQuant.Instruments.Design
{
	// Token: 0x02000028 RID: 40
	internal abstract class ComboBoxTypeEditor : UITypeEditor
	{
		// Token: 0x0600025C RID: 604 RVA: 0x00008148 File Offset: 0x00007148
		public ComboBoxTypeEditor()
		{
		}

		// Token: 0x0600025D RID: 605
		protected abstract object[] GetItems();

		// Token: 0x0600025E RID: 606 RVA: 0x00008150 File Offset: 0x00007150
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			if (context != null && context.Instance != null)
			{
				return UITypeEditorEditStyle.DropDown;
			}
			return base.GetEditStyle(context);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00008166 File Offset: 0x00007166
		public override bool GetPaintValueSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000816C File Offset: 0x0000716C
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			if (context != null && context.Instance != null && provider != null)
			{
				this.editorService = (provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService);
				if (this.editorService != null)
				{
					ListBox listBox = new ListBox();
					listBox.MultiColumn = false;
					listBox.SelectionMode = SelectionMode.One;
					listBox.BorderStyle = BorderStyle.None;
					listBox.SelectedIndexChanged += this.OnSelectedIndexChanged;
					listBox.Items.AddRange(this.GetItems());
					listBox.SelectedItem = value;
					this.editorService.DropDownControl(listBox);
					value = listBox.SelectedItem;
				}
				return value;
			}
			return base.EditValue(context, provider, value);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00008214 File Offset: 0x00007214
		private void OnSelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.editorService != null)
			{
				this.editorService.CloseDropDown();
			}
		}

		// Token: 0x040000A7 RID: 167
		private IWindowsFormsEditorService editorService;
	}
}
