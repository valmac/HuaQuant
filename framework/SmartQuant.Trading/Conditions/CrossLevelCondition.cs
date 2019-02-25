using System;
using SmartQuant.Series;

namespace SmartQuant.Trading.Conditions
{
	// Token: 0x0200002C RID: 44
	public class CrossLevelCondition : Condition
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00006709 File Offset: 0x00005709
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00006711 File Offset: 0x00005711
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000671A File Offset: 0x0000571A
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00006722 File Offset: 0x00005722
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000672B File Offset: 0x0000572B
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00006733 File Offset: 0x00005733
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000673C File Offset: 0x0000573C
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00006744 File Offset: 0x00005744
		public DoubleSeries Series
		{
			get
			{
				return this.series;
			}
			set
			{
				this.series = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000674D File Offset: 0x0000574D
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00006755 File Offset: 0x00005755
		public double Level
		{
			get
			{
				return this.level;
			}
			set
			{
				this.level = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00006760 File Offset: 0x00005760
		public override string Name
		{
			get
			{
				if (this.series != null)
				{
					return string.Concat(new string[]
					{
						"CrossLevelCondition(",
						this.series.Name,
						", ",
						this.level.ToString(),
						")"
					});
				}
				return "CrossLevelCondition(...)";
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001BF RID: 447 RVA: 0x000067BC File Offset: 0x000057BC
		public override string CodeName
		{
			get
			{
				return this.series.Name.Replace(" ", "") + "Crosses" + this.level;
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000067F0 File Offset: 0x000057F0
		public override string GetInitCode(string name)
		{
			return string.Concat(new object[]
			{
				"CrossLevelCondition ",
				name,
				" = new CrossLevelCondition(",
				this.series.Name.Replace(" ", ""),
				", ",
				this.level,
				");"
			});
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00006859 File Offset: 0x00005859
		public CrossLevelCondition(DoubleSeries series, double level)
		{
			this.series = series;
			this.level = level;
			this.Init();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00006875 File Offset: 0x00005875
		public CrossLevelCondition()
		{
			this.Init();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00006884 File Offset: 0x00005884
		private void Init()
		{
			this.above = new RuleItemList();
			this.below = new RuleItemList();
			this.none = new RuleItemList();
			this.childs.Add("Above", this.above);
			this.childs.Add("Below", this.below);
			this.childs.Add("None", this.none);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000068F4 File Offset: 0x000058F4
		public override void Execute()
		{
			switch (this.series.Crosses(this.level, this.series.Count - 1))
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

		// Token: 0x0400008D RID: 141
		private DoubleSeries series;

		// Token: 0x0400008E RID: 142
		private double level;

		// Token: 0x0400008F RID: 143
		private RuleItemList above;

		// Token: 0x04000090 RID: 144
		private RuleItemList below;

		// Token: 0x04000091 RID: 145
		private RuleItemList none;
	}
}
