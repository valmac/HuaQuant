using System;

namespace SmartQuant.File.Indexing
{
	// Token: 0x0200000E RID: 14
	internal class MonthlyIndex : Index
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00004DBA File Offset: 0x00003DBA
		internal MonthlyIndex()
		{
		}

		// Token: 0x1700000A RID: 10
		internal override IndexItem this[DateTime datetime]
		{
			get
			{
				return base[new DateTime(datetime.Year, datetime.Month, 1)];
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004DDE File Offset: 0x00003DDE
		internal override void Add(DateTime datetime, int objectPosition, long blockPosition)
		{
			base.Add(new DateTime(datetime.Year, datetime.Month, 1), objectPosition, blockPosition);
		}
	}
}
