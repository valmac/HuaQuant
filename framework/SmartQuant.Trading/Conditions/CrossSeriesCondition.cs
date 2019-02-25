using System;
using SmartQuant.Series;

namespace SmartQuant.Trading.Conditions
{
	// Token: 0x02000081 RID: 129
	public class CrossSeriesCondition : Condition
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00013274 File Offset: 0x00012274
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x0001327C File Offset: 0x0001227C
		public RuleItemList Above
		{
			get
			{
				return this.above;
			}
			set
			{
				this.above = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00013285 File Offset: 0x00012285
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x0001328D File Offset: 0x0001228D
		public RuleItemList Below
		{
			get
			{
				return this.below;
			}
			set
			{
				this.below = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00013296 File Offset: 0x00012296
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x0001329E File Offset: 0x0001229E
		public RuleItemList None
		{
			get
			{
				return this.none;
			}
			set
			{
				this.none = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x000132A7 File Offset: 0x000122A7
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x000132AF File Offset: 0x000122AF
		public DoubleSeries Series1
		{
			get
			{
				return this.series1;
			}
			set
			{
				this.series1 = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x000132B8 File Offset: 0x000122B8
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x000132C0 File Offset: 0x000122C0
		public DoubleSeries Series2
		{
			get
			{
				return this.series2;
			}
			set
			{
				this.series2 = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x000132CC File Offset: 0x000122CC
		public override string Name
		{
			get
			{
				if (this.series1 != null && this.series2 != null)
				{
					return string.Concat(new string[]
					{
						"CrossSeriesCondition(",
						this.series1.Name,
						", ",
						this.series2.Name,
						")"
					});
				}
				return "CrossSeriesCondition(...)";
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00013330 File Offset: 0x00012330
		public override string CodeName
		{
			get
			{
				return this.series1.Name.Replace(" ", "") + "Crosses" + this.series2.Name.Replace(" ", "");
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00013370 File Offset: 0x00012370
		public override string GetInitCode(string name)
		{
			return string.Concat(new string[]
			{
				"CrossSeriesCondition ",
				name,
				" = new CrossSeriesCondition(",
				this.series1.Name.Replace(" ", ""),
				", ",
				this.series2.Name.Replace(" ", ""),
				");"
			});
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000133E8 File Offset: 0x000123E8
		public CrossSeriesCondition(DoubleSeries series1, DoubleSeries series2)
		{
			this.series1 = series1;
			this.series2 = series2;
			this.Init();
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00013404 File Offset: 0x00012404
		public CrossSeriesCondition()
		{
			this.Init();
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00013414 File Offset: 0x00012414
		private void Init()
		{
			this.above = new RuleItemList();
			this.below = new RuleItemList();
			this.none = new RuleItemList();
			this.childs.Add("Above", this.above);
			this.childs.Add("Below", this.below);
			this.childs.Add("None", this.none);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00013484 File Offset: 0x00012484
		public override void Execute()
		{
			if (this.series1.Count == 0 || this.series2.Count == 0)
			{
				this.none.Execute();
				return;
			}
			switch (this.series1.Crosses(this.series2, this.series1.LastDateTime))
			{
			case ECross.Above:
				this.above.Execute();
				return;
			case ECross.Below:
				this.below.Execute();
				return;
			case ECross.None:
				this.none.Execute();
				return;
			default:
				return;
			}
		}

		// Token: 0x04000196 RID: 406
		private DoubleSeries series1;

		// Token: 0x04000197 RID: 407
		private DoubleSeries series2;

		// Token: 0x04000198 RID: 408
		private RuleItemList above;

		// Token: 0x04000199 RID: 409
		private RuleItemList below;

		// Token: 0x0400019A RID: 410
		private RuleItemList none;
	}
}
