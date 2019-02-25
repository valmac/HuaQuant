using System;
using SmartQuant.Data;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace SmartQuant.Trading
{
	// Token: 0x0200000E RID: 14
	public abstract class MultiInstrumentComponent : ComponentBase
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00005032 File Offset: 0x00004032
		public virtual void OnMarketData(Instrument instrument, IMarketData data)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005034 File Offset: 0x00004034
		public virtual void OnBar(Instrument instrument, Bar bar)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00005036 File Offset: 0x00004036
		public virtual void OnBarOpen(Instrument instrument, Bar bar)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00005038 File Offset: 0x00004038
		public virtual void OnTrade(Instrument instrument, Trade trade)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000503A File Offset: 0x0000403A
		public virtual void OnQuote(Instrument instrument, Quote quote)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000503C File Offset: 0x0000403C
		public virtual void OnMarketDepth(Instrument instrument, MarketDepth marketDepth)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000503E File Offset: 0x0000403E
		public virtual void OnFundamental(Instrument instrument, Fundamental fundamental)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00005040 File Offset: 0x00004040
		public virtual void OnCorporateAction(Instrument instrument, CorporateAction corporateAction)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005042 File Offset: 0x00004042
		public virtual void OnPositionOpened(Position position)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00005044 File Offset: 0x00004044
		public virtual void OnPositionClosed(Position position)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005046 File Offset: 0x00004046
		public virtual void OnPositionChanged(Position position)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005048 File Offset: 0x00004048
		public virtual void OnPositionValueChanged(Position position)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000504A File Offset: 0x0000404A
		public virtual void OnNewOrder(SingleOrder order)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000504C File Offset: 0x0000404C
		public virtual void OnExecutionReport(SingleOrder order, ExecutionReport report)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000504E File Offset: 0x0000404E
		public virtual void OnOrderPartiallyFilled(SingleOrder order)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005050 File Offset: 0x00004050
		public virtual void OnOrderStatusChanged(SingleOrder order)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005052 File Offset: 0x00004052
		public virtual void OnOrderDone(SingleOrder order)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005054 File Offset: 0x00004054
		public virtual void OnOrderFilled(SingleOrder order)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005056 File Offset: 0x00004056
		public virtual void OnOrderCancelled(SingleOrder order)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005058 File Offset: 0x00004058
		public virtual void OnOrderRejected(SingleOrder order)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000505A File Offset: 0x0000405A
		public virtual void OnProviderConnected(IProvider provider)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000505C File Offset: 0x0000405C
		public virtual void OnProviderDisconnected(IProvider provider)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000505E File Offset: 0x0000405E
		public virtual void OnProviderError(IProvider provider, int id, int code, string message)
		{
		}
	}
}
