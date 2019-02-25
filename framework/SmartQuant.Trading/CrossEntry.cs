using System;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Simulation;

namespace SmartQuant.Trading
{
	// Token: 0x02000070 RID: 112
	[StrategyComponent("{664274F3-FDE1-46da-A84F-556E4A0EB170}", ComponentType.CrossEntry, Name = "Default_CrossEntry", Description = "")]
	public class CrossEntry : StrategyMultiComponent
	{
		// Token: 0x06000484 RID: 1156 RVA: 0x0001025D File Offset: 0x0000F25D
		public virtual SingleOrder EmitSignal(Signal signal)
		{
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001026C File Offset: 0x0000F26C
		public virtual SingleOrder LongEntry(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text);
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x000102A9 File Offset: 0x0000F2A9
		public virtual SingleOrder LongEntry(Instrument instrument)
		{
			return this.LongEntry(instrument, "LongEntry " + base.Strategy.Name);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000102C8 File Offset: 0x0000F2C8
		public virtual SingleOrder ShortEntry(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.SellShort, instrument, text);
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00010305 File Offset: 0x0000F305
		public virtual SingleOrder ShortEntry(Instrument instrument)
		{
			return this.ShortEntry(instrument, "ShortEntry " + base.Strategy.Name);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00010324 File Offset: 0x0000F324
		public virtual SingleOrder LongEntry(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001036F File Offset: 0x0000F36F
		public virtual SingleOrder LongEntry(Instrument instrument, double price)
		{
			return this.LongEntry(instrument, price, "LongEntry " + base.Strategy.Name);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00010390 File Offset: 0x0000F390
		public virtual SingleOrder ShortEntry(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.SellShort, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000103DB File Offset: 0x0000F3DB
		public virtual SingleOrder ShortEntry(Instrument instrument, double price)
		{
			return this.ShortEntry(instrument, price, "ShortEntry " + base.Strategy.Name);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000103FC File Offset: 0x0000F3FC
		public virtual SingleOrder LongEntry(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00010447 File Offset: 0x0000F447
		public virtual SingleOrder LongEntry(Instrument instrument, FillOnBarMode mode)
		{
			return this.LongEntry(instrument, mode, "LongEntry " + base.Strategy.Name);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00010468 File Offset: 0x0000F468
		public virtual SingleOrder ShortEntry(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.SellShort, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000104B3 File Offset: 0x0000F4B3
		public virtual SingleOrder ShortEntry(Instrument instrument, FillOnBarMode mode)
		{
			return this.ShortEntry(instrument, mode, "ShortEntry " + base.Strategy.Name);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000104D2 File Offset: 0x0000F4D2
		public virtual SingleOrder Buy(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			return base.Strategy.EmitSignal(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text));
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00010502 File Offset: 0x0000F502
		public virtual SingleOrder Buy(Instrument instrument)
		{
			return this.Buy(instrument, "Buy " + base.Strategy.Name);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00010520 File Offset: 0x0000F520
		public virtual SingleOrder Buy(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0001056B File Offset: 0x0000F56B
		public virtual SingleOrder Buy(Instrument instrument, double price)
		{
			return this.Buy(instrument, price, "Buy " + base.Strategy.Name);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0001058C File Offset: 0x0000F58C
		public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000105D7 File Offset: 0x0000F5D7
		public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode)
		{
			return this.Buy(instrument, mode, "Buy " + base.Strategy.Name);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000105F8 File Offset: 0x0000F5F8
		public virtual SingleOrder BuyMarket(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text);
			signal.ForceMarketOrder = true;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001063C File Offset: 0x0000F63C
		public virtual SingleOrder BuyMarket(Instrument instrument)
		{
			return this.Buy(instrument, "BuyMarket " + base.Strategy.Name);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0001065C File Offset: 0x0000F65C
		public virtual SingleOrder BuyLimit(Instrument instrument, double price, TimeInForce timeInForce, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Limit, SignalSide.Buy, instrument, text);
			signal.LimitPrice = price;
			signal.TimeInForce = timeInForce;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000106A8 File Offset: 0x0000F6A8
		public virtual SingleOrder BuyLimit(Instrument instrument, double price, string text)
		{
			return this.BuyLimit(instrument, price, TimeInForce.GTC, text);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000106B4 File Offset: 0x0000F6B4
		public virtual SingleOrder BuyLimit(Instrument instrument, double price, TimeInForce timeInForce)
		{
			return this.BuyLimit(instrument, price, timeInForce, "BuyLimit " + base.Strategy.Name);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000106D4 File Offset: 0x0000F6D4
		public virtual SingleOrder BuyLimit(Instrument instrument, double price)
		{
			return this.BuyLimit(instrument, price, "BuyLimit " + base.Strategy.Name);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x000106F4 File Offset: 0x0000F6F4
		public virtual SingleOrder BuyStop(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Stop, SignalSide.Buy, instrument, text);
			signal.StopPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00010738 File Offset: 0x0000F738
		public virtual SingleOrder BuyStop(Instrument instrument, double price)
		{
			return this.BuyStop(instrument, price, "BuyStop " + base.Strategy.Name);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00010758 File Offset: 0x0000F758
		public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.StopLimit, SignalSide.Buy, instrument, text);
			signal.StopPrice = stopPrice;
			signal.LimitPrice = limitPrice;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000107A4 File Offset: 0x0000F7A4
		public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice)
		{
			return this.BuyStopLimit(instrument, stopPrice, limitPrice, "BuyStopLimit " + base.Strategy.Name);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000107C4 File Offset: 0x0000F7C4
		public virtual SingleOrder BuyTrailingStop(Instrument instrument, double delta, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.TrailingStop, SignalSide.Buy, instrument, text);
			signal.StopPrice = delta;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00010808 File Offset: 0x0000F808
		public virtual SingleOrder BuyTrailingStop(Instrument instrument, double delta)
		{
			return this.BuyTrailingStop(instrument, delta, string.Format("BuyTrailingStop {0}", base.Strategy.Name));
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00010827 File Offset: 0x0000F827
		public virtual SingleOrder Sell(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			return base.Strategy.EmitSignal(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Sell, instrument, text));
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00010857 File Offset: 0x0000F857
		public virtual SingleOrder Sell(Instrument instrument)
		{
			return this.Sell(instrument, "Sell " + base.Strategy.Name);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00010878 File Offset: 0x0000F878
		public virtual SingleOrder Sell(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.StrategyFill = true;
			signal.StrategyPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000108C3 File Offset: 0x0000F8C3
		public virtual SingleOrder Sell(Instrument instrument, double price)
		{
			return this.Sell(instrument, price, "Sell " + base.Strategy.Name);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000108E4 File Offset: 0x0000F8E4
		public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001092F File Offset: 0x0000F92F
		public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode)
		{
			return this.Sell(instrument, mode, "Sell " + base.Strategy.Name);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00010950 File Offset: 0x0000F950
		public virtual SingleOrder SellMarket(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Sell, instrument, text);
			signal.ForceMarketOrder = true;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00010994 File Offset: 0x0000F994
		public virtual SingleOrder SellMarket(Instrument instrument)
		{
			return this.Sell(instrument, "SellMarket " + base.Strategy.Name);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000109B4 File Offset: 0x0000F9B4
		public virtual SingleOrder SellLimit(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Limit, SignalSide.Sell, instrument, text);
			signal.LimitPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000109F8 File Offset: 0x0000F9F8
		public virtual SingleOrder SellLimit(Instrument instrument, double price)
		{
			return this.SellLimit(instrument, price, "SellLimit " + base.Strategy.Name);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00010A18 File Offset: 0x0000FA18
		public virtual SingleOrder SellStop(Instrument instrument, double price, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Stop, SignalSide.Sell, instrument, text);
			signal.StopPrice = price;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00010A5C File Offset: 0x0000FA5C
		public virtual SingleOrder SellStop(Instrument instrument, double price)
		{
			return this.SellStop(instrument, price, "SellStop " + base.Strategy.Name);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00010A7C File Offset: 0x0000FA7C
		public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.StopLimit, SignalSide.Sell, instrument, text);
			signal.StopPrice = stopPrice;
			signal.LimitPrice = limitPrice;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00010AC8 File Offset: 0x0000FAC8
		public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice)
		{
			return this.SellStopLimit(instrument, stopPrice, limitPrice, "SellStopLimit " + base.Strategy.Name);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00010AE8 File Offset: 0x0000FAE8
		public virtual SingleOrder SellTrailingStop(Instrument instrument, double delta, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.TrailingStop, SignalSide.Sell, instrument, text);
			signal.StopPrice = delta;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00010B2C File Offset: 0x0000FB2C
		public virtual SingleOrder SellTrailingStop(Instrument instrument, double delta)
		{
			return this.SellTrailingStop(instrument, delta, string.Format("SellTrailingStop {0}", base.Strategy.Name));
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00010B4B File Offset: 0x0000FB4B
		public virtual SingleOrder SellShort(Instrument instrument, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			return base.Strategy.EmitSignal(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.SellShort, instrument, text));
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00010B7B File Offset: 0x0000FB7B
		public virtual SingleOrder SellShort(Instrument instrument)
		{
			return this.SellShort(instrument, "SellShort " + base.Strategy.Name);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00010B9C File Offset: 0x0000FB9C
		public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode, string text)
		{
			if (!base.Strategy.IsInstrumentActive(instrument))
			{
				return null;
			}
			Signal signal = new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.SellShort, instrument, text);
			signal.ForceFillOnBarMode = true;
			signal.FillOnBarMode = mode;
			return base.Strategy.EmitSignal(signal);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00010BE7 File Offset: 0x0000FBE7
		public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode)
		{
			return this.SellShort(instrument, mode, "SellShort " + base.Strategy.Name);
		}

		// Token: 0x04000164 RID: 356
		public const string GUID = "{664274F3-FDE1-46da-A84F-556E4A0EB170}";
	}
}
