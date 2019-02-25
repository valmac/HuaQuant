using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000D5 RID: 213
	public class FIXInstrAttribGroup : FIXGroup
	{
		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x0002D692 File Offset: 0x0002C692
		// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x0002D6A4 File Offset: 0x0002C6A4
		[FIXField("871", EFieldOption.Optional)]
		public int InstrAttribType
		{
			get
			{
				return this.GetIntField(871).Value;
			}
			set
			{
				this.AddIntField(871, value);
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x0002D6B2 File Offset: 0x0002C6B2
		// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x0002D6C4 File Offset: 0x0002C6C4
		[FIXField("872", EFieldOption.Optional)]
		public string InstrAttribValue
		{
			get
			{
				return this.GetStringField(872).Value;
			}
			set
			{
				this.AddStringField(872, value);
			}
		}
	}
}
