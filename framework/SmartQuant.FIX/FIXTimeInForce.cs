using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000154 RID: 340
	public class FIXTimeInForce : FIXCharField
	{
		// Token: 0x06004025 RID: 16421 RVA: 0x00045D53 File Offset: 0x00044D53
		public FIXTimeInForce(char val) : base(59, val)
		{
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x00045D60 File Offset: 0x00044D60
		public new static char Value(string Name)
		{
			if (Name == "Day")
			{
				return '0';
			}
			if (Name == "GTC")
			{
				return '1';
			}
			if (Name == "OPG")
			{
				return '2';
			}
			if (Name == "IOC")
			{
				return '3';
			}
			if (Name == "FOK")
			{
				return '4';
			}
			if (Name == "GTX")
			{
				return '5';
			}
			if (Name == "GoodTillDate")
			{
				return '6';
			}
			if (Name == "AtTheClose")
			{
				return '7';
			}
			return '\0';
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x00045DF0 File Offset: 0x00044DF0
		public static string ToString(char c)
		{
			switch (c)
			{
			case '0':
				return "Day";
			case '1':
				return "GTC";
			case '2':
				return "OPG";
			case '3':
				return "IOC";
			case '4':
				return "FOK";
			case '5':
				return "GTX";
			case '6':
				return "GoodTillDate";
			case '7':
				return "AtTheClose";
			default:
				return "Unknown";
			}
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x00045E60 File Offset: 0x00044E60
		public static TimeInForce FromFIX(char timeInForce)
		{
			if (timeInForce == '\0')
			{
				return TimeInForce.Undefined;
			}
			switch (timeInForce)
			{
			case '0':
				return TimeInForce.Day;
			case '1':
				return TimeInForce.GTC;
			case '2':
				return TimeInForce.OPG;
			case '3':
				return TimeInForce.IOC;
			case '4':
				return TimeInForce.FOK;
			case '5':
				return TimeInForce.GTX;
			case '6':
				return TimeInForce.GoodTillDate;
			case '7':
				return TimeInForce.AtTheClose;
			default:
				throw new ArgumentException("Unknown time in force - " + timeInForce);
			}
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x00045EC8 File Offset: 0x00044EC8
		public static char ToFIX(TimeInForce timeInForce)
		{
			switch (timeInForce)
			{
			case TimeInForce.Undefined:
				return '\0';
			case TimeInForce.Day:
				return '0';
			case TimeInForce.GTC:
				return '1';
			case TimeInForce.OPG:
				return '2';
			case TimeInForce.IOC:
				return '3';
			case TimeInForce.FOK:
				return '4';
			case TimeInForce.GTX:
				return '5';
			case TimeInForce.GoodTillDate:
				return '6';
			case TimeInForce.AtTheClose:
				return '7';
			default:
				throw new ArgumentException("Unknown time in force - " + timeInForce.ToString());
			}
		}

		// Token: 0x0400095C RID: 2396
		public const char Day = '0';

		// Token: 0x0400095D RID: 2397
		public const char GTC = '1';

		// Token: 0x0400095E RID: 2398
		public const char OPG = '2';

		// Token: 0x0400095F RID: 2399
		public const char IOC = '3';

		// Token: 0x04000960 RID: 2400
		public const char FOK = '4';

		// Token: 0x04000961 RID: 2401
		public const char GTX = '5';

		// Token: 0x04000962 RID: 2402
		public const char GoodTillDate = '6';

		// Token: 0x04000963 RID: 2403
		public const char AtTheClose = '7';
	}
}
