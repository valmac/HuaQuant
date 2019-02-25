using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000BD RID: 189
	public class FIXUserRequestEventArgs : EventArgs
	{
		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x00028A6C File Offset: 0x00027A6C
		// (set) Token: 0x06002606 RID: 9734 RVA: 0x00028A74 File Offset: 0x00027A74
		public FIXUserRequest UserRequest
		{
			get
			{
				return this.fUserRequest;
			}
			set
			{
				this.fUserRequest = value;
			}
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00028A7D File Offset: 0x00027A7D
		public FIXUserRequestEventArgs(FIXUserRequest UserRequest)
		{
			this.fUserRequest = UserRequest;
		}

		// Token: 0x04000397 RID: 919
		private FIXUserRequest fUserRequest;
	}
}
