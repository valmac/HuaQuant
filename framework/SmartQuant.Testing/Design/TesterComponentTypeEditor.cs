using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Design
{
	// Token: 0x02000012 RID: 18
	internal class TesterComponentTypeEditor : UITypeEditor
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00003A5F File Offset: 0x00002A5F
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			if (context != null && context.Instance != null)
			{
				return UITypeEditorEditStyle.Modal;
			}
			return base.GetEditStyle(context);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003A75 File Offset: 0x00002A75
		public override bool GetPaintValueSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003A78 File Offset: 0x00002A78
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			if (context != null && context.Instance != null && provider != null)
			{
				this.editorService = (provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService);
				if (this.editorService != null)
				{
					AddParentComponent addParentComponent = new AddParentComponent(context.Instance as SeriesTesterItem, TesterSaver.Tester);
					this.editorService.ShowDialog(addParentComponent);
					value = ((addParentComponent.Component == null) ? null : addParentComponent.Component);
				}
				return value;
			}
			return base.EditValue(context, provider, value);
		}

		// Token: 0x0400001B RID: 27
		private IWindowsFormsEditorService editorService;
	}
}
