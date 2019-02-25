using System;
using System.Drawing;
using System.Text;
using SmartQuant.Charting;
using SmartQuant.Data;

namespace SmartQuant.Series
{
	// Token: 0x0200000E RID: 14
	public class QuoteArray : DataArray, IDrawable, IZoomable
	{
		// Token: 0x17000031 RID: 49
		public new Quote this[int index]
		{
			get
			{
				return this.fList[index] as Quote;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00007EA8 File Offset: 0x00006EA8
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00007EB0 File Offset: 0x00006EB0
		public Color BidColor
		{
			get
			{
				return this.fBidColor;
			}
			set
			{
				this.fBidColor = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00007EB9 File Offset: 0x00006EB9
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00007EC1 File Offset: 0x00006EC1
		public Color AskColor
		{
			get
			{
				return this.fAskColor;
			}
			set
			{
				this.fAskColor = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00007ECA File Offset: 0x00006ECA
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00007ED2 File Offset: 0x00006ED2
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00007EDB File Offset: 0x00006EDB
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00007EE3 File Offset: 0x00006EE3
		public string ToolTipDateTimeFormat
		{
			get
			{
				return this.fToolTipDateTimeFormat;
			}
			set
			{
				this.fToolTipDateTimeFormat = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00007EEC File Offset: 0x00006EEC
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00007EF4 File Offset: 0x00006EF4
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

		// Token: 0x060001C8 RID: 456 RVA: 0x00007F00 File Offset: 0x00006F00
		public void Paint(Pad pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			Pen pen = new Pen(this.fAskColor);
			Pen pen2 = new Pen(this.fBidColor);
			int num = 0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			int num13 = 0;
			int num14 = 0;
			int num15 = 0;
			int num16 = 0;
			DateTime dateTime = new DateTime((long)MinX);
			DateTime dateTime2 = new DateTime((long)MaxX);
			int num17;
			if (dateTime < base.FirstDateTime)
			{
				num17 = 0;
			}
			else
			{
				num17 = base.GetIndex(dateTime);
			}
			int num18;
			if (dateTime2 > base.LastDateTime)
			{
				num18 = base.Count - 1;
			}
			else
			{
				num18 = base.GetIndex(dateTime2);
			}
			if (num17 < 0 || num18 < 0)
			{
				return;
			}
			for (int i = num17; i <= num18; i++)
			{
				Quote quote = this[i];
				double num19 = (double)quote.DateTime.Ticks;
				double ask = quote.Ask;
				double bid = quote.Bid;
				if (num != 0)
				{
					num5 = pad.ClientX(num2);
					num7 = pad.ClientY(num3);
					num6 = pad.ClientX(num19);
					num8 = pad.ClientY(ask);
					if (ask != 0.0 && num3 != 0.0 && (pad.IsInRange(num19, ask) || pad.IsInRange(num2, num3)) && (num5 != num11 || num6 != num12 || num7 != num13 || num8 != num14))
					{
						pad.Graphics.DrawLine(pen, num5, num7, num6, num8);
					}
					num5 = pad.ClientX(num2);
					num9 = pad.ClientY(num4);
					num6 = pad.ClientX(num19);
					num10 = pad.ClientY(bid);
					if (bid != 0.0 && num4 != 0.0 && (pad.IsInRange(num19, bid) || pad.IsInRange(num2, num4)) && (num5 != num11 || num6 != num12 || num9 != num15 || num10 != num16))
					{
						pad.Graphics.DrawLine(pen2, num5, num9, num6, num10);
					}
				}
				num13 = num7;
				num14 = num8;
				num3 = ask;
				num11 = num5;
				num15 = num9;
				num12 = num6;
				num16 = num10;
				num2 = num19;
				num4 = bid;
				num++;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00008154 File Offset: 0x00007154
		public TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			int index = base.GetIndex(new DateTime((long)X));
			if (index == -1)
			{
				return null;
			}
			Quote quote = this[index];
			double dX = Math.Abs(X - (double)quote.DateTime.Ticks);
			double val = Math.Abs(Y - quote.Ask);
			double val2 = Math.Abs(Y - quote.Bid);
			tdistance.dX = dX;
			tdistance.dY = Math.Min(val, val2);
			tdistance.X = (double)quote.DateTime.Ticks;
			tdistance.Y = Y;
			if (quote != null)
			{
				DateTime dateTime = new DateTime((long)tdistance.X);
				StringBuilder stringBuilder = new StringBuilder();
				this.fToolTipFormat = "{0} {1} {2} = {3}, {4} = {5}";
				stringBuilder.AppendFormat(this.fToolTipFormat, new object[]
				{
					"QuoteArray",
					dateTime.ToString(this.fToolTipDateTimeFormat),
					"Bid",
					quote.Bid,
					"Ask",
					quote.Ask
				});
				tdistance.ToolTipText = stringBuilder.ToString();
				return tdistance;
			}
			return null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00008284 File Offset: 0x00007284
		public void Draw()
		{
			if (Chart.Pad == null)
			{
				new Canvas("QuoteArray", "QuoteArray");
			}
			Chart.Pad.Add(this);
			Chart.Pad.AxisBottom.Type = EAxisType.DateTime;
			Chart.Pad.AxisBottom.LabelFormat = "HH:mm";
			double num = (double)base.FirstDateTime.Ticks;
			double num2 = (double)base.LastDateTime.Ticks;
			double num3 = double.MaxValue;
			double num4 = double.MinValue;
			for (int i = 0; i < base.Count; i++)
			{
				Quote quote = this[i];
				if (Math.Max(quote.Bid, quote.Ask) > num4)
				{
					num4 = Math.Max(quote.Bid, quote.Ask);
				}
				if (Math.Min(quote.Bid, quote.Ask) < num3)
				{
					num3 = Math.Min(quote.Bid, quote.Ask);
				}
			}
			double num5 = num3;
			double num6 = num4;
			Chart.Pad.SetRange(num - (num2 - num) / 20.0, num2 + (num2 - num) / 20.0, num5 - (num6 - num5) / 20.0, num6 + (num6 - num5) / 20.0);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000083D2 File Offset: 0x000073D2
		public bool IsPadRangeY()
		{
			return true;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000083D8 File Offset: 0x000073D8
		public PadRange GetPadRangeY(Pad pad)
		{
			if (base.Count == 0)
			{
				return new PadRange(0.0, 0.0);
			}
			double num = double.MaxValue;
			double num2 = double.MinValue;
			DateTime dateTime = new DateTime((long)pad.XMin);
			DateTime dateTime2 = new DateTime((long)pad.XMax);
			int num3;
			if (dateTime <= base.FirstDateTime)
			{
				num3 = 0;
			}
			else
			{
				num3 = base.GetIndex(dateTime);
			}
			if (num3 == -1)
			{
				return new PadRange(0.0, 0.0);
			}
			int num4;
			if (dateTime2 >= base.LastDateTime)
			{
				num4 = base.Count - 1;
			}
			else
			{
				num4 = base.GetIndex(dateTime2);
			}
			for (int i = num3; i <= num4; i++)
			{
				Quote quote = this[i];
				if (Math.Max(quote.Bid, quote.Ask) > num2)
				{
					num2 = Math.Max(quote.Bid, quote.Ask);
				}
				if (Math.Min(quote.Bid, quote.Ask) < num && quote.Bid != 0.0 && quote.Ask != 0.0)
				{
					num = Math.Min(quote.Bid, quote.Ask);
				}
			}
			return new PadRange(num, num2);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00008531 File Offset: 0x00007531
		public bool IsPadRangeX()
		{
			return false;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00008534 File Offset: 0x00007534
		public PadRange GetPadRangeX(Pad pad)
		{
			return null;
		}

		// Token: 0x04000030 RID: 48
		private bool fToolTipEnabled = true;

		// Token: 0x04000031 RID: 49
		private string fToolTipFormat = "MM/dd/yyyy";

		// Token: 0x04000032 RID: 50
		private string fToolTipDateTimeFormat;

		// Token: 0x04000033 RID: 51
		private Color fBidColor = Color.Red;

		// Token: 0x04000034 RID: 52
		private Color fAskColor = Color.Blue;
	}
}
