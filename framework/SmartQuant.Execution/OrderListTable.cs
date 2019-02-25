using System;
using System.Collections;
using SmartQuant.FIX;

namespace SmartQuant.Execution
{
	// Token: 0x02000009 RID: 9
	public class OrderListTable : InstrumentOrderListTable
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00002DE4 File Offset: 0x00001DE4
		public OrderListTable()
		{
			this.tables = new Hashtable();
		}

		// Token: 0x1700003A RID: 58
		public InstrumentOrderListTable this[IFIXInstrument instrument]
		{
			get
			{
				InstrumentOrderListTable instrumentOrderListTable = this.tables[instrument] as InstrumentOrderListTable;
				if (instrumentOrderListTable == null)
				{
					instrumentOrderListTable = new InstrumentOrderListTable();
					this.tables.Add(instrument, instrumentOrderListTable);
				}
				return instrumentOrderListTable;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002E2E File Offset: 0x00001E2E
		public override void Clear()
		{
			base.Clear();
			this.tables.Clear();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002E41 File Offset: 0x00001E41
		public override void Add(SingleOrder order)
		{
			base.Add(order);
			this[order.Instrument].Add(order);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002E5C File Offset: 0x00001E5C
		public override void Remove(SingleOrder order)
		{
			base.Remove(order);
			this[order.Instrument].Remove(order);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002E77 File Offset: 0x00001E77
		public override void Update(SingleOrder order)
		{
			base.Update(order);
			this[order.Instrument].Update(order);
		}

		// Token: 0x04000016 RID: 22
		private Hashtable tables;
	}
}
