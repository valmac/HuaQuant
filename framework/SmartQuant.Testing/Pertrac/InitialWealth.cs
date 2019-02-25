using System;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000030 RID: 48
	public class InitialWealth : SimpleItem
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00006EE1 File Offset: 0x00005EE1
		public InitialWealth(string name, LiveTester tester, string format) : base(name, format)
		{
			this.tester = tester;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006EF2 File Offset: 0x00005EF2
		public InitialWealth(string name, LiveTester tester) : base(name, "F4")
		{
			this.tester = tester;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00006F07 File Offset: 0x00005F07
		public InitialWealth(string name) : base(name)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00006F10 File Offset: 0x00005F10
		public override double LastValue
		{
			get
			{
				return this.tester.InitialWealth;
			}
		}

		// Token: 0x04000071 RID: 113
		protected LiveTester tester;
	}
}
