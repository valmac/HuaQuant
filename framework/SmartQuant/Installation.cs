using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace SmartQuant
{
	// Token: 0x02000006 RID: 6
	public class Installation
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002110 File Offset: 0x00001110
		internal Installation()
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000217D File Offset: 0x0000117D
		[Category("Main")]
		public Version Version
		{
			get
			{
				if (this.version == null)
				{
					this.version = new Version(1,0,100);
				}
				return this.version;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000021AE File Offset: 0x000011AE
		[Browsable(false)]
		public Edition Edition
		{
			get
			{
				return Edition.Enterprise;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000021B1 File Offset: 0x000011B1
		[Browsable(false)]
		public string MainProduct
		{
			get
			{
				return "QuantDeveloper";
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000021B8 File Offset: 0x000011B8
		[Category("Main")]
		public DirectoryInfo QUANTSYS
		{
			get
			{
				if (this.fQUANTSYS == null)
				{
                    string path = System.Environment.CurrentDirectory;
                    this.fQUANTSYS = new DirectoryInfo(path.TrimEnd(new char[]{'\\'}));
                    
                }
				return this.fQUANTSYS;
			}
            set
            {
                this.fQUANTSYS= value;
            }
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002200 File Offset: 0x00001200
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002248 File Offset: 0x00001248
		[Category("Main")]
		[ReadOnly(true)]
		public DirectoryInfo QUANTDAT
		{
			get
			{
				if (this.fQUANTDAT == null)
				{                   
                    this.fQUANTDAT = new DirectoryInfo(this.QUANTSYS.FullName+"\\data");
                    
				}
				return this.fQUANTDAT;
			}
			set
			{
				this.fQUANTDAT = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000228E File Offset: 0x0000128E
		[Category("Other")]
		public DirectoryInfo DataDir
		{
			get
			{
				return this.QUANTDAT;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002296 File Offset: 0x00001296
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000022C1 File Offset: 0x000012C1
		[Category("Other")]
		[ReadOnly(true)]
		public DirectoryInfo BinDir
		{
			get
			{
				if (this.binDir != null)
				{
					return this.binDir;
				}
				return new DirectoryInfo(this.QUANTSYS.FullName + "\\bin");
			}
			set
			{
				this.binDir = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000022CA File Offset: 0x000012CA
		[Category("Other")]
		public DirectoryInfo ObjectDir
		{
			get
			{
				return new DirectoryInfo(this.QUANTSYS.FullName + "\\objects");
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000022E6 File Offset: 0x000012E6
		[Category("Other")]
		public DirectoryInfo IniDir
		{
			get
			{
				return new DirectoryInfo(this.QUANTSYS.FullName + "\\ini");
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002302 File Offset: 0x00001302
		[Category("Other")]
		public DirectoryInfo SolutionDir
		{
			get
			{
				return new DirectoryInfo(this.QUANTSYS.FullName + "\\solutions");
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000231E File Offset: 0x0000131E
		[Category("Other")]
		public DirectoryInfo ComponentDir
		{
			get
			{
				return new DirectoryInfo(this.QUANTSYS.FullName + "\\components");
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000233A File Offset: 0x0000133A
		[Category("Other")]
		public DirectoryInfo TemplateDir
		{
			get
			{
				return new DirectoryInfo(this.QUANTSYS.FullName + "\\templates");
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002356 File Offset: 0x00001356
		[Category("Other")]
		public DirectoryInfo HelpDir
		{
			get
			{
				return new DirectoryInfo(this.QUANTSYS.FullName + "\\help");
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002372 File Offset: 0x00001372
		[Category("Other")]
		public DirectoryInfo LogDir
		{
			get
			{
				return new DirectoryInfo(this.QUANTSYS.FullName + "\\logs");
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000238E File Offset: 0x0000138E
		[Category("Other")]
		public DirectoryInfo FIXDir
		{
			get
			{
				return new DirectoryInfo(this.QUANTSYS.FullName + "\\fix");
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000023AA File Offset: 0x000013AA
		[Category("Other")]
		public DirectoryInfo TempDir
		{
			get
			{
				return new DirectoryInfo(this.QUANTSYS.FullName + "\\temp");
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000023C6 File Offset: 0x000013C6
		internal void Init()
		{
		}

		// Token: 0x0400000D RID: 13
		private const string MAIN_PRODUCT = "QuantDeveloper";

		// Token: 0x0400000E RID: 14
		private const Edition EDITION = Edition.Enterprise;

		// Token: 0x04000014 RID: 20
		private const string SUBDIR_SOLUTION = "solutions";

		// Token: 0x04000015 RID: 21
		private const string SUBDIR_BIN = "bin";

		// Token: 0x04000016 RID: 22
		private const string SUBDIR_OBJECT = "objects";

		// Token: 0x04000017 RID: 23
		private const string SUBDIR_INI = "ini";

		// Token: 0x04000018 RID: 24
		private const string SUBDIR_COMPONENT = "components";

		// Token: 0x04000019 RID: 25
		private const string SUBDIR_TEMPLATE = "templates";

		// Token: 0x0400001A RID: 26
		private const string SUBDIR_HELP = "help";

		// Token: 0x0400001B RID: 27
		private const string SUBDIR_LOG = "logs";

		// Token: 0x0400001C RID: 28
		private const string SUBDIR_FIX = "fix";

		// Token: 0x0400001D RID: 29
		private const string SUBDIR_TEMP = "temp";

		// Token: 0x0400001E RID: 30
		private const string CATEGORY_MAIN = "Main";

		// Token: 0x0400001F RID: 31
		private const string CATEGORY_OTHER = "Other";


		// Token: 0x04000021 RID: 33
		private DirectoryInfo fQUANTSYS;

		// Token: 0x04000022 RID: 34
		private DirectoryInfo fQUANTDAT;

		// Token: 0x04000023 RID: 35
		private DirectoryInfo binDir;

		// Token: 0x04000024 RID: 36
		private Version version;

	}
}
