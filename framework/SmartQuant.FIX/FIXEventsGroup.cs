using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000EA RID: 234
	public class FIXEventsGroup : FIXGroup
	{
		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x000310DA File Offset: 0x000300DA
		// (set) Token: 0x06002E53 RID: 11859 RVA: 0x000310EC File Offset: 0x000300EC
		[FIXField("865", EFieldOption.Optional)]
		public int EventType
		{
			get
			{
				return this.GetIntField(865).Value;
			}
			set
			{
				this.AddIntField(865, value);
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x000310FA File Offset: 0x000300FA
		// (set) Token: 0x06002E55 RID: 11861 RVA: 0x0003110C File Offset: 0x0003010C
		[FIXField("866", EFieldOption.Optional)]
		public DateTime EventDate
		{
			get
			{
				return this.GetDateTimeField(866).Value;
			}
			set
			{
				this.AddDateTimeField(866, value);
			}
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06002E56 RID: 11862 RVA: 0x0003111A File Offset: 0x0003011A
		// (set) Token: 0x06002E57 RID: 11863 RVA: 0x0003112C File Offset: 0x0003012C
		[FIXField("867", EFieldOption.Optional)]
		public double EventPx
		{
			get
			{
				return this.GetDoubleField(867).Value;
			}
			set
			{
				this.AddDoubleField(867, value);
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x06002E58 RID: 11864 RVA: 0x0003113A File Offset: 0x0003013A
		// (set) Token: 0x06002E59 RID: 11865 RVA: 0x0003114C File Offset: 0x0003014C
		[FIXField("868", EFieldOption.Optional)]
		public string EventText
		{
			get
			{
				return this.GetStringField(868).Value;
			}
			set
			{
				this.AddStringField(868, value);
			}
		}
	}
}
