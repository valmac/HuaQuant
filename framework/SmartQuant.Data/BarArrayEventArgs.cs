using System;

namespace SmartQuant.Data
{
	// Token: 0x02000019 RID: 25
	public class BarArrayEventArgs : EventArgs
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000389D File Offset: 0x0000289D
		public BarArrayEventArgs(BarArray bars)
		{
			this.bars = bars;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000038AC File Offset: 0x000028AC
		public BarArray BarArray
		{
			get
			{
				return this.bars;
			}
		}

		// Token: 0x0400003C RID: 60
		private BarArray bars;
	}
}
