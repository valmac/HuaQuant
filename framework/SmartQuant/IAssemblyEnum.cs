using System;
using System.Runtime.InteropServices;

namespace SmartQuant
{
	// Token: 0x02000034 RID: 52
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("21b8916c-f28e-11d2-a473-00c04f8ef448")]
	[ComImport]
	internal interface IAssemblyEnum
	{
		// Token: 0x06000101 RID: 257
		[PreserveSig]
		int GetNextAssembly(IntPtr pvReserved, out IAssemblyName ppName, uint dwFlags);

		// Token: 0x06000102 RID: 258
		[PreserveSig]
		int Reset();

		// Token: 0x06000103 RID: 259
		[PreserveSig]
		int Clone(out IAssemblyEnum ppEnum);
	}
}
