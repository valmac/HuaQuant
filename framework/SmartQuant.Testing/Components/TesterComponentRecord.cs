using System;
using System.ComponentModel;
using System.IO;

namespace SmartQuant.Testing.Components
{
	// Token: 0x02000053 RID: 83
	public class TesterComponentRecord
	{
		// Token: 0x06000267 RID: 615 RVA: 0x0000E561 File Offset: 0x0000D561
		internal TesterComponentRecord(string name, string description, FileInfo file, Type type)
		{
			this.name = name;
			this.description = description;
			this.file = file;
			this.type = type;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000E586 File Offset: 0x0000D586
		[Description("Component name")]
		[Category("Naming")]
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000E58E File Offset: 0x0000D58E
		[Description("Component description")]
		[Category("Naming")]
		public string Description
		{
			get
			{
				return this.description;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000E596 File Offset: 0x0000D596
		[Browsable(false)]
		public FileInfo File
		{
			get
			{
				return this.file;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000E59E File Offset: 0x0000D59E
		[Browsable(false)]
		public Type Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x040000EE RID: 238
		private const string CATEGORY_NAMING = "Naming";

		// Token: 0x040000EF RID: 239
		private const string CATEGORY_MISC = "Misc";

		// Token: 0x040000F0 RID: 240
		private string name;

		// Token: 0x040000F1 RID: 241
		private string description;

		// Token: 0x040000F2 RID: 242
		private FileInfo file;

		// Token: 0x040000F3 RID: 243
		private Type type;
	}
}
