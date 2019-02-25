using System;
using System.ComponentModel;
using System.Drawing.Design;
using SmartQuant.FIX;
using SmartQuant.Instruments.Design;

namespace SmartQuant.Instruments
{
	// Token: 0x02000015 RID: 21
	public class Leg : FIXGroup
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00004B58 File Offset: 0x00003B58
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00004B60 File Offset: 0x00003B60
		[Editor(typeof(InstrumentTypeEditor), typeof(UITypeEditor))]
		public Instrument Instrument
		{
			get
			{
				return this.fInstrument;
			}
			set
			{
				this.fInstrument = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00004B69 File Offset: 0x00003B69
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00004B76 File Offset: 0x00003B76
		[FIXField("623", EFieldOption.Optional)]
		public double LegRatioQty
		{
			get
			{
				return this.GetDoubleValue(623);
			}
			set
			{
				this.SetDoubleValue(623, value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00004B84 File Offset: 0x00003B84
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00004B91 File Offset: 0x00003B91
		[FIXField("624", EFieldOption.Optional)]
		public char LegSide
		{
			get
			{
				return this.GetCharValue(624);
			}
			set
			{
				this.SetCharValue(624, value);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00004B9F File Offset: 0x00003B9F
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00004BAC File Offset: 0x00003BAC
		[FIXField("556", EFieldOption.Optional)]
		public string LegCurrency
		{
			get
			{
				return this.GetStringValue(556);
			}
			set
			{
				this.SetStringValue(556, value);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004BBA File Offset: 0x00003BBA
		public Leg()
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004BC2 File Offset: 0x00003BC2
		public Leg(Instrument instrument)
		{
			this.fInstrument = instrument;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004BD1 File Offset: 0x00003BD1
		public Leg(Instrument instrument, char side, double ratioQty)
		{
			this.fInstrument = instrument;
			this.LegSide = side;
			this.LegRatioQty = ratioQty;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00004BEE File Offset: 0x00003BEE
		public Leg(string symbol)
		{
			this.fInstrument = InstrumentManager.Instruments[symbol];
			if (this.fInstrument == null)
			{
				throw new ArgumentException("Can not create leg. Instrument does not exist : " + symbol);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004C20 File Offset: 0x00003C20
		public Leg(string symbol, char side, double ratioQty)
		{
			this.fInstrument = InstrumentManager.Instruments[symbol];
			if (this.fInstrument == null)
			{
				throw new ArgumentException("Can not create leg. Instrument does not exist : " + symbol);
			}
			this.LegSide = side;
			this.LegRatioQty = ratioQty;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004C60 File Offset: 0x00003C60
		public override string ToString()
		{
			if (this.fInstrument != null)
			{
				return this.fInstrument.Symbol;
			}
			return "Not Defined";
		}

		// Token: 0x0400003E RID: 62
		private Instrument fInstrument;
	}
}
