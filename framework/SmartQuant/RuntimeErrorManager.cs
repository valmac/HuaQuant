using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SmartQuant
{
	// Token: 0x02000017 RID: 23
	public class RuntimeErrorManager
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000A3 RID: 163 RVA: 0x00003EA2 File Offset: 0x00002EA2
		// (remove) Token: 0x060000A4 RID: 164 RVA: 0x00003EB9 File Offset: 0x00002EB9
		public static event RuntimeErrorEventHandler Error;

		// Token: 0x060000A5 RID: 165 RVA: 0x00003ED0 File Offset: 0x00002ED0
		static RuntimeErrorManager()
		{
			RuntimeErrorManager.enabled = false;
			RuntimeErrorManager.Enabled = true;
			RuntimeErrorManager.target = RuntimeErrorOutputTarget.PopupWindow;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00003EEE File Offset: 0x00002EEE
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00003EF8 File Offset: 0x00002EF8
		public static bool Enabled
		{
			get
			{
				return RuntimeErrorManager.enabled;
			}
			set
			{
				if (value)
				{
					if (RuntimeErrorManager.enabled)
					{
						return;
					}
					AppDomain.CurrentDomain.UnhandledException += RuntimeErrorManager.OnUnhandledException;
					RuntimeErrorManager.enabled = true;
					return;
				}
				else
				{
					if (!RuntimeErrorManager.enabled)
					{
						return;
					}
					AppDomain.CurrentDomain.UnhandledException -= RuntimeErrorManager.OnUnhandledException;
					RuntimeErrorManager.enabled = false;
					return;
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00003F51 File Offset: 0x00002F51
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00003F58 File Offset: 0x00002F58
		public static RuntimeErrorOutputTarget Target
		{
			get
			{
				return RuntimeErrorManager.target;
			}
			set
			{
				RuntimeErrorManager.target = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00003F60 File Offset: 0x00002F60
		public static RuntimeErrorCollection Errors
		{
			get
			{
				return RuntimeErrorManager.errors;
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003F84 File Offset: 0x00002F84
		public static void ReportError(RuntimeError error)
		{
			lock (typeof(RuntimeErrorManager))
			{
				RuntimeErrorManager.errors.Add(error);
				if (Trace.IsLevelEnabled(TraceLevel.Error))
				{
					Trace.WriteLine(error.ToString());
				}
				if (Environment.UserInteractive)
				{
					switch (RuntimeErrorManager.target)
					{
					case RuntimeErrorOutputTarget.Console:
						Console.WriteLine(error.ToString());
						break;
					case RuntimeErrorOutputTarget.PopupWindow:
					{
						RuntimeErrorForm form = new RuntimeErrorForm();
						form.SetError(error);
						Control app = Control.FromHandle(Process.GetCurrentProcess().MainWindowHandle);
						if (app != null && app.InvokeRequired)
						{
							MethodInvoker method = delegate()
							{
								form.ShowDialog(app);
							};
							app.Invoke(method);
						}
						else
						{
							form.ShowDialog(app);
						}
						break;
					}
					}
				}
				if (RuntimeErrorManager.Error != null)
				{
					RuntimeErrorManager.Error(new RuntimeErrorEventArgs(error));
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000040A8 File Offset: 0x000030A8
		internal static void Init()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000040AC File Offset: 0x000030AC
		private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			Exception e2 = e.ExceptionObject as Exception;
			RuntimeErrorManager.ReportError(new RuntimeError(RuntimeErrorLevel.Critical, e2));
		}

		// Token: 0x0400006A RID: 106
		internal const bool DEFAULT_ENABLED = true;

		// Token: 0x0400006B RID: 107
		internal const RuntimeErrorOutputTarget DEFAULT_TARGET = RuntimeErrorOutputTarget.PopupWindow;

		// Token: 0x0400006C RID: 108
		private static bool enabled;

		// Token: 0x0400006D RID: 109
		private static RuntimeErrorOutputTarget target;

		// Token: 0x0400006E RID: 110
		private static RuntimeErrorCollection errors = new RuntimeErrorCollection();
	}
}
