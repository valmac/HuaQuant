using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace SmartQuant
{
	// Token: 0x02000037 RID: 55
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9E3AAEB4-D1CD-11D2-BAB9-00C04F8ECEAE")]
	[ComImport]
	internal interface IAssemblyCacheItem
	{
		// Token: 0x06000106 RID: 262
		void CreateStream(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszStreamName, uint dwFormat, uint dwFormatFlags, out IStream ppIStream, ref long puliMaxSize);

		// Token: 0x06000107 RID: 263
		void Commit(uint dwFlags, out long pulDisposition);

		// Token: 0x06000108 RID: 264
		void AbortItem();
	}
}
