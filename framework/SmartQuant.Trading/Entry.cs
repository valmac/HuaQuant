using System;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Simulation;

namespace SmartQuant.Trading
{
	// Token: 0x02000067 RID: 103
	[StrategyComponent("{94FAFF9D-5281-4c67-A599-B893F1F58B38}", ComponentType.Entry, Name = "Default_Entry", Description = "")]
	public class Entry : StrategySingleComponent
	{
		// Token: 0x060003FA RID: 1018 RVA: 0x0000F313 File Offset: 0x0000E313
		public virtual SingleOrder EmitSignal(Signal signal)
		{
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000F324 File Offset: 0x0000E324
		public virtual SingleOrder LongEntry(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text);
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000F35D File Offset: 0x0000E35D
		public virtual SingleOrder LongEntry(Instrument instrument)
		{
			return this.LongEntry(instrument, "LongEntry " + base.Strategy.Name);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000F37C File Offset: 0x0000E37C
		public virtual SingleOrder ShortEntry(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.SellShort, instrument, text);
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000F3B5 File Offset: 0x0000E3B5
		public virtual SingleOrder ShortEntry(Instrument instrument)
		{
			return this.ShortEntry(instrument, "ShortEntry " + base.Strategy.Name);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000F3D3 File Offset: 0x0000E3D3
		public virtual SingleOrder LongEntry(string text)
		{
			return this.LongEntry(this.instrument, text);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000F3E2 File Offset: 0x0000E3E2
		public virtual SingleOrder LongEntry()
		{
			return this.LongEntry(this.instrument);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000F3F0 File Offset: 0x0000E3F0
		public virtual SingleOrder ShortEntry(string text)
		{
			return this.ShortEntry(this.instrument, text);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000F3FF File Offset: 0x0000E3FF
		public virtual SingleOrder ShortEntry()
		{
			return this.ShortEntry(this.instrument);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000F410 File Offset: 0x0000E410
		public virtual SingleOrder LongEntry(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000F457 File Offset: 0x0000E457
		public virtual SingleOrder LongEntry(Instrument instrument, double price)
		{
			return this.LongEntry(instrument, price, "LongEntry " + base.Strategy.Name);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000F478 File Offset: 0x0000E478
		public virtual SingleOrder ShortEntry(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.SellShort, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000F4BF File Offset: 0x0000E4BF
		public virtual SingleOrder ShortEntry(Instrument instrument, double price)
		{
			return this.ShortEntry(instrument, price, "ShortEntry " + base.Strategy.Name);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000F4DE File Offset: 0x0000E4DE
		public virtual SingleOrder LongEntry(double price, string text)
		{
			return this.LongEntry(this.instrument, price, text);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000F4EE File Offset: 0x0000E4EE
		public virtual SingleOrder LongEntry(double price)
		{
			return this.LongEntry(this.instrument, price);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000F4FD File Offset: 0x0000E4FD
		public virtual SingleOrder ShortEntry(double price, string text)
		{
			return this.ShortEntry(this.instrument, price, text);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000F50D File Offset: 0x0000E50D
		public virtual SingleOrder ShortEntry(double price)
		{
			return this.ShortEntry(this.instrument, price);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000F51C File Offset: 0x0000E51C
		public virtual SingleOrder LongEntry(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000F563 File Offset: 0x0000E563
		public virtual SingleOrder LongEntry(Instrument instrument, FillOnBarMode mode)
		{
			return this.LongEntry(instrument, mode, "LongEntry " + base.Strategy.Name);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000F584 File Offset: 0x0000E584
		public virtual SingleOrder ShortEntry(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.SellShort, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000F5CB File Offset: 0x0000E5CB
		public virtual SingleOrder ShortEntry(Instrument instrument, FillOnBarMode mode)
		{
			return this.ShortEntry(instrument, mode, "ShortEntry " + base.Strategy.Name);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000F5EA File Offset: 0x0000E5EA
		public virtual SingleOrder LongEntry(FillOnBarMode mode, string text)
		{
			return this.LongEntry(this.instrument, mode, text);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000F5FA File Offset: 0x0000E5FA
		public virtual SingleOrder LongEntry(FillOnBarMode mode)
		{
			return this.LongEntry(this.instrument, mode);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000F609 File Offset: 0x0000E609
		public virtual SingleOrder ShortEntry(FillOnBarMode mode, string text)
		{
			return this.ShortEntry(this.instrument, mode, text);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000F619 File Offset: 0x0000E619
		public virtual SingleOrder ShortEntry(FillOnBarMode mode)
		{
			return this.ShortEntry(this.instrument, mode);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000F628 File Offset: 0x0000E628
		public virtual SingleOrder Buy(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			return base.Strategy.EmitSignal(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text));
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000F654 File Offset: 0x0000E654
		public virtual SingleOrder Buy(Instrument instrument)
		{
			return this.Buy(instrument, "Buy " + base.Strategy.Name);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000F672 File Offset: 0x0000E672
		public virtual SingleOrder Buy(string text)
		{
			return this.Buy(this.instrument, text);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000F681 File Offset: 0x0000E681
		public virtual SingleOrder Buy()
		{
			return this.Buy(this.instrument);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000F690 File Offset: 0x0000E690
		public virtual SingleOrder Buy(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000F6D7 File Offset: 0x0000E6D7
		public virtual SingleOrder Buy(Instrument instrument, double price)
		{
			return this.Buy(instrument, price, "Buy " + base.Strategy.Name);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000F6F6 File Offset: 0x0000E6F6
		public virtual SingleOrder Buy(double price, string text)
		{
			return this.Buy(this.instrument, price, text);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000F706 File Offset: 0x0000E706
		public virtual SingleOrder Buy(double price)
		{
			return this.Buy(this.instrument, price);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000F718 File Offset: 0x0000E718
		public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000F75F File Offset: 0x0000E75F
		public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode)
		{
			return this.Buy(instrument, mode, "Buy " + base.Strategy.Name);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000F77E File Offset: 0x0000E77E
		public virtual SingleOrder Buy(string text, FillOnBarMode mode)
		{
			return this.Buy(this.instrument, mode, text);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000F78E File Offset: 0x0000E78E
		public virtual SingleOrder Buy(FillOnBarMode mode)
		{
			return this.Buy(this.instrument, mode);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000F7A0 File Offset: 0x0000E7A0
		public virtual SingleOrder BuyMarket(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.ForceMarketOrder = true;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000F7E0 File Offset: 0x0000E7E0
		public virtual SingleOrder BuyMarket(Instrument instrument)
		{
			return this.Buy(instrument, "BuyMarket " + base.Strategy.Name);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000F7FE File Offset: 0x0000E7FE
		public virtual SingleOrder BuyMarket(string text)
		{
			return this.Buy(this.instrument, text);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000F80D File Offset: 0x0000E80D
		public virtual SingleOrder BuyMarket()
		{
			return this.Buy(this.instrument);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000F81C File Offset: 0x0000E81C
		public virtual SingleOrder BuyLimit(Instrument instrument, double price, TimeInForce timeInForce, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Limit, SignalSide.Buy, instrument, text);
			signal.LimitPrice = price;
			signal.TimeInForce = timeInForce;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000F864 File Offset: 0x0000E864
		public virtual SingleOrder BuyLimit(Instrument instrument, double price, string text)
		{
			return this.BuyLimit(instrument, price, TimeInForce.GTC, text);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000F870 File Offset: 0x0000E870
		public virtual SingleOrder BuyLimit(Instrument instrument, double price, TimeInForce timeInForce)
		{
			return this.BuyLimit(instrument, price, timeInForce, "BuyLimit " + base.Strategy.Name);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000F890 File Offset: 0x0000E890
		public virtual SingleOrder BuyLimit(Instrument instrument, double price)
		{
			return this.BuyLimit(instrument, price, "BuyLimit " + base.Strategy.Name);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000F8AF File Offset: 0x0000E8AF
		public virtual SingleOrder BuyLimit(double price, TimeInForce timeInForce, string text)
		{
			return this.BuyLimit(this.instrument, price, timeInForce, text);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000F8C0 File Offset: 0x0000E8C0
		public virtual SingleOrder BuyLimit(double price, string text)
		{
			return this.BuyLimit(this.instrument, price, text);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000F8D0 File Offset: 0x0000E8D0
		public virtual SingleOrder BuyLimit(double price, TimeInForce timeInForce)
		{
			return this.BuyLimit(this.instrument, price, timeInForce);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000F8E0 File Offset: 0x0000E8E0
		public virtual SingleOrder BuyLimit(double price)
		{
			return this.BuyLimit(this.instrument, price);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000F8F0 File Offset: 0x0000E8F0
		public virtual SingleOrder BuyStop(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Stop, SignalSide.Buy, instrument, text);
			signal.StopPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000F930 File Offset: 0x0000E930
		public virtual SingleOrder BuyStop(Instrument instrument, double price)
		{
			return this.BuyStop(instrument, price, "BuyStop " + base.Strategy.Name);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000F94F File Offset: 0x0000E94F
		public virtual SingleOrder BuyStop(double price, string text)
		{
			return this.BuyStop(this.instrument, price, text);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000F95F File Offset: 0x0000E95F
		public virtual SingleOrder BuyStop(double price)
		{
			return this.BuyStop(this.instrument, price);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000F970 File Offset: 0x0000E970
		public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.StopLimit, SignalSide.Buy, instrument, text);
			signal.StopPrice = stopPrice;
			signal.LimitPrice = limitPrice;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000F9B8 File Offset: 0x0000E9B8
		public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice)
		{
			return this.BuyStopLimit(instrument, stopPrice, limitPrice, "BuyStopLimit " + base.Strategy.Name);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000F9D8 File Offset: 0x0000E9D8
		public virtual SingleOrder BuyStopLimit(double stopPrice, double limitPrice, string text)
		{
			return this.BuyStopLimit(this.instrument, stopPrice, limitPrice, text);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000F9E9 File Offset: 0x0000E9E9
		public virtual SingleOrder BuyStopLimit(double stopPrice, double limitPrice)
		{
			return this.BuyStopLimit(this.instrument, stopPrice, limitPrice);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000F9FC File Offset: 0x0000E9FC
		public virtual SingleOrder BuyTrailingStop(double delta, string text)
		{
			if (!base.Strategy.IsInstrumentActive(this.instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.TrailingStop, SignalSide.Buy, this.instrument, text);
			signal.StopPrice = delta;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000FA46 File Offset: 0x0000EA46
		public virtual SingleOrder BuyTrailingStop(double delta)
		{
			return this.BuyTrailingStop(delta, string.Format("BuyTrailingStop {0}", base.Strategy.Name));
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000FA64 File Offset: 0x0000EA64
		public virtual SingleOrder Sell(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			return base.Strategy.EmitSignal(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Sell, instrument, text));
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000FA90 File Offset: 0x0000EA90
		public virtual SingleOrder Sell(Instrument instrument)
		{
			return this.Sell(instrument, "Sell " + base.Strategy.Name);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000FAAE File Offset: 0x0000EAAE
		public virtual SingleOrder Sell(string text)
		{
			return this.Sell(this.instrument, text);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000FABD File Offset: 0x0000EABD
		public virtual SingleOrder Sell()
		{
			return this.Sell(this.instrument);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000FACC File Offset: 0x0000EACC
		public virtual SingleOrder Sell(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000FB13 File Offset: 0x0000EB13
		public virtual SingleOrder Sell(Instrument instrument, double price)
		{
			return this.Sell(instrument, price, "Sell " + base.Strategy.Name);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000FB32 File Offset: 0x0000EB32
		public virtual SingleOrder Sell(string text, double price)
		{
			return this.Sell(this.instrument, price, text);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000FB42 File Offset: 0x0000EB42
		public virtual SingleOrder Sell(double price)
		{
			return this.Sell(this.instrument, price);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000FB54 File Offset: 0x0000EB54
		public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000FB9B File Offset: 0x0000EB9B
		public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode)
		{
			return this.Sell(instrument, mode, "Sell " + base.Strategy.Name);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000FBBA File Offset: 0x0000EBBA
		public virtual SingleOrder Sell(string text, FillOnBarMode mode)
		{
			return this.Sell(this.instrument, mode, text);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000FBCA File Offset: 0x0000EBCA
		public virtual SingleOrder Sell(FillOnBarMode mode)
		{
			return this.Sell(this.instrument, mode);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000FBDC File Offset: 0x0000EBDC
		public virtual SingleOrder SellMarket(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.ForceMarketOrder = true;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000FC1C File Offset: 0x0000EC1C
		public virtual SingleOrder SellMarket(Instrument instrument)
		{
			return this.Sell(instrument, "SellMarket " + base.Strategy.Name);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000FC3A File Offset: 0x0000EC3A
		public virtual SingleOrder SellMarket(string text)
		{
			return this.Sell(this.instrument, text);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000FC49 File Offset: 0x0000EC49
		public virtual SingleOrder SellMarket()
		{
			return this.Sell(this.instrument);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000FC58 File Offset: 0x0000EC58
		public virtual SingleOrder SellLimit(Instrument instrument, double price, TimeInForce timeInForce, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Limit, SignalSide.Sell, instrument, text);
			signal.LimitPrice = price;
			signal.TimeInForce = timeInForce;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000FCA0 File Offset: 0x0000ECA0
		public virtual SingleOrder SellLimit(Instrument instrument, double price, string text)
		{
			return this.SellLimit(instrument, price, TimeInForce.GTC, text);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000FCAC File Offset: 0x0000ECAC
		public virtual SingleOrder SellLimit(Instrument instrument, double price, TimeInForce timeInForce)
		{
			return this.SellLimit(instrument, price, timeInForce, "SellLimit " + base.Strategy.Name);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000FCCC File Offset: 0x0000ECCC
		public virtual SingleOrder SellLimit(Instrument instrument, double price)
		{
			return this.SellLimit(instrument, price, "SellLimit " + base.Strategy.Name);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000FCEB File Offset: 0x0000ECEB
		public virtual SingleOrder SellLimit(double price, TimeInForce timeInForce, string text)
		{
			return this.SellLimit(this.instrument, price, timeInForce, text);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000FCFC File Offset: 0x0000ECFC
		public virtual SingleOrder SellLimit(double price, string text)
		{
			return this.SellLimit(this.instrument, price, text);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000FD0C File Offset: 0x0000ED0C
		public virtual SingleOrder SellLimit(double price, TimeInForce timeInForce)
		{
			return this.SellLimit(this.instrument, price, timeInForce);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000FD1C File Offset: 0x0000ED1C
		public virtual SingleOrder SellLimit(double price)
		{
			return this.SellLimit(this.instrument, price);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000FD2C File Offset: 0x0000ED2C
		public virtual SingleOrder SellStop(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Stop, SignalSide.Sell, instrument, text);
			signal.StopPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000FD6C File Offset: 0x0000ED6C
		public virtual SingleOrder SellStop(Instrument instrument, double price)
		{
			return this.SellStop(instrument, price, "SellStop " + base.Strategy.Name);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000FD8B File Offset: 0x0000ED8B
		public virtual SingleOrder SellStop(double price, string text)
		{
			return this.SellStop(this.instrument, price, text);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000FD9B File Offset: 0x0000ED9B
		public virtual SingleOrder SellStop(double price)
		{
			return this.SellStop(this.instrument, price);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000FDAC File Offset: 0x0000EDAC
		public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.StopLimit, SignalSide.Sell, instrument, text);
			signal.StopPrice = stopPrice;
			signal.LimitPrice = limitPrice;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000FDF4 File Offset: 0x0000EDF4
		public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice)
		{
			return this.SellStopLimit(instrument, stopPrice, limitPrice, "SellStopLimit " + base.Strategy.Name);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000FE14 File Offset: 0x0000EE14
		public virtual SingleOrder SellStopLimit(double stopPrice, double limitPrice, string text)
		{
			return this.SellStopLimit(this.instrument, stopPrice, limitPrice, text);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000FE25 File Offset: 0x0000EE25
		public virtual SingleOrder SellStopLimit(double stopPrice, double limitPrice)
		{
			return this.SellStopLimit(this.instrument, stopPrice, limitPrice);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000FE38 File Offset: 0x0000EE38
		public virtual SingleOrder SellTrailingStop(double delta, string text)
		{
			if (!base.Strategy.IsInstrumentActive(this.instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.TrailingStop, SignalSide.Sell, this.instrument, text);
			signal.StopPrice = delta;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000FE82 File Offset: 0x0000EE82
		public virtual SingleOrder SellTrailingStop(double delta)
		{
			return this.SellTrailingStop(delta, string.Format("SellTrailingStop {0}", base.Strategy.Name));
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000FEA0 File Offset: 0x0000EEA0
		public virtual SingleOrder SellShort(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			return base.Strategy.EmitSignal(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.SellShort, instrument, text));
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000FECC File Offset: 0x0000EECC
		public virtual SingleOrder SellShort(Instrument instrument)
		{
			return this.SellShort(instrument, "SellShort " + base.Strategy.Name);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000FEEA File Offset: 0x0000EEEA
		public virtual SingleOrder SellShort(string text)
		{
			return this.SellShort(this.instrument, text);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000FEF9 File Offset: 0x0000EEF9
		public virtual SingleOrder SellShort()
		{
			return this.SellShort(this.instrument);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000FF08 File Offset: 0x0000EF08
		public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.SellShort, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000FF4F File Offset: 0x0000EF4F
		public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode)
		{
			return this.SellShort(instrument, mode, "SellShort " + base.Strategy.Name);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000FF6E File Offset: 0x0000EF6E
		public virtual SingleOrder SellShort(string text, FillOnBarMode mode)
		{
			return this.SellShort(this.instrument, mode, text);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000FF7E File Offset: 0x0000EF7E
		public virtual SingleOrder SellShort(FillOnBarMode mode)
		{
			return this.SellShort(this.instrument, mode);
		}

		// Token: 0x04000159 RID: 345
		public const string GUID = "{94FAFF9D-5281-4c67-A599-B893F1F58B38}";
	}
}
