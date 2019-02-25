using System;
using SmartQuant.Data;

namespace SmartQuant.Simulation
{
	// Token: 0x02000008 RID: 8
	internal class QueueEntry : IComparable
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002710 File Offset: 0x00001710
		public virtual int CompareTo(object obj)
		{
			QueueEntry queueEntry = obj as QueueEntry;
			if (this.Object.DateTime > queueEntry.Object.DateTime)
			{
				return 1;
			}
			if (this.Object.DateTime < queueEntry.Object.DateTime)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x04000015 RID: 21
		internal IDataSeries Series;

		// Token: 0x04000016 RID: 22
		internal IDataObject Object;

		// Token: 0x04000017 RID: 23
		internal int CurrentPosition;

		// Token: 0x04000018 RID: 24
		internal int EndPosition;
	}
}
