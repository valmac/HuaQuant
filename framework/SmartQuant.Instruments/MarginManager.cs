using System;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
	// Token: 0x02000023 RID: 35
	public class MarginManager
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00007E03 File Offset: 0x00006E03
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00007E0B File Offset: 0x00006E0B
		public bool Enabled
		{
			get
			{
				return this.fEnabled;
			}
			set
			{
				this.fEnabled = value;
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00007E24 File Offset: 0x00006E24
		public virtual double GetInitialMargin(double Value, Instrument instrument, Side side, DateTime dateTime)
		{
			if (!this.fEnabled)
			{
				return 0.0;
			}
			if (instrument.SecurityType == "CS" && (side == Side.Buy || side == Side.SellShort))
			{
				return Value * 0.5;
			}
			return 0.0;
		}

		// Token: 0x0400009F RID: 159
		private bool fEnabled = true;
	}
}
