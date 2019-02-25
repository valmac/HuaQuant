using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200006F RID: 111
	public class FIXTradingSessionsGroup : FIXGroup
	{
		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x00016CF8 File Offset: 0x00015CF8
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x00016D0A File Offset: 0x00015D0A
		[FIXField("336", EFieldOption.Optional)]
		public string TradingSessionID
		{
			get
			{
				return this.GetStringField(336).Value;
			}
			set
			{
				this.AddStringField(336, value);
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x00016D18 File Offset: 0x00015D18
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x00016D2A File Offset: 0x00015D2A
		[FIXField("625", EFieldOption.Optional)]
		public string TradingSessionSubID
		{
			get
			{
				return this.GetStringField(625).Value;
			}
			set
			{
				this.AddStringField(625, value);
			}
		}
	}
}
