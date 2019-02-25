using System;

namespace SmartQuant.Trading
{
	// Token: 0x02000065 RID: 101
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class StrategyComponentAttribute : Attribute
	{
		// Token: 0x060003CF RID: 975 RVA: 0x0000F06F File Offset: 0x0000E06F
		public StrategyComponentAttribute(string guid, ComponentType type)
		{
			this.guid = new Guid(guid);
			this.type = type;
			this.name = null;
			this.description = null;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0000F098 File Offset: 0x0000E098
		public Guid GUID
		{
			get
			{
				return this.guid;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0000F0A0 File Offset: 0x0000E0A0
		public ComponentType Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0000F0A8 File Offset: 0x0000E0A8
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0000F0B0 File Offset: 0x0000E0B0
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

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0000F0B9 File Offset: 0x0000E0B9
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x0000F0C1 File Offset: 0x0000E0C1
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

		// Token: 0x0400013D RID: 317
		private Guid guid;

		// Token: 0x0400013E RID: 318
		private ComponentType type;

		// Token: 0x0400013F RID: 319
		private string name;

		// Token: 0x04000140 RID: 320
		private string description;
	}
}
