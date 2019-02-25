using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x0200001A RID: 26
	internal class SimulatorTypeEditor : UITypeEditor
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00005B08 File Offset: 0x00004B08
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			if (context != null && context.Instance != null)
			{
				return UITypeEditorEditStyle.Modal;
			}
			return base.GetEditStyle(context);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005B1E File Offset: 0x00004B1E
		public override bool GetPaintValueSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005B24 File Offset: 0x00004B24
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			if (context != null && context.Instance != null && provider != null)
			{
				this.editorService = (provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService);
				if (this.editorService != null)
				{
					Simulator simulator = value as Simulator;
					SimulatorEditorForm dialog = new SimulatorEditorForm(simulator);
					this.editorService.ShowDialog(dialog);
				}
				return value;
			}
			return base.EditValue(context, provider, value);
		}

		// Token: 0x04000077 RID: 119
		private IWindowsFormsEditorService editorService;
	}
}
