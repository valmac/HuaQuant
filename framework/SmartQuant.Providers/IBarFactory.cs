using System;
using System.ComponentModel;
using SmartQuant.Data;
using SmartQuant.FIX;
using SmartQuant.Providers.Design;

namespace SmartQuant.Providers
{
	// Token: 0x02000018 RID: 24
	[TypeConverter(typeof(BarFactoryTypeConverter))]
	public interface IBarFactory
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007F RID: 127
		// (set) Token: 0x06000080 RID: 128
		bool Enabled { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000081 RID: 129
		// (set) Token: 0x06000082 RID: 130
		BarFactoryInput Input { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000083 RID: 131
		BarFactoryItemList Items { get; }

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000084 RID: 132
		// (remove) Token: 0x06000085 RID: 133
		event BarEventHandler NewBar;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000086 RID: 134
		// (remove) Token: 0x06000087 RID: 135
		event BarEventHandler NewBarOpen;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000088 RID: 136
		// (remove) Token: 0x06000089 RID: 137
		event BarSliceEventHandler NewBarSlice;

		// Token: 0x0600008A RID: 138
		void OnNewTrade(IFIXInstrument instrument, Trade trade);

		// Token: 0x0600008B RID: 139
		void OnNewQuote(IFIXInstrument instrument, Quote quote);

		// Token: 0x0600008C RID: 140
		void Reset();
	}
}
