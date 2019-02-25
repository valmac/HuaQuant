using System;
using System.Collections;
using System.ComponentModel;
using SmartQuant.Testing;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Trading
{
	// Token: 0x02000034 RID: 52
	[StrategyComponent("{5E7810DC-C9C1-427f-8CD9-1DFFE26E59B5}", ComponentType.ReportManager, Name = "Default_ReportManager", Description = "")]
	public class ReportManager : ComponentBase
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00009E15 File Offset: 0x00008E15
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00009E1D File Offset: 0x00008E1D
		[Browsable(false)]
		public LiveTester Tester
		{
			get
			{
				return this.tester;
			}
			set
			{
				this.tester = value;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00009E28 File Offset: 0x00008E28
		protected void RemoveAllStatistics()
		{
			foreach (object obj in this.tester.Components)
			{
				TesterItem testerItem = (TesterItem)obj;
				if (testerItem is SeriesTesterItem)
				{
					(testerItem as SeriesTesterItem).Enabled = false;
				}
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00009E94 File Offset: 0x00008E94
		protected void AddAllStatistics()
		{
			foreach (object obj in this.tester.Components)
			{
				TesterItem testerItem = (TesterItem)obj;
				if (testerItem is SeriesTesterItem)
				{
					(testerItem as SeriesTesterItem).Enabled = true;
				}
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00009F00 File Offset: 0x00008F00
		protected void AddStatistics(string name)
		{
			TesterItem testerItem = this.tester.Components[name];
			if (testerItem is SeriesTesterItem)
			{
				(testerItem as SeriesTesterItem).Enabled = true;
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00009F34 File Offset: 0x00008F34
		protected void AddComponentSet(string setName)
		{
			if (setName == "Performance Analysis")
			{
				this.tester.EnableComponent("InitialWealth");
				this.tester.EnableComponent("FinalWealth");
				this.tester.EnableComponent("TotalDays");
				this.tester.EnableComponent("TradeDays");
				this.tester.EnableComponent("GainDays");
				this.tester.EnableComponent("LossDays");
				this.tester.EnableComponent("Average Return (%)");
				this.tester.EnableComponent("Average Gain (%)");
				this.tester.EnableComponent("Average Loss (%)");
				this.tester.EnableComponent("Drawdown Average");
				this.tester.EnableComponent("Drawdown Median");
				this.tester.EnableComponent("Average Annual Return (%)");
				this.tester.EnableComponent("Median Annual Return (%)");
				this.tester.EnableComponent("Maximum Annual Return (%)");
				this.tester.EnableComponent("Minimum Annual Return (%)");
				this.tester.EnableComponent("Average Monthly Return (%)");
				this.tester.EnableComponent("Median Monthly Return (%)");
				this.tester.EnableComponent("Maximum Monthly Return (%)");
				this.tester.EnableComponent("Minimum Monthly Return (%)");
			}
			if (setName == "Risk Analysis")
			{
				this.tester.EnableComponent("MAR Ratio");
				this.tester.EnableComponent("Modified Sharpe Ratio");
				this.tester.EnableComponent("Sotrino Ratio");
				this.tester.EnableComponent("CompoundAverageReturn");
				this.tester.EnableComponent("Minimum DrawDown");
				this.tester.EnableComponent("StandardDeviation");
				this.tester.EnableComponent("GainStandardDeviation");
				this.tester.EnableComponent("LossStandardDeviation");
				this.tester.EnableComponent("Skewness");
				this.tester.EnableComponent("Kurtosis");
				this.tester.EnableComponent("SharpeRatio");
				this.tester.EnableComponent("VaR95");
				this.tester.EnableComponent("VaR99");
			}
			if (setName == "Rolling Statistics")
			{
				string[] array = new string[]
				{
					"month3",
					"month6",
					"month9",
					"year1",
					"year2"
				};
				string[] array2 = new string[]
				{
					"day1",
					"week1",
					"month1",
					"year1"
				};
				string[] array3 = new string[]
				{
					"Percentage of profitable #PER periods (%) (Inc = #INC)",
					"Average Return for every #PER period (%) (Inc = #INC)",
					"Median Return for every #PER period (%) (Inc = #INC)"
				};
				for (int i = 0; i < array3.Length; i++)
				{
					for (int j = 0; j < array.Length; j++)
					{
						for (int k = 0; k < array2.Length; k++)
						{
							string name = array3[i].Replace("#PER", array[j]).Replace("#INC", array2[k]);
							this.tester.EnableComponent(name);
						}
					}
				}
			}
			if (setName == "Daily")
			{
				this.tester.EnableComponent("DailyWealthSeries");
				this.tester.EnableComponent("DailyPnLSeries");
				this.tester.EnableComponent("DailyReturnSeries");
				this.tester.EnableComponent("DailyDrawdownSeries");
			}
			if (setName == "Monthly")
			{
				this.tester.EnableComponent("MonthlyWealthSeries");
				this.tester.EnableComponent("MonthlyPnLSeries");
				this.tester.EnableComponent("MonthlyReturnSeries");
				this.tester.EnableComponent("MonthlyDrawdownSeries");
			}
			if (setName == "Annual")
			{
				this.tester.EnableComponent("AnnualWealthSeries");
				this.tester.EnableComponent("AnnualPnLSeries");
				this.tester.EnableComponent("AnnualReturnSeries");
				this.tester.EnableComponent("AnnualDrawdownSeries");
			}
			if (setName == "RoundTrips Statistics")
			{
				foreach (object obj in new ArrayList
				{
					"Number Of RoundTrips",
					"Number Of Winning RoundTrips",
					"Number Of Losing RoundTrips",
					"Percent Of Profitable (%)",
					"Value Open RoundTrips",
					"Total PnL Of All RoundTrips",
					"Total PnL Of Winning RoundTrips",
					"Total PnL Of Losing RoundTrips",
					"Profit Per Winning Trade",
					"Average RoundTrip",
					"Largest Winning RoundTrip",
					"Largest Losing RoundTrip",
					"Average Winning RoundTrip",
					"Average Losing RoundTrip",
					"Ratio avg. win / avg. loss",
					"Profit Factor",
					"Maximal Consecutive Winners",
					"Maximal Consecutive Losers",
					"Average Total Efficiency",
					"Average Entry Efficiency",
					"Average Exit Efficiency"
				})
				{
					string text = (string)obj;
					this.tester.EnableComponent(text);
					this.tester.EnableComponent("(Long) " + text);
					this.tester.EnableComponent("(Short) " + text);
				}
			}
			if (setName == "RoundTrips Duration Statistics")
			{
				foreach (object obj2 in new ArrayList
				{
					"Duration Of Last RoundTrip",
					"Average Duration Of RoundTrips",
					"Duration Of Last Winning RoundTrip",
					"Average Duration Of Winning RoundTrips",
					"Median Duration Of Winning RoundTrips",
					"Maximum Duration Of Winning RoundTrips",
					"Minimum Duration Of Winning RoundTrips",
					"Duration Of Last Losing RoundTrip",
					"Average Duration Of Losing RoundTrips",
					"Median Duration Of Losing RoundTrips",
					"Maximum Duration Of Losing RoundTrips",
					"Minimum Duration Of Losing RoundTrips"
				})
				{
					string text2 = (string)obj2;
					this.tester.EnableComponent(text2);
					this.tester.EnableComponent("(Long) " + text2);
					this.tester.EnableComponent("(Short) " + text2);
				}
			}
		}

		// Token: 0x040000CA RID: 202
		public const string GUID = "{5E7810DC-C9C1-427f-8CD9-1DFFE26E59B5}";

		// Token: 0x040000CB RID: 203
		protected LiveTester tester;
	}
}
