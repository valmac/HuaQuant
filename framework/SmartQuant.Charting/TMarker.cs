using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace SmartQuant.Charting
{
	// Token: 0x0200002B RID: 43
	[Serializable]
	public class TMarker : IDrawable, IMovable
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00007953 File Offset: 0x00006953
		// (set) Token: 0x060001BB RID: 443 RVA: 0x0000795B File Offset: 0x0000695B
		public Color BuyColor
		{
			get
			{
				return this.fBuyColor;
			}
			set
			{
				this.fBuyColor = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00007964 File Offset: 0x00006964
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0000796C File Offset: 0x0000696C
		public Color SellColor
		{
			get
			{
				return this.fSellColor;
			}
			set
			{
				this.fSellColor = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00007975 File Offset: 0x00006975
		// (set) Token: 0x060001BF RID: 447 RVA: 0x0000797D File Offset: 0x0000697D
		public Color BuyShortColor
		{
			get
			{
				return this.fBuyShortColor;
			}
			set
			{
				this.fBuyShortColor = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00007986 File Offset: 0x00006986
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x0000798E File Offset: 0x0000698E
		public Color SellShortColor
		{
			get
			{
				return this.fSellShortColor;
			}
			set
			{
				this.fSellShortColor = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00007997 File Offset: 0x00006997
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0000799F File Offset: 0x0000699F
		[Category("ToolTip")]
		[Description("Enable or disable tooltip appearance for this marker.")]
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x000079A8 File Offset: 0x000069A8
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x000079B0 File Offset: 0x000069B0
		[Category("ToolTip")]
		[Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
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

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000079B9 File Offset: 0x000069B9
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x000079C1 File Offset: 0x000069C1
		[Category("Position")]
		[Description("X position of this marker on the pad. (World coordinate system)")]
		public double X
		{
			get
			{
				return this.fX;
			}
			set
			{
				this.fX = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x000079CA File Offset: 0x000069CA
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x000079D2 File Offset: 0x000069D2
		[Category("Position")]
		[Description("Y position of this marker on the pad. (World coordinate system)")]
		public double Y
		{
			get
			{
				return this.fY;
			}
			set
			{
				this.fY = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000079DB File Offset: 0x000069DB
		// (set) Token: 0x060001CB RID: 459 RVA: 0x000079E3 File Offset: 0x000069E3
		[Browsable(false)]
		public double Z
		{
			get
			{
				return this.fZ;
			}
			set
			{
				this.fZ = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000079EC File Offset: 0x000069EC
		// (set) Token: 0x060001CD RID: 461 RVA: 0x000079F4 File Offset: 0x000069F4
		[Category("Marker")]
		[Description("Marker style")]
		public EMarkerStyle Style
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000079FD File Offset: 0x000069FD
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00007A05 File Offset: 0x00006A05
		[Description("Marker color")]
		[Category("Marker")]
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

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00007A0E File Offset: 0x00006A0E
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00007A16 File Offset: 0x00006A16
		[Description("Marker size in pixels")]
		[Category("Marker")]
		public int Size
		{
			get
			{
				return this.fSize;
			}
			set
			{
				this.fSize = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00007A1F File Offset: 0x00006A1F
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00007A27 File Offset: 0x00006A27
		[Description("Marker interior will be filled if this propery is set to true, otherwise it will be transparent")]
		[Category("Marker")]
		public bool Filled
		{
			get
			{
				return this.fFilled;
			}
			set
			{
				this.fFilled = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00007A30 File Offset: 0x00006A30
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00007A38 File Offset: 0x00006A38
		[Category("Value")]
		[Description("High of bar marker")]
		public double High
		{
			get
			{
				return this.fHigh;
			}
			set
			{
				this.fHigh = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00007A41 File Offset: 0x00006A41
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00007A49 File Offset: 0x00006A49
		[Category("Value")]
		[Description("Low of bar marker")]
		public double Low
		{
			get
			{
				return this.fLow;
			}
			set
			{
				this.fLow = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00007A52 File Offset: 0x00006A52
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00007A5A File Offset: 0x00006A5A
		[Description("Open of bar marker")]
		[Category("Value")]
		public double Open
		{
			get
			{
				return this.fOpen;
			}
			set
			{
				this.fOpen = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00007A63 File Offset: 0x00006A63
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00007A6B File Offset: 0x00006A6B
		[Description("Close of bar marker")]
		[Category("Value")]
		public double Close
		{
			get
			{
				return this.fClose;
			}
			set
			{
				this.fClose = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00007A74 File Offset: 0x00006A74
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00007A7C File Offset: 0x00006A7C
		public string Text
		{
			get
			{
				return this.fText;
			}
			set
			{
				this.fText = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00007A85 File Offset: 0x00006A85
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00007A8D File Offset: 0x00006A8D
		public bool TextEnabled
		{
			get
			{
				return this.fTextEnabled;
			}
			set
			{
				this.fTextEnabled = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00007A96 File Offset: 0x00006A96
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00007A9E File Offset: 0x00006A9E
		public EMarkerTextPosition TextPosition
		{
			get
			{
				return this.fTextPosition;
			}
			set
			{
				this.fTextPosition = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00007AA7 File Offset: 0x00006AA7
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00007AAF File Offset: 0x00006AAF
		public int TextOffset
		{
			get
			{
				return this.fTextOffset;
			}
			set
			{
				this.fTextOffset = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00007AB8 File Offset: 0x00006AB8
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00007AC0 File Offset: 0x00006AC0
		public Color TextColor
		{
			get
			{
				return this.fTextColor;
			}
			set
			{
				this.fTextColor = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00007AC9 File Offset: 0x00006AC9
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00007AD1 File Offset: 0x00006AD1
		public Font TextFont
		{
			get
			{
				return this.fTextFont;
			}
			set
			{
				this.fTextFont = value;
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00007ADC File Offset: 0x00006ADC
		private void InitMarker()
		{
			this.fStyle = EMarkerStyle.Rectangle;
			this.fColor = Color.Black;
			this.fSize = 5;
			this.fFilled = true;
			this.fTextEnabled = true;
			this.fTextOffset = 2;
			this.fTextPosition = EMarkerTextPosition.Bottom;
			this.fTextFont = new Font("Arial", 8f);
			this.fTextColor = Color.Black;
			this.fToolTipEnabled = true;
			this.fToolTipFormat = "X = {0:F2} Y = {1:F2}";
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00007B50 File Offset: 0x00006B50
		public TMarker(double X, double Y)
		{
			this.fX = X;
			this.fY = Y;
			this.fZ = 0.0;
			this.InitMarker();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00007BB4 File Offset: 0x00006BB4
		public TMarker(DateTime X, double Y)
		{
			this.fX = (double)X.Ticks;
			this.fY = Y;
			this.fZ = 0.0;
			this.InitMarker();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00007C20 File Offset: 0x00006C20
		public TMarker(string X, double Y)
		{
			this.fX = (double)DateTime.Parse(X).Ticks;
			this.fY = Y;
			this.fZ = 0.0;
			this.InitMarker();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00007C90 File Offset: 0x00006C90
		public TMarker(double X, double Y, Color Color)
		{
			this.fX = X;
			this.fY = Y;
			this.fZ = 0.0;
			this.InitMarker();
			this.fColor = Color;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00007CFC File Offset: 0x00006CFC
		public TMarker(double X, double Y, EMarkerStyle Style)
		{
			this.fX = X;
			this.fY = Y;
			this.fZ = 0.0;
			this.InitMarker();
			this.fStyle = Style;
			if (this.fStyle == EMarkerStyle.Buy || this.fStyle == EMarkerStyle.Sell || this.fStyle == EMarkerStyle.SellShort || this.fStyle == EMarkerStyle.BuyShort)
			{
				this.fSize = 10;
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00007D94 File Offset: 0x00006D94
		public TMarker(DateTime X, double Y, EMarkerStyle Style)
		{
			this.fX = (double)X.Ticks;
			this.fY = Y;
			this.fZ = 0.0;
			this.InitMarker();
			this.fStyle = Style;
			if (this.fStyle == EMarkerStyle.Buy || this.fStyle == EMarkerStyle.Sell || this.fStyle == EMarkerStyle.SellShort || this.fStyle == EMarkerStyle.BuyShort)
			{
				this.fSize = 10;
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00007E34 File Offset: 0x00006E34
		public TMarker(string X, double Y, EMarkerStyle Style)
		{
			this.fX = (double)DateTime.Parse(X).Ticks;
			this.fY = Y;
			this.fZ = 0.0;
			this.InitMarker();
			this.fStyle = Style;
			if (this.fStyle == EMarkerStyle.Buy || this.fStyle == EMarkerStyle.Sell || this.fStyle == EMarkerStyle.SellShort || this.fStyle == EMarkerStyle.BuyShort)
			{
				this.fSize = 10;
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00007ED8 File Offset: 0x00006ED8
		public TMarker(double X, double Y, double Z)
		{
			this.fX = X;
			this.fY = Y;
			this.fZ = Z;
			this.InitMarker();
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00007F34 File Offset: 0x00006F34
		public TMarker(double X, double Y, double Z, Color Color)
		{
			this.fX = X;
			this.fY = Y;
			this.fZ = Z;
			this.InitMarker();
			this.fColor = Color;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00007F98 File Offset: 0x00006F98
		public TMarker(double X, double High, double Low, double Open, double Close)
		{
			this.fX = X;
			this.fY = 0.0;
			this.fZ = 0.0;
			this.fHigh = High;
			this.fLow = Low;
			this.fOpen = Open;
			this.fClose = Close;
			this.InitMarker();
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00008020 File Offset: 0x00007020
		public TMarker(double X, double High, double Low, double Open, double Close, Color Color)
		{
			this.fX = X;
			this.fY = 0.0;
			this.fZ = 0.0;
			this.fHigh = High;
			this.fLow = Low;
			this.fOpen = Open;
			this.fClose = Close;
			this.InitMarker();
			this.fColor = Color;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000080B0 File Offset: 0x000070B0
		public virtual void Draw()
		{
			if (Chart.Pad == null)
			{
				new Canvas("Canvas", "Canvas");
			}
			Chart.Pad.Add(this);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000080D4 File Offset: 0x000070D4
		public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
		{
			int num = Pad.ClientX(this.fX);
			int num2 = Pad.ClientY(this.fY);
			float num3 = (float)this.fSize;
			switch (this.fStyle)
			{
			case EMarkerStyle.Rectangle:
				if (this.fFilled)
				{
					Pad.Graphics.FillRectangle(new SolidBrush(this.fColor), (float)num - num3 / 2f, (float)num2 - num3 / 2f, num3, num3);
				}
				else
				{
					Pen pen = new Pen(this.fColor);
					Pad.Graphics.DrawRectangle(pen, (float)num - num3 / 2f, (float)num2 - num3 / 2f, num3, num3);
				}
				break;
			case EMarkerStyle.Triangle:
			{
				float num4 = (float)((double)(num3 / 2f) * Math.Tan(0.52359877559829882));
				float num5 = (float)((double)num3 * Math.Cos(0.52359877559829882)) - num4;
				PointF pointF = new PointF((float)num, (float)num2 - num5);
				PointF pointF2 = new PointF((float)num - num3 / 2f, (float)num2 + num4);
				PointF pointF3 = new PointF((float)num + num3 / 2f, (float)num2 + num4);
				PointF[] points = new PointF[]
				{
					pointF,
					pointF2,
					pointF3,
					pointF
				};
				if (this.fFilled)
				{
					Pad.Graphics.FillPolygon(new SolidBrush(this.fColor), points);
				}
				else
				{
					Pen pen = new Pen(this.fColor);
					Pad.Graphics.DrawLines(pen, points);
				}
				break;
			}
			case EMarkerStyle.Circle:
				if (this.fFilled)
				{
					Pad.Graphics.FillEllipse(new SolidBrush(this.fColor), (float)num - num3 / 2f, (float)num2 - num3 / 2f, num3, num3);
				}
				else
				{
					Pen pen = new Pen(this.fColor);
					Pad.Graphics.DrawEllipse(pen, (float)num - num3 / 2f, (float)num2 - num3 / 2f, num3, num3);
				}
				break;
			case EMarkerStyle.Bar:
			{
				Pen pen2 = new Pen(this.fColor);
				Pad.Graphics.DrawLine(pen2, num, Pad.ClientY(this.fLow), Pad.ClientX(this.fX), Pad.ClientY(this.fHigh));
				Pad.Graphics.DrawLine(pen2, num, Pad.ClientY(this.fLow), Pad.ClientX(this.fX) - 3, Pad.ClientY(this.fLow));
				Pad.Graphics.DrawLine(pen2, num, Pad.ClientY(this.fHigh), Pad.ClientX(this.fX) + 3, Pad.ClientY(this.fHigh));
				break;
			}
			case EMarkerStyle.Buy:
			{
				Point p = new Point(num, num2);
				Point p2 = new Point((int)((float)num - num3 / 2f), (int)((float)num2 + num3));
				Point p3 = new Point((int)((float)num + num3 / 2f), (int)((float)num2 + num3));
				PointF[] points2 = new PointF[]
				{
					p,
					p2,
					p3
				};
				Pad.Graphics.FillPolygon(new SolidBrush(this.fBuyColor), points2);
				break;
			}
			case EMarkerStyle.Sell:
			{
				Point point = new Point(num, num2);
				Point point2 = new Point((int)((float)num - num3 / 2f), (int)((float)num2 - num3));
				Point point3 = new Point((int)((float)num + num3 / 2f), (int)((float)num2 - num3));
				Point[] points3 = new Point[]
				{
					point,
					point2,
					point3
				};
				Pad.Graphics.FillPolygon(new SolidBrush(this.fSellColor), points3);
				break;
			}
			case EMarkerStyle.SellShort:
			{
				Point point4 = new Point(num, num2);
				Point point5 = new Point((int)((float)num - num3 / 2f), (int)((float)num2 - num3));
				Point point6 = new Point((int)((float)num + num3 / 2f), (int)((float)num2 - num3));
				Point[] points4 = new Point[]
				{
					point4,
					point5,
					point6
				};
				Pad.Graphics.FillPolygon(new SolidBrush(this.fSellShortColor), points4);
				break;
			}
			case EMarkerStyle.BuyShort:
			{
				Point point7 = new Point(num, num2);
				Point point8 = new Point((int)((float)num - num3 / 2f), (int)((float)num2 + num3));
				Point point9 = new Point((int)((float)num + num3 / 2f), (int)((float)num2 + num3));
				Point[] points5 = new Point[]
				{
					point7,
					point8,
					point9
				};
				Pad.Graphics.FillPolygon(new SolidBrush(this.fBuyShortColor), points5);
				break;
			}
			case EMarkerStyle.Plus:
			{
				Pen pen = new Pen(this.fColor);
				Pad.Graphics.DrawLine(pen, (float)num - num3 / 2f, (float)num2, (float)num + num3 / 2f, (float)num2);
				Pad.Graphics.DrawLine(pen, (float)num, (float)num2 - num3 / 2f, (float)num, (float)num2 + num3 / 2f);
				break;
			}
			case EMarkerStyle.Cross:
			{
				Pen pen = new Pen(this.fColor);
				Pad.Graphics.DrawLine(pen, (float)num - num3 / 2f, (float)num2 - num3 / 2f, (float)num + num3 / 2f, (float)num2 + num3 / 2f);
				Pad.Graphics.DrawLine(pen, (float)num - num3 / 2f, (float)num2 + num3 / 2f, (float)num + num3 / 2f, (float)num2 - num3 / 2f);
				break;
			}
			}
			if (this.fTextEnabled && this.fText != null && this.fText != "")
			{
				int num6 = (int)Pad.Graphics.MeasureString(this.fText, this.fTextFont).Width;
				int num7 = (int)Pad.Graphics.MeasureString(this.fText, this.fTextFont).Height;
				switch (this.fStyle)
				{
				case EMarkerStyle.Buy:
					Pad.Graphics.DrawString(this.fText, this.fTextFont, new SolidBrush(this.fTextColor), (float)(Pad.ClientX(this.fX) - num6 / 2), (float)Pad.ClientY(this.fY) + num3 + (float)this.fTextOffset);
					return;
				case EMarkerStyle.Sell:
					Pad.Graphics.DrawString(this.fText, this.fTextFont, new SolidBrush(this.fTextColor), (float)(Pad.ClientX(this.fX) - num6 / 2), (float)Pad.ClientY(this.fY) - num3 - (float)this.fTextOffset - (float)num7);
					return;
				case EMarkerStyle.SellShort:
					Pad.Graphics.DrawString(this.fText, this.fTextFont, new SolidBrush(this.fTextColor), (float)(Pad.ClientX(this.fX) - num6 / 2), (float)Pad.ClientY(this.fY) + num3 + (float)this.fTextOffset);
					break;
				case EMarkerStyle.BuyShort:
					Pad.Graphics.DrawString(this.fText, this.fTextFont, new SolidBrush(this.fTextColor), (float)(Pad.ClientX(this.fX) - num6 / 2), (float)Pad.ClientY(this.fY) + num3 + (float)this.fTextOffset);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00008898 File Offset: 0x00007898
		public virtual TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			tdistance.X = this.fX;
			tdistance.Y = this.fY;
			tdistance.dX = Math.Abs(X - this.fX);
			tdistance.dY = Math.Abs(Y - this.fY);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(this.fToolTipFormat, this.fX, this.fY);
			tdistance.ToolTipText = stringBuilder.ToString();
			return tdistance;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000891F File Offset: 0x0000791F
		public void Move(double X, double Y, double dX, double dY)
		{
			this.fX += dX;
			this.fY += dY;
		}

		// Token: 0x040000C4 RID: 196
		protected double fX;

		// Token: 0x040000C5 RID: 197
		protected double fY;

		// Token: 0x040000C6 RID: 198
		protected double fZ;

		// Token: 0x040000C7 RID: 199
		protected double fHigh;

		// Token: 0x040000C8 RID: 200
		protected double fLow;

		// Token: 0x040000C9 RID: 201
		protected double fOpen;

		// Token: 0x040000CA RID: 202
		protected double fClose;

		// Token: 0x040000CB RID: 203
		protected EMarkerStyle fStyle;

		// Token: 0x040000CC RID: 204
		protected Color fColor;

		// Token: 0x040000CD RID: 205
		protected int fSize;

		// Token: 0x040000CE RID: 206
		protected bool fFilled;

		// Token: 0x040000CF RID: 207
		protected Color fBuyColor = Color.Blue;

		// Token: 0x040000D0 RID: 208
		protected Color fSellColor = Color.Red;

		// Token: 0x040000D1 RID: 209
		protected Color fSellShortColor = Color.Yellow;

		// Token: 0x040000D2 RID: 210
		protected Color fBuyShortColor = Color.Green;

		// Token: 0x040000D3 RID: 211
		[NonSerialized]
		protected string fText;

		// Token: 0x040000D4 RID: 212
		[NonSerialized]
		protected bool fTextEnabled;

		// Token: 0x040000D5 RID: 213
		[NonSerialized]
		protected EMarkerTextPosition fTextPosition;

		// Token: 0x040000D6 RID: 214
		[NonSerialized]
		protected int fTextOffset;

		// Token: 0x040000D7 RID: 215
		[NonSerialized]
		protected Color fTextColor;

		// Token: 0x040000D8 RID: 216
		[NonSerialized]
		protected Font fTextFont;

		// Token: 0x040000D9 RID: 217
		protected bool fToolTipEnabled;

		// Token: 0x040000DA RID: 218
		protected string fToolTipFormat;
	}
}
