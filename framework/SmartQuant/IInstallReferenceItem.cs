using System;
using System.Runtime.InteropServices;

namespace SmartQuant
{
	// Token: 0x02000035 RID: 53
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("582dac66-e678-449f-aba6-6faaec8a9394")]
	[ComImport]
	internal interface IInstallReferenceItem
	{
		// Token: 0x06000104 RID: 260
		[PreserveSig]
		int GetReference([MarshalAs(UnmanagedType.LPArray)] out FUSION_INSTALL_REFERENCE[] ppRefData, uint dwFlags, IntPtr pvReserved);
	}
}
