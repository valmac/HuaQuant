using System;
using SmartQuant.Data;

namespace SmartQuant.Simulation
{
	// Token: 0x0200002F RID: 47
	internal class BarObject : IDataObject
	{
		// Token: 0x0600019E RID: 414 RVA: 0x00008D6C File Offset: 0x00007D6C
		internal BarObject(Bar bar)
		{
			this.Bar = (bar.Clone() as Bar);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00008D85 File Offset: 0x00007D85
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00008D8C File Offset: 0x00007D8C
		public byte ProviderId
		{
			get
			{
				throw new InvalidOperationException();
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00008D93 File Offset: 0x00007D93
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00008D9B File Offset: 0x00007D9B
		public DateTime DateTime
		{
			get
			{
				return this.datetime;
			}
			set
			{
				this.datetime = value;
			}
		}

		// Token: 0x040000D8 RID: 216
		internal Bar Bar;

		// Token: 0x040000D9 RID: 217
		private DateTime datetime;
	}
}
