using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000D2 RID: 210
	public class FIXTrdRegTimestampsGroup : FIXGroup
	{
		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x0002C9C8 File Offset: 0x0002B9C8
		// (set) Token: 0x060029E9 RID: 10729 RVA: 0x0002C9DA File Offset: 0x0002B9DA
		[FIXField("769", EFieldOption.Optional)]
		public DateTime TrdRegTimestamp
		{
			get
			{
				return this.GetDateTimeField(769).Value;
			}
			set
			{
				this.AddDateTimeField(769, value);
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x060029EA RID: 10730 RVA: 0x0002C9E8 File Offset: 0x0002B9E8
		// (set) Token: 0x060029EB RID: 10731 RVA: 0x0002C9FA File Offset: 0x0002B9FA
		[FIXField("770", EFieldOption.Optional)]
		public int TrdRegTimestampType
		{
			get
			{
				return this.GetIntField(770).Value;
			}
			set
			{
				this.AddIntField(770, value);
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x060029EC RID: 10732 RVA: 0x0002CA08 File Offset: 0x0002BA08
		// (set) Token: 0x060029ED RID: 10733 RVA: 0x0002CA1A File Offset: 0x0002BA1A
		[FIXField("771", EFieldOption.Optional)]
		public string TrdRegTimestampOrigin
		{
			get
			{
				return this.GetStringField(771).Value;
			}
			set
			{
				this.AddStringField(771, value);
			}
		}
	}
}
