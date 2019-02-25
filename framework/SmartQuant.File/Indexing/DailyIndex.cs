using System;

namespace SmartQuant.File.Indexing
{
	// Token: 0x02000013 RID: 19
	internal class DailyIndex : Index
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00005677 File Offset: 0x00004677
		internal DailyIndex()
		{
		}

		// Token: 0x1700001E RID: 30
		internal override IndexItem this[DateTime datetime]
		{
			get
			{
				return base[datetime.Date];
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000568E File Offset: 0x0000468E
		internal override void Add(DateTime datetime, int objectPosition, long blockPosition)
		{
			base.Add(datetime.Date, objectPosition, blockPosition);
		}
	}
}
