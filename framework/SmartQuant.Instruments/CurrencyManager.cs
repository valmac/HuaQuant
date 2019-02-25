using System;

namespace SmartQuant.Instruments
{
	// Token: 0x0200004B RID: 75
	public class CurrencyManager : MarshalByRefObject
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0000C6E9 File Offset: 0x0000B6E9
		public static CurrencyList Currencies
		{
			get
			{
				return CurrencyManager.fCurrencies;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000C6F0 File Offset: 0x0000B6F0
		public static Currency DefaultCurrency
		{
			get
			{
				return CurrencyManager.fCurrencies[Framework.Configuration.DefaultCurrency];
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000C706 File Offset: 0x0000B706
		static CurrencyManager()
		{
			Currency.Init();
		}

		// Token: 0x04000109 RID: 265
		private static CurrencyList fCurrencies = new CurrencyList();
	}
}
