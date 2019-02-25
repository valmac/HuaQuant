using System;
using System.IO;
using System.Reflection;
using System.Threading;
using SmartQuant.FIX;
using SmartQuant.Providers.Xml;

namespace SmartQuant.Providers
{
	// Token: 0x02000030 RID: 48
	public class ProviderManager
	{
		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000100 RID: 256 RVA: 0x0000360C File Offset: 0x0000260C
		// (remove) Token: 0x06000101 RID: 257 RVA: 0x00003623 File Offset: 0x00002623
		public static event ProviderEventHandler Added;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000102 RID: 258 RVA: 0x0000363A File Offset: 0x0000263A
		// (remove) Token: 0x06000103 RID: 259 RVA: 0x00003651 File Offset: 0x00002651
		public static event ProviderEventHandler Connected;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000104 RID: 260 RVA: 0x00003668 File Offset: 0x00002668
		// (remove) Token: 0x06000105 RID: 261 RVA: 0x0000367F File Offset: 0x0000267F
		public static event ProviderEventHandler Disconnected;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000106 RID: 262 RVA: 0x00003696 File Offset: 0x00002696
		// (remove) Token: 0x06000107 RID: 263 RVA: 0x000036AD File Offset: 0x000026AD
		public static event ProviderEventHandler StatusChanged;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000108 RID: 264 RVA: 0x000036C4 File Offset: 0x000026C4
		// (remove) Token: 0x06000109 RID: 265 RVA: 0x000036DB File Offset: 0x000026DB
		public static event ProviderErrorEventHandler Error;

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x0600010A RID: 266 RVA: 0x000036F2 File Offset: 0x000026F2
		// (remove) Token: 0x0600010B RID: 267 RVA: 0x00003709 File Offset: 0x00002709
		public static event MarketDataRequestRejectEventHandler MarketDataRequestReject;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x0600010C RID: 268 RVA: 0x00003720 File Offset: 0x00002720
		// (remove) Token: 0x0600010D RID: 269 RVA: 0x00003737 File Offset: 0x00002737
		public static event TradeEventHandler NewTrade;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x0600010E RID: 270 RVA: 0x0000374E File Offset: 0x0000274E
		// (remove) Token: 0x0600010F RID: 271 RVA: 0x00003765 File Offset: 0x00002765
		public static event QuoteEventHandler NewQuote;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000110 RID: 272 RVA: 0x0000377C File Offset: 0x0000277C
		// (remove) Token: 0x06000111 RID: 273 RVA: 0x00003793 File Offset: 0x00002793
		public static event BarEventHandler NewBar;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000112 RID: 274 RVA: 0x000037AA File Offset: 0x000027AA
		// (remove) Token: 0x06000113 RID: 275 RVA: 0x000037C1 File Offset: 0x000027C1
		public static event BarEventHandler NewBarOpen;

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000114 RID: 276 RVA: 0x000037D8 File Offset: 0x000027D8
		// (remove) Token: 0x06000115 RID: 277 RVA: 0x000037EF File Offset: 0x000027EF
		public static event BarSliceEventHandler NewBarSlice;

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06000116 RID: 278 RVA: 0x00003806 File Offset: 0x00002806
		// (remove) Token: 0x06000117 RID: 279 RVA: 0x0000381D File Offset: 0x0000281D
		public static event MarketDepthEventHandler NewMarketDepth;

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000118 RID: 280 RVA: 0x00003834 File Offset: 0x00002834
		// (remove) Token: 0x06000119 RID: 281 RVA: 0x0000384B File Offset: 0x0000284B
		public static event FundamentalEventHandler NewFundamental;

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x0600011A RID: 282 RVA: 0x00003862 File Offset: 0x00002862
		// (remove) Token: 0x0600011B RID: 283 RVA: 0x00003879 File Offset: 0x00002879
		public static event CorporateActionEventHandler NewCorporateAction;

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x0600011C RID: 284 RVA: 0x00003890 File Offset: 0x00002890
		// (remove) Token: 0x0600011D RID: 285 RVA: 0x000038A7 File Offset: 0x000028A7
		public static event ExecutionReportEventHandler ExecutionReport;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x0600011E RID: 286 RVA: 0x000038BE File Offset: 0x000028BE
		// (remove) Token: 0x0600011F RID: 287 RVA: 0x000038D5 File Offset: 0x000028D5
		public static event OrderCancelRejectEventHandler OrderCancelReject;

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000395B File Offset: 0x0000295B
		public static ProviderList Providers
		{
			get
			{
				return ProviderManager.fProviders;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00003962 File Offset: 0x00002962
		public static ExecutionProviderList ExecutionProviders
		{
			get
			{
				return ProviderManager.fExecutionProviders;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00003969 File Offset: 0x00002969
		public static MarketDataProviderList MarketDataProviders
		{
			get
			{
				return ProviderManager.fMarketDataProviders;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00003970 File Offset: 0x00002970
		public static HistoryProviderList HistoryProviders
		{
			get
			{
				return ProviderManager.fHistoryProviders;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00003977 File Offset: 0x00002977
		public static InstrumentProviderList InstrumentProviders
		{
			get
			{
				return ProviderManager.fInstrumentProviders;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000397E File Offset: 0x0000297E
		public static HistoricalDataProviderList HistoricalDataProviders
		{
			get
			{
				return ProviderManager.fHistoricalDataProviders;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00003985 File Offset: 0x00002985
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000399B File Offset: 0x0000299B
		public static IExecutionProvider DefaultExecutionProvider
		{
			get
			{
				return ProviderManager.fExecutionProviders[Framework.Configuration.DefaultExecutionProvider];
			}
			set
			{
				if (value == null)
				{
					Framework.Configuration.DefaultExecutionProvider = "";
					return;
				}
				Framework.Configuration.DefaultExecutionProvider = value.Name;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000129 RID: 297 RVA: 0x000039C0 File Offset: 0x000029C0
		// (set) Token: 0x0600012A RID: 298 RVA: 0x000039D6 File Offset: 0x000029D6
		public static IMarketDataProvider DefaultMarketDataProvider
		{
			get
			{
				return ProviderManager.fMarketDataProviders[Framework.Configuration.DefaultMarketDataProvider];
			}
			set
			{
				if (value == null)
				{
					Framework.Configuration.DefaultMarketDataProvider = "";
					return;
				}
				Framework.Configuration.DefaultMarketDataProvider = value.Name;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000039FB File Offset: 0x000029FB
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00003A02 File Offset: 0x00002A02
		public static IMarketDataProvider MarketDataSimulator
		{
			get
			{
				return ProviderManager.fMarketDataSimulator;
			}
			set
			{
				ProviderManager.fMarketDataSimulator = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00003A0A File Offset: 0x00002A0A
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00003A11 File Offset: 0x00002A11
		public static IExecutionProvider ExecutionSimulator
		{
			get
			{
				return ProviderManager.fExecutionSimulator;
			}
			set
			{
				ProviderManager.fExecutionSimulator = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00003A19 File Offset: 0x00002A19
		public static ProviderErrorCollection Errors
		{
			get
			{
				return ProviderManager.fErrors;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003A20 File Offset: 0x00002A20
		public static void Add(IProvider provider)
		{
			if (Framework.Installation.Edition == Edition.Research)
			{
				byte id = provider.Id;
				switch (id)
				{
				case 1:
				case 2:
					break;
				default:
					switch (id)
					{
					case 17:
					case 19:
						break;
					default:
						return;
					}
					break;
				}
			}
			ProviderManager.fProviders.Add(provider);
			if (provider is IExecutionProvider)
			{
				ProviderManager.fExecutionProviders.Add(provider);
			}
			if (provider is IMarketDataProvider)
			{
				ProviderManager.fMarketDataProviders.Add(provider);
			}
			if (provider is IHistoryProvider)
			{
				ProviderManager.fHistoryProviders.Add(provider);
			}
			if (provider is IInstrumentProvider)
			{
				ProviderManager.fInstrumentProviders.Add(provider);
			}
			if (provider is IHistoricalDataProvider)
			{
				ProviderManager.fHistoricalDataProviders.Add(provider);
			}
			provider.Connected += ProviderManager.OnConnected;
			provider.Disconnected += ProviderManager.OnDisconnected;
			provider.StatusChanged += ProviderManager.OnStatusChanged;
			provider.Error += ProviderManager.OnError;
			ProviderManager.EmitAdded(provider);
			IMarketDataProvider marketDataProvider = provider as IMarketDataProvider;
			if (marketDataProvider != null)
			{
				marketDataProvider.NewQuote += ProviderManager.OnNewQuote;
				marketDataProvider.NewTrade += ProviderManager.OnNewTrade;
				marketDataProvider.NewBar += ProviderManager.OnNewBar;
				marketDataProvider.NewBarOpen += ProviderManager.OnNewBarOpen;
				marketDataProvider.NewBarSlice += ProviderManager.OnNewBarSlice;
				marketDataProvider.NewMarketDepth += ProviderManager.OnNewMarketDepth;
				marketDataProvider.NewFundamental += ProviderManager.OnNewFundamental;
				marketDataProvider.NewCorporateAction += ProviderManager.OnNewCorporateAction;
				marketDataProvider.MarketDataRequestReject += ProviderManager.OnMarketDataRequestReject;
			}
			IExecutionProvider executionProvider = provider as IExecutionProvider;
			if (executionProvider != null)
			{
				executionProvider.ExecutionReport += ProviderManager.OnExecutionReport;
				executionProvider.OrderCancelReject += ProviderManager.OnOrderCancelReject;
			}
			ProviderManager.LoadProviderProperties(provider);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00003C04 File Offset: 0x00002C04
		public static void Disconnect()
		{
			foreach (object obj in ProviderManager.fProviders)
			{
				IProvider provider = (IProvider)obj;
				provider.Disconnect();
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003C5C File Offset: 0x00002C5C
		public static void Shutdown()
		{
			foreach (object obj in ProviderManager.fProviders)
			{
				IProvider provider = (IProvider)obj;
				provider.Shutdown();
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00003CB4 File Offset: 0x00002CB4
		public static void WaitConnected(IProvider provider, int timeout)
		{
			long ticks = DateTime.Now.Ticks;
			while (!provider.IsConnected)
			{
				Thread.Sleep(1);
				double totalMilliseconds = TimeSpan.FromTicks(DateTime.Now.Ticks - ticks).TotalMilliseconds;
				if (totalMilliseconds >= (double)timeout)
				{
					return;
				}
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00003D04 File Offset: 0x00002D04
		public static void SaveProviderProperties()
		{
			ProviderListXmlDocument providerListXmlDocument = new ProviderListXmlDocument();
			foreach (object obj in ProviderManager.fProviders)
			{
				IProvider provider = (IProvider)obj;
				ProviderXmlNode providerXmlNode = providerListXmlDocument.CreateProviderNode();
				providerXmlNode.Name = provider.Name;
				foreach (PropertyInfo propertyInfo in provider.GetType().GetProperties())
				{
					if (propertyInfo.CanRead && propertyInfo.CanWrite && (propertyInfo.PropertyType.IsValueType || propertyInfo.PropertyType == typeof(string)))
					{
						object value = propertyInfo.GetValue(provider, null);
						if (value != null)
						{
							providerXmlNode.Properties.AddProperty(propertyInfo.Name, propertyInfo.PropertyType, value.ToString());
						}
					}
				}
				if (provider is IMarketDataProvider)
				{
					IBarFactory barFactory = (provider as IMarketDataProvider).BarFactory;
					if (barFactory != null)
					{
						BarFactoryXmlNode barFactoryXmlNode = providerXmlNode.CreateBarFactoryNode();
						barFactoryXmlNode.Type = barFactory.GetType();
						barFactoryXmlNode.Enabled = barFactory.Enabled;
						barFactoryXmlNode.Input = barFactory.Input;
						foreach (object obj2 in barFactory.Items)
						{
							BarFactoryItem item = (BarFactoryItem)obj2;
							barFactoryXmlNode.Items.AddItem(item);
						}
						foreach (PropertyInfo propertyInfo2 in barFactory.GetType().GetProperties())
						{
							if (propertyInfo2.DeclaringType != typeof(BarFactory) && propertyInfo2.CanRead && propertyInfo2.CanWrite && (propertyInfo2.PropertyType.IsValueType || propertyInfo2.PropertyType == typeof(string)))
							{
								object value2 = propertyInfo2.GetValue(barFactory, null);
								if (value2 != null)
								{
									barFactoryXmlNode.Properties.AddProperty(propertyInfo2.Name, propertyInfo2.PropertyType, value2.ToString());
								}
							}
						}
					}
				}
			}
			providerListXmlDocument.Save(Framework.Installation.IniDir.FullName + "\\provider.properties.xml");
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00003F84 File Offset: 0x00002F84
		public static void LoadProviderProperties(IProvider provider)
		{
			FileInfo fileInfo = new FileInfo(Framework.Installation.IniDir.FullName + "\\provider.properties.xml");
			if (fileInfo.Exists)
			{
				ProviderListXmlDocument providerListXmlDocument = new ProviderListXmlDocument();
				providerListXmlDocument.Load(fileInfo.FullName);
				ProviderXmlNode[] providers = providerListXmlDocument.GetProviders();
				int i = 0;
				while (i < providers.Length)
				{
					ProviderXmlNode providerXmlNode = providers[i];
					if (provider.Name == providerXmlNode.Name)
					{
						Type type = provider.GetType();
						foreach (object obj in providerXmlNode.Properties)
						{
							PropertyXmlNode propertyXmlNode = (PropertyXmlNode)obj;
							if (propertyXmlNode.Type != null)
							{
								PropertyInfo property = type.GetProperty(propertyXmlNode.Name, propertyXmlNode.Type);
								if (property != null)
								{
									object value;
									if (property.PropertyType.IsEnum)
									{
										value = Enum.Parse(property.PropertyType, propertyXmlNode.Value);
									}
									else if (property.PropertyType == typeof(string))
									{
										value = propertyXmlNode.Value;
									}
									else if (property.PropertyType == typeof(TimeSpan))
									{
										value = TimeSpan.Parse(propertyXmlNode.Value);
									}
									else
									{
										value = Convert.ChangeType(propertyXmlNode.Value, property.PropertyType);
									}
									property.SetValue(provider, value, null);
								}
							}
						}
						if (!(provider is IMarketDataProvider))
						{
							break;
						}
						BarFactoryXmlNode barFactory = providerXmlNode.BarFactory;
						if (barFactory != null)
						{
							IBarFactory barFactory2 = Activator.CreateInstance(barFactory.Type) as IBarFactory;
							barFactory2.Enabled = barFactory.Enabled;
							barFactory2.Input = barFactory.Input;
							barFactory2.Items.Clear();
							foreach (object obj2 in barFactory.Items)
							{
								BarFactoryItemXmlNode barFactoryItemXmlNode = (BarFactoryItemXmlNode)obj2;
								barFactory2.Items.Add(barFactoryItemXmlNode.BarType, barFactoryItemXmlNode.BarSize, barFactoryItemXmlNode.Enabled);
							}
							foreach (object obj3 in barFactory.Properties)
							{
								PropertyXmlNode propertyXmlNode2 = (PropertyXmlNode)obj3;
								PropertyInfo property2 = barFactory2.GetType().GetProperty(propertyXmlNode2.Name, propertyXmlNode2.Type);
								if (property2 != null)
								{
									object value2;
									if (property2.PropertyType.IsEnum)
									{
										value2 = Enum.Parse(property2.PropertyType, propertyXmlNode2.Value);
									}
									else if (property2.PropertyType == typeof(string))
									{
										value2 = propertyXmlNode2.Value;
									}
									else if (property2.PropertyType == typeof(TimeSpan))
									{
										value2 = TimeSpan.Parse(propertyXmlNode2.Value);
									}
									else
									{
										value2 = Convert.ChangeType(propertyXmlNode2.Value, property2.PropertyType);
									}
									property2.SetValue(barFactory2, value2, null);
								}
							}
							(provider as IMarketDataProvider).BarFactory = barFactory2;
							return;
						}
						break;
					}
					else
					{
						i++;
					}
				}
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000042EC File Offset: 0x000032EC
		private static void EmitAdded(IProvider provider)
		{
			if (ProviderManager.Added != null)
			{
				ProviderManager.Added(new ProviderEventArgs(provider));
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004308 File Offset: 0x00003308
		private static void OnConnected(object sender, EventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.Connected != null)
				{
					ProviderManager.Connected(new ProviderEventArgs(sender as IProvider));
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004368 File Offset: 0x00003368
		private static void OnDisconnected(object sender, EventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.Disconnected != null)
				{
					ProviderManager.Disconnected(new ProviderEventArgs(sender as IProvider));
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000043C8 File Offset: 0x000033C8
		private static void OnStatusChanged(object sender, EventArgs e)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.StatusChanged != null)
				{
					ProviderManager.StatusChanged(new ProviderEventArgs(sender as IProvider));
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004428 File Offset: 0x00003428
		private static void OnError(ProviderErrorEventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (Trace.IsLevelEnabled(TraceLevel.Error))
				{
					Trace.WriteLine(args.ToString() + Environment.NewLine);
				}
				ProviderManager.fErrors.Add(args.Error);
				if (ProviderManager.Error != null)
				{
					ProviderManager.Error(args);
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000044B0 File Offset: 0x000034B0
		private static void OnMarketDataRequestReject(object sender, MarketDataRequestRejectEventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.MarketDataRequestReject != null)
				{
					ProviderManager.MarketDataRequestReject(sender, args);
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00004508 File Offset: 0x00003508
		private static void OnNewBar(object sender, BarEventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.NewBar != null)
				{
					ProviderManager.NewBar(sender, args);
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004560 File Offset: 0x00003560
		private static void OnNewBarOpen(object sender, BarEventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.NewBarOpen != null)
				{
					ProviderManager.NewBarOpen(sender, args);
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000045B8 File Offset: 0x000035B8
		private static void OnNewBarSlice(object sender, BarSliceEventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.NewBarSlice != null)
				{
					ProviderManager.NewBarSlice(sender, args);
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00004610 File Offset: 0x00003610
		private static void OnNewTrade(object sender, TradeEventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.NewTrade != null)
				{
					ProviderManager.NewTrade(sender, args);
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00004668 File Offset: 0x00003668
		private static void OnNewQuote(object sender, QuoteEventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.NewQuote != null)
				{
					ProviderManager.NewQuote(sender, args);
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000046C0 File Offset: 0x000036C0
		private static void OnNewMarketDepth(object sender, MarketDepthEventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.NewMarketDepth != null)
				{
					ProviderManager.NewMarketDepth(sender, args);
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004718 File Offset: 0x00003718
		private static void OnNewFundamental(object sender, FundamentalEventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.NewFundamental != null)
				{
					ProviderManager.NewFundamental(sender, args);
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00004770 File Offset: 0x00003770
		private static void OnNewCorporateAction(object sender, CorporateActionEventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.NewCorporateAction != null)
				{
					ProviderManager.NewCorporateAction(sender, args);
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000047C8 File Offset: 0x000037C8
		private static void OnExecutionReport(object sender, ExecutionReportEventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.ExecutionReport != null)
				{
					ProviderManager.ExecutionReport(sender, args);
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00004820 File Offset: 0x00003820
		private static void OnOrderCancelReject(object sender, OrderCancelRejectEventArgs args)
		{
			if (ProviderManager.isSynchronized)
			{
				Monitor.Enter(ProviderManager.lockObject);
			}
			try
			{
				if (ProviderManager.OrderCancelReject != null)
				{
					ProviderManager.OrderCancelReject(sender, args);
				}
			}
			finally
			{
				if (ProviderManager.isSynchronized)
				{
					Monitor.Exit(ProviderManager.lockObject);
				}
			}
		}

		// Token: 0x0400005C RID: 92
		private const string PROPERTIES_FILE_NAME = "provider.properties.xml";

		// Token: 0x0400005D RID: 93
		private static object lockObject = new object();

		// Token: 0x0400005E RID: 94
		private static bool isSynchronized = false;

		// Token: 0x0400005F RID: 95
		private static ProviderList fProviders = new ProviderList();

		// Token: 0x04000060 RID: 96
		private static ExecutionProviderList fExecutionProviders = new ExecutionProviderList();

		// Token: 0x04000061 RID: 97
		private static MarketDataProviderList fMarketDataProviders = new MarketDataProviderList();

		// Token: 0x04000062 RID: 98
		private static HistoryProviderList fHistoryProviders = new HistoryProviderList();

		// Token: 0x04000063 RID: 99
		private static InstrumentProviderList fInstrumentProviders = new InstrumentProviderList();

		// Token: 0x04000064 RID: 100
		private static HistoricalDataProviderList fHistoricalDataProviders = new HistoricalDataProviderList();

		// Token: 0x04000065 RID: 101
		private static IMarketDataProvider fMarketDataSimulator = null;

		// Token: 0x04000066 RID: 102
		private static IExecutionProvider fExecutionSimulator = null;

		// Token: 0x04000067 RID: 103
		private static ProviderErrorCollection fErrors = new ProviderErrorCollection();
	}
}
