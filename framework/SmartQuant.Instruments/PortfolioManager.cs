using System;

namespace SmartQuant.Instruments
{
	// Token: 0x02000010 RID: 16
	public class PortfolioManager
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000294E File Offset: 0x0000194E
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002964 File Offset: 0x00001964
		public static Portfolio DefaultPortfolio
		{
			get
			{
				return PortfolioManager.portfolios[Framework.Configuration.DefaultPortfolio];
			}
			set
			{
				Framework.Configuration.DefaultPortfolio = value.Name;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002976 File Offset: 0x00001976
		static PortfolioManager()
		{
            //PortfolioManager.server = new PortfolioOleDbServer();
            PortfolioManager.server = new PortfolioSQLiteServer();
			PortfolioManager.server.Open();
			PortfolioManager.portfolios = PortfolioManager.server.Load();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000029A5 File Offset: 0x000019A5
		public static void Init()
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600004E RID: 78 RVA: 0x000029A7 File Offset: 0x000019A7
		// (remove) Token: 0x0600004F RID: 79 RVA: 0x000029BE File Offset: 0x000019BE
		public static event PortfolioEventHandler PortfolioAdded;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000050 RID: 80 RVA: 0x000029D5 File Offset: 0x000019D5
		// (remove) Token: 0x06000051 RID: 81 RVA: 0x000029EC File Offset: 0x000019EC
		public static event PortfolioEventHandler PortfolioRemoved;

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002A03 File Offset: 0x00001A03
		public static PortfolioList Portfolios
		{
			get
			{
				return PortfolioManager.portfolios;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002A0A File Offset: 0x00001A0A
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002A11 File Offset: 0x00001A11
		public static IPortfolioServer Server
		{
			get
			{
				return PortfolioManager.server;
			}
			set
			{
				PortfolioManager.server = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002A19 File Offset: 0x00001A19
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002A20 File Offset: 0x00001A20
		public static IPortfolioPricer Pricer
		{
			get
			{
				return PortfolioManager.pricer;
			}
			set
			{
				PortfolioManager.pricer = value;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002A28 File Offset: 0x00001A28
		internal static void Add(Portfolio portfolio)
		{
			PortfolioManager.portfolios.Add(portfolio);
			PortfolioManager.EmitPortfolioAdded(portfolio);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002A3B File Offset: 0x00001A3B
		public static void Remove(Portfolio portfolio)
		{
			PortfolioManager.server.Remove(portfolio);
			PortfolioManager.portfolios.Remove(portfolio);
			PortfolioManager.EmitPortfolioRemoved(portfolio);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002A59 File Offset: 0x00001A59
		internal static void Save(Portfolio portfolio)
		{
			PortfolioManager.server.Save(portfolio);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002A66 File Offset: 0x00001A66
		internal static void Update(Portfolio portfolio)
		{
			PortfolioManager.server.Update(portfolio);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002A73 File Offset: 0x00001A73
		internal static void Add(Portfolio portfolio, Transaction transaction)
		{
			PortfolioManager.server.Add(portfolio, transaction);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002A81 File Offset: 0x00001A81
		internal static void Add(Portfolio portfolio, AccountTransaction transaction)
		{
			PortfolioManager.server.Add(portfolio, transaction);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002A8F File Offset: 0x00001A8F
		internal static void Clear(Portfolio portfolio)
		{
			PortfolioManager.server.Clear(portfolio);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002A9C File Offset: 0x00001A9C
		private static void EmitPortfolioAdded(Portfolio portfolio)
		{
			if (PortfolioManager.PortfolioAdded != null)
			{
				PortfolioManager.PortfolioAdded(new PortfolioEventArgs(portfolio));
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002AB5 File Offset: 0x00001AB5
		private static void EmitPortfolioRemoved(Portfolio portfolio)
		{
			if (PortfolioManager.PortfolioRemoved != null)
			{
				PortfolioManager.PortfolioRemoved(new PortfolioEventArgs(portfolio));
			}
		}

		// Token: 0x0400000D RID: 13
		private static IPortfolioServer server;

		// Token: 0x0400000E RID: 14
		private static PortfolioList portfolios;

		// Token: 0x0400000F RID: 15
		private static IPortfolioPricer pricer = new PortfolioPricer();
	}
}
