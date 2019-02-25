using System;

namespace SmartQuant.Instruments
{
	// Token: 0x02000008 RID: 8
	public class CurrencyConverter : ICurrencyConverter
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002393 File Offset: 0x00001393
		public virtual double Convert(double amount, Currency fromCurrency, Currency toCurrency)
		{
			return amount;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002396 File Offset: 0x00001396
		public virtual double Convert(double amount, Currency fromCurrency, Currency toCurrency, DateTime dateTime)
		{
			return amount;
		}
	}
}
