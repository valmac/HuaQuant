using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200008C RID: 140
	public class FIXFaMethod : FIXStringField
	{
		// Token: 0x06001B03 RID: 6915 RVA: 0x0001DA84 File Offset: 0x0001CA84
		public FIXFaMethod(string value) : base(10710, value)
		{
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0001DA94 File Offset: 0x0001CA94
		public static string ToFIX(FaMethod value)
		{
			switch (value)
			{
			case FaMethod.PctChange:
				return "PctChange";
			case FaMethod.AvailableEquity:
				return "AvailableEquity";
			case FaMethod.NetLiq:
				return "NetLiq";
			case FaMethod.EqualQuantity:
				return "EqualQuantity";
			default:
				throw new ArgumentException(string.Format("Unknown allocation method - {0}", value));
			}
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0001DAE8 File Offset: 0x0001CAE8
		public static FaMethod FromFIX(string value)
		{
			if (value != null)
			{
				if (value == "AvailableEquity")
				{
					return FaMethod.AvailableEquity;
				}
				if (value == "EqualQuantity")
				{
					return FaMethod.EqualQuantity;
				}
				if (value == "NetLiq")
				{
					return FaMethod.NetLiq;
				}
				if (value == "PctChange")
				{
					return FaMethod.PctChange;
				}
			}
			return FaMethod.Undefined;
		}

		// Token: 0x040002D3 RID: 723
		public const string PctChange = "PctChange";

		// Token: 0x040002D4 RID: 724
		public const string AvailableEquity = "AvailableEquity";

		// Token: 0x040002D5 RID: 725
		public const string NetLiq = "NetLiq";

		// Token: 0x040002D6 RID: 726
		public const string EqualQuantity = "EqualQuantity";
	}
}
