using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using SmartQuant.Business;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Series;
using SmartQuant.Testing.Design;
using SmartQuant.Testing.MathStatistics;
using SmartQuant.Testing.Pertrac;
using SmartQuant.Testing.RoundTrips;
using SmartQuant.Testing.RoundTripsStatistics;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing
{
	// Token: 0x02000039 RID: 57
	public class LiveTester
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600013E RID: 318 RVA: 0x00007615 File Offset: 0x00006615
		// (remove) Token: 0x0600013F RID: 319 RVA: 0x0000762E File Offset: 0x0000662E
		public event TesterEventHandler PnLSeriesValueAdded;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000140 RID: 320 RVA: 0x00007647 File Offset: 0x00006647
		// (remove) Token: 0x06000141 RID: 321 RVA: 0x00007660 File Offset: 0x00006660
		public event TesterEventHandler WealthSeriesValueAdded;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000142 RID: 322 RVA: 0x00007679 File Offset: 0x00006679
		// (remove) Token: 0x06000143 RID: 323 RVA: 0x00007692 File Offset: 0x00006692
		public event TesterEventHandler DrawdownSeriesValueAdded;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000144 RID: 324 RVA: 0x000076AB File Offset: 0x000066AB
		// (remove) Token: 0x06000145 RID: 325 RVA: 0x000076C4 File Offset: 0x000066C4
		public event TesterEventHandler CostSeriesValueAdded;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000146 RID: 326 RVA: 0x000076DD File Offset: 0x000066DD
		// (remove) Token: 0x06000147 RID: 327 RVA: 0x000076F6 File Offset: 0x000066F6
		public event TesterEventHandler ReturnSeriesValueAdded;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000148 RID: 328 RVA: 0x0000770F File Offset: 0x0000670F
		// (remove) Token: 0x06000149 RID: 329 RVA: 0x00007728 File Offset: 0x00006728
		public event TesterEventHandler AllocationSeriesValueAdded;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600014A RID: 330 RVA: 0x00007741 File Offset: 0x00006741
		// (remove) Token: 0x0600014B RID: 331 RVA: 0x0000775A File Offset: 0x0000675A
		public event TesterEventHandler AllocationLongSeriesValueAdded;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600014C RID: 332 RVA: 0x00007773 File Offset: 0x00006773
		// (remove) Token: 0x0600014D RID: 333 RVA: 0x0000778C File Offset: 0x0000678C
		public event TesterEventHandler AllocationShortSeriesValueAdded;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600014E RID: 334 RVA: 0x000077A5 File Offset: 0x000067A5
		// (remove) Token: 0x0600014F RID: 335 RVA: 0x000077BE File Offset: 0x000067BE
		public event TesterItemEventHandler ComponentChanged;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000150 RID: 336 RVA: 0x000077D7 File Offset: 0x000067D7
		// (remove) Token: 0x06000151 RID: 337 RVA: 0x000077F0 File Offset: 0x000067F0
		public event TesterComponentNameEventHandler ComponentNameChanged;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000152 RID: 338 RVA: 0x00007809 File Offset: 0x00006809
		// (remove) Token: 0x06000153 RID: 339 RVA: 0x00007822 File Offset: 0x00006822
		public event EventHandler ComponentListChanged;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000154 RID: 340 RVA: 0x0000783B File Offset: 0x0000683B
		// (remove) Token: 0x06000155 RID: 341 RVA: 0x00007854 File Offset: 0x00006854
		public event TesterItemEventHandler ComponentEnabledChanged;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000156 RID: 342 RVA: 0x0000786D File Offset: 0x0000686D
		// (remove) Token: 0x06000157 RID: 343 RVA: 0x00007886 File Offset: 0x00006886
		public event EventHandler Changed;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000158 RID: 344 RVA: 0x0000789F File Offset: 0x0000689F
		// (remove) Token: 0x06000159 RID: 345 RVA: 0x000078B8 File Offset: 0x000068B8
		public event TesterEventHandler StatisticChanged;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600015A RID: 346 RVA: 0x000078D1 File Offset: 0x000068D1
		// (remove) Token: 0x0600015B RID: 347 RVA: 0x000078EA File Offset: 0x000068EA
		public event TesterEventHandler RoundTripStatisticChanged;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600015C RID: 348 RVA: 0x00007903 File Offset: 0x00006903
		// (remove) Token: 0x0600015D RID: 349 RVA: 0x0000791C File Offset: 0x0000691C
		public event TesterEventHandler RoundTripsFinished;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600015E RID: 350 RVA: 0x00007935 File Offset: 0x00006935
		// (remove) Token: 0x0600015F RID: 351 RVA: 0x0000794E File Offset: 0x0000694E
		public event TesterEventHandler Reseted;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000160 RID: 352 RVA: 0x00007967 File Offset: 0x00006967
		// (remove) Token: 0x06000161 RID: 353 RVA: 0x00007980 File Offset: 0x00006980
		internal event TesterEventHandler RoundTripsUpdated;

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00007999 File Offset: 0x00006999
		public Dictionary<Instrument, LiveTester> FriendlyTesters
		{
			get
			{
				return this.friendlyTesters;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000079A1 File Offset: 0x000069A1
		[Browsable(false)]
		public RoundTripList RoundTripList
		{
			get
			{
				return this.roundTripList;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000079A9 File Offset: 0x000069A9
		[Browsable(false)]
		public RoundTripList LongRoundTripList
		{
			get
			{
				return this.longRoundTripList;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000079B1 File Offset: 0x000069B1
		[Browsable(false)]
		public RoundTripList ShortRoundTripList
		{
			get
			{
				return this.shortRoundTripList;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000079B9 File Offset: 0x000069B9
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000079C1 File Offset: 0x000069C1
		[Editor(typeof(TesterComponentListTypeEditor), typeof(UITypeEditor))]
		public TesterItemList Components
		{
			get
			{
				return this.components;
			}
			set
			{
				this.components = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000079CA File Offset: 0x000069CA
		// (set) Token: 0x06000169 RID: 361 RVA: 0x000079D4 File Offset: 0x000069D4
		public bool FollowChanges
		{
			get
			{
				return this.followChanges;
			}
			set
			{
				if (this.followChanges != value)
				{
					if (!this.isTested && value)
					{
						DateTime now = Clock.Now;
						this.Test(now, now, value);
					}
					else if (value)
					{
						DateTime intervalEnd = this.GetIntervalEnd(this.wealthSeries.LastDateTime, this.timeInterval);
						if (intervalEnd != this.awaitTime)
						{
							this.awaitTime = intervalEnd;
							Clock.AddReminder(new ReminderEventHandler(this.OnTimer), this.awaitTime, null);
						}
					}
					else
					{
						Clock.RemoveReminder(this.awaitHandler);
					}
				}
				this.followChanges = value;
				this.EmitChanged();
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00007A68 File Offset: 0x00006A68
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00007A70 File Offset: 0x00006A70
		public bool AllowRoundTrips
		{
			get
			{
				return this.allowRoundTrips;
			}
			set
			{
				this.allowRoundTrips = value;
				if (this.allowRoundTrips)
				{
					this.isRoundTripsOnly = true;
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00007A88 File Offset: 0x00006A88
		[Browsable(false)]
		public Portfolio Portfolio
		{
			get
			{
				return this.portfolio;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00007A90 File Offset: 0x00006A90
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00007A98 File Offset: 0x00006A98
		public TimeIntervalSize TimeInterval
		{
			get
			{
				return this.timeInterval;
			}
			set
			{
				this.timeInterval = value;
				this.EmitChanged();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00007AA7 File Offset: 0x00006AA7
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00007AAF File Offset: 0x00006AAF
		[Browsable(false)]
		public DateTime FirstDate
		{
			get
			{
				return this.firstDate;
			}
			set
			{
				this.firstDate = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00007AB8 File Offset: 0x00006AB8
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00007AC0 File Offset: 0x00006AC0
		[Browsable(false)]
		public DateTime LastDate
		{
			get
			{
				return this.lastDate;
			}
			set
			{
				this.lastDate = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00007AC9 File Offset: 0x00006AC9
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00007AD1 File Offset: 0x00006AD1
		[Browsable(false)]
		public double InitialWealth
		{
			get
			{
				return this.initialWealth;
			}
			set
			{
				this.initialWealth = value;
				this.currentWealth = this.initialWealth;
				this.maxPreviousWealth = this.initialWealth;
				this.currentAccount = this.initialWealth;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00007AFE File Offset: 0x00006AFE
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00007B06 File Offset: 0x00006B06
		[Browsable(false)]
		public double RiskFreeRate
		{
			get
			{
				return this.riskFreeRate;
			}
			set
			{
				if (value != this.riskFreeRate)
				{
					this.riskFreeRate = value;
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00007B18 File Offset: 0x00006B18
		[Browsable(false)]
		public double DailyRiskFreeRate
		{
			get
			{
				return (Math.Pow(this.riskFreeRate / 100.0 + 1.0, 0.004) - 1.0) * 100.0;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00007B56 File Offset: 0x00006B56
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00007B5E File Offset: 0x00006B5E
		[Browsable(false)]
		public bool BusinessDaysOnly
		{
			get
			{
				return this.businessDaysOnly;
			}
			set
			{
				this.businessDaysOnly = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00007B68 File Offset: 0x00006B68
		[Browsable(false)]
		public int TestDays
		{
			get
			{
				if (this.wealthSeries.Count <= 0)
				{
					return 0;
				}
				int days = (this.wealthSeries.LastDateTime - this.wealthSeries.FirstDateTime).Days;
				if (this.wealthSeries.FirstDateTime.AddDays((double)days) < this.wealthSeries.LastDateTime)
				{
					return days + 1;
				}
				return days;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00007BD5 File Offset: 0x00006BD5
		[Browsable(false)]
		public int TradeDays
		{
			get
			{
				return this.TestDays - Calendar.GetNWeekends(this.firstDate, this.lastDate);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00007BEF File Offset: 0x00006BEF
		[Browsable(false)]
		public double FinalWealth
		{
			get
			{
				if (this.wealthSeries.Count > 0)
				{
					return this.wealthSeries[this.wealthSeries.Count - 1];
				}
				return this.initialWealth;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00007C20 File Offset: 0x00006C20
		private void Init()
		{
			this.tempPortfolio = new Portfolio();
			this.timeInterval = TimeIntervalSize.day1;
			this.wealthSeries = new DoubleSeries();
			this.drawdownSeries = new DoubleSeries();
			this.percentDrawdownSeries = new DoubleSeries();
			this.costSeries = new DoubleSeries();
			this.pnLSeries = new DoubleSeries();
			this.returnSeries = new DoubleSeries();
			this.allocationSeries = new DoubleSeries();
			this.allocationLongSeries = new DoubleSeries();
			this.allocationShortSeries = new DoubleSeries();
			this.roundTripList = new RoundTripList(this);
			this.longRoundTripList = new RoundTripList(this);
			this.shortRoundTripList = new RoundTripList(this);
			this.isRoundTripsOnly = this.allowRoundTrips;
			this.pnLSeries.Title = "PnL";
			this.wealthSeries.Title = "Wealth";
			this.drawdownSeries.Title = "Drawdown";
			this.percentDrawdownSeries.Title = "Percent Drawdown";
			this.costSeries.Title = "Transaction costs";
			this.returnSeries.Title = "Return";
			this.pnLSeries.Name = "PnL";
			this.wealthSeries.Name = "Wealth";
			this.drawdownSeries.Name = "Drawdown";
			this.percentDrawdownSeries.Name = "Percent Drawdown";
			this.costSeries.Name = "Transaction costs";
			this.returnSeries.Name = "Return";
			this.components = new TesterItemList();
			this.components.ComponentListChanged += this.components_ComponentListChanged;
			this.InitialWealth = -1.0;
			this.riskFreeRate = 0.0;
			this.businessDaysOnly = true;
			this.totalCost = 0.0;
			SimpleSeriesItem component = new SimpleSeriesItem("Wealth", this.wealthSeries);
			SimpleSeriesItem component2 = new SimpleSeriesItem("Drawdown", this.drawdownSeries);
			SimpleSeriesItem component3 = new SimpleSeriesItem("Percent Drawdown", this.percentDrawdownSeries);
			SimpleSeriesItem component4 = new SimpleSeriesItem("Cost", this.costSeries);
			SimpleSeriesItem component5 = new SimpleSeriesItem("PnL", this.pnLSeries);
			SimpleSeriesItem component6 = new SimpleSeriesItem("Return", this.returnSeries);
			this.AddComponent(component);
			this.AddComponent(component2);
			this.AddComponent(component3);
			this.AddComponent(component4);
			this.AddComponent(component5);
			this.AddComponent(component6);
			this.AddComponents();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00007E8C File Offset: 0x00006E8C
		private void AddComponents()
		{
			SimpleSeriesItem parentSeriesItem = this.Components["Wealth"] as SimpleSeriesItem;
			SimpleSeriesItem parentSeriesItem2 = this.Components["Drawdown"] as SimpleSeriesItem;
			SimpleSeriesItem parentSeriesItem3 = this.Components["Percent Drawdown"] as SimpleSeriesItem;
			SimpleSeriesItem parentSeriesItem4 = this.Components["Cost"] as SimpleSeriesItem;
			SimpleSeriesItem parentSeriesItem5 = this.Components["PnL"] as SimpleSeriesItem;
			SimpleSeriesItem parentSeriesItem6 = this.Components["Return"] as SimpleSeriesItem;
			SimpleMonthlySeries simpleMonthlySeries = new SimpleMonthlySeries("MonthlyWealthSeries", parentSeriesItem);
			SimpleAnnualSeries simpleAnnualSeries = new SimpleAnnualSeries("AnnualWealthSeries", parentSeriesItem);
			SimpleDailySeries simpleDailySeries = new SimpleDailySeries("DailyWealthSeries", parentSeriesItem);
			this.AddComponent(simpleMonthlySeries);
			this.AddComponent(simpleAnnualSeries);
			this.AddComponent(simpleDailySeries);
			Return @return = new Return("DailyReturnSeries", simpleDailySeries);
			Return return2 = new Return("MonthlyReturnSeries", simpleMonthlySeries);
			Return return3 = new Return("AnnualReturnSeries", simpleAnnualSeries);
			this.AddComponent(@return);
			this.AddComponent(return2);
			this.AddComponent(return3);
			this.AddComponent(new Median("Drawdown Median", parentSeriesItem2));
			this.AddComponent(new Average("Drawdown Average", parentSeriesItem2));
			this.AddComponent(new Average("Average Annual Return (%)", return3));
			this.AddComponent(new Median("Median Annual Return (%)", return3));
			this.AddComponent(new Maximum("Maximum Annual Return (%)", return3));
			this.AddComponent(new Minimum("Minimum Annual Return (%)", return3));
			this.AddComponent(new Average("Average Daily Return (%)", @return));
			this.AddComponent(new Median("Median Daily Return (%)", @return));
			this.AddComponent(new Maximum("Maximum Daily Return (%)", @return));
			this.AddComponent(new Minimum("Minimum Daily Return (%)", @return));
			this.AddComponent(new Average("Average Monthly Return (%)", return2));
			this.AddComponent(new Median("Median Monthly Return (%)", return2));
			this.AddComponent(new Maximum("Maximum Monthly Return (%)", return2));
			this.AddComponent(new Minimum("Minimum Monthly Return (%)", return2));
			this.AddComponent(new SimpleMonthlySeries("MonthlyDrawdownSeries", parentSeriesItem2));
			this.AddComponent(new SimpleAnnualSeries("AnnualDrawdownSeries", parentSeriesItem2));
			this.AddComponent(new SimpleDailySeries("DailyDrawdownSeries", parentSeriesItem2));
			this.AddComponent(new SimpleMonthlySeries("MonthlyCostSeries", parentSeriesItem4));
			this.AddComponent(new SimpleAnnualSeries("AnnualCostSeries", parentSeriesItem4));
			this.AddComponent(new SimpleDailySeries("DailyCostSeries", parentSeriesItem4));
			this.AddComponent(new CumulativeMonthlySeries("MonthlyPnLSeries", parentSeriesItem5));
			this.AddComponent(new CumulativeAnnualSeries("AnnualPnLSeries", parentSeriesItem5));
			this.AddComponent(new CumulativeDailySeries("DailyPnLSeries", parentSeriesItem5));
			this.AddComponent(new InitialWealth("InitialWealth", this));
			this.AddComponent(new FinalWealth("FinalWealth", this));
			this.AddComponent(new TradeDays("TradeDays", this));
			this.AddComponent(new TotalDays("TotalDays", this));
			this.AddComponent(new Average("Average Return (%)", parentSeriesItem6));
			this.AddComponent(new GainDays("GainDays", parentSeriesItem6));
			this.AddComponent(new LossDays("LossDays", parentSeriesItem6));
			this.AddComponent(new PositiveSeries("PositiveReturnSeries", parentSeriesItem6));
			this.AddComponent(new NegativeSeries("NegativeReturnSeries", parentSeriesItem6));
			this.AddComponent(new Average("Average Gain (%)", this.Components["PositiveReturnSeries"] as SeriesTesterItem));
			this.AddComponent(new Average("Average Loss (%)", this.Components["NegativeReturnSeries"] as SeriesTesterItem));
			this.AddComponent(new StandardDeviation("StandardDeviation", parentSeriesItem6));
			this.AddComponent(new GainStandardDeviation("GainStandardDeviation", this.Components["PositiveReturnSeries"] as SeriesTesterItem));
			this.AddComponent(new LossStandardDeviation("LossStandardDeviation", this.Components["NegativeReturnSeries"] as SeriesTesterItem));
			this.AddComponent(new CompoundAverageReturn("CompoundAverageReturn", return3));
			this.AddComponent(new Skewness("Skewness", parentSeriesItem6));
			this.AddComponent(new Kurtosis("Kurtosis", parentSeriesItem6));
			this.AddComponent(new SharpeRatio("SharpeRatio", parentSeriesItem6, this.RiskFreeRate));
			this.AddComponent(new VaR("VaR95", parentSeriesItem5, 95.0));
			this.AddComponent(new VaR("VaR99", parentSeriesItem5, 99.0));
			this.AddRollingStatistics(TimeIntervalSize.year1, TimeIntervalSize.month3);
			this.AddRollingStatistics(TimeIntervalSize.year1, TimeIntervalSize.month6);
			this.AddRollingStatistics(TimeIntervalSize.year1, TimeIntervalSize.month9);
			this.AddRollingStatistics(TimeIntervalSize.year1, TimeIntervalSize.year1);
			this.AddRollingStatistics(TimeIntervalSize.year1, TimeIntervalSize.year2);
			this.AddRollingStatistics(TimeIntervalSize.month1, TimeIntervalSize.month3);
			this.AddRollingStatistics(TimeIntervalSize.month1, TimeIntervalSize.month6);
			this.AddRollingStatistics(TimeIntervalSize.month1, TimeIntervalSize.month9);
			this.AddRollingStatistics(TimeIntervalSize.month1, TimeIntervalSize.year1);
			this.AddRollingStatistics(TimeIntervalSize.month1, TimeIntervalSize.year2);
			this.AddRollingStatistics(TimeIntervalSize.week1, TimeIntervalSize.month3);
			this.AddRollingStatistics(TimeIntervalSize.week1, TimeIntervalSize.month6);
			this.AddRollingStatistics(TimeIntervalSize.week1, TimeIntervalSize.month9);
			this.AddRollingStatistics(TimeIntervalSize.week1, TimeIntervalSize.year1);
			this.AddRollingStatistics(TimeIntervalSize.week1, TimeIntervalSize.year2);
			this.AddRollingStatistics(TimeIntervalSize.day1, TimeIntervalSize.month3);
			this.AddRollingStatistics(TimeIntervalSize.day1, TimeIntervalSize.month6);
			this.AddRollingStatistics(TimeIntervalSize.day1, TimeIntervalSize.month9);
			this.AddRollingStatistics(TimeIntervalSize.day1, TimeIntervalSize.year1);
			this.AddRollingStatistics(TimeIntervalSize.day1, TimeIntervalSize.year2);
			Minimum minimum = new Minimum("Minimum DrawDown", parentSeriesItem3);
			this.AddComponent(minimum);
			MARRatio component = new MARRatio("MAR Ratio", return3, minimum);
			this.AddComponent(component);
			ModifiedSharpeRatio component2 = new ModifiedSharpeRatio("Modified Sharpe Ratio", return2);
			this.AddComponent(component2);
			SotrinoRatio component3 = new SotrinoRatio("Sotrino Ratio", @return, 0.05);
			this.AddComponent(component3);
			this.AddRoundTripComponents(this.roundTripList, "");
			this.AddRoundTripComponents(this.longRoundTripList, "(Long) ");
			this.AddRoundTripComponents(this.shortRoundTripList, "(Short) ");
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00008574 File Offset: 0x00007574
		private void AddRollingStatistics(TimeIntervalSize incr, TimeIntervalSize period)
		{
			SimpleSeriesItem parentSeriesItem = this.components["Wealth"] as SimpleSeriesItem;
			PercentageOfProfitableForPeriod percentageOfProfitableForPeriod;
			if (this.components.Contains(string.Concat(new string[]
			{
				"PercentageOfProfitableForPeriod ",
				period.ToString(),
				"(Inc = ",
				incr.ToString(),
				")"
			})))
			{
				percentageOfProfitableForPeriod = (this.components[string.Concat(new string[]
				{
					"PercentageOfProfitableForPeriod ",
					period.ToString(),
					"(Inc = ",
					incr.ToString(),
					")"
				})] as PercentageOfProfitableForPeriod);
			}
			else
			{
				percentageOfProfitableForPeriod = new PercentageOfProfitableForPeriod(string.Concat(new string[]
				{
					"PercentageOfProfitableForPeriod ",
					period.ToString(),
					"(Inc = ",
					incr.ToString(),
					")"
				}), parentSeriesItem, incr, period);
				this.AddComponent(percentageOfProfitableForPeriod);
			}
			Average component = new Average(string.Concat(new string[]
			{
				"Percentage of profitable ",
				period.ToString(),
				" periods (%) (Inc = ",
				incr.ToString(),
				")"
			}), percentageOfProfitableForPeriod);
			this.AddComponent(component);
			ReturnForPeriod returnForPeriod;
			if (this.components.Contains(string.Concat(new string[]
			{
				"ReturnForPeriod ",
				period.ToString(),
				"(Inc = ",
				incr.ToString(),
				")"
			})))
			{
				returnForPeriod = (this.components[string.Concat(new string[]
				{
					"ReturnForPeriod ",
					period.ToString(),
					"(Inc = ",
					incr.ToString(),
					")"
				})] as ReturnForPeriod);
			}
			else
			{
				returnForPeriod = new ReturnForPeriod(string.Concat(new string[]
				{
					"ReturnForPeriod ",
					period.ToString(),
					"(Inc = ",
					incr.ToString(),
					")"
				}), parentSeriesItem, incr, period);
				this.AddComponent(returnForPeriod);
			}
			Average component2 = new Average(string.Concat(new string[]
			{
				"Average Return for every ",
				period.ToString(),
				" period (%) (Inc = ",
				incr.ToString(),
				")"
			}), returnForPeriod);
			this.AddComponent(component2);
			Median component3 = new Median(string.Concat(new string[]
			{
				"Median Return for every ",
				period.ToString(),
				" period (%) (Inc = ",
				incr.ToString(),
				")"
			}), returnForPeriod);
			this.AddComponent(component3);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000088B0 File Offset: 0x000078B0
		private void AddRoundTripComponents(RoundTripList roundTripList, string caption)
		{
			WinningRoundTrips winningRoundTrips = new WinningRoundTrips(roundTripList, caption + "Number Of Winning RoundTrips");
			this.AddComponent(winningRoundTrips);
			LosingRoundTrips losingRoundTrips = new LosingRoundTrips(roundTripList, caption + "Number Of Losing RoundTrips");
			this.AddComponent(losingRoundTrips);
			NumberOfRoundTrips numberOfRoundTrips = new NumberOfRoundTrips(roundTripList, caption + "Number Of RoundTrips");
			this.AddComponent(numberOfRoundTrips);
			Division component = new Division(caption + "Percent Of Profitable (%)", winningRoundTrips, numberOfRoundTrips, numberOfRoundTrips);
			this.AddComponent(component);
			AllRoundTripsTotalPnL allRoundTripsTotalPnL = new AllRoundTripsTotalPnL(roundTripList, caption + "Total PnL Of All RoundTrips");
			this.AddComponent(allRoundTripsTotalPnL);
			WinningRoundTripsTotalPnL winningRoundTripsTotalPnL = new WinningRoundTripsTotalPnL(roundTripList, caption + "Total PnL Of Winning RoundTrips");
			this.AddComponent(winningRoundTripsTotalPnL);
			LosingRoundTripsTotalPnL losingRoundTripsTotalPnL = new LosingRoundTripsTotalPnL(roundTripList, caption + "Total PnL Of Losing RoundTrips");
			this.AddComponent(losingRoundTripsTotalPnL);
			Division component2 = new Division(caption + "Profit Per Winning Trade", winningRoundTripsTotalPnL, winningRoundTrips, winningRoundTrips);
			this.AddComponent(component2);
			LargestWinningRoundTrip component3 = new LargestWinningRoundTrip(roundTripList, caption + "Largest Winning RoundTrip");
			this.AddComponent(component3);
			LargestLosingRoundTrip component4 = new LargestLosingRoundTrip(roundTripList, caption + "Largest Losing RoundTrip");
			this.AddComponent(component4);
			Division division = new Division(caption + "Average Winning RoundTrip", winningRoundTripsTotalPnL, winningRoundTrips, winningRoundTripsTotalPnL);
			this.AddComponent(division);
			Division division2 = new Division(caption + "Average Losing RoundTrip", losingRoundTripsTotalPnL, losingRoundTrips, losingRoundTripsTotalPnL);
			this.AddComponent(division2);
			Division component5 = new Division(caption + "Average RoundTrip", allRoundTripsTotalPnL, numberOfRoundTrips, allRoundTripsTotalPnL);
			this.AddComponent(component5);
			Division component6 = new Division(caption + "Ratio avg. win / avg. loss", division, division2, allRoundTripsTotalPnL, -1.0);
			this.AddComponent(component6);
			Division component7 = new Division(caption + "Profit Factor", winningRoundTripsTotalPnL, losingRoundTripsTotalPnL, allRoundTripsTotalPnL, -1.0);
			this.AddComponent(component7);
			OpenRoundTripValue component8 = new OpenRoundTripValue(roundTripList, caption + "Value Open RoundTrips");
			this.AddComponent(component8);
			ConsecutiveWinners consecutiveWinners = new ConsecutiveWinners(roundTripList, caption + "Consecutive Winners");
			this.AddComponent(consecutiveWinners);
			Maximum component9 = new Maximum(caption + "Maximal Consecutive Winners", consecutiveWinners);
			this.AddComponent(component9);
			ConsecutiveLosers consecutiveLosers = new ConsecutiveLosers(roundTripList, caption + "Consecutive Losers");
			this.AddComponent(consecutiveLosers);
			Maximum component10 = new Maximum(caption + "Maximal Consecutive Losers", consecutiveLosers);
			this.AddComponent(component10);
			RoundTripsDuration roundTripsDuration = new RoundTripsDuration(roundTripList, caption + "Duration Of Last RoundTrip");
			this.AddComponent(roundTripsDuration);
			Average component11 = new Average(caption + "Average Duration Of RoundTrips", roundTripsDuration);
			this.AddComponent(component11);
			WinningRoundTripsDuration winningRoundTripsDuration = new WinningRoundTripsDuration(roundTripList, caption + "Duration Of Last Winning RoundTrip");
			this.AddComponent(winningRoundTripsDuration);
			Average component12 = new Average(caption + "Average Duration Of Winning RoundTrips", winningRoundTripsDuration);
			this.AddComponent(component12);
			Median component13 = new Median(caption + "Median Duration Of Winning RoundTrips", winningRoundTripsDuration);
			this.AddComponent(component13);
			Maximum component14 = new Maximum(caption + "Maximum Duration Of Winning RoundTrips", winningRoundTripsDuration);
			this.AddComponent(component14);
			Minimum component15 = new Minimum(caption + "Minimum Duration Of Winning RoundTrips", winningRoundTripsDuration);
			this.AddComponent(component15);
			LosingRoundTripsDuration losingRoundTripsDuration = new LosingRoundTripsDuration(roundTripList, caption + "Duration Of Last Losing RoundTrip");
			this.AddComponent(losingRoundTripsDuration);
			Average component16 = new Average(caption + "Average Duration Of Losing RoundTrips", losingRoundTripsDuration);
			this.AddComponent(component16);
			Median component17 = new Median(caption + "Median Duration Of Losing RoundTrips", losingRoundTripsDuration);
			this.AddComponent(component17);
			Maximum component18 = new Maximum(caption + "Maximum Duration Of Losing RoundTrips", losingRoundTripsDuration);
			this.AddComponent(component18);
			Minimum component19 = new Minimum(caption + "Minimum Duration Of Losing RoundTrips", losingRoundTripsDuration);
			this.AddComponent(component19);
			TotalRoundTripsEfficiency totalRoundTripsEfficiency = new TotalRoundTripsEfficiency(roundTripList, caption + "Last RoundTrip Total Efficiency");
			this.AddComponent(totalRoundTripsEfficiency);
			Average component20 = new Average(caption + "Average Total Efficiency", totalRoundTripsEfficiency);
			this.AddComponent(component20);
			RoundTripsEntryEfficiency roundTripsEntryEfficiency = new RoundTripsEntryEfficiency(roundTripList, caption + "Last RoundTrip Entry Efficiency");
			this.AddComponent(roundTripsEntryEfficiency);
			Average component21 = new Average(caption + "Average Entry Efficiency", roundTripsEntryEfficiency);
			this.AddComponent(component21);
			RoundTripsExitEfficiency roundTripsExitEfficiency = new RoundTripsExitEfficiency(roundTripList, caption + "Last RoundTrip Exit Efficiency");
			this.AddComponent(roundTripsExitEfficiency);
			Average component22 = new Average(caption + "Average Exit Efficiency", roundTripsExitEfficiency);
			this.AddComponent(component22);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00008CF2 File Offset: 0x00007CF2
		private void InitComponents()
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00008CF4 File Offset: 0x00007CF4
		public void ResetParameters()
		{
			this.pnL = 0.0;
			this.wealth = 0.0;
			this.drawdown = 0.0;
			this.percentDrawdown = 0.0;
			this.cost = 0.0;
			this.totalCost = 0.0;
			this.returnValue = 0.0;
			this.allocation = 0.0;
			this.allocationLong = 0.0;
			this.allocationShort = 0.0;
			this.isAllocationLong = false;
			this.isAllocationShort = false;
			this.InitialWealth = -1.0;
			this.awaitTime = DateTime.MinValue;
			this.firstDate = DateTime.MinValue;
			this.lastDate = DateTime.MinValue;
			this.isRoundTripsOnly = this.allowRoundTrips;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00008DE4 File Offset: 0x00007DE4
		public void Reset()
		{
			this.isTested = false;
			this.tempPortfolio.Clear();
			this.wealthSeries.Clear();
			this.pnLSeries.Clear();
			this.drawdownSeries.Clear();
			this.percentDrawdownSeries.Clear();
			this.costSeries.Clear();
			this.returnSeries.Clear();
			this.roundTripList.Clear();
			this.shortRoundTripList.Clear();
			this.longRoundTripList.Clear();
			this.ResetParameters();
			if (this.connected)
			{
				this.waitingForStart = true;
			}
			foreach (object obj in this.components)
			{
				TesterItem testerItem = (TesterItem)obj;
				testerItem.Reset();
			}
			this.EmitReseted();
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00008ECC File Offset: 0x00007ECC
		public void Connect()
		{
			this.Connect(false);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00008ED8 File Offset: 0x00007ED8
		public void Connect(bool connectStatistics)
		{
			lock (this)
			{
				this.portfolio.TransactionAdded += this.portfolio_TransactionAdded;
				this.portfolio.Cleared += this.portfolio_Cleared;
				this.portfolio.ValueChanged += this.portfolio_ValueChanged;
				this.portfolio.Account.AccountChanged += this.Account_AccountChanged;
				this.roundTripList.Connect();
				this.longRoundTripList.Connect();
				this.shortRoundTripList.Connect();
				foreach (object obj in this.components)
				{
					TesterItem testerItem = (TesterItem)obj;
					if (connectStatistics)
					{
						testerItem.Connect();
					}
					testerItem.PropertyChanged += this.component_PropertyChanged;
					testerItem.ComponentNameChanged += this.component_ComponentNameChanged;
					if (testerItem is SeriesTesterItem)
					{
						(testerItem as SeriesTesterItem).ComponentEnabledChanged += this.LiveTester_ComponentEnabledChanged;
					}
				}
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00009030 File Offset: 0x00008030
		public void Disconnect(bool disconnectStatistics)
		{
			lock (this)
			{
				this.DisconnectPorftolio();
				this.portfolio.TransactionAdded -= this.portfolio_TransactionAdded;
				this.portfolio.Cleared -= this.portfolio_Cleared;
				this.portfolio.ValueChanged -= this.portfolio_ValueChanged;
				this.portfolio.Account.AccountChanged -= this.Account_AccountChanged;
				Clock.RemoveReminder(this.awaitHandler);
				this.roundTripList.Disconnect();
				this.longRoundTripList.Disconnect();
				this.shortRoundTripList.Disconnect();
				foreach (object obj in this.components)
				{
					TesterItem testerItem = (TesterItem)obj;
					if (disconnectStatistics)
					{
						testerItem.Disconnect();
					}
					testerItem.PropertyChanged -= this.component_PropertyChanged;
					testerItem.ComponentNameChanged -= this.component_ComponentNameChanged;
					if (testerItem is SeriesTesterItem)
					{
						(testerItem as SeriesTesterItem).ComponentEnabledChanged -= this.LiveTester_ComponentEnabledChanged;
					}
				}
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00009198 File Offset: 0x00008198
		public void Disconnect()
		{
			this.Disconnect(false);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000091A1 File Offset: 0x000081A1
		public void DisconnectPorftolio()
		{
			this.tempPortfolio.Monitored = false;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000091B0 File Offset: 0x000081B0
		public LiveTester(Portfolio portfolio)
		{
			this.firstDate = new DateTime(0L);
			this.lastDate = new DateTime(0L);
			this.portfolio = portfolio;
			this.transactions = portfolio.Transactions;
			this.Init();
			this.InitComponents();
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00009210 File Offset: 0x00008210
		public DateTime GetIntervalEnd(DateTime dateTime, TimeIntervalSize intervalSize)
		{
			DateTime dateTime2;
			if (intervalSize <= TimeIntervalSize.hour12)
			{
				if (intervalSize <= TimeIntervalSize.min10)
				{
					if (intervalSize <= TimeIntervalSize.sec10)
					{
						if (intervalSize <= TimeIntervalSize.sec2)
						{
							if (intervalSize == TimeIntervalSize.sec1)
							{
								dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second).AddSeconds(1.0);
								goto IL_C91;
							}
							if (intervalSize == TimeIntervalSize.sec2)
							{
								dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second).AddSeconds((double)(1 + (1 - (int)new TimeSpan(dateTime.Ticks).TotalSeconds % 2)));
								goto IL_C91;
							}
						}
						else
						{
							if (intervalSize == TimeIntervalSize.sec5)
							{
								dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second).AddSeconds((double)(1 + (4 - (int)new TimeSpan(dateTime.Ticks).TotalSeconds % 5)));
								goto IL_C91;
							}
							if (intervalSize == TimeIntervalSize.sec10)
							{
								dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second).AddSeconds((double)(1 + (9 - (int)new TimeSpan(dateTime.Ticks).TotalSeconds % 10)));
								goto IL_C91;
							}
						}
					}
					else if (intervalSize <= TimeIntervalSize.sec30)
					{
						if (intervalSize == TimeIntervalSize.sec20)
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second).AddSeconds((double)(1 + (19 - (int)new TimeSpan(dateTime.Ticks).TotalSeconds % 20)));
							goto IL_C91;
						}
						if (intervalSize == TimeIntervalSize.sec30)
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second).AddSeconds((double)(1 + (29 - (int)new TimeSpan(dateTime.Ticks).TotalSeconds % 30)));
							goto IL_C91;
						}
					}
					else
					{
						if (intervalSize == TimeIntervalSize.min1)
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes(1.0);
							goto IL_C91;
						}
						if (intervalSize ==unchecked((TimeIntervalSize)((ulong)-1294967296)))
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double)(1 + (4 - (int)new TimeSpan(dateTime.Ticks).TotalMinutes % 5)));
							goto IL_C91;
						}
						if (intervalSize == TimeIntervalSize.min10)
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double)(1 + (9 - (int)new TimeSpan(dateTime.Ticks).TotalMinutes % 10)));
							goto IL_C91;
						}
					}
				}
				else if (intervalSize <= TimeIntervalSize.hour1)
				{
					if (intervalSize <= TimeIntervalSize.min20)
					{
						if (intervalSize == TimeIntervalSize.min15)
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double)(1 + (14 - (int)new TimeSpan(dateTime.Ticks).TotalMinutes % 15)));
							goto IL_C91;
						}
						if (intervalSize == TimeIntervalSize.min20)
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double)(1 + (19 - (int)new TimeSpan(dateTime.Ticks).TotalMinutes % 20)));
							goto IL_C91;
						}
					}
					else
					{
						if (intervalSize == TimeIntervalSize.min30)
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double)(1 + (29 - (int)new TimeSpan(dateTime.Ticks).TotalMinutes % 30)));
							goto IL_C91;
						}
						if (intervalSize == TimeIntervalSize.hour1)
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours(1.0);
							goto IL_C91;
						}
					}
				}
				else if (intervalSize <= TimeIntervalSize.hour3)
				{
					if (intervalSize == TimeIntervalSize.hour2)
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double)(1 + (1 - (int)new TimeSpan(dateTime.Ticks).TotalHours % 2)));
						goto IL_C91;
					}
					if (intervalSize == TimeIntervalSize.hour3)
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double)(1 + (2 - (int)new TimeSpan(dateTime.Ticks).TotalHours % 3)));
						goto IL_C91;
					}
				}
				else
				{
					if (intervalSize == TimeIntervalSize.hour4)
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double)(1 + (3 - (int)new TimeSpan(dateTime.Ticks).TotalHours % 4)));
						goto IL_C91;
					}
					if (intervalSize == TimeIntervalSize.hour6)
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double)(1 + (5 - (int)new TimeSpan(dateTime.Ticks).TotalHours % 6)));
						goto IL_C91;
					}
					if (intervalSize == TimeIntervalSize.hour12)
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double)(1 + (11 - (int)new TimeSpan(dateTime.Ticks).TotalHours % 12)));
						goto IL_C91;
					}
				}
			}
			else if (intervalSize <= TimeIntervalSize.month3)
			{
				if (intervalSize <= TimeIntervalSize.day5)
				{
					if (intervalSize <= TimeIntervalSize.day2)
					{
						if (intervalSize == TimeIntervalSize.day1)
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(1.0);
							goto IL_C91;
						}
						if (intervalSize == TimeIntervalSize.day2)
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(1 + (int)new TimeSpan(dateTime.Ticks).TotalDays % 2));
							goto IL_C91;
						}
					}
					else
					{
						if (intervalSize == TimeIntervalSize.day3)
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(1 + (2 - (int)new TimeSpan(dateTime.Ticks).TotalDays % 3)));
							goto IL_C91;
						}
						if (intervalSize == TimeIntervalSize.day5)
						{
							dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(1 + (4 - (int)new TimeSpan(dateTime.Ticks).TotalDays % 5)));
							goto IL_C91;
						}
					}
				}
				else if (intervalSize <= TimeIntervalSize.week2)
				{
					if (intervalSize == TimeIntervalSize.week1)
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(8.0 - (double)dateTime.DayOfWeek);
						goto IL_C91;
					}
					if (intervalSize == TimeIntervalSize.week2)
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(8.0 - (double)dateTime.DayOfWeek + (double)(7 * (1 - (int)Math.Floor(new TimeSpan(dateTime.AddDays(8.0 - (double)dateTime.DayOfWeek).Ticks).TotalDays) / 7 % 2)));
						goto IL_C91;
					}
				}
				else
				{
					if (intervalSize == TimeIntervalSize.month1)
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1);
						goto IL_C91;
					}
					if (intervalSize == TimeIntervalSize.month2)
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1 + dateTime.Month % 2);
						goto IL_C91;
					}
					if (intervalSize == TimeIntervalSize.month3)
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1 + (12 - dateTime.Month) % 3);
						goto IL_C91;
					}
				}
			}
			else if (intervalSize <= TimeIntervalSize.year2)
			{
				if (intervalSize <= TimeIntervalSize.month6)
				{
					if (intervalSize == TimeIntervalSize.month4)
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1 + (12 - dateTime.Month) % 4);
						goto IL_C91;
					}
					if (intervalSize == TimeIntervalSize.month6)
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1 + (12 - dateTime.Month) % 6);
						goto IL_C91;
					}
				}
				else
				{
					if (intervalSize == TimeIntervalSize.year1)
					{
						dateTime2 = new DateTime(dateTime.Year, 1, 1).AddYears(1);
						goto IL_C91;
					}
					if (intervalSize == TimeIntervalSize.year2)
					{
						dateTime2 = new DateTime(dateTime.Year, 1, 1).AddYears(1 + (1 - dateTime.Year % 2));
						goto IL_C91;
					}
				}
			}
			else if (intervalSize <= TimeIntervalSize.year4)
			{
				if (intervalSize == TimeIntervalSize.year3)
				{
					dateTime2 = new DateTime(dateTime.Year, 1, 1).AddYears(1 + (2 - dateTime.Year % 3));
					goto IL_C91;
				}
				if (intervalSize == TimeIntervalSize.year4)
				{
					dateTime2 = new DateTime(dateTime.Year, 1, 1).AddYears(1 + (3 - dateTime.Year % 4));
					goto IL_C91;
				}
			}
			else
			{
				if (intervalSize == TimeIntervalSize.year5)
				{
					dateTime2 = new DateTime(dateTime.Year, 1, 1).AddYears(1 + (4 - dateTime.Year % 5));
					goto IL_C91;
				}
				if (intervalSize == TimeIntervalSize.year10)
				{
					dateTime2 = new DateTime(dateTime.Year, 1, 1).AddYears(1 + (9 - dateTime.Year % 10));
					goto IL_C91;
				}
				if (intervalSize == TimeIntervalSize.year20)
				{
					dateTime2 = new DateTime(dateTime.Year, 1, 1).AddYears(1 + (19 - dateTime.Year % 20));
					goto IL_C91;
				}
			}
			dateTime2 = dateTime.AddTicks((long)intervalSize);
			IL_C91:
			return dateTime2.AddTicks(-1L);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00009EB8 File Offset: 0x00008EB8
		public DateTime AddInterval(DateTime dateTime, TimeIntervalSize intervalSize)
		{
			if (intervalSize <= TimeIntervalSize.year1)
			{
				if (intervalSize <= TimeIntervalSize.month3)
				{
					if (intervalSize == TimeIntervalSize.month1)
					{
						return dateTime.AddMonths(1);
					}
					if (intervalSize == TimeIntervalSize.month2)
					{
						return dateTime.AddMonths(2);
					}
					if (intervalSize == TimeIntervalSize.month3)
					{
						return dateTime.AddMonths(3);
					}
				}
				else
				{
					if (intervalSize == TimeIntervalSize.month4)
					{
						return dateTime.AddMonths(4);
					}
					if (intervalSize == TimeIntervalSize.month6)
					{
						return dateTime.AddMonths(6);
					}
					if (intervalSize == TimeIntervalSize.year1)
					{
						return dateTime.AddYears(1);
					}
				}
			}
			else if (intervalSize <= TimeIntervalSize.year4)
			{
				if (intervalSize == TimeIntervalSize.year2)
				{
					return dateTime.AddYears(2);
				}
				if (intervalSize == TimeIntervalSize.year3)
				{
					return dateTime.AddYears(3);
				}
				if (intervalSize == TimeIntervalSize.year4)
				{
					return dateTime.AddYears(4);
				}
			}
			else
			{
				if (intervalSize == TimeIntervalSize.year5)
				{
					return dateTime.AddYears(5);
				}
				if (intervalSize == TimeIntervalSize.year10)
				{
					return dateTime.AddYears(10);
				}
				if (intervalSize == TimeIntervalSize.year20)
				{
					return dateTime.AddYears(20);
				}
			}
			return dateTime.AddTicks((long)intervalSize);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000A046 File Offset: 0x00009046
		private void Account_AccountChanged(object sender, EventArgs e)
		{
			if (this.initialWealth == -1.0)
			{
				this.InitialWealth = this.portfolio.Account.GetValue();
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000A070 File Offset: 0x00009070
		private void portfolio_TransactionAdded(object sender, TransactionEventArgs args)
		{
			lock (this)
			{
				if (this.followChanges)
				{
					this.tempPortfolio.Add(args.Transaction);
					this.tempPortfolio.Monitored = true;
					switch (args.Transaction.Side)
					{
					case Side.Buy:
						this.currentAccount -= args.Transaction.Value;
						this.allocation += args.Transaction.Value;
						this.allocationLong += args.Transaction.Value;
						this.isAllocationLong = true;
						break;
					case Side.Sell:
						this.currentAccount += args.Transaction.Value;
						this.allocation -= args.Transaction.Value;
						this.allocationLong -= args.Transaction.Value;
						this.isAllocationLong = true;
						break;
					case Side.BuyMinus:
						this.currentAccount -= args.Transaction.Value;
						this.allocation += args.Transaction.Value;
						this.allocationShort += args.Transaction.Value;
						this.isAllocationShort = true;
						break;
					case Side.SellShort:
						this.currentAccount += args.Transaction.Value;
						this.allocation -= args.Transaction.Value;
						this.allocationShort -= args.Transaction.Value;
						this.isAllocationShort = true;
						break;
					}
					if (this.isRoundTripsOnly)
					{
						if (!this.tempPortfolio.Positions.Contains(args.Transaction.Instrument))
						{
							this.roundTripList.CloseOpenRoundTrip(args.Transaction.Instrument, args.Transaction.Price, args.Transaction.DateTime);
							if (args.Transaction.Side == Side.Buy)
							{
								this.shortRoundTripList.CloseOpenRoundTrip(args.Transaction.Instrument, args.Transaction.Price, args.Transaction.DateTime);
							}
							else
							{
								this.longRoundTripList.CloseOpenRoundTrip(args.Transaction.Instrument, args.Transaction.Price, args.Transaction.DateTime);
							}
						}
						else if (this.tempPortfolio.Positions[args.Transaction.Instrument].Transactions.Count == 1)
						{
							PositionSide tradePosition = PositionSide.Short;
							if (args.Transaction.Side == Side.Buy)
							{
								tradePosition = PositionSide.Long;
							}
							RoundTrip openRoundTrip = new RoundTrip(this.tempPortfolio.Positions[args.Transaction.Instrument], args.Transaction.Instrument, tradePosition, args.Transaction.Amount, args.Transaction.Price, args.Transaction.Price, args.Transaction.DateTime, args.Transaction.DateTime, RoundTripStatus.Opened);
							this.roundTripList.AddOpenRoundTrip(openRoundTrip);
							if (args.Transaction.Side == Side.Buy)
							{
								this.longRoundTripList.AddOpenRoundTrip(openRoundTrip);
							}
							else
							{
								this.shortRoundTripList.AddOpenRoundTrip(openRoundTrip);
							}
						}
						else
						{
							this.isRoundTripsOnly = false;
							this.EmitRoundTripsFinished();
						}
					}
					if (this.isRoundTripsOnly)
					{
						this.roundTripList.UpdateOpenRoundTrips();
					}
					this.currentAccount -= args.Transaction.Cost;
					this.cost += args.Transaction.Cost;
					if (this.isRoundTripsOnly)
					{
						this.EmitRoundTripsUpdated();
						this.EmitRoundTripStatisticChanged();
					}
					if (this.waitingForStart)
					{
						this.waitingForStart = false;
						this.awaitTime = this.GetIntervalEnd(args.Transaction.DateTime, this.timeInterval);
						this.awaitHandler = new ReminderEventHandler(this.OnTimer);
						Clock.AddReminder(this.awaitHandler, this.awaitTime, null);
					}
				}
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000A49C File Offset: 0x0000949C
		private void OnTimer(ReminderEventArgs args)
		{
			lock (this)
			{
				try
				{
					DateTime dateTime = args.SignalTime;
					DateTime now = Clock.Now;
					while (dateTime <= now)
					{
						this.UpdateStatistic(dateTime);
						this.isNewData = false;
						dateTime = this.AddInterval(dateTime, this.timeInterval);
					}
					this.awaitTime = dateTime;
					this.awaitHandler = new ReminderEventHandler(this.OnTimer);
					Clock.AddReminder(this.awaitHandler, this.awaitTime, null);
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000A53C File Offset: 0x0000953C
		private void UpdateStatistic(DateTime date)
		{
			if (this.tempPortfolio.Transactions == null)
			{
				return;
			}
			if (this.tempPortfolio.Transactions.Count == 0)
			{
				return;
			}
			if (this.isAllocationLong || this.isAllocationShort)
			{
				this.allocationSeries.Add(date.AddTicks(1L), this.allocation);
				this.EmitAllocationSeriesValueAdded();
			}
			if (this.isAllocationLong)
			{
				this.allocationLongSeries.Add(date.AddTicks(1L), this.allocationLong);
				this.EmitAllocationLongSeriesValueAdded();
			}
			if (this.isAllocationShort)
			{
				this.allocationShortSeries.Add(date.AddTicks(1L), this.allocationShort);
				this.EmitAllocationShortSeriesValueAdded();
			}
			this.isAllocationLong = false;
			this.isAllocationShort = false;
			if (this.isRoundTripsOnly)
			{
				this.roundTripList.UpdateOpenRoundTrips();
			}
			double num = this.currentWealth;
			if (this.wealthSeries.Count > 0)
			{
				num = this.wealthSeries[this.wealthSeries.Count - 1];
			}
			this.currentWealth = this.currentAccount + this.tempPortfolio.GetPositionValue();
			this.pnL = this.currentWealth - num;
			this.maxPreviousWealth = Math.Max(this.maxPreviousWealth, num);
			this.drawdown = Math.Min(this.currentWealth - this.maxPreviousWealth, 0.0);
			this.percentDrawdown = this.currentWealth / this.maxPreviousWealth - 1.0;
			this.returnValue = (this.currentWealth / num - 1.0) * 100.0;
			this.wealthSeries.Add(date.AddTicks(1L), this.currentWealth);
			this.drawdownSeries.Add(date.AddTicks(1L), this.drawdown);
			this.percentDrawdownSeries.Add(date.AddTicks(1L), this.percentDrawdown);
			this.pnLSeries.Add(date.AddTicks(1L), this.pnL);
			this.costSeries.Add(date.AddTicks(1L), this.cost);
			this.returnSeries.Add(date.AddTicks(1L), this.returnValue);
			this.EmitPnLSeriesValueAdded();
			this.EmitWealthSeriesValueAddedd();
			this.EmitDrawdownSeriesValueAdded();
			this.EmitCostSeriesValueAdded();
			this.EmitReturnSeriesValueAdded();
			this.EmitStatisticChanged();
			if (this.isRoundTripsOnly)
			{
				this.EmitRoundTripsUpdated();
				this.EmitRoundTripStatisticChanged();
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000A7A8 File Offset: 0x000097A8
		private void portfolio_ValueChanged(object sender, PositionEventArgs e)
		{
			lock (this)
			{
				this.isNewData = true;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000A7E0 File Offset: 0x000097E0
		private void portfolio_Cleared(object sender, EventArgs e)
		{
			lock (this)
			{
				this.Reset();
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000A814 File Offset: 0x00009814
		public void Test(DateTime firstDateTime, DateTime lastDateTime, bool followChanges)
		{
			lock (this)
			{
				this.connected = followChanges;
				this.isTested = true;
				int count = this.portfolio.Transactions.Count;
				this.Reset();
				this.Disconnect();
				this.Connect();
				int num = 0;
				DateTime dateTime = this.GetIntervalEnd(firstDateTime, this.timeInterval);
				while (dateTime <= lastDateTime)
				{
					bool flag = false;
					bool flag2 = false;
					for (int i = num; i < count; i++)
					{
						Transaction transaction = this.portfolio.Transactions[i];
						if (transaction.DateTime <= dateTime)
						{
							switch (transaction.Side)
							{
							case Side.Buy:
								this.currentAccount -= transaction.Value;
								this.allocation += transaction.Value;
								this.allocationLong += transaction.Value;
								flag = true;
								break;
							case Side.Sell:
								this.currentAccount += transaction.Value;
								this.allocation -= transaction.Value;
								this.allocationLong -= transaction.Value;
								flag = true;
								break;
							case Side.BuyMinus:
								this.currentAccount -= transaction.Value;
								this.allocation += transaction.Value;
								this.allocationShort += transaction.Value;
								flag2 = true;
								break;
							case Side.SellShort:
								this.currentAccount += transaction.Value;
								this.allocation -= transaction.Value;
								this.allocationShort -= transaction.Value;
								flag2 = true;
								break;
							}
							if (this.isRoundTripsOnly)
							{
								if (!this.tempPortfolio.Positions.Contains(transaction.Instrument))
								{
									this.roundTripList.CloseOpenRoundTrip(transaction.Instrument, transaction.Price, transaction.DateTime);
									if (transaction.Side == Side.Buy)
									{
										this.shortRoundTripList.CloseOpenRoundTrip(transaction.Instrument, transaction.Price, transaction.DateTime);
									}
									else
									{
										this.longRoundTripList.CloseOpenRoundTrip(transaction.Instrument, transaction.Price, transaction.DateTime);
									}
								}
								else if (this.tempPortfolio.Positions[transaction.Instrument].Transactions.Count == 1)
								{
									PositionSide tradePosition = PositionSide.Short;
									if (transaction.Side == Side.Buy)
									{
										tradePosition = PositionSide.Long;
									}
									RoundTrip openRoundTrip = new RoundTrip(this.tempPortfolio.Positions[transaction.Instrument], transaction.Instrument, tradePosition, transaction.Amount, transaction.Price, transaction.Price, transaction.DateTime, transaction.DateTime, RoundTripStatus.Opened);
									this.roundTripList.AddOpenRoundTrip(openRoundTrip);
									if (transaction.Side == Side.Buy)
									{
										this.longRoundTripList.AddOpenRoundTrip(openRoundTrip);
									}
									else
									{
										this.shortRoundTripList.AddOpenRoundTrip(openRoundTrip);
									}
								}
								else
								{
									this.isRoundTripsOnly = false;
									this.EmitRoundTripsFinished();
								}
							}
							this.currentAccount -= transaction.Cost;
							this.tempPortfolio.Add(transaction);
							this.cost += transaction.Cost;
							num = i + 1;
						}
						else if (transaction.DateTime.Date >= dateTime)
						{
							break;
						}
					}
					double num2 = this.currentWealth;
					this.currentWealth = this.currentAccount + this.tempPortfolio.GetPositionValue(dateTime);
					this.pnL = this.currentWealth - num2;
					this.maxPreviousWealth = Math.Max(this.maxPreviousWealth, num2);
					this.drawdown = Math.Min(this.currentWealth - this.maxPreviousWealth, 0.0);
					this.percentDrawdown = this.currentWealth / this.maxPreviousWealth - 1.0;
					this.returnValue = (this.currentWealth / num2 - 1.0) * 100.0;
					this.totalCost += this.cost;
					if (this.businessDaysOnly)
					{
						Calendar.IsWeekend(dateTime);
					}
					if (dateTime >= this.FirstDate.Date)
					{
						this.wealthSeries.Add(dateTime.AddTicks(1L), this.currentWealth);
						this.drawdownSeries.Add(dateTime.AddTicks(1L), this.drawdown);
						this.percentDrawdownSeries.Add(dateTime.AddTicks(1L), this.percentDrawdown);
						this.pnLSeries.Add(dateTime.AddTicks(1L), this.pnL);
						this.costSeries.Add(dateTime.AddTicks(1L), this.cost);
						this.returnSeries.Add(dateTime.AddTicks(1L), this.returnValue);
						this.EmitPnLSeriesValueAdded();
						this.EmitWealthSeriesValueAddedd();
						this.EmitDrawdownSeriesValueAdded();
						this.EmitCostSeriesValueAdded();
						this.EmitReturnSeriesValueAdded();
						if (flag || flag2)
						{
							this.allocationSeries.Add(dateTime.AddTicks(1L), this.allocation);
							this.EmitAllocationSeriesValueAdded();
						}
						if (flag)
						{
							this.allocationLongSeries.Add(dateTime.AddTicks(1L), this.allocationLong);
							this.EmitAllocationLongSeriesValueAdded();
						}
						if (flag2)
						{
							this.allocationShortSeries.Add(dateTime.AddTicks(1L), this.allocationShort);
							this.EmitAllocationShortSeriesValueAdded();
						}
					}
					dateTime = this.AddInterval(dateTime, this.timeInterval);
				}
				this.EmitStatisticChanged();
				if (this.isRoundTripsOnly)
				{
					this.EmitRoundTripsUpdated();
					this.EmitRoundTripStatisticChanged();
				}
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000ADD0 File Offset: 0x00009DD0
		public void Test()
		{
			this.Test(this.followChanges);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000ADE0 File Offset: 0x00009DE0
		public void Test(bool followChanges)
		{
			this.followChanges = followChanges;
			if (this.portfolio.Transactions.Count > 0 && this.firstDate == DateTime.MinValue && this.lastDate == DateTime.MinValue)
			{
				this.firstDate = this.portfolio.Transactions.First.DateTime;
				this.lastDate = this.AddInterval(this.portfolio.Transactions.Last.DateTime, this.timeInterval);
			}
			else
			{
				this.firstDate = Clock.Now.AddDays(1.0);
			}
			this.Test(this.firstDate, this.lastDate, followChanges);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000AE9E File Offset: 0x00009E9E
		public void TestOffline()
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000AEA0 File Offset: 0x00009EA0
		public void AddComponent(TesterItem component)
		{
			this.components.Add(component);
			component.PropertyChanged += this.component_PropertyChanged;
			component.ComponentNameChanged += this.component_ComponentNameChanged;
			if (component is SeriesTesterItem)
			{
				(component as SeriesTesterItem).ComponentEnabledChanged += this.LiveTester_ComponentEnabledChanged;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000AEFC File Offset: 0x00009EFC
		public void RemoveComponent(TesterItem component)
		{
			this.components.Remove(component.Name);
			component.PropertyChanged -= this.component_PropertyChanged;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000AF24 File Offset: 0x00009F24
		public void ClearComponents(TesterItem component)
		{
			ArrayList arrayList = new ArrayList(this.components);
			foreach (object obj in arrayList)
			{
				TesterItem component2 = (TesterItem)obj;
				this.RemoveComponent(component2);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000AF84 File Offset: 0x00009F84
		public void AddList(TesterItemList componentList)
		{
			foreach (object obj in componentList)
			{
				TesterItem component = (TesterItem)obj;
				this.AddComponent(component);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000AFD8 File Offset: 0x00009FD8
		public void EnableComponent(string name)
		{
			TesterItem testerItem = this.components[name];
			if (testerItem is SeriesTesterItem)
			{
				(testerItem as SeriesTesterItem).Enabled = true;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000B008 File Offset: 0x0000A008
		public void DisableComponent(string name)
		{
			TesterItem testerItem = this.components[name];
			if (testerItem is SeriesTesterItem)
			{
				(testerItem as SeriesTesterItem).Enabled = false;
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000B036 File Offset: 0x0000A036
		public void EmitAllocationShortSeriesValueAdded()
		{
			if (this.AllocationShortSeriesValueAdded != null)
			{
				this.AllocationShortSeriesValueAdded(this);
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000B04C File Offset: 0x0000A04C
		public void EmitAllocationLongSeriesValueAdded()
		{
			if (this.AllocationLongSeriesValueAdded != null)
			{
				this.AllocationLongSeriesValueAdded(this);
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000B062 File Offset: 0x0000A062
		public void EmitAllocationSeriesValueAdded()
		{
			if (this.AllocationSeriesValueAdded != null)
			{
				this.AllocationSeriesValueAdded(this);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000B078 File Offset: 0x0000A078
		public void EmitPnLSeriesValueAdded()
		{
			if (this.PnLSeriesValueAdded != null)
			{
				this.PnLSeriesValueAdded(this);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000B08E File Offset: 0x0000A08E
		public void EmitWealthSeriesValueAddedd()
		{
			if (this.WealthSeriesValueAdded != null)
			{
				this.WealthSeriesValueAdded(this);
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000B0A4 File Offset: 0x0000A0A4
		public void EmitDrawdownSeriesValueAdded()
		{
			if (this.DrawdownSeriesValueAdded != null)
			{
				this.DrawdownSeriesValueAdded(this);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000B0BA File Offset: 0x0000A0BA
		public void EmitCostSeriesValueAdded()
		{
			if (this.CostSeriesValueAdded != null)
			{
				this.CostSeriesValueAdded(this);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000B0D0 File Offset: 0x0000A0D0
		public void EmitReturnSeriesValueAdded()
		{
			if (this.ReturnSeriesValueAdded != null)
			{
				this.ReturnSeriesValueAdded(this);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000B0E6 File Offset: 0x0000A0E6
		public void EmitStatisticChanged()
		{
			if (this.StatisticChanged != null)
			{
				this.StatisticChanged(this);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000B0FC File Offset: 0x0000A0FC
		public void EmitRoundTripStatisticChanged()
		{
			if (this.RoundTripStatisticChanged != null)
			{
				this.RoundTripStatisticChanged(this);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000B112 File Offset: 0x0000A112
		public void EmitRoundTripsUpdated()
		{
			if (this.RoundTripsUpdated != null)
			{
				this.RoundTripsUpdated(this);
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000B128 File Offset: 0x0000A128
		public void EmitRoundTripsFinished()
		{
			if (this.RoundTripsFinished != null)
			{
				this.RoundTripsFinished(this);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000B13E File Offset: 0x0000A13E
		public void EmitReseted()
		{
			if (this.Reseted != null)
			{
				this.Reseted(this);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000B154 File Offset: 0x0000A154
		[Browsable(false)]
		public DoubleSeries AllocationSeries
		{
			get
			{
				return this.allocationSeries;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000B15C File Offset: 0x0000A15C
		[Browsable(false)]
		public DoubleSeries AllocationLongSeries
		{
			get
			{
				return this.allocationLongSeries;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000B164 File Offset: 0x0000A164
		[Browsable(false)]
		public DoubleSeries AllocationShortSeries
		{
			get
			{
				return this.allocationShortSeries;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000B16C File Offset: 0x0000A16C
		[Browsable(false)]
		public DoubleSeries PnLSeries
		{
			get
			{
				return this.pnLSeries;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000B174 File Offset: 0x0000A174
		[Browsable(false)]
		public DoubleSeries DrawdownSeries
		{
			get
			{
				return this.drawdownSeries;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000B17C File Offset: 0x0000A17C
		[Browsable(false)]
		public DoubleSeries PercentDrawdownSeries
		{
			get
			{
				return this.percentDrawdownSeries;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000B184 File Offset: 0x0000A184
		[Browsable(false)]
		public DoubleSeries WealthSeries
		{
			get
			{
				return this.wealthSeries;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000B18C File Offset: 0x0000A18C
		[Browsable(false)]
		public DoubleSeries CostSeries
		{
			get
			{
				return this.costSeries;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000B194 File Offset: 0x0000A194
		[Browsable(false)]
		public DoubleSeries ReturnSeries
		{
			get
			{
				return this.returnSeries;
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000B19C File Offset: 0x0000A19C
		private void component_PropertyChanged(TesterItem component)
		{
			this.EmitComponentChanged(component);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000B1A5 File Offset: 0x0000A1A5
		private void component_ComponentNameChanged(TesterItem component, ComponentNameEventArgs args)
		{
			this.EmitComponentNameChanged(component, args);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000B1AF File Offset: 0x0000A1AF
		private void components_ComponentListChanged(object sender, EventArgs e)
		{
			this.EmitComponentListChanged(sender, e);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000B1B9 File Offset: 0x0000A1B9
		public void SaveSettings()
		{
			this.settings = new TesterSettings(this);
			this.components.ActivateItemOnRequest = true;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000B1D3 File Offset: 0x0000A1D3
		public void RestoreSettings()
		{
			if (this.components.ActivateItemOnRequest)
			{
				this.components.ActivateItemOnRequest = false;
				this.settings.LoadState();
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000B1FC File Offset: 0x0000A1FC
		public void DisableComponents()
		{
			foreach (object obj in this.Components)
			{
				TesterItem testerItem = (TesterItem)obj;
				SeriesTesterItem seriesTesterItem = testerItem as SeriesTesterItem;
				if (seriesTesterItem != null)
				{
					seriesTesterItem.FillSeries = false;
					seriesTesterItem.Enabled = false;
				}
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000B268 File Offset: 0x0000A268
		public void SetSplitDate(DateTime date, Color color)
		{
			foreach (object obj in this.Components)
			{
				TesterItem testerItem = (TesterItem)obj;
				SeriesTesterItem seriesTesterItem = testerItem as SeriesTesterItem;
				if (seriesTesterItem != null)
				{
					seriesTesterItem.Series.SecondColor = color;
					seriesTesterItem.Series.SplitDate = date;
				}
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000B2DC File Offset: 0x0000A2DC
		private void LiveTester_ComponentEnabledChanged(object sender, EventArgs e)
		{
			this.EmitComponentEnabledChanged(sender as TesterItem);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000B2EA File Offset: 0x0000A2EA
		private void EmitComponentChanged(TesterItem component)
		{
			if (this.ComponentChanged != null)
			{
				this.ComponentChanged(component);
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000B300 File Offset: 0x0000A300
		private void EmitComponentNameChanged(TesterItem component, ComponentNameEventArgs args)
		{
			if (this.ComponentNameChanged != null)
			{
				this.ComponentNameChanged(component, args);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000B317 File Offset: 0x0000A317
		private void EmitComponentListChanged(object sender, EventArgs args)
		{
			if (this.ComponentListChanged != null)
			{
				this.ComponentListChanged(sender, args);
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000B32E File Offset: 0x0000A32E
		private void EmitComponentEnabledChanged(TesterItem component)
		{
			if (this.ComponentEnabledChanged != null)
			{
				this.ComponentEnabledChanged(component);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000B344 File Offset: 0x0000A344
		private void EmitChanged()
		{
			if (this.Changed != null)
			{
				this.Changed(this, EventArgs.Empty);
			}
		}

		// Token: 0x0400008E RID: 142
		protected TransactionList transactions;

		// Token: 0x0400008F RID: 143
		protected Portfolio portfolio;

		// Token: 0x04000090 RID: 144
		protected TimeIntervalSize timeInterval;

		// Token: 0x04000091 RID: 145
		protected TesterItemList components;

		// Token: 0x04000092 RID: 146
		protected Portfolio tempPortfolio;

		// Token: 0x04000093 RID: 147
		protected RoundTripList roundTripList;

		// Token: 0x04000094 RID: 148
		protected RoundTripList longRoundTripList;

		// Token: 0x04000095 RID: 149
		protected RoundTripList shortRoundTripList;

		// Token: 0x04000096 RID: 150
		protected bool isRoundTripsOnly;

		// Token: 0x04000097 RID: 151
		protected bool allowRoundTrips = true;

		// Token: 0x04000098 RID: 152
		protected Portfolio benchmark;

		// Token: 0x04000099 RID: 153
		protected LiveTester benchmarkTester;

		// Token: 0x0400009A RID: 154
		protected bool isTested;

		// Token: 0x0400009B RID: 155
		protected bool followChanges;

		// Token: 0x0400009C RID: 156
		protected double pnL;

		// Token: 0x0400009D RID: 157
		protected double wealth;

		// Token: 0x0400009E RID: 158
		protected double drawdown;

		// Token: 0x0400009F RID: 159
		protected double percentDrawdown;

		// Token: 0x040000A0 RID: 160
		protected double returnValue;

		// Token: 0x040000A1 RID: 161
		protected double cost;

		// Token: 0x040000A2 RID: 162
		protected double allocation;

		// Token: 0x040000A3 RID: 163
		protected double allocationLong;

		// Token: 0x040000A4 RID: 164
		protected double allocationShort;

		// Token: 0x040000A5 RID: 165
		protected double currentAccount;

		// Token: 0x040000A6 RID: 166
		protected double currentWealth;

		// Token: 0x040000A7 RID: 167
		protected double maxPreviousWealth;

		// Token: 0x040000A8 RID: 168
		protected DoubleSeries pnLSeries;

		// Token: 0x040000A9 RID: 169
		protected DoubleSeries wealthSeries;

		// Token: 0x040000AA RID: 170
		protected DoubleSeries returnSeries;

		// Token: 0x040000AB RID: 171
		protected DoubleSeries drawdownSeries;

		// Token: 0x040000AC RID: 172
		protected DoubleSeries percentDrawdownSeries;

		// Token: 0x040000AD RID: 173
		protected DoubleSeries costSeries;

		// Token: 0x040000AE RID: 174
		protected DoubleSeries allocationSeries;

		// Token: 0x040000AF RID: 175
		protected DoubleSeries allocationLongSeries;

		// Token: 0x040000B0 RID: 176
		protected DoubleSeries allocationShortSeries;

		// Token: 0x040000B1 RID: 177
		protected bool isAllocationLong;

		// Token: 0x040000B2 RID: 178
		protected bool isAllocationShort;

		// Token: 0x040000B3 RID: 179
		protected DateTime firstDate;

		// Token: 0x040000B4 RID: 180
		protected DateTime lastDate;

		// Token: 0x040000B5 RID: 181
		protected double initialWealth;

		// Token: 0x040000B6 RID: 182
		protected double riskFreeRate;

		// Token: 0x040000B7 RID: 183
		protected double totalCost;

		// Token: 0x040000B8 RID: 184
		protected bool businessDaysOnly;

		// Token: 0x040000B9 RID: 185
		protected bool waitingForStart;

		// Token: 0x040000BA RID: 186
		protected DateTime awaitTime;

		// Token: 0x040000BB RID: 187
		protected ReminderEventHandler awaitHandler;

		// Token: 0x040000BC RID: 188
		protected bool isNewData;

		// Token: 0x040000BD RID: 189
		protected bool connected;

		// Token: 0x040000BE RID: 190
		private Dictionary<Instrument, LiveTester> friendlyTesters = new Dictionary<Instrument, LiveTester>();

		// Token: 0x040000BF RID: 191
		private TesterSettings settings;
	}
}
