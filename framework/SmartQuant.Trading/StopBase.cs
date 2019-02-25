using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using SmartQuant.Charting;
using SmartQuant.Data;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000020 RID: 32
	public abstract class StopBase : IStop, IDrawable, IZoomable
	{
		// Token: 0x06000135 RID: 309 RVA: 0x0000576C File Offset: 0x0000476C
		public StopBase()
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000136 RID: 310
		public abstract Instrument Instrument { get; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00005800 File Offset: 0x00004800
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00005808 File Offset: 0x00004808
		public bool TraceOnBar
		{
			get
			{
				return this.fTraceOnBar;
			}
			set
			{
				this.fTraceOnBar = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00005811 File Offset: 0x00004811
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00005819 File Offset: 0x00004819
		public bool TraceOnBarOpen
		{
			get
			{
				return this.fTraceOnBarOpen;
			}
			set
			{
				this.fTraceOnBarOpen = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00005822 File Offset: 0x00004822
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000582A File Offset: 0x0000482A
		public bool TraceOnTrade
		{
			get
			{
				return this.fTraceOnTrade;
			}
			set
			{
				this.fTraceOnTrade = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00005833 File Offset: 0x00004833
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000583B File Offset: 0x0000483B
		public bool TraceOnQuote
		{
			get
			{
				return this.fTraceOnQuote;
			}
			set
			{
				this.fTraceOnQuote = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00005844 File Offset: 0x00004844
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000584C File Offset: 0x0000484C
		public bool TrailOnOpen
		{
			get
			{
				return this.fTrailOnOpen;
			}
			set
			{
				this.fTrailOnOpen = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00005855 File Offset: 0x00004855
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000585D File Offset: 0x0000485D
		public bool TrailOnHighLow
		{
			get
			{
				return this.fTrailOnHighLow;
			}
			set
			{
				this.fTrailOnHighLow = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00005866 File Offset: 0x00004866
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000586E File Offset: 0x0000486E
		public double Level
		{
			get
			{
				return this.fLevel;
			}
			set
			{
				this.fLevel = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00005877 File Offset: 0x00004877
		public StopType Type
		{
			get
			{
				return this.fType;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000587F File Offset: 0x0000487F
		public StopMode Mode
		{
			get
			{
				return this.fMode;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00005887 File Offset: 0x00004887
		public StopStatus Status
		{
			get
			{
				return this.fStatus;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000588F File Offset: 0x0000488F
		public DateTime CreationTime
		{
			get
			{
				return this.fCreationTime;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00005897 File Offset: 0x00004897
		public DateTime CompletionTime
		{
			get
			{
				return this.fCompletionTime;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000589F File Offset: 0x0000489F
		public Position Position
		{
			get
			{
				return this.fPosition;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000058A7 File Offset: 0x000048A7
		// (set) Token: 0x0600014C RID: 332 RVA: 0x000058AF File Offset: 0x000048AF
		[Category("Drawing Style")]
		public Color ExecutedColor
		{
			get
			{
				return this.executedColor;
			}
			set
			{
				this.executedColor = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000058B8 File Offset: 0x000048B8
		// (set) Token: 0x0600014E RID: 334 RVA: 0x000058C0 File Offset: 0x000048C0
		[Category("Drawing Style")]
		public Color ActiveColor
		{
			get
			{
				return this.activeColor;
			}
			set
			{
				this.activeColor = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000058C9 File Offset: 0x000048C9
		// (set) Token: 0x06000150 RID: 336 RVA: 0x000058D1 File Offset: 0x000048D1
		[Category("Drawing Style")]
		public Color CanceledColor
		{
			get
			{
				return this.canceledColor;
			}
			set
			{
				this.canceledColor = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000058DA File Offset: 0x000048DA
		// (set) Token: 0x06000152 RID: 338 RVA: 0x000058E2 File Offset: 0x000048E2
		[Category("Drawing Style")]
		public bool TextEnabled
		{
			get
			{
				return this.textEnabled;
			}
			set
			{
				this.textEnabled = value;
			}
		}

		// Token: 0x06000153 RID: 339
		public abstract void Disconnect();

		// Token: 0x06000154 RID: 340 RVA: 0x000058EB File Offset: 0x000048EB
		public void SetBarFilter(long barSize, BarType barType)
		{
			this.fFilterBarSize = barSize;
			this.fFilterBarType = barType;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000058FB File Offset: 0x000048FB
		public void SetBarFilter(long barSize)
		{
			this.SetBarFilter(barSize, BarType.Time);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00005908 File Offset: 0x00004908
		public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			double worldY;
			if (this.fStatus == StopStatus.Executed)
			{
				worldY = Math.Abs(this.fFillPrice);
			}
			else
			{
				worldY = Math.Abs(this.fStopPrice);
			}
			if (this.fType == StopType.Time)
			{
				worldY = this.fStopPrice;
			}
			int num = Pad.ClientX((double)this.fCreationTime.Ticks);
			int num2 = Pad.ClientY(worldY);
			string text = string.Concat(new string[]
			{
				"Stop at ",
				worldY.ToString(this.fInstrument.PriceDisplay),
				" (",
				this.fStatus.ToString(),
				")"
			});
			Font font = new Font("Arial", 8f);
			Color color = this.canceledColor;
			switch (this.fStatus)
			{
			case StopStatus.Active:
				color = this.activeColor;
				break;
			case StopStatus.Executed:
				color = this.executedColor;
				break;
			case StopStatus.Canceled:
				color = this.canceledColor;
				break;
			}
			Pen pen = new Pen(color, 2f);
			pen.DashStyle = DashStyle.Dash;
			double val = (double)Pad.ClientX((double)Clock.Now.Ticks);
			double val2 = (double)Pad.ClientX(MinX);
			double val3 = (double)Pad.ClientX(MaxX);
			if (this.fStatus != StopStatus.Active)
			{
				val = (double)Pad.ClientX((double)this.fCompletionTime.Ticks);
			}
			float num3 = (float)Math.Max(val2, (double)num);
			float num4 = (float)Math.Min(val3, val);
			if (num3 <= num4)
			{
				Pad.Graphics.DrawLine(pen, num3, (float)num2, num4, (float)num2);
				if (this.textEnabled)
				{
					double num5 = (double)(num + 2);
					double num6;
					if (this.fSide == PositionSide.Long)
					{
						num6 = (double)(num2 - 2 - (int)Pad.Graphics.MeasureString(text, font).Height);
					}
					else
					{
						num6 = (double)(num2 + 2);
					}
					Pad.Graphics.DrawString(text, font, Brushes.Black, (float)num5, (float)num6);
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00005AFC File Offset: 0x00004AFC
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00005B04 File Offset: 0x00004B04
		[Category("ToolTip")]
		[Description("Enable or disable tooltip appearance for this marker.")]
		public bool ToolTipEnabled
		{
			get
			{
				return this.toolTipEnabled;
			}
			set
			{
				this.toolTipEnabled = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00005B0D File Offset: 0x00004B0D
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00005B15 File Offset: 0x00004B15
		[Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
		[Category("ToolTip")]
		public string ToolTipFormat
		{
			get
			{
				return this.toolTipFormat;
			}
			set
			{
				this.toolTipFormat = value;
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00005B20 File Offset: 0x00004B20
		public TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			double y = Math.Abs(this.fStopPrice);
			tdistance.X = X;
			tdistance.Y = y;
			if (X >= (double)this.fCreationTime.Ticks && ((this.fStatus == StopStatus.Active && X <= (double)Clock.Now.Ticks) || X <= (double)this.fCompletionTime.Ticks))
			{
				tdistance.dX = 0.0;
			}
			else
			{
				tdistance.dX = double.MaxValue;
			}
			tdistance.dY = Math.Abs(Y - tdistance.Y);
			StringBuilder stringBuilder = new StringBuilder();
			if (this.fCreationTime.Second != 0 || this.fCreationTime.Minute != 0 || this.fCreationTime.Hour != 0)
			{
				stringBuilder.AppendFormat(this.toolTipFormat, new object[]
				{
					this.fStatus.ToString(),
					this.fType.ToString(),
					" Stop (",
					this.fLevel.ToString(this.fPosition.Instrument.PriceDisplay),
					"): ",
					this.fPosition.Instrument.Symbol,
					y.ToString(this.fPosition.Instrument.PriceDisplay),
					this.fCreationTime
				});
			}
			else
			{
				stringBuilder.AppendFormat(this.toolTipFormat, new object[]
				{
					this.fStatus.ToString(),
					this.fType.ToString(),
					" Stop (",
					this.fLevel.ToString(this.fPosition.Instrument.PriceDisplay),
					"): ",
					this.fPosition.Instrument.Symbol,
					y.ToString(this.fPosition.Instrument.PriceDisplay),
					this.fCreationTime.ToShortDateString()
				});
			}
			tdistance.ToolTipText = stringBuilder.ToString();
			return tdistance;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00005D55 File Offset: 0x00004D55
		public void Draw()
		{
			Chart.Pad.Add(this);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005D62 File Offset: 0x00004D62
		public bool IsPadRangeY()
		{
			return true;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00005D68 File Offset: 0x00004D68
		public PadRange GetPadRangeY(Pad pad)
		{
			DateTime t = new DateTime((long)pad.XMin);
			DateTime t2 = new DateTime((long)pad.XMax);
			if (t <= this.fCompletionTime && t2 >= this.fCreationTime && this.fStatus != StopStatus.Canceled)
			{
				double num = Math.Abs(this.fStopPrice);
				return new PadRange(num - 1E-10, num + 1E-10);
			}
			return new PadRange(0.0, 0.0);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005DF5 File Offset: 0x00004DF5
		public bool IsPadRangeX()
		{
			return false;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005DF8 File Offset: 0x00004DF8
		public PadRange GetPadRangeX(Pad pad)
		{
			return null;
		}

		// Token: 0x04000063 RID: 99
		protected internal StopType fType = StopType.Trailing;

		// Token: 0x04000064 RID: 100
		protected internal StopMode fMode = StopMode.Percent;

		// Token: 0x04000065 RID: 101
		protected internal StopStatus fStatus;

		// Token: 0x04000066 RID: 102
		protected internal Position fPosition;

		// Token: 0x04000067 RID: 103
		protected internal Instrument fInstrument;

		// Token: 0x04000068 RID: 104
		protected internal double fLevel;

		// Token: 0x04000069 RID: 105
		protected internal double fInitPrice;

		// Token: 0x0400006A RID: 106
		protected internal double fCurrPrice;

		// Token: 0x0400006B RID: 107
		protected internal double fStopPrice;

		// Token: 0x0400006C RID: 108
		protected internal double fFillPrice;

		// Token: 0x0400006D RID: 109
		protected internal double fTrailPrice;

		// Token: 0x0400006E RID: 110
		protected internal double fQty;

		// Token: 0x0400006F RID: 111
		protected internal PositionSide fSide;

		// Token: 0x04000070 RID: 112
		protected internal DateTime fCreationTime;

		// Token: 0x04000071 RID: 113
		protected internal DateTime fCompletionTime;

		// Token: 0x04000072 RID: 114
		protected internal bool fTraceOnQuote = true;

		// Token: 0x04000073 RID: 115
		protected internal bool fTraceOnTrade = true;

		// Token: 0x04000074 RID: 116
		protected internal bool fTraceOnBar = true;

		// Token: 0x04000075 RID: 117
		protected internal bool fTraceOnBarOpen = true;

		// Token: 0x04000076 RID: 118
		protected internal bool fTrailOnOpen = true;

		// Token: 0x04000077 RID: 119
		protected internal bool fTrailOnHighLow;

		// Token: 0x04000078 RID: 120
		protected internal long fFilterBarSize = -1L;

		// Token: 0x04000079 RID: 121
		protected internal BarType fFilterBarType = BarType.Time;

		// Token: 0x0400007A RID: 122
		protected internal StopFillMode fFillMode = StopFillMode.Stop;

		// Token: 0x0400007B RID: 123
		protected internal bool textEnabled = true;

		// Token: 0x0400007C RID: 124
		protected internal bool toolTipEnabled = true;

		// Token: 0x0400007D RID: 125
		protected internal string toolTipFormat = "{0} {1} {2}{3}{4} {5} {6} {7}";

		// Token: 0x0400007E RID: 126
		protected internal Color activeColor = Color.Purple;

		// Token: 0x0400007F RID: 127
		protected internal Color executedColor = Color.RoyalBlue;

		// Token: 0x04000080 RID: 128
		protected internal Color canceledColor = Color.Gray;
	}
}
