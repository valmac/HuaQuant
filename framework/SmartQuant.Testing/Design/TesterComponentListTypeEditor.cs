using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace SmartQuant.Testing.Design
{
	// Token: 0x02000015 RID: 21
	internal class TesterComponentListTypeEditor : UITypeEditor
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00003D8B File Offset: 0x00002D8B
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			if (context != null && context.Instance != null)
			{
				return UITypeEditorEditStyle.Modal;
			}
			return base.GetEditStyle(context);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003DA1 File Offset: 0x00002DA1
		public override bool GetPaintValueSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003DA4 File Offset: 0x00002DA4
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			if (context != null && context.Instance != null && provider != null)
			{
				this.editorService = (provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService);
				if (this.editorService != null)
				{
					EditComponent_Tester editComponent_Tester = new EditComponent_Tester(context.Instance as LiveTester);
					this.editorService.ShowDialog(editComponent_Tester);
					value = ((editComponent_Tester.ComponentList == null) ? null : editComponent_Tester.ComponentList);
				}
				return value;
			}
			return base.EditValue(context, provider, value);
		}

		// Token: 0x0400001F RID: 31
		private IWindowsFormsEditorService editorService;
	}
}
