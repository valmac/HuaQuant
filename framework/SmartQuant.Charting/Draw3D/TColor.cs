using System;
using System.Drawing;

namespace SmartQuant.Charting.Draw3D
{
	// Token: 0x02000049 RID: 73
	public struct TColor
	{
		// Token: 0x06000452 RID: 1106 RVA: 0x0000F9E8 File Offset: 0x0000E9E8
		public TColor(double R, double G, double B)
		{
			this.R = R;
			this.G = G;
			this.B = B;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000FA00 File Offset: 0x0000EA00
		public TColor(double Gray)
		{
			this.B = Gray;
			this.G = Gray;
			this.R = Gray;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000FA28 File Offset: 0x0000EA28
		public TColor(Color c)
		{
			this.R = 0.00392156862745098 * (double)c.R;
			this.G = 0.00392156862745098 * (double)c.G;
			this.B = 0.00392156862745098 * (double)c.B;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000FA7D File Offset: 0x0000EA7D
		public static TColor operator +(TColor a, TColor b)
		{
			return new TColor(a.R + b.R, a.G + b.G, a.B + b.B);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000FAB1 File Offset: 0x0000EAB1
		public static TColor operator *(TColor a, TColor b)
		{
			return new TColor(a.R * b.R, a.G * b.G, a.B * b.B);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000FAE5 File Offset: 0x0000EAE5
		public static TColor operator *(double k, TColor c)
		{
			return new TColor(k * c.R, k * c.G, k * c.B);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000FB07 File Offset: 0x0000EB07
		public static TColor operator *(TColor c, double k)
		{
			return k * c;
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0000FB10 File Offset: 0x0000EB10
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x0000FB4A File Offset: 0x0000EB4A
		public Color Color
		{
			get
			{
				return Color.FromArgb((int)(255.0 * this.R), (int)(255.0 * this.G), (int)(255.0 * this.B));
			}
			set
			{
				this = new TColor(value);
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000FB58 File Offset: 0x0000EB58
		public static implicit operator TColor(Color c)
		{
			return new TColor(c);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000FB60 File Offset: 0x0000EB60
		public int Get888()
		{
			return ((int)(255.0 * this.R) << 16) + ((int)(255.0 * this.G) << 8) + (int)(255.0 * this.B);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000FB9C File Offset: 0x0000EB9C
		private void Clip(ref double x)
		{
			if (x < 0.003937007874015748)
			{
				x = 0.003937007874015748;
			}
			if (x > 1.0)
			{
				x = 1.0;
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000FBCE File Offset: 0x0000EBCE
		public void Clip()
		{
			this.Clip(ref this.R);
			this.Clip(ref this.G);
			this.Clip(ref this.B);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000FBF4 File Offset: 0x0000EBF4
		public static TColor Clip(TColor c)
		{
			TColor result = c;
			result.Clip();
			return result;
		}

		// Token: 0x040001BF RID: 447
		private double R;

		// Token: 0x040001C0 RID: 448
		private double G;

		// Token: 0x040001C1 RID: 449
		private double B;
	}
}
