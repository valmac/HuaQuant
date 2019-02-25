using System;
using SmartQuant.Data;

namespace SmartQuant.Series
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public class DailySeries : BarSeries
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000B950 File Offset: 0x0000A950
		public new Daily First
		{
			get
			{
				if (this.fArray.Count <= 0)
				{
					throw new ApplicationException("Array has no elements");
				}
				return this[0];
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000B972 File Offset: 0x0000A972
		public new Daily Last
		{
			get
			{
				if (this.fArray.Count <= 0)
				{
					return null;
				}
				return this[this.Count - 1];
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000B992 File Offset: 0x0000A992
		public DailySeries(string name, string title) : base(name, title)
		{
			this.fArray = new MemorySeries<Daily>();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000B9A7 File Offset: 0x0000A9A7
		public DailySeries(string name) : this(name, "")
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000B9B5 File Offset: 0x0000A9B5
		public DailySeries() : this("")
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000B9C2 File Offset: 0x0000A9C2
		public new DailySeries Clone()
		{
			return base.Clone() as DailySeries;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000B9CF File Offset: 0x0000A9CF
		public new DailySeries Clone(int index1, int index2)
		{
			return base.Clone(index1, index2) as DailySeries;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000B9DE File Offset: 0x0000A9DE
		public new DailySeries Clone(DateTime dateTime1, DateTime dateTime2)
		{
			return base.Clone(dateTime1, dateTime2) as DailySeries;
		}

		// Token: 0x1700004A RID: 74
		public new Daily this[int index]
		{
			get
			{
				return (Daily)base[index];
			}
		}

		// Token: 0x1700004B RID: 75
		public new Daily this[DateTime date]
		{
			get
			{
				return (Daily)base[date];
			}
		}

		// Token: 0x1700004C RID: 76
		public new Daily this[DateTime date, EIndexOption option]
		{
			get
			{
				return base[date, option] as Daily;
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000BA18 File Offset: 0x0000AA18
		public new DailySeries Shift(int offset)
		{
			DailySeries dailySeries = new DailySeries(base.Name, base.Title);
			int num = 0;
			if (offset < 0)
			{
				num += Math.Abs(offset);
			}
			for (int i = num; i < this.Count; i++)
			{
				int num2 = i + offset;
				if (num2 >= this.Count)
				{
					break;
				}
				DateTime dateTime = this.GetDateTime(num2);
				dailySeries.Add(new Bar(this[i])
				{
					DateTime = dateTime
				});
			}
			return dailySeries;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000BA90 File Offset: 0x0000AA90
		public new Daily Ago(int n)
		{
			int num = this.Count - 1 - n;
			if (num < 0)
			{
				throw new ArgumentException("Can not return daily " + n + " entries ago: daily series is too short.");
			}
			return this[num];
		}
	}
}
