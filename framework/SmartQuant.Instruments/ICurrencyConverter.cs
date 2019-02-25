using System;

namespace SmartQuant.Instruments
{
	// Token: 0x02000007 RID: 7
	public interface ICurrencyConverter
	{
		// Token: 0x06000017 RID: 23
		double Convert(double amount, Currency fromCurrency, Currency toCurrency);

		// Token: 0x06000018 RID: 24
		double Convert(double amount, Currency fromCurrency, Currency toCurrency, DateTime dateTime);
	}
}
