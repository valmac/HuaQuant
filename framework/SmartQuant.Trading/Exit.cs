using System;
using SmartQuant.Execution;
using SmartQuant.Instruments;
using SmartQuant.Simulation;

namespace SmartQuant.Trading
{
	// Token: 0x0200007C RID: 124
	[StrategyComponent("{6FEE0044-0FD2-418d-94E6-400834BEE5D3}", ComponentType.Exit, Name = "Default_Exit", Description = "")]
	public class Exit : StrategySingleComponent
	{
		// Token: 0x0600055E RID: 1374 RVA: 0x00012065 File Offset: 0x00011065
		public virtual SingleOrder EmitSignal(Signal signal)
		{
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00012074 File Offset: 0x00011074
		public virtual SingleOrder LongExit(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text);
			if (!base.HasPosition || base.Position.Side != PositionSide.Long)
			{
				signal.Status = SignalStatus.Rejected;
				signal.Rejecter = ComponentType.Exit;
			}
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000120D0 File Offset: 0x000110D0
		public virtual SingleOrder LongExit(Instrument instrument)
		{
			return this.LongExit(instrument, "LongExit " + base.Strategy.Name);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000120F0 File Offset: 0x000110F0
		public virtual SingleOrder ShortExit(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.BuyCover, instrument, text);
			if (!base.HasPosition || base.Position.Side != PositionSide.Short)
			{
				signal.Status = SignalStatus.Rejected;
				signal.Rejecter = ComponentType.Exit;
			}
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0001214D File Offset: 0x0001114D
		public virtual SingleOrder ShortExit(Instrument instrument)
		{
			return this.ShortExit(instrument, "ShortExit " + base.Strategy.Name);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0001216B File Offset: 0x0001116B
		public virtual SingleOrder LongExit(string text)
		{
			return this.LongExit(this.instrument, text);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0001217A File Offset: 0x0001117A
		public virtual SingleOrder LongExit()
		{
			return this.LongExit(this.instrument);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00012188 File Offset: 0x00011188
		public virtual SingleOrder ShortExit(string text)
		{
			return this.ShortExit(this.instrument, text);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00012197 File Offset: 0x00011197
		public virtual void ShortExit()
		{
			this.ShortExit(this.instrument);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000121A8 File Offset: 0x000111A8
		public virtual SingleOrder LongExit(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			if (!base.HasPosition || base.Position.Side != PositionSide.Long)
			{
				signal.Status = SignalStatus.Rejected;
				signal.Rejecter = ComponentType.Exit;
			}
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00012212 File Offset: 0x00011212
		public virtual SingleOrder LongExit(Instrument instrument, double price)
		{
			return this.LongExit(instrument, price, "LongExit " + base.Strategy.Name);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00012234 File Offset: 0x00011234
		public virtual SingleOrder ShortExit(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.BuyCover, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			if (!base.HasPosition || base.Position.Side != PositionSide.Short)
			{
				signal.Status = SignalStatus.Rejected;
				signal.Rejecter = ComponentType.Exit;
			}
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001229F File Offset: 0x0001129F
		public virtual SingleOrder ShortExit(Instrument instrument, double price)
		{
			return this.ShortExit(instrument, price, "ShortExit " + base.Strategy.Name);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000122BE File Offset: 0x000112BE
		public virtual SingleOrder LongExit(double price, string text)
		{
			return this.LongExit(this.instrument, price, text);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000122CE File Offset: 0x000112CE
		public virtual SingleOrder LongExit(double price)
		{
			return this.LongExit(this.instrument, price);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000122DD File Offset: 0x000112DD
		public virtual SingleOrder ShortExit(double price, string text)
		{
			return this.ShortExit(this.instrument, price, text);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000122ED File Offset: 0x000112ED
		public virtual void ShortExit(double price)
		{
			this.ShortExit(this.instrument, price);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00012300 File Offset: 0x00011300
		public virtual SingleOrder LongExit(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00012347 File Offset: 0x00011347
		public virtual SingleOrder LongExit(Instrument instrument, FillOnBarMode mode)
		{
			return this.LongExit(instrument, mode, "LongExit " + base.Strategy.Name);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00012368 File Offset: 0x00011368
		public virtual SingleOrder ShortExit(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.BuyCover, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000123AF File Offset: 0x000113AF
		public virtual SingleOrder ShortExit(Instrument instrument, FillOnBarMode mode)
		{
			return this.ShortExit(instrument, mode, "ShortExit " + base.Strategy.Name);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000123CE File Offset: 0x000113CE
		public virtual SingleOrder LongExit(FillOnBarMode mode, string text)
		{
			return this.LongExit(this.instrument, mode, text);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000123DE File Offset: 0x000113DE
		public virtual SingleOrder LongExit(FillOnBarMode mode)
		{
			return this.LongExit(this.instrument, mode);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000123ED File Offset: 0x000113ED
		public virtual SingleOrder ShortExit(FillOnBarMode mode, string text)
		{
			return this.ShortExit(this.instrument, mode, text);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000123FD File Offset: 0x000113FD
		public virtual void ShortExit(FillOnBarMode mode)
		{
			this.ShortExit(this.instrument, mode);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0001240D File Offset: 0x0001140D
		public virtual SingleOrder Buy(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			return base.Strategy.EmitSignal(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Buy, instrument, text));
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00012439 File Offset: 0x00011439
		public virtual SingleOrder Buy(Instrument instrument)
		{
			return this.Buy(instrument, "Buy " + base.Strategy.Name);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00012457 File Offset: 0x00011457
		public virtual SingleOrder Buy(string text)
		{
			return this.Buy(this.instrument, text);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00012466 File Offset: 0x00011466
		public virtual SingleOrder Buy()
		{
			return this.Buy(this.instrument);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00012474 File Offset: 0x00011474
		public virtual SingleOrder Buy(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000124BB File Offset: 0x000114BB
		public virtual SingleOrder Buy(Instrument instrument, double price)
		{
			return this.Buy(instrument, price, "Buy " + base.Strategy.Name);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000124DA File Offset: 0x000114DA
		public virtual SingleOrder Buy(double price, string text)
		{
			return this.Buy(this.instrument, price, text);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000124EA File Offset: 0x000114EA
		public virtual SingleOrder Buy(double price)
		{
			return this.Buy(this.instrument, price);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000124FC File Offset: 0x000114FC
		public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00012543 File Offset: 0x00011543
		public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode)
		{
			return this.Buy(instrument, mode, "Buy " + base.Strategy.Name);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00012562 File Offset: 0x00011562
		public virtual SingleOrder Buy(string text, FillOnBarMode mode)
		{
			return this.Buy(this.instrument, mode, text);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00012572 File Offset: 0x00011572
		public virtual SingleOrder Buy(FillOnBarMode mode)
		{
			return this.Buy(this.instrument, mode);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00012584 File Offset: 0x00011584
		public virtual SingleOrder BuyLimit(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Limit, SignalSide.Buy, instrument, text);
			signal.LimitPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000125C4 File Offset: 0x000115C4
		public virtual SingleOrder BuyLimit(Instrument instrument, double price)
		{
			return this.BuyLimit(instrument, price, "BuyLimit " + base.Strategy.Name);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000125E3 File Offset: 0x000115E3
		public virtual SingleOrder BuyLimit(double price, string text)
		{
			return this.BuyLimit(this.instrument, price, text);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000125F3 File Offset: 0x000115F3
		public virtual SingleOrder BuyLimit(double price)
		{
			return this.BuyLimit(this.instrument, price);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00012604 File Offset: 0x00011604
		public virtual SingleOrder BuyStop(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Stop, SignalSide.Buy, instrument, text);
			signal.StopPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00012644 File Offset: 0x00011644
		public virtual SingleOrder BuyStop(Instrument instrument, double price)
		{
			return this.BuyStop(instrument, price, "BuyStop " + base.Strategy.Name);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00012663 File Offset: 0x00011663
		public virtual SingleOrder BuyStop(double price, string text)
		{
			return this.BuyStop(this.instrument, price, text);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00012673 File Offset: 0x00011673
		public virtual SingleOrder BuyStop(double price)
		{
			return this.BuyStop(this.instrument, price);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00012684 File Offset: 0x00011684
		public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.StopLimit, SignalSide.Buy, instrument, text);
			signal.StopPrice = stopPrice;
			signal.LimitPrice = limitPrice;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x000126CC File Offset: 0x000116CC
		public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice)
		{
			return this.BuyStopLimit(instrument, stopPrice, limitPrice, "BuyStopLimit " + base.Strategy.Name);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x000126EC File Offset: 0x000116EC
		public virtual SingleOrder BuyStopLimit(double stopPrice, double limitPrice, string text)
		{
			return this.BuyStopLimit(this.instrument, stopPrice, limitPrice, text);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000126FD File Offset: 0x000116FD
		public virtual SingleOrder BuyStopLimit(double stopPrice, double limitPrice)
		{
			return this.BuyStopLimit(this.instrument, stopPrice, limitPrice);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00012710 File Offset: 0x00011710
		public virtual SingleOrder BuyTrailingStop(double delta, string text)
		{
			if (!base.Strategy.IsInstrumentActive(this.instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.TrailingStop, SignalSide.Buy, this.instrument, text);
			signal.StopPrice = delta;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0001275A File Offset: 0x0001175A
		public virtual SingleOrder BuyTrailingStop(double delta)
		{
			return this.BuyTrailingStop(delta, string.Format("BuyTrailingStop {0}", base.Strategy.Name));
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00012778 File Offset: 0x00011778
		public virtual SingleOrder Sell(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			return base.Strategy.EmitSignal(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text));
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000127A4 File Offset: 0x000117A4
		public virtual SingleOrder Sell(Instrument instrument)
		{
			return this.Sell(instrument, "Sell " + base.Strategy.Name);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000127C2 File Offset: 0x000117C2
		public virtual SingleOrder Sell(string text)
		{
			return this.Sell(this.instrument, text);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000127D1 File Offset: 0x000117D1
		public virtual SingleOrder Sell()
		{
			return this.Sell(this.instrument);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000127E0 File Offset: 0x000117E0
		public virtual SingleOrder Sell(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00012827 File Offset: 0x00011827
		public virtual SingleOrder Sell(Instrument instrument, double price)
		{
			return this.Sell(instrument, price, "Sell " + base.Strategy.Name);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00012846 File Offset: 0x00011846
		public virtual SingleOrder Sell(double price, string text)
		{
			return this.Sell(this.instrument, price, text);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00012856 File Offset: 0x00011856
		public virtual SingleOrder Sell(double price)
		{
			return this.Sell(this.instrument, price);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00012868 File Offset: 0x00011868
		public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000128AF File Offset: 0x000118AF
		public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode)
		{
			return this.Sell(instrument, mode, "Sell " + base.Strategy.Name);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000128CE File Offset: 0x000118CE
		public virtual SingleOrder Sell(string text, FillOnBarMode mode)
		{
			return this.Sell(this.instrument, mode, text);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000128DE File Offset: 0x000118DE
		public virtual SingleOrder Sell(FillOnBarMode mode)
		{
			return this.Sell(this.instrument, mode);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000128F0 File Offset: 0x000118F0
		public virtual SingleOrder SellLimit(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Limit, SignalSide.Sell, instrument, text);
			signal.LimitPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00012930 File Offset: 0x00011930
		public virtual SingleOrder SellLimit(Instrument instrument, double price)
		{
			return this.SellLimit(instrument, price, "SellLimit " + base.Strategy.Name);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0001294F File Offset: 0x0001194F
		public virtual SingleOrder SellLimit(double price, string text)
		{
			return this.SellLimit(this.instrument, price, text);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0001295F File Offset: 0x0001195F
		public virtual SingleOrder SellLimit(double price)
		{
			return this.SellLimit(this.instrument, price);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00012970 File Offset: 0x00011970
		public virtual SingleOrder SellStop(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Stop, SignalSide.Sell, instrument, text);
			signal.StopPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x000129B0 File Offset: 0x000119B0
		public virtual SingleOrder SellStop(Instrument instrument, double price)
		{
			return this.SellStop(instrument, price, "SellStop " + base.Strategy.Name);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000129CF File Offset: 0x000119CF
		public virtual SingleOrder SellStop(double price, string text)
		{
			return this.SellStop(this.instrument, price, text);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000129DF File Offset: 0x000119DF
		public virtual SingleOrder SellStop(double price)
		{
			return this.SellStop(this.instrument, price);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000129F0 File Offset: 0x000119F0
		public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.StopLimit, SignalSide.Sell, instrument, text);
			signal.StopPrice = stopPrice;
			signal.LimitPrice = limitPrice;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00012A38 File Offset: 0x00011A38
		public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice)
		{
			return this.SellStopLimit(instrument, stopPrice, limitPrice, "SellStopLimit " + base.Strategy.Name);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00012A58 File Offset: 0x00011A58
		public virtual SingleOrder SellStopLimit(double stopPrice, double limitPrice, string text)
		{
			return this.SellStopLimit(this.instrument, stopPrice, limitPrice, text);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00012A69 File Offset: 0x00011A69
		public virtual SingleOrder SellStopLimit(double stopPrice, double limitPrice)
		{
			return this.SellStopLimit(this.instrument, stopPrice, limitPrice);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00012A7C File Offset: 0x00011A7C
		public virtual SingleOrder SellTrailingStop(double delta, string text)
		{
			if (!base.Strategy.IsInstrumentActive(this.instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.TrailingStop, SignalSide.Sell, this.instrument, text);
			signal.StopPrice = delta;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00012AC6 File Offset: 0x00011AC6
		public virtual SingleOrder SellTrailingStop(double delta)
		{
			return this.SellTrailingStop(delta, string.Format("SellTrailingStop {0}", base.Strategy.Name));
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00012AE4 File Offset: 0x00011AE4
		public virtual SingleOrder SellShort(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			return base.Strategy.EmitSignal(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.SellShort, instrument, text));
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00012B10 File Offset: 0x00011B10
		public virtual SingleOrder SellShort(Instrument instrument)
		{
			return this.SellShort(instrument, "SellShort " + base.Strategy.Name);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00012B2E File Offset: 0x00011B2E
		public virtual SingleOrder SellShort(string text)
		{
			return this.SellShort(this.instrument, text);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00012B3D File Offset: 0x00011B3D
		public virtual SingleOrder SellShort()
		{
			return this.SellShort(this.instrument);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00012B4C File Offset: 0x00011B4C
		public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.SellShort, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00012B93 File Offset: 0x00011B93
		public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode)
		{
			return this.Sell(instrument, mode, "SellShort " + base.Strategy.Name);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00012BB2 File Offset: 0x00011BB2
		public virtual SingleOrder SellShort(string text, FillOnBarMode mode)
		{
			return this.SellShort(this.instrument, mode, text);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00012BC2 File Offset: 0x00011BC2
		public virtual SingleOrder SellShort(FillOnBarMode mode)
		{
			return this.SellShort(this.instrument, mode);
		}

		// Token: 0x0400018E RID: 398
		public const string GUID = "{6FEE0044-0FD2-418d-94E6-400834BEE5D3}";
	}
}
