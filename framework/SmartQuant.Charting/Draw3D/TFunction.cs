using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace SmartQuant.Charting.Draw3D
{
	// Token: 0x02000013 RID: 19
	public abstract class TFunction
	{
		// Token: 0x060000AD RID: 173 RVA: 0x000037F8 File Offset: 0x000027F8
		public TFunction()
		{
			this.Surface.Diffuse = 0.59 * new TColor(0.5, 0.7, 1.0);
		}

		// Token: 0x060000AE RID: 174
		public abstract double f(double x, double y);

		// Token: 0x060000AF RID: 175 RVA: 0x00003874 File Offset: 0x00002874
		public virtual TColor color0(double x, double y)
		{
			return this.Surface.Diffuse;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003884 File Offset: 0x00002884
		public unsafe void Paint(Pad Pad)
		{
			TView tview = TView.View(Pad);
			this.Left = tview.Left;
			this.Top = tview.Top;
			this.W = tview.H;
			this.H = tview.H;
			this.o = tview.o - new TVec3((double)this.Left, (double)this.Top, 0.0);
			this.Lx = tview.Lx;
			this.Ly = tview.Ly;
			this.Lz = tview.Lz;
			this.Light = tview.Light;
			if (this.Look == EChartLook.SurfaceOnly)
			{
				this.BitmapWriteOnly = false;
			}
			Bitmap bitmap = new Bitmap(this.W, this.H, PixelFormat.Format32bppRgb);
			this.BackgroundIntoBitmapIfNeeded(Pad, bitmap);
			Rectangle rect = new Rectangle(0, 0, this.W, this.H);
			BitmapData bitmapData = bitmap.LockBits(rect, this.BitmapWriteOnly ? ImageLockMode.WriteOnly : ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
			int* b = (int*)bitmapData.Scan0.ToPointer();
			this.PaintBuffer(b);
			bitmap.UnlockBits(bitmapData);
			Color transparentColor = Color.FromArgb(255, 0, 0, 0);
			bitmap.MakeTransparent(transparentColor);
			Pad.Graphics.DrawImage(bitmap, this.Left, this.Top);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000039D4 File Offset: 0x000029D4
		private TColor color(double x, double y, double dx, double dy, TColor Diffuse)
		{
			TVec3 a = new TVec3(dx, 0.0, this.f(x + dx, y) - this.f(x, y));
			TVec3 b = new TVec3(0.0, dy, this.f(x, y + dy) - this.f(x, y));
			TVec3 n = a ^ b;
			return this.Light.Result(new TVec3(x, y, this.f(x, y)), n, Diffuse);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003A54 File Offset: 0x00002A54
		private void BackgroundIntoBitmapIfNeeded(Pad pad, Bitmap bm)
		{
			if (this.Look == EChartLook.SurfaceOnly)
			{
				Graphics g = Graphics.FromImage(bm);
				TView.View(pad).PaintAxes(g, pad, 0, 0, this.H);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003A88 File Offset: 0x00002A88
		private unsafe void PaintBuffer(int* b)
		{
			int[,] array = new int[this.W, this.H];
			if (!this.BitmapWriteOnly)
			{
				int* ptr = b;
				for (int i = 0; i < this.H; i++)
				{
					for (int j = 0; j < this.W; j++)
					{
						array[j, i] = *(ptr++);
					}
				}
			}
			double normInf = this.Lx.NormInf;
			double normInf2 = this.Ly.NormInf;
			TVec3 tvec = this.o - 0.5 * this.Lx - 0.5 * this.Ly;
			TVec3 tvec2 = this.Lx / normInf;
			TVec3 tvec3 = this.Ly / normInf2;
			double num = (this.MaxX - this.MinX) / normInf;
			double num2 = (this.MaxY - this.MinY) / normInf2;
			double num3 = num;
			double num4 = num2;
			if ((double)(2 * this.nx) >= normInf && (double)(2 * this.ny) >= normInf2)
			{
				num3 = (this.MaxX - this.MinX) / (double)this.nx;
				num4 = (this.MaxY - this.MinY) / (double)this.ny;
			}
			double num5 = this.MinX + 0.01 * num3;
			double num6 = this.MinY + 0.01 * num4;
			TVec3 b2 = this.Lx;
			TVec3 b3 = this.Ly;
			if (this.Lx.z > 0.0)
			{
				num5 = this.MaxX - 0.99 * num3;
				num = -num;
				num3 = -num3;
				tvec += this.Lx;
				b2 = -this.Lx;
				tvec2 = -tvec2;
			}
			if (this.Ly.z > 0.0)
			{
				num6 = this.MaxY - 0.99 * num4;
				num2 = -num2;
				num4 = -num4;
				tvec += this.Ly;
				b3 = -this.Ly;
				tvec3 = -tvec3;
			}
			int num7 = (int)normInf;
			int num8 = (int)normInf2;
			int num9 = (int)this.Lz.NormInf;
			bool[] array2 = new bool[num7 + 2];
			bool[] array3 = new bool[num8 + 2];
			bool[] array4 = new bool[num9 + 2];
			if (this.Grid)
			{
				TAxisCalc taxisCalc = new TAxisCalc(tvec, tvec + b2, num5, num5 + normInf * num, 10);
				TAxisCalc taxisCalc2 = new TAxisCalc(tvec, tvec + b3, num6, num6 + normInf2 * num2, 10);
				double num10 = num5;
				int k = 0;
				while (k <= num7)
				{
					if (taxisCalc.TickPassed(num10))
					{
						array2[k] = true;
					}
					k++;
					num10 += num;
				}
				double num11 = num6;
				int l = 0;
				while (l <= num8)
				{
					if (taxisCalc2.TickPassed(num11))
					{
						array3[l] = true;
					}
					l++;
					num11 += num2;
				}
			}
			if (this.LevelLines)
			{
				for (int m = 0; m < num9; m++)
				{
					array4[m] = ((m & 4) != 0);
				}
			}
			switch (this.Look)
			{
			case EChartLook.FromZeroToSurface:
			{
				double num10 = num5;
				int k = 0;
				while (k <= num7)
				{
					bool flag = array2[k];
					TVec3 a = tvec;
					double num11 = num6;
					int l = 0;
					while (l <= num8)
					{
						double num12 = this.f(num10, num11);
						if (num12 > 0.0)
						{
							int num13 = (int)a.y;
							int num14 = (int)(a.y - num12);
							if (num14 < 0)
							{
								num14 = 0;
							}
							TColor tcolor = this.color0(num10, num11);
							if (this.Grid && (flag || array3[l]))
							{
								tcolor = this.Surface.GridDiffuse;
							}
							tcolor = this.color(num10, num11, num3, num4, tcolor);
							tcolor.Clip();
							int num15 = tcolor.Get888();
							int num16 = (int)a.x;
							if (this.LevelLines)
							{
								TColor tcolor2 = 0.81 * tcolor;
								tcolor2.Clip();
								int num17 = tcolor2.Get888();
								for (int n = num13; n >= num14; n--)
								{
									array[num16, n] = (array4[num13 - n] ? num17 : num15);
								}
							}
							else
							{
								for (int num18 = num13; num18 >= num14; num18--)
								{
									array[num16, num18] = num15;
								}
							}
						}
						l++;
						num11 += num2;
						a += tvec3;
					}
					k++;
					num10 += num;
					tvec += tvec2;
				}
				break;
			}
			case EChartLook.SurfaceOnly:
			{
				double num10 = num5;
				int k = 0;
				while (k < num7)
				{
					bool flag2 = array2[k];
					TVec3 a = tvec;
					double num11 = num6;
					int l = 0;
					while (l < num8)
					{
						double num19 = this.f(num10, num11);
						double num20 = this.f(num10 + num, num11);
						double num21 = this.f(num10, num11 + num2);
						double num22 = this.f(num10 + num, num11 + num2);
						double num23 = num19;
						double num24 = num19;
						if (num20 < num23)
						{
							num23 = num20;
						}
						if (num21 < num23)
						{
							num23 = num21;
						}
						if (num22 < num23)
						{
							num23 = num22;
						}
						if (num20 > num24)
						{
							num24 = num20;
						}
						if (num21 > num24)
						{
							num24 = num21;
						}
						if (num22 > num24)
						{
							num24 = num22;
						}
						int num25 = (int)a.y;
						int num26 = (int)(a.y - num23 + 1.0);
						int num27 = (int)(a.y - num24);
						if (num26 < this.H && num26 >= 0 && num27 < this.H && num27 >= 0)
						{
							TColor tcolor3 = this.color0(num10, num11);
							if (this.Grid && (flag2 || array3[l]))
							{
								tcolor3 = this.Surface.GridDiffuse;
							}
							tcolor3 = this.color(num10, num11, num3, num4, tcolor3);
							tcolor3.Clip();
							int num28 = tcolor3.Get888();
							int num29 = (int)a.x;
							if (this.LevelLines)
							{
								TColor tcolor4 = 0.81 * tcolor3;
								tcolor4.Clip();
								int num30 = tcolor4.Get888();
								for (int num31 = num26; num31 >= num27; num31--)
								{
									if (num23 > 0.0 || array[num29, num31] >= 0 || array[num29, num31] == -1)
									{
										array[num29, num31] = (((num25 - num31 & 4) != 0) ? num30 : num28);
									}
								}
							}
							else
							{
								for (int num32 = num26; num32 >= num27; num32--)
								{
									if (num23 > 0.0 || array[num29, num32] >= 0 || array[num29, num32] == -1)
									{
										array[num29, num32] = num28;
									}
								}
							}
						}
						l++;
						num11 += num2;
						a += tvec3;
					}
					k++;
					num10 += num;
					tvec += tvec2;
				}
				break;
			}
			}
			for (int num33 = 0; num33 < this.H; num33++)
			{
				for (int num34 = 0; num34 < this.W; num34++)
				{
					*(b++) = array[num34, num33];
				}
			}
		}

		// Token: 0x0400003A RID: 58
		protected double MinX;

		// Token: 0x0400003B RID: 59
		protected double MaxX = 1.0;

		// Token: 0x0400003C RID: 60
		protected double MinY;

		// Token: 0x0400003D RID: 61
		protected double MaxY = 1.0;

		// Token: 0x0400003E RID: 62
		protected int nx;

		// Token: 0x0400003F RID: 63
		protected int ny;

		// Token: 0x04000040 RID: 64
		public EChartLook Look;

		// Token: 0x04000041 RID: 65
		public TSurface Surface = new TSurface();

		// Token: 0x04000042 RID: 66
		public bool Grid;

		// Token: 0x04000043 RID: 67
		public bool LevelLines;

		// Token: 0x04000044 RID: 68
		private TLight Light;

		// Token: 0x04000045 RID: 69
		private int Top;

		// Token: 0x04000046 RID: 70
		private int Left;

		// Token: 0x04000047 RID: 71
		private int W;

		// Token: 0x04000048 RID: 72
		private int H;

		// Token: 0x04000049 RID: 73
		private TVec3 o;

		// Token: 0x0400004A RID: 74
		private TVec3 Lx;

		// Token: 0x0400004B RID: 75
		private TVec3 Ly;

		// Token: 0x0400004C RID: 76
		private TVec3 Lz;

		// Token: 0x0400004D RID: 77
		private bool BitmapWriteOnly = true;
	}
}
