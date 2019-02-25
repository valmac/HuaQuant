using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000161 RID: 353
	public class FIXNetworkCounterpartySystemStatusRequestEventArgs : EventArgs
	{
		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x06004315 RID: 17173 RVA: 0x000493B4 File Offset: 0x000483B4
		// (set) Token: 0x06004316 RID: 17174 RVA: 0x000493BC File Offset: 0x000483BC
		public FIXNetworkCounterpartySystemStatusRequest NetworkCounterpartySystemStatusRequest
		{
			get
			{
				return this.fNetworkCounterpartySystemStatusRequest;
			}
			set
			{
				this.fNetworkCounterpartySystemStatusRequest = value;
			}
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x000493C5 File Offset: 0x000483C5
		public FIXNetworkCounterpartySystemStatusRequestEventArgs(FIXNetworkCounterpartySystemStatusRequest NetworkCounterpartySystemStatusRequest)
		{
			this.fNetworkCounterpartySystemStatusRequest = NetworkCounterpartySystemStatusRequest;
		}

		// Token: 0x040009A6 RID: 2470
		private FIXNetworkCounterpartySystemStatusRequest fNetworkCounterpartySystemStatusRequest;
	}
}
