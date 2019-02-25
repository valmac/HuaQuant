using System;

namespace SmartQuant.Instruments
{
	// Token: 0x02000016 RID: 22
	public interface IPricer
	{
		// Token: 0x06000139 RID: 313
		double Price(Instrument instrument);

		// Token: 0x0600013A RID: 314
		double Volatility(Instrument instrument);

		// Token: 0x0600013B RID: 315
		double Delta(Instrument instrument);

		// Token: 0x0600013C RID: 316
		double Gamma(Instrument instrument);

		// Token: 0x0600013D RID: 317
		double Theta(Instrument instrument);

		// Token: 0x0600013E RID: 318
		double Vega(Instrument instrument);

		// Token: 0x0600013F RID: 319
		double Rho(Instrument instrument);

		// Token: 0x06000140 RID: 320
		double Price(Instrument instrument, DateTime dateTime);

		// Token: 0x06000141 RID: 321
		double Volatility(Instrument instrument, DateTime dateTime1, DateTime dateTime2);

		// Token: 0x06000142 RID: 322
		double Delta(Instrument instrument, DateTime dateTime);

		// Token: 0x06000143 RID: 323
		double Gamma(Instrument instrument, DateTime dateTime);

		// Token: 0x06000144 RID: 324
		double Theta(Instrument instrument, DateTime dateTime);

		// Token: 0x06000145 RID: 325
		double Vega(Instrument instrument, DateTime dateTime);

		// Token: 0x06000146 RID: 326
		double Rho(Instrument instrument, DateTime dateTime);
	}
}
