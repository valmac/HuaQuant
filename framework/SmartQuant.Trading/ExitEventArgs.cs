using System;
using SmartQuant.Data;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000026 RID: 38
	public class ExitEventArgs : EventArgs
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00006572 File Offset: 0x00005572
		public ExitEventArgs(Instrument instrument, char side, Bar bar)
		{
			this.instrument = instrument;
			this.side = side;
			this.bar = bar;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000658F File Offset: 0x0000558F
		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00006597 File Offset: 0x00005597
		public char Side
		{
			get
			{
				return this.side;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0000659F File Offset: 0x0000559F
		public Bar Bar
		{
			get
			{
				return this.bar;
			}
		}

		// Token: 0x04000087 RID: 135
		private Instrument instrument;

		// Token: 0x04000088 RID: 136
		private char side;

		// Token: 0x04000089 RID: 137
		private Bar bar;
	}
}
