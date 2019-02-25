using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000085 RID: 133
	public class FIXDiscretionInstructions : FIXMessage
	{
		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x0001BBCD File Offset: 0x0001ABCD
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x0001BBDF File Offset: 0x0001ABDF
		[FIXField("388", EFieldOption.Optional)]
		public char DiscretionInst
		{
			get
			{
				return this.GetCharField(388).Value;
			}
			set
			{
				this.AddCharField(388, value);
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x0001BBED File Offset: 0x0001ABED
		// (set) Token: 0x0600195E RID: 6494 RVA: 0x0001BBFF File Offset: 0x0001ABFF
		[FIXField("389", EFieldOption.Optional)]
		public double DiscretionOffsetValue
		{
			get
			{
				return this.GetDoubleField(389).Value;
			}
			set
			{
				this.AddDoubleField(389, value);
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x0001BC0D File Offset: 0x0001AC0D
		// (set) Token: 0x06001960 RID: 6496 RVA: 0x0001BC1F File Offset: 0x0001AC1F
		[FIXField("841", EFieldOption.Optional)]
		public int DiscretionMoveType
		{
			get
			{
				return this.GetIntField(841).Value;
			}
			set
			{
				this.AddIntField(841, value);
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06001961 RID: 6497 RVA: 0x0001BC2D File Offset: 0x0001AC2D
		// (set) Token: 0x06001962 RID: 6498 RVA: 0x0001BC3F File Offset: 0x0001AC3F
		[FIXField("842", EFieldOption.Optional)]
		public int DiscretionOffsetType
		{
			get
			{
				return this.GetIntField(842).Value;
			}
			set
			{
				this.AddIntField(842, value);
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06001963 RID: 6499 RVA: 0x0001BC4D File Offset: 0x0001AC4D
		// (set) Token: 0x06001964 RID: 6500 RVA: 0x0001BC5F File Offset: 0x0001AC5F
		[FIXField("843", EFieldOption.Optional)]
		public int DiscretionLimitType
		{
			get
			{
				return this.GetIntField(843).Value;
			}
			set
			{
				this.AddIntField(843, value);
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x0001BC6D File Offset: 0x0001AC6D
		// (set) Token: 0x06001966 RID: 6502 RVA: 0x0001BC7F File Offset: 0x0001AC7F
		[FIXField("844", EFieldOption.Optional)]
		public int DiscretionRoundDirection
		{
			get
			{
				return this.GetIntField(844).Value;
			}
			set
			{
				this.AddIntField(844, value);
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x0001BC8D File Offset: 0x0001AC8D
		// (set) Token: 0x06001968 RID: 6504 RVA: 0x0001BC9F File Offset: 0x0001AC9F
		[FIXField("846", EFieldOption.Optional)]
		public int DiscretionScope
		{
			get
			{
				return this.GetIntField(846).Value;
			}
			set
			{
				this.AddIntField(846, value);
			}
		}
	}
}
