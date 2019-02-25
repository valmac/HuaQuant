using System;

namespace SmartQuant.Data
{
	// Token: 0x02000002 RID: 2
	public interface IDataObject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1
		// (set) Token: 0x06000002 RID: 2
		DateTime DateTime { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3
		// (set) Token: 0x06000004 RID: 4
		byte ProviderId { get; set; }
	}
}
