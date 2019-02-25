using System;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x0200004B RID: 75
	[Serializable]
	public class BarEventArgs : IntradayEventArgs
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x000051DC File Offset: 0x000041DC
		public BarEventArgs(Bar bar, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.bar = bar;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x000051ED File Offset: 0x000041ED
		public Bar Bar
		{
			get
			{
				return this.bar;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000051F5 File Offset: 0x000041F5
		public override string ToString()
		{
			return string.Format("{0} {1} {2}", this.provider.Name, this.instrument.Symbol, this.bar);
		}

		// Token: 0x040000B3 RID: 179
		private Bar bar;
	}
}
