using System;
using System.IO;

namespace SmartQuant
{
	// Token: 0x02000022 RID: 34
	public class SmartQuantReference : CustomReference
	{
		// Token: 0x060000CA RID: 202 RVA: 0x00004581 File Offset: 0x00003581
		public SmartQuantReference(string name, bool enabled) : base(new FileInfo(Framework.Installation.BinDir.FullName + "\\" + name + ".dll"), ReferenceType.SmartQuant, enabled)
		{
		}
	}
}
