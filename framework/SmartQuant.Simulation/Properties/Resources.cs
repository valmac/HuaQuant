using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace SmartQuant.Simulation.Properties
{
	// Token: 0x0200002A RID: 42
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000186 RID: 390 RVA: 0x0000855B File Offset: 0x0000755B
		internal Resources()
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00008564 File Offset: 0x00007564
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("SmartQuant.Simulation.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000085A3 File Offset: 0x000075A3
		// (set) Token: 0x06000189 RID: 393 RVA: 0x000085AA File Offset: 0x000075AA
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x040000CD RID: 205
		private static ResourceManager resourceMan;

		// Token: 0x040000CE RID: 206
		private static CultureInfo resourceCulture;
	}
}
