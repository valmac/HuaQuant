using System;
using System.Collections;

namespace SmartQuant.Instruments
{
	// Token: 0x0200003F RID: 63
	public class InstrumentManager
	{
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000347 RID: 839 RVA: 0x0000AFBA File Offset: 0x00009FBA
		// (remove) Token: 0x06000348 RID: 840 RVA: 0x0000AFD1 File Offset: 0x00009FD1
		public static event InstrumentEventHandler InstrumentAdded;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000349 RID: 841 RVA: 0x0000AFE8 File Offset: 0x00009FE8
		// (remove) Token: 0x0600034A RID: 842 RVA: 0x0000AFFF File Offset: 0x00009FFF
		public static event InstrumentEventHandler InstrumentRemoved;

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0000B016 File Offset: 0x0000A016
		public static InstrumentList Instruments
		{
			get
			{
				return InstrumentManager.fInstruments;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000B01D File Offset: 0x0000A01D
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0000B024 File Offset: 0x0000A024
		public static IInstrumentServer Server
		{
			get
			{
				return InstrumentManager.fServer;
			}
			set
			{
				InstrumentManager.fServer = value;
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000B02C File Offset: 0x0000A02C
		static InstrumentManager()
		{
			InstrumentManager.fServer.Open();
			InstrumentManager.fInstruments.Clear();
			foreach (object obj in InstrumentManager.fServer.Load())
			{
				Instrument instrument = (Instrument)obj;
				InstrumentManager.fInstruments.Add(instrument);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000B0C0 File Offset: 0x0000A0C0
		public static void Init()
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000B0C2 File Offset: 0x0000A0C2
		public static void Remove(Instrument instrument)
		{
			InstrumentManager.fServer.Remove(instrument);
			InstrumentManager.fInstruments.Remove(instrument);
			if (InstrumentManager.InstrumentRemoved != null)
			{
				InstrumentManager.InstrumentRemoved(new InstrumentEventArgs(instrument));
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000B0F4 File Offset: 0x0000A0F4
		public static void Remove(string symbol)
		{
			Instrument instrument = InstrumentManager.fInstruments[symbol];
			if (instrument != null)
			{
				InstrumentManager.Remove(instrument);
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000B116 File Offset: 0x0000A116
		public static void AddList(InstrumentList list)
		{
			if (InstrumentManager.fLists.Contains(list.Name))
			{
				InstrumentManager.RemoveList(list.Name);
			}
			InstrumentManager.fLists.Add(list.Name, list);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000B146 File Offset: 0x0000A146
		public static void RemoveList(string name)
		{
			InstrumentManager.fLists.Remove(name);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000B153 File Offset: 0x0000A153
		public static InstrumentList GetList(string name)
		{
			return InstrumentManager.fLists[name] as InstrumentList;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000B165 File Offset: 0x0000A165
		internal static void Add(Instrument instrument)
		{
			InstrumentManager.fInstruments.Add(instrument);
			if (InstrumentManager.InstrumentAdded != null)
			{
				InstrumentManager.InstrumentAdded(new InstrumentEventArgs(instrument));
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000B189 File Offset: 0x0000A189
		internal static void Save(Instrument instrument)
		{
			InstrumentManager.fServer.Save(instrument);
			if (!InstrumentManager.fInstruments.Contains(instrument.Id))
			{
				InstrumentManager.fInstruments.RegisterById(instrument);
			}
		}

        // Token: 0x040000F0 RID: 240
        //private static IInstrumentServer fServer = new InstrumentOleDbServer();
        private static IInstrumentServer fServer = new InstrumentSQLiteServer();
        // Token: 0x040000F1 RID: 241
        private static InstrumentList fInstruments = new InstrumentList();

		// Token: 0x040000F2 RID: 242
		private static Hashtable fLists = new Hashtable();
	}
}
