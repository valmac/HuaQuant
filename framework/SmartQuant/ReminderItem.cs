using System;

namespace SmartQuant
{
	// Token: 0x0200000E RID: 14
	internal class ReminderItem
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00003062 File Offset: 0x00002062
		internal ReminderItem(ReminderEventHandler handler, object data)
		{
			this.handler = handler;
			this.data = data;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003078 File Offset: 0x00002078
		internal ReminderEventHandler Handler
		{
			get
			{
				return this.handler;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003080 File Offset: 0x00002080
		internal object Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x0400003D RID: 61
		private ReminderEventHandler handler;

		// Token: 0x0400003E RID: 62
		private object data;
	}
}
