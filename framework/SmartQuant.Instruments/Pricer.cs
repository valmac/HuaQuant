using System;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Instruments
{
	// Token: 0x0200002F RID: 47
	public class Pricer : IPricer
	{
		// Token: 0x0600029A RID: 666 RVA: 0x00008810 File Offset: 0x00007810
		public virtual double Price(Instrument instrument)
		{
			if (instrument.Trade.DateTime != DateTime.MinValue && instrument.Trade.DateTime >= instrument.Bar.DateTime)
			{
				return instrument.Trade.Price;
			}
			if (instrument.Bar.DateTime != DateTime.MinValue)
			{
				return instrument.Bar.Close;
			}
			Daily last = instrument.GetDailySeries().Last;
			if (last != null)
			{
				return last.Close;
			}
			return 0.0;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000889F File Offset: 0x0000789F
		public virtual double Volatility(Instrument instrument)
		{
			return 0.0;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000088AA File Offset: 0x000078AA
		public virtual double Delta(Instrument instrument)
		{
			return 0.0;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000088B5 File Offset: 0x000078B5
		public virtual double Gamma(Instrument instrument)
		{
			return 0.0;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000088C0 File Offset: 0x000078C0
		public virtual double Theta(Instrument instrument)
		{
			return 0.0;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000088CB File Offset: 0x000078CB
		public virtual double Vega(Instrument instrument)
		{
			return 0.0;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000088D6 File Offset: 0x000078D6
		public virtual double Rho(Instrument instrument)
		{
			return 0.0;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000088E1 File Offset: 0x000078E1
		public virtual double Price(Instrument instrument, DateTime dateTime)
		{
			return instrument.GetDailySeries()[dateTime.Date, EIndexOption.Prev].Close;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000088FB File Offset: 0x000078FB
		public virtual double Volatility(Instrument instrument, DateTime dateTime1, DateTime dateTime2)
		{
			return 0.0;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00008906 File Offset: 0x00007906
		public virtual double Delta(Instrument instrument, DateTime dateTime)
		{
			return 0.0;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00008911 File Offset: 0x00007911
		public virtual double Gamma(Instrument instrument, DateTime dateTime)
		{
			return 0.0;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000891C File Offset: 0x0000791C
		public virtual double Theta(Instrument instrument, DateTime dateTime)
		{
			return 0.0;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00008927 File Offset: 0x00007927
		public virtual double Vega(Instrument instrument, DateTime dateTime)
		{
			return 0.0;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00008932 File Offset: 0x00007932
		public virtual double Rho(Instrument instrument, DateTime dateTime)
		{
			return 0.0;
		}
	}
}
