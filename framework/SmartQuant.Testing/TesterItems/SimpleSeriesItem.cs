using System;
using System.ComponentModel;
using SmartQuant.Series;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x0200004A RID: 74
	public class SimpleSeriesItem : SeriesTesterItem
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000DD37 File Offset: 0x0000CD37
		[Browsable(false)]
		public override SeriesTesterItem ParentComponent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000DD3A File Offset: 0x0000CD3A
		[Browsable(false)]
		public override bool FillSeries
		{
			get
			{
				return this.fillSeries;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000DD42 File Offset: 0x0000CD42
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0000DD4A File Offset: 0x0000CD4A
		[Browsable(false)]
		public override bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0000DD4C File Offset: 0x0000CD4C
		public override double LastValue
		{
			get
			{
				if (this.series.Count > 0)
				{
					return this.series.Last;
				}
				return double.NaN;
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000DD71 File Offset: 0x0000CD71
		public SimpleSeriesItem(string name, DoubleSeries parentSeries)
		{
			this.enabled = true;
			this.parentSeries = parentSeries;
			this.name = name;
			this.series = parentSeries;
			this.fillSeries = true;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000DD9C File Offset: 0x0000CD9C
		public SimpleSeriesItem(string name) : base(name)
		{
			this.enabled = true;
		}
	}
}
