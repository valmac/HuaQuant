using System;

namespace SmartQuant.Business
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	public class Holiday
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002401 File Offset: 0x00001401
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002409 File Offset: 0x00001409
		public string Name
		{
			get
			{
				return this.fName;
			}
			set
			{
				this.fName = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002412 File Offset: 0x00001412
		// (set) Token: 0x0600002A RID: 42 RVA: 0x0000241A File Offset: 0x0000141A
		public string Description
		{
			get
			{
				return this.fDescription;
			}
			set
			{
				this.fDescription = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002423 File Offset: 0x00001423
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000242B File Offset: 0x0000142B
		public DateTime Date
		{
			get
			{
				return this.fDate;
			}
			set
			{
				this.fDate = value;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002434 File Offset: 0x00001434
		public Holiday()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000243C File Offset: 0x0000143C
		public Holiday(DateTime date, string name)
		{
			this.fDate = this.Date;
			this.fName = name;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002457 File Offset: 0x00001457
		public Holiday(DateTime date, string name, string description)
		{
			this.fDate = date;
			this.fName = name;
			this.fDescription = description;
		}

		// Token: 0x04000006 RID: 6
		private string fName;

		// Token: 0x04000007 RID: 7
		private string fDescription;

		// Token: 0x04000008 RID: 8
		private DateTime fDate;
	}
}
