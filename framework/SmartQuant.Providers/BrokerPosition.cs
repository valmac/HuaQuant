using System;
using System.Collections.Generic;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000045 RID: 69
	public class BrokerPosition
	{
		// Token: 0x0600017E RID: 382 RVA: 0x00004C74 File Offset: 0x00003C74
		public BrokerPosition()
		{
			this.symbol = string.Empty;
			this.securityType = string.Empty;
			this.securityExchange = string.Empty;
			this.currency = string.Empty;
			this.maturityDate = DateTime.MinValue;
			this.putOrCall = PutOrCall.Put;
			this.strike = 0.0;
			this.qty = 0.0;
			this.longQty = 0.0;
			this.shortQty = 0.0;
			this.customFields = new SortedList<string, string>();
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00004D0C File Offset: 0x00003D0C
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00004D14 File Offset: 0x00003D14
		public string Symbol
		{
			get
			{
				return this.symbol;
			}
			set
			{
				this.symbol = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00004D1D File Offset: 0x00003D1D
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00004D25 File Offset: 0x00003D25
		public string SecurityType
		{
			get
			{
				return this.securityType;
			}
			set
			{
				this.securityType = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00004D2E File Offset: 0x00003D2E
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00004D36 File Offset: 0x00003D36
		public string SecurityExchange
		{
			get
			{
				return this.securityExchange;
			}
			set
			{
				this.securityExchange = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00004D3F File Offset: 0x00003D3F
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00004D47 File Offset: 0x00003D47
		public string Currency
		{
			get
			{
				return this.currency;
			}
			set
			{
				this.currency = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00004D50 File Offset: 0x00003D50
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00004D58 File Offset: 0x00003D58
		public DateTime MaturityDate
		{
			get
			{
				return this.maturityDate;
			}
			set
			{
				this.maturityDate = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00004D61 File Offset: 0x00003D61
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00004D69 File Offset: 0x00003D69
		public PutOrCall PutOrCall
		{
			get
			{
				return this.putOrCall;
			}
			set
			{
				this.putOrCall = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00004D72 File Offset: 0x00003D72
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00004D7A File Offset: 0x00003D7A
		public double Strike
		{
			get
			{
				return this.strike;
			}
			set
			{
				this.strike = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00004D83 File Offset: 0x00003D83
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00004D8B File Offset: 0x00003D8B
		public double Qty
		{
			get
			{
				return this.qty;
			}
			set
			{
				this.qty = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00004D94 File Offset: 0x00003D94
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00004D9C File Offset: 0x00003D9C
		public double LongQty
		{
			get
			{
				return this.longQty;
			}
			set
			{
				this.longQty = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00004DA5 File Offset: 0x00003DA5
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00004DAD File Offset: 0x00003DAD
		public double ShortQty
		{
			get
			{
				return this.shortQty;
			}
			set
			{
				this.shortQty = value;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00004DB6 File Offset: 0x00003DB6
		public void AddCustomField(string name, string value)
		{
			this.customFields.Add(name, value);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00004DC8 File Offset: 0x00003DC8
		public BrokerPositionField[] GetCustomFields()
		{
			List<BrokerPositionField> list = new List<BrokerPositionField>();
			foreach (KeyValuePair<string, string> keyValuePair in this.customFields)
			{
				list.Add(new BrokerPositionField(keyValuePair.Key, keyValuePair.Value));
			}
			return list.ToArray();
		}

		// Token: 0x0400009B RID: 155
		private string symbol;

		// Token: 0x0400009C RID: 156
		private string securityType;

		// Token: 0x0400009D RID: 157
		private string securityExchange;

		// Token: 0x0400009E RID: 158
		private string currency;

		// Token: 0x0400009F RID: 159
		private DateTime maturityDate;

		// Token: 0x040000A0 RID: 160
		private PutOrCall putOrCall;

		// Token: 0x040000A1 RID: 161
		private double strike;

		// Token: 0x040000A2 RID: 162
		private double qty;

		// Token: 0x040000A3 RID: 163
		private double longQty;

		// Token: 0x040000A4 RID: 164
		private double shortQty;

		// Token: 0x040000A5 RID: 165
		private SortedList<string, string> customFields;
	}
}
