using System;

namespace SmartQuant.Providers
{
	// Token: 0x0200000A RID: 10
	public interface IProvider
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000026 RID: 38
		// (remove) Token: 0x06000027 RID: 39
		event EventHandler StatusChanged;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000028 RID: 40
		// (remove) Token: 0x06000029 RID: 41
		event EventHandler Connected;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600002A RID: 42
		// (remove) Token: 0x0600002B RID: 43
		event EventHandler Disconnected;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600002C RID: 44
		// (remove) Token: 0x0600002D RID: 45
		event ProviderErrorEventHandler Error;

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002E RID: 46
		byte Id { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002F RID: 47
		string Name { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000030 RID: 48
		string Title { get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000031 RID: 49
		string URL { get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000032 RID: 50
		bool IsConnected { get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000033 RID: 51
		ProviderStatus Status { get; }

		// Token: 0x06000034 RID: 52
		void Connect();

		// Token: 0x06000035 RID: 53
		void Connect(int timeout);

		// Token: 0x06000036 RID: 54
		void Disconnect();

		// Token: 0x06000037 RID: 55
		void Shutdown();
	}
}
