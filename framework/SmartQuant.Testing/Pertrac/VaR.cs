using System;
using System.Collections;
using System.ComponentModel;
using SmartQuant.Business;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000034 RID: 52
	public class VaR : SeriesTesterItem
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000702A File Offset: 0x0000602A
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00007032 File Offset: 0x00006032
		[Category("Parameters")]
		public double Level
		{
			get
			{
				return this.level;
			}
			set
			{
				this.level = value;
				base.EmitPropertyChanged();
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00007041 File Offset: 0x00006041
		public VaR(string name, SeriesTesterItem parentSeriesItem, double level) : base(name, parentSeriesItem, "VaR - " + parentSeriesItem.Series.Title)
		{
			this.level = level;
			this.sortedSeries = new ArrayList();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00007072 File Offset: 0x00006072
		public VaR(string name) : base(name)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000707C File Offset: 0x0000607C
		protected override double GetValue(DateTime date)
		{
			int index = this.parentSeries.GetIndex(date);
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i <= index; i++)
			{
				DateTime dateTime = this.parentSeries.GetDateTime(i);
				if (!Calendar.IsWeekend(dateTime))
				{
					arrayList.Add(this.parentSeries[dateTime]);
				}
			}
			arrayList.Sort();
			int num = arrayList.Count - (int)(this.level * (double)arrayList.Count / 100.0) - 1;
			if (num > arrayList.Count - 1 || num < 0)
			{
				return double.NaN;
			}
			return (double)arrayList[num];
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00007128 File Offset: 0x00006128
		public override void Reset()
		{
			base.Reset();
			this.sortedSeries = new ArrayList();
		}

		// Token: 0x04000074 RID: 116
		protected double level;

		// Token: 0x04000075 RID: 117
		protected ArrayList sortedSeries;
	}
}
