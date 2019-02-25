using System;
using System.ComponentModel;
using SmartQuant.Execution.Design;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace SmartQuant.Execution
{
	// Token: 0x02000003 RID: 3
	public class SingleOrder : NewOrderSingle, IOrder
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00001050
		// (remove) Token: 0x06000014 RID: 20 RVA: 0x00002069 File Offset: 0x00001069
		public event EventHandler StatusChanged;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000015 RID: 21 RVA: 0x00002082 File Offset: 0x00001082
		// (remove) Token: 0x06000016 RID: 22 RVA: 0x0000209B File Offset: 0x0000109B
		public event ExecutionReportEventHandler ExecutionReport;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000017 RID: 23 RVA: 0x000020B4 File Offset: 0x000010B4
		// (remove) Token: 0x06000018 RID: 24 RVA: 0x000020CD File Offset: 0x000010CD
		public event OrderCancelRejectEventHandler CancelReject;

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000020E6 File Offset: 0x000010E6
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000020EE File Offset: 0x000010EE
		[TypeConverter(typeof(IExecutionProviderTypeConverter))]
		[Description("Execution provider")]
		[ReadOnly(true)]
		[Category("Attributes")]
		public IExecutionProvider Provider
		{
			get
			{
				return this.fProvider;
			}
			set
			{
				this.fProvider = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000020F7 File Offset: 0x000010F7
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020FF File Offset: 0x000010FF
		[ReadOnly(true)]
		[Category("Attributes")]
		[Description("Portfolio")]
		public Portfolio Portfolio
		{
			get
			{
				return this.fPortfolio;
			}
			set
			{
				this.fPortfolio = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002108 File Offset: 0x00001108
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002130 File Offset: 0x00001130
		[Description("Instrument")]
		[Category("Attributes")]
		[ReadOnly(true)]
		public Instrument Instrument
		{
			get
			{
				if (this.fInstrument == null)
				{
					this.fInstrument = InstrumentManager.Instruments[base.Symbol];
				}
				return this.fInstrument;
			}
			set
			{
				this.fInstrument = value;
				if (this.fInstrument != null)
				{
					base.Symbol = this.fInstrument.Symbol;
					base.SecurityType = this.fInstrument.SecurityType;
					base.SecurityExchange = this.fInstrument.SecurityExchange;
					base.SecurityID = this.fInstrument.SecurityID;
					base.SecurityIDSource = this.fInstrument.SecurityIDSource;
					base.Currency = this.fInstrument.Currency;
					base.MaturityDate = this.fInstrument.MaturityDate;
					base.MaturityMonthYear = this.fInstrument.MaturityMonthYear;
					base.StrikePrice = this.fInstrument.StrikePrice;
					base.PutOrCall = (int)this.fInstrument.PutOrCall;
					if (!this.fInstrument.ContainsField(15))
					{
						base.Currency = Framework.Configuration.DefaultCurrency;
					}
					if (!this.fInstrument.ContainsField(207))
					{
						base.Currency = Framework.Configuration.DefaultExchange;
					}
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000223A File Offset: 0x0000123A
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002242 File Offset: 0x00001242
		[Category("Misc")]
		public bool Persistent
		{
			get
			{
				return this.fPersistent;
			}
			set
			{
				this.fPersistent = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000224B File Offset: 0x0000124B
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002253 File Offset: 0x00001253
		[Browsable(false)]
		public bool IsStopLimitReady
		{
			get
			{
				return this.fIsStopLimitReady;
			}
			set
			{
				this.fIsStopLimitReady = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000225C File Offset: 0x0000125C
		[Browsable(false)]
		public NewOrderSingle ReplaceOrder
		{
			get
			{
				return this.fReplaceOrder;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002264 File Offset: 0x00001264
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000226E File Offset: 0x0000126E
		[FIXField("37", EFieldOption.Optional)]
		[Browsable(false)]
		public string OrderID
		{
			get
			{
				return this.GetStringValue(37);
			}
			set
			{
				this.SetStringValue(37, value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002279 File Offset: 0x00001279
		[Browsable(false)]
		public ExecutionReportList Reports
		{
			get
			{
				return this.fReports;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002281 File Offset: 0x00001281
		[Browsable(false)]
		public OrderCancelRejectList Rejects
		{
			get
			{
				return this.fRejects;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002289 File Offset: 0x00001289
		[Browsable(false)]
		public bool IsNew
		{
			get
			{
				return this.OrdStatus == OrdStatus.New;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002297 File Offset: 0x00001297
		[Browsable(false)]
		public bool IsPartiallyFilled
		{
			get
			{
				return this.OrdStatus == OrdStatus.PartiallyFilled;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000022A5 File Offset: 0x000012A5
		[Browsable(false)]
		public bool IsFilled
		{
			get
			{
				return this.OrdStatus == OrdStatus.Filled;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000022B3 File Offset: 0x000012B3
		[Browsable(false)]
		public bool IsDoneForDay
		{
			get
			{
				return this.OrdStatus == OrdStatus.DoneForDay;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000022C1 File Offset: 0x000012C1
		[Browsable(false)]
		public bool IsCancelled
		{
			get
			{
				return this.OrdStatus == OrdStatus.Cancelled;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000022CF File Offset: 0x000012CF
		[Browsable(false)]
		public bool IsReplaced
		{
			get
			{
				return this.OrdStatus == OrdStatus.Replaced;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000022DD File Offset: 0x000012DD
		[Browsable(false)]
		public bool IsPendingCancel
		{
			get
			{
				return this.OrdStatus == OrdStatus.PendingCancel;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000022EB File Offset: 0x000012EB
		[Browsable(false)]
		public bool IsStopped
		{
			get
			{
				return this.OrdStatus == OrdStatus.Stopped;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000022F9 File Offset: 0x000012F9
		[Browsable(false)]
		public bool IsRejected
		{
			get
			{
				return this.OrdStatus == OrdStatus.Rejected;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002308 File Offset: 0x00001308
		[Browsable(false)]
		public bool IsSuspended
		{
			get
			{
				return this.OrdStatus == OrdStatus.Suspended;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002317 File Offset: 0x00001317
		[Browsable(false)]
		public bool IsPendingNew
		{
			get
			{
				return this.OrdStatus == OrdStatus.PendingNew;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002326 File Offset: 0x00001326
		[Browsable(false)]
		public bool IsCalculated
		{
			get
			{
				return this.OrdStatus == OrdStatus.Calculated;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002335 File Offset: 0x00001335
		[Browsable(false)]
		public bool IsExpired
		{
			get
			{
				return this.OrdStatus == OrdStatus.Expired;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002344 File Offset: 0x00001344
		[Browsable(false)]
		public bool IsAcceptedForBidding
		{
			get
			{
				return this.OrdStatus == OrdStatus.AcceptedForBidding;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002353 File Offset: 0x00001353
		[Browsable(false)]
		public bool IsPendingReplace
		{
			get
			{
				return this.OrdStatus == OrdStatus.PendingReplace;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002362 File Offset: 0x00001362
		[Browsable(false)]
		public bool IsDone
		{
			get
			{
				return this.IsFilled || this.IsCancelled || this.IsRejected;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000237C File Offset: 0x0000137C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000238B File Offset: 0x0000138B
		[Category("Execution")]
		public OrdStatus OrdStatus
		{
			get
			{
				return FIXOrdStatus.FromFIX(this.GetCharValue(39));
			}
			set
			{
				this.SetCharValue(39, FIXOrdStatus.ToFIX(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0000239B File Offset: 0x0000139B
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000023A5 File Offset: 0x000013A5
		[ReadOnly(true)]
		[FIXField("103", EFieldOption.Optional)]
		[Category("Execution")]
		public int OrdRejReason
		{
			get
			{
				return this.GetIntValue(103);
			}
			set
			{
				this.SetIntValue(103, value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000023B0 File Offset: 0x000013B0
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000023BD File Offset: 0x000013BD
		[ReadOnly(true)]
		[FIXField("151", EFieldOption.Required)]
		[Category("Execution")]
		public double LeavesQty
		{
			get
			{
				return this.GetDoubleValue(151);
			}
			set
			{
				this.SetDoubleValue(151, value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000023CB File Offset: 0x000013CB
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000023D5 File Offset: 0x000013D5
		[FIXField("14", EFieldOption.Required)]
		[ReadOnly(true)]
		[Category("Execution")]
		public double CumQty
		{
			get
			{
				return this.GetDoubleValue(14);
			}
			set
			{
				this.SetDoubleValue(14, value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000023E0 File Offset: 0x000013E0
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000023E9 File Offset: 0x000013E9
		[Category("Execution")]
		[FIXField("6", EFieldOption.Required)]
		[ReadOnly(true)]
		public double AvgPx
		{
			get
			{
				return this.GetDoubleValue(6);
			}
			set
			{
				this.SetDoubleValue(6, value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000023F3 File Offset: 0x000013F3
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000023FD File Offset: 0x000013FD
		[ReadOnly(true)]
		[Category("Execution")]
		[FIXField("32", EFieldOption.Optional)]
		public double LastQty
		{
			get
			{
				return this.GetDoubleValue(32);
			}
			set
			{
				this.SetDoubleValue(32, value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002408 File Offset: 0x00001408
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002412 File Offset: 0x00001412
		[FIXField("31", EFieldOption.Optional)]
		[Category("Execution")]
		[ReadOnly(true)]
		public double LastPx
		{
			get
			{
				return this.GetDoubleValue(31);
			}
			set
			{
				this.SetDoubleValue(31, value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000241D File Offset: 0x0000141D
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0000242A File Offset: 0x0000142A
		[Category("Simulation")]
		[FIXField("11200", EFieldOption.Optional)]
		[Description("Force market order execution")]
		public bool ForceMarketOrder
		{
			get
			{
				return this.GetBoolValue(11200);
			}
			set
			{
				this.SetBoolValue(11200, value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002438 File Offset: 0x00001438
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002445 File Offset: 0x00001445
		[FIXField("11201", EFieldOption.Optional)]
		[Category("Simulation")]
		[Description("FillOnBar mode")]
		public int FillOnBarMode
		{
			get
			{
				return this.GetIntValue(11201);
			}
			set
			{
				this.SetIntValue(11201, value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002453 File Offset: 0x00001453
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002460 File Offset: 0x00001460
		[FIXField("11100", EFieldOption.Optional)]
		[Category("Strategy")]
		[Description("Strategy that sends this order")]
		public string Strategy
		{
			get
			{
				return this.GetStringValue(11100);
			}
			set
			{
				this.SetStringValue(11100, value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000246E File Offset: 0x0000146E
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000247B File Offset: 0x0000147B
		[FIXField("11101", EFieldOption.Optional)]
		[Description("Strategy component that sends this order")]
		[Category("Strategy")]
		public string StrategyComponent
		{
			get
			{
				return this.GetStringValue(11101);
			}
			set
			{
				this.SetStringValue(11101, value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002489 File Offset: 0x00001489
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002496 File Offset: 0x00001496
		[Category("Strategy")]
		[Description("")]
		[FIXField("11102", EFieldOption.Optional)]
		public double StrategyPrice
		{
			get
			{
				return this.GetDoubleValue(11102);
			}
			set
			{
				this.SetDoubleValue(11102, value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000024A4 File Offset: 0x000014A4
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000024B1 File Offset: 0x000014B1
		[Category("Strategy")]
		[FIXField("11103", EFieldOption.Optional)]
		[Description("")]
		public bool StrategyFill
		{
			get
			{
				return this.GetBoolValue(11103);
			}
			set
			{
				this.SetBoolValue(11103, value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000024BF File Offset: 0x000014BF
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000024CC File Offset: 0x000014CC
		[Category("Strategy")]
		[Description("")]
		[FIXField("11104", EFieldOption.Optional)]
		public char StrategyMode
		{
			get
			{
				return this.GetCharValue(11104);
			}
			set
			{
				this.SetCharValue(11104, value);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000024DC File Offset: 0x000014DC
		public SingleOrder()
		{
			base.ClOrdID = OrderManager.GetNextClOrdId();
			this.OrdStatus = OrdStatus.PendingNew;
			base.HandlInst = '2';
			base.TimeInForce = TimeInForce.Day;
			base.Currency = Framework.Configuration.DefaultCurrency;
			this.Persistent = false;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002549 File Offset: 0x00001549
		public void Send()
		{
			base.TransactTime = Clock.Now;
			OrderManager.Send(this);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000255C File Offset: 0x0000155C
		public void Cancel()
		{
			OrderManager.Cancel(this);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002564 File Offset: 0x00001564
		public void Replace()
		{
			OrderManager.Replace(this);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000256C File Offset: 0x0000156C
		internal void Add(ExecutionReport report)
		{
			if (report.OrdStatus == OrdStatus.New || report.OrdStatus == OrdStatus.PendingNew)
			{
				this.OrderID = report.OrderID;
			}
			if (report.Text == "")
			{
				report.Text = base.Text;
			}
			this.CumQty = report.CumQty;
			this.LeavesQty = report.LeavesQty;
			this.AvgPx = report.AvgPx;
			this.OrdStatus = report.OrdStatus;
			if (report.OrdStatus == OrdStatus.PartiallyFilled || report.OrdStatus == OrdStatus.Filled)
			{
				this.LastPx = report.LastPx;
				this.LastQty = report.LastQty;
			}
			this.fReports.Add(report);
			if (this.ExecutionReport != null)
			{
				this.ExecutionReport(this, new ExecutionReportEventArgs(report));
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002637 File Offset: 0x00001637
		internal void Add(OrderCancelReject reject)
		{
			this.OrdStatus = reject.OrdStatus;
			this.fRejects.Add(reject);
			if (this.CancelReject != null)
			{
				this.CancelReject(this, new OrderCancelRejectEventArgs(reject));
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000266C File Offset: 0x0000166C
		internal void EmitStatusChanged()
		{
			if (this.StatusChanged != null)
			{
				this.StatusChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002687 File Offset: 0x00001687
        //public string ClOrdID
        //{
        //    get { return this.ClOrdID; }
        //    set { this.ClOrdID = value; }
        //}


		// Token: 0x04000001 RID: 1
		private const string CATEGORY_STRATEGY = "Strategy";

		// Token: 0x04000002 RID: 2
		private const string CATEGORY_SIMULATION = "Simulation";

		// Token: 0x04000006 RID: 6
		private IExecutionProvider fProvider;

		// Token: 0x04000007 RID: 7
		private Portfolio fPortfolio;

		// Token: 0x04000008 RID: 8
		private Instrument fInstrument;

		// Token: 0x04000009 RID: 9
		private ExecutionReportList fReports = new ExecutionReportList();

		// Token: 0x0400000A RID: 10
		private OrderCancelRejectList fRejects = new OrderCancelRejectList();

		// Token: 0x0400000B RID: 11
		private bool fPersistent;

		// Token: 0x0400000C RID: 12
		private bool fIsStopLimitReady;

		// Token: 0x0400000D RID: 13
		private NewOrderSingle fReplaceOrder = new NewOrderSingle();
	}
}
