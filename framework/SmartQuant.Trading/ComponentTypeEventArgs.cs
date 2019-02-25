using System;

namespace SmartQuant.Trading
{
	// Token: 0x02000050 RID: 80
	public class ComponentTypeEventArgs : EventArgs
	{
		// Token: 0x06000325 RID: 805 RVA: 0x0000C7CD File Offset: 0x0000B7CD
		public ComponentTypeEventArgs(ComponentType componentType)
		{
			this.componentType = componentType;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000C7DC File Offset: 0x0000B7DC
		public ComponentType ComponentType
		{
			get
			{
				return this.componentType;
			}
		}

		// Token: 0x04000104 RID: 260
		private ComponentType componentType;
	}
}
