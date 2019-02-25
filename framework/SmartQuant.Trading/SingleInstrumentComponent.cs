using System;
using System.ComponentModel;
using SmartQuant.Data;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000027 RID: 39
	public abstract class SingleInstrumentComponent : ComponentBase
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000065A7 File Offset: 0x000055A7
		// (set) Token: 0x06000188 RID: 392 RVA: 0x000065AF File Offset: 0x000055AF
		[Browsable(false)]
		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
			set
			{
				this.instrument = value;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000065B8 File Offset: 0x000055B8
		public virtual void OnMarketData(IMarketData data)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000065BA File Offset: 0x000055BA
		public virtual void OnBar(Bar bar)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000065BC File Offset: 0x000055BC
		public virtual void OnBarOpen(Bar bar)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000065BE File Offset: 0x000055BE
		public virtual void OnTrade(Trade trade)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000065C0 File Offset: 0x000055C0
		public virtual void OnQuote(Quote quote)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000065C2 File Offset: 0x000055C2
		public virtual void OnMarketDepth(MarketDepth marketDepth)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000065C4 File Offset: 0x000055C4
		public virtual void OnFundamental(Fundamental fundamental)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000065C6 File Offset: 0x000055C6
		public virtual void OnCorporateAction(CorporateAction corporateAction)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000065C8 File Offset: 0x000055C8
		public virtual void OnNews(FIXNews news)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000065CA File Offset: 0x000055CA
		public virtual void OnPositionOpened()
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000065CC File Offset: 0x000055CC
		public virtual void OnPositionClosed()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000065CE File Offset: 0x000055CE
		public virtual void OnPositionChanged()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000065D0 File Offset: 0x000055D0
		public virtual void OnPositionValueChanged()
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000065D2 File Offset: 0x000055D2
		public virtual void OnNewOrder(SingleOrder order)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000065D4 File Offset: 0x000055D4
		public virtual void OnExecutionReport(SingleOrder order, ExecutionReport report)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000065D6 File Offset: 0x000055D6
		public virtual void OnOrderPartiallyFilled(SingleOrder order)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000065D8 File Offset: 0x000055D8
		public virtual void OnOrderStatusChanged(SingleOrder order)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000065DA File Offset: 0x000055DA
		public virtual void OnOrderDone(SingleOrder order)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000065DC File Offset: 0x000055DC
		public virtual void OnOrderFilled(SingleOrder order)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000065DE File Offset: 0x000055DE
		public virtual void OnOrderCancelled(SingleOrder order)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000065E0 File Offset: 0x000055E0
		public virtual void OnOrderRejected(SingleOrder order)
		{
		}

		// Token: 0x0400008A RID: 138
		protected Instrument instrument;
	}
}
