using System;
using System.ComponentModel;
using System.Drawing.Design;
using SmartQuant.FIX;
using SmartQuant.Instruments.Design;

namespace SmartQuant.Instruments
{
	// Token: 0x0200002B RID: 43
	public class Underlying : FIXGroup
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000835A File Offset: 0x0000735A
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00008362 File Offset: 0x00007362
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000836B File Offset: 0x0000736B
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00008378 File Offset: 0x00007378
		[FIXField("318", EFieldOption.Optional)]
		public string UnderlyingCurrency
		{
			get
			{
				return this.GetStringValue(318);
			}
			set
			{
				this.SetStringValue(318, value);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00008386 File Offset: 0x00007386
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00008393 File Offset: 0x00007393
		[FIXField("879", EFieldOption.Optional)]
		public double UnderlyingQty
		{
			get
			{
				return this.GetDoubleValue(879);
			}
			set
			{
				this.SetDoubleValue(879, value);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000271 RID: 625 RVA: 0x000083A1 File Offset: 0x000073A1
		// (set) Token: 0x06000272 RID: 626 RVA: 0x000083AE File Offset: 0x000073AE
		[FIXField("810", EFieldOption.Optional)]
		public double UnderlyingPx
		{
			get
			{
				return this.GetDoubleValue(810);
			}
			set
			{
				this.SetDoubleValue(810, value);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000273 RID: 627 RVA: 0x000083BC File Offset: 0x000073BC
		// (set) Token: 0x06000274 RID: 628 RVA: 0x000083C9 File Offset: 0x000073C9
		[FIXField("882", EFieldOption.Optional)]
		public double UnderlyingDirtyPrice
		{
			get
			{
				return this.GetDoubleValue(882);
			}
			set
			{
				this.SetDoubleValue(882, value);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000275 RID: 629 RVA: 0x000083D7 File Offset: 0x000073D7
		// (set) Token: 0x06000276 RID: 630 RVA: 0x000083E4 File Offset: 0x000073E4
		[FIXField("883", EFieldOption.Optional)]
		public double UnderlyingEndPrice
		{
			get
			{
				return this.GetDoubleValue(883);
			}
			set
			{
				this.SetDoubleValue(883, value);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000277 RID: 631 RVA: 0x000083F2 File Offset: 0x000073F2
		// (set) Token: 0x06000278 RID: 632 RVA: 0x000083FF File Offset: 0x000073FF
		[FIXField("884", EFieldOption.Optional)]
		public double UnderlyingStartValue
		{
			get
			{
				return this.GetDoubleValue(884);
			}
			set
			{
				this.SetDoubleValue(884, value);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000840D File Offset: 0x0000740D
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0000841A File Offset: 0x0000741A
		[FIXField("885", EFieldOption.Optional)]
		public double UnderlyingCurrentValue
		{
			get
			{
				return this.GetDoubleValue(885);
			}
			set
			{
				this.SetDoubleValue(885, value);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00008428 File Offset: 0x00007428
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00008435 File Offset: 0x00007435
		[FIXField("886", EFieldOption.Optional)]
		public double UnderlyingEndValue
		{
			get
			{
				return this.GetDoubleValue(886);
			}
			set
			{
				this.SetDoubleValue(886, value);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00008443 File Offset: 0x00007443
		public Underlying()
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000844B File Offset: 0x0000744B
		public Underlying(Instrument instrument)
		{
			this.fInstrument = instrument;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000845A File Offset: 0x0000745A
		public Underlying(string symbol)
		{
			this.fInstrument = InstrumentManager.Instruments[symbol];
			if (this.fInstrument == null)
			{
				throw new ArgumentException("Can not create underlying. Instrument does not exist : " + symbol);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000848C File Offset: 0x0000748C
		public override string ToString()
		{
			if (this.fInstrument != null)
			{
				return this.fInstrument.Symbol;
			}
			return "Not Defined";
		}

		// Token: 0x040000AC RID: 172
		private Instrument fInstrument;
	}
}
