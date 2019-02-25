using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace SmartQuant
{
	// Token: 0x0200003A RID: 58
	public class Framework
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00005113 File Offset: 0x00004113
		private Framework()
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000511C File Offset: 0x0000411C
		static Framework()
		{
			string text = Framework.Installation.QUANTSYS.FullName;
			text = text.Replace('\\', ':');
			text = text.Replace('/', ':');
			Framework.mutex = new Mutex(true, text);
			Framework.isAlreadyRunning = !Framework.mutex.WaitOne(0, false);
			if (Framework.isAlreadyRunning)
			{
				return;
			}
			switch (Framework.Installation.Edition)
			{
			case Edition.Demo:
				if (Framework.Installation.TimeChanged || Framework.Installation.DemoExpired)
				{
					if (Trace.IsLevelEnabled(TraceLevel.Info))
					{
						Trace.WriteLine("Your demo version has expired.");
					}
					if (Environment.UserInteractive)
					{
						MessageBox.Show("Your demo version of QuantDeveloper has expired. Please contact us at sales@smartquant.com to discuss QuantDeveloper licensing issues.", "Expiration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					Environment.Exit(-1);
					return;
				}
				break;
			case Edition.Research:
			case Edition.Professional:
				if (!Framework.Installation.RuntimeEnabled)
				{
					if (Trace.IsLevelEnabled(TraceLevel.Info))
					{
						Trace.WriteLine("You cannot use runtime libraries.");
					}
					if (Environment.UserInteractive)
					{
						MessageBox.Show("You cannot use runtime libraries.", "Runtime", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					Environment.Exit(-1);
				}
				break;
			case Edition.Enterprise:
				break;
			default:
				return;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000522A File Offset: 0x0000422A
		public static bool IsAlreadyRunning
		{
			get
			{
				return Framework.isAlreadyRunning;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00005234 File Offset: 0x00004234
		public static Configuration Configuration
		{
			get
			{
				if (Framework.IsAlreadyRunning)
				{
					throw new Exception("SmartQuant .NET Framework cannot be initialized because it is already used by another process!");
				}
				if (Framework.configuration == null)
				{
					Framework.configuration = new Configuration();
					Trace.SetTraceLevel(Framework.configuration.TraceLevel);
					Trace.AutoFlush = true;
					Trace.Listeners.Add(new TextWriterTraceListener(Framework.Installation.LogDir.FullName + "\\log.txt"));
				}
				return Framework.configuration;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000052A7 File Offset: 0x000042A7
		public static Installation Installation
		{
			get
			{
				if (Framework.IsAlreadyRunning)
				{
					throw new Exception("SmartQuant .NET Framework cannot be initialized because it is already used by another process!");
				}
				if (Framework.installation == null)
				{
					Framework.installation = new Installation();
				}
				return Framework.installation;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000052D4 File Offset: 0x000042D4
		public static void Init()
		{
			try
			{
				if (Framework.IsAlreadyRunning)
				{
					throw new Exception("SmartQuant .NET Framework cannot be initialized because it is already used by another process!");
				}
				RuntimeErrorManager.Init();
				if (Trace.IsLevelEnabled(TraceLevel.Info))
				{
					Trace.WriteLine("Initializing framework...");
				}
				Framework.Installation.Init();
				Framework.Configuration.Init();
			}
			catch (Exception ex)
			{
				if (Trace.IsLevelEnabled(TraceLevel.Error))
				{
					Trace.WriteLine(ex.ToString());
				}
				throw ex;
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005350 File Offset: 0x00004350
		public static void LoadPlugins()
		{
			foreach (object obj in Framework.configuration.Plugins)
			{
				Plugin plugin = (Plugin)obj;
				if (plugin.Enabled)
				{
					Framework.LoadPlugin(plugin);
				}
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000053B4 File Offset: 0x000043B4
		public static void LoadPlugin(Plugin plugin)
		{
			try
			{
				plugin.CreateInstance();
			}
			catch (Exception ex)
			{
				if (Trace.IsLevelEnabled(TraceLevel.Error))
				{
					Trace.WriteLine(ex.ToString());
				}
				if (Environment.UserInteractive)
				{
					MessageBox.Show(string.Concat(new string[]
					{
						"The Framework can not load plugin ",
						plugin.TypeName,
						" (see log file for details).",
						Environment.NewLine,
						Environment.NewLine,
						"Please check that you have all required third party applications and dlls installed and COM components properly registered.",
						Environment.NewLine,
						Environment.NewLine,
						"Please refer to your market data or execution provider technical documentation for more information about proper usage of their API."
					}), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x040000E3 RID: 227
		private const string EXPIRATION_MESSAGE = "Your demo version of QuantDeveloper has expired. Please contact us at sales@smartquant.com to discuss QuantDeveloper licensing issues.";

		// Token: 0x040000E4 RID: 228
		private static Configuration configuration;

		// Token: 0x040000E5 RID: 229
		private static Installation installation;

		// Token: 0x040000E6 RID: 230
		private static Mutex mutex;

		// Token: 0x040000E7 RID: 231
		private static bool isAlreadyRunning;
	}
}
