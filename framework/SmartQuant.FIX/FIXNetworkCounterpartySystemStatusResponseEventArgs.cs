using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000A9 RID: 169
	public class FIXNetworkCounterpartySystemStatusResponseEventArgs : EventArgs
	{
		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x00026F57 File Offset: 0x00025F57
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x00026F5F File Offset: 0x00025F5F
		public FIXNetworkCounterpartySystemStatusResponse NetworkCounterpartySystemStatusResponse
		{
			get
			{
				return this.fNetworkCounterpartySystemStatusResponse;
			}
			set
			{
				this.fNetworkCounterpartySystemStatusResponse = value;
			}
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x00026F68 File Offset: 0x00025F68
		public FIXNetworkCounterpartySystemStatusResponseEventArgs(FIXNetworkCounterpartySystemStatusResponse NetworkCounterpartySystemStatusResponse)
		{
			this.fNetworkCounterpartySystemStatusResponse = NetworkCounterpartySystemStatusResponse;
		}

		// Token: 0x04000351 RID: 849
		private FIXNetworkCounterpartySystemStatusResponse fNetworkCounterpartySystemStatusResponse;
	}
}
