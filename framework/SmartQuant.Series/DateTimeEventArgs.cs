using System;

namespace SmartQuant.Series
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	public class DateTimeEventArgs : EventArgs
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002067 File Offset: 0x00001067
		public DateTimeEventArgs(DateTime dateTime)
		{
			this.DateTime = dateTime;
		}

		// Token: 0x0400000D RID: 13
		public DateTime DateTime;
	}
}
