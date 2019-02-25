using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SmartQuant
{
	// Token: 0x02000033 RID: 51
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("CD193BC0-B4BC-11d2-9833-00C04FC31D2E")]
	[ComImport]
	internal interface IAssemblyName
	{
		// Token: 0x060000F8 RID: 248
		[PreserveSig]
		int SetProperty(ASM_NAME PropertyId, IntPtr pvProperty, uint cbProperty);

		// Token: 0x060000F9 RID: 249
		[PreserveSig]
		int GetProperty(ASM_NAME PropertyId, IntPtr pvProperty, ref uint pcbProperty);

		// Token: 0x060000FA RID: 250
		[PreserveSig]
		int Finalize();

		// Token: 0x060000FB RID: 251
		[PreserveSig]
		int GetDisplayName([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder szDisplayName, ref uint pccDisplayName, ASM_DISPLAY_FLAGS dwDisplayFlags);

		// Token: 0x060000FC RID: 252
		[PreserveSig]
		int BindToObject(ref Guid refIID, [MarshalAs(UnmanagedType.IUnknown)] object pUnkSink, [MarshalAs(UnmanagedType.IUnknown)] object pUnkContext, [MarshalAs(UnmanagedType.LPWStr)] string szCodeBase, long llFlags, IntPtr pvReserved, uint cbReserved, out IntPtr ppv);

		// Token: 0x060000FD RID: 253
		[PreserveSig]
		int GetName(ref uint lpcwBuffer, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder pwzName);

		// Token: 0x060000FE RID: 254
		[PreserveSig]
		int GetVersion(out uint pdwVersionHi, out uint pdwVersionLow);

		// Token: 0x060000FF RID: 255
		[PreserveSig]
		int IsEqual(IAssemblyName pName, ASM_CMP_FLAGS dwCmpFlags);

		// Token: 0x06000100 RID: 256
		[PreserveSig]
		int Clone(out IAssemblyName pName);
	}
}
