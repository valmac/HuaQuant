using System;
using System.Collections.Generic;
using SmartQuant.Data;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000079 RID: 121
	public class BarSlice
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00011FF5 File Offset: 0x00010FF5
		public Dictionary<Instrument, Bar> Table
		{
			get
			{
				return this.table;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00011FFD File Offset: 0x00010FFD
		public bool IsComplete
		{
			get
			{
				return this.table.Count == this.instrumentCount;
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00012012 File Offset: 0x00011012
		internal BarSlice(int instrumentCount)
		{
			this.instrumentCount = instrumentCount;
			this.Init();
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00012027 File Offset: 0x00011027
		private void Init()
		{
			this.table = new Dictionary<Instrument, Bar>();
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00012034 File Offset: 0x00011034
		internal void AddBar(Instrument instrument, Bar bar)
		{
			this.table[instrument] = bar;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00012043 File Offset: 0x00011043
		internal void Reset()
		{
			this.table.Clear();
		}

		// Token: 0x04000186 RID: 390
		private int instrumentCount;

		// Token: 0x04000187 RID: 391
		private Dictionary<Instrument, Bar> table;
	}
}
