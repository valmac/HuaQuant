using System;
using System.Runtime.InteropServices;

namespace SmartQuant
{
	// Token: 0x02000030 RID: 48
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct ASSEMBLY_INFO
	{
		// Token: 0x040000D4 RID: 212
		public uint cbAssemblyInfo;

		// Token: 0x040000D5 RID: 213
		public uint dwAssemblyFlags;

		// Token: 0x040000D6 RID: 214
		public ulong uliAssemblySizeInKB;

		// Token: 0x040000D7 RID: 215
		public string pszCurrentAssemblyPathBuf;

		// Token: 0x040000D8 RID: 216
		public uint cchBuf;
	}
}
