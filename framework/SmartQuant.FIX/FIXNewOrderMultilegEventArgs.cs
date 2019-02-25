using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000A7 RID: 167
	public class FIXNewOrderMultilegEventArgs : EventArgs
	{
		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x0002597B File Offset: 0x0002497B
		// (set) Token: 0x06002301 RID: 8961 RVA: 0x00025983 File Offset: 0x00024983
		public FIXNewOrderMultileg NewOrderMultileg
		{
			get
			{
				return this.fNewOrderMultileg;
			}
			set
			{
				this.fNewOrderMultileg = value;
			}
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0002598C File Offset: 0x0002498C
		public FIXNewOrderMultilegEventArgs(FIXNewOrderMultileg NewOrderMultileg)
		{
			this.fNewOrderMultileg = NewOrderMultileg;
		}

		// Token: 0x04000347 RID: 839
		private FIXNewOrderMultileg fNewOrderMultileg;
	}
}
