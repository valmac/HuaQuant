using System;

namespace SmartQuant.Charting
{
	// Token: 0x0200003C RID: 60
	public class ZoomEventArgs : EventArgs
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000B676 File Offset: 0x0000A676
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x0000B67E File Offset: 0x0000A67E
		public double XMin
		{
			get
			{
				return this.fXMin;
			}
			set
			{
				this.fXMin = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000B687 File Offset: 0x0000A687
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0000B68F File Offset: 0x0000A68F
		public double XMax
		{
			get
			{
				return this.fXMax;
			}
			set
			{
				this.fXMax = value;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000B698 File Offset: 0x0000A698
		public ZoomEventArgs(double XMin, double XMax, double YMin, double YMax, bool ZoomUnzoom)
		{
			this.fXMin = XMin;
			this.fXMax = XMax;
			this.fYMin = YMin;
			this.fYMax = YMax;
			this.fZoomUnzoom = ZoomUnzoom;
		}

		// Token: 0x0400012D RID: 301
		public double fXMin;

		// Token: 0x0400012E RID: 302
		public double fXMax;

		// Token: 0x0400012F RID: 303
		public double fYMin;

		// Token: 0x04000130 RID: 304
		public double fYMax;

		// Token: 0x04000131 RID: 305
		public bool fZoomUnzoom;
	}
}
