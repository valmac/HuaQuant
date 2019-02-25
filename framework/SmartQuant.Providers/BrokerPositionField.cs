using System;

namespace SmartQuant.Providers
{
	// Token: 0x02000010 RID: 16
	public class BrokerPositionField
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00002265 File Offset: 0x00001265
		public BrokerPositionField(string name, string value)
		{
			this.name = name;
			this.value = value;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000227B File Offset: 0x0000127B
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002283 File Offset: 0x00001283
		public string Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x0400002B RID: 43
		private string name;

		// Token: 0x0400002C RID: 44
		private string value;
	}
}
