using System;

namespace SmartQuant.Instruments
{
	// Token: 0x02000048 RID: 72
	public interface IInstrumentServer
	{
		// Token: 0x06000384 RID: 900
		void Open(string dataBase);

		// Token: 0x06000385 RID: 901
		void Open();

		// Token: 0x06000386 RID: 902
		InstrumentList Load();

		// Token: 0x06000387 RID: 903
		void Save(Instrument instrument);

		// Token: 0x06000388 RID: 904
		void Remove(Instrument instrument);

		// Token: 0x06000389 RID: 905
		void Close();
	}
}
