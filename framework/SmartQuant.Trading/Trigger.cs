using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using SmartQuant.Charting;
using SmartQuant.Series;

namespace SmartQuant.Trading
{
	// Token: 0x02000053 RID: 83
	public class Trigger : IDrawable, IZoomable
	{
		// Token: 0x06000328 RID: 808 RVA: 0x0000C7F0 File Offset: 0x0000B7F0
		public Trigger(Strategy strategy, TriggerType type, DoubleSeries series, double level, Signal signal)
		{
			this.fStrategy = strategy;
			this.fType = type;
			this.fSeries = series;
			this.fLevel = level;
			this.fSignal = signal;
			this.fStatus = TriggerStatus.Active;
			this.fCreationTime = Clock.Now;
			this.fCompletionTime = DateTime.MinValue;
			this.fStrategy.AddTrigger(this);
			this.Connect();
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000C891 File Offset: 0x0000B891
		public TriggerType Type
		{
			get
			{
				return this.fType;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000C899 File Offset: 0x0000B899
		public TriggerStatus Status
		{
			get
			{
				return this.fStatus;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0000C8A1 File Offset: 0x0000B8A1
		public DoubleSeries Series
		{
			get
			{
				return this.fSeries;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000C8A9 File Offset: 0x0000B8A9
		public double Level
		{
			get
			{
				return this.fLevel;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0000C8B1 File Offset: 0x0000B8B1
		public Signal Signal
		{
			get
			{
				return this.fSignal;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000C8B9 File Offset: 0x0000B8B9
		public DateTime CreationTime
		{
			get
			{
				return this.fCreationTime;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000C8C1 File Offset: 0x0000B8C1
		public DateTime CompletionTime
		{
			get
			{
				return this.fCompletionTime;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000C8C9 File Offset: 0x0000B8C9
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0000C8D1 File Offset: 0x0000B8D1
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000C8DA File Offset: 0x0000B8DA
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0000C8E2 File Offset: 0x0000B8E2
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

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000C8EB File Offset: 0x0000B8EB
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0000C8F3 File Offset: 0x0000B8F3
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000C8FC File Offset: 0x0000B8FC
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000C904 File Offset: 0x0000B904
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

		// Token: 0x06000338 RID: 824 RVA: 0x0000C90D File Offset: 0x0000B90D
		internal void Disconnect()
		{
			this.fSeries.ItemAdded -= this.OnItemAdded;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000C926 File Offset: 0x0000B926
		private void Connect()
		{
			this.fSeries.ItemAdded += this.OnItemAdded;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000C940 File Offset: 0x0000B940
		private void OnItemAdded(object sender, DateTimeEventArgs args)
		{
			DateTime dateTime = args.DateTime;
			switch (this.fType)
			{
			case TriggerType.Above:
				if (this.fSeries[dateTime] > this.fLevel)
				{
					this.Disconnect();
					this.fSignal = new Signal(Clock.Now, this.fSignal.Sender, this.fSignal.Type, this.fSignal.Side, this.fSignal.Qty, this.fSignal.Price, this.fSignal.Instrument, this.fSignal.Text);
					this.fStrategy.EmitSignal(this.fSignal);
					this.Complete(TriggerStatus.Executed);
					return;
				}
				break;
			case TriggerType.Below:
				if (this.fSeries[dateTime] < this.fLevel)
				{
					this.Disconnect();
					this.fSignal = new Signal(Clock.Now, this.fSignal.Sender, this.fSignal.Type, this.fSignal.Side, this.fSignal.Qty, this.fSignal.Price, this.fSignal.Instrument, this.fSignal.Text);
					this.fStrategy.EmitSignal(this.fSignal);
					this.Complete(TriggerStatus.Executed);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000CA8E File Offset: 0x0000BA8E
		private void Complete(TriggerStatus status)
		{
			this.fStatus = status;
			this.fCompletionTime = Clock.Now;
			this.fStrategy.EmitTriggerStatusChanged(this);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000CAB0 File Offset: 0x0000BAB0
		public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			double worldY = this.fLevel;
			int num = Pad.ClientX((double)this.CreationTime.Ticks);
			int num2 = Pad.ClientY(worldY);
			string text = string.Concat(new string[]
			{
				"Trigger - ",
				worldY.ToString("F4"),
				" (",
				this.Status.ToString(),
				")"
			});
			Font font = new Font("Arial", 8f);
			Color color = this.canceledColor;
			switch (this.Status)
			{
			case TriggerStatus.Active:
				color = this.activeColor;
				break;
			case TriggerStatus.Executed:
				color = this.executedColor;
				break;
			}
			Pen pen = new Pen(color, 1f);
			pen.DashStyle = DashStyle.DashDot;
			double val = (double)Pad.ClientX((double)Clock.Now.Ticks);
			double val2 = (double)Pad.ClientX(MinX);
			double val3 = (double)Pad.ClientX(MaxX);
			if (this.Status != TriggerStatus.Active)
			{
				val = (double)Pad.ClientX((double)this.CompletionTime.Ticks);
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
					if (this.fType == TriggerType.Above)
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000CC62 File Offset: 0x0000BC62
		// (set) Token: 0x0600033E RID: 830 RVA: 0x0000CC6A File Offset: 0x0000BC6A
		[Description("Enable or disable tooltip appearance for this marker.")]
		[Category("ToolTip")]
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0000CC73 File Offset: 0x0000BC73
		// (set) Token: 0x06000340 RID: 832 RVA: 0x0000CC7B File Offset: 0x0000BC7B
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

		// Token: 0x06000341 RID: 833 RVA: 0x0000CC84 File Offset: 0x0000BC84
		public TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			double y = this.fLevel;
			tdistance.X = X;
			tdistance.Y = y;
			if (X >= (double)this.CreationTime.Ticks && ((this.Status == TriggerStatus.Active && X <= (double)Clock.Now.Ticks) || X <= (double)this.CompletionTime.Ticks))
			{
				tdistance.dX = 0.0;
			}
			else
			{
				tdistance.dX = double.MaxValue;
			}
			tdistance.dY = Math.Abs(Y - tdistance.Y);
			StringBuilder stringBuilder = new StringBuilder();
			if (this.CreationTime.Second != 0 || this.CreationTime.Minute != 0 || this.CreationTime.Hour != 0)
			{
				stringBuilder.AppendFormat(this.toolTipFormat, new object[]
				{
					this.fStatus.ToString(),
					this.fType.ToString(),
					" Trigger (",
					this.fLevel.ToString(this.Signal.Instrument.PriceDisplay),
					"): ",
					this.fSeries.Name,
					y.ToString(this.Signal.Instrument.PriceDisplay),
					this.CreationTime
				});
			}
			else
			{
				stringBuilder.AppendFormat(this.toolTipFormat, new object[]
				{
					this.fStatus.ToString(),
					this.fType.ToString(),
					" Trigger (",
					this.fLevel.ToString(this.Signal.Instrument.PriceDisplay),
					"): ",
					this.fSeries.Name,
					y.ToString(this.Signal.Instrument.PriceDisplay),
					this.CreationTime.ToShortDateString()
				});
			}
			tdistance.ToolTipText = stringBuilder.ToString();
			return tdistance;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000CEC2 File Offset: 0x0000BEC2
		public void Draw()
		{
			Chart.Pad.Add(this);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000CECF File Offset: 0x0000BECF
		public bool IsPadRangeY()
		{
			return true;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000CED4 File Offset: 0x0000BED4
		public PadRange GetPadRangeY(Pad pad)
		{
			DateTime t = new DateTime((long)pad.XMin);
			DateTime t2 = new DateTime((long)pad.XMax);
			if (t <= this.CompletionTime && t2 >= this.CreationTime)
			{
				double num = this.fLevel;
				return new PadRange(num - double.Epsilon, num + double.Epsilon);
			}
			return new PadRange(0.0, 0.0);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000CF53 File Offset: 0x0000BF53
		public bool IsPadRangeX()
		{
			return false;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000CF56 File Offset: 0x0000BF56
		public PadRange GetPadRangeX(Pad pad)
		{
			return null;
		}

		// Token: 0x04000109 RID: 265
		private Strategy fStrategy;

		// Token: 0x0400010A RID: 266
		private TriggerType fType;

		// Token: 0x0400010B RID: 267
		private TriggerStatus fStatus;

		// Token: 0x0400010C RID: 268
		private DoubleSeries fSeries;

		// Token: 0x0400010D RID: 269
		private double fLevel;

		// Token: 0x0400010E RID: 270
		private Signal fSignal;

		// Token: 0x0400010F RID: 271
		private DateTime fCreationTime;

		// Token: 0x04000110 RID: 272
		private DateTime fCompletionTime;

		// Token: 0x04000111 RID: 273
		private Color activeColor = Color.Brown;

		// Token: 0x04000112 RID: 274
		private Color executedColor = Color.Green;

		// Token: 0x04000113 RID: 275
		private Color canceledColor = Color.DarkGray;

		// Token: 0x04000114 RID: 276
		private bool textEnabled = true;

		// Token: 0x04000115 RID: 277
		private bool toolTipEnabled = true;

		// Token: 0x04000116 RID: 278
		private string toolTipFormat = "{0} {1} {2}{3}{4} {5} {6} {7}";
	}
}
