using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000117 RID: 279
	public class FIXDerivativeSecurityListEventArgs : EventArgs
	{
		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x00037F9B File Offset: 0x00036F9B
		// (set) Token: 0x06003507 RID: 13575 RVA: 0x00037FA3 File Offset: 0x00036FA3
		public FIXDerivativeSecurityList DerivativeSecurityList
		{
			get
			{
				return this.fDerivativeSecurityList;
			}
			set
			{
				this.fDerivativeSecurityList = value;
			}
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00037FAC File Offset: 0x00036FAC
		public FIXDerivativeSecurityListEventArgs(FIXDerivativeSecurityList DerivativeSecurityList)
		{
			this.fDerivativeSecurityList = DerivativeSecurityList;
		}

		// Token: 0x040004FF RID: 1279
		private FIXDerivativeSecurityList fDerivativeSecurityList;
	}
}
