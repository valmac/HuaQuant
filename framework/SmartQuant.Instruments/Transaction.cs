using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using SmartQuant.Charting;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
	// Token: 0x0200001F RID: 31
	public class Transaction : IComparable, IDrawable, ICloneable
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00006C16 File Offset: 0x00005C16
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00006C1E File Offset: 0x00005C1E
		internal int Id
		{
			get
			{
				return this.fId;
			}
			set
			{
				this.fId = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00006C27 File Offset: 0x00005C27
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00006C2F File Offset: 0x00005C2F
		[Category("Order")]
		[ReadOnly(true)]
		[Description("")]
		public string ClOrdID
		{
			get
			{
				return this.fClOrdID;
			}
			set
			{
				this.fClOrdID = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00006C38 File Offset: 0x00005C38
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00006C40 File Offset: 0x00005C40
		[Description("")]
		[Category("Order")]
		[ReadOnly(true)]
		public int ReportId
		{
			get
			{
				return this.fReportId;
			}
			set
			{
				this.fReportId = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00006C49 File Offset: 0x00005C49
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00006C51 File Offset: 0x00005C51
		[Category("Transaction")]
		[Description("")]
		[ReadOnly(true)]
		public DateTime DateTime
		{
			get
			{
				return this.fDateTime;
			}
			set
			{
				this.fDateTime = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00006C5A File Offset: 0x00005C5A
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00006C62 File Offset: 0x00005C62
		[Category("Transaction")]
		[Description("")]
		public Instrument Instrument
		{
			get
			{
				return this.fInstrument;
			}
			set
			{
				this.fInstrument = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00006C6B File Offset: 0x00005C6B
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00006C73 File Offset: 0x00005C73
		[Description("")]
		[ReadOnly(true)]
		[Category("Transaction")]
		public Side Side
		{
			get
			{
				return this.fSide;
			}
			set
			{
				this.fSide = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00006C7C File Offset: 0x00005C7C
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00006C84 File Offset: 0x00005C84
		[ReadOnly(true)]
		[Category("Transaction")]
		[Description("")]
		public double Price
		{
			get
			{
				return this.fPrice;
			}
			set
			{
				this.fPrice = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00006C8D File Offset: 0x00005C8D
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00006C95 File Offset: 0x00005C95
		[Description("")]
		[ReadOnly(true)]
		[Category("Transaction")]
		public double Qty
		{
			get
			{
				return this.fQty;
			}
			set
			{
				this.fQty = Math.Abs(value);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00006CA4 File Offset: 0x00005CA4
		[Description("")]
		[Category("Transaction")]
		public double Amount
		{
			get
			{
				switch (this.fSide)
				{
				case Side.Buy:
				case Side.BuyMinus:
					return this.Qty;
				case Side.Sell:
				case Side.SellPlus:
				case Side.SellShort:
				case Side.SellShortExempt:
					return -this.Qty;
				default:
					throw new NotSupportedException("Tansaction side is not spported : " + this.fSide);
				}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00006D03 File Offset: 0x00005D03
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00006D0B File Offset: 0x00005D0B
		[Category("Transaction")]
		[Description("")]
		public Currency Currency
		{
			get
			{
				return this.fCurrency;
			}
			set
			{
				this.fCurrency = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00006D14 File Offset: 0x00005D14
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00006D1C File Offset: 0x00005D1C
		[Browsable(false)]
		public TransactionCost TransactionCost
		{
			get
			{
				return this.fTransactionCost;
			}
			set
			{
				this.fTransactionCost = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00006D25 File Offset: 0x00005D25
		[Description("")]
		[Category("Transaction")]
		public double Cost
		{
			get
			{
				if (this.fTransactionCost == null)
				{
					return 0.0;
				}
				return this.fTransactionCost.GetCost(this);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00006D45 File Offset: 0x00005D45
		[Category("Value")]
		[Description("")]
		public virtual double Value
		{
			get
			{
				if (this.fInstrument.Factor != 0.0)
				{
					return this.fPrice * this.fQty * this.fInstrument.Factor;
				}
				return this.fPrice * this.fQty;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00006D84 File Offset: 0x00005D84
		[Category("Value")]
		[Description("")]
		public virtual double NetCashFlow
		{
			get
			{
				if (this.fInstrument.Factor != 0.0)
				{
					return -(this.Amount * this.fPrice * this.fInstrument.Factor);
				}
				return -(this.Amount * this.fPrice);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00006DD0 File Offset: 0x00005DD0
		[Category("Value")]
		[Description("")]
		public virtual double CashFlow
		{
			get
			{
				return this.NetCashFlow - this.Cost;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00006DDF File Offset: 0x00005DDF
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00006DE7 File Offset: 0x00005DE7
		[ReadOnly(true)]
		public string Strategy
		{
			get
			{
				return this.fStrategy;
			}
			set
			{
				this.fStrategy = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00006DF0 File Offset: 0x00005DF0
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00006DF8 File Offset: 0x00005DF8
		[Description("")]
		[Category("Text")]
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00006E01 File Offset: 0x00005E01
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00006E09 File Offset: 0x00005E09
		[Browsable(false)]
		[Category("Drawing Style")]
		public Color BuyColor
		{
			get
			{
				return this.buyColor;
			}
			set
			{
				this.buyColor = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00006E12 File Offset: 0x00005E12
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00006E1A File Offset: 0x00005E1A
		[Category("Drawing Style")]
		[Browsable(false)]
		public Color SellColor
		{
			get
			{
				return this.sellColor;
			}
			set
			{
				this.sellColor = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00006E23 File Offset: 0x00005E23
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00006E2B File Offset: 0x00005E2B
		[Browsable(false)]
		[Category("Drawing Style")]
		public Color SellShortColor
		{
			get
			{
				return this.sellShortColor;
			}
			set
			{
				this.sellShortColor = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00006E34 File Offset: 0x00005E34
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00006E3C File Offset: 0x00005E3C
		[Category("Drawing Style")]
		[Browsable(false)]
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00006E45 File Offset: 0x00005E45
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00006E4D File Offset: 0x00005E4D
		[Description("")]
		[ReadOnly(true)]
		[Category("Transaction")]
		public double PnL
		{
			get
			{
				return this.fPnL;
			}
			internal set
			{
				this.fPnL = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00006E56 File Offset: 0x00005E56
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00006E5E File Offset: 0x00005E5E
		[Description("")]
		[Category("Transaction")]
		[ReadOnly(true)]
		public double RealizedPnL
		{
			get
			{
				return this.fRealizedPnL;
			}
			internal set
			{
				this.fRealizedPnL = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00006E67 File Offset: 0x00005E67
		[Description("Transaction margin")]
		[ReadOnly(true)]
		[Category("Margin")]
		public double Margin
		{
			get
			{
				return this.fInstrument.Margin * this.fQty;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00006E7C File Offset: 0x00005E7C
		[ReadOnly(true)]
		[Description("Transaction debt")]
		[Category("Margin")]
		public double Debt
		{
			get
			{
				double num = this.fInstrument.Margin * this.fQty;
				if (num == 0.0)
				{
					return 0.0;
				}
				return this.Value - num;
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00006EBC File Offset: 0x00005EBC
		public Transaction()
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00006F3C File Offset: 0x00005F3C
		public Transaction(DateTime dateTime, Side side, double qty, Instrument instrument, double price)
		{
			this.fDateTime = dateTime;
			this.fInstrument = instrument;
			this.fSide = side;
			this.fPrice = price;
			this.fQty = Math.Abs(qty);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00006FE6 File Offset: 0x00005FE6
		public Transaction(DateTime dateTime, Side side, double qty, Instrument instrument, double price, double commission, CommType commType) : this(dateTime, side, qty, instrument, price)
		{
			this.fTransactionCost.Commission = commission;
			this.fTransactionCost.CommType = commType;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000700F File Offset: 0x0000600F
		public void Draw(string option)
		{
			if (option.IndexOf("t") != -1)
			{
				this.textEnabled = true;
			}
			if (Chart.Pad == null)
			{
				new Canvas("Canvas", "Canvas");
			}
			Chart.Pad.Add(this);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00007048 File Offset: 0x00006048
		public void Draw()
		{
			this.Draw("T");
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00007058 File Offset: 0x00006058
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				this.fDateTime,
				" ",
				this.fSide.ToString(),
				" ",
				this.fQty,
				" ",
				this.fInstrument.Symbol,
				" @",
				this.fPrice
			});
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000070E0 File Offset: 0x000060E0
		public int CompareTo(object obj)
		{
			Transaction transaction = obj as Transaction;
			if (this.fDateTime > transaction.DateTime)
			{
				return 1;
			}
			if (this.fDateTime < transaction.DateTime)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000711F File Offset: 0x0000611F
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00007127 File Offset: 0x00006127
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

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00007130 File Offset: 0x00006130
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00007138 File Offset: 0x00006138
		[Category("ToolTip")]
		[Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
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

		// Token: 0x06000216 RID: 534 RVA: 0x00007144 File Offset: 0x00006144
		public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			if ((double)this.DateTime.Ticks > MaxX || (double)this.DateTime.Ticks < MinX)
			{
				return;
			}
			int num = Pad.ClientX((double)this.DateTime.Ticks);
			int num2 = Pad.ClientY(this.Price);
			float num3 = 12f;
			string text = string.Concat(new object[]
			{
				this.Side.ToString(),
				" ",
				this.Qty,
				" ",
				this.Instrument.Symbol,
				" @ ",
				this.Price.ToString("F2")
			});
			Font font = new Font("Arial", 8f);
			switch (this.Side)
			{
			case Side.Buy:
			{
				Color color = this.buyColor;
				Point p = new Point(num, num2);
				Point p2 = new Point((int)((float)num - num3 / 2f), (int)((float)num2 + num3 / 2f));
				Point p3 = new Point((int)((float)num + num3 / 2f), (int)((float)num2 + num3 / 2f));
				PointF[] points = new PointF[]
				{
					p,
					p2,
					p3
				};
				Pad.Graphics.DrawPolygon(new Pen(Color.Black), points);
				Pad.Graphics.DrawRectangle(new Pen(Color.Black), (float)num - num3 / 4f, (float)num2 + num3 / 2f, num3 / 2f, num3 / 2f);
				Pad.Graphics.FillPolygon(new SolidBrush(color), points);
				Pad.Graphics.FillRectangle(new SolidBrush(color), (float)num - num3 / 4f, (float)num2 + num3 / 2f - 1f, num3 / 2f, num3 / 2f + 1f);
				break;
			}
			case Side.Sell:
			{
				Color color = this.sellColor;
				Point point = new Point(num, num2);
				Point point2 = new Point((int)((float)num - num3 / 2f), (int)((float)num2 - num3 / 2f));
				Point point3 = new Point((int)((float)num + num3 / 2f), (int)((float)num2 - num3 / 2f));
				Point[] points2 = new Point[]
				{
					point,
					point2,
					point3
				};
				Pad.Graphics.DrawPolygon(new Pen(Color.Black), points2);
				Pad.Graphics.DrawRectangle(new Pen(Color.Black), (float)num - num3 / 4f, (float)num2 - num3, num3 / 2f, num3 / 2f + 1f);
				Pad.Graphics.FillPolygon(new SolidBrush(color), points2);
				Pad.Graphics.FillRectangle(new SolidBrush(color), (float)num - num3 / 4f, (float)num2 - num3, num3 / 2f, num3 / 2f + 1f);
				break;
			}
			case Side.SellShort:
			{
				Color color = this.sellShortColor;
				Point point4 = new Point(num, num2);
				Point point5 = new Point((int)((float)num - num3 / 2f), (int)((float)num2 - num3 / 2f));
				Point point6 = new Point((int)((float)num + num3 / 2f), (int)((float)num2 - num3 / 2f));
				Point[] points3 = new Point[]
				{
					point4,
					point5,
					point6
				};
				Pad.Graphics.DrawPolygon(new Pen(Color.Black), points3);
				Pad.Graphics.DrawRectangle(new Pen(Color.Black), (float)num - num3 / 4f, (float)num2 - num3, num3 / 2f, num3 / 2f + 1f);
				Pad.Graphics.FillPolygon(new SolidBrush(color), points3);
				Pad.Graphics.FillRectangle(new SolidBrush(color), (float)num - num3 / 4f, (float)num2 - num3, num3 / 2f, num3 / 2f + 1f);
				break;
			}
			}
			if (this.textEnabled)
			{
				int num4 = (int)Pad.Graphics.MeasureString(text, font).Width;
				int num5 = (int)Pad.Graphics.MeasureString(text, font).Height;
				switch (this.Side)
				{
				case Side.Buy:
					Pad.Graphics.DrawString(text, font, new SolidBrush(Color.Black), (float)(num - num4 / 2), (float)num2 + num3 + 2f);
					return;
				case Side.Sell:
					Pad.Graphics.DrawString(text, font, new SolidBrush(Color.Black), (float)(num - num4 / 2), (float)num2 - num3 - 2f - (float)num5);
					return;
				case Side.BuyMinus:
				case Side.SellPlus:
					break;
				case Side.SellShort:
					Pad.Graphics.DrawString(text, font, new SolidBrush(Color.Black), (float)(num - num4 / 2), (float)num2 + num3 + 2f);
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000076AC File Offset: 0x000066AC
		public TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			tdistance.X = (double)this.DateTime.Ticks;
			tdistance.Y = this.Price;
			tdistance.dX = Math.Abs(X - tdistance.X);
			tdistance.dY = Math.Abs(Y - tdistance.Y);
			StringBuilder stringBuilder = new StringBuilder();
			if (this.DateTime.Second != 0 || this.DateTime.Minute != 0 || this.DateTime.Hour != 0)
			{
				stringBuilder.AppendFormat(this.toolTipFormat, new object[]
				{
					this.Side.ToString(),
					this.Instrument.Symbol,
					this.Qty,
					this.Price,
					this.DateTime
				});
			}
			else
			{
				stringBuilder.AppendFormat(this.toolTipFormat, new object[]
				{
					this.Side.ToString(),
					this.Instrument.Symbol,
					this.Qty,
					this.Price,
					this.DateTime.ToShortDateString()
				});
			}
			tdistance.ToolTipText = stringBuilder.ToString();
			return tdistance;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000781F File Offset: 0x0000681F
		public object Clone()
		{
			return null;
		}

		// Token: 0x04000079 RID: 121
		private int fId = -1;

		// Token: 0x0400007A RID: 122
		private string fClOrdID = "";

		// Token: 0x0400007B RID: 123
		private int fReportId = -1;

		// Token: 0x0400007C RID: 124
		private DateTime fDateTime;

		// Token: 0x0400007D RID: 125
		private Instrument fInstrument;

		// Token: 0x0400007E RID: 126
		private Side fSide;

		// Token: 0x0400007F RID: 127
		private double fPrice;

		// Token: 0x04000080 RID: 128
		private double fQty;

		// Token: 0x04000081 RID: 129
		private string fText = "";

		// Token: 0x04000082 RID: 130
		private Currency fCurrency = CurrencyManager.DefaultCurrency;

		// Token: 0x04000083 RID: 131
		private TransactionCost fTransactionCost = new TransactionCost();

		// Token: 0x04000084 RID: 132
		private double fPnL;

		// Token: 0x04000085 RID: 133
		private double fRealizedPnL;

		// Token: 0x04000086 RID: 134
		private string fStrategy;

		// Token: 0x04000087 RID: 135
		private bool toolTipEnabled = true;

		// Token: 0x04000088 RID: 136
		private string toolTipFormat = "{0} {2} {1} @ {3} {4}";

		// Token: 0x04000089 RID: 137
		private Color buyColor = Color.Blue;

		// Token: 0x0400008A RID: 138
		private Color sellColor = Color.Red;

		// Token: 0x0400008B RID: 139
		private Color sellShortColor = Color.Yellow;

		// Token: 0x0400008C RID: 140
		private bool textEnabled;
	}
}
