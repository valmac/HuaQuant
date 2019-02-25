using System;

namespace SmartQuant
{
	// Token: 0x02000010 RID: 16
	public class Plugin
	{
		// Token: 0x06000053 RID: 83 RVA: 0x000033D4 File Offset: 0x000023D4
		public Plugin(string assemblyName, string typeName, bool enabled)
		{
			this.assemblyName = assemblyName;
			this.typeName = typeName;
			this.enabled = enabled;
			this.configuration = null;
			this.loaded = false;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000033FF File Offset: 0x000023FF
		public string AssemblyName
		{
			get
			{
				return this.assemblyName;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003407 File Offset: 0x00002407
		public string TypeName
		{
			get
			{
				return this.typeName;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000340F File Offset: 0x0000240F
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00003417 File Offset: 0x00002417
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				if (this.enabled != value)
				{
					this.enabled = value;
					if (this.configuration != null)
					{
						this.configuration.EmitPluginEnabledChanged(this);
					}
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000343D File Offset: 0x0000243D
		public bool Loaded
		{
			get
			{
				return this.loaded;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003448 File Offset: 0x00002448
		internal object CreateInstance()
		{
			object result = Activator.CreateInstance(this.assemblyName, this.typeName);
			this.loaded = true;
			return result;
		}

		// Token: 0x1700002D RID: 45
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000346F File Offset: 0x0000246F
		internal Configuration Configuration
		{
			set
			{
				this.configuration = value;
			}
		}

		// Token: 0x04000040 RID: 64
		private string assemblyName;

		// Token: 0x04000041 RID: 65
		private string typeName;

		// Token: 0x04000042 RID: 66
		private bool enabled;

		// Token: 0x04000043 RID: 67
		private Configuration configuration;

		// Token: 0x04000044 RID: 68
		private bool loaded;
	}
}
