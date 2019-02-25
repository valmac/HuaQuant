using System;

namespace SmartQuant.Providers
{
	// Token: 0x0200002F RID: 47
	public class BrokerAccountField
	{
		// Token: 0x060000FC RID: 252 RVA: 0x000035D7 File Offset: 0x000025D7
		public BrokerAccountField(string name, string currency, string value)
		{
			this.name = name;
			this.currency = currency;
			this.value = value;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000035F4 File Offset: 0x000025F4
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000035FC File Offset: 0x000025FC
		public string Currency
		{
			get
			{
				return this.currency;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00003604 File Offset: 0x00002604
		public string Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x04000059 RID: 89
		private string name;

		// Token: 0x0400005A RID: 90
		private string currency;

		// Token: 0x0400005B RID: 91
		private string value;
	}
}
