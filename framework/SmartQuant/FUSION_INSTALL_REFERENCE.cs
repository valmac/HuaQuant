using System;
using System.Runtime.InteropServices;

namespace SmartQuant
{
	// Token: 0x0200002F RID: 47
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct FUSION_INSTALL_REFERENCE
	{
		// Token: 0x040000CF RID: 207
		public uint cbSize;

		// Token: 0x040000D0 RID: 208
		public uint dwFlags;

		// Token: 0x040000D1 RID: 209
		public Guid guidScheme;

		// Token: 0x040000D2 RID: 210
		public string szIdentifier;

		// Token: 0x040000D3 RID: 211
		public string szNonCannonicalData;
	}
}
