using System;
using System.Runtime.InteropServices;

namespace SmartQuant
{
	// Token: 0x02000036 RID: 54
	[Guid("56b1a988-7c0c-4aa2-8639-c3eb5a90226f")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	internal interface IInstallReferenceEnum
	{
		// Token: 0x06000105 RID: 261
		[PreserveSig]
		int GetNextInstallReferenceItem(out IInstallReferenceItem ppRefItem, uint dwFlags, IntPtr pvReserved);
	}
}
