using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200011D RID: 285
	public class FIXQuoteQualifiersGroup : FIXGroup
	{
		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x06003651 RID: 13905 RVA: 0x000394F1 File Offset: 0x000384F1
		// (set) Token: 0x06003652 RID: 13906 RVA: 0x00039503 File Offset: 0x00038503
		[FIXField("695", EFieldOption.Optional)]
		public char QuoteQualifier
		{
			get
			{
				return this.GetCharField(695).Value;
			}
			set
			{
				this.AddCharField(695, value);
			}
		}
	}
}
