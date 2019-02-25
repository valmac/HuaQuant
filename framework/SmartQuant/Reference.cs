using System;
using System.ComponentModel;
using System.Reflection;

namespace SmartQuant
{
	// Token: 0x02000003 RID: 3
	public class Reference
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002078 File Offset: 0x00001078
		protected Reference(ReferenceType referenceType, bool enabled)
		{
			this.referenceType = referenceType;
			this.enabled = enabled;
			this.assemblyName = null;
			this.valid = false;
			this.configuration = null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020A3 File Offset: 0x000010A3
		public AssemblyName AssemblyName
		{
			get
			{
				return this.assemblyName;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020AB File Offset: 0x000010AB
		public ReferenceType ReferenceType
		{
			get
			{
				return this.referenceType;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020B3 File Offset: 0x000010B3
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000020BB File Offset: 0x000010BB
		[Browsable(false)]
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
						this.configuration.EmitReferenceEnabledChanged(this);
					}
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020E1 File Offset: 0x000010E1
		public bool Valid
		{
			get
			{
				return this.valid;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020E9 File Offset: 0x000010E9
		public virtual string Path
		{
			get
			{
				return "";
			}
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020F0 File Offset: 0x000010F0
		internal Configuration Configuration
		{
			set
			{
				this.configuration = value;
			}
		}

		// Token: 0x04000006 RID: 6
		protected AssemblyName assemblyName;

		// Token: 0x04000007 RID: 7
		protected ReferenceType referenceType;

		// Token: 0x04000008 RID: 8
		protected bool enabled;

		// Token: 0x04000009 RID: 9
		protected bool valid;

		// Token: 0x0400000A RID: 10
		private Configuration configuration;
	}
}
