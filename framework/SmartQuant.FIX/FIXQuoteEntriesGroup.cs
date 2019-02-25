using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200011E RID: 286
	public class FIXQuoteEntriesGroup : FIXGroup
	{
		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x06003654 RID: 13908 RVA: 0x00039519 File Offset: 0x00038519
		// (set) Token: 0x06003655 RID: 13909 RVA: 0x00039528 File Offset: 0x00038528
		[FIXField("55", EFieldOption.Optional)]
		public string Symbol
		{
			get
			{
				return this.GetStringField(55).Value;
			}
			set
			{
				this.AddStringField(55, value);
			}
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06003656 RID: 13910 RVA: 0x00039533 File Offset: 0x00038533
		// (set) Token: 0x06003657 RID: 13911 RVA: 0x00039542 File Offset: 0x00038542
		[FIXField("65", EFieldOption.Optional)]
		public string SymbolSfx
		{
			get
			{
				return this.GetStringField(65).Value;
			}
			set
			{
				this.AddStringField(65, value);
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06003658 RID: 13912 RVA: 0x0003954D File Offset: 0x0003854D
		// (set) Token: 0x06003659 RID: 13913 RVA: 0x0003955C File Offset: 0x0003855C
		[FIXField("48", EFieldOption.Optional)]
		public string SecurityID
		{
			get
			{
				return this.GetStringField(48).Value;
			}
			set
			{
				this.AddStringField(48, value);
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x0600365A RID: 13914 RVA: 0x00039567 File Offset: 0x00038567
		// (set) Token: 0x0600365B RID: 13915 RVA: 0x00039576 File Offset: 0x00038576
		[FIXField("22", EFieldOption.Optional)]
		public string SecurityIDSource
		{
			get
			{
				return this.GetStringField(22).Value;
			}
			set
			{
				this.AddStringField(22, value);
			}
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x0600365C RID: 13916 RVA: 0x00039581 File Offset: 0x00038581
		// (set) Token: 0x0600365D RID: 13917 RVA: 0x00039593 File Offset: 0x00038593
		[FIXField("454", EFieldOption.Optional)]
		public int NoSecurityAltID
		{
			get
			{
				return this.GetIntField(454).Value;
			}
			set
			{
				this.AddIntField(454, value);
			}
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x000395A1 File Offset: 0x000385A1
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x000395BF File Offset: 0x000385BF
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06003660 RID: 13920 RVA: 0x000395DC File Offset: 0x000385DC
		// (set) Token: 0x06003661 RID: 13921 RVA: 0x000395EE File Offset: 0x000385EE
		[FIXField("460", EFieldOption.Optional)]
		public int Product
		{
			get
			{
				return this.GetIntField(460).Value;
			}
			set
			{
				this.AddIntField(460, value);
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06003662 RID: 13922 RVA: 0x000395FC File Offset: 0x000385FC
		// (set) Token: 0x06003663 RID: 13923 RVA: 0x0003960E File Offset: 0x0003860E
		[FIXField("461", EFieldOption.Optional)]
		public string CFICode
		{
			get
			{
				return this.GetStringField(461).Value;
			}
			set
			{
				this.AddStringField(461, value);
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x06003664 RID: 13924 RVA: 0x0003961C File Offset: 0x0003861C
		// (set) Token: 0x06003665 RID: 13925 RVA: 0x0003962E File Offset: 0x0003862E
		[FIXField("167", EFieldOption.Optional)]
		public string SecurityType
		{
			get
			{
				return this.GetStringField(167).Value;
			}
			set
			{
				this.AddStringField(167, value);
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x06003666 RID: 13926 RVA: 0x0003963C File Offset: 0x0003863C
		// (set) Token: 0x06003667 RID: 13927 RVA: 0x0003964E File Offset: 0x0003864E
		[FIXField("762", EFieldOption.Optional)]
		public string SecuritySubType
		{
			get
			{
				return this.GetStringField(762).Value;
			}
			set
			{
				this.AddStringField(762, value);
			}
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x06003668 RID: 13928 RVA: 0x0003965C File Offset: 0x0003865C
		// (set) Token: 0x06003669 RID: 13929 RVA: 0x0003966E File Offset: 0x0003866E
		[FIXField("200", EFieldOption.Optional)]
		public string MaturityMonthYear
		{
			get
			{
				return this.GetStringField(200).Value;
			}
			set
			{
				this.AddStringField(200, value);
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x0600366A RID: 13930 RVA: 0x0003967C File Offset: 0x0003867C
		// (set) Token: 0x0600366B RID: 13931 RVA: 0x0003968E File Offset: 0x0003868E
		[FIXField("541", EFieldOption.Optional)]
		public DateTime MaturityDate
		{
			get
			{
				return this.GetDateTimeField(541).Value;
			}
			set
			{
				this.AddDateTimeField(541, value);
			}
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x0600366C RID: 13932 RVA: 0x0003969C File Offset: 0x0003869C
		// (set) Token: 0x0600366D RID: 13933 RVA: 0x000396AE File Offset: 0x000386AE
		[FIXField("224", EFieldOption.Optional)]
		public DateTime CouponPaymentDate
		{
			get
			{
				return this.GetDateTimeField(224).Value;
			}
			set
			{
				this.AddDateTimeField(224, value);
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x0600366E RID: 13934 RVA: 0x000396BC File Offset: 0x000386BC
		// (set) Token: 0x0600366F RID: 13935 RVA: 0x000396CE File Offset: 0x000386CE
		[FIXField("225", EFieldOption.Optional)]
		public DateTime IssueDate
		{
			get
			{
				return this.GetDateTimeField(225).Value;
			}
			set
			{
				this.AddDateTimeField(225, value);
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06003670 RID: 13936 RVA: 0x000396DC File Offset: 0x000386DC
		// (set) Token: 0x06003671 RID: 13937 RVA: 0x000396EE File Offset: 0x000386EE
		[FIXField("239", EFieldOption.Optional)]
		public int RepoCollateralSecurityType
		{
			get
			{
				return this.GetIntField(239).Value;
			}
			set
			{
				this.AddIntField(239, value);
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06003672 RID: 13938 RVA: 0x000396FC File Offset: 0x000386FC
		// (set) Token: 0x06003673 RID: 13939 RVA: 0x0003970E File Offset: 0x0003870E
		[FIXField("226", EFieldOption.Optional)]
		public int RepurchaseTerm
		{
			get
			{
				return this.GetIntField(226).Value;
			}
			set
			{
				this.AddIntField(226, value);
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06003674 RID: 13940 RVA: 0x0003971C File Offset: 0x0003871C
		// (set) Token: 0x06003675 RID: 13941 RVA: 0x0003972E File Offset: 0x0003872E
		[FIXField("227", EFieldOption.Optional)]
		public double RepurchaseRate
		{
			get
			{
				return this.GetDoubleField(227).Value;
			}
			set
			{
				this.AddDoubleField(227, value);
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06003676 RID: 13942 RVA: 0x0003973C File Offset: 0x0003873C
		// (set) Token: 0x06003677 RID: 13943 RVA: 0x0003974E File Offset: 0x0003874E
		[FIXField("228", EFieldOption.Optional)]
		public double Factor
		{
			get
			{
				return this.GetDoubleField(228).Value;
			}
			set
			{
				this.AddDoubleField(228, value);
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06003678 RID: 13944 RVA: 0x0003975C File Offset: 0x0003875C
		// (set) Token: 0x06003679 RID: 13945 RVA: 0x0003976E File Offset: 0x0003876E
		[FIXField("255", EFieldOption.Optional)]
		public string CreditRating
		{
			get
			{
				return this.GetStringField(255).Value;
			}
			set
			{
				this.AddStringField(255, value);
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x0600367A RID: 13946 RVA: 0x0003977C File Offset: 0x0003877C
		// (set) Token: 0x0600367B RID: 13947 RVA: 0x0003978E File Offset: 0x0003878E
		[FIXField("543", EFieldOption.Optional)]
		public string InstrRegistry
		{
			get
			{
				return this.GetStringField(543).Value;
			}
			set
			{
				this.AddStringField(543, value);
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x0600367C RID: 13948 RVA: 0x0003979C File Offset: 0x0003879C
		// (set) Token: 0x0600367D RID: 13949 RVA: 0x000397AE File Offset: 0x000387AE
		[FIXField("470", EFieldOption.Optional)]
		public string CountryOfIssue
		{
			get
			{
				return this.GetStringField(470).Value;
			}
			set
			{
				this.AddStringField(470, value);
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x0600367E RID: 13950 RVA: 0x000397BC File Offset: 0x000387BC
		// (set) Token: 0x0600367F RID: 13951 RVA: 0x000397CE File Offset: 0x000387CE
		[FIXField("471", EFieldOption.Optional)]
		public string StateOrProvinceOfIssue
		{
			get
			{
				return this.GetStringField(471).Value;
			}
			set
			{
				this.AddStringField(471, value);
			}
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06003680 RID: 13952 RVA: 0x000397DC File Offset: 0x000387DC
		// (set) Token: 0x06003681 RID: 13953 RVA: 0x000397EE File Offset: 0x000387EE
		[FIXField("472", EFieldOption.Optional)]
		public string LocaleOfIssue
		{
			get
			{
				return this.GetStringField(472).Value;
			}
			set
			{
				this.AddStringField(472, value);
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x06003682 RID: 13954 RVA: 0x000397FC File Offset: 0x000387FC
		// (set) Token: 0x06003683 RID: 13955 RVA: 0x0003980E File Offset: 0x0003880E
		[FIXField("240", EFieldOption.Optional)]
		public DateTime RedemptionDate
		{
			get
			{
				return this.GetDateTimeField(240).Value;
			}
			set
			{
				this.AddDateTimeField(240, value);
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x06003684 RID: 13956 RVA: 0x0003981C File Offset: 0x0003881C
		// (set) Token: 0x06003685 RID: 13957 RVA: 0x0003982E File Offset: 0x0003882E
		[FIXField("202", EFieldOption.Optional)]
		public double StrikePrice
		{
			get
			{
				return this.GetDoubleField(202).Value;
			}
			set
			{
				this.AddDoubleField(202, value);
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06003686 RID: 13958 RVA: 0x0003983C File Offset: 0x0003883C
		// (set) Token: 0x06003687 RID: 13959 RVA: 0x0003984E File Offset: 0x0003884E
		[FIXField("947", EFieldOption.Optional)]
		public double StrikeCurrency
		{
			get
			{
				return this.GetDoubleField(947).Value;
			}
			set
			{
				this.AddDoubleField(947, value);
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06003688 RID: 13960 RVA: 0x0003985C File Offset: 0x0003885C
		// (set) Token: 0x06003689 RID: 13961 RVA: 0x0003986E File Offset: 0x0003886E
		[FIXField("206", EFieldOption.Optional)]
		public char OptAttribute
		{
			get
			{
				return this.GetCharField(206).Value;
			}
			set
			{
				this.AddCharField(206, value);
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x0600368A RID: 13962 RVA: 0x0003987C File Offset: 0x0003887C
		// (set) Token: 0x0600368B RID: 13963 RVA: 0x0003988E File Offset: 0x0003888E
		[FIXField("231", EFieldOption.Optional)]
		public double ContractMultiplier
		{
			get
			{
				return this.GetDoubleField(231).Value;
			}
			set
			{
				this.AddDoubleField(231, value);
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x0600368C RID: 13964 RVA: 0x0003989C File Offset: 0x0003889C
		// (set) Token: 0x0600368D RID: 13965 RVA: 0x000398AE File Offset: 0x000388AE
		[FIXField("223", EFieldOption.Optional)]
		public double CouponRate
		{
			get
			{
				return this.GetDoubleField(223).Value;
			}
			set
			{
				this.AddDoubleField(223, value);
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x0600368E RID: 13966 RVA: 0x000398BC File Offset: 0x000388BC
		// (set) Token: 0x0600368F RID: 13967 RVA: 0x000398CE File Offset: 0x000388CE
		[FIXField("207", EFieldOption.Optional)]
		public string SecurityExchange
		{
			get
			{
				return this.GetStringField(207).Value;
			}
			set
			{
				this.AddStringField(207, value);
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x06003690 RID: 13968 RVA: 0x000398DC File Offset: 0x000388DC
		// (set) Token: 0x06003691 RID: 13969 RVA: 0x000398EB File Offset: 0x000388EB
		[FIXField("106", EFieldOption.Optional)]
		public string Issuer
		{
			get
			{
				return this.GetStringField(106).Value;
			}
			set
			{
				this.AddStringField(106, value);
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x000398F6 File Offset: 0x000388F6
		// (set) Token: 0x06003693 RID: 13971 RVA: 0x00039908 File Offset: 0x00038908
		[FIXField("348", EFieldOption.Optional)]
		public int EncodedIssuerLen
		{
			get
			{
				return this.GetIntField(348).Value;
			}
			set
			{
				this.AddIntField(348, value);
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x00039916 File Offset: 0x00038916
		// (set) Token: 0x06003695 RID: 13973 RVA: 0x00039928 File Offset: 0x00038928
		[FIXField("349", EFieldOption.Optional)]
		public string EncodedIssuer
		{
			get
			{
				return this.GetStringField(349).Value;
			}
			set
			{
				this.AddStringField(349, value);
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06003696 RID: 13974 RVA: 0x00039936 File Offset: 0x00038936
		// (set) Token: 0x06003697 RID: 13975 RVA: 0x00039945 File Offset: 0x00038945
		[FIXField("107", EFieldOption.Optional)]
		public string SecurityDesc
		{
			get
			{
				return this.GetStringField(107).Value;
			}
			set
			{
				this.AddStringField(107, value);
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06003698 RID: 13976 RVA: 0x00039950 File Offset: 0x00038950
		// (set) Token: 0x06003699 RID: 13977 RVA: 0x00039962 File Offset: 0x00038962
		[FIXField("350", EFieldOption.Optional)]
		public int EncodedSecurityDescLen
		{
			get
			{
				return this.GetIntField(350).Value;
			}
			set
			{
				this.AddIntField(350, value);
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x0600369A RID: 13978 RVA: 0x00039970 File Offset: 0x00038970
		// (set) Token: 0x0600369B RID: 13979 RVA: 0x00039982 File Offset: 0x00038982
		[FIXField("351", EFieldOption.Optional)]
		public string EncodedSecurityDesc
		{
			get
			{
				return this.GetStringField(351).Value;
			}
			set
			{
				this.AddStringField(351, value);
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x0600369C RID: 13980 RVA: 0x00039990 File Offset: 0x00038990
		// (set) Token: 0x0600369D RID: 13981 RVA: 0x000399A2 File Offset: 0x000389A2
		[FIXField("691", EFieldOption.Optional)]
		public string Pool
		{
			get
			{
				return this.GetStringField(691).Value;
			}
			set
			{
				this.AddStringField(691, value);
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x0600369E RID: 13982 RVA: 0x000399B0 File Offset: 0x000389B0
		// (set) Token: 0x0600369F RID: 13983 RVA: 0x000399C2 File Offset: 0x000389C2
		[FIXField("667", EFieldOption.Optional)]
		public string ContractSettlMonth
		{
			get
			{
				return this.GetStringField(667).Value;
			}
			set
			{
				this.AddStringField(667, value);
			}
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x060036A0 RID: 13984 RVA: 0x000399D0 File Offset: 0x000389D0
		// (set) Token: 0x060036A1 RID: 13985 RVA: 0x000399E2 File Offset: 0x000389E2
		[FIXField("875", EFieldOption.Optional)]
		public int CPProgram
		{
			get
			{
				return this.GetIntField(875).Value;
			}
			set
			{
				this.AddIntField(875, value);
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x060036A2 RID: 13986 RVA: 0x000399F0 File Offset: 0x000389F0
		// (set) Token: 0x060036A3 RID: 13987 RVA: 0x00039A02 File Offset: 0x00038A02
		[FIXField("876", EFieldOption.Optional)]
		public string CPRegType
		{
			get
			{
				return this.GetStringField(876).Value;
			}
			set
			{
				this.AddStringField(876, value);
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x060036A4 RID: 13988 RVA: 0x00039A10 File Offset: 0x00038A10
		// (set) Token: 0x060036A5 RID: 13989 RVA: 0x00039A22 File Offset: 0x00038A22
		[FIXField("864", EFieldOption.Optional)]
		public int NoEvents
		{
			get
			{
				return this.GetIntField(864).Value;
			}
			set
			{
				this.AddIntField(864, value);
			}
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x00039A30 File Offset: 0x00038A30
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x00039A4E File Offset: 0x00038A4E
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x00039A6B File Offset: 0x00038A6B
		// (set) Token: 0x060036A9 RID: 13993 RVA: 0x00039A7D File Offset: 0x00038A7D
		[FIXField("873", EFieldOption.Optional)]
		public DateTime DatedDate
		{
			get
			{
				return this.GetDateTimeField(873).Value;
			}
			set
			{
				this.AddDateTimeField(873, value);
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x060036AA RID: 13994 RVA: 0x00039A8B File Offset: 0x00038A8B
		// (set) Token: 0x060036AB RID: 13995 RVA: 0x00039A9D File Offset: 0x00038A9D
		[FIXField("874", EFieldOption.Optional)]
		public DateTime InterestAccrualDate
		{
			get
			{
				return this.GetDateTimeField(874).Value;
			}
			set
			{
				this.AddDateTimeField(874, value);
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x060036AC RID: 13996 RVA: 0x00039AAB File Offset: 0x00038AAB
		// (set) Token: 0x060036AD RID: 13997 RVA: 0x00039ABD File Offset: 0x00038ABD
		[FIXField("913", EFieldOption.Optional)]
		public string AgreementDesc
		{
			get
			{
				return this.GetStringField(913).Value;
			}
			set
			{
				this.AddStringField(913, value);
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x060036AE RID: 13998 RVA: 0x00039ACB File Offset: 0x00038ACB
		// (set) Token: 0x060036AF RID: 13999 RVA: 0x00039ADD File Offset: 0x00038ADD
		[FIXField("914", EFieldOption.Optional)]
		public string AgreementID
		{
			get
			{
				return this.GetStringField(914).Value;
			}
			set
			{
				this.AddStringField(914, value);
			}
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x060036B0 RID: 14000 RVA: 0x00039AEB File Offset: 0x00038AEB
		// (set) Token: 0x060036B1 RID: 14001 RVA: 0x00039AFD File Offset: 0x00038AFD
		[FIXField("915", EFieldOption.Optional)]
		public DateTime AgreementDate
		{
			get
			{
				return this.GetDateTimeField(915).Value;
			}
			set
			{
				this.AddDateTimeField(915, value);
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x060036B2 RID: 14002 RVA: 0x00039B0B File Offset: 0x00038B0B
		// (set) Token: 0x060036B3 RID: 14003 RVA: 0x00039B1D File Offset: 0x00038B1D
		[FIXField("918", EFieldOption.Optional)]
		public double AgreementCurrency
		{
			get
			{
				return this.GetDoubleField(918).Value;
			}
			set
			{
				this.AddDoubleField(918, value);
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x060036B4 RID: 14004 RVA: 0x00039B2B File Offset: 0x00038B2B
		// (set) Token: 0x060036B5 RID: 14005 RVA: 0x00039B3D File Offset: 0x00038B3D
		[FIXField("788", EFieldOption.Optional)]
		public int TerminationType
		{
			get
			{
				return this.GetIntField(788).Value;
			}
			set
			{
				this.AddIntField(788, value);
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x060036B6 RID: 14006 RVA: 0x00039B4B File Offset: 0x00038B4B
		// (set) Token: 0x060036B7 RID: 14007 RVA: 0x00039B5D File Offset: 0x00038B5D
		[FIXField("916", EFieldOption.Optional)]
		public DateTime StartDate
		{
			get
			{
				return this.GetDateTimeField(916).Value;
			}
			set
			{
				this.AddDateTimeField(916, value);
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x060036B8 RID: 14008 RVA: 0x00039B6B File Offset: 0x00038B6B
		// (set) Token: 0x060036B9 RID: 14009 RVA: 0x00039B7D File Offset: 0x00038B7D
		[FIXField("917", EFieldOption.Optional)]
		public DateTime EndDate
		{
			get
			{
				return this.GetDateTimeField(917).Value;
			}
			set
			{
				this.AddDateTimeField(917, value);
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x060036BA RID: 14010 RVA: 0x00039B8B File Offset: 0x00038B8B
		// (set) Token: 0x060036BB RID: 14011 RVA: 0x00039B9D File Offset: 0x00038B9D
		[FIXField("919", EFieldOption.Optional)]
		public int DeliveryType
		{
			get
			{
				return this.GetIntField(919).Value;
			}
			set
			{
				this.AddIntField(919, value);
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x060036BC RID: 14012 RVA: 0x00039BAB File Offset: 0x00038BAB
		// (set) Token: 0x060036BD RID: 14013 RVA: 0x00039BBD File Offset: 0x00038BBD
		[FIXField("898", EFieldOption.Optional)]
		public double MarginRatio
		{
			get
			{
				return this.GetDoubleField(898).Value;
			}
			set
			{
				this.AddDoubleField(898, value);
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x060036BE RID: 14014 RVA: 0x00039BCB File Offset: 0x00038BCB
		// (set) Token: 0x060036BF RID: 14015 RVA: 0x00039BDD File Offset: 0x00038BDD
		[FIXField("711", EFieldOption.Optional)]
		public int NoUnderlyings
		{
			get
			{
				return this.GetIntField(711).Value;
			}
			set
			{
				this.AddIntField(711, value);
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x060036C0 RID: 14016 RVA: 0x00039BEB File Offset: 0x00038BEB
		// (set) Token: 0x060036C1 RID: 14017 RVA: 0x00039BFD File Offset: 0x00038BFD
		[FIXField("555", EFieldOption.Optional)]
		public int NoLegs
		{
			get
			{
				return this.GetIntField(555).Value;
			}
			set
			{
				this.AddIntField(555, value);
			}
		}

		// Token: 0x04000509 RID: 1289
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x0400050A RID: 1290
		private ArrayList fEventsGroup = new ArrayList();
	}
}
