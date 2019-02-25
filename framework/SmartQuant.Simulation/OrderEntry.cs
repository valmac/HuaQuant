using System;
using SmartQuant.FIX;
using SmartQuant.Instruments;

namespace SmartQuant.Simulation
{
	// Token: 0x0200001E RID: 30
	public class OrderEntry
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00006346 File Offset: 0x00005346
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000634E File Offset: 0x0000534E
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				this.enabled = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00006357 File Offset: 0x00005357
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000635F File Offset: 0x0000535F
		public DateTime DateTime
		{
			get
			{
				return this.datetime;
			}
			set
			{
				this.datetime = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00006368 File Offset: 0x00005368
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00006370 File Offset: 0x00005370
		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
			set
			{
				this.instrument = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00006379 File Offset: 0x00005379
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00006381 File Offset: 0x00005381
		public Side Side
		{
			get
			{
				return this.side;
			}
			set
			{
				this.side = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000638A File Offset: 0x0000538A
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00006392 File Offset: 0x00005392
		public OrdType OrdType
		{
			get
			{
				return this.ordType;
			}
			set
			{
				this.ordType = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000639B File Offset: 0x0000539B
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000063A3 File Offset: 0x000053A3
		public double Price
		{
			get
			{
				return this.price;
			}
			set
			{
				this.price = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000063AC File Offset: 0x000053AC
		// (set) Token: 0x0600010D RID: 269 RVA: 0x000063B4 File Offset: 0x000053B4
		public double StopPx
		{
			get
			{
				return this.stopPx;
			}
			set
			{
				this.stopPx = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000063BD File Offset: 0x000053BD
		// (set) Token: 0x0600010F RID: 271 RVA: 0x000063C5 File Offset: 0x000053C5
		public double OrderQty
		{
			get
			{
				return this.orderQty;
			}
			set
			{
				this.orderQty = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000063CE File Offset: 0x000053CE
		// (set) Token: 0x06000111 RID: 273 RVA: 0x000063D6 File Offset: 0x000053D6
		public string Text
		{
			get
			{
				return this.text;
			}
			set
			{
				this.text = value;
			}
		}

		// Token: 0x04000095 RID: 149
		private bool enabled;

		// Token: 0x04000096 RID: 150
		private DateTime datetime;

		// Token: 0x04000097 RID: 151
		private Instrument instrument;

		// Token: 0x04000098 RID: 152
		private Side side;

		// Token: 0x04000099 RID: 153
		private OrdType ordType;

		// Token: 0x0400009A RID: 154
		private double price;

		// Token: 0x0400009B RID: 155
		private double stopPx;

		// Token: 0x0400009C RID: 156
		private double orderQty;

		// Token: 0x0400009D RID: 157
		private string text;
	}
}
