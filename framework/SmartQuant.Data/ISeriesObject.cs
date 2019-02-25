using System;
using System.IO;

namespace SmartQuant.Data
{
	// Token: 0x02000003 RID: 3
	public interface ISeriesObject : ICloneable
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5
		DateTime DateTime { get; }

		// Token: 0x06000006 RID: 6
		void ReadFrom(BinaryReader reader);

		// Token: 0x06000007 RID: 7
		void WriteTo(BinaryWriter writer);

		// Token: 0x06000008 RID: 8
		ISeriesObject NewInstance();
	}
}
