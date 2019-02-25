using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x0200002E RID: 46
	internal class OrderEntryListEditor : UITypeEditor
	{
		// Token: 0x0600019B RID: 411 RVA: 0x00008C7A File Offset: 0x00007C7A
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			if (context != null && context.Instance != null)
			{
				return UITypeEditorEditStyle.Modal;
			}
			return base.GetEditStyle(context);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00008C90 File Offset: 0x00007C90
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			if (context != null && context.Instance != null && provider != null)
			{
				IWindowsFormsEditorService windowsFormsEditorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
				if (windowsFormsEditorService != null)
				{
					OrderEntryList orderEntryList = (OrderEntryList)value;
					OrderEntryListEditorForm orderEntryListEditorForm = new OrderEntryListEditorForm();
					orderEntryListEditorForm.Entries = orderEntryList;
					if (windowsFormsEditorService.ShowDialog(orderEntryListEditorForm) == DialogResult.OK)
					{
						orderEntryList.Clear();
						foreach (object obj in orderEntryListEditorForm.Entries)
						{
							OrderEntry entry = (OrderEntry)obj;
							orderEntryList.Add(entry);
						}
						SimulationExecutionService simulationExecutionService = (SimulationExecutionService)context.Instance;
						simulationExecutionService.SaveConfiguration();
					}
				}
				return value;
			}
			return base.EditValue(context, provider, value);
		}
	}
}
