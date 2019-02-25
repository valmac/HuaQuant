using System;
using System.Drawing;
using System.Text;
using SmartQuant.Charting;
using SmartQuant.Data;

namespace SmartQuant.Series
{
	// Token: 0x0200000D RID: 13
	public class TradeArray : DataArray, IDrawable, IZoomable
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x00007809 File Offset: 0x00006809
		public TradeArray()
		{
			this.fToolTipEnabled = true;
			this.fToolTipFormat = "{0}\n{2} - {3:F2}";
			this.fToolTipDateTimeFormat = "MM/dd/yyyy";
			this.fColor = Color.Black;
		}

		// Token: 0x1700002C RID: 44
		public new Trade this[int index]
		{
			get
			{
				return this.fList[index] as Trade;
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000784C File Offset: 0x0000684C
		public double GetMinPrice()
		{
			if (base.Count == 0)
			{
				return 0.0;
			}
			double num = double.MaxValue;
			foreach (object obj in this)
			{
				Trade trade = (Trade)obj;
				if (trade.Price < num)
				{
					num = trade.Price;
				}
			}
			return num;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000078C8 File Offset: 0x000068C8
		public double GetMaxPrice()
		{
			if (base.Count == 0)
			{
				return 0.0;
			}
			double num = double.MinValue;
			foreach (object obj in this)
			{
				Trade trade = (Trade)obj;
				if (trade.Price > num)
				{
					num = trade.Price;
				}
			}
			return num;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00007944 File Offset: 0x00006944
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0000794C File Offset: 0x0000694C
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00007955 File Offset: 0x00006955
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0000795D File Offset: 0x0000695D
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00007966 File Offset: 0x00006966
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0000796E File Offset: 0x0000696E
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

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00007977 File Offset: 0x00006977
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0000797F File Offset: 0x0000697F
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

		// Token: 0x060001B5 RID: 437 RVA: 0x00007988 File Offset: 0x00006988
		public void Paint(Pad pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			Pen pen = new Pen(this.fColor);
			int num = 0;
			double num2 = 0.0;
			double num3 = 0.0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			DateTime dateTime = new DateTime((long)MinX);
			DateTime dateTime2 = new DateTime((long)MaxX);
			int num12;
			if (dateTime < base.FirstDateTime)
			{
				num12 = 0;
			}
			else
			{
				num12 = base.GetIndex(dateTime);
			}
			int num13;
			if (dateTime2 > base.LastDateTime)
			{
				num13 = base.Count - 1;
			}
			else
			{
				num13 = base.GetIndex(dateTime2);
			}
			if (num12 < 0 || num13 < 0)
			{
				return;
			}
			for (int i = num12; i <= num13; i++)
			{
				Trade trade = this[i];
				double num14 = (double)trade.DateTime.Ticks;
				double price = trade.Price;
				if (num != 0 && price != 0.0 && num3 != 0.0)
				{
					num4 = pad.ClientX(num2);
					num6 = pad.ClientY(num3);
					num5 = pad.ClientX(num14);
					num7 = pad.ClientY(price);
					if ((pad.IsInRange(num14, price) || pad.IsInRange(num2, num3)) && (num4 != num8 || num5 != num9 || num6 != num10 || num7 != num11))
					{
						pad.Graphics.DrawLine(pen, num4, num6, num5, num7);
					}
				}
				num8 = num4;
				num10 = num6;
				num9 = num5;
				num11 = num7;
				num2 = num14;
				num3 = price;
				num++;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00007B10 File Offset: 0x00006B10
		public TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			foreach (object obj in this)
			{
				Trade trade = (Trade)obj;
				double num = Math.Abs(X - (double)trade.DateTime.Ticks);
				double num2 = Math.Abs(Y - trade.Price);
				if (num < tdistance.dX && num2 < tdistance.dY)
				{
					tdistance.dX = num;
					tdistance.dY = num2;
					tdistance.X = (double)trade.DateTime.Ticks;
					tdistance.Y = trade.Price;
				}
			}
			if (tdistance.dX != 1.7976931348623157E+308 && tdistance.dY != 1.7976931348623157E+308)
			{
				DateTime dateTime = new DateTime((long)tdistance.X);
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat(this.fToolTipFormat, new object[]
				{
					"TradeArray",
					"TradeArray",
					dateTime.ToString(this.fToolTipDateTimeFormat),
					tdistance.Y
				});
				tdistance.ToolTipText = stringBuilder.ToString();
				return tdistance;
			}
			return null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00007C64 File Offset: 0x00006C64
		public void Draw()
		{
			if (Chart.Pad == null)
			{
				new Canvas("TradeArray", "TradeArray");
			}
			Chart.Pad.Add(this);
			Chart.Pad.AxisBottom.Type = EAxisType.DateTime;
			Chart.Pad.AxisBottom.LabelFormat = "HH:mm";
			double num = (double)base.FirstDateTime.Ticks;
			double num2 = (double)base.LastDateTime.Ticks;
			double minPrice = this.GetMinPrice();
			double maxPrice = this.GetMaxPrice();
			Chart.Pad.SetRange(num - (num2 - num) / 20.0, num2 + (num2 - num) / 20.0, minPrice - (maxPrice - minPrice) / 20.0, maxPrice + (maxPrice - minPrice) / 20.0);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00007D2D File Offset: 0x00006D2D
		public bool IsPadRangeY()
		{
			return true;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00007D30 File Offset: 0x00006D30
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
			if (base.Count > 0)
			{
				int num3;
				if (dateTime <= base.FirstDateTime)
				{
					num3 = 0;
				}
				else
				{
					num3 = base.GetIndex(dateTime);
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
				if (num3 == -1)
				{
					return new PadRange(0.0, 0.0);
				}
				for (int i = num3; i < num4; i++)
				{
					Trade trade = this[i];
					if (trade.Price > num2 && trade.Price != 0.0)
					{
						num2 = trade.Price;
					}
					if (trade.Price < num && trade.Price != 0.0)
					{
						num = trade.Price;
					}
				}
			}
			return new PadRange(num, num2);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00007E5F File Offset: 0x00006E5F
		public bool IsPadRangeX()
		{
			return false;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00007E62 File Offset: 0x00006E62
		public PadRange GetPadRangeX(Pad pad)
		{
			return null;
		}

		// Token: 0x0400002C RID: 44
		private bool fToolTipEnabled;

		// Token: 0x0400002D RID: 45
		private string fToolTipFormat;

		// Token: 0x0400002E RID: 46
		private string fToolTipDateTimeFormat;

		// Token: 0x0400002F RID: 47
		private Color fColor;
	}
}
