using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000141 RID: 321
	public class FIXBidDescriptorsGroup : FIXGroup
	{
		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06003ECE RID: 16078 RVA: 0x0004212E File Offset: 0x0004112E
		// (set) Token: 0x06003ECF RID: 16079 RVA: 0x00042140 File Offset: 0x00041140
		[FIXField("399", EFieldOption.Optional)]
		public int BidDescriptorType
		{
			get
			{
				return this.GetIntField(399).Value;
			}
			set
			{
				this.AddIntField(399, value);
			}
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06003ED0 RID: 16080 RVA: 0x0004214E File Offset: 0x0004114E
		// (set) Token: 0x06003ED1 RID: 16081 RVA: 0x00042160 File Offset: 0x00041160
		[FIXField("400", EFieldOption.Optional)]
		public string BidDescriptor
		{
			get
			{
				return this.GetStringField(400).Value;
			}
			set
			{
				this.AddStringField(400, value);
			}
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06003ED2 RID: 16082 RVA: 0x0004216E File Offset: 0x0004116E
		// (set) Token: 0x06003ED3 RID: 16083 RVA: 0x00042180 File Offset: 0x00041180
		[FIXField("401", EFieldOption.Optional)]
		public int SideValueInd
		{
			get
			{
				return this.GetIntField(401).Value;
			}
			set
			{
				this.AddIntField(401, value);
			}
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x06003ED4 RID: 16084 RVA: 0x0004218E File Offset: 0x0004118E
		// (set) Token: 0x06003ED5 RID: 16085 RVA: 0x000421A0 File Offset: 0x000411A0
		[FIXField("404", EFieldOption.Optional)]
		public double LiquidityValue
		{
			get
			{
				return this.GetDoubleField(404).Value;
			}
			set
			{
				this.AddDoubleField(404, value);
			}
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x06003ED6 RID: 16086 RVA: 0x000421AE File Offset: 0x000411AE
		// (set) Token: 0x06003ED7 RID: 16087 RVA: 0x000421C0 File Offset: 0x000411C0
		[FIXField("441", EFieldOption.Optional)]
		public int LiquidityNumSecurities
		{
			get
			{
				return this.GetIntField(441).Value;
			}
			set
			{
				this.AddIntField(441, value);
			}
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x06003ED8 RID: 16088 RVA: 0x000421CE File Offset: 0x000411CE
		// (set) Token: 0x06003ED9 RID: 16089 RVA: 0x000421E0 File Offset: 0x000411E0
		[FIXField("402", EFieldOption.Optional)]
		public double LiquidityPctLow
		{
			get
			{
				return this.GetDoubleField(402).Value;
			}
			set
			{
				this.AddDoubleField(402, value);
			}
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x000421EE File Offset: 0x000411EE
		// (set) Token: 0x06003EDB RID: 16091 RVA: 0x00042200 File Offset: 0x00041200
		[FIXField("403", EFieldOption.Optional)]
		public double LiquidityPctHigh
		{
			get
			{
				return this.GetDoubleField(403).Value;
			}
			set
			{
				this.AddDoubleField(403, value);
			}
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x0004220E File Offset: 0x0004120E
		// (set) Token: 0x06003EDD RID: 16093 RVA: 0x00042220 File Offset: 0x00041220
		[FIXField("405", EFieldOption.Optional)]
		public double EFPTrackingError
		{
			get
			{
				return this.GetDoubleField(405).Value;
			}
			set
			{
				this.AddDoubleField(405, value);
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06003EDE RID: 16094 RVA: 0x0004222E File Offset: 0x0004122E
		// (set) Token: 0x06003EDF RID: 16095 RVA: 0x00042240 File Offset: 0x00041240
		[FIXField("406", EFieldOption.Optional)]
		public double FairValue
		{
			get
			{
				return this.GetDoubleField(406).Value;
			}
			set
			{
				this.AddDoubleField(406, value);
			}
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06003EE0 RID: 16096 RVA: 0x0004224E File Offset: 0x0004124E
		// (set) Token: 0x06003EE1 RID: 16097 RVA: 0x00042260 File Offset: 0x00041260
		[FIXField("407", EFieldOption.Optional)]
		public double OutsideIndexPct
		{
			get
			{
				return this.GetDoubleField(407).Value;
			}
			set
			{
				this.AddDoubleField(407, value);
			}
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x06003EE2 RID: 16098 RVA: 0x0004226E File Offset: 0x0004126E
		// (set) Token: 0x06003EE3 RID: 16099 RVA: 0x00042280 File Offset: 0x00041280
		[FIXField("408", EFieldOption.Optional)]
		public double ValueOfFutures
		{
			get
			{
				return this.GetDoubleField(408).Value;
			}
			set
			{
				this.AddDoubleField(408, value);
			}
		}
	}
}
