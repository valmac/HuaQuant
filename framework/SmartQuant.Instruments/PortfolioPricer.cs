using System;

namespace SmartQuant.Instruments
{
	// Token: 0x0200003E RID: 62
	internal class PortfolioPricer : IPortfolioPricer
	{
		// Token: 0x06000345 RID: 837 RVA: 0x0000AECC File Offset: 0x00009ECC
		public virtual double Price(Position position)
		{
			switch (position.Side)
			{
			case PositionSide.Long:
				if (position.Instrument.OrderBook.Bid.Count != 0)
				{
					return position.Instrument.OrderBook.GetAvgBidPrice(position.Qty);
				}
				if (position.Instrument.Quote.Bid != 0.0)
				{
					return position.Instrument.Quote.Bid;
				}
				break;
			case PositionSide.Short:
				if (position.Instrument.OrderBook.Ask.Count != 0)
				{
					return position.Instrument.OrderBook.GetAvgAskPrice(position.Qty);
				}
				if (position.Instrument.Quote.Ask != 0.0)
				{
					return position.Instrument.Quote.Ask;
				}
				break;
			}
			return position.Instrument.Price();
		}
	}
}
