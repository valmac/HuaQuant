using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000013 RID: 19
	public class FIXExecsGroup : FIXGroup
	{
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x0000759D File Offset: 0x0000659D
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x000075AC File Offset: 0x000065AC
		[FIXField("17", EFieldOption.Optional)]
		public string ExecID
		{
			get
			{
				return this.GetStringField(17).Value;
			}
			set
			{
				this.AddStringField(17, value);
			}
		}
	}
}
