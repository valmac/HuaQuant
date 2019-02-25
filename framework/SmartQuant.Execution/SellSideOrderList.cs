using System;
using System.Collections;
using System.Collections.Generic;

namespace SmartQuant.Execution
{
	// Token: 0x02000014 RID: 20
	public class SellSideOrderList : ICollection, IEnumerable
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00004921 File Offset: 0x00003921
		internal SellSideOrderList()
		{
			this.orders = new Dictionary<string, SingleOrder>();
			this.list = new List<SingleOrder>();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000493F File Offset: 0x0000393F
		public void CopyTo(Array array, int index)
		{
			this.list.ToArray().CopyTo(array, index);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00004953 File Offset: 0x00003953
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00004960 File Offset: 0x00003960
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00004963 File Offset: 0x00003963
		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004966 File Offset: 0x00003966
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x17000043 RID: 67
		public SingleOrder this[string orderID]
		{
			get
			{
				SingleOrder result;
				if (this.orders.TryGetValue(orderID, out result))
				{
					return result;
				}
				return null;
			}
		}

		// Token: 0x17000044 RID: 68
		public SingleOrder this[int index]
		{
			get
			{
				return this.list[index];
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000049A6 File Offset: 0x000039A6
		internal void Clear()
		{
			this.orders.Clear();
			this.list.Clear();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000049BE File Offset: 0x000039BE
		internal void Add(SingleOrder order)
		{
			this.orders.Add(order.OrderID, order);
			this.list.Add(order);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000049E0 File Offset: 0x000039E0
		internal void RemoveAt(int index)
		{
			string orderID = this.list[index].OrderID;
			this.orders.Remove(orderID);
			this.list.RemoveAt(index);
		}

		// Token: 0x0400002D RID: 45
		private Dictionary<string, SingleOrder> orders;

		// Token: 0x0400002E RID: 46
		private List<SingleOrder> list;
	}
}
