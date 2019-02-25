using System;
using System.Collections.Generic;

namespace SmartQuant.Trading.Design
{
	// Token: 0x02000016 RID: 22
	internal class ComponentTypeEditor : ComboBoxTypeEditor
	{
		// Token: 0x06000122 RID: 290 RVA: 0x000055EB File Offset: 0x000045EB
		public ComponentTypeEditor(ComponentType componentType) : base(false)
		{
			this.componentType = componentType;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000055FC File Offset: 0x000045FC
		protected override List<KeyValuePair<string, object>> GetItems()
		{
			List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
			foreach (object obj in StrategyComponentManager.GetComponentList(this.componentType))
			{
				ComponentRecord componentRecord = (ComponentRecord)obj;
				IComponentBase component = StrategyComponentManager.GetComponent(componentRecord.GUID, this.instance);
				list.Add(new KeyValuePair<string, object>(component.Name, component));
			}
			return list;
		}

		// Token: 0x0400005C RID: 92
		private ComponentType componentType;
	}
}
