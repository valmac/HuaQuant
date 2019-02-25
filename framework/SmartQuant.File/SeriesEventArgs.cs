using System;

namespace SmartQuant.File
{
	// Token: 0x0200000C RID: 12
	public class SeriesEventArgs : EventArgs
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00004C28 File Offset: 0x00003C28
		public SeriesEventArgs(FileSeries series)
		{
			this.series = series;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00004C37 File Offset: 0x00003C37
		public FileSeries Series
		{
			get
			{
				return this.series;
			}
		}

		// Token: 0x04000027 RID: 39
		private FileSeries series;
	}
}
