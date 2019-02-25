using System;

namespace SmartQuant.Testing.Components
{
	// Token: 0x02000008 RID: 8
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class TesterComponentAttribute : Attribute
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002CB8 File Offset: 0x00001CB8
		public TesterComponentAttribute(string guid)
		{
			this.guid = new Guid(guid);
			this.name = null;
			this.description = null;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002CDA File Offset: 0x00001CDA
		public Guid GUID
		{
			get
			{
				return this.guid;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002CE2 File Offset: 0x00001CE2
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002CEA File Offset: 0x00001CEA
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002CF3 File Offset: 0x00001CF3
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002CFB File Offset: 0x00001CFB
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		// Token: 0x04000012 RID: 18
		private Guid guid;

		// Token: 0x04000013 RID: 19
		private string name;

		// Token: 0x04000014 RID: 20
		private string description;
	}
}
