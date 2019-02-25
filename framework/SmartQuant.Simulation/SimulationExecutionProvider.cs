using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.Providers;

namespace SmartQuant.Simulation
{
	// Token: 0x0200001D RID: 29
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class SimulationExecutionProvider : IExecutionProvider, IProvider
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060000CA RID: 202 RVA: 0x00005CDB File Offset: 0x00004CDB
		// (remove) Token: 0x060000CB RID: 203 RVA: 0x00005CF4 File Offset: 0x00004CF4
		public event EventHandler Connected;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060000CC RID: 204 RVA: 0x00005D0D File Offset: 0x00004D0D
		// (remove) Token: 0x060000CD RID: 205 RVA: 0x00005D26 File Offset: 0x00004D26
		public event EventHandler Disconnected;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060000CE RID: 206 RVA: 0x00005D3F File Offset: 0x00004D3F
		// (remove) Token: 0x060000CF RID: 207 RVA: 0x00005D58 File Offset: 0x00004D58
		public event ProviderErrorEventHandler Error;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060000D0 RID: 208 RVA: 0x00005D71 File Offset: 0x00004D71
		// (remove) Token: 0x060000D1 RID: 209 RVA: 0x00005D8A File Offset: 0x00004D8A
		public event EventHandler StatusChanged;

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005DA3 File Offset: 0x00004DA3
		[Category("Information")]
		public string Name
		{
			get
			{
				return "Simulator(execution)";
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00005DAA File Offset: 0x00004DAA
		[Category("Information")]
		public string Title
		{
			get
			{
				return "Simulation Execution Provider";
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00005DB1 File Offset: 0x00004DB1
		[Category("Information")]
		public byte Id
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00005DB4 File Offset: 0x00004DB4
		[Category("Information")]
		public string URL
		{
			get
			{
				return "www.smartquant.com";
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00005DBB File Offset: 0x00004DBB
		[Category("Status")]
		public bool IsConnected
		{
			get
			{
				return this.fIsConnected;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00005DC3 File Offset: 0x00004DC3
		[Category("Status")]
		public ProviderStatus Status
		{
			get
			{
				return this.fStatus;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005DCC File Offset: 0x00004DCC
		public void Connect()
		{
			if (!this.fIsConnected)
			{
				this.fIsConnected = true;
				this.fStatus = ProviderStatus.Connected;
				if (this.Connected != null)
				{
					this.Connected(this, EventArgs.Empty);
				}
				if (this.StatusChanged != null)
				{
					this.StatusChanged(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005E21 File Offset: 0x00004E21
		public void Connect(int timeout)
		{
			this.Connect();
			ProviderManager.WaitConnected(this, timeout);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005E30 File Offset: 0x00004E30
		public void Disconnect()
		{
			if (this.fIsConnected)
			{
				foreach (object obj in new ArrayList(this.fProcessors.Values))
				{
					SimulationExecutionProcessor simulationExecutionProcessor = (SimulationExecutionProcessor)obj;
					simulationExecutionProcessor.Cancel();
				}
				this.fIsConnected = false;
				this.fStatus = ProviderStatus.Disconnected;
				if (this.Disconnected != null)
				{
					this.Disconnected(this, EventArgs.Empty);
				}
				if (this.StatusChanged != null)
				{
					this.StatusChanged(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005EE0 File Offset: 0x00004EE0
		public void Shutdown()
		{
			this.Disconnect();
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060000DC RID: 220 RVA: 0x00005EE8 File Offset: 0x00004EE8
		// (remove) Token: 0x060000DD RID: 221 RVA: 0x00005F01 File Offset: 0x00004F01
		public event ExecutionReportEventHandler ExecutionReport;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060000DE RID: 222 RVA: 0x00005F1A File Offset: 0x00004F1A
		// (remove) Token: 0x060000DF RID: 223 RVA: 0x00005F33 File Offset: 0x00004F33
		public event OrderCancelRejectEventHandler OrderCancelReject;

		// Token: 0x060000E0 RID: 224 RVA: 0x00005F4C File Offset: 0x00004F4C
		public void SendNewOrderSingle(NewOrderSingle order)
		{
			SingleOrder singleOrder = order as SingleOrder;
			if (singleOrder.IsFilled || singleOrder.IsCancelled)
			{
				return;
			}
			this.EmitExecutionReport(new ExecutionReport
			{
				TransactTime = Clock.Now,
				ClOrdID = order.ClOrdID,
				ExecType = ExecType.New,
				OrdStatus = OrdStatus.New,
				Symbol = order.Symbol,
				OrdType = order.OrdType,
				Side = order.Side,
				Price = order.Price,
				StopPx = order.StopPx,
				OrderQty = order.OrderQty,
				CumQty = 0.0,
				LeavesQty = order.OrderQty,
				Currency = order.Currency,
				Text = order.Text
			});
			new SimulationExecutionProcessor(this, order);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00006028 File Offset: 0x00005028
		public void SendOrderCancelRequest(FIXOrderCancelRequest request)
		{
			SimulationExecutionProcessor simulationExecutionProcessor = this.fProcessors[request.OrigClOrdID] as SimulationExecutionProcessor;
			if (simulationExecutionProcessor != null)
			{
				simulationExecutionProcessor.Cancel();
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00006058 File Offset: 0x00005058
		public void SendOrderCancelReplaceRequest(FIXOrderCancelReplaceRequest request)
		{
			SimulationExecutionProcessor simulationExecutionProcessor = this.fProcessors[request.OrigClOrdID] as SimulationExecutionProcessor;
			if (simulationExecutionProcessor != null)
			{
				simulationExecutionProcessor.Replace(request);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006086 File Offset: 0x00005086
		public void SendOrderStatusRequest(FIXOrderStatusRequest request)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000608D File Offset: 0x0000508D
		public BrokerInfo GetBrokerInfo()
		{
			throw new NotImplementedException();
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00006094 File Offset: 0x00005094
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000609C File Offset: 0x0000509C
		[Category("Fill Data")]
		[DefaultValue(true)]
		public bool PartialFills
		{
			get
			{
				return this.partialFills;
			}
			set
			{
				this.partialFills = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000060A5 File Offset: 0x000050A5
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000060AD File Offset: 0x000050AD
		[Category("Fill Data")]
		[DefaultValue(true)]
		public bool FillOnQuote
		{
			get
			{
				return this.fFillOnQuote;
			}
			set
			{
				this.fFillOnQuote = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000060B6 File Offset: 0x000050B6
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000060BE File Offset: 0x000050BE
		[DefaultValue(true)]
		[Category("Fill Data")]
		public bool FillOnTrade
		{
			get
			{
				return this.fFillOnTrade;
			}
			set
			{
				this.fFillOnTrade = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000060C7 File Offset: 0x000050C7
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000060CF File Offset: 0x000050CF
		[Category("Fill Data")]
		[DefaultValue(true)]
		public bool FillOnBar
		{
			get
			{
				return this.fFillOnBar;
			}
			set
			{
				this.fFillOnBar = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000060D8 File Offset: 0x000050D8
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000060E0 File Offset: 0x000050E0
		[Category("Fill Mode")]
		[DefaultValue(FillOnTradeMode.LastTrade)]
		public FillOnTradeMode FillOnTradeMode
		{
			get
			{
				return this.fFillOnTradeMode;
			}
			set
			{
				this.fFillOnTradeMode = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000060E9 File Offset: 0x000050E9
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000060F1 File Offset: 0x000050F1
		[Category("Fill Mode")]
		[DefaultValue(FillOnQuoteMode.LastQuote)]
		public FillOnQuoteMode FillOnQuoteMode
		{
			get
			{
				return this.fFillOnQuoteMode;
			}
			set
			{
				this.fFillOnQuoteMode = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000060FA File Offset: 0x000050FA
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00006102 File Offset: 0x00005102
		[DefaultValue(FillOnBarMode.LastBarClose)]
		[Category("Fill Mode")]
		public FillOnBarMode FillOnBarMode
		{
			get
			{
				return this.fFillOnBarMode;
			}
			set
			{
				this.fFillOnBarMode = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000610B File Offset: 0x0000510B
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00006113 File Offset: 0x00005113
		[Category("Commission & Slippage")]
		public ICommissionProvider CommissionProvider
		{
			get
			{
				return this.fCommissionProvider;
			}
			set
			{
				this.fCommissionProvider = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000611C File Offset: 0x0000511C
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000061B0 File Offset: 0x000051B0
		[Browsable(false)]
		public string CommissionProviderStr
		{
			get
			{
				List<string> list = new List<string>();
				if (this.fCommissionProvider != null)
				{
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					list.Add(this.fCommissionProvider.CommType.ToString());
					list.Add(this.fCommissionProvider.Commission.ToString(invariantCulture));
					if (this.fCommissionProvider is CommissionProvider)
					{
						list.Add((this.fCommissionProvider as CommissionProvider).MinCommission.ToString(invariantCulture));
					}
				}
				return string.Join("|", list.ToArray());
			}
			set
			{
				if (this.fCommissionProvider == null || value == null)
				{
					return;
				}
				string[] array = value.Split(new char[]
				{
					'|'
				});
				if (array.Length < 2)
				{
					return;
				}
				if (Enum.IsDefined(typeof(CommType), array[0]))
				{
					this.fCommissionProvider.CommType = (CommType)Enum.Parse(typeof(CommType), array[0]);
				}
				double commission;
				if (double.TryParse(array[1], NumberStyles.Float, CultureInfo.InvariantCulture, out commission))
				{
					this.fCommissionProvider.Commission = commission;
				}
				double minCommission;
				if (this.fCommissionProvider is CommissionProvider && array.Length == 3 && double.TryParse(array[2], NumberStyles.Float, CultureInfo.InvariantCulture, out minCommission))
				{
					(this.fCommissionProvider as CommissionProvider).MinCommission = minCommission;
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00006276 File Offset: 0x00005276
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000627E File Offset: 0x0000527E
		[Category("Commission & Slippage")]
		public ISlippageProvider SlippageProvider
		{
			get
			{
				return this.fSlippageProvider;
			}
			set
			{
				this.fSlippageProvider = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00006287 File Offset: 0x00005287
		[Category("Fill Data")]
		public BarFilter BarFilter
		{
			get
			{
				return this.fBarFilter;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000628F File Offset: 0x0000528F
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000629C File Offset: 0x0000529C
		[Browsable(false)]
		public string BarFilterString
		{
			get
			{
				return this.fBarFilter.ToString();
			}
			set
			{
				this.fBarFilter.FromString(value);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000062AC File Offset: 0x000052AC
		public SimulationExecutionProvider()
		{
			ProviderManager.Add(this);
			ProviderManager.ExecutionSimulator = this;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000631A File Offset: 0x0000531A
		internal void EmitExecutionReport(ExecutionReport report)
		{
			if (this.ExecutionReport != null)
			{
				this.ExecutionReport(this, new ExecutionReportEventArgs(report));
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00006336 File Offset: 0x00005336
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x04000079 RID: 121
		private const string PROVIDER_NAME = "Simulator(execution)";

		// Token: 0x0400007A RID: 122
		private const string PROVIDER_TITLE = "Simulation Execution Provider";

		// Token: 0x0400007B RID: 123
		private const string PROVIDER_URL = "www.smartquant.com";

		// Token: 0x0400007C RID: 124
		private const byte PROVIDER_ID = 2;

		// Token: 0x0400007D RID: 125
		private const string CATEGORY_INFO = "Information";

		// Token: 0x0400007E RID: 126
		private const string CATEGORY_STATUS = "Status";

		// Token: 0x0400007F RID: 127
		private const string CATEGORY_FILL_DATA = "Fill Data";

		// Token: 0x04000080 RID: 128
		private const string CATEGORY_FILL_MODE = "Fill Mode";

		// Token: 0x04000081 RID: 129
		private const string CATEGORY_PROVIDERS = "Commission & Slippage";

		// Token: 0x04000088 RID: 136
		private bool fIsConnected;

		// Token: 0x04000089 RID: 137
		private ProviderStatus fStatus = ProviderStatus.Unknown;

		// Token: 0x0400008A RID: 138
		internal Hashtable fProcessors = new Hashtable();

		// Token: 0x0400008B RID: 139
		private bool fFillOnQuote = true;

		// Token: 0x0400008C RID: 140
		private bool fFillOnTrade = true;

		// Token: 0x0400008D RID: 141
		private bool fFillOnBar = true;

		// Token: 0x0400008E RID: 142
		private FillOnTradeMode fFillOnTradeMode;

		// Token: 0x0400008F RID: 143
		private FillOnQuoteMode fFillOnQuoteMode;

		// Token: 0x04000090 RID: 144
		private FillOnBarMode fFillOnBarMode;

		// Token: 0x04000091 RID: 145
		private bool partialFills = true;

		// Token: 0x04000092 RID: 146
		private ICommissionProvider fCommissionProvider = new CommissionProvider();

		// Token: 0x04000093 RID: 147
		private ISlippageProvider fSlippageProvider = new SlippageProvider();

		// Token: 0x04000094 RID: 148
		private BarFilter fBarFilter = new BarFilter();
	}
}
