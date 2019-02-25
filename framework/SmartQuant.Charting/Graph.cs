using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace SmartQuant.Charting
{
	// Token: 0x02000024 RID: 36
	[Serializable]
	public class Graph : IDrawable, IZoomable, IMovable
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000067A8 File Offset: 0x000057A8
		// (set) Token: 0x06000150 RID: 336 RVA: 0x000067B0 File Offset: 0x000057B0
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000067B9 File Offset: 0x000057B9
		// (set) Token: 0x06000152 RID: 338 RVA: 0x000067C1 File Offset: 0x000057C1
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000067CA File Offset: 0x000057CA
		// (set) Token: 0x06000154 RID: 340 RVA: 0x000067D2 File Offset: 0x000057D2
		[Category("ToolTip")]
		[Description("")]
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000155 RID: 341 RVA: 0x000067DB File Offset: 0x000057DB
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000067E3 File Offset: 0x000057E3
		[Description("")]
		[Category("ToolTip")]
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

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000067EC File Offset: 0x000057EC
		// (set) Token: 0x06000158 RID: 344 RVA: 0x000067F4 File Offset: 0x000057F4
		[Category("Style")]
		[Description("")]
		public EGraphStyle Style
		{
			get
			{
				return this.fStyle;
			}
			set
			{
				this.fStyle = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000067FD File Offset: 0x000057FD
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00006805 File Offset: 0x00005805
		[Description("")]
		[Category("Style")]
		public EGraphMoveStyle MoveStyle
		{
			get
			{
				return this.fMoveStyle;
			}
			set
			{
				this.fMoveStyle = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000680E File Offset: 0x0000580E
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00006816 File Offset: 0x00005816
		[Category("Marker")]
		[Description("")]
		public bool MarkerEnabled
		{
			get
			{
				return this.fMarkerEnabled;
			}
			set
			{
				this.fMarkerEnabled = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000681F File Offset: 0x0000581F
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00006828 File Offset: 0x00005828
		[Category("Marker")]
		[Description("")]
		public EMarkerStyle MarkerStyle
		{
			get
			{
				return this.fMarkerStyle;
			}
			set
			{
				this.fMarkerStyle = value;
				foreach (object obj in this.fPoints)
				{
					TMarker tmarker = (TMarker)obj;
					tmarker.Style = this.fMarkerStyle;
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00006890 File Offset: 0x00005890
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00006898 File Offset: 0x00005898
		[Description("")]
		[Category("Marker")]
		public int MarkerSize
		{
			get
			{
				return this.fMarkerSize;
			}
			set
			{
				this.fMarkerSize = value;
				foreach (object obj in this.fPoints)
				{
					TMarker tmarker = (TMarker)obj;
					tmarker.Size = this.fMarkerSize;
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00006900 File Offset: 0x00005900
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00006908 File Offset: 0x00005908
		[Description("")]
		[Category("Marker")]
		public Color MarkerColor
		{
			get
			{
				return this.fMarkerColor;
			}
			set
			{
				this.fMarkerColor = value;
				foreach (object obj in this.fPoints)
				{
					TMarker tmarker = (TMarker)obj;
					tmarker.Color = this.fMarkerColor;
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00006970 File Offset: 0x00005970
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00006978 File Offset: 0x00005978
		[Category("Bar")]
		[Description("")]
		public int BarWidth
		{
			get
			{
				return this.fBarWidth;
			}
			set
			{
				this.fBarWidth = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00006981 File Offset: 0x00005981
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00006989 File Offset: 0x00005989
		[Description("")]
		[Category("Line")]
		public bool LineEnabled
		{
			get
			{
				return this.fLineEnabled;
			}
			set
			{
				this.fLineEnabled = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00006992 File Offset: 0x00005992
		// (set) Token: 0x06000168 RID: 360 RVA: 0x0000699A File Offset: 0x0000599A
		[Description("")]
		[Category("Line")]
		public DashStyle LineDashStyle
		{
			get
			{
				return this.fLineDashStyle;
			}
			set
			{
				this.fLineDashStyle = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000069A3 File Offset: 0x000059A3
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000069AB File Offset: 0x000059AB
		[Description("")]
		[Category("Line")]
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

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000069B4 File Offset: 0x000059B4
		[Browsable(false)]
		public ArrayList Points
		{
			get
			{
				return this.fPoints;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000069BC File Offset: 0x000059BC
		[Browsable(false)]
		public double MinX
		{
			get
			{
				return this.fXMin;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000069C4 File Offset: 0x000059C4
		[Browsable(false)]
		public double MinY
		{
			get
			{
				return this.fYMin;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000069CC File Offset: 0x000059CC
		[Browsable(false)]
		public double MaxX
		{
			get
			{
				return this.fXMax;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000069D4 File Offset: 0x000059D4
		[Browsable(false)]
		public double MaxY
		{
			get
			{
				return this.fMaxY;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000069DC File Offset: 0x000059DC
		private void MinMax(double X, double Y)
		{
			this.fXMin = Math.Min(this.fXMin, X);
			this.fYMin = Math.Min(this.fYMin, Y);
			this.fXMax = Math.Max(this.fXMax, X);
			this.fMaxY = Math.Max(this.fMaxY, Y);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00006A34 File Offset: 0x00005A34
		private void InitGraph()
		{
			this.fStyle = EGraphStyle.Line;
			this.fMoveStyle = EGraphMoveStyle.Point;
			this.fPoints = new ArrayList();
			this.fXMin = double.MaxValue;
			this.fYMin = double.MaxValue;
			this.fXMax = double.MinValue;
			this.fMaxY = double.MinValue;
			this.fMarkerEnabled = true;
			this.fMarkerStyle = EMarkerStyle.Rectangle;
			this.fMarkerSize = 5;
			this.fMarkerColor = Color.Black;
			this.fLineEnabled = true;
			this.fLineDashStyle = DashStyle.Solid;
			this.fLineColor = Color.Black;
			this.fBarWidth = 20;
			this.fToolTipEnabled = true;
			this.fToolTipFormat = "{0}\nX = {2:F2} Y = {3:F2}";
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00006AE9 File Offset: 0x00005AE9
		public Graph()
		{
			this.InitGraph();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006AF7 File Offset: 0x00005AF7
		public Graph(string Name)
		{
			this.fName = Name;
			this.InitGraph();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006B0C File Offset: 0x00005B0C
		public Graph(string Name, string Title)
		{
			this.fName = Name;
			this.fTitle = Title;
			this.InitGraph();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00006B28 File Offset: 0x00005B28
		public void Add(double X, double Y)
		{
			TMarker tmarker = new TMarker(X, Y);
			tmarker.Style = this.fMarkerStyle;
			tmarker.Size = this.fMarkerSize;
			tmarker.Color = this.fMarkerColor;
			this.fPoints.Add(tmarker);
			this.MinMax(X, Y);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00006B78 File Offset: 0x00005B78
		public void Add(double X, double Y, Color Color)
		{
			TMarker tmarker = new TMarker(X, Y);
			tmarker.Style = this.fMarkerStyle;
			tmarker.Size = this.fMarkerSize;
			tmarker.Color = Color;
			this.fPoints.Add(tmarker);
			this.MinMax(X, Y);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00006BC4 File Offset: 0x00005BC4
		public void Add(double X, double Y, string Text)
		{
			TLabel tlabel = new TLabel(Text, X, Y);
			tlabel.Style = this.fMarkerStyle;
			tlabel.Size = this.fMarkerSize;
			tlabel.Color = this.fMarkerColor;
			this.fPoints.Add(tlabel);
			this.MinMax(X, Y);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00006C14 File Offset: 0x00005C14
		public void Add(double X, double Y, string Text, Color MarkerColor)
		{
			TLabel tlabel = new TLabel(Text, X, Y, MarkerColor);
			tlabel.Style = this.fMarkerStyle;
			tlabel.Size = this.fMarkerSize;
			this.fPoints.Add(tlabel);
			this.MinMax(X, Y);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00006C5C File Offset: 0x00005C5C
		public void Add(double X, double Y, string Text, Color MarkerColor, Color TextColor)
		{
			TLabel tlabel = new TLabel(Text, X, Y, MarkerColor, TextColor);
			tlabel.Style = this.fMarkerStyle;
			tlabel.Size = this.fMarkerSize;
			this.fPoints.Add(tlabel);
			this.MinMax(X, Y);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00006CA3 File Offset: 0x00005CA3
		public void Add(TMarker Marker)
		{
			this.fPoints.Add(Marker);
			this.MinMax(Marker.X, Marker.Y);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00006CC4 File Offset: 0x00005CC4
		public void Add(TLabel Label)
		{
			this.fPoints.Add(Label);
			this.MinMax(Label.X, Label.Y);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00006CE5 File Offset: 0x00005CE5
		public virtual bool IsPadRangeX()
		{
			return false;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00006CE8 File Offset: 0x00005CE8
		public virtual bool IsPadRangeY()
		{
			return false;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00006CEB File Offset: 0x00005CEB
		public virtual PadRange GetPadRangeX(Pad Pad)
		{
			return null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00006CEE File Offset: 0x00005CEE
		public virtual PadRange GetPadRangeY(Pad Pad)
		{
			return null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00006CF4 File Offset: 0x00005CF4
		public virtual void Draw(string Option)
		{
			if (Chart.Pad == null)
			{
				new Canvas("Canvas", "Canvas");
			}
			Chart.Pad.Add(this);
			Chart.Pad.Title.Add(this.fName, this.fLineColor);
			Chart.Pad.Legend.Add(this.fName, this.fLineColor);
			if (Option.ToLower().IndexOf("s") < 0)
			{
				Chart.Pad.SetRange(this.fXMin - (this.fXMax - this.fXMin) / 10.0, this.fXMax + (this.fXMax - this.fXMin) / 10.0, this.fYMin - (this.fMaxY - this.fYMin) / 10.0, this.fMaxY + (this.fMaxY - this.fYMin) / 10.0);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00006DF1 File Offset: 0x00005DF1
		public virtual void Draw()
		{
			this.Draw("");
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00006E00 File Offset: 0x00005E00
		public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
		{
			if (this.fStyle == EGraphStyle.Line && this.fLineEnabled)
			{
				Pen pen = new Pen(this.fLineColor);
				pen.DashStyle = this.fLineDashStyle;
				double x = 0.0;
				double y = 0.0;
				bool flag = true;
				foreach (object obj in this.fPoints)
				{
					TMarker tmarker = (TMarker)obj;
					if (!flag)
					{
						Pad.DrawLine(pen, x, y, tmarker.X, tmarker.Y);
					}
					else
					{
						flag = false;
					}
					x = tmarker.X;
					y = tmarker.Y;
				}
			}
			if ((this.fStyle == EGraphStyle.Line || this.fStyle == EGraphStyle.Scatter) && this.fMarkerEnabled)
			{
				foreach (object obj2 in this.fPoints)
				{
					TMarker tmarker2 = (TMarker)obj2;
					tmarker2.Paint(Pad, XMin, XMax, YMin, YMax);
				}
			}
			if (this.fStyle == EGraphStyle.Bar)
			{
				foreach (object obj3 in this.fPoints)
				{
					TMarker tmarker3 = (TMarker)obj3;
					if (tmarker3.Y > 0.0)
					{
						Pad.Graphics.FillRectangle(new SolidBrush(Color.Black), Pad.ClientX(tmarker3.X) - this.fBarWidth / 2, Pad.ClientY(tmarker3.Y), this.fBarWidth, Pad.ClientY(0.0) - Pad.ClientY(tmarker3.Y));
					}
					else
					{
						Pad.Graphics.FillRectangle(new SolidBrush(Color.Black), Pad.ClientX(tmarker3.X) - this.fBarWidth / 2, Pad.ClientY(0.0), this.fBarWidth, Pad.ClientY(tmarker3.Y) - Pad.ClientY(0.0));
					}
				}
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00007064 File Offset: 0x00006064
		public TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			foreach (object obj in this.fPoints)
			{
				TMarker tmarker = (TMarker)obj;
				TDistance tdistance2 = tmarker.Distance(X, Y);
				if (tdistance2.dX < tdistance.dX && tdistance2.dY < tdistance.dY)
				{
					tdistance = tdistance2;
				}
			}
			if (tdistance != null)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat(this.fToolTipFormat, new object[]
				{
					this.fName,
					this.fTitle,
					tdistance.X,
					tdistance.Y
				});
				tdistance.ToolTipText = stringBuilder.ToString();
			}
			return tdistance;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000714C File Offset: 0x0000614C
		public void Move(double X, double Y, double dX, double dY)
		{
			switch (this.fMoveStyle)
			{
			case EGraphMoveStyle.Graph:
				break;
			case EGraphMoveStyle.Point:
                IEnumerator enumerator = this.fPoints.GetEnumerator();
				
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					TMarker tmarker = (TMarker)obj;
					if (tmarker.X == X && tmarker.Y == Y)
					{
						tmarker.X += dX;
						tmarker.Y += dY;
						break;
					}
				}
				return;
			default:
				return;
			}
			foreach (object obj2 in this.fPoints)
			{
				TMarker tmarker2 = (TMarker)obj2;
				tmarker2.X += dX;
				tmarker2.Y += dY;
			}
		}

		// Token: 0x04000095 RID: 149
		private string fName;

		// Token: 0x04000096 RID: 150
		private string fTitle;

		// Token: 0x04000097 RID: 151
		private ArrayList fPoints;

		// Token: 0x04000098 RID: 152
		private EGraphStyle fStyle;

		// Token: 0x04000099 RID: 153
		private EGraphMoveStyle fMoveStyle;

		// Token: 0x0400009A RID: 154
		private bool fMarkerEnabled;

		// Token: 0x0400009B RID: 155
		private EMarkerStyle fMarkerStyle;

		// Token: 0x0400009C RID: 156
		private int fMarkerSize;

		// Token: 0x0400009D RID: 157
		private Color fMarkerColor;

		// Token: 0x0400009E RID: 158
		private bool fLineEnabled;

		// Token: 0x0400009F RID: 159
		private DashStyle fLineDashStyle;

		// Token: 0x040000A0 RID: 160
		private Color fLineColor;

		// Token: 0x040000A1 RID: 161
		private double fXMin;

		// Token: 0x040000A2 RID: 162
		private double fXMax;

		// Token: 0x040000A3 RID: 163
		private double fYMin;

		// Token: 0x040000A4 RID: 164
		private double fMaxY;

		// Token: 0x040000A5 RID: 165
		private int fBarWidth;

		// Token: 0x040000A6 RID: 166
		private bool fToolTipEnabled;

		// Token: 0x040000A7 RID: 167
		private string fToolTipFormat;
	}
}
