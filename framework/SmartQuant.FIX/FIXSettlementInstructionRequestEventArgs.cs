using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000076 RID: 118
	public class FIXSettlementInstructionRequestEventArgs : EventArgs
	{
		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x000171D5 File Offset: 0x000161D5
		// (set) Token: 0x0600148F RID: 5263 RVA: 0x000171DD File Offset: 0x000161DD
		public FIXSettlementInstructionRequest SettlementInstructionRequest
		{
			get
			{
				return this.fSettlementInstructionRequest;
			}
			set
			{
				this.fSettlementInstructionRequest = value;
			}
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000171E6 File Offset: 0x000161E6
		public FIXSettlementInstructionRequestEventArgs(FIXSettlementInstructionRequest SettlementInstructionRequest)
		{
			this.fSettlementInstructionRequest = SettlementInstructionRequest;
		}

		// Token: 0x04000283 RID: 643
		private FIXSettlementInstructionRequest fSettlementInstructionRequest;
	}
}
