using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000CC RID: 204
	public class FIXConfirmationEventArgs : EventArgs
	{
		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06002824 RID: 10276 RVA: 0x0002AC2D File Offset: 0x00029C2D
		// (set) Token: 0x06002825 RID: 10277 RVA: 0x0002AC35 File Offset: 0x00029C35
		public FIXConfirmation Confirmation
		{
			get
			{
				return this.fConfirmation;
			}
			set
			{
				this.fConfirmation = value;
			}
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x0002AC3E File Offset: 0x00029C3E
		public FIXConfirmationEventArgs(FIXConfirmation Confirmation)
		{
			this.fConfirmation = Confirmation;
		}

		// Token: 0x040003B1 RID: 945
		private FIXConfirmation fConfirmation;
	}
}
