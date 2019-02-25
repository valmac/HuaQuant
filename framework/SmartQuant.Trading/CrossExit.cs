using System;
using SmartQuant.Execution;
using SmartQuant.Instruments;
using SmartQuant.Simulation;

namespace SmartQuant.Trading
{
	// Token: 0x02000037 RID: 55
	[StrategyComponent("{D779BA8E-C0CA-44cf-8745-99105365882F}", ComponentType.CrossExit, Name = "Default_CrossExit", Description = "")]
	public class CrossExit : StrategyMultiComponent
	{
		// Token: 0x06000283 RID: 643 RVA: 0x0000A641 File Offset: 0x00009641
		public virtual SingleOrder EmitSignal(Signal signal)
		{
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000A650 File Offset: 0x00009650
		public virtual SingleOrder LongExit(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.Sell, instrument, text);
			Position position = base.Portfolio.Positions[instrument];
			if (position == null || position.Side != PositionSide.Long)
			{
				signal.Status = SignalStatus.Rejected;
				signal.Rejecter = ComponentType.CrossExit;
			}
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000A6BC File Offset: 0x000096BC
		public virtual SingleOrder LongExit(Instrument instrument)
		{
			return this.LongExit(instrument, "LongExit " + base.Strategy.Name);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000A6DC File Offset: 0x000096DC
		public virtual SingleOrder ShortExit(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.BuyCover, instrument, text);
			Position position = base.Portfolio.Positions[instrument];
			if (position == null || position.Side != PositionSide.Short)
			{
				signal.Status = SignalStatus.Rejected;
				signal.Rejecter = ComponentType.CrossExit;
			}
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000A749 File Offset: 0x00009749
		public virtual SingleOrder ShortExit(Instrument instrument)
		{
			return this.ShortExit(instrument, "ShortExit " + base.Strategy.Name);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000A768 File Offset: 0x00009768
		public virtual SingleOrder LongExit(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			Position position = base.Portfolio.Positions[instrument];
			if (position == null || position.Side != PositionSide.Long)
			{
				signal.Status = SignalStatus.Rejected;
				signal.Rejecter = ComponentType.CrossExit;
			}
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000A7E2 File Offset: 0x000097E2
		public virtual SingleOrder LongExit(Instrument instrument, double price)
		{
			return this.LongExit(instrument, price, "LongExit " + base.Strategy.Name);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000A804 File Offset: 0x00009804
		public virtual SingleOrder ShortExit(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.BuyCover, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			Position position = base.Portfolio.Positions[instrument];
			if (position == null || position.Side != PositionSide.Short)
			{
				signal.Status = SignalStatus.Rejected;
				signal.Rejecter = ComponentType.CrossExit;
			}
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000A87F File Offset: 0x0000987F
		public virtual SingleOrder ShortExit(Instrument instrument, double price)
		{
			return this.ShortExit(instrument, price, "ShortExit " + base.Strategy.Name);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000A8A0 File Offset: 0x000098A0
		public virtual SingleOrder LongExit(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000A8EB File Offset: 0x000098EB
		public virtual SingleOrder LongExit(Instrument instrument, FillOnBarMode mode)
		{
			return this.LongExit(instrument, mode, "LongExit " + base.Strategy.Name);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000A90C File Offset: 0x0000990C
		public virtual SingleOrder ShortExit(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.BuyCover, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000A957 File Offset: 0x00009957
		public virtual SingleOrder ShortExit(Instrument instrument, FillOnBarMode mode)
		{
			return this.ShortExit(instrument, mode, "ShortExit " + base.Strategy.Name);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000A976 File Offset: 0x00009976
		public virtual SingleOrder Buy(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			return base.Strategy.EmitSignal(new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.Buy, instrument, text));
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000A9A6 File Offset: 0x000099A6
		public virtual SingleOrder Buy(Instrument instrument)
		{
			return this.Buy(instrument, "Buy " + base.Strategy.Name);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000A9C4 File Offset: 0x000099C4
		public virtual SingleOrder Buy(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000AA0F File Offset: 0x00009A0F
		public virtual SingleOrder Buy(Instrument instrument, double price)
		{
			return this.Buy(instrument, price, "Buy " + base.Strategy.Name);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000AA30 File Offset: 0x00009A30
		public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000AA7B File Offset: 0x00009A7B
		public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode)
		{
			return this.Buy(instrument, mode, "Buy " + base.Strategy.Name);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000AA9C File Offset: 0x00009A9C
		public virtual SingleOrder BuyLimit(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Limit, SignalSide.Buy, instrument, text);
			signal.LimitPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000AAE0 File Offset: 0x00009AE0
		public virtual SingleOrder BuyLimit(Instrument instrument, double price)
		{
			return this.BuyLimit(instrument, price, "BuyLimit " + base.Strategy.Name);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000AB00 File Offset: 0x00009B00
		public virtual SingleOrder BuyStop(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Stop, SignalSide.Buy, instrument, text);
			signal.StopPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000AB44 File Offset: 0x00009B44
		public virtual SingleOrder BuyStop(Instrument instrument, double price)
		{
			return this.BuyStop(instrument, price, "BuyStop " + base.Strategy.Name);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000AB64 File Offset: 0x00009B64
		public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.StopLimit, SignalSide.Buy, instrument, text);
			signal.StopPrice = stopPrice;
			signal.LimitPrice = limitPrice;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000ABB0 File Offset: 0x00009BB0
		public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice)
		{
			return this.BuyStopLimit(instrument, stopPrice, limitPrice, "BuyStopLimit " + base.Strategy.Name);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000ABD0 File Offset: 0x00009BD0
		public virtual SingleOrder BuyTrailingStop(Instrument instrument, double delta, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.TrailingStop, SignalSide.Buy, instrument, text);
			signal.StopPrice = delta;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000AC14 File Offset: 0x00009C14
		public virtual SingleOrder BuyTrailingStop(Instrument instrument, double delta)
		{
			return this.BuyTrailingStop(instrument, delta, string.Format("BuyTrailingStop {0}", base.Strategy.Name));
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000AC33 File Offset: 0x00009C33
		public virtual SingleOrder Sell(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			return base.Strategy.EmitSignal(new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.Sell, instrument, text));
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000AC63 File Offset: 0x00009C63
		public virtual SingleOrder Sell(Instrument instrument)
		{
			return this.Sell(instrument, "Sell " + base.Strategy.Name);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000AC84 File Offset: 0x00009C84
		public virtual SingleOrder Sell(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000ACCF File Offset: 0x00009CCF
		public virtual SingleOrder Sell(Instrument instrument, double price)
		{
			return this.Sell(instrument, price, "Sell " + base.Strategy.Name);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000ACF0 File Offset: 0x00009CF0
		public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000AD3B File Offset: 0x00009D3B
		public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode)
		{
			return this.Sell(instrument, mode, "Sell " + base.Strategy.Name);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000AD5C File Offset: 0x00009D5C
		public virtual SingleOrder SellLimit(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Limit, SignalSide.Sell, instrument, text);
			signal.LimitPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000ADA0 File Offset: 0x00009DA0
		public virtual SingleOrder SellLimit(Instrument instrument, double price)
		{
			return this.SellLimit(instrument, price, "SellLimit " + base.Strategy.Name);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000ADC0 File Offset: 0x00009DC0
		public virtual SingleOrder SellStop(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Stop, SignalSide.Sell, instrument, text);
			signal.StopPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000AE04 File Offset: 0x00009E04
		public virtual SingleOrder SellStop(Instrument instrument, double price)
		{
			return this.SellStop(instrument, price, "SellStop " + base.Strategy.Name);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000AE24 File Offset: 0x00009E24
		public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.StopLimit, SignalSide.Sell, instrument, text);
			signal.StopPrice = stopPrice;
			signal.LimitPrice = limitPrice;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000AE70 File Offset: 0x00009E70
		public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice)
		{
			return this.SellStopLimit(instrument, stopPrice, limitPrice, "SellStopLimit " + base.Strategy.Name);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000AE90 File Offset: 0x00009E90
		public virtual SingleOrder SellTrailingStop(Instrument instrument, double delta, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.TrailingStop, SignalSide.Sell, instrument, text);
			signal.StopPrice = delta;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000AED4 File Offset: 0x00009ED4
		public virtual SingleOrder SellTrailingStop(Instrument instrument, double delta)
		{
			return this.SellTrailingStop(instrument, delta, string.Format("SellTrailingStop {0}", base.Strategy.Name));
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000AEF3 File Offset: 0x00009EF3
		public virtual SingleOrder SellShort(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			return base.Strategy.EmitSignal(new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.SellShort, instrument, text));
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000AF23 File Offset: 0x00009F23
		public virtual SingleOrder SellShort(Instrument instrument)
		{
			return this.SellShort(instrument, "SellShort " + base.Strategy.Name);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000AF44 File Offset: 0x00009F44
		public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossExit, SignalType.Market, SignalSide.SellShort, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000AF8F File Offset: 0x00009F8F
		public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode)
		{
			return this.Sell(instrument, mode, "SellShort " + base.Strategy.Name);
		}

		// Token: 0x040000CC RID: 204
		public const string GUID = "{D779BA8E-C0CA-44cf-8745-99105365882F}";
	}
}
