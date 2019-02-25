using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000064 RID: 100
	public class FIXStandardTrailer : FIXMessage
	{
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00014EF8 File Offset: 0x00013EF8
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x00014F07 File Offset: 0x00013F07
		[FIXField("10", EFieldOption.Required)]
		public string CheckSum
		{
			get
			{
				return this.GetStringField(10).Value;
			}
			set
			{
				this.AddStringField(10, value);
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00014F12 File Offset: 0x00013F12
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x00014F21 File Offset: 0x00013F21
		[FIXField("89", EFieldOption.Optional)]
		public string Signature
		{
			get
			{
				return this.GetStringField(89).Value;
			}
			set
			{
				this.AddStringField(89, value);
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x00014F2C File Offset: 0x00013F2C
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x00014F3B File Offset: 0x00013F3B
		[FIXField("93", EFieldOption.Optional)]
		public int SignatureLength
		{
			get
			{
				return this.GetIntField(93).Value;
			}
			set
			{
				this.AddIntField(93, value);
			}
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00014F46 File Offset: 0x00013F46
		public FIXStandardTrailer()
		{
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00014F4E File Offset: 0x00013F4E
		public FIXStandardTrailer(string CheckSum)
		{
			this.CheckSum = CheckSum;
		}
	}
}
