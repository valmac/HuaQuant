using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000147 RID: 327
	public class FIXSettlementInstructionsEventArgs : EventArgs
	{
		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06003EEF RID: 16111 RVA: 0x00044AA8 File Offset: 0x00043AA8
		// (set) Token: 0x06003EF0 RID: 16112 RVA: 0x00044AB0 File Offset: 0x00043AB0
		public FIXSettlementInstructions SettlementInstructions
		{
			get
			{
				return this.fSettlementInstructions;
			}
			set
			{
				this.fSettlementInstructions = value;
			}
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x00044AB9 File Offset: 0x00043AB9
		public FIXSettlementInstructionsEventArgs(FIXSettlementInstructions SettlementInstructions)
		{
			this.fSettlementInstructions = SettlementInstructions;
		}

		// Token: 0x0400094C RID: 2380
		private FIXSettlementInstructions fSettlementInstructions;
	}
}
