using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000C2 RID: 194
	public class FIXPegInstructions : FIXMessage
	{
		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x0002958D File Offset: 0x0002858D
		// (set) Token: 0x060026BB RID: 9915 RVA: 0x0002959F File Offset: 0x0002859F
		[FIXField("211", EFieldOption.Optional)]
		public double PegOffsetValue
		{
			get
			{
				return this.GetDoubleField(211).Value;
			}
			set
			{
				this.AddDoubleField(211, value);
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x000295AD File Offset: 0x000285AD
		// (set) Token: 0x060026BD RID: 9917 RVA: 0x000295BF File Offset: 0x000285BF
		[FIXField("835", EFieldOption.Optional)]
		public int PegMoveType
		{
			get
			{
				return this.GetIntField(835).Value;
			}
			set
			{
				this.AddIntField(835, value);
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x060026BE RID: 9918 RVA: 0x000295CD File Offset: 0x000285CD
		// (set) Token: 0x060026BF RID: 9919 RVA: 0x000295DF File Offset: 0x000285DF
		[FIXField("836", EFieldOption.Optional)]
		public int PegOffsetType
		{
			get
			{
				return this.GetIntField(836).Value;
			}
			set
			{
				this.AddIntField(836, value);
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x000295ED File Offset: 0x000285ED
		// (set) Token: 0x060026C1 RID: 9921 RVA: 0x000295FF File Offset: 0x000285FF
		[FIXField("837", EFieldOption.Optional)]
		public int PegLimitType
		{
			get
			{
				return this.GetIntField(837).Value;
			}
			set
			{
				this.AddIntField(837, value);
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x0002960D File Offset: 0x0002860D
		// (set) Token: 0x060026C3 RID: 9923 RVA: 0x0002961F File Offset: 0x0002861F
		[FIXField("838", EFieldOption.Optional)]
		public int PegRoundDirection
		{
			get
			{
				return this.GetIntField(838).Value;
			}
			set
			{
				this.AddIntField(838, value);
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x0002962D File Offset: 0x0002862D
		// (set) Token: 0x060026C5 RID: 9925 RVA: 0x0002963F File Offset: 0x0002863F
		[FIXField("840", EFieldOption.Optional)]
		public int PegScope
		{
			get
			{
				return this.GetIntField(840).Value;
			}
			set
			{
				this.AddIntField(840, value);
			}
		}
	}
}
