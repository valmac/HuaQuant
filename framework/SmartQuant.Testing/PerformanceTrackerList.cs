using System;
using SmartQuant.Testing.MathStatistics;
using SmartQuant.Testing.Pertrac;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing
{
	// Token: 0x02000048 RID: 72
	public class PerformanceTrackerList : TesterItemList
	{
		// Token: 0x0600023D RID: 573 RVA: 0x0000D650 File Offset: 0x0000C650
		public PerformanceTrackerList(LiveTester tester)
		{
			this.tester = tester;
			lock (tester)
			{
				this.Init();
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000D694 File Offset: 0x0000C694
		private void Init()
		{
			SimpleSeriesItem parentSeriesItem = this.tester.Components["Wealth"] as SimpleSeriesItem;
			SimpleSeriesItem parentSeriesItem2 = this.tester.Components["Drawdown"] as SimpleSeriesItem;
			SimpleSeriesItem parentSeriesItem3 = this.tester.Components["Cost"] as SimpleSeriesItem;
			SimpleSeriesItem parentSeriesItem4 = this.tester.Components["PnL"] as SimpleSeriesItem;
			SimpleSeriesItem parentSeriesItem5 = this.tester.Components["Return"] as SimpleSeriesItem;
			base.Add(new SimpleMonthlySeries("MonthlyWealthSeries", parentSeriesItem));
			base.Add(new SimpleAnnualSeries("AnnualWealthSeries", parentSeriesItem));
			base.Add(new SimpleMonthlySeries("MonthlyDrawdownSeries", parentSeriesItem2));
			base.Add(new SimpleAnnualSeries("AnnualDrawdownSeries", parentSeriesItem2));
			base.Add(new SimpleMonthlySeries("MonthlyCostSeries", parentSeriesItem3));
			base.Add(new SimpleAnnualSeries("AnnualCostSeries", parentSeriesItem3));
			base.Add(new CumulativeMonthlySeries("MonthlyPnLSeries", parentSeriesItem4));
			base.Add(new CumulativeAnnualSeries("AnnualPnLSeries", parentSeriesItem4));
			base.Add(new CumulativeDailySeries("DailyPnLSeries", parentSeriesItem4));
			base.Add(new CumulativeAnnualSeries("AnnualReturnSeries", parentSeriesItem5));
			base.Add(new CumulativeMonthlySeries("MonthlyReturnSeries", parentSeriesItem5));
			base.Add(new InitialWealth("InitialWealth", this.tester));
			base.Add(new FinalWealth("FinalWealth", this.tester));
			base.Add(new TradeDays("TradeDays", this.tester));
			base.Add(new TotalDays("TotalDays", this.tester));
			base.Add(new Average("AverageReturn", parentSeriesItem5));
			base.Add(new GainDays("GainDays", parentSeriesItem5));
			base.Add(new LossDays("LossDays", parentSeriesItem5));
			base.Add(new PositiveSeries("PositiveReturnSeries", parentSeriesItem5));
			base.Add(new NegativeSeries("NegativeReturnSeries", parentSeriesItem5));
			base.Add(new Average("AverageGain", base["PositiveReturnSeries"] as SeriesTesterItem));
			base.Add(new Average("AverageLoss", base["NegativeReturnSeries"] as SeriesTesterItem));
			base.Add(new StandardDeviation("StandardDeviation", parentSeriesItem5));
			base.Add(new GainStandardDeviation("GainStandardDeviation", base["PositiveReturnSeries"] as SeriesTesterItem));
			base.Add(new LossStandardDeviation("LossStandardDeviation", base["NegativeReturnSeries"] as SeriesTesterItem));
			base.Add(new Skewness("Skewness", parentSeriesItem5));
			base.Add(new Kurtosis("Kurtosis", parentSeriesItem5));
			base.Add(new SharpeRatio("SharpeRatio", parentSeriesItem5, this.tester.RiskFreeRate));
			base.Add(new VaR("VaR95", parentSeriesItem4, 95.0));
			base.Add(new VaR("VaR99", parentSeriesItem4, 99.0));
		}

		// Token: 0x040000DF RID: 223
		private LiveTester tester;
	}
}
