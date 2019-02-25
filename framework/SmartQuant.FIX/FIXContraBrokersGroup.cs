using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000169 RID: 361
	public class FIXContraBrokersGroup : FIXGroup
	{
		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x06004381 RID: 17281 RVA: 0x00049A4C File Offset: 0x00048A4C
		// (set) Token: 0x06004382 RID: 17282 RVA: 0x00049A5E File Offset: 0x00048A5E
		[FIXField("375", EFieldOption.Optional)]
		public string ContraBroker
		{
			get
			{
				return this.GetStringField(375).Value;
			}
			set
			{
				this.AddStringField(375, value);
			}
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x00049A6C File Offset: 0x00048A6C
		// (set) Token: 0x06004384 RID: 17284 RVA: 0x00049A7E File Offset: 0x00048A7E
		[FIXField("337", EFieldOption.Optional)]
		public string ContraTrader
		{
			get
			{
				return this.GetStringField(337).Value;
			}
			set
			{
				this.AddStringField(337, value);
			}
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x00049A8C File Offset: 0x00048A8C
		// (set) Token: 0x06004386 RID: 17286 RVA: 0x00049A9E File Offset: 0x00048A9E
		[FIXField("437", EFieldOption.Optional)]
		public double ContraTradeQty
		{
			get
			{
				return this.GetDoubleField(437).Value;
			}
			set
			{
				this.AddDoubleField(437, value);
			}
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x06004387 RID: 17287 RVA: 0x00049AAC File Offset: 0x00048AAC
		// (set) Token: 0x06004388 RID: 17288 RVA: 0x00049ABE File Offset: 0x00048ABE
		[FIXField("438", EFieldOption.Optional)]
		public DateTime ContraTradeTime
		{
			get
			{
				return this.GetDateTimeField(438).Value;
			}
			set
			{
				this.AddDateTimeField(438, value);
			}
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x06004389 RID: 17289 RVA: 0x00049ACC File Offset: 0x00048ACC
		// (set) Token: 0x0600438A RID: 17290 RVA: 0x00049ADE File Offset: 0x00048ADE
		[FIXField("655", EFieldOption.Optional)]
		public string ContraLegRefID
		{
			get
			{
				return this.GetStringField(655).Value;
			}
			set
			{
				this.AddStringField(655, value);
			}
		}
	}
}
