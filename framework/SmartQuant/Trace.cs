using System;
using System.Diagnostics;

namespace SmartQuant
{
	// Token: 0x02000016 RID: 22
	public class Trace
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00003DCF File Offset: 0x00002DCF
		static Trace()
		{
			Trace.traceSwitch.Level = System.Diagnostics.TraceLevel.Error;
			Trace.Listeners.Clear();
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003DFA File Offset: 0x00002DFA
		public static TraceListenerCollection Listeners
		{
			get
			{
				return System.Diagnostics.Trace.Listeners;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003E04 File Offset: 0x00002E04
		public static bool IsLevelEnabled(System.Diagnostics.TraceLevel level)
		{
			bool result = false;
			switch (level)
			{
			case System.Diagnostics.TraceLevel.Error:
				result = Trace.traceSwitch.TraceError;
				break;
			case System.Diagnostics.TraceLevel.Warning:
				result = Trace.traceSwitch.TraceWarning;
				break;
			case System.Diagnostics.TraceLevel.Info:
				result = Trace.traceSwitch.TraceInfo;
				break;
			case System.Diagnostics.TraceLevel.Verbose:
				result = Trace.traceSwitch.TraceVerbose;
				break;
			}
			return result;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003E62 File Offset: 0x00002E62
		public static void WriteLine(string message)
		{
            System.Diagnostics.Trace.WriteLine(string.Format("{0} {1}", Clock.Now, message));
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003E7E File Offset: 0x00002E7E
		internal static void SetTraceLevel(System.Diagnostics.TraceLevel level)
		{
			Trace.traceSwitch.Level = level;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003E8B File Offset: 0x00002E8B
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00003E92 File Offset: 0x00002E92
		internal static bool AutoFlush
		{
			get
			{
				return System.Diagnostics.Trace.AutoFlush;
			}
			set
			{
                System.Diagnostics.Trace.AutoFlush = value;
			}
		}

		// Token: 0x04000068 RID: 104
		private const string SWITCH_NAME = "Framework";

		// Token: 0x04000069 RID: 105
		private static TraceSwitch traceSwitch = new TraceSwitch("Framework", "");
	}
}
