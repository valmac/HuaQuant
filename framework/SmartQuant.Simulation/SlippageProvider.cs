using System;
using System.ComponentModel;
using SmartQuant.FIX;

namespace SmartQuant.Simulation
{
	// Token: 0x0200001C RID: 28
	public class SlippageProvider : ISlippageProvider
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00005C55 File Offset: 0x00004C55
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00005C5D File Offset: 0x00004C5D
		[DefaultValue(0.0)]
		[Category("Parameter")]
		[Description("Slippage in percents, 0.01 = 1%")]
		public double Slippage
		{
			get
			{
				return this.fSlippage;
			}
			set
			{
				this.fSlippage = value;
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005C70 File Offset: 0x00004C70
		public double GetExecutionPrice(ExecutionReport report)
		{
			double num = report.AvgPx;
			if (report.OrdStatus == OrdStatus.Filled)
			{
				switch (report.Side)
				{
				case Side.Buy:
					num += num * this.fSlippage;
					break;
				case Side.Sell:
				case Side.SellShort:
					num -= num * this.fSlippage;
					break;
				}
			}
			return report.AvgPx = num;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005CD4 File Offset: 0x00004CD4
		public override string ToString()
		{
			return "Slippage Provider";
		}

		// Token: 0x04000078 RID: 120
		private double fSlippage;
	}
}
