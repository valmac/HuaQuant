using System;

namespace SmartQuant.DataCenterLib
{
	// Token: 0x0200000A RID: 10
	public interface IConnector
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000022 RID: 34
		string Name { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000023 RID: 35
		string Description { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000024 RID: 36
		// (set) Token: 0x06000025 RID: 37
		ConnectorStartupType StartupType { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000026 RID: 38
		bool IsStarted { get; }

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000027 RID: 39
		// (remove) Token: 0x06000028 RID: 40
		event EventHandler Started;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000029 RID: 41
		// (remove) Token: 0x0600002A RID: 42
		event EventHandler Stopped;

		// Token: 0x0600002B RID: 43
		void Start();

		// Token: 0x0600002C RID: 44
		void Stop();

		// Token: 0x0600002D RID: 45
		void Restart();
	}
}
