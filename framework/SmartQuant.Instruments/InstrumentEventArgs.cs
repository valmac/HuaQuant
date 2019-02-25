using System;

namespace SmartQuant.Instruments
{
	// Token: 0x02000040 RID: 64
	public class InstrumentEventArgs : EventArgs
	{
		// Token: 0x06000358 RID: 856 RVA: 0x0000B1BB File Offset: 0x0000A1BB
		public InstrumentEventArgs(Instrument instrument)
		{
			this.instrument = instrument;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000B1CA File Offset: 0x0000A1CA
		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
		}

		// Token: 0x040000F5 RID: 245
		private Instrument instrument;
	}
}
