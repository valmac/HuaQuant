using System;
using System.IO;
using System.Reflection;

namespace SmartQuant
{
	// Token: 0x0200000A RID: 10
	public class CustomReference : Reference
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002D78 File Offset: 0x00001D78
		protected CustomReference(FileInfo file, ReferenceType referenceType, bool enabled) : base(referenceType, enabled)
		{
			this.file = file;
			try
			{
				this.assemblyName = AssemblyName.GetAssemblyName(file.FullName);
				this.valid = true;
			}
			catch (Exception ex)
			{
				ex.GetHashCode();
				this.assemblyName = new AssemblyName();
				this.assemblyName.Name = file.Name.Replace(file.Extension, "");
				this.assemblyName.Version = new Version();
				this.valid = false;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002E0C File Offset: 0x00001E0C
		public override string Path
		{
			get
			{
				return this.file.FullName;
			}
		}

		// Token: 0x04000031 RID: 49
		protected FileInfo file;
	}
}
