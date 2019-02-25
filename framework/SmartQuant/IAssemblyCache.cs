using System;
using System.Runtime.InteropServices;

namespace SmartQuant
{
	// Token: 0x02000032 RID: 50
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e707dcde-d1cd-11d2-bab9-00c04f8eceae")]
	[ComImport]
	internal interface IAssemblyCache
	{
		// Token: 0x060000F3 RID: 243
		[PreserveSig]
		int UninstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, [MarshalAs(UnmanagedType.LPArray)] FUSION_INSTALL_REFERENCE[] pRefData, out uint pulDisposition);

		// Token: 0x060000F4 RID: 244
		[PreserveSig]
		int QueryAssemblyInfo(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, ref ASSEMBLY_INFO pAsmInfo);

		// Token: 0x060000F5 RID: 245
		[PreserveSig]
		int CreateAssemblyCacheItem(uint dwFlags, IntPtr pvReserved, out IAssemblyCacheItem ppAsmItem, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName);

		// Token: 0x060000F6 RID: 246
		[PreserveSig]
		int CreateAssemblyScavenger([MarshalAs(UnmanagedType.IUnknown)] out object ppAsmScavenger);

		// Token: 0x060000F7 RID: 247
		[PreserveSig]
		int InstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszManifestFilePath, [MarshalAs(UnmanagedType.LPArray)] FUSION_INSTALL_REFERENCE[] pRefData);
	}
}
