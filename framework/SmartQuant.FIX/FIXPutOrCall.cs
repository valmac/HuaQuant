using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000191 RID: 401
	public class FIXPutOrCall : FIXIntField
	{
		// Token: 0x06004B8E RID: 19342 RVA: 0x0005380F File Offset: 0x0005280F
		public FIXPutOrCall(int val) : base(201, val)
		{
		}

		// Token: 0x06004B8F RID: 19343 RVA: 0x00053820 File Offset: 0x00052820
		public static string ToString(int i)
		{
			switch (i)
			{
			case 0:
				return "Put";
			case 1:
				return "Call";
			default:
				return "Unknown";
			}
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x00053850 File Offset: 0x00052850
		public static PutOrCall FromFIX(int value)
		{
			switch (value)
			{
			case 0:
				return PutOrCall.Put;
			case 1:
				return PutOrCall.Call;
			default:
				throw new ArgumentException(string.Format("Unknown put or call value - {0}", value));
			}
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x00053888 File Offset: 0x00052888
		public static int ToFIX(PutOrCall value)
		{
			switch (value)
			{
			case PutOrCall.Put:
				return 0;
			case PutOrCall.Call:
				return 1;
			default:
				throw new ArgumentException(string.Format("Unknown put or call value - {0}", value));
			}
		}

		// Token: 0x04000DC2 RID: 3522
		public const int Put = 0;

		// Token: 0x04000DC3 RID: 3523
		public const int Call = 1;
	}
}
