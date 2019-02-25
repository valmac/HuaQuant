using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000C8 RID: 200
	public class FIXHeartbeatEventArgs : EventArgs
	{
		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x00029C1E File Offset: 0x00028C1E
		// (set) Token: 0x0600272A RID: 10026 RVA: 0x00029C26 File Offset: 0x00028C26
		public FIXHeartbeat Heartbeat
		{
			get
			{
				return this.fHeartbeat;
			}
			set
			{
				this.fHeartbeat = value;
			}
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00029C2F File Offset: 0x00028C2F
		public FIXHeartbeatEventArgs(FIXHeartbeat Heartbeat)
		{
			this.fHeartbeat = Heartbeat;
		}

		// Token: 0x040003A6 RID: 934
		private FIXHeartbeat fHeartbeat;
	}
}
