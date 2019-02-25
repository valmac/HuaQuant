using System;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x02000032 RID: 50
	public class ComponentNameEventArgs : EventArgs
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00006F1D File Offset: 0x00005F1D
		public string OldName
		{
			get
			{
				return this.oldName;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00006F25 File Offset: 0x00005F25
		public string NewName
		{
			get
			{
				return this.newName;
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00006F2D File Offset: 0x00005F2D
		public ComponentNameEventArgs(string oldName, string newName)
		{
			this.oldName = oldName;
			this.newName = newName;
		}

		// Token: 0x04000072 RID: 114
		private string oldName;

		// Token: 0x04000073 RID: 115
		private string newName;
	}
}
