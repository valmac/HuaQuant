using System;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace SmartQuant.Execution
{
	// Token: 0x02000002 RID: 2
	public interface IOrder
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000001 RID: 1
		// (remove) Token: 0x06000002 RID: 2
		event EventHandler StatusChanged;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000003 RID: 3
		// (remove) Token: 0x06000004 RID: 4
		event ExecutionReportEventHandler ExecutionReport;

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5
		string OrderID { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6
		// (set) Token: 0x06000007 RID: 7
		string ClOrdID { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8
		// (set) Token: 0x06000009 RID: 9
		int Id { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10
		// (set) Token: 0x0600000B RID: 11
		Instrument Instrument { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12
		// (set) Token: 0x0600000D RID: 13
		IExecutionProvider Provider { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14
		// (set) Token: 0x0600000F RID: 15
		Portfolio Portfolio { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16
		// (set) Token: 0x06000011 RID: 17
		bool Persistent { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000012 RID: 18
		ExecutionReportList Reports { get; }
	}
}
