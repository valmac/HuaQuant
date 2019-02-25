using System;

namespace SmartQuant.Instruments
{
	// Token: 0x0200002D RID: 45
	[Serializable]
	public class AccountPosition
	{
		// Token: 0x06000293 RID: 659 RVA: 0x000087AC File Offset: 0x000077AC
		public AccountPosition(Currency currency)
		{
			this.fCurrency = currency;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000087BB File Offset: 0x000077BB
		public Currency Currency
		{
			get
			{
				return this.fCurrency;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000295 RID: 661 RVA: 0x000087C3 File Offset: 0x000077C3
		public double Value
		{
			get
			{
				return this.fValue;
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000087CB File Offset: 0x000077CB
		public override string ToString()
		{
			return this.fValue + " " + this.fCurrency.Code;
		}

		// Token: 0x040000B2 RID: 178
		internal Currency fCurrency;

		// Token: 0x040000B3 RID: 179
		internal double fValue;
	}
}
