using System;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200003E RID: 62
	public class PointAndFigure : PnFSeries
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0000DF43 File Offset: 0x0000CF43
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0000DF4B File Offset: 0x0000CF4B
		public double BoxSize
		{
			get
			{
				return this.boxSize;
			}
			set
			{
				this.boxSize = value;
				this.Recalculate();
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000DF5A File Offset: 0x0000CF5A
		// (set) Token: 0x0600031A RID: 794 RVA: 0x0000DF62 File Offset: 0x0000CF62
		public int ReversalSize
		{
			get
			{
				return this.reversalSize;
			}
			set
			{
				this.reversalSize = value;
				this.Recalculate();
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000DF74 File Offset: 0x0000CF74
		private void Recalculate()
		{
			this.Clear();
			this.volume = 0L;
			this.min = 0.0;
			this.max = 0.0;
			this.realMin = double.MaxValue;
			this.realMax = double.MinValue;
			this.firstAdded = false;
			this.firstDateTime = DateTime.MaxValue;
			for (int i = 0; i < this.barSeries.Count; i++)
			{
				this.Calculate(this.barSeries[i]);
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000E008 File Offset: 0x0000D008
		public PointAndFigure(BarSeries barSeries, double boxSize, int reversalSize)
		{
			this.barSeries = barSeries;
			base.Name = barSeries.Name;
			this.boxSize = boxSize;
			this.reversalSize = reversalSize;
			barSeries.ItemAdded += this.barArray_ItemAdded;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000E078 File Offset: 0x0000D078
		private void Calculate(Bar bar)
		{
			this.volume += bar.Volume;
			if (!this.firstAdded)
			{
				if (this.firstDateTime == DateTime.MaxValue)
				{
					this.firstDateTime = bar.DateTime;
				}
				if (this.realMin > bar.Low)
				{
					this.min = Math.Floor(bar.Low / this.boxSize) * this.boxSize;
				}
				if (this.realMax < bar.High)
				{
					this.max = Math.Ceiling(bar.High / this.boxSize) * this.boxSize;
				}
				bool flag = false;
				if (this.realMin > bar.Low)
				{
					this.realMin = bar.Low;
					base.Add(new PnF(this.boxSize, this.firstDateTime, bar.EndTime, this.max, this.max, this.min, this.min, this.volume, 1L));
					flag = true;
				}
				else if (this.realMax < bar.High)
				{
					this.realMax = bar.High;
					base.Add(new PnF(this.boxSize, this.firstDateTime, bar.EndTime, this.min, this.max, this.min, this.max, this.volume, 1L));
					flag = false;
				}
				if (this.max - this.min >= this.boxSize)
				{
					if (flag)
					{
						base.Add(new PnF(this.boxSize, this.firstDateTime, bar.EndTime, this.max, this.max, this.min, this.min, this.volume, 1L));
						this.firstAdded = true;
						this.volume = 0L;
						this.state = PnFKind.Down;
					}
					else
					{
						base.Add(new PnF(this.boxSize, this.firstDateTime, bar.EndTime, this.min, this.max, this.min, this.max, this.volume, 1L));
						this.firstAdded = true;
						this.volume = 0L;
						this.state = PnFKind.Up;
					}
					this.realMin = double.MaxValue;
					this.realMax = double.MinValue;
					return;
				}
			}
			else
			{
				if (this.realMax == -1.7976931348623157E+308 && this.realMin == 1.7976931348623157E+308)
				{
					this.firstDateTime = bar.BeginTime;
				}
				this.realMin = Math.Min(this.realMin, bar.Low);
				this.realMax = Math.Max(this.realMax, bar.High);
				if (this.state == PnFKind.Up)
				{
					if (this.realMax >= this.max)
					{
						this.max = Math.Ceiling(this.realMax / this.boxSize) * this.boxSize;
						base.Add(new PnF(this.boxSize, base.Last.BeginTime, bar.EndTime, this.min, this.max, this.min, this.max, this.volume, 1L));
					}
					if (this.realMin < this.max - this.boxSize * (double)this.reversalSize)
					{
						this.state = PnFKind.Down;
						this.max -= this.boxSize;
						this.min = Math.Floor(this.realMin / this.boxSize) * this.boxSize;
						if (this.max == this.min)
						{
							Console.WriteLine("szd");
						}
						this.realMin = double.MaxValue;
						this.realMax = double.MinValue;
						if (this.max == this.min)
						{
							Console.WriteLine("szd");
						}
						base.Add(new PnF(this.boxSize, this.firstDateTime, bar.EndTime, this.max, this.max, this.min, this.min, this.volume, 1L));
						this.volume = 0L;
						return;
					}
				}
				else
				{
					if (this.realMin <= this.min)
					{
						this.min = Math.Floor(this.realMin / this.boxSize) * this.boxSize;
						base.Add(new PnF(this.boxSize, base.Last.BeginTime, bar.EndTime, this.max, this.max, this.min, this.min, this.volume, 1L));
					}
					if (this.realMax > this.min + this.boxSize * (double)this.reversalSize)
					{
						this.state = PnFKind.Up;
						this.min += this.boxSize;
						this.max = Math.Ceiling(this.realMax / this.boxSize) * this.boxSize;
						if (this.max == this.min)
						{
							Console.WriteLine("szd");
						}
						this.realMin = double.MaxValue;
						this.realMax = double.MinValue;
						base.Add(new PnF(this.boxSize, this.firstDateTime, bar.EndTime, this.min, this.max, this.min, this.max, this.volume, 1L));
						this.volume = 0L;
					}
				}
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000E5BC File Offset: 0x0000D5BC
		public void Calculate()
		{
			foreach (object obj in this.barSeries)
			{
				Bar bar = (Bar)obj;
				this.Calculate(bar);
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000E618 File Offset: 0x0000D618
		private void barArray_ItemAdded(object sender, DateTimeEventArgs e)
		{
			this.Calculate(this.barSeries[e.DateTime]);
		}

		// Token: 0x04000095 RID: 149
		private BarSeries barSeries;

		// Token: 0x04000096 RID: 150
		private long volume;

		// Token: 0x04000097 RID: 151
		private double boxSize;

		// Token: 0x04000098 RID: 152
		private int reversalSize;

		// Token: 0x04000099 RID: 153
		private DateTime firstDateTime = DateTime.MaxValue;

		// Token: 0x0400009A RID: 154
		public PnFKind state;

		// Token: 0x0400009B RID: 155
		private double min;

		// Token: 0x0400009C RID: 156
		private double max;

		// Token: 0x0400009D RID: 157
		private double realMin = double.MaxValue;

		// Token: 0x0400009E RID: 158
		private double realMax = double.MinValue;

		// Token: 0x0400009F RID: 159
		private bool firstAdded;
	}
}
