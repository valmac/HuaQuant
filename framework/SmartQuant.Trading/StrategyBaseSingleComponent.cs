using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Charting;
using SmartQuant.Instruments;
using SmartQuant.Series;

namespace SmartQuant.Trading
{
	// Token: 0x02000028 RID: 40
	public abstract class StrategyBaseSingleComponent : SingleInstrumentComponent, IStrategyComponent
	{
		// Token: 0x0600019F RID: 415 RVA: 0x000065EA File Offset: 0x000055EA
		public StrategyBaseSingleComponent()
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x000065F2 File Offset: 0x000055F2
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x000065FA File Offset: 0x000055FA
		[Browsable(false)]
		public StrategyBase StrategyBase
		{
			get
			{
				return this.strategyBase;
			}
			internal set
			{
				if (this.strategyBase != null)
				{
					this.Disconnect();
				}
				this.strategyBase = value;
				if (this.strategyBase != null)
				{
					this.Connect();
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000661F File Offset: 0x0000561F
		[Browsable(false)]
		public Portfolio Portfolio
		{
			get
			{
				return this.strategyBase.Portfolio;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000662C File Offset: 0x0000562C
		[Browsable(false)]
		public BarSeriesList Bars
		{
			get
			{
				return this.strategyBase.Bars;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00006639 File Offset: 0x00005639
		[Browsable(false)]
		public BarSeries Bar
		{
			get
			{
				return this.strategyBase.Bars[this.instrument];
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00006651 File Offset: 0x00005651
		[Browsable(false)]
		public Position Position
		{
			get
			{
				return this.strategyBase.Portfolio.Positions[this.instrument];
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000666E File Offset: 0x0000566E
		[Browsable(false)]
		public bool HasPosition
		{
			get
			{
				return this.Position != null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000667C File Offset: 0x0000567C
		[Browsable(false)]
		public NamedOrderTable Orders
		{
			get
			{
				return this.strategyBase.Orders[this.instrument];
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00006694 File Offset: 0x00005694
		[Browsable(false)]
		public Hashtable Global
		{
			get
			{
				return this.strategyBase.Global;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000066A1 File Offset: 0x000056A1
		public void Draw(IDrawable primitive, int padNumber)
		{
			this.strategyBase.MetaStrategyBase.DrawPrimitive(this.instrument, primitive, padNumber);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000066BB File Offset: 0x000056BB
		public void Draw(IDrawable primitive, int padNumber, Color color)
		{
			if (primitive is TimeSeries)
			{
				(primitive as TimeSeries).Color = color;
			}
			this.Draw(primitive, padNumber);
		}

		// Token: 0x0400008B RID: 139
		private StrategyBase strategyBase;
	}
}
