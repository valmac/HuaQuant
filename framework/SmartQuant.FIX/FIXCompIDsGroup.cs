using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000071 RID: 113
	public class FIXCompIDsGroup : FIXGroup
	{
		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x00016D68 File Offset: 0x00015D68
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x00016D7A File Offset: 0x00015D7A
		[FIXField("930", EFieldOption.Optional)]
		public string RefCompID
		{
			get
			{
				return this.GetStringField(930).Value;
			}
			set
			{
				this.AddStringField(930, value);
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x00016D88 File Offset: 0x00015D88
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x00016D9A File Offset: 0x00015D9A
		[FIXField("931", EFieldOption.Optional)]
		public string RefSubID
		{
			get
			{
				return this.GetStringField(931).Value;
			}
			set
			{
				this.AddStringField(931, value);
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x00016DA8 File Offset: 0x00015DA8
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x00016DBA File Offset: 0x00015DBA
		[FIXField("283", EFieldOption.Optional)]
		public string LocationID
		{
			get
			{
				return this.GetStringField(283).Value;
			}
			set
			{
				this.AddStringField(283, value);
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x00016DC8 File Offset: 0x00015DC8
		// (set) Token: 0x06001479 RID: 5241 RVA: 0x00016DDA File Offset: 0x00015DDA
		[FIXField("284", EFieldOption.Optional)]
		public string DeskID
		{
			get
			{
				return this.GetStringField(284).Value;
			}
			set
			{
				this.AddStringField(284, value);
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x00016DE8 File Offset: 0x00015DE8
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x00016DFA File Offset: 0x00015DFA
		[FIXField("928", EFieldOption.Optional)]
		public int StatusValue
		{
			get
			{
				return this.GetIntField(928).Value;
			}
			set
			{
				this.AddIntField(928, value);
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x00016E08 File Offset: 0x00015E08
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x00016E1A File Offset: 0x00015E1A
		[FIXField("929", EFieldOption.Optional)]
		public string StatusText
		{
			get
			{
				return this.GetStringField(929).Value;
			}
			set
			{
				this.AddStringField(929, value);
			}
		}
	}
}
