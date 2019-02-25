using System;

namespace SmartQuant.Simulation
{
	// Token: 0x0200002B RID: 43
	public class IntervalEventArgs : EventArgs
	{
		// Token: 0x0600018A RID: 394 RVA: 0x000085B2 File Offset: 0x000075B2
		public IntervalEventArgs(Interval interval)
		{
			this.interval = interval;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000085C1 File Offset: 0x000075C1
		public Interval Interval
		{
			get
			{
				return this.interval;
			}
		}

		// Token: 0x040000CF RID: 207
		private Interval interval;
	}
}
