using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000042 RID: 66
	public class FIXRule80A : FIXCharField
	{
		// Token: 0x06000F52 RID: 3922 RVA: 0x00011DBF File Offset: 0x00010DBF
		public FIXRule80A(char val) : base(47, val)
		{
		}

		// Token: 0x040000BA RID: 186
		public const char AgencySingleOrder = 'A';

		// Token: 0x040000BB RID: 187
		public const char ShortExemptTransactionAType = 'B';

		// Token: 0x040000BC RID: 188
		public const char ProgramOrderNonIndexArbForMemberFirm = 'C';

		// Token: 0x040000BD RID: 189
		public const char ProgramOrderIndexArbForMemberFirm = 'D';

		// Token: 0x040000BE RID: 190
		public const char ShortExemptTransactionForPrincipal = 'E';

		// Token: 0x040000BF RID: 191
		public const char ShortExemptTransactionWType = 'F';

		// Token: 0x040000C0 RID: 192
		public const char ShortExemptTransactionIType = 'H';

		// Token: 0x040000C1 RID: 193
		public const char IndividualInvestorSingleOrder = 'I';

		// Token: 0x040000C2 RID: 194
		public const char ProgramOrderIndexArbForIndividualCustomer = 'J';

		// Token: 0x040000C3 RID: 195
		public const char ProgramOrderNonIndexArbForIndividualCustomer = 'K';

		// Token: 0x040000C4 RID: 196
		public const char ShortExemptTransactionForMemberCompetingMarketMakerAffiliatedWithTheFirmCleraingTheTrade = 'L';

		// Token: 0x040000C5 RID: 197
		public const char ProgramOrderIndexArbForOtherMember = 'M';

		// Token: 0x040000C6 RID: 198
		public const char ProgramOrderNonIndexArbForOtherMember = 'N';

		// Token: 0x040000C7 RID: 199
		public const char ProprietaryTransactionsForCompetingMarketMakerThatIsAffiliatedWithTheClearingMember = 'O';

		// Token: 0x040000C8 RID: 200
		public const char Principal = 'P';

		// Token: 0x040000C9 RID: 201
		public const char TransactionsForTheAccountOfANonMemberCompetingMarketMaker = 'R';

		// Token: 0x040000CA RID: 202
		public const char SpecialistTrades = 'S';

		// Token: 0x040000CB RID: 203
		public const char TransactionsForTheAccountofAnUnaffiliatedMembersCompetingMarketMaker = 'T';

		// Token: 0x040000CC RID: 204
		public const char ProgramOrderIndexArbForOtherAgency = 'U';

		// Token: 0x040000CD RID: 205
		public const char AllOtherOrdersAsAgentForOtherMember = 'W';

		// Token: 0x040000CE RID: 206
		public const char ShortExemptTransactionForMemberCompetingMarketMakerNotAffiliatedWithTheFirmClearingTheTrade = 'X';

		// Token: 0x040000CF RID: 207
		public const char ProgramOrderNonIndexArbForOtherAgency = 'Y';

		// Token: 0x040000D0 RID: 208
		public const char ShortExemptTransactionForNonMemberCompetingMarketMakerAAndRTypes = 'Z';
	}
}
