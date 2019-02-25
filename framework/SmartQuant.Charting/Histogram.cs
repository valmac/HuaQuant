using System;
using System.Drawing;
using SmartQuant.Quant;

namespace SmartQuant.Charting
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	public class Histogram : IDrawable
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002A2B File Offset: 0x00001A2B
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002A33 File Offset: 0x00001A33
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

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002A3C File Offset: 0x00001A3C
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002A44 File Offset: 0x00001A44
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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002A4D File Offset: 0x00001A4D
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002A55 File Offset: 0x00001A55
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002A5E File Offset: 0x00001A5E
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002A66 File Offset: 0x00001A66
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002A6F File Offset: 0x00001A6F
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002A77 File Offset: 0x00001A77
		public Color LineColor
		{
			get
			{
				return this.fLineColor;
			}
			set
			{
				this.fLineColor = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002A80 File Offset: 0x00001A80
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002A88 File Offset: 0x00001A88
		public Color FillColor
		{
			get
			{
				return this.fFillColor;
			}
			set
			{
				this.fFillColor = value;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002A94 File Offset: 0x00001A94
		private void Init(int NBins, double XMin, double XMax)
		{
			this.fNBins = NBins;
			this.fBins = new double[this.fNBins];
			this.fBinSize = Math.Abs(XMax - XMin) / (double)NBins;
			for (int i = 0; i < this.fNBins; i++)
			{
				this.fBins[i] = 0.0;
			}
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
			this.fYMin = 0.0;
			this.fYMax = 0.0;
			this.fLineColor = Color.Black;
			this.fFillColor = Color.Blue;
			this.fFillBrush = null;
			this.fIntegral = new double[this.fNBins];
			this.fIntegralChanged = false;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002B61 File Offset: 0x00001B61
		public Histogram(string Name, string Title, int NBins, double XMin, double XMax)
		{
			this.fName = Name;
			this.fTitle = Title;
			this.Init(NBins, XMin, XMax);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002B82 File Offset: 0x00001B82
		public Histogram(string Name, int NBins, double XMin, double XMax)
		{
			this.fName = Name;
			this.Init(NBins, XMin, XMax);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002B9B File Offset: 0x00001B9B
		public Histogram(int NBins, double XMin, double XMax)
		{
			this.Init(NBins, XMin, XMax);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002BAC File Offset: 0x00001BAC
		public void Add(double X)
		{
			if (X < this.fXMin || X >= this.fXMax)
			{
				return;
			}
			int num = (int)((double)this.fNBins * (X - this.fXMin) / (this.fXMax - this.fXMin));
			this.fBins[num] += 1.0;
			if (this.fBins[num] > this.fYMax)
			{
				this.fYMax = this.fBins[num];
			}
			this.fIntegralChanged = true;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002C34 File Offset: 0x00001C34
		public void Add(double X, double Value)
		{
			if (X < this.fXMin || X >= this.fXMax)
			{
				return;
			}
			int num = (int)((double)this.fNBins * (X - this.fXMin) / (this.fXMax - this.fXMin));
			this.fBins[num] = Value;
			if (this.fBins[num] > this.fYMax)
			{
				this.fYMax = this.fBins[num];
			}
			this.fIntegralChanged = true;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002CA2 File Offset: 0x00001CA2
		public double GetBinSize()
		{
			return this.fBinSize;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002CAA File Offset: 0x00001CAA
		public double GetBinMin(int Index)
		{
			return this.fXMin + this.fBinSize * (double)Index;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002CBC File Offset: 0x00001CBC
		public double GetBinMax(int Index)
		{
			return this.fXMin + this.fBinSize * (double)(Index + 1);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002CD0 File Offset: 0x00001CD0
		public double GetBinCentre(int Index)
		{
			return this.fXMin + this.fBinSize * ((double)Index + 0.5);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002CEC File Offset: 0x00001CEC
		public double[] GetIntegral()
		{
			if (this.fIntegralChanged)
			{
				for (int i = 0; i < this.fNBins; i++)
				{
					if (i == 0)
					{
						this.fIntegral[i] = this.fBins[i];
					}
					else
					{
						this.fIntegral[i] = this.fIntegral[i - 1] + this.fBins[i];
					}
				}
				if (this.fIntegral[this.fNBins - 1] == 0.0)
				{
					Console.WriteLine("Error in THistogram::GetIntegral, Integral = 0");
					return null;
				}
				for (int j = 0; j < this.fNBins; j++)
				{
					this.fIntegral[j] /= this.fIntegral[this.fNBins - 1];
				}
			}
			return this.fIntegral;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002DAC File Offset: 0x00001DAC
		public double GetRandom()
		{
			double num = SmartQuant.Quant.Random.Rndm();
			int num2 = FinMath.BinarySearch(this.fNBins, this.GetIntegral(), num);
			if (num2 < 0 || num2 >= this.fNBins)
			{
				Console.WriteLine("Error in THistogram::GetRandom(), Bin = " + num2);
				return 0.0;
			}
			return this.GetBinMin(num2) + this.fBinSize * (num - this.fIntegral[num2]) / (this.fIntegral[num2 + 1] - this.fIntegral[num2]);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002E2C File Offset: 0x00001E2C
		public double GetSum()
		{
			double num = 0.0;
			for (int i = 0; i < this.fNBins; i++)
			{
				num += this.fBins[i];
			}
			return num;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002E60 File Offset: 0x00001E60
		public double GetMean()
		{
			double num = 0.0;
			double num2 = 0.0;
			for (int i = 0; i < this.fNBins; i++)
			{
				num += this.fBins[i];
				num2 += this.GetBinCentre(i) * this.fBins[i];
			}
			if (num != 0.0)
			{
				return num2 / num;
			}
			return 0.0;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002ECC File Offset: 0x00001ECC
		public void Print()
		{
			for (int i = 0; i < this.fNBins; i++)
			{
				Console.WriteLine(string.Concat(new object[]
				{
					i,
					" - [",
					this.GetBinMin(i),
					" ",
					this.GetBinCentre(i),
					" ",
					this.GetBinMax(i),
					"] : ",
					this.fBins[i].ToString("F2")
				}));
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002F72 File Offset: 0x00001F72
		public virtual void Draw()
		{
			this.Draw("");
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002F80 File Offset: 0x00001F80
		public virtual void Draw(string Option)
		{
			if (Chart.Pad == null)
			{
				new Canvas("Canvas", "Canvas");
			}
			Chart.Pad.Add(this);
			Chart.Pad.Title.Add(this.fName, this.fFillColor);
			Chart.Pad.Legend.Add(this.fName, this.fFillColor);
			if (Option.ToLower().IndexOf("s") < 0)
			{
				Chart.Pad.SetRange(this.fXMin, this.fXMax, this.fYMin - (this.fYMax - this.fYMin) / 10.0, this.fYMax + (this.fYMax - this.fYMin) / 10.0);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000304C File Offset: 0x0000204C
		public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
		{
			Pen pen = new Pen(this.fLineColor);
			Brush brush;
			if (this.fFillBrush == null)
			{
				brush = new SolidBrush(this.fFillColor);
			}
			else
			{
				brush = this.fFillBrush;
			}
			for (int i = 0; i < this.fNBins; i++)
			{
				Pad.Graphics.FillRectangle(brush, Pad.ClientX(this.GetBinMin(i)), Pad.ClientY(this.fBins[i]), Math.Abs(Pad.ClientX(this.GetBinMax(i)) - Pad.ClientX(this.GetBinMin(i))), Math.Abs(Pad.ClientY(this.fBins[i]) - Pad.ClientY(0.0)));
				Pad.DrawLine(pen, this.GetBinMin(i), 0.0, this.GetBinMin(i), this.fBins[i]);
				Pad.DrawLine(pen, this.GetBinMin(i), this.fBins[i], this.GetBinMax(i), this.fBins[i]);
				Pad.DrawLine(pen, this.GetBinMax(i), this.fBins[i], this.GetBinMax(i), 0.0);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003174 File Offset: 0x00002174
		public TDistance Distance(double X, double Y)
		{
			return null;
		}

		// Token: 0x04000023 RID: 35
		private string fName;

		// Token: 0x04000024 RID: 36
		private string fTitle;

		// Token: 0x04000025 RID: 37
		protected int fNBins;

		// Token: 0x04000026 RID: 38
		protected double[] fBins;

		// Token: 0x04000027 RID: 39
		protected double fBinSize;

		// Token: 0x04000028 RID: 40
		protected double fXMin;

		// Token: 0x04000029 RID: 41
		protected double fXMax;

		// Token: 0x0400002A RID: 42
		protected double fYMin;

		// Token: 0x0400002B RID: 43
		protected double fYMax;

		// Token: 0x0400002C RID: 44
		protected double[] fIntegral;

		// Token: 0x0400002D RID: 45
		protected bool fIntegralChanged;

		// Token: 0x0400002E RID: 46
		private Color fLineColor;

		// Token: 0x0400002F RID: 47
		private Color fFillColor;

		// Token: 0x04000030 RID: 48
		[NonSerialized]
		private Brush fFillBrush;

		// Token: 0x04000031 RID: 49
		private bool fToolTipEnabled;

		// Token: 0x04000032 RID: 50
		private string fToolTipFormat;
	}
}
