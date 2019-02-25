using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000192 RID: 402
	public class FIXPositionEffect : FIXCharField
	{
		// Token: 0x06004B92 RID: 19346 RVA: 0x000538C0 File Offset: 0x000528C0
		public FIXPositionEffect(char val) : base(77, val)
		{
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x000538CC File Offset: 0x000528CC
		public new static char Value(string Name)
		{
			if (Name == "Open")
			{
				return 'O';
			}
			if (Name == "Close")
			{
				return 'C';
			}
			if (Name == "Rolled")
			{
				return 'R';
			}
			if (Name == "FIFO")
			{
				return 'F';
			}
			return '\0';
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x0005391C File Offset: 0x0005291C
		public static string ToString(char c)
		{
			if (c <= 'F')
			{
				if (c == 'C')
				{
					return "Close";
				}
				if (c == 'F')
				{
					return "FIFO";
				}
			}
			else
			{
				if (c == 'O')
				{
					return "Open";
				}
				if (c == 'R')
				{
					return "Rolled";
				}
			}
			return "Unknown";
		}

		// Token: 0x04000DC4 RID: 3524
		public const char Open = 'O';

		// Token: 0x04000DC5 RID: 3525
		public const char Close = 'C';

		// Token: 0x04000DC6 RID: 3526
		public const char Rolled = 'R';

		// Token: 0x04000DC7 RID: 3527
		public const char FIFO = 'F';
	}
}
