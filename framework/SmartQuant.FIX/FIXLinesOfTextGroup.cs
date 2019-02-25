using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000012 RID: 18
	public class FIXLinesOfTextGroup : FIXGroup
	{
		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0000752C File Offset: 0x0000652C
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x0000753B File Offset: 0x0000653B
		[FIXField("58", EFieldOption.Required)]
		public string Text
		{
			get
			{
				return this.GetStringField(58).Value;
			}
			set
			{
				this.AddStringField(58, value);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00007546 File Offset: 0x00006546
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00007558 File Offset: 0x00006558
		[FIXField("354", EFieldOption.Optional)]
		public int EncodedTextLen
		{
			get
			{
				return this.GetIntField(354).Value;
			}
			set
			{
				this.AddIntField(354, value);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00007566 File Offset: 0x00006566
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00007578 File Offset: 0x00006578
		[FIXField("355", EFieldOption.Optional)]
		public string EncodedText
		{
			get
			{
				return this.GetStringField(355).Value;
			}
			set
			{
				this.AddStringField(355, value);
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00007586 File Offset: 0x00006586
		public FIXLinesOfTextGroup()
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0000758E File Offset: 0x0000658E
		public FIXLinesOfTextGroup(string Text)
		{
			this.Text = Text;
		}
	}
}
