using System;
using System.Collections;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x0200004A RID: 74
	public class IntParam
	{
		// Token: 0x1700009C RID: 156
		public int this[Instrument instrument]
		{
			get
			{
				object obj = this.fParam[instrument];
				if (obj != null)
				{
					return (int)obj;
				}
				return 0;
			}
			set
			{
				this.fParam[instrument] = value;
			}
		}

		// Token: 0x040000FE RID: 254
		private Hashtable fParam = new Hashtable();
	}
}
