using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200005F RID: 95
	public class FIXUnderlyingInstrumentEventArgs : EventArgs
	{
		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x00013762 File Offset: 0x00012762
		// (set) Token: 0x06001120 RID: 4384 RVA: 0x0001376A File Offset: 0x0001276A
		public FIXUnderlyingInstrument UnderlyingInstrument
		{
			get
			{
				return this.fUnderlyingInstrument;
			}
			set
			{
				this.fUnderlyingInstrument = value;
			}
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00013773 File Offset: 0x00012773
		public FIXUnderlyingInstrumentEventArgs(FIXUnderlyingInstrument UnderlyingInstrument)
		{
			this.fUnderlyingInstrument = UnderlyingInstrument;
		}

		// Token: 0x04000246 RID: 582
		private FIXUnderlyingInstrument fUnderlyingInstrument;
	}
}
