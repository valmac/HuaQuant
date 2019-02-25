using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000167 RID: 359
	public class FIXMsgTypesGroup : FIXGroup
	{
		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06004377 RID: 17271 RVA: 0x000499C8 File Offset: 0x000489C8
		// (set) Token: 0x06004378 RID: 17272 RVA: 0x000499DA File Offset: 0x000489DA
		[FIXField("372", EFieldOption.Optional)]
		public string RefMsgType
		{
			get
			{
				return this.GetStringField(372).Value;
			}
			set
			{
				this.AddStringField(372, value);
			}
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06004379 RID: 17273 RVA: 0x000499E8 File Offset: 0x000489E8
		// (set) Token: 0x0600437A RID: 17274 RVA: 0x000499FA File Offset: 0x000489FA
		[FIXField("385", EFieldOption.Optional)]
		public char MsgDirection
		{
			get
			{
				return this.GetCharField(385).Value;
			}
			set
			{
				this.AddCharField(385, value);
			}
		}
	}
}
