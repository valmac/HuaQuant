using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000016 RID: 22
	public class FIXCxlRejResponseTo : FIXCharField
	{
		// Token: 0x06000513 RID: 1299 RVA: 0x00007760 File Offset: 0x00006760
		public FIXCxlRejResponseTo(char value) : base(434, value)
		{
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00007770 File Offset: 0x00006770
		public static CxlRejResponseTo FromFIX(char value)
		{
			switch (value)
			{
			case '1':
				return CxlRejResponseTo.CancelRequest;
			case '2':
				return CxlRejResponseTo.CancelReplaceRequest;
			default:
				throw new ArgumentException(string.Format("Unknown response - {0}", value));
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000077AC File Offset: 0x000067AC
		public static char ToFIX(CxlRejResponseTo response)
		{
			switch (response)
			{
			case CxlRejResponseTo.CancelRequest:
				return '1';
			case CxlRejResponseTo.CancelReplaceRequest:
				return '2';
			default:
				throw new ArgumentException(string.Format("Unknown response - {0}", response));
			}
		}

		// Token: 0x04000037 RID: 55
		public const char CancelRequest = '1';

		// Token: 0x04000038 RID: 56
		public const char CancelReplaceRequest = '2';
	}
}
