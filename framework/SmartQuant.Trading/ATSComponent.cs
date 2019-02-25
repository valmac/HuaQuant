using System;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000078 RID: 120
	[StrategyComponent("{AC3C53E2-6C94-4718-A5D8-8A475D8B4EB7}", ComponentType.ATSComponent, Name = "Default_ATSComponent", Description = "")]
	public class ATSComponent : ATSStrategySingleComponent
	{
		// Token: 0x0600050E RID: 1294 RVA: 0x000119FB File Offset: 0x000109FB
		public virtual void OnStopStatusChanged(ATSStop stop)
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x000119FD File Offset: 0x000109FD
		public virtual void OnStopCanceled(ATSStop stop)
		{
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000119FF File Offset: 0x000109FF
		public virtual void OnStopExecuted(ATSStop stop)
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00011A04 File Offset: 0x00010A04
		public ATSStop SetStop(Position position, double level, StopType type, StopMode mode)
		{
			ATSStop atsstop = new ATSStop(position, level, type, mode);
			base.Strategy.AddStop(atsstop);
			return atsstop;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00011A29 File Offset: 0x00010A29
		public ATSStop SetStop(double level, StopType type, StopMode mode)
		{
			return this.SetStop(base.Position, level, type, mode);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00011A3C File Offset: 0x00010A3C
		public ATSStop SetStop(Position position, DateTime dateTime)
		{
			ATSStop atsstop = new ATSStop(position, dateTime);
			base.Strategy.AddStop(atsstop);
			return atsstop;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00011A5E File Offset: 0x00010A5E
		public ATSStop SetStop(DateTime dateTime)
		{
			return this.SetStop(base.Position, dateTime);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00011A70 File Offset: 0x00010A70
		public MarketOrder MarketOrder(Instrument instrument, Side side, double qty, string text)
		{
			MarketOrder marketOrder = new MarketOrder(instrument, side, qty, text);
			base.Strategy.RegisterOrder(marketOrder);
			return marketOrder;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00011A98 File Offset: 0x00010A98
		public MarketOrder SendMarketOrder(Instrument instrument, Side side, double qty, string text)
		{
			MarketOrder marketOrder = new MarketOrder(instrument, side, qty, text);
			base.Strategy.RegisterOrder(marketOrder);
			marketOrder.Send();
			return marketOrder;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00011AC4 File Offset: 0x00010AC4
		public MarketOrder MarketOrder(Instrument instrument, Side side, double qty)
		{
			MarketOrder marketOrder = new MarketOrder(instrument, side, qty);
			base.Strategy.RegisterOrder(marketOrder);
			return marketOrder;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00011AE8 File Offset: 0x00010AE8
		public MarketOrder SendMarketOrder(Instrument instrument, Side side, double qty)
		{
			MarketOrder marketOrder = new MarketOrder(instrument, side, qty);
			base.Strategy.RegisterOrder(marketOrder);
			marketOrder.Send();
			return marketOrder;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00011B11 File Offset: 0x00010B11
		public MarketOrder MarketOrder(Side side, double qty, string text)
		{
			return this.MarketOrder(base.Instrument, side, qty, text);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00011B22 File Offset: 0x00010B22
		public MarketOrder SendMarketOrder(Side side, double qty, string text)
		{
			return this.SendMarketOrder(base.Instrument, side, qty, text);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00011B33 File Offset: 0x00010B33
		public MarketOrder MarketOrder(Side side, double qty)
		{
			return this.MarketOrder(base.Instrument, side, qty);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00011B43 File Offset: 0x00010B43
		public MarketOrder SendMarketOrder(Side side, double qty)
		{
			return this.SendMarketOrder(base.Instrument, side, qty);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00011B54 File Offset: 0x00010B54
		public LimitOrder LimitOrder(Instrument instrument, Side side, double qty, double price, string text)
		{
			LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price, text);
			base.Strategy.RegisterOrder(limitOrder);
			return limitOrder;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00011B7C File Offset: 0x00010B7C
		public LimitOrder SendLimitOrder(Instrument instrument, Side side, double qty, double price, string text)
		{
			LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price, text);
			base.Strategy.RegisterOrder(limitOrder);
			limitOrder.Send();
			return limitOrder;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00011BAC File Offset: 0x00010BAC
		public LimitOrder LimitOrder(Instrument instrument, Side side, double qty, double price)
		{
			LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price);
			base.Strategy.RegisterOrder(limitOrder);
			return limitOrder;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00011BD4 File Offset: 0x00010BD4
		public LimitOrder SendLimitOrder(Instrument instrument, Side side, double qty, double price)
		{
			LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price);
			base.Strategy.RegisterOrder(limitOrder);
			limitOrder.Send();
			return limitOrder;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00011BFF File Offset: 0x00010BFF
		public LimitOrder LimitOrder(Side side, double qty, double price, string text)
		{
			return this.LimitOrder(base.Instrument, side, qty, price, text);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00011C12 File Offset: 0x00010C12
		public LimitOrder SendLimitOrder(Side side, double qty, double price, string text)
		{
			return this.SendLimitOrder(base.Instrument, side, qty, price, text);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00011C25 File Offset: 0x00010C25
		public LimitOrder LimitOrder(Side side, double qty, double price)
		{
			return this.LimitOrder(base.Instrument, side, qty, price);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00011C36 File Offset: 0x00010C36
		public LimitOrder SendLimitOrder(Side side, double qty, double price)
		{
			return this.SendLimitOrder(base.Instrument, side, qty, price);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00011C48 File Offset: 0x00010C48
		public StopOrder StopOrder(Instrument instrument, Side side, double qty, double price, string text)
		{
			StopOrder stopOrder = new StopOrder(instrument, side, qty, price, text);
			base.Strategy.RegisterOrder(stopOrder);
			return stopOrder;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00011C70 File Offset: 0x00010C70
		public StopOrder SendStopOrder(Instrument instrument, Side side, double qty, double price, string text)
		{
			StopOrder stopOrder = new StopOrder(instrument, side, qty, price, text);
			base.Strategy.RegisterOrder(stopOrder);
			stopOrder.Send();
			return stopOrder;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00011CA0 File Offset: 0x00010CA0
		public StopOrder StopOrder(Instrument instrument, Side side, double qty, double price)
		{
			StopOrder stopOrder = new StopOrder(instrument, side, qty, price);
			base.Strategy.RegisterOrder(stopOrder);
			return stopOrder;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00011CC8 File Offset: 0x00010CC8
		public StopOrder SendStopOrder(Instrument instrument, Side side, double qty, double price)
		{
			StopOrder stopOrder = new StopOrder(instrument, side, qty, price);
			base.Strategy.RegisterOrder(stopOrder);
			stopOrder.Send();
			return stopOrder;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00011CF3 File Offset: 0x00010CF3
		public StopOrder StopOrder(Side side, double qty, double price, string text)
		{
			return this.StopOrder(base.Instrument, side, qty, price, text);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00011D06 File Offset: 0x00010D06
		public StopOrder SendStopOrder(Side side, double qty, double price, string text)
		{
			return this.SendStopOrder(base.Instrument, side, qty, price, text);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00011D19 File Offset: 0x00010D19
		public StopOrder StopOrder(Side side, double qty, double price)
		{
			return this.StopOrder(base.Instrument, side, qty, price);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00011D2A File Offset: 0x00010D2A
		public StopOrder SendStopOrder(Side side, double qty, double price)
		{
			return this.SendStopOrder(base.Instrument, side, qty, price);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00011D3C File Offset: 0x00010D3C
		public StopLimitOrder StopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice, string text)
		{
			StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice, text);
			base.Strategy.RegisterOrder(stopLimitOrder);
			return stopLimitOrder;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00011D68 File Offset: 0x00010D68
		public StopLimitOrder SendStopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice, string text)
		{
			StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice, text);
			base.Strategy.RegisterOrder(stopLimitOrder);
			stopLimitOrder.Send();
			return stopLimitOrder;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00011D98 File Offset: 0x00010D98
		public StopLimitOrder StopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice)
		{
			StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice);
			base.Strategy.RegisterOrder(stopLimitOrder);
			return stopLimitOrder;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00011DC0 File Offset: 0x00010DC0
		public StopLimitOrder SendStopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice)
		{
			StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice);
			base.Strategy.RegisterOrder(stopLimitOrder);
			stopLimitOrder.Send();
			return stopLimitOrder;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00011DED File Offset: 0x00010DED
		public StopLimitOrder StopLimitOrder(Side side, double qty, double limitPrice, double stopPrice, string text)
		{
			return this.StopLimitOrder(base.Instrument, side, qty, limitPrice, stopPrice, text);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00011E02 File Offset: 0x00010E02
		public StopLimitOrder SendStopLimitOrder(Side side, double qty, double limitPrice, double stopPrice, string text)
		{
			return this.SendStopLimitOrder(base.Instrument, side, qty, limitPrice, stopPrice, text);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00011E17 File Offset: 0x00010E17
		public StopLimitOrder StopLimitOrder(Side side, double qty, double limitPrice, double stopPrice)
		{
			return this.StopLimitOrder(base.Instrument, side, qty, limitPrice, stopPrice);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00011E2A File Offset: 0x00010E2A
		public StopLimitOrder SendStopLimitOrder(Side side, double qty, double limitPrice, double stopPrice)
		{
			return this.SendStopLimitOrder(base.Instrument, side, qty, limitPrice, stopPrice);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00011E40 File Offset: 0x00010E40
		public TrailingStopOrder TrailingStopOrder(Side side, double qty, double delta)
		{
			TrailingStopOrder trailingStopOrder = new TrailingStopOrder(this.instrument, side, qty, delta);
			base.Strategy.RegisterOrder(trailingStopOrder);
			return trailingStopOrder;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00011E69 File Offset: 0x00010E69
		public MarketOrder Buy(Instrument instrument, double Qty, string text)
		{
			return this.SendMarketOrder(instrument, Side.Buy, Qty, text);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00011E75 File Offset: 0x00010E75
		public MarketOrder Buy(Instrument instrument, double Qty)
		{
			return this.SendMarketOrder(instrument, Side.Buy, Qty);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00011E80 File Offset: 0x00010E80
		public MarketOrder Buy(double Qty, string text)
		{
			return this.SendMarketOrder(Side.Buy, Qty, text);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00011E8B File Offset: 0x00010E8B
		public MarketOrder Buy(double Qty)
		{
			return this.SendMarketOrder(Side.Buy, Qty);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00011E95 File Offset: 0x00010E95
		public MarketOrder Sell(Instrument instrument, double Qty, string text)
		{
			return this.SendMarketOrder(instrument, Side.Sell, Qty, text);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00011EA1 File Offset: 0x00010EA1
		public MarketOrder Sell(Instrument instrument, double Qty)
		{
			return this.SendMarketOrder(instrument, Side.Sell, Qty);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00011EAC File Offset: 0x00010EAC
		public MarketOrder Sell(double Qty, string text)
		{
			return this.SendMarketOrder(Side.Sell, Qty, text);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00011EB7 File Offset: 0x00010EB7
		public MarketOrder Sell(double Qty)
		{
			return this.SendMarketOrder(Side.Sell, Qty);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00011EC1 File Offset: 0x00010EC1
		public LimitOrder BuyLimit(Instrument instrument, double qty, double price, string text)
		{
			return this.SendLimitOrder(instrument, Side.Buy, qty, price, text);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00011ECF File Offset: 0x00010ECF
		public LimitOrder BuyLimit(Instrument instrument, double qty, double price)
		{
			return this.SendLimitOrder(instrument, Side.Buy, qty, price);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00011EDB File Offset: 0x00010EDB
		public LimitOrder BuyLimit(double qty, double price, string text)
		{
			return this.SendLimitOrder(Side.Buy, qty, price, text);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00011EE7 File Offset: 0x00010EE7
		public LimitOrder BuyLimit(double qty, double price)
		{
			return this.SendLimitOrder(Side.Buy, qty, price);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00011EF2 File Offset: 0x00010EF2
		public LimitOrder SellLimit(Instrument instrument, double qty, double price, string text)
		{
			return this.SendLimitOrder(instrument, Side.Sell, qty, price, text);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00011F00 File Offset: 0x00010F00
		public LimitOrder SellLimit(Instrument instrument, double qty, double price)
		{
			return this.SendLimitOrder(instrument, Side.Sell, qty, price);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00011F0C File Offset: 0x00010F0C
		public LimitOrder SellLimit(double qty, double price, string text)
		{
			return this.SendLimitOrder(Side.Sell, qty, price, text);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00011F18 File Offset: 0x00010F18
		public LimitOrder SellLimit(double qty, double price)
		{
			return this.SendLimitOrder(Side.Sell, qty, price);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00011F23 File Offset: 0x00010F23
		public StopOrder BuyStop(Instrument instrument, double qty, double price, string text)
		{
			return this.SendStopOrder(instrument, Side.Buy, qty, price, text);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00011F31 File Offset: 0x00010F31
		public StopOrder BuyStop(Instrument instrument, double qty, double price)
		{
			return this.SendStopOrder(instrument, Side.Buy, qty, price);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00011F3D File Offset: 0x00010F3D
		public StopOrder BuyStop(double qty, double price, string text)
		{
			return this.SendStopOrder(Side.Buy, qty, price, text);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00011F49 File Offset: 0x00010F49
		public StopOrder BuyStop(double qty, double price)
		{
			return this.SendStopOrder(Side.Buy, qty, price);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00011F54 File Offset: 0x00010F54
		public StopOrder SellStop(Instrument instrument, double qty, double price, string text)
		{
			return this.SendStopOrder(instrument, Side.Sell, qty, price, text);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00011F62 File Offset: 0x00010F62
		public StopOrder SellStop(Instrument instrument, double qty, double price)
		{
			return this.SendStopOrder(instrument, Side.Sell, qty, price);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00011F6E File Offset: 0x00010F6E
		public StopOrder SellStop(double qty, double price, string text)
		{
			return this.SendStopOrder(Side.Sell, qty, price, text);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00011F7A File Offset: 0x00010F7A
		public StopOrder SellStop(double qty, double price)
		{
			return this.SendStopOrder(Side.Sell, qty, price);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00011F85 File Offset: 0x00010F85
		public StopLimitOrder BuyStopLimit(Instrument instrument, double qty, double limitPrice, double stopPrice, string text)
		{
			return this.SendStopLimitOrder(instrument, Side.Buy, qty, limitPrice, stopPrice, text);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00011F95 File Offset: 0x00010F95
		public StopLimitOrder BuyStopLimit(Instrument instrument, double qty, double limitPrice, double stopPrice)
		{
			return this.SendStopLimitOrder(instrument, Side.Buy, qty, limitPrice, stopPrice);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00011FA3 File Offset: 0x00010FA3
		public StopLimitOrder BuyStopLimit(double qty, double limitPrice, double stopPrice, string text)
		{
			return this.SendStopLimitOrder(Side.Buy, qty, limitPrice, stopPrice, text);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00011FB1 File Offset: 0x00010FB1
		public StopLimitOrder BuyStopLimit(double qty, double limitPrice, double stopPrice)
		{
			return this.SendStopLimitOrder(Side.Buy, qty, limitPrice, stopPrice);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00011FBD File Offset: 0x00010FBD
		public StopLimitOrder SellStopLimit(Instrument instrument, double qty, double limitPrice, double stopPrice, string text)
		{
			return this.SendStopLimitOrder(instrument, Side.Sell, qty, limitPrice, stopPrice, text);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00011FCD File Offset: 0x00010FCD
		public StopLimitOrder SellStopLimit(Instrument instrument, double qty, double limitPrice, double stopPrice)
		{
			return this.SendStopLimitOrder(instrument, Side.Sell, qty, limitPrice, stopPrice);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00011FDB File Offset: 0x00010FDB
		public StopLimitOrder SellStopLimit(double qty, double limitPrice, double stopPrice, string text)
		{
			return this.SendStopLimitOrder(Side.Sell, qty, limitPrice, stopPrice, text);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00011FE9 File Offset: 0x00010FE9
		public StopLimitOrder SellStopLimit(double qty, double limitPrice, double stopPrice)
		{
			return this.SendStopLimitOrder(Side.Sell, qty, limitPrice, stopPrice);
		}

		// Token: 0x04000185 RID: 389
		public const string GUID = "{AC3C53E2-6C94-4718-A5D8-8A475D8B4EB7}";
	}
}
