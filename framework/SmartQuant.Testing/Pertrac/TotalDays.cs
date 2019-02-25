using System;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000035 RID: 53
	public class TotalDays : SimpleItem
	{
		// Token: 0x0600012E RID: 302 RVA: 0x0000713B File Offset: 0x0000613B
		public TotalDays(string name, LiveTester tester, string format) : base(name, format)
		{
			this.tester = tester;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000714C File Offset: 0x0000614C
		public TotalDays(string name, LiveTester tester) : base(name, "F4")
		{
			this.tester = tester;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00007161 File Offset: 0x00006161
		public TotalDays(string name) : base(name)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000716A File Offset: 0x0000616A
		public override double LastValue
		{
			get
			{
				return (double)this.tester.TestDays;
			}
		}

		// Token: 0x04000076 RID: 118
		protected LiveTester tester;
	}
}
