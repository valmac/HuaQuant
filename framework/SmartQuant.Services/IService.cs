using System;

namespace SmartQuant.Services
{
	// Token: 0x02000003 RID: 3
	public interface IService
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000001 RID: 1
		// (remove) Token: 0x06000002 RID: 2
		event EventHandler StatusChanged;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000003 RID: 3
		// (remove) Token: 0x06000004 RID: 4
		event ServiceErrorEventHandler Error;

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5
		byte Id { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6
		string Name { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7
		string Description { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8
		ServiceStatus Status { get; }

		// Token: 0x06000009 RID: 9
		void Start();

		// Token: 0x0600000A RID: 10
		void Stop();
	}
}
