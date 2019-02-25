using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SmartQuant.Charting
{
	// Token: 0x0200004A RID: 74
	[Serializable]
	public class TLine : IDrawable
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0000FC0B File Offset: 0x0000EC0B
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x0000FC13 File Offset: 0x0000EC13
		public bool ToolTipEnabled
		{
			get
			{
				return this.fToolTipEnabled;
			}
			set
			{
				this.fToolTipEnabled = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0000FC1C File Offset: 0x0000EC1C
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x0000FC24 File Offset: 0x0000EC24
		public string ToolTipFormat
		{
			get
			{
				return this.fToolTipFormat;
			}
			set
			{
				this.fToolTipFormat = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0000FC2D File Offset: 0x0000EC2D
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x0000FC35 File Offset: 0x0000EC35
		public double X1
		{
			get
			{
				return this.fX1;
			}
			set
			{
				this.fX1 = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0000FC3E File Offset: 0x0000EC3E
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x0000FC46 File Offset: 0x0000EC46
		public double Y1
		{
			get
			{
				return this.fY1;
			}
			set
			{
				this.fY1 = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0000FC4F File Offset: 0x0000EC4F
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0000FC57 File Offset: 0x0000EC57
		public double X2
		{
			get
			{
				return this.fX2;
			}
			set
			{
				this.fX2 = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0000FC60 File Offset: 0x0000EC60
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0000FC68 File Offset: 0x0000EC68
		public double Y2
		{
			get
			{
				return this.fY2;
			}
			set
			{
				this.fY2 = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0000FC71 File Offset: 0x0000EC71
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x0000FC79 File Offset: 0x0000EC79
		public DashStyle DashStyle
		{
			get
			{
				return this.fDashStyle;
			}
			set
			{
				this.fDashStyle = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000FC82 File Offset: 0x0000EC82
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x0000FC8A File Offset: 0x0000EC8A
		public Color Color
		{
			get
			{
				return this.fColor;
			}
			set
			{
				this.fColor = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000FC93 File Offset: 0x0000EC93
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0000FC9B File Offset: 0x0000EC9B
		public int Width
		{
			get
			{
				return this.fWidth;
			}
			set
			{
				this.fWidth = value;
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000FCA4 File Offset: 0x0000ECA4
		public TLine(double X1, double Y1, double X2, double Y2)
		{
			this.fX1 = X1;
			this.fY1 = Y1;
			this.fX2 = X2;
			this.fY2 = Y2;
			this.fColor = Color.Black;
			this.fDashStyle = DashStyle.Solid;
			this.fWidth = 1;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000FCE4 File Offset: 0x0000ECE4
		public TLine(DateTime X1, double Y1, DateTime X2, double Y2)
		{
			this.fX1 = (double)X1.Ticks;
			this.fY1 = Y1;
			this.fX2 = (double)X2.Ticks;
			this.fY2 = Y2;
			this.fColor = Color.Black;
			this.fDashStyle = DashStyle.Solid;
			this.fWidth = 1;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0000FD3B File Offset: 0x0000ED3B
		public virtual void Draw()
		{
			if (Chart.Pad == null)
			{
				new Canvas("Canvas", "Canvas");
			}
			Chart.Pad.Add(this);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000FD60 File Offset: 0x0000ED60
		public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
		{
			Pad.DrawLine(new Pen(this.fColor)
			{
				Width = (float)this.fWidth,
				DashStyle = this.fDashStyle
			}, this.fX1, this.fY1, this.fX2, this.fY2);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000FDB1 File Offset: 0x0000EDB1
		public TDistance Distance(double X, double Y)
		{
			return null;
		}

		// Token: 0x040001C2 RID: 450
		private double fX1;

		// Token: 0x040001C3 RID: 451
		private double fY1;

		// Token: 0x040001C4 RID: 452
		private double fX2;

		// Token: 0x040001C5 RID: 453
		private double fY2;

		// Token: 0x040001C6 RID: 454
		private Color fColor;

		// Token: 0x040001C7 RID: 455
		private int fWidth;

		// Token: 0x040001C8 RID: 456
		private DashStyle fDashStyle;

		// Token: 0x040001C9 RID: 457
		private bool fToolTipEnabled;

		// Token: 0x040001CA RID: 458
		private string fToolTipFormat;
	}
}
