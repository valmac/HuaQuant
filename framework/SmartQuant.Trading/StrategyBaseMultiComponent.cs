using System;
using System.Collections;
using System.ComponentModel;
using SmartQuant.Charting;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000010 RID: 16
	public class StrategyBaseMultiComponent : MultiInstrumentComponent, IStrategyComponent
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00005070 File Offset: 0x00004070
		public virtual void OnPortfolioValueChanged(Position position)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00005072 File Offset: 0x00004072
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000507A File Offset: 0x0000407A
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

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000509F File Offset: 0x0000409F
		[Browsable(false)]
		public Portfolio Portfolio
		{
			get
			{
				return this.strategyBase.Portfolio;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000050AC File Offset: 0x000040AC
		[Browsable(false)]
		public BarSeriesList Bars
		{
			get
			{
				return this.StrategyBase.Bars;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000050B9 File Offset: 0x000040B9
		[Browsable(false)]
		public Hashtable Global
		{
			get
			{
				return this.strategyBase.Global;
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000050C6 File Offset: 0x000040C6
		public virtual void OnBarSlice(long size)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000050C8 File Offset: 0x000040C8
		public void Draw(Instrument instrument, IDrawable primitive, int padNumber)
		{
			this.strategyBase.MetaStrategyBase.DrawPrimitive(instrument, primitive, padNumber);
		}

		// Token: 0x04000047 RID: 71
		private StrategyBase strategyBase;
	}
}
