using System;

namespace SmartQuant.Series
{
	// Token: 0x02000002 RID: 2
	public class SeriesEventArgs : EventArgs
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		public SeriesEventArgs(TimeSeries series)
		{
			this.series = series;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000205F File Offset: 0x0000105F
		public TimeSeries Series
		{
			get
			{
				return this.series;
			}
		}

		// Token: 0x04000001 RID: 1
		private TimeSeries series;
	}
}
