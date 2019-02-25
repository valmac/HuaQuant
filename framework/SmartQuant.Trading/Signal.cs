using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using SmartQuant.Charting;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Simulation;

namespace SmartQuant.Trading
{
	// Token: 0x02000073 RID: 115
	public class Signal : IDrawable
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x000112A2 File Offset: 0x000102A2
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x000112AA File Offset: 0x000102AA
		public Strategy Strategy
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x000112B3 File Offset: 0x000102B3
		public DateTime DateTime
		{
			get
			{
				return this.fDateTime;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x000112BB File Offset: 0x000102BB
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x000112C3 File Offset: 0x000102C3
		public ComponentType Sender
		{
			get
			{
				return this.fSender;
			}
			set
			{
				this.fSender = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x000112CC File Offset: 0x000102CC
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x000112D4 File Offset: 0x000102D4
		public ComponentType Rejecter
		{
			get
			{
				return this.fRejecter;
			}
			set
			{
				this.fRejecter = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x000112DD File Offset: 0x000102DD
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x000112E5 File Offset: 0x000102E5
		public string RejectReason
		{
			get
			{
				return this.fRejectReason;
			}
			set
			{
				this.fRejectReason = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000112EE File Offset: 0x000102EE
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x000112F6 File Offset: 0x000102F6
		public SignalType Type
		{
			get
			{
				return this.fType;
			}
			set
			{
				this.fType = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x000112FF File Offset: 0x000102FF
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00011307 File Offset: 0x00010307
		public SignalSide Side
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

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00011310 File Offset: 0x00010310
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00011318 File Offset: 0x00010318
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

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00011321 File Offset: 0x00010321
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00011329 File Offset: 0x00010329
		public double StopPrice
		{
			get
			{
				return this.fStopPrice;
			}
			set
			{
				this.fStopPrice = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00011332 File Offset: 0x00010332
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x0001133A File Offset: 0x0001033A
		public double LimitPrice
		{
			get
			{
				return this.fLimitPrice;
			}
			set
			{
				this.fLimitPrice = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00011343 File Offset: 0x00010343
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x0001134B File Offset: 0x0001034B
		public double Qty
		{
			get
			{
				return this.fQty;
			}
			set
			{
				this.fQty = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00011354 File Offset: 0x00010354
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x0001135C File Offset: 0x0001035C
		public TimeInForce TimeInForce
		{
			get
			{
				return this.fTimeInForce;
			}
			set
			{
				this.fTimeInForce = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00011365 File Offset: 0x00010365
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0001136D File Offset: 0x0001036D
		public double StrategyPrice
		{
			get
			{
				return this.fStrategyPrice;
			}
			set
			{
				this.fStrategyPrice = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00011376 File Offset: 0x00010376
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x0001137E File Offset: 0x0001037E
		public bool StrategyFill
		{
			get
			{
				return this.fStrategyFill;
			}
			set
			{
				this.fStrategyFill = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00011387 File Offset: 0x00010387
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x0001138F File Offset: 0x0001038F
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00011398 File Offset: 0x00010398
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x000113A0 File Offset: 0x000103A0
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x000113A9 File Offset: 0x000103A9
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x000113B1 File Offset: 0x000103B1
		public SignalStatus Status
		{
			get
			{
				return this.fStatus;
			}
			set
			{
				this.fStatus = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x000113BA File Offset: 0x000103BA
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x000113C2 File Offset: 0x000103C2
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x000113CB File Offset: 0x000103CB
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x000113D3 File Offset: 0x000103D3
		[Category("Drawing Style")]
		public Color BuyCoverColor
		{
			get
			{
				return this.buyCoverColor;
			}
			set
			{
				this.buyCoverColor = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x000113DC File Offset: 0x000103DC
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x000113E4 File Offset: 0x000103E4
		[Category("Drawing Style")]
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

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x000113ED File Offset: 0x000103ED
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x000113F5 File Offset: 0x000103F5
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

		// Token: 0x060004F5 RID: 1269 RVA: 0x00011400 File Offset: 0x00010400
		public Signal(DateTime datetime, ComponentType sender, SignalType type, SignalSide side, double qty, double strategyPrice, Instrument instrument, string text)
		{
			this.fDateTime = datetime;
			this.fSender = sender;
			this.fType = type;
			this.fSide = side;
			this.fQty = qty;
			this.fStrategyPrice = strategyPrice;
			this.fInstrument = instrument;
			this.fPrice = this.fInstrument.Price();
			this.fTimeInForce = TimeInForce.GTC;
			this.fText = text;
			this.fStrategy = null;
			this.fRejecter = ComponentType.Unknown;
			this.fStopPrice = 0.0;
			this.fLimitPrice = 0.0;
			this.fStatus = SignalStatus.New;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000114DC File Offset: 0x000104DC
		public Signal(DateTime datetime, ComponentType sender, SignalType type, SignalSide side, Instrument instrument, string text) : this(datetime, sender, type, side, 0.0, 0.0, instrument, text)
		{
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001150C File Offset: 0x0001050C
		public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			int num = Pad.ClientX((double)this.DateTime.Ticks);
			int num2 = Pad.ClientY(this.fPrice);
			string.Concat(new string[]
			{
				"Stop at ",
				this.fPrice.ToString("F4"),
				" (",
				this.Status.ToString(),
				")"
			});
			new Font("Arial", 8f);
			Color color = this.buyColor;
			switch (this.Side)
			{
			case SignalSide.Buy:
				color = this.buyColor;
				break;
			case SignalSide.BuyCover:
				color = this.buyCoverColor;
				break;
			case SignalSide.Sell:
				color = this.sellColor;
				break;
			case SignalSide.SellShort:
				color = this.sellShortColor;
				break;
			}
			Pen pen = new Pen(color, 2f);
			int num3 = 8;
			double num4 = (double)Pad.ClientX(MinX);
			double num5 = (double)Pad.ClientX(MaxX);
			if ((double)(num - num3 / 2) <= num5 && (double)(num + num3 / 2) >= num4)
			{
				Pad.Graphics.DrawEllipse(pen, num - num3 / 2, num2 - num3 / 2, num3, num3);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0001163F File Offset: 0x0001063F
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00011647 File Offset: 0x00010647
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00011650 File Offset: 0x00010650
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00011658 File Offset: 0x00010658
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

		// Token: 0x060004FC RID: 1276 RVA: 0x00011664 File Offset: 0x00010664
		public TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			tdistance.X = (double)this.DateTime.Ticks;
			tdistance.Y = this.fPrice;
			tdistance.dX = Math.Abs(X - tdistance.X);
			tdistance.dY = Math.Abs(Y - tdistance.Y);
			StringBuilder stringBuilder = new StringBuilder();
			if (this.DateTime.Second != 0 || this.DateTime.Minute != 0 || this.DateTime.Hour != 0)
			{
				stringBuilder.AppendFormat(this.toolTipFormat, new object[]
				{
					"Signal: ",
					this.Side.ToString(),
					this.Instrument.Symbol,
					this.Price,
					this.DateTime,
					this.Status.ToString()
				});
			}
			else
			{
				stringBuilder.AppendFormat(this.toolTipFormat, new object[]
				{
					"Signal: ",
					this.Side.ToString(),
					this.Instrument.Symbol,
					this.Price,
					this.DateTime.ToShortDateString(),
					this.Status.ToString()
				});
			}
			tdistance.ToolTipText = stringBuilder.ToString();
			return tdistance;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000117F3 File Offset: 0x000107F3
		public void Draw()
		{
			Chart.Pad.Add(this);
		}

		// Token: 0x04000168 RID: 360
		private Strategy fStrategy;

		// Token: 0x04000169 RID: 361
		private DateTime fDateTime;

		// Token: 0x0400016A RID: 362
		private ComponentType fSender;

		// Token: 0x0400016B RID: 363
		private ComponentType fRejecter;

		// Token: 0x0400016C RID: 364
		private string fRejectReason;

		// Token: 0x0400016D RID: 365
		private SignalType fType;

		// Token: 0x0400016E RID: 366
		private SignalSide fSide;

		// Token: 0x0400016F RID: 367
		private double fPrice;

		// Token: 0x04000170 RID: 368
		private double fStopPrice;

		// Token: 0x04000171 RID: 369
		private double fLimitPrice;

		// Token: 0x04000172 RID: 370
		private double fQty;

		// Token: 0x04000173 RID: 371
		private TimeInForce fTimeInForce;

		// Token: 0x04000174 RID: 372
		private bool fStrategyFill;

		// Token: 0x04000175 RID: 373
		private double fStrategyPrice;

		// Token: 0x04000176 RID: 374
		private Instrument fInstrument;

		// Token: 0x04000177 RID: 375
		private string fText;

		// Token: 0x04000178 RID: 376
		private SignalStatus fStatus;

		// Token: 0x04000179 RID: 377
		private Color buyColor = Color.Blue;

		// Token: 0x0400017A RID: 378
		private Color buyCoverColor = Color.SkyBlue;

		// Token: 0x0400017B RID: 379
		private Color sellColor = Color.Pink;

		// Token: 0x0400017C RID: 380
		private Color sellShortColor = Color.Red;

		// Token: 0x0400017D RID: 381
		private bool toolTipEnabled = true;

		// Token: 0x0400017E RID: 382
		private string toolTipFormat = "{0} {1} {2} {3} {4} {5}";

		// Token: 0x0400017F RID: 383
		internal FillOnBarMode FillOnBarMode;

		// Token: 0x04000180 RID: 384
		internal bool ForceFillOnBarMode;

		// Token: 0x04000181 RID: 385
		internal bool ForceMarketOrder;
	}
}
