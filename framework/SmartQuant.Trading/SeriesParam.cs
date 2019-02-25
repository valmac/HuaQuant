using System;
using System.Collections;
using SmartQuant.Instruments;
using SmartQuant.Series;

namespace SmartQuant.Trading
{
	// Token: 0x02000049 RID: 73
	public class SeriesParam
	{
		// Token: 0x1700009B RID: 155
		public TimeSeries this[Instrument instrument]
		{
			get
			{
				return (TimeSeries)this.fParam[instrument];
			}
			set
			{
				this.fParam[instrument] = value;
			}
		}

		// Token: 0x040000FD RID: 253
		private Hashtable fParam = new Hashtable();
	}
}
