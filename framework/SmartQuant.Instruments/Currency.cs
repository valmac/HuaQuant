using System;

namespace SmartQuant.Instruments
{
	// Token: 0x0200003B RID: 59
	public class Currency
	{
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0000A76D File Offset: 0x0000976D
		public string Code
		{
			get
			{
				return this.fCode;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000A775 File Offset: 0x00009775
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0000A77D File Offset: 0x0000977D
		public string Description
		{
			get
			{
				return this.fDescription;
			}
			set
			{
				this.fDescription = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000A786 File Offset: 0x00009786
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0000A78D File Offset: 0x0000978D
		public static ICurrencyConverter Converter
		{
			get
			{
				return Currency.fConverter;
			}
			set
			{
				Currency.fConverter = value;
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000A795 File Offset: 0x00009795
		internal static void Init()
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000A797 File Offset: 0x00009797
		public Currency(string code) : this(code, "")
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000A7A5 File Offset: 0x000097A5
		public Currency(string code, string description)
		{
			this.fCode = code;
			this.fDescription = description;
			CurrencyManager.Currencies.Add(this);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000A7C6 File Offset: 0x000097C6
		public static double Convert(double amount, Currency fromCurrency, Currency toCurrency)
		{
			return Currency.fConverter.Convert(amount, fromCurrency, toCurrency);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000A7D5 File Offset: 0x000097D5
		public static double Convert(double amount, Currency fromCurrency, Currency toCurrency, DateTime dateTime)
		{
			return Currency.fConverter.Convert(amount, fromCurrency, toCurrency, dateTime);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000A7E5 File Offset: 0x000097E5
		public double Convert(double amount, Currency toCurrency)
		{
			return Currency.fConverter.Convert(amount, this, toCurrency);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000A7F4 File Offset: 0x000097F4
		public double Convert(double amount, Currency toCurrency, DateTime dateTime)
		{
			return Currency.fConverter.Convert(amount, this, toCurrency, dateTime);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000A804 File Offset: 0x00009804
		public override string ToString()
		{
			return this.fCode;
		}

		// Token: 0x040000CE RID: 206
		private string fCode;

		// Token: 0x040000CF RID: 207
		private string fDescription;

		// Token: 0x040000D0 RID: 208
		private static ICurrencyConverter fConverter = new CurrencyConverter();

		// Token: 0x040000D1 RID: 209
		public static Currency ARS = new Currency("ARS", "Argentina Peso");

		// Token: 0x040000D2 RID: 210
		public static Currency ATS = new Currency("ATS", "Austrian Schilling");

		// Token: 0x040000D3 RID: 211
		public static Currency AUD = new Currency("AUD", "Australian Dollar");

		// Token: 0x040000D4 RID: 212
		public static Currency BEF = new Currency("BEF", "Belgian Franc");

		// Token: 0x040000D5 RID: 213
		public static Currency BRL = new Currency("BRL", "Brazilian Real");

		// Token: 0x040000D6 RID: 214
		public static Currency CAD = new Currency("CAD", "Canadian Dollar");

		// Token: 0x040000D7 RID: 215
		public static Currency CHF = new Currency("CHF", "Swiss Franc");

		// Token: 0x040000D8 RID: 216
		public static Currency DEM = new Currency("DEM", "Deutsche Mark");

		// Token: 0x040000D9 RID: 217
		public static Currency ESP = new Currency("ESP", "Spanish Peseta");

		// Token: 0x040000DA RID: 218
		public static Currency EUR = new Currency("EUR", "Euro");

		// Token: 0x040000DB RID: 219
		public static Currency FRF = new Currency("FRF", "French Franc");

		// Token: 0x040000DC RID: 220
		public static Currency GBP = new Currency("GBP", "British Pound");

		// Token: 0x040000DD RID: 221
		public static Currency HKD = new Currency("HKD", "Hong Kong Dollar");

		// Token: 0x040000DE RID: 222
		public static Currency INR = new Currency("INR", "Indian Rupee");

		// Token: 0x040000DF RID: 223
		public static Currency ITL = new Currency("ITL", "Italian Lira");

		// Token: 0x040000E0 RID: 224
		public static Currency JPY = new Currency("JPY", "Japanese Yen");

		// Token: 0x040000E1 RID: 225
		public static Currency KRW = new Currency("KRW", "Korean (South) Won");

		// Token: 0x040000E2 RID: 226
		public static Currency NLG = new Currency("NLG", "Netherlands Gilder");

		// Token: 0x040000E3 RID: 227
		public static Currency PTE = new Currency("PTE", "Portuguese Escudo");

		// Token: 0x040000E4 RID: 228
		public static Currency RUR = new Currency("RUR", "Russian Ruble");

		// Token: 0x040000E5 RID: 229
		public static Currency SGD = new Currency("SGD", "Singapore Dollar");

		// Token: 0x040000E6 RID: 230
		public static Currency USD = new Currency("USD", "US Dollar");

		// Token: 0x040000E7 RID: 231
		public static Currency XBA = new Currency("XBA", "European Composite Unit");

		// Token: 0x040000E8 RID: 232
		public static Currency XEU = new Currency("XEU", "European Currency Unit");
	}
}
