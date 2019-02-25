using System;
using SmartQuant.Instruments;

namespace SmartQuant.Pricers
{
	// Token: 0x02000002 RID: 2
	public class IndexPricer : IPricer
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00001058
		public virtual double Price(Instrument instrument)
		{
			double num = 0.0;
			foreach (object obj in instrument.Legs)
			{
				Leg leg = (Leg)obj;
				switch (leg.LegSide)
				{
				case '1':
				case '3':
					num += leg.LegRatioQty * leg.Instrument.Price();
					continue;
				case '2':
				case '5':
					num -= leg.LegRatioQty * leg.Instrument.Price();
					continue;
				}
				throw new ApplicationException(string.Concat(new object[]
				{
					"Can no price index ",
					instrument.Symbol,
					" : Unknown leg side ",
					leg.LegSide,
					" for leg ",
					leg.Instrument.Symbol
				}));
			}
			return num;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000216C File Offset: 0x0000116C
		public virtual double Volatility(Instrument instrument)
		{
			return 0.0;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002177 File Offset: 0x00001177
		public virtual double Delta(Instrument instrument)
		{
			return 0.0;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002182 File Offset: 0x00001182
		public virtual double Gamma(Instrument instrument)
		{
			return 0.0;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000218D File Offset: 0x0000118D
		public virtual double Theta(Instrument instrument)
		{
			return 0.0;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002198 File Offset: 0x00001198
		public virtual double Vega(Instrument instrument)
		{
			return 0.0;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021A3 File Offset: 0x000011A3
		public virtual double Rho(Instrument instrument)
		{
			return 0.0;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021B0 File Offset: 0x000011B0
		public virtual double Price(Instrument instrument, DateTime dateTime)
		{
			double num = 0.0;
			foreach (object obj in instrument.Legs)
			{
				Leg leg = (Leg)obj;
				switch (leg.LegSide)
				{
				case '1':
				case '3':
					num += leg.LegRatioQty * leg.Instrument.Price(dateTime);
					continue;
				case '2':
				case '5':
					num -= leg.LegRatioQty * leg.Instrument.Price();
					continue;
				}
				throw new ApplicationException(string.Concat(new object[]
				{
					"Can no price index ",
					instrument.Symbol,
					" : Unknown leg side ",
					leg.LegSide,
					" for leg ",
					leg.Instrument.Symbol
				}));
			}
			return num;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022C4 File Offset: 0x000012C4
		public virtual double Volatility(Instrument instrument, DateTime dateTime1, DateTime dateTime2)
		{
			return 0.0;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000022CF File Offset: 0x000012CF
		public virtual double Delta(Instrument instrument, DateTime dateTime)
		{
			return 0.0;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000022DA File Offset: 0x000012DA
		public virtual double Gamma(Instrument instrument, DateTime dateTime)
		{
			return 0.0;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022E5 File Offset: 0x000012E5
		public virtual double Theta(Instrument instrument, DateTime dateTime)
		{
			return 0.0;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022F0 File Offset: 0x000012F0
		public virtual double Vega(Instrument instrument, DateTime dateTime)
		{
			return 0.0;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022FB File Offset: 0x000012FB
		public virtual double Rho(Instrument instrument, DateTime dateTime)
		{
			return 0.0;
		}
	}
}
