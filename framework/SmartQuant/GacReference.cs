using System;
using System.Reflection;

namespace SmartQuant
{
	// Token: 0x0200003F RID: 63
	public class GacReference : Reference
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00005CE1 File Offset: 0x00004CE1
		public GacReference(string name, Version version, bool enabled) : base(ReferenceType.GAC, enabled)
		{
			this.assemblyName = new AssemblyName();
			this.assemblyName.Name = name;
			this.assemblyName.Version = version;
			this.valid = GAC.Exists(this.assemblyName);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00005D1F File Offset: 0x00004D1F
		public override string Path
		{
			get
			{
				return GAC.GetPath(this.assemblyName);
			}
		}
	}
}
