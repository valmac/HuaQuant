using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000069 RID: 105
	public class FIXInstrumentLegEventArgs : EventArgs
	{
		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x000156B3 File Offset: 0x000146B3
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x000156BB File Offset: 0x000146BB
		public FIXInstrumentLeg InstrumentLeg
		{
			get
			{
				return this.fInstrumentLeg;
			}
			set
			{
				this.fInstrumentLeg = value;
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000156C4 File Offset: 0x000146C4
		public FIXInstrumentLegEventArgs(FIXInstrumentLeg InstrumentLeg)
		{
			this.fInstrumentLeg = InstrumentLeg;
		}

		// Token: 0x0400025A RID: 602
		private FIXInstrumentLeg fInstrumentLeg;
	}
}
