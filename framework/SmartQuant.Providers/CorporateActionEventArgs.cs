using System;
using SmartQuant.FIX;
using SmartQuant.FIXData;

namespace SmartQuant.Providers
{
	// Token: 0x02000050 RID: 80
	public class CorporateActionEventArgs : IntradayEventArgs
	{
		// Token: 0x060001DE RID: 478 RVA: 0x0000546C File Offset: 0x0000446C
		public CorporateActionEventArgs(CorporateAction corporateAction, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.corporateAction = corporateAction;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000547D File Offset: 0x0000447D
		public CorporateAction CorporateAction
		{
			get
			{
				return this.corporateAction;
			}
		}

		// Token: 0x040000B9 RID: 185
		private CorporateAction corporateAction;
	}
}
