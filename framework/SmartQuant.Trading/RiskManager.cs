using System;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x0200003F RID: 63
	[StrategyComponent("{BE0176A8-3BBD-407c-814A-D5A3E3437899}", ComponentType.RiskManager, Name = "Default_RiskManager", Description = "")]
	public class RiskManager : StrategySingleComponent
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x0000B7E9 File Offset: 0x0000A7E9
		public virtual double GetPositionRisk()
		{
			return 1.0;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000B7F4 File Offset: 0x0000A7F4
		public virtual bool Validate(Signal signal)
		{
			return true;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000B7F7 File Offset: 0x0000A7F7
		public virtual Stop AddStop(Position position, double level, StopType type, StopMode mode)
		{
			if (!base.Strategy.IsInstrumentActive(position.Instrument))
			{
				return null;
			}
			return new Stop(base.Strategy, position, level, type, mode);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000B81E File Offset: 0x0000A81E
		public virtual Stop AddStop(double level, StopType type, StopMode mode)
		{
			if (!base.Strategy.IsInstrumentActive(base.Position.Instrument))
			{
				return null;
			}
			return new Stop(base.Strategy, base.Position, level, type, mode);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000B84E File Offset: 0x0000A84E
		public virtual Stop AddStop(Position position, DateTime time)
		{
			if (!base.Strategy.IsInstrumentActive(position.Instrument))
			{
				return null;
			}
			return new Stop(base.Strategy, position, time);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000B872 File Offset: 0x0000A872
		public virtual Stop AddStop(DateTime time)
		{
			if (!base.Strategy.IsInstrumentActive(base.Position.Instrument))
			{
				return null;
			}
			return new Stop(base.Strategy, base.Position, time);
		}

		// Token: 0x040000F2 RID: 242
		public const string GUID = "{BE0176A8-3BBD-407c-814A-D5A3E3437899}";
	}
}
