using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200004A RID: 74
	public interface IFIXInstrument
	{
		// Token: 0x06000F6C RID: 3948
		bool ContainsField(int tag);

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06000F6D RID: 3949
		// (set) Token: 0x06000F6E RID: 3950
		int Id { get; set; }

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06000F6F RID: 3951
		// (set) Token: 0x06000F70 RID: 3952
		[FIXField("55", EFieldOption.Optional)]
		string Symbol { get; set; }

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06000F71 RID: 3953
		// (set) Token: 0x06000F72 RID: 3954
		[FIXField("65", EFieldOption.Optional)]
		string SymbolSfx { get; set; }

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06000F73 RID: 3955
		// (set) Token: 0x06000F74 RID: 3956
		[FIXField("48", EFieldOption.Optional)]
		string SecurityID { get; set; }

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06000F75 RID: 3957
		// (set) Token: 0x06000F76 RID: 3958
		[FIXField("22", EFieldOption.Optional)]
		string SecurityIDSource { get; set; }

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06000F77 RID: 3959
		[FIXField("454", EFieldOption.Optional)]
		int NoSecurityAltID { get; }

		// Token: 0x06000F78 RID: 3960
		FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i);

		// Token: 0x06000F79 RID: 3961
		void AddGroup(FIXSecurityAltIDGroup group);

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06000F7A RID: 3962
		// (set) Token: 0x06000F7B RID: 3963
		[FIXField("460", EFieldOption.Optional)]
		int Product { get; set; }

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06000F7C RID: 3964
		// (set) Token: 0x06000F7D RID: 3965
		[FIXField("461", EFieldOption.Optional)]
		string CFICode { get; set; }

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06000F7E RID: 3966
		// (set) Token: 0x06000F7F RID: 3967
		[FIXField("167", EFieldOption.Optional)]
		string SecurityType { get; set; }

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06000F80 RID: 3968
		// (set) Token: 0x06000F81 RID: 3969
		[FIXField("762", EFieldOption.Optional)]
		string SecuritySubType { get; set; }

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06000F82 RID: 3970
		// (set) Token: 0x06000F83 RID: 3971
		[FIXField("200", EFieldOption.Optional)]
		string MaturityMonthYear { get; set; }

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06000F84 RID: 3972
		// (set) Token: 0x06000F85 RID: 3973
		[FIXField("205", EFieldOption.Optional)]
		string MaturityDay { get; set; }

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06000F86 RID: 3974
		// (set) Token: 0x06000F87 RID: 3975
		[FIXField("541", EFieldOption.Optional)]
		DateTime MaturityDate { get; set; }

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06000F88 RID: 3976
		// (set) Token: 0x06000F89 RID: 3977
		[FIXField("201", EFieldOption.Optional)]
		int PutOrCall { get; set; }

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06000F8A RID: 3978
		// (set) Token: 0x06000F8B RID: 3979
		[FIXField("224", EFieldOption.Optional)]
		DateTime CouponPaymentDate { get; set; }

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06000F8C RID: 3980
		// (set) Token: 0x06000F8D RID: 3981
		[FIXField("225", EFieldOption.Optional)]
		DateTime IssueDate { get; set; }

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06000F8E RID: 3982
		// (set) Token: 0x06000F8F RID: 3983
		[FIXField("239", EFieldOption.Optional)]
		int RepoCollateralSecurityType { get; set; }

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06000F90 RID: 3984
		// (set) Token: 0x06000F91 RID: 3985
		[FIXField("226", EFieldOption.Optional)]
		int RepurchaseTerm { get; set; }

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06000F92 RID: 3986
		// (set) Token: 0x06000F93 RID: 3987
		[FIXField("227", EFieldOption.Optional)]
		double RepurchaseRate { get; set; }

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06000F94 RID: 3988
		// (set) Token: 0x06000F95 RID: 3989
		[FIXField("228", EFieldOption.Optional)]
		double Factor { get; set; }

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06000F96 RID: 3990
		// (set) Token: 0x06000F97 RID: 3991
		[FIXField("255", EFieldOption.Optional)]
		string CreditRating { get; set; }

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06000F98 RID: 3992
		// (set) Token: 0x06000F99 RID: 3993
		[FIXField("543", EFieldOption.Optional)]
		string InstrRegistry { get; set; }

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06000F9A RID: 3994
		// (set) Token: 0x06000F9B RID: 3995
		[FIXField("470", EFieldOption.Optional)]
		string CountryOfIssue { get; set; }

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06000F9C RID: 3996
		// (set) Token: 0x06000F9D RID: 3997
		[FIXField("471", EFieldOption.Optional)]
		string StateOrProvinceOfIssue { get; set; }

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06000F9E RID: 3998
		// (set) Token: 0x06000F9F RID: 3999
		[FIXField("472", EFieldOption.Optional)]
		string LocaleOfIssue { get; set; }

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06000FA0 RID: 4000
		// (set) Token: 0x06000FA1 RID: 4001
		[FIXField("240", EFieldOption.Optional)]
		DateTime RedemptionDate { get; set; }

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06000FA2 RID: 4002
		// (set) Token: 0x06000FA3 RID: 4003
		[FIXField("202", EFieldOption.Optional)]
		double StrikePrice { get; set; }

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06000FA4 RID: 4004
		// (set) Token: 0x06000FA5 RID: 4005
		[FIXField("947", EFieldOption.Optional)]
		string StrikeCurrency { get; set; }

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06000FA6 RID: 4006
		// (set) Token: 0x06000FA7 RID: 4007
		[FIXField("206", EFieldOption.Optional)]
		char OptAttribute { get; set; }

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06000FA8 RID: 4008
		// (set) Token: 0x06000FA9 RID: 4009
		[FIXField("231", EFieldOption.Optional)]
		double ContractMultiplier { get; set; }

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06000FAA RID: 4010
		// (set) Token: 0x06000FAB RID: 4011
		[FIXField("223", EFieldOption.Optional)]
		double CouponRate { get; set; }

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06000FAC RID: 4012
		// (set) Token: 0x06000FAD RID: 4013
		[FIXField("207", EFieldOption.Optional)]
		string SecurityExchange { get; set; }

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06000FAE RID: 4014
		// (set) Token: 0x06000FAF RID: 4015
		[FIXField("106", EFieldOption.Optional)]
		string Issuer { get; set; }

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06000FB0 RID: 4016
		// (set) Token: 0x06000FB1 RID: 4017
		[FIXField("348", EFieldOption.Optional)]
		int EncodedIssuerLen { get; set; }

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06000FB2 RID: 4018
		// (set) Token: 0x06000FB3 RID: 4019
		[FIXField("349", EFieldOption.Optional)]
		string EncodedIssuer { get; set; }

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06000FB4 RID: 4020
		// (set) Token: 0x06000FB5 RID: 4021
		[FIXField("107", EFieldOption.Optional)]
		string SecurityDesc { get; set; }

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06000FB6 RID: 4022
		// (set) Token: 0x06000FB7 RID: 4023
		[FIXField("350", EFieldOption.Optional)]
		int EncodedSecurityDescLen { get; set; }

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06000FB8 RID: 4024
		// (set) Token: 0x06000FB9 RID: 4025
		[FIXField("351", EFieldOption.Optional)]
		string EncodedSecurityDesc { get; set; }

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06000FBA RID: 4026
		// (set) Token: 0x06000FBB RID: 4027
		[FIXField("691", EFieldOption.Optional)]
		string Pool { get; set; }

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06000FBC RID: 4028
		// (set) Token: 0x06000FBD RID: 4029
		[FIXField("667", EFieldOption.Optional)]
		string ContractSettlMonth { get; set; }

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06000FBE RID: 4030
		// (set) Token: 0x06000FBF RID: 4031
		[FIXField("875", EFieldOption.Optional)]
		int CPProgram { get; set; }

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06000FC0 RID: 4032
		// (set) Token: 0x06000FC1 RID: 4033
		[FIXField("876", EFieldOption.Optional)]
		string CPRegType { get; set; }

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06000FC2 RID: 4034
		// (set) Token: 0x06000FC3 RID: 4035
		[FIXField("864", EFieldOption.Optional)]
		int NoEvents { get; set; }

		// Token: 0x06000FC4 RID: 4036
		FIXEventsGroup GetEventsGroup(int i);

		// Token: 0x06000FC5 RID: 4037
		void AddGroup(FIXEventsGroup group);

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06000FC6 RID: 4038
		// (set) Token: 0x06000FC7 RID: 4039
		[FIXField("873", EFieldOption.Optional)]
		DateTime DatedDate { get; set; }

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06000FC8 RID: 4040
		// (set) Token: 0x06000FC9 RID: 4041
		[FIXField("874", EFieldOption.Optional)]
		DateTime InterestAccrualDate { get; set; }
	}
}
