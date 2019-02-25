using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200002B RID: 43
	public class FIXTestReqIDGroup : FIXGroup
	{
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0000C924 File Offset: 0x0000B924
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x0000C933 File Offset: 0x0000B933
		[FIXField("112", EFieldOption.Required)]
		public string TestReqID
		{
			get
			{
				return this.GetStringField(112).Value;
			}
			set
			{
				this.AddStringField(112, value);
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0000C93E File Offset: 0x0000B93E
		public FIXTestReqIDGroup()
		{
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0000C946 File Offset: 0x0000B946
		public FIXTestReqIDGroup(string TestReqID)
		{
			this.TestReqID = TestReqID;
		}
	}
}
