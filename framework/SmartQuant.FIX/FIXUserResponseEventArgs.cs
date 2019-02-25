using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000FC RID: 252
	public class FIXUserResponseEventArgs : EventArgs
	{
		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x0003120A File Offset: 0x0003020A
		// (set) Token: 0x06002EB0 RID: 11952 RVA: 0x00031212 File Offset: 0x00030212
		public FIXUserResponse UserResponse
		{
			get
			{
				return this.fUserResponse;
			}
			set
			{
				this.fUserResponse = value;
			}
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x0003121B File Offset: 0x0003021B
		public FIXUserResponseEventArgs(FIXUserResponse UserResponse)
		{
			this.fUserResponse = UserResponse;
		}

		// Token: 0x04000419 RID: 1049
		private FIXUserResponse fUserResponse;
	}
}
