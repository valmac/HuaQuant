using System;
using SmartQuant.Data;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000056 RID: 86
	public class EntryEventArgs : EventArgs
	{
		// Token: 0x06000352 RID: 850 RVA: 0x0000D0C4 File Offset: 0x0000C0C4
		public EntryEventArgs(Instrument instrument, char side, Bar bar)
		{
			this.instrument = instrument;
			this.side = side;
			this.bar = bar;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000D0E1 File Offset: 0x0000C0E1
		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000D0E9 File Offset: 0x0000C0E9
		public char Side
		{
			get
			{
				return this.side;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0000D0F1 File Offset: 0x0000C0F1
		public Bar Bar
		{
			get
			{
				return this.bar;
			}
		}

		// Token: 0x04000118 RID: 280
		private Instrument instrument;

		// Token: 0x04000119 RID: 281
		private char side;

		// Token: 0x0400011A RID: 282
		private Bar bar;
	}
}
