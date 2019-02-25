using System;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000021 RID: 33
	public class FinalWealth : SimpleItem
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x0000540F File Offset: 0x0000440F
		public FinalWealth(string name, LiveTester tester, string format) : base(name, format)
		{
			this.tester = tester;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005420 File Offset: 0x00004420
		public FinalWealth(string name, LiveTester tester) : base(name, "F4")
		{
			this.tester = tester;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005435 File Offset: 0x00004435
		public FinalWealth(string name) : base(name)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000543E File Offset: 0x0000443E
		public override double LastValue
		{
			get
			{
				return this.tester.FinalWealth;
			}
		}

		// Token: 0x04000034 RID: 52
		protected LiveTester tester;
	}
}
