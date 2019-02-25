using System;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000052 RID: 82
	public class TradeDays : SimpleItem
	{
		// Token: 0x06000263 RID: 611 RVA: 0x0000E524 File Offset: 0x0000D524
		public TradeDays(string name, LiveTester tester, string format) : base(name, format)
		{
			this.tester = tester;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000E535 File Offset: 0x0000D535
		public TradeDays(string name, LiveTester tester) : base(name, "F4")
		{
			this.tester = tester;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000E54A File Offset: 0x0000D54A
		public TradeDays(string name) : base(name)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000E553 File Offset: 0x0000D553
		public override double LastValue
		{
			get
			{
				return (double)this.tester.TradeDays;
			}
		}

		// Token: 0x040000ED RID: 237
		protected LiveTester tester;
	}
}
