using System;
using System.Collections.Generic;
using SmartQuant.Data;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x0200002E RID: 46
	public class BarSliceManager
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x00006B5B File Offset: 0x00005B5B
		public BarSliceManager()
		{
			this.Init();
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00006B69 File Offset: 0x00005B69
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00006B71 File Offset: 0x00005B71
		public int InstrumentsCount
		{
			get
			{
				return this.instrumentsCount;
			}
			set
			{
				this.instrumentsCount = value;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00006B7A File Offset: 0x00005B7A
		private void Init()
		{
			this.table = new Dictionary<long, BarSlice>();
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00006B87 File Offset: 0x00005B87
		internal void Reset()
		{
			this.table.Clear();
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00006B94 File Offset: 0x00005B94
		internal void AddBar(Instrument instrument, Bar bar)
		{
			BarSlice barSlice = null;
			if (!this.table.TryGetValue(bar.Size, out barSlice))
			{
				barSlice = new BarSlice(this.instrumentsCount);
				this.table.Add(bar.Size, barSlice);
			}
			barSlice.AddBar(instrument, bar);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00006BE0 File Offset: 0x00005BE0
		internal BarSlice GetSlice(long barSize)
		{
			BarSlice result = null;
			this.table.TryGetValue(barSize, out result);
			return result;
		}

		// Token: 0x04000098 RID: 152
		private int instrumentsCount;

		// Token: 0x04000099 RID: 153
		private Dictionary<long, BarSlice> table;
	}
}
