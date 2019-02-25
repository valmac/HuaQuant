using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SmartQuant.Charting.Draw3D
{
	// Token: 0x0200004B RID: 75
	public class TView
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0000FDB4 File Offset: 0x0000EDB4
		public int Left
		{
			get
			{
				return this.fLeft;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0000FDBC File Offset: 0x0000EDBC
		public int Top
		{
			get
			{
				return this.fTop;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0000FDC4 File Offset: 0x0000EDC4
		public int H
		{
			get
			{
				return this.fH;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0000FDCC File Offset: 0x0000EDCC
		public TVec3 o
		{
			get
			{
				return this.fo;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0000FDD4 File Offset: 0x0000EDD4
		public TVec3 Lx
		{
			get
			{
				return this.fLx;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0000FDDC File Offset: 0x0000EDDC
		public TVec3 Ly
		{
			get
			{
				return this.fLy;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0000FDE4 File Offset: 0x0000EDE4
		public TVec3 Lz
		{
			get
			{
				return this.fLz;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0000FDEC File Offset: 0x0000EDEC
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x0000FDF4 File Offset: 0x0000EDF4
		public double ScaleZ
		{
			get
			{
				return this.fScaleZ;
			}
			set
			{
				if (value < 0.0)
				{
					this.fScaleZ = 1.0;
					return;
				}
				this.fScaleZ = value;
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000FE19 File Offset: 0x0000EE19
		public TView()
		{
			this.SetProjectionSpecial(-2.0, 0.52359877559829882);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000FE53 File Offset: 0x0000EE53
		public static TView View(Pad Pad)
		{
			if (Pad.View3D == null)
			{
				Pad.View3D = new TView();
			}
			return (TView)Pad.View3D;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000FE74 File Offset: 0x0000EE74
		public void SetProjectionOrthogonal(double AngleXY, double ViewAngle)
		{
			this.m = new TRotZ(AngleXY);
			TMat3x3 b = new TRotX(ViewAngle);
			this.m = b * this.m;
			this.ms = TView.ToScreenCoords * this.m;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000FEBC File Offset: 0x0000EEBC
		public void SetProjectionSpecial(double AngleXY, double ViewAngle)
		{
			this.m = new TRotZ(AngleXY);
			TMat3x3 b = new TSpecialProjection(ViewAngle);
			this.m = b * this.m;
			this.ms = TView.ToScreenCoords * this.m;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000FF04 File Offset: 0x0000EF04
		public void CalculateAxes(Pad Pad, int Left, int Top, int H)
		{
			this.fLeft = Left;
			this.fTop = Top;
			this.fH = H;
			this.fo = new TVec3((double)(Left + H / 2), (double)(Top + 3 * H / 4), 0.0);
			if (this.ScaleZ < 1.0)
			{
				this.fo.y = this.fo.y - (1.0 - this.ScaleZ) * 0.25 * (double)H;
			}
			double num = 0.7 * (double)H;
			double z = 0.5 * this.ScaleZ * (double)H;
			this.fLx = new TVec3(num, 0.0, 0.0);
			this.fLy = new TVec3(0.0, num, 0.0);
			this.fLz = new TVec3(0.0, 0.0, z);
			this.fLx = this.ms * this.Lx;
			this.fLy = this.ms * this.Ly;
			this.fLz = this.ms * this.Lz;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00010050 File Offset: 0x0000F050
		private static void SetAxesPropertiesFor3D(Pad Pad)
		{
			if (Pad.Grid3D)
			{
				foreach (Axis axis in Pad.Axes3D)
				{
					axis.GridEnabled = true;
				}
				return;
			}
			foreach (Axis axis2 in Pad.Axes3D)
			{
				axis2.GridEnabled = false;
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x000100B0 File Offset: 0x0000F0B0
		public void PaintAxisGridAndTicks(Graphics g, Axis a, bool Marks, TVec3 o, TVec3 o_, TVec3 L)
		{
			a.MinorGridEnabled = false;
			a.MinorTicksEnabled = false;
			double normInf = L.NormInf;
			int num = (int)(normInf / 10.0);
			if (num < 3)
			{
				num = 3;
			}
			if (num > 10)
			{
				num = 10;
			}
			TAxisCalc taxisCalc = new TAxisCalc(o, o + L, a.Min, a.Max, num);
			TVec3 tvec = o_ - o;
			TVec3 tvec2 = TVec3.O;
			TVec3 tvec3 = -0.04 * tvec;
			if (o_.y > o.y)
			{
				tvec2 = tvec;
				tvec3 = -tvec3;
			}
			TVec3 b = tvec2 + 1.04 * tvec3;
			if (a.GridEnabled)
			{
				Pen pen = new Pen(a.GridColor, a.GridWidth);
				for (int i = 0; i < taxisCalc.nTicks; i++)
				{
					g.DrawLine(pen, taxisCalc.TickPos(i), taxisCalc.TickPos(i) + tvec);
				}
			}
			if (a.Position == EAxisPosition.Right && tvec3.x <= 0.0)
			{
				Marks = false;
			}
			if (Marks)
			{
				int num2 = (a.Position == EAxisPosition.Bottom) ? 0 : 1;
				int num3 = (a.Position == EAxisPosition.Bottom) ? (taxisCalc.nTicks - 1) : taxisCalc.nTicks;
				float num4 = 0f;
				if (a.MajorTicksEnabled)
				{
					Pen pen2 = new Pen(a.GridColor, a.GridWidth);
					for (int j = num2; j < num3; j++)
					{
						g.DrawLine(pen2, taxisCalc.TickPos(j) + tvec2, taxisCalc.TickPos(j) + tvec2 + tvec3);
					}
				}
				if (a.LabelEnabled)
				{
					Font labelFont = a.LabelFont;
					float height = labelFont.GetHeight(g);
					SolidBrush brush = new SolidBrush(a.LabelColor);
					StringFormat stringFormat = new StringFormat();
					float num5;
					if (a.Position == EAxisPosition.Bottom)
					{
						stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
						num5 = (float)Math.Abs(taxisCalc.TickPos(1).x - taxisCalc.TickPos(0).x);
					}
					else
					{
						b.y -= 0.5 * (double)a.LabelFont.GetHeight();
						num5 = (float)Math.Abs(taxisCalc.TickPos(1).y - taxisCalc.TickPos(0).y);
					}
					if (tvec3.x < 0.0)
					{
						b.x -= (double)a.LabelFont.GetHeight();
					}
					if (num5 > 0f)
					{
						int num6 = (int)(height / num5 + 1f);
						if (num2 + num6 < num3)
						{
							for (int k = num2; k < num3; k += num6)
							{
								if (k + num6 >= num3)
								{
									k = num3 - 1;
								}
								TVec3 v = taxisCalc.TickPos(k) + b;
								string text = taxisCalc.TickVal(k).ToString();
								g.DrawString(text, labelFont, brush, v, stringFormat);
								SizeF sizeF = g.MeasureString(text, labelFont);
								if (sizeF.Width > num4)
								{
									num4 = sizeF.Width;
								}
							}
						}
						else if (num3 > 0)
						{
							int i2 = num3 - 1;
							TVec3 v2 = taxisCalc.TickPos(i2) + b;
							string text2 = taxisCalc.TickVal(i2).ToString();
							g.DrawString(text2, labelFont, brush, v2, stringFormat);
							num4 = g.MeasureString(text2, labelFont).Width;
						}
					}
				}
				if (a.TitleEnabled)
				{
					SizeF sizeF2 = g.MeasureString(a.Title, a.TitleFont);
					PointF pointF;
					PointF point;
					float angle;
					if (a.Position == EAxisPosition.Bottom)
					{
						if (tvec3.x < 0.0)
						{
							if (taxisCalc.TickPos(0).x <= taxisCalc.TickPos(1).x)
							{
								pointF = taxisCalc.TickPos(0) + b;
							}
							else
							{
								pointF = taxisCalc.TickPos(taxisCalc.nTicks - 1) + b;
							}
							pointF.Y += num4;
							point = pointF;
							angle = (float)(Math.Atan2(Math.Abs(L.y), Math.Abs(L.x)) * 180.0 / 3.1415926535897931);
						}
						else
						{
							if (taxisCalc.TickPos(0).x <= taxisCalc.TickPos(1).x)
							{
								pointF = taxisCalc.TickPos(taxisCalc.nTicks - 1) + b;
							}
							else
							{
								pointF = taxisCalc.TickPos(0) + b;
							}
							pointF.X += a.LabelFont.GetHeight(g);
							pointF.Y += num4;
							point = pointF;
							point.X -= sizeF2.Width;
							angle = (float)(-(float)Math.Atan2(Math.Abs(L.y), Math.Abs(L.x)) * 180.0 / 3.1415926535897931);
						}
					}
					else
					{
						if (taxisCalc.TickPos(0).z <= taxisCalc.TickPos(1).z)
						{
							pointF = taxisCalc.TickPos(taxisCalc.nTicks - 1) + b;
						}
						else
						{
							pointF = taxisCalc.TickPos(0) + b;
						}
						pointF.X += num4;
						point = pointF;
						point.X -= sizeF2.Width;
						angle = -90f;
					}
					Matrix matrix = new Matrix();
					matrix.RotateAt(angle, pointF, MatrixOrder.Append);
					g.Transform = matrix;
					g.DrawString(a.Title, a.LabelFont, new SolidBrush(a.LabelColor), point);
					matrix.Reset();
					g.Transform = matrix;
				}
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000106AC File Offset: 0x0000F6AC
		public void PaintAxes(Graphics g, Pad Pad, int Left, int Top, int H)
		{
			Graphics graphics = Pad.Graphics;
			int x = Pad.X1;
			int x2 = Pad.X2;
			int y = Pad.Y1;
			int y2 = Pad.Y2;
			Pad.Graphics = g;
			Pad.X1 = Left;
			Pad.X2 = Left + H;
			Pad.Y1 = Top;
			Pad.Y2 = Top + H;
			this.PaintAxes(Pad, Left, Top, H);
			Pad.Graphics = graphics;
			Pad.X1 = x;
			Pad.X2 = x2;
			Pad.Y1 = y;
			Pad.Y2 = y2;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00010738 File Offset: 0x0000F738
		public void PaintAxes(Pad Pad, int Left, int Top, int H)
		{
			this.CalculateAxes(Pad, Left, Top, H);
			TVec3[] array = new TVec3[]
			{
				this.o - 0.5 * this.Lx - 0.5 * this.Ly,
				this.o + 0.5 * this.Lx - 0.5 * this.Ly,
				this.o + 0.5 * this.Lx + 0.5 * this.Ly,
				this.o - 0.5 * this.Lx + 0.5 * this.Ly
			};
			double num = -1.0;
			int num2 = -1;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].y > num)
				{
					num = array[i].y;
					num2 = i;
				}
			}
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			switch (num2)
			{
			case 0:
				num3 = 1;
				num4 = 2;
				num5 = 3;
				break;
			case 1:
				num3 = 2;
				num4 = 3;
				num5 = 0;
				break;
			case 2:
				num3 = 3;
				num4 = 0;
				num5 = 1;
				break;
			case 3:
				num3 = 0;
				num4 = 1;
				num5 = 2;
				break;
			}
			Point[] points = TVec3.PointArray(array);
			Point[] points2 = new Point[]
			{
				array[num3],
				array[num4],
				array[num4] + this.Lz,
				array[num3] + this.Lz
			};
			Point[] points3 = new Point[]
			{
				array[num4],
				array[num5],
				array[num5] + this.Lz,
				array[num4] + this.Lz
			};
			Graphics graphics = Pad.Graphics;
			graphics.Clip = new Region(new Rectangle(Pad.X1, Pad.Y1, Pad.Width + 1, Pad.Height + 1));
			Pen pen = new Pen(Color.Black, 1f);
			Brush brush = new SolidBrush(Color.White);
			graphics.FillPolygon(brush, points);
			graphics.FillPolygon(brush, points2);
			graphics.FillPolygon(brush, points3);
			graphics.DrawPolygon(pen, points);
			graphics.DrawPolygon(pen, points2);
			graphics.DrawPolygon(pen, points3);
			TView.SetAxesPropertiesFor3D(Pad);
			Pad.AxisX3D.Position = EAxisPosition.Bottom;
			Pad.AxisY3D.Position = EAxisPosition.Bottom;
			Pad.AxisZ3D.Position = EAxisPosition.Right;
			this.PaintAxisGridAndTicks(graphics, Pad.AxisX3D, true, array[0], array[0] + this.Ly, this.Lx);
			this.PaintAxisGridAndTicks(graphics, Pad.AxisY3D, true, array[0], array[0] + this.Lx, this.Ly);
			this.PaintAxisGridAndTicks(graphics, Pad.AxisX3D, false, array[num4], array[num4] + this.Lz, this.Lx);
			this.PaintAxisGridAndTicks(graphics, Pad.AxisY3D, false, array[num4], array[num4] + this.Lz, this.Ly);
			this.PaintAxisGridAndTicks(graphics, Pad.AxisZ3D, true, array[num4], array[num4] + this.Lx, this.Lz);
			this.PaintAxisGridAndTicks(graphics, Pad.AxisZ3D, true, array[num4], array[num4] + this.Ly, this.Lz);
		}

		// Token: 0x040001CB RID: 459
		public TLight Light = new TLight();

		// Token: 0x040001CC RID: 460
		private TMat3x3 m;

		// Token: 0x040001CD RID: 461
		private TMat3x3 ms;

		// Token: 0x040001CE RID: 462
		private TVec3 fo;

		// Token: 0x040001CF RID: 463
		private TVec3 fLx;

		// Token: 0x040001D0 RID: 464
		private TVec3 fLy;

		// Token: 0x040001D1 RID: 465
		private TVec3 fLz;

		// Token: 0x040001D2 RID: 466
		private int fLeft;

		// Token: 0x040001D3 RID: 467
		private int fTop;

		// Token: 0x040001D4 RID: 468
		private int fH;

		// Token: 0x040001D5 RID: 469
		private double fScaleZ = 1.0;

		// Token: 0x040001D6 RID: 470
		private static TMat3x3 ReverseY = new TMat3x3Diagonal(1.0, -1.0, 1.0);

		// Token: 0x040001D7 RID: 471
		private static TMat3x3 ExchangeYZ = new TExchangeYZ();

		// Token: 0x040001D8 RID: 472
		private static TMat3x3 ToScreenCoords = TView.ReverseY * TView.ExchangeYZ;
	}
}
