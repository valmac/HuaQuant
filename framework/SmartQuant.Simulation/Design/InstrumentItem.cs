using System;
using SmartQuant.Instruments;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x02000031 RID: 49
	internal class InstrumentItem
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x0000905F File Offset: 0x0000805F
		public InstrumentItem(Instrument instrument)
		{
			this.instrument = instrument;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000906E File Offset: 0x0000806E
		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00009076 File Offset: 0x00008076
		public override string ToString()
		{
			return this.instrument.Symbol;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00009083 File Offset: 0x00008083
		public override int GetHashCode()
		{
			return this.instrument.GetHashCode();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00009090 File Offset: 0x00008090
		public override bool Equals(object obj)
		{
			return this.instrument.Equals(obj);
		}

		// Token: 0x040000DC RID: 220
		private Instrument instrument;
	}
}
