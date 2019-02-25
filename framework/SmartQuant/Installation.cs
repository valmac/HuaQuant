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
			this.timeChanged = false;
			this.timeVerified = false;
			this.demoExpired = false;
			this.demoVerified = false;
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
					this.version = new Version(this.GetRegistryValue(Registry.LocalMachine, "Version"));
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
					this.fQUANTSYS = new DirectoryInfo(this.GetRegistryValue(Registry.LocalMachine, "QUANTSYS").TrimEnd(new char[]
					{
						'\\'
					}));
				}
				return this.fQUANTSYS;
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
					this.fQUANTDAT = new DirectoryInfo(this.GetRegistryValue(Registry.LocalMachine, "QUANTDAT").TrimEnd(new char[]
					{
						'\\'
					}));
				}
				return this.fQUANTDAT;
			}
			set
			{
				this.SetRegistryValue(Registry.LocalMachine, "QUANTDAT", value.FullName.TrimEnd(new char[]
				{
					'\\'
				}) + "\\");
				this.fQUANTDAT = null;
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

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000023C8 File Offset: 0x000013C8
		internal bool TimeChanged
		{
			get
			{
				if (!this.timeVerified)
				{
					try
					{
						if (!this.ContainsKey(Registry.CurrentUser, TIME_KEY))
						{
							Registry.CurrentUser.CreateSubKey(ROOT_PATH).Close();
							this.SetRegistryValue(Registry.CurrentUser, TIME_KEY, new DateTime(1974, 2, 12).Ticks.ToString());
						}
						DateTime t = new DateTime(long.Parse(this.GetRegistryValue(Registry.CurrentUser, TIME_KEY)));
						if (t > DateTime.Now)
						{
							this.timeChanged = true;
						}
						else
						{
							this.SetRegistryValue(Registry.CurrentUser, TIME_KEY, DateTime.Now.Ticks.ToString());
							this.timeChanged = false;
						}
					}
					catch
					{
						this.timeChanged = true;
					}
					finally
					{
						this.timeVerified = true;
					}
				}
				return this.timeChanged;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000024CC File Offset: 0x000014CC
		internal bool DemoExpired
		{
			get
			{
				if (!this.demoVerified)
				{
					try
					{
						if (!this.ContainsKey(Registry.CurrentUser, DEMO_KEY))
						{
							Registry.CurrentUser.CreateSubKey(ROOT_PATH).Close();
							this.SetRegistryValue(Registry.CurrentUser, DEMO_KEY, DateTime.UtcNow.Ticks.ToString());
						}
						DateTime d = new DateTime(long.Parse(this.GetRegistryValue(Registry.CurrentUser, DEMO_KEY)));
						double totalDays = (DateTime.UtcNow - d).TotalDays;
						int num = 14 - (int)totalDays;
						if (num > 0 && Environment.UserInteractive)
						{
							DemoDialog demoDialog = new DemoDialog();
							demoDialog.SetText(string.Format("You are using a demonstration version of {0}.", this.MainProduct) + Environment.NewLine + Environment.NewLine + string.Format("This demo will expire in {0} days.", num));
							demoDialog.ShowDialog();
							demoDialog.Dispose();
						}
						this.demoExpired = (totalDays > 14.0);
					}
					catch
					{
						this.demoExpired = true;
					}
					finally
					{
						this.demoVerified = true;
					}
				}
				return this.demoExpired;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002608 File Offset: 0x00001608
		internal bool RuntimeEnabled
		{
			get
			{
				AssemblyName name = Assembly.GetEntryAssembly().GetName();
				return new ArrayList(this.allowedApplications).Contains(name.Name);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002638 File Offset: 0x00001638
		private string GetRegistryValue(RegistryKey rootKey, string subKey)
		{
			string result;
			try
			{
				RegistryKey registryKey = rootKey.OpenSubKey(ROOT_PATH);
				string text = registryKey.GetValue(subKey) as string;
				registryKey.Close();
				result = text;
			}
			catch (Exception innerException)
			{
				throw new ApplicationException("Installation::GetRegistryValue", innerException);
			}
			return result;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002688 File Offset: 0x00001688
		private bool ContainsKey(RegistryKey rootKey, string subKey)
		{
			bool result;
			try
			{
				RegistryKey registryKey = rootKey.OpenSubKey(ROOT_PATH);
				bool flag = false;
				if (registryKey != null)
				{
					foreach (string a in registryKey.GetValueNames())
					{
						if (a == subKey)
						{
							flag = true;
							break;
						}
					}
					registryKey.Close();
				}
				result = flag;
			}
			catch (Exception innerException)
			{
				throw new ApplicationException("Installation::ContainsKey", innerException);
			}
			return result;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002700 File Offset: 0x00001700
		private void SetRegistryValue(RegistryKey rootKey, string subKey, string value)
		{
			try
			{
				RegistryKey registryKey = rootKey.OpenSubKey(ROOT_PATH, true);
				registryKey.SetValue(subKey, value);
				registryKey.Close();
			}
			catch (Exception innerException)
			{
				throw new ApplicationException("Installation::SetRegistryValue", innerException);
			}
		}

		// Token: 0x0400000C RID: 12
		private const string ROOT_PATH = "SOFTWARE\\SmartQuant Ltd\\QuantDeveloper .NET";

		// Token: 0x0400000D RID: 13
		private const string MAIN_PRODUCT = "QuantDeveloper";

		// Token: 0x0400000E RID: 14
		private const Edition EDITION = Edition.Enterprise;

		// Token: 0x0400000F RID: 15
		private const string QUANTSYS_KEY = "QUANTSYS";

		// Token: 0x04000010 RID: 16
		private const string QUANTDAT_KEY = "QUANTDAT";

		// Token: 0x04000011 RID: 17
		private const string VERSION_KEY = "Version";

		// Token: 0x04000012 RID: 18
		private const string TIME_KEY = "{CDD416EC-BA43-47f9-BEE8-89125652118F}";

		// Token: 0x04000013 RID: 19
		private const string DEMO_KEY = "{A7834A40-B64B-4efe-B697-DE670034DE0B}";

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

		// Token: 0x04000020 RID: 32
		private const int NUM_OF_DEMO_DAYS = 14;

		// Token: 0x04000021 RID: 33
		private DirectoryInfo fQUANTSYS;

		// Token: 0x04000022 RID: 34
		private DirectoryInfo fQUANTDAT;

		// Token: 0x04000023 RID: 35
		private DirectoryInfo binDir;

		// Token: 0x04000024 RID: 36
		private Version version;

		// Token: 0x04000025 RID: 37
		private bool timeChanged;

		// Token: 0x04000026 RID: 38
		private bool timeVerified;

		// Token: 0x04000027 RID: 39
		private bool demoExpired;

		// Token: 0x04000028 RID: 40
		private bool demoVerified;

		// Token: 0x04000029 RID: 41
		private string[] allowedApplications = new string[]
		{
			"QuantDeveloper",
			"DataCenter",
			"CATS2",
			"Configurator",
			"DatabaseManager",
			"QSBenchmark"
		};
	}
}
