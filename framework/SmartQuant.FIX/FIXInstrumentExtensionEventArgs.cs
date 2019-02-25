using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000C6 RID: 198
	public class FIXInstrumentExtensionEventArgs : EventArgs
	{
		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x00029B50 File Offset: 0x00028B50
		// (set) Token: 0x0600271E RID: 10014 RVA: 0x00029B58 File Offset: 0x00028B58
		public FIXInstrumentExtension InstrumentExtension
		{
			get
			{
				return this.fInstrumentExtension;
			}
			set
			{
				this.fInstrumentExtension = value;
			}
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00029B61 File Offset: 0x00028B61
		public FIXInstrumentExtensionEventArgs(FIXInstrumentExtension InstrumentExtension)
		{
			this.fInstrumentExtension = InstrumentExtension;
		}

		// Token: 0x040003A4 RID: 932
		private FIXInstrumentExtension fInstrumentExtension;
	}
}
