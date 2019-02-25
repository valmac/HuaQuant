using System;

namespace SmartQuant.DataCenterLib
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public class DataSeriesInfo
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002067 File Offset: 0x00001067
		public DataSeriesInfo(string name, string desc, int count, DateTime firstDateTime, DateTime lastDateTime)
		{
			this.name = name;
			this.desc = desc;
			this.count = count;
			this.firstDateTime = firstDateTime;
			this.lastDateTime = lastDateTime;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002094 File Offset: 0x00001094
		public DataSeriesInfo(string name, string desc) : this(name, desc, 0, DateTime.MinValue, DateTime.MaxValue)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020A9 File Offset: 0x000010A9
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020B1 File Offset: 0x000010B1
		public string Description
		{
			get
			{
				return this.desc;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020B9 File Offset: 0x000010B9
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020C1 File Offset: 0x000010C1
		public DateTime FirstDateTime
		{
			get
			{
				return this.firstDateTime;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020C9 File Offset: 0x000010C9
		public DateTime LastDateTime
		{
			get
			{
				return this.lastDateTime;
			}
		}

		// Token: 0x04000002 RID: 2
		private string name;

		// Token: 0x04000003 RID: 3
		private string desc;

		// Token: 0x04000004 RID: 4
		private int count;

		// Token: 0x04000005 RID: 5
		private DateTime firstDateTime;

		// Token: 0x04000006 RID: 6
		private DateTime lastDateTime;
	}
}
