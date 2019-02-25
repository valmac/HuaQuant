using System;
using System.Collections;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000011 RID: 17
	public class BoolParam
	{
		// Token: 0x17000030 RID: 48
		public bool this[Instrument instrument]
		{
			get
			{
				object obj = this.fParam[instrument];
				return obj != null && (bool)obj;
			}
			set
			{
				this.fParam[instrument] = value;
			}
		}

		// Token: 0x04000048 RID: 72
		private Hashtable fParam = new Hashtable();
	}
}
