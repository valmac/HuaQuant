using System;
using System.Collections;
using SmartQuant.FIX;

namespace SmartQuant.Execution
{
	// Token: 0x02000007 RID: 7
	public class OrderList : FIXGroupList
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00002B4D File Offset: 0x00001B4D
		public OrderList()
		{
			this.list = new Hashtable();
		}

		// Token: 0x17000031 RID: 49
		public new IOrder this[int index]
		{
			get
			{
				return base[index] as IOrder;
			}
		}

		// Token: 0x17000032 RID: 50
		public IOrder this[string orderId]
		{
			get
			{
				return this.list[orderId] as IOrder;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002B81 File Offset: 0x00001B81
		public new IOrder GetById(int id)
		{
			return base.GetById(id) as IOrder;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002B8F File Offset: 0x00001B8F
		public void Add(IOrder order)
		{
			this.list.Add(order.ClOrdID, order);
			base.Add(order as FIXGroup);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002BB0 File Offset: 0x00001BB0
		public void Remove(IOrder order)
		{
			this.list.Remove(order.ClOrdID);
			base.Remove(order as FIXGroup);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002BCF File Offset: 0x00001BCF
		public override void Clear()
		{
			this.list.Clear();
			base.Clear();
		}

		// Token: 0x0400000F RID: 15
		private Hashtable list;
	}
}
