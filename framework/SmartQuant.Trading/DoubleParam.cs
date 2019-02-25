using System;
using System.Collections;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x0200001E RID: 30
	public class DoubleParam
	{
		// Token: 0x1700003A RID: 58
		public double this[Instrument instrument]
		{
			get
			{
				object obj = this.fParam[instrument];
				if (obj != null)
				{
					return (double)obj;
				}
				return 0.0;
			}
			set
			{
				this.fParam[instrument] = value;
			}
		}

		// Token: 0x0400005F RID: 95
		private Hashtable fParam = new Hashtable();
	}
}
