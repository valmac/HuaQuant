using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000B8 RID: 184
	public class FIXContAmtsGroup : FIXGroup
	{
		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x000289F9 File Offset: 0x000279F9
		// (set) Token: 0x060025FE RID: 9726 RVA: 0x00028A0B File Offset: 0x00027A0B
		[FIXField("519", EFieldOption.Optional)]
		public int ContAmtType
		{
			get
			{
				return this.GetIntField(519).Value;
			}
			set
			{
				this.AddIntField(519, value);
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x00028A19 File Offset: 0x00027A19
		// (set) Token: 0x06002600 RID: 9728 RVA: 0x00028A2B File Offset: 0x00027A2B
		[FIXField("520", EFieldOption.Optional)]
		public double ContAmtValue
		{
			get
			{
				return this.GetDoubleField(520).Value;
			}
			set
			{
				this.AddDoubleField(520, value);
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x00028A39 File Offset: 0x00027A39
		// (set) Token: 0x06002602 RID: 9730 RVA: 0x00028A4B File Offset: 0x00027A4B
		[FIXField("521", EFieldOption.Optional)]
		public double ContAmtCurr
		{
			get
			{
				return this.GetDoubleField(521).Value;
			}
			set
			{
				this.AddDoubleField(521, value);
			}
		}
	}
}
