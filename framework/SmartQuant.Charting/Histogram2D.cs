using System;
using System.Drawing;
using SmartQuant.Charting.Draw3D;

namespace SmartQuant.Charting
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	public class Histogram2D : IDrawable
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00004644 File Offset: 0x00003644
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00004654 File Offset: 0x00003654
		public EChartLook Look
		{
			get
			{
				return this.Draw3DChart.Look;
			}
			set
			{
				TFunction draw3DChartMulticolorSmoothedLinear = this.Draw3DChartMulticolorSmoothedLinear;
				TFunction draw3DChartMulticolor = this.Draw3DChartMulticolor;
				TFunction draw3DChartSmoothedLinear = this.Draw3DChartSmoothedLinear;
				this.Draw3DChart.Look = value;
				draw3DChartSmoothedLinear.Look = value;
				draw3DChartMulticolor.Look = value;
				draw3DChartMulticolorSmoothedLinear.Look = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00004697 File Offset: 0x00003697
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000046A4 File Offset: 0x000036A4
		public TSurface Surface3D
		{
			get
			{
				return this.Draw3DChart.Surface;
			}
			set
			{
				TFunction draw3DChartSmoothedLinear = this.Draw3DChartSmoothedLinear;
				this.Draw3DChart.Surface = value;
				draw3DChartSmoothedLinear.Surface = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000046CB File Offset: 0x000036CB
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000046D8 File Offset: 0x000036D8
		public bool Grid3D
		{
			get
			{
				return this.Draw3DChart.Grid;
			}
			set
			{
				TFunction draw3DChartMulticolorSmoothedLinear = this.Draw3DChartMulticolorSmoothedLinear;
				TFunction draw3DChartMulticolor = this.Draw3DChartMulticolor;
				TFunction draw3DChartSmoothedLinear = this.Draw3DChartSmoothedLinear;
				this.Draw3DChart.Grid = value;
				draw3DChartSmoothedLinear.Grid = value;
				draw3DChartMulticolor.Grid = value;
				draw3DChartMulticolorSmoothedLinear.Grid = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000471B File Offset: 0x0000371B
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00004728 File Offset: 0x00003728
		public bool LevelLines3D
		{
			get
			{
				return this.Draw3DChart.LevelLines;
			}
			set
			{
				TFunction draw3DChartMulticolorSmoothedLinear = this.Draw3DChartMulticolorSmoothedLinear;
				TFunction draw3DChartMulticolor = this.Draw3DChartMulticolor;
				TFunction draw3DChartSmoothedLinear = this.Draw3DChartSmoothedLinear;
				this.Draw3DChart.LevelLines = value;
				draw3DChartSmoothedLinear.LevelLines = value;
				draw3DChartMulticolor.LevelLines = value;
				draw3DChartMulticolorSmoothedLinear.LevelLines = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000476B File Offset: 0x0000376B
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00004773 File Offset: 0x00003773
		public string Name
		{
			get
			{
				return this.fName;
			}
			set
			{
				this.fName = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000477C File Offset: 0x0000377C
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00004784 File Offset: 0x00003784
		public string Title
		{
			get
			{
				return this.fTitle;
			}
			set
			{
				this.fTitle = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000478D File Offset: 0x0000378D
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00004795 File Offset: 0x00003795
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

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000479E File Offset: 0x0000379E
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000047A6 File Offset: 0x000037A6
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

		// Token: 0x060000F1 RID: 241 RVA: 0x000047B0 File Offset: 0x000037B0
		private void Init(int NBinsX, double XMin, double XMax, int NBinsY, double YMin, double YMax)
		{
			this.fNBinsX = NBinsX;
			this.fNBinsY = NBinsY;
			this.fBins = new double[this.fNBinsX, this.fNBinsY];
			for (int i = 0; i < this.fNBinsX; i++)
			{
				for (int j = 0; j < this.fNBinsY; j++)
				{
					this.fBins[i, j] = 0.0;
				}
			}
			this.fBinSizeX = Math.Abs(XMax - XMin) / (double)NBinsX;
			this.fBinSizeY = Math.Abs(YMax - YMin) / (double)NBinsY;
			if (XMin < XMax)
			{
				this.fXMin = XMin;
				this.fXMax = XMax;
			}
			else
			{
				this.fXMin = XMax;
				this.fXMax = XMin;
			}
			if (YMin < YMax)
			{
				this.fYMin = YMin;
				this.fYMax = YMax;
			}
			else
			{
				this.fYMin = YMax;
				this.fYMax = YMin;
			}
			this.Kx = (double)this.fNBinsX / (this.fXMax - this.fXMin);
			this.Ky = (double)this.fNBinsY / (this.fYMax - this.fYMin);
			this.fBinMin = double.MaxValue;
			this.fBinMax = double.MinValue;
			this.SetPalette(EPalette.Rainbow);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000048E8 File Offset: 0x000038E8
		public Histogram2D(string Name, string Title, int NBinsX, double XMin, double XMax, int NBinsY, double YMin, double YMax)
		{
			this.fName = Name;
			this.fTitle = Title;
			this.Init(NBinsX, XMin, XMax, NBinsY, YMin, YMax);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00004948 File Offset: 0x00003948
		public Histogram2D(string Name, int NBinsX, double XMin, double XMax, int NBinsY, double YMin, double YMax)
		{
			this.fName = Name;
			this.Init(NBinsX, XMin, XMax, NBinsY, YMin, YMax);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000049A0 File Offset: 0x000039A0
		public Histogram2D(int NBinsX, double XMin, double XMax, int NBinsY, double YMin, double YMax)
		{
			this.Init(NBinsX, XMin, XMax, NBinsY, YMin, YMax);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000049EE File Offset: 0x000039EE
		private int Index(double a, double Min, double K)
		{
			return (int)(K * (a - Min) + 1E-09);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004A00 File Offset: 0x00003A00
		private int IndexX(double X)
		{
			return this.Index(X, this.fXMin, this.Kx);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004A15 File Offset: 0x00003A15
		private int IndexY(double Y)
		{
			return this.Index(Y, this.fYMin, this.Ky);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00004A2C File Offset: 0x00003A2C
		public void Add(double X, double Y)
		{
			if (X < this.fXMin || X >= this.fXMax || Y < this.fYMin || Y >= this.fYMax)
			{
				return;
			}
			int num = this.IndexX(X);
			int num2 = this.IndexY(Y);
			this.fBins[num, num2] += 1.0;
			if (this.fBins[num, num2] > this.fBinMax)
			{
				this.fBinMax = this.fBins[num, num2];
			}
			if (this.fBins[num, num2] < this.fBinMin)
			{
				this.fBinMin = this.fBins[num, num2];
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004AE0 File Offset: 0x00003AE0
		public void Set(double X, double Y, double Value)
		{
			if (X < this.fXMin || X >= this.fXMax || Y < this.fYMin || Y >= this.fYMax)
			{
				return;
			}
			int num = this.IndexX(X);
			int num2 = this.IndexY(Y);
			this.fBins[num, num2] = Value;
			if (this.fBins[num, num2] > this.fBinMax)
			{
				this.fBinMax = this.fBins[num, num2];
			}
			if (this.fBins[num, num2] < this.fBinMin)
			{
				this.fBinMin = this.fBins[num, num2];
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00004B80 File Offset: 0x00003B80
		public double Get(double X, double Y)
		{
			if (X < this.fXMin || X >= this.fXMax || Y < this.fYMin || Y >= this.fYMax)
			{
				return 0.0;
			}
			int num = this.IndexX(X);
			int num2 = this.IndexY(Y);
			return this.fBins[num, num2];
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004BD8 File Offset: 0x00003BD8
		public double GetBinSizeX()
		{
			return this.fBinSizeX;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00004BE0 File Offset: 0x00003BE0
		public double GetBinSizeY()
		{
			return this.fBinSizeY;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004BE8 File Offset: 0x00003BE8
		public double GetBinMinX(int Index)
		{
			return this.fXMin + this.fBinSizeX * (double)Index;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004BFA File Offset: 0x00003BFA
		public double GetBinMinY(int Index)
		{
			return this.fYMin + this.fBinSizeY * (double)Index;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004C0C File Offset: 0x00003C0C
		public double GetBinMaxX(int Index)
		{
			return this.fXMin + this.fBinSizeX * (double)(Index + 1);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004C20 File Offset: 0x00003C20
		public double GetBinMaxY(int Index)
		{
			return this.fYMin + this.fBinSizeY * (double)(Index + 1);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004C34 File Offset: 0x00003C34
		public double GetBinCentreX(int Index)
		{
			return this.fXMin + this.fBinSizeX * ((double)Index + 0.5);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004C50 File Offset: 0x00003C50
		public double GetBinCentreY(int Index)
		{
			return this.fYMin + this.fBinSizeY * ((double)Index + 0.5);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004C6C File Offset: 0x00003C6C
		public double GetSum()
		{
			double num = 0.0;
			for (int i = 0; i < this.fNBinsX; i++)
			{
				for (int j = 0; j < this.fNBinsY; j++)
				{
					num += this.fBins[i, j];
				}
			}
			return num;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004CB8 File Offset: 0x00003CB8
		public double GetSumSqr()
		{
			double num = 0.0;
			for (int i = 0; i < this.fNBinsX; i++)
			{
				for (int j = 0; j < this.fNBinsY; j++)
				{
					num += this.fBins[i, j] * this.fBins[i, j];
				}
			}
			return num;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004D10 File Offset: 0x00003D10
		public double GetMin()
		{
			return this.fBinMin;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004D18 File Offset: 0x00003D18
		public double GetMax()
		{
			return this.fBinMax;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00004D20 File Offset: 0x00003D20
		public double dX
		{
			get
			{
				return (this.fXMax - this.fXMin) / (double)this.fNBinsX;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00004D37 File Offset: 0x00003D37
		public double dY
		{
			get
			{
				return (this.fYMax - this.fYMin) / (double)this.fNBinsY;
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00004D4E File Offset: 0x00003D4E
		public void ShowMaxZ(double MaxZ)
		{
			this.fShowMaxZ = MaxZ;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004D57 File Offset: 0x00003D57
		public void ShowUnnormalizedZ()
		{
			this.ShowMaxZ(this.GetMax());
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004D65 File Offset: 0x00003D65
		public bool IsNormalized()
		{
			return this.fShowMaxZ != this.GetMax();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004D78 File Offset: 0x00003D78
		public void ShowNormalizedByMax()
		{
			this.ShowMaxZ(1.0);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004D89 File Offset: 0x00003D89
		public void ShowNormalizedBySum()
		{
			this.ShowMaxZ(this.GetMax() / this.GetSum());
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004D9E File Offset: 0x00003D9E
		public void ShowDensityUnnormalized()
		{
			this.ShowMaxZ(this.GetMax() / (this.dX * this.dY));
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004DBA File Offset: 0x00003DBA
		public bool IsDensityNormalized()
		{
			return this.fShowMaxZ != this.GetMax() / (this.dX * this.dY);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004DDB File Offset: 0x00003DDB
		public void ShowDensityNormalizedByMax()
		{
			this.ShowMaxZ(1.0);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004DEC File Offset: 0x00003DEC
		public void ShowDensityNormalizedBySum()
		{
			this.ShowMaxZ(this.GetMax() / (this.GetSum() * this.dX * this.dY));
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004E10 File Offset: 0x00003E10
		public void Print()
		{
			for (int i = 0; i < this.fNBinsX; i++)
			{
				for (int j = 0; j < this.fNBinsY; j++)
				{
					if (this.fBins[i, j] != 0.0)
					{
						Console.WriteLine(string.Concat(new object[]
						{
							i,
							":",
							j,
							" - [",
							this.GetBinCentreX(i),
							" ",
							this.GetBinCentreY(j),
							"] : ",
							this.fBins[i, j].ToString("F2")
						}));
					}
				}
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004EE0 File Offset: 0x00003EE0
		public virtual void Draw()
		{
			this.Draw("");
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004EF0 File Offset: 0x00003EF0
		public virtual void Draw(string Option)
		{
			if (Chart.Pad == null)
			{
				new Canvas("Canvas", "Canvas");
			}
			if (Chart.Pad.View3D == null)
			{
				Chart.Pad.View3D = new TView();
			}
			Chart.Pad.Add(this);
			if (Option.ToLower().IndexOf("s") < 0)
			{
				if (Chart.Pad.For3D)
				{
					TText ttext = new TText(this.fName, this.fXMin, this.fYMax);
					ttext.Draw();
				}
				else
				{
					Chart.Pad.Title.Text = this.fName;
				}
				Chart.Pad.SetRange(this.fXMin, this.fXMax, this.fYMin, this.fYMax);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00004FB0 File Offset: 0x00003FB0
		public Color[] CreatePalette(Color LowColor, Color HighColor, int NColors)
		{
			Color[] array = new Color[NColors];
			double num = (double)(HighColor.R - LowColor.R) / (double)NColors;
			double num2 = (double)(HighColor.G - LowColor.G) / (double)NColors;
			double num3 = (double)(HighColor.B - LowColor.B) / (double)NColors;
			double num4 = (double)LowColor.R;
			double num5 = (double)LowColor.G;
			double num6 = (double)LowColor.B;
			array[0] = LowColor;
			for (int i = 1; i < NColors; i++)
			{
				num4 += num;
				num5 += num2;
				num6 += num3;
				array[i] = Color.FromArgb((int)num4, (int)num5, (int)num6);
			}
			return array;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005069 File Offset: 0x00004069
		public void SetPalette(Color LowColor, Color HighColor, int NColors)
		{
			this.fNColors = NColors;
			this.fPalette = this.CreatePalette(LowColor, HighColor, NColors);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005081 File Offset: 0x00004081
		public void SetPalette(Color[] Colors, int NColors)
		{
			this.fNColors = NColors;
			this.fPalette = Colors;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005094 File Offset: 0x00004094
		public void SetPalette(EPalette Palette)
		{
			switch (Palette)
			{
			case EPalette.Gray:
				this.SetPalette(Color.White, Color.Black, 255);
				return;
			case EPalette.Rainbow:
			{
				Color[] array = new Color[160];
				int num = 0;
				Color[] array2 = this.CreatePalette(Color.Purple, Color.Blue, 32);
				foreach (Color color in array2)
				{
					array[num++] = color;
				}
				array2 = this.CreatePalette(Color.Blue, Color.FromArgb(0, 128, 255), 16);
				foreach (Color color2 in array2)
				{
					array[num++] = color2;
				}
				Color color3 = Color.FromArgb(0, 200, 0);
				array2 = this.CreatePalette(Color.FromArgb(0, 128, 255), color3, 16);
				foreach (Color color4 in array2)
				{
					array[num++] = color4;
				}
				array2 = this.CreatePalette(color3, Color.Yellow, 32);
				foreach (Color color5 in array2)
				{
					array[num++] = color5;
				}
				array2 = this.CreatePalette(Color.Yellow, Color.Orange, 32);
				foreach (Color color6 in array2)
				{
					array[num++] = color6;
				}
				array2 = this.CreatePalette(Color.Orange, Color.Red, 32);
				foreach (Color color7 in array2)
				{
					array[num++] = color7;
				}
				this.SetPalette(array, 160);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000052C4 File Offset: 0x000042C4
		private void PrepareBrushes()
		{
			this.fBrushes = new Brush[this.fNColors];
			for (int i = 0; i < this.fNColors; i++)
			{
				this.fBrushes[i] = new SolidBrush(this.fPalette[i]);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00005314 File Offset: 0x00004314
		public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
		{
			if (Pad.For3D)
			{
				int millisecond = DateTime.Now.Millisecond;
				int num = Pad.ClientX(XMin);
				int num2 = (Pad.ClientY(YMax) + Pad.Y1) / 2;
				int num3 = Math.Abs(Pad.ClientX(XMax) - Pad.ClientX(XMin));
				int num4 = Math.Abs(Pad.ClientY(YMax) - Pad.ClientY(YMin));
				int num5 = (num3 < num4) ? num3 : num4;
				int left = num + num3 / 2 - num5 / 2;
				int top = num2;
				if (this.fShowMaxZ == 0.0)
				{
					this.ShowUnnormalizedZ();
				}
				Pad.AxisZ3D.Min = 0.0;
				Pad.AxisZ3D.Max = this.fShowMaxZ;
				TView tview = TView.View(Pad);
				tview.PaintAxes(Pad, left, top, num5);
				if (!this.Multicolor3D)
				{
					switch (this.Smoothing)
					{
					case ESmoothing.Disabled:
						this.Draw3DChart.Set(Pad, this.fBins, this.fNBinsX, this.fNBinsY, this.fXMin, this.fXMax, this.fYMin, this.fYMax, this.fBinMax);
						this.Draw3DChart.Paint(Pad);
						break;
					case ESmoothing.Linear:
						this.Draw3DChartSmoothedLinear.Set(Pad, this.fBins, this.fNBinsX, this.fNBinsY, this.fXMin, this.fXMax, this.fYMin, this.fYMax, this.fBinMax);
						this.Draw3DChartSmoothedLinear.Paint(Pad);
						break;
					}
				}
				else
				{
					switch (this.Smoothing)
					{
					case ESmoothing.Disabled:
						this.Draw3DChartMulticolor.Set(Pad, this.fBins, this.fNBinsX, this.fNBinsY, this.fXMin, this.fXMax, this.fYMin, this.fYMax, this.fBinMin, this.fBinMax, this.fPalette);
						this.Draw3DChartMulticolor.Paint(Pad);
						break;
					case ESmoothing.Linear:
						this.Draw3DChartMulticolorSmoothedLinear.Set(Pad, this.fBins, this.fNBinsX, this.fNBinsY, this.fXMin, this.fXMax, this.fYMin, this.fYMax, this.fBinMin, this.fBinMax, this.fPalette);
						this.Draw3DChartMulticolorSmoothedLinear.Paint(Pad);
						break;
					}
				}
				int num6 = DateTime.Now.Millisecond;
				num6 -= millisecond;
				return;
			}
			int millisecond2 = DateTime.Now.Millisecond;
			int num7 = DateTime.Now.Millisecond;
			int num8 = Pad.ClientX(this.fXMin);
			int num9 = Pad.ClientY(this.fYMax);
			int num10 = Pad.ClientX(this.fXMax) - num8;
			int num11 = Pad.ClientY(this.fYMin) - num9;
			int num12 = this.fPalette.Length;
			int[] array = new int[num12];
			for (int i = 0; i < num12; i++)
			{
				array[i] = this.fPalette[i].ToArgb();
			}
			TPaintingBitmap tpaintingBitmap = new TPaintingBitmap(num10, num11);
			tpaintingBitmap.Fill(Pad.ForeColor);
			double num13 = (double)num10 / (double)this.fNBinsX;
			double num14 = (double)num11 / (double)this.fNBinsY;
			int w = (int)(num13 + 1.0);
			int num15 = (int)(num14 + 1.0);
			double num16 = (double)(this.fNColors - 1) / (this.fBinMax - this.fBinMin);
			int j = 0;
			double num17 = 0.0;
			while (j < this.fNBinsX)
			{
				int k = 0;
				double num18 = 0.0;
				while (k < this.fNBinsY)
				{
					if (this.fBins[j, k] != 0.0)
					{
						int num19 = (int)(num16 * (this.fBins[j, k] - this.fBinMin));
						tpaintingBitmap.FillRectangle(array[num19], (int)num17, num11 - (int)num18 - num15, w, num15);
					}
					k++;
					num18 += num14;
				}
				j++;
				num17 += num13;
			}
			Bitmap image = tpaintingBitmap.Get();
			Pad.Graphics.DrawImage(image, num8, num9);
			int num20 = DateTime.Now.Millisecond;
			num7 -= millisecond2;
			num20 -= millisecond2;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000576D File Offset: 0x0000476D
		public TDistance Distance(double X, double Y)
		{
			return null;
		}

		// Token: 0x0400005A RID: 90
		public const double epsilon = 1E-09;

		// Token: 0x0400005B RID: 91
		protected string fName;

		// Token: 0x0400005C RID: 92
		protected string fTitle;

		// Token: 0x0400005D RID: 93
		protected int fNBinsX;

		// Token: 0x0400005E RID: 94
		protected int fNBinsY;

		// Token: 0x0400005F RID: 95
		protected double fXMin;

		// Token: 0x04000060 RID: 96
		protected double fXMax;

		// Token: 0x04000061 RID: 97
		protected double fYMin;

		// Token: 0x04000062 RID: 98
		protected double fYMax;

		// Token: 0x04000063 RID: 99
		protected double[,] fBins;

		// Token: 0x04000064 RID: 100
		protected double fBinSizeX;

		// Token: 0x04000065 RID: 101
		protected double fBinSizeY;

		// Token: 0x04000066 RID: 102
		protected double fBinMin;

		// Token: 0x04000067 RID: 103
		protected double fBinMax;

		// Token: 0x04000068 RID: 104
		protected double Kx;

		// Token: 0x04000069 RID: 105
		protected double Ky;

		// Token: 0x0400006A RID: 106
		protected double fShowMaxZ;

		// Token: 0x0400006B RID: 107
		protected int fNColors;

		// Token: 0x0400006C RID: 108
		protected Color[] fPalette;

		// Token: 0x0400006D RID: 109
		private Histogram2D.TDraw3DChart Draw3DChart = new Histogram2D.TDraw3DChart();

		// Token: 0x0400006E RID: 110
		private Histogram2D.TDraw3DChartSmoothedLinear Draw3DChartSmoothedLinear = new Histogram2D.TDraw3DChartSmoothedLinear();

		// Token: 0x0400006F RID: 111
		private Histogram2D.TDraw3DChartMulticolor Draw3DChartMulticolor = new Histogram2D.TDraw3DChartMulticolor();

		// Token: 0x04000070 RID: 112
		private Histogram2D.TDraw3DChartMulticolorSmoothedLinear Draw3DChartMulticolorSmoothedLinear = new Histogram2D.TDraw3DChartMulticolorSmoothedLinear();

		// Token: 0x04000071 RID: 113
		public ESmoothing Smoothing;

		// Token: 0x04000072 RID: 114
		[NonSerialized]
		private Brush[] fBrushes;

		// Token: 0x04000073 RID: 115
		private bool fToolTipEnabled;

		// Token: 0x04000074 RID: 116
		private string fToolTipFormat;

		// Token: 0x04000075 RID: 117
		public bool Multicolor3D;

		// Token: 0x0200001A RID: 26
		private class TDraw3DChart : TFunction
		{
			// Token: 0x0600011C RID: 284 RVA: 0x00005770 File Offset: 0x00004770
			public virtual void Set(Pad Pad, double[,] h, int nx, int ny, double MinX, double MaxX, double MinY, double MaxY, double MaxZ)
			{
				this.h = h;
				this.nx = nx;
				this.ny = ny;
				this.MinX = MinX;
				this.MaxX = MaxX;
				this.MinY = MinY;
				this.MaxY = MaxY;
				this.M = MaxZ;
				this.Kx = (double)nx / (MaxX - MinX);
				this.Ky = (double)ny / (MaxY - MinY);
				this.Kz = TView.View(Pad).Lz.NormInf / this.M;
			}

			// Token: 0x0600011D RID: 285 RVA: 0x000057F8 File Offset: 0x000047F8
			public override double f(double x, double y)
			{
				if (x < this.MinX)
				{
					return 0.0;
				}
				if (x >= this.MaxX)
				{
					return 0.0;
				}
				if (y < this.MinY)
				{
					return 0.0;
				}
				if (y >= this.MaxY)
				{
					return 0.0;
				}
				return this.Kz * this.h[(int)(this.Kx * (x - this.MinX)), (int)(this.Ky * (y - this.MinY))];
			}

			// Token: 0x04000076 RID: 118
			protected double[,] h;

			// Token: 0x04000077 RID: 119
			protected double M;

			// Token: 0x04000078 RID: 120
			protected double Kx;

			// Token: 0x04000079 RID: 121
			protected double Ky;

			// Token: 0x0400007A RID: 122
			protected double Kz;
		}

		// Token: 0x0200001B RID: 27
		private class TDraw3DChartSmoothedLinear : Histogram2D.TDraw3DChart
		{
			// Token: 0x0600011F RID: 287 RVA: 0x0000588C File Offset: 0x0000488C
			public override double f(double x, double y)
			{
				double num = this.Kx * (x - this.MinX) - 0.5;
				double num2 = this.Ky * (y - this.MinY) - 0.5;
				int num3 = (int)num;
				int num4 = (int)num2;
				int num5 = num3 + 1;
				int num6 = num4 + 1;
				if (num5 >= this.h.GetLength(0))
				{
					num5 = num3;
				}
				if (num6 >= this.h.GetLength(1))
				{
					num6 = num4;
				}
				double num7 = num - (double)num3;
				double num8 = num2 - (double)num4;
				if (num7 < 0.0)
				{
					num7 = 0.0;
				}
				if (num8 < 0.0)
				{
					num8 = 0.0;
				}
				double num9 = this.h[num3, num4];
				double num10 = this.h[num5, num4];
				double num11 = this.h[num3, num6];
				double num12 = this.h[num5, num6];
				double num13 = num9 + (num10 - num9) * num7 + (num11 - num9) * num8 + (num9 - num10 - num11 + num12) * num7 * num8;
				return this.Kz * num13;
			}
		}

		// Token: 0x0200001C RID: 28
		private class TDraw3DChartMulticolor : Histogram2D.TDraw3DChart
		{
			// Token: 0x06000121 RID: 289 RVA: 0x000059B8 File Offset: 0x000049B8
			public override TColor color0(double x, double y)
			{
				int num = (int)(this.K * (this.f(x, y) - this.MinZ));
				return this.c0[num];
			}

			// Token: 0x06000122 RID: 290 RVA: 0x000059F0 File Offset: 0x000049F0
			public void Set(Pad Pad, double[,] h, int nx, int ny, double MinX, double MaxX, double MinY, double MaxY, double MinZ, double MaxZ, Color[] palette)
			{
				base.Set(Pad, h, nx, ny, MinX, MaxX, MinY, MaxY, MaxZ);
				this.c0 = new TColor[palette.Length];
				for (int i = 0; i < this.c0.Length; i++)
				{
					this.c0[i] = palette[i];
				}
				this.K = (double)(this.c0.Length - 1) / (MaxZ - MinZ) / this.Kz;
				this.MinZ = MinZ * this.Kz;
			}

			// Token: 0x0400007B RID: 123
			private TColor[] c0;

			// Token: 0x0400007C RID: 124
			private double MinZ;

			// Token: 0x0400007D RID: 125
			private double K;
		}

		// Token: 0x0200001D RID: 29
		private class TDraw3DChartMulticolorSmoothedLinear : Histogram2D.TDraw3DChartMulticolor
		{
			// Token: 0x06000124 RID: 292 RVA: 0x00005A8C File Offset: 0x00004A8C
			public override double f(double x, double y)
			{
				double num = this.Kx * (x - this.MinX) - 0.5;
				double num2 = this.Ky * (y - this.MinY) - 0.5;
				int num3 = (int)num;
				int num4 = (int)num2;
				int num5 = num3 + 1;
				int num6 = num4 + 1;
				if (num5 >= this.h.GetLength(0))
				{
					num5 = num3;
				}
				if (num6 >= this.h.GetLength(1))
				{
					num6 = num4;
				}
				double num7 = num - (double)num3;
				double num8 = num2 - (double)num4;
				if (num7 < 0.0)
				{
					num7 = 0.0;
				}
				if (num8 < 0.0)
				{
					num8 = 0.0;
				}
				double num9 = this.h[num3, num4];
				double num10 = this.h[num5, num4];
				double num11 = this.h[num3, num6];
				double num12 = this.h[num5, num6];
				double num13 = num9 + (num10 - num9) * num7 + (num11 - num9) * num8 + (num9 - num10 - num11 + num12) * num7 * num8;
				return this.Kz * num13;
			}
		}
	}
}
