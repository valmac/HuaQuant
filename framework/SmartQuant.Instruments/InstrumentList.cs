using System;
using System.Collections;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
	// Token: 0x0200002C RID: 44
	public class InstrumentList : FIXGroupList
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000281 RID: 641 RVA: 0x000084A7 File Offset: 0x000074A7
		public string Name
		{
			get
			{
				return this.fName;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000084AF File Offset: 0x000074AF
		// (set) Token: 0x06000283 RID: 643 RVA: 0x000084B7 File Offset: 0x000074B7
		public string Description
		{
			get
			{
				return this.fDescription;
			}
			set
			{
				this.fDescription = value;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000084C0 File Offset: 0x000074C0
		public InstrumentList()
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000084E9 File Offset: 0x000074E9
		public InstrumentList(string name)
		{
			this.fName = name;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00008519 File Offset: 0x00007519
		public InstrumentList(string name, string description)
		{
			this.fName = name;
			this.fDescription = description;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00008550 File Offset: 0x00007550
		public void Add(Instrument instrument)
		{
			if (this.fSymbol.Contains(instrument.Symbol))
			{
				throw new ApplicationException("Can not add instrument that is already present in the list : " + instrument.Symbol);
			}
			this.fSymbol.Add(instrument.Symbol, instrument);
			this.fInstruments.Add(instrument, true);
			foreach (object obj in instrument.SecurityAltIDGroup)
			{
				FIXSecurityAltIDGroup fixsecurityAltIDGroup = (FIXSecurityAltIDGroup)obj;
				this.fSource[fixsecurityAltIDGroup.SecurityAltID + ":" + fixsecurityAltIDGroup.SecurityAltIDSource] = instrument;
			}
			base.Add(instrument);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000861C File Offset: 0x0000761C
		public void Remove(Instrument instrument)
		{
			this.fSymbol.Remove(instrument.Symbol);
			this.fInstruments.Remove(instrument);
			foreach (object obj in new SortedList(this.fSource))
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				if (instrument == dictionaryEntry.Value)
				{
					this.fSource.Remove(dictionaryEntry.Key);
				}
			}
			base.Remove(instrument);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000086B4 File Offset: 0x000076B4
		public override void Clear()
		{
			this.fSymbol.Clear();
			this.fInstruments.Clear();
			this.fSource.Clear();
			base.Clear();
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000086DD File Offset: 0x000076DD
		public bool Contains(string symbol)
		{
			return this.fSymbol.ContainsKey(symbol);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000086EB File Offset: 0x000076EB
		public bool Contains(string symbol, string source)
		{
			return this.fSource.ContainsKey(symbol + ":" + source);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00008704 File Offset: 0x00007704
		public bool Contains(Instrument instrument)
		{
			return this.fInstruments.ContainsKey(instrument);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00008712 File Offset: 0x00007712
		public new Instrument GetById(int id)
		{
			return base.GetById(id) as Instrument;
		}

		// Token: 0x170000A2 RID: 162
		public new Instrument this[int index]
		{
			get
			{
				return this.fSymbol.GetByIndex(index) as Instrument;
			}
		}

		// Token: 0x170000A3 RID: 163
		public Instrument this[string symbol]
		{
			get
			{
				return this.fSymbol[symbol] as Instrument;
			}
		}

		// Token: 0x170000A4 RID: 164
		public Instrument this[string symbol, string source]
		{
			get
			{
				Instrument instrument = this.fSource[symbol + ":" + source] as Instrument;
				if (instrument != null)
				{
					return instrument;
				}
				return this[symbol];
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000877E File Offset: 0x0000777E
		public override IEnumerator GetEnumerator()
		{
			return this.fSymbol.Values.GetEnumerator();
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00008790 File Offset: 0x00007790
		public static implicit operator Instrument[](InstrumentList list)
		{
			return list.fList.ToArray(typeof(Instrument)) as Instrument[];
		}

		// Token: 0x040000AD RID: 173
		private string fName;

		// Token: 0x040000AE RID: 174
		private string fDescription;

		// Token: 0x040000AF RID: 175
		private SortedList fSymbol = new SortedList();

		// Token: 0x040000B0 RID: 176
		private SortedList fSource = new SortedList();

		// Token: 0x040000B1 RID: 177
		private Hashtable fInstruments = new Hashtable();
	}
}
