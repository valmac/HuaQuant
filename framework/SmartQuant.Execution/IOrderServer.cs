using System;
using SmartQuant.FIX;

namespace SmartQuant.Execution
{
	// Token: 0x0200000A RID: 10
	public interface IOrderServer
	{
		// Token: 0x06000087 RID: 135
		void Open();

		// Token: 0x06000088 RID: 136
		void Open(string database);

		// Token: 0x06000089 RID: 137
		OrderList Load();

		// Token: 0x0600008A RID: 138
		void AddOrder(IOrder order);

		// Token: 0x0600008B RID: 139
		void AddReport(IOrder order, FIXExecutionReport report);

		// Token: 0x0600008C RID: 140
		void Remove(IOrder order);

		// Token: 0x0600008D RID: 141
		void Close();
	}
}
