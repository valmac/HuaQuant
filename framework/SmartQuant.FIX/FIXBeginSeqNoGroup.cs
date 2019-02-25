using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000174 RID: 372
	public class FIXBeginSeqNoGroup : FIXGroup
	{
		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x0004D221 File Offset: 0x0004C221
		// (set) Token: 0x06004575 RID: 17781 RVA: 0x0004D22F File Offset: 0x0004C22F
		[FIXField("7", EFieldOption.Required)]
		public int BeginSeqNo
		{
			get
			{
				return this.GetIntField(7).Value;
			}
			set
			{
				this.AddIntField(7, value);
			}
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x0004D239 File Offset: 0x0004C239
		// (set) Token: 0x06004577 RID: 17783 RVA: 0x0004D248 File Offset: 0x0004C248
		[FIXField("16", EFieldOption.Required)]
		public int EndSeqNo
		{
			get
			{
				return this.GetIntField(16).Value;
			}
			set
			{
				this.AddIntField(16, value);
			}
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x0004D253 File Offset: 0x0004C253
		public FIXBeginSeqNoGroup()
		{
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x0004D25B File Offset: 0x0004C25B
		public FIXBeginSeqNoGroup(int BeginSeqNo, int EndSeqNo)
		{
			this.BeginSeqNo = BeginSeqNo;
			this.EndSeqNo = EndSeqNo;
		}
	}
}
