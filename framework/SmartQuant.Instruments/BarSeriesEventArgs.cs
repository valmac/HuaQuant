using System;
using SmartQuant.Series;

namespace SmartQuant.Instruments
{
	// Token: 0x02000051 RID: 81
	public class BarSeriesEventArgs : EventArgs
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0000CCCE File Offset: 0x0000BCCE
		public BarSeries BarSeries
		{
			get
			{
				return this.barSeries;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0000CCD6 File Offset: 0x0000BCD6
		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000CCDE File Offset: 0x0000BCDE
		public BarSeriesEventArgs(BarSeries barSeries, Instrument instrument)
		{
			this.barSeries = barSeries;
			this.instrument = instrument;
		}

		// Token: 0x04000110 RID: 272
		private BarSeries barSeries;

		// Token: 0x04000111 RID: 273
		private Instrument instrument;
	}
}
