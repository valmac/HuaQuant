using System;
using System.Collections;
using System.Threading;
using SmartQuant.Providers;

namespace SmartQuant.Instruments
{
	// Token: 0x0200004A RID: 74
	internal class HistoricalDataDownloader
	{
		// Token: 0x06000394 RID: 916 RVA: 0x0000C44D File Offset: 0x0000B44D
		public HistoricalDataDownloader(IHistoricalDataProvider provider, HistoricalDataRequest request)
		{
			this.provider = provider;
			this.request = request;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000C464 File Offset: 0x0000B464
		public ArrayList GetObjects()
		{
			this.list = new ArrayList();
			this.semaphore = new Semaphore(0, 1);
			this.SubscribeToEvents();
			this.provider.SendHistoricalDataRequest(this.request);
			this.semaphore.WaitOne();
			this.semaphore.Release();
			this.UnsubscribeFromEvents();
			return this.list;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000C4C4 File Offset: 0x0000B4C4
		private void SubscribeToEvents()
		{
			this.provider.NewHistoricalQuote += this.provider_NewHistoricalQuote;
			this.provider.NewHistoricalTrade += this.provider_NewHistoricalTrade;
			this.provider.NewHistoricalBar += this.provider_NewHistoricalBar;
			this.provider.HistoricalDataRequestCompleted += this.provider_HistoricalDataRequestCompleted;
			this.provider.HistoricalDataRequestCancelled += this.provider_HistoricalDataRequestCancelled;
			this.provider.HistoricalDataRequestError += this.provider_HistoricalDataRequestError;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000C55C File Offset: 0x0000B55C
		private void UnsubscribeFromEvents()
		{
			this.provider.NewHistoricalQuote -= this.provider_NewHistoricalQuote;
			this.provider.NewHistoricalTrade -= this.provider_NewHistoricalTrade;
			this.provider.NewHistoricalBar -= this.provider_NewHistoricalBar;
			this.provider.HistoricalDataRequestCompleted -= this.provider_HistoricalDataRequestCompleted;
			this.provider.HistoricalDataRequestCancelled -= this.provider_HistoricalDataRequestCancelled;
			this.provider.HistoricalDataRequestError -= this.provider_HistoricalDataRequestError;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000C5F3 File Offset: 0x0000B5F3
		private void provider_NewHistoricalQuote(object sender, HistoricalQuoteEventArgs args)
		{
			if (args.RequestId == this.request.RequestId)
			{
				this.list.Add(args.Quote);
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000C61F File Offset: 0x0000B61F
		private void provider_NewHistoricalTrade(object sender, HistoricalTradeEventArgs args)
		{
			if (args.RequestId == this.request.RequestId)
			{
				this.list.Add(args.Trade);
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000C64B File Offset: 0x0000B64B
		private void provider_NewHistoricalBar(object sender, HistoricalBarEventArgs args)
		{
			if (args.RequestId == this.request.RequestId)
			{
				this.list.Add(args.Bar);
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000C677 File Offset: 0x0000B677
		private void provider_HistoricalDataRequestCompleted(object sender, HistoricalDataEventArgs args)
		{
			if (args.RequestId == this.request.RequestId)
			{
				this.semaphore.Release();
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000C69D File Offset: 0x0000B69D
		private void provider_HistoricalDataRequestCancelled(object sender, HistoricalDataEventArgs args)
		{
			if (args.RequestId == this.request.RequestId)
			{
				this.semaphore.Release();
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000C6C3 File Offset: 0x0000B6C3
		private void provider_HistoricalDataRequestError(object sender, HistoricalDataErrorEventArgs args)
		{
			if (args.RequestId == this.request.RequestId)
			{
				this.semaphore.Release();
			}
		}

		// Token: 0x04000105 RID: 261
		private ArrayList list;

		// Token: 0x04000106 RID: 262
		private IHistoricalDataProvider provider;

		// Token: 0x04000107 RID: 263
		private HistoricalDataRequest request;

		// Token: 0x04000108 RID: 264
		private Semaphore semaphore;
	}
}
