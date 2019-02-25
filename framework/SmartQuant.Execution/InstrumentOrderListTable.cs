using System;
using SmartQuant.FIX;

namespace SmartQuant.Execution
{
	// Token: 0x02000008 RID: 8
	public class InstrumentOrderListTable
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00002BE2 File Offset: 0x00001BE2
		public InstrumentOrderListTable()
		{
			this.ordersAll = new OrderList();
			this.ordersNew = null;
			this.ordersPending = null;
			this.ordersCancelled = null;
			this.ordersRejected = null;
			this.ordersFilled = null;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002C18 File Offset: 0x00001C18
		public OrderList All
		{
			get
			{
				return this.ordersAll;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002C20 File Offset: 0x00001C20
		public OrderList New
		{
			get
			{
				if (this.ordersNew == null)
				{
					this.ordersNew = this.GetOrderList(OrdStatus.New);
				}
				return this.ordersNew;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002C3D File Offset: 0x00001C3D
		public OrderList Pending
		{
			get
			{
				if (this.ordersPending == null)
				{
					this.ordersPending = this.GetOrderList(OrdStatus.PendingNew);
				}
				return this.ordersPending;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002C5B File Offset: 0x00001C5B
		public OrderList Cancelled
		{
			get
			{
				if (this.ordersCancelled == null)
				{
					this.ordersCancelled = this.GetOrderList(OrdStatus.Cancelled);
				}
				return this.ordersCancelled;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002C78 File Offset: 0x00001C78
		public OrderList Rejected
		{
			get
			{
				if (this.ordersRejected == null)
				{
					this.ordersRejected = this.GetOrderList(OrdStatus.Rejected);
				}
				return this.ordersRejected;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002C96 File Offset: 0x00001C96
		public OrderList Filled
		{
			get
			{
				if (this.ordersFilled == null)
				{
					this.ordersFilled = this.GetOrderList(OrdStatus.Filled);
				}
				return this.ordersFilled;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002CB3 File Offset: 0x00001CB3
		public int Count
		{
			get
			{
				return this.ordersAll.Count;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002CC0 File Offset: 0x00001CC0
		public virtual void Clear()
		{
			this.ordersAll.Clear();
			this.ordersNew = null;
			this.ordersPending = null;
			this.ordersCancelled = null;
			this.ordersRejected = null;
			this.ordersFilled = null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002CF0 File Offset: 0x00001CF0
		public virtual void Add(SingleOrder order)
		{
			this.ordersAll.Add(order);
			this.ordersNew = null;
			this.ordersPending = null;
			this.ordersCancelled = null;
			this.ordersRejected = null;
			this.ordersFilled = null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002D21 File Offset: 0x00001D21
		public virtual void Remove(SingleOrder order)
		{
			this.ordersAll.Remove(order);
			this.ordersNew = null;
			this.ordersPending = null;
			this.ordersCancelled = null;
			this.ordersRejected = null;
			this.ordersFilled = null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002D52 File Offset: 0x00001D52
		public virtual void Update(SingleOrder order)
		{
			this.ordersNew = null;
			this.ordersPending = null;
			this.ordersCancelled = null;
			this.ordersRejected = null;
			this.ordersFilled = null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002D78 File Offset: 0x00001D78
		public OrderList GetOrderList(OrdStatus ordStatus)
		{
			OrderList orderList = new OrderList();
			foreach (object obj in this.ordersAll)
			{
				SingleOrder singleOrder = (SingleOrder)obj;
				if (singleOrder.OrdStatus == ordStatus)
				{
					orderList.Add(singleOrder);
				}
			}
			return orderList;
		}

		// Token: 0x04000010 RID: 16
		private OrderList ordersAll;

		// Token: 0x04000011 RID: 17
		private OrderList ordersNew;

		// Token: 0x04000012 RID: 18
		private OrderList ordersPending;

		// Token: 0x04000013 RID: 19
		private OrderList ordersCancelled;

		// Token: 0x04000014 RID: 20
		private OrderList ordersRejected;

		// Token: 0x04000015 RID: 21
		private OrderList ordersFilled;
	}
}
