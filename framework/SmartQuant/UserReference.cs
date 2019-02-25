using System;
using System.IO;

namespace SmartQuant
{
	// Token: 0x0200001A RID: 26
	public class UserReference : CustomReference
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00004111 File Offset: 0x00003111
		public UserReference(FileInfo file, bool enabled) : base(file, ReferenceType.User, enabled)
		{
		}
	}
}
