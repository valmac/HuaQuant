using System;
using System.Drawing;
using SmartQuant.Charting;
using SmartQuant.Instruments;
using SmartQuant.Series;

namespace SmartQuant.Testing.RoundTrips
{
	// Token: 0x0200003E RID: 62
	public class RoundTrip : IDrawable
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000BAF3 File Offset: 0x0000AAF3
		public RoundTripStatus Status
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000BAFB File Offset: 0x0000AAFB
		// (set) Token: 0x060001EB RID: 491 RVA: 0x0000BB03 File Offset: 0x0000AB03
		public DateTime EntryDateTime
		{
			get
			{
				return this.entryDateTime;
			}
			set
			{
				this.entryDateTime = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000BB0C File Offset: 0x0000AB0C
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0000BB14 File Offset: 0x0000AB14
		public DateTime ExitDateTime
		{
			get
			{
				return this.exitDateTime;
			}
			set
			{
				this.exitDateTime = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000BB1D File Offset: 0x0000AB1D
		// (set) Token: 0x060001EF RID: 495 RVA: 0x0000BB25 File Offset: 0x0000AB25
		public PositionSide TradePosition
		{
			get
			{
				return this.tradePosition;
			}
			set
			{
				this.tradePosition = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000BB2E File Offset: 0x0000AB2E
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0000BB36 File Offset: 0x0000AB36
		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
			set
			{
				this.instrument = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000BB3F File Offset: 0x0000AB3F
		public double EntryPrice
		{
			get
			{
				return this.entryPrice;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000BB47 File Offset: 0x0000AB47
		public double ExitPrice
		{
			get
			{
				return this.exitPrice;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000BB4F File Offset: 0x0000AB4F
		public double EntryValue
		{
			get
			{
				return this.entryValue;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000BB57 File Offset: 0x0000AB57
		public double ExitValue
		{
			get
			{
				return this.exitValue;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000BB5F File Offset: 0x0000AB5F
		public double Amount
		{
			get
			{
				return this.amount;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000BB67 File Offset: 0x0000AB67
		public double EntryCost
		{
			get
			{
				return this.entryCost;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000BB6F File Offset: 0x0000AB6F
		public double ExitCost
		{
			get
			{
				return this.exitCost;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000BB78 File Offset: 0x0000AB78
		public string DurationToString
		{
			get
			{
				long num = this.exitDateTime.Ticks - this.entryDateTime.Ticks;
				if (num <= 0L)
				{
					return "";
				}
				if ((num + 1L) % 864000000000L == 0L)
				{
					num += 1L;
				}
				string text = "";
				TimeSpan timeSpan = new TimeSpan(num);
				if (timeSpan.Days != 0)
				{
					text = text + timeSpan.Days.ToString() + " Days ";
				}
				if (timeSpan.Hours != 0)
				{
					text = text + timeSpan.Hours.ToString() + " Hours ";
				}
				if (timeSpan.Minutes != 0)
				{
					text = text + timeSpan.Minutes.ToString() + " Minutes";
				}
				return text;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000BC3C File Offset: 0x0000AC3C
		public double RoundTripHighPrice
		{
			get
			{
				return this.roundTripHighPrice;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000BC44 File Offset: 0x0000AC44
		public double RoundTripLowPrice
		{
			get
			{
				return this.roundTripLowPrice;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000BC4C File Offset: 0x0000AC4C
		public double RoundTripResultWithCost
		{
			get
			{
				return this.RoundTripResultWithoutCost - (this.entryCost + this.exitCost);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000BC62 File Offset: 0x0000AC62
		public double RoundTripResultWithoutCost
		{
			get
			{
				if (this.tradePosition == PositionSide.Long)
				{
					return this.exitPrice - this.entryPrice;
				}
				return this.entryPrice - this.exitPrice;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000BC88 File Offset: 0x0000AC88
		public double EntryEfficiency
		{
			get
			{
				if (Math.Abs(this.roundTripHighPrice - this.roundTripLowPrice) < 4.94065645841247E-324)
				{
					return double.NaN;
				}
				if (this.tradePosition == PositionSide.Long)
				{
					return (this.roundTripHighPrice - this.entryPrice) / (this.roundTripHighPrice - this.roundTripLowPrice);
				}
				return (this.entryPrice - this.roundTripLowPrice) / (this.roundTripHighPrice - this.roundTripLowPrice);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000BCFC File Offset: 0x0000ACFC
		public double ExitEfficiency
		{
			get
			{
				if (Math.Abs(this.roundTripHighPrice - this.roundTripLowPrice) < 4.94065645841247E-324)
				{
					return double.NaN;
				}
				if (this.tradePosition == PositionSide.Long)
				{
					return (this.exitPrice - this.roundTripLowPrice) / (this.roundTripHighPrice - this.roundTripLowPrice);
				}
				return (this.roundTripHighPrice - this.exitPrice) / (this.roundTripHighPrice - this.roundTripLowPrice);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000BD70 File Offset: 0x0000AD70
		public double TotalEfficiency
		{
			get
			{
				if (Math.Abs(this.roundTripHighPrice - this.roundTripLowPrice) < 4.94065645841247E-324)
				{
					return double.NaN;
				}
				if (this.tradePosition == PositionSide.Long)
				{
					return (this.exitPrice - this.entryPrice) / (this.roundTripHighPrice - this.roundTripLowPrice);
				}
				return (this.entryPrice - this.exitPrice) / (this.roundTripHighPrice - this.roundTripLowPrice);
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000BDE4 File Offset: 0x0000ADE4
		public RoundTrip(Position Position, Instrument Instrument, PositionSide TradePosition, double Amount, double EntryPrice, double ExitPrice, DateTime EntryDateTime, DateTime ExitDateTime, RoundTripStatus Status)
		{
			this.position = Position;
			this.instrument = Instrument;
			this.tradePosition = TradePosition;
			this.amount = Amount;
			this.entryPrice = EntryPrice;
			this.exitPrice = ExitPrice;
			this.entryDateTime = EntryDateTime;
			this.exitDateTime = ExitDateTime;
			this.entryCost = 0.0;
			this.exitCost = 0.0;
			this.entryValue = EntryPrice * Amount;
			this.exitValue = ExitPrice * Amount;
			this.roundTripLowPrice = EntryPrice;
			this.roundTripHighPrice = EntryPrice;
			this.status = Status;
			if (this.status == RoundTripStatus.Opened)
			{
				this.series = new DoubleSeries();
				this.series.Add(EntryDateTime, this.entryPrice);
				this.Connect();
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000BEAC File Offset: 0x0000AEAC
		public RoundTrip(Position Position, Instrument Instrument, PositionSide TradePosition, double Amount, double EntryPrice, double ExitPrice, DateTime EntryDateTime, DateTime ExitDateTime)
		{
			this.position = Position;
			this.instrument = Instrument;
			this.tradePosition = TradePosition;
			this.amount = Amount;
			this.entryPrice = EntryPrice;
			this.exitPrice = ExitPrice;
			this.entryDateTime = EntryDateTime;
			this.exitDateTime = ExitDateTime;
			this.entryCost = 0.0;
			this.exitCost = 0.0;
			this.entryValue = EntryPrice * Amount;
			this.exitValue = ExitPrice * Amount;
			this.roundTripLowPrice = EntryPrice;
			this.roundTripHighPrice = EntryPrice;
			this.status = RoundTripStatus.Closed;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000BF48 File Offset: 0x0000AF48
		public void Close(DateTime exitDate)
		{
			this.status = RoundTripStatus.Closed;
			this.exitDateTime = exitDate;
			this.exitPrice = this.position.Transactions[1].Price;
			this.roundTripHighPrice = Math.Max(this.roundTripHighPrice, this.exitPrice);
			this.roundTripLowPrice = Math.Min(this.roundTripLowPrice, this.exitPrice);
			this.series.Add(this.exitDateTime, this.exitPrice);
			this.Disconnect();
			this.EmitUpdated();
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000BFD0 File Offset: 0x0000AFD0
		public void Cancel()
		{
			this.status = RoundTripStatus.Canceled;
			this.Disconnect();
			this.EmitUpdated();
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000BFE5 File Offset: 0x0000AFE5
		protected void Connect()
		{
			this.position.ValueChanged += this.position_ValueChanged;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000BFFE File Offset: 0x0000AFFE
		protected void Disconnect()
		{
			this.position.ValueChanged -= this.position_ValueChanged;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000C017 File Offset: 0x0000B017
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0000C01A File Offset: 0x0000B01A
		public string ToolTipFormat
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000C01C File Offset: 0x0000B01C
		public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			Graphics graphics = Pad.Graphics;
			Pen pen = new Pen(Color.Black);
			Pen pen2 = new Pen(Color.Purple, 2f);
			Pen pen3 = new Pen(Color.Blue, 2f);
			Color baseColor;
			Color baseColor2;
			if (this.RoundTripResultWithoutCost > 0.0)
			{
				baseColor = Color.Green;
				baseColor2 = Color.LightGreen;
			}
			else
			{
				baseColor = Color.Red;
				baseColor2 = Color.Pink;
			}
			float num = (float)Pad.ClientX(MinX);
			float num2 = (float)Pad.ClientX(MaxX);
			float num3 = (float)Pad.ClientY(MinY);
			float num4 = (float)Pad.ClientY(MaxY);
			DateTime dateTime = this.EntryDateTime.AddTicks(-(this.ExitDateTime - this.EntryDateTime).Ticks / 4L);
			DateTime dateTime2 = this.ExitDateTime.AddTicks((this.ExitDateTime - this.EntryDateTime).Ticks / 4L);
			float num5 = (float)this.series.GetMax(dateTime, dateTime2);
			float num6 = (float)this.series.GetMin(dateTime, dateTime2);
			float num7 = (num2 - num) / 3f;
			float num8 = (num3 - num4) * 2f / 3f * (float)Math.Abs(this.exitPrice - this.entryPrice) / (num5 - num6);
			float num9 = (num3 - num4) / 10f;
			float num10 = num + (num2 - num) / 2f;
			float num11;
			if (this.entryPrice > this.exitPrice)
			{
				num11 = (float)((double)(num4 + (num3 - num4) / 6f) + (double)((num3 - num4) * 2f / 3f) * ((double)num5 - this.entryPrice) / (double)(num5 - num6)) + num8 / 2f;
			}
			else
			{
				num11 = (float)((double)(num4 + (num3 - num4) / 6f) + (double)((num3 - num4) * 2f / 3f) * ((double)num5 - this.entryPrice) / (double)(num5 - num6)) - num8 / 2f;
			}
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(170, baseColor2)), num10 - num7 / 2f, num11 - num8 / 2f, num7, num8);
			graphics.FillEllipse(new SolidBrush(Color.White), num10 - num7 / 2f, num11 + num8 / 2f - num9 / 2f, num7, num9);
			graphics.FillEllipse(new SolidBrush(Color.White), num10 - num7 / 2f, num11 - num8 / 2f - num9 / 2f, num7, num9);
			graphics.FillEllipse(new SolidBrush(Color.FromArgb(170, baseColor)), num10 - num7 / 2f, num11 + num8 / 2f - num9 / 2f, num7, num9);
			graphics.FillEllipse(new SolidBrush(Color.FromArgb(170, baseColor)), num10 - num7 / 2f, num11 - num8 / 2f - num9 / 2f, num7, num9);
			float num12 = 0f;
			float num13 = 0f;
			int i = 0;
			while (i < this.series.Count)
			{
				float num14 = (float)(this.series.GetDateTime(i) - this.EntryDateTime).Ticks / (float)(this.ExitDateTime - this.EntryDateTime).Ticks * num7 + num10 - num7 / 2f;
				float num15 = (float)(((double)num5 - this.series[i]) / (double)(num5 - num6) * (double)(num3 - num4) * 2.0 / 3.0 + (double)((num3 - num4) / 6f) + (double)num4);
				if (num12 == 0f || num13 == 0f)
				{
					goto IL_683;
				}
				if (this.series.GetDateTime(i) <= this.EntryDateTime || this.series.GetDateTime(i) > this.ExitDateTime)
				{
					graphics.DrawLine(pen3, num14, num15, num12, num13);
					num12 = num14;
					num13 = num15;
				}
				else
				{
					if (num13 > num11 - num8 / 2f && num15 < num11 - num8 / 2f)
					{
						float num16 = num12 + (num14 - num12) * (num13 - num11 + num8 / 2f) / (num13 - num15);
						graphics.DrawLine(pen2, num12, num13, num16, num11 - num8 / 2f);
						graphics.DrawLine(pen3, num16, num11 - num8 / 2f, num14, num15);
						goto IL_683;
					}
					if (num13 < num11 + num8 / 2f && num15 > num11 + num8 / 2f)
					{
						float num17 = num12 + (num14 - num12) * (num11 + num8 / 2f - num13) / (num15 - num13);
						graphics.DrawLine(pen2, num12, num13, num17, num11 + num8 / 2f);
						graphics.DrawLine(pen3, num17, num11 + num8 / 2f, num14, num15);
						goto IL_683;
					}
					if (num13 < num11 - num8 / 2f && num15 > num11 - num8 / 2f)
					{
						float num18 = num12 + (num14 - num12) * (num11 - num8 / 2f - num13) / (num15 - num13);
						graphics.DrawLine(pen3, num12, num13, num18, num11 - num8 / 2f);
						graphics.DrawLine(pen2, num18, num11 - num8 / 2f, num14, num15);
						goto IL_683;
					}
					if (num13 > num11 + num8 / 2f && num15 < num11 + num8 / 2f)
					{
						float num19 = num12 + (num14 - num12) * (num13 - num11 - num8 / 2f) / (num13 - num15);
						graphics.DrawLine(pen3, num12, num13, num19, num11 + num8 / 2f);
						graphics.DrawLine(pen2, num19, num11 + num8 / 2f, num14, num15);
						goto IL_683;
					}
					if ((num13 < num11 - num8 / 2f && num15 < num11 - num8 / 2f) || (num13 > num11 + num8 / 2f && num15 > num11 + num8 / 2f))
					{
						graphics.DrawLine(pen3, num14, num15, num12, num13);
						goto IL_683;
					}
					if (num13 >= num11 - num8 / 2f && num15 >= num11 - num8 / 2f && num13 <= num11 + num8 / 2f && num15 <= num11 + num8 / 2f)
					{
						graphics.DrawLine(pen2, num14, num15, num12, num13);
						goto IL_683;
					}
					graphics.DrawLine(pen3, num14, num15, num12, num13);
					goto IL_683;
				}
				IL_68B:
				i++;
				continue;
				IL_683:
				num12 = num14;
				num13 = num15;
				goto IL_68B;
			}
			graphics.DrawEllipse(pen, num10 - num7 / 2f, num11 + num8 / 2f - num9 / 2f, num7, num9);
			graphics.DrawLine(pen, num10 - num7 / 2f, num11 - num8 / 2f, num10 - num7 / 2f, num11 + num8 / 2f);
			graphics.DrawLine(pen, num10 + num7 / 2f, num11 - num8 / 2f, num10 + num7 / 2f, num11 + num8 / 2f);
			graphics.DrawEllipse(pen, num10 - num7 / 2f, num11 - num8 / 2f - num9 / 2f, num7, num9);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000C786 File Offset: 0x0000B786
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0000C789 File Offset: 0x0000B789
		public bool ToolTipEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000C78B File Offset: 0x0000B78B
		public TDistance Distance(double X, double Y)
		{
			return null;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000C78E File Offset: 0x0000B78E
		public void Draw()
		{
			Chart.Pad.Add(this);
			Chart.Pad.SetRange(0.0, 100.0, 0.0, 100.0);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000C7C9 File Offset: 0x0000B7C9
		private void position_ValueChanged(object sender, EventArgs e)
		{
			this.Update(true);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000C7D2 File Offset: 0x0000B7D2
		public void Update()
		{
			this.Update(false);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000C7DC File Offset: 0x0000B7DC
		public void Update(bool force)
		{
			if (this.exitDateTime != Clock.Now || force)
			{
				this.exitDateTime = Clock.Now;
				this.exitPrice = this.instrument.Price();
				this.roundTripHighPrice = Math.Max(this.roundTripHighPrice, this.exitPrice);
				this.roundTripLowPrice = Math.Min(this.roundTripLowPrice, this.exitPrice);
				this.series.Add(this.exitDateTime, this.exitPrice);
				this.EmitUpdated();
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000C865 File Offset: 0x0000B865
		private void EmitUpdated()
		{
			if (this.Updated != null)
			{
				this.Updated(this, EventArgs.Empty);
			}
		}

		// Token: 0x040000C9 RID: 201
		protected DateTime entryDateTime;

		// Token: 0x040000CA RID: 202
		protected DateTime exitDateTime;

		// Token: 0x040000CB RID: 203
		protected PositionSide tradePosition;

		// Token: 0x040000CC RID: 204
		protected Instrument instrument;

		// Token: 0x040000CD RID: 205
		protected Position position;

		// Token: 0x040000CE RID: 206
		protected double amount;

		// Token: 0x040000CF RID: 207
		protected double entryPrice;

		// Token: 0x040000D0 RID: 208
		protected double exitPrice;

		// Token: 0x040000D1 RID: 209
		protected double entryCost;

		// Token: 0x040000D2 RID: 210
		protected double exitCost;

		// Token: 0x040000D3 RID: 211
		protected double roundTripHighPrice;

		// Token: 0x040000D4 RID: 212
		protected double roundTripLowPrice;

		// Token: 0x040000D5 RID: 213
		protected double entryValue;

		// Token: 0x040000D6 RID: 214
		protected double exitValue;

		// Token: 0x040000D7 RID: 215
		protected RoundTripStatus status;

		// Token: 0x040000D8 RID: 216
		protected DoubleSeries series;

		// Token: 0x040000D9 RID: 217
		public EventHandler Updated;
	}
}
