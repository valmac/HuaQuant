using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000057 RID: 87
	public class FIXSecurityType : FIXStringField
	{
		// Token: 0x06001100 RID: 4352 RVA: 0x000134F3 File Offset: 0x000124F3
		public FIXSecurityType(string val) : base(167, val)
		{
		}

		// Token: 0x040001AA RID: 426
		public const string EuroSupranationalCoupons = "EUSUPRA";

		// Token: 0x040001AB RID: 427
		public const string FederalAgencyCoupon = "FAC";

		// Token: 0x040001AC RID: 428
		public const string FederalAgencyDiscountNote = "FADN";

		// Token: 0x040001AD RID: 429
		public const string PrivateExportFunding = "PEF";

		// Token: 0x040001AE RID: 430
		public const string USDSupranationalCoupons = "SUPRA";

		// Token: 0x040001AF RID: 431
		public const string Future = "FUT";

		// Token: 0x040001B0 RID: 432
		public const string Option = "OPT";

		// Token: 0x040001B1 RID: 433
		public const string FutureOption = "FOP";

		// Token: 0x040001B2 RID: 434
		public const string CorporateBond = "CORP";

		// Token: 0x040001B3 RID: 435
		public const string CorporatePrivatePlacement = "CPP";

		// Token: 0x040001B4 RID: 436
		public const string ConvertibleBond = "CB";

		// Token: 0x040001B5 RID: 437
		public const string DualCurrency = "DUAL";

		// Token: 0x040001B6 RID: 438
		public const string EuroCorporateBond = "EUCORP";

		// Token: 0x040001B7 RID: 439
		public const string IndexedLinked = "XLINKD";

		// Token: 0x040001B8 RID: 440
		public const string StructuredNotes = "STRUCT";

		// Token: 0x040001B9 RID: 441
		public const string YankeeCorporateBond = "YANK";

		// Token: 0x040001BA RID: 442
		public const string ForeignExchangeContract = "FOR";

		// Token: 0x040001BB RID: 443
		public const string CommonStock = "CS";

		// Token: 0x040001BC RID: 444
		public const string PreferredStock = "PS";

		// Token: 0x040001BD RID: 445
		public const string BradyBond = "BRADY";

		// Token: 0x040001BE RID: 446
		public const string EuroSovereigns = "EUSOV";

		// Token: 0x040001BF RID: 447
		public const string USTreasuryBond = "TBOND";

		// Token: 0x040001C0 RID: 448
		public const string InterestStripFromAnyBondOrNote = "TINT";

		// Token: 0x040001C1 RID: 449
		public const string TreasuryInflationProtectedSecurities = "TIPS";

		// Token: 0x040001C2 RID: 450
		public const string PrincipalStripOfACallableBondOrNote = "TCAL";

		// Token: 0x040001C3 RID: 451
		public const string PrincipalStripFromANoncallableBondOrNote = "TPRN";

		// Token: 0x040001C4 RID: 452
		public const string USTreasuryNote = "TNOTE";

		// Token: 0x040001C5 RID: 453
		public const string USTreasuryBill = "TBILL";

		// Token: 0x040001C6 RID: 454
		public const string Repurchase = "REPO";

		// Token: 0x040001C7 RID: 455
		public const string Forward = "FORWARD";

		// Token: 0x040001C8 RID: 456
		public const string BuySellback = "BUYSELL";

		// Token: 0x040001C9 RID: 457
		public const string SecuritiesLoan = "SECLOAN";

		// Token: 0x040001CA RID: 458
		public const string SecuritiesPledge = "SECPLEDGE";

		// Token: 0x040001CB RID: 459
		public const string Index = "IDX";

		// Token: 0x040001CC RID: 460
		public const string TermLoan = "TERM";

		// Token: 0x040001CD RID: 461
		public const string RevolverLoan = "RVLV";

		// Token: 0x040001CE RID: 462
		public const string RevolverTermLoan = "RVLVTRM";

		// Token: 0x040001CF RID: 463
		public const string BridgeLoan = "BRIDGE";

		// Token: 0x040001D0 RID: 464
		public const string LetterOfCredit = "LOFC";

		// Token: 0x040001D1 RID: 465
		public const string SwingLineFacility = "SWING";

		// Token: 0x040001D2 RID: 466
		public const string DebtorInPossession = "DINP";

		// Token: 0x040001D3 RID: 467
		public const string Defaulted = "DEFLTED";

		// Token: 0x040001D4 RID: 468
		public const string Withdrawn = "WITHDRN";

		// Token: 0x040001D5 RID: 469
		public const string Replaced = "REPLACD";

		// Token: 0x040001D6 RID: 470
		public const string Matured = "MATURED";

		// Token: 0x040001D7 RID: 471
		public const string AmendedAndRestated = "AMENDED";

		// Token: 0x040001D8 RID: 472
		public const string Retired = "RETIRED";

		// Token: 0x040001D9 RID: 473
		public const string BankersAcceptance = "BA";

		// Token: 0x040001DA RID: 474
		public const string BankNotes = "BN";

		// Token: 0x040001DB RID: 475
		public const string BillOfExchanges = "BOX";

		// Token: 0x040001DC RID: 476
		public const string CertificateOfDeposit = "CD";

		// Token: 0x040001DD RID: 477
		public const string CallLoans = "CL";

		// Token: 0x040001DE RID: 478
		public const string CommercialPaper = "CP";

		// Token: 0x040001DF RID: 479
		public const string DepositNotes = "DN";

		// Token: 0x040001E0 RID: 480
		public const string EuroCertificateOfDeposit = "EUCD";

		// Token: 0x040001E1 RID: 481
		public const string EuroCommercialPaper = "EUCP";

		// Token: 0x040001E2 RID: 482
		public const string LiquidityNote = "LQN";

		// Token: 0x040001E3 RID: 483
		public const string MediumTermNotes = "MTN";

		// Token: 0x040001E4 RID: 484
		public const string Overnight = "ONITE";

		// Token: 0x040001E5 RID: 485
		public const string PromissoryNote = "PN";

		// Token: 0x040001E6 RID: 486
		public const string PlazosFijos = "PZFJ";

		// Token: 0x040001E7 RID: 487
		public const string ShortTermLoanNote = "STN";

		// Token: 0x040001E8 RID: 488
		public const string TimeDeposit = "TD";

		// Token: 0x040001E9 RID: 489
		public const string ExtendedCommNote = "XCN";

		// Token: 0x040001EA RID: 490
		public const string YankeeCertificateOfDeposit = "YCD";

		// Token: 0x040001EB RID: 491
		public const string AssetBackedSecurities = "ABS";

		// Token: 0x040001EC RID: 492
		public const string CorpMortgageBackedSecurities = "CMBS";

		// Token: 0x040001ED RID: 493
		public const string CollateralizedMortgageObligation = "CMO";

		// Token: 0x040001EE RID: 494
		public const string IOETTEMortgage = "IET";

		// Token: 0x040001EF RID: 495
		public const string MortgageBackedSecurities = "MBS";

		// Token: 0x040001F0 RID: 496
		public const string MortgageInterestOnly = "MIO";

		// Token: 0x040001F1 RID: 497
		public const string MortgagePrincipalOnly = "MPO";

		// Token: 0x040001F2 RID: 498
		public const string MortgagePrivatePlacement = "MPP";

		// Token: 0x040001F3 RID: 499
		public const string MiscellaneousPassThrough = "MPT";

		// Token: 0x040001F4 RID: 500
		public const string Pfandbriefe = "PFAND";

		// Token: 0x040001F5 RID: 501
		public const string ToBeAnnounced = "TBA";

		// Token: 0x040001F6 RID: 502
		public const string OtherAnticipationNotes = "AN";

		// Token: 0x040001F7 RID: 503
		public const string CertificateOfObligation = "COFO";

		// Token: 0x040001F8 RID: 504
		public const string CertificateOfParticipation = "COFP";

		// Token: 0x040001F9 RID: 505
		public const string GeneralObligationBonds = "GO";

		// Token: 0x040001FA RID: 506
		public const string MandatoryTender = "MT";

		// Token: 0x040001FB RID: 507
		public const string RevenueAnticipationNote = "RAN";

		// Token: 0x040001FC RID: 508
		public const string RevenueBonds = "REV";

		// Token: 0x040001FD RID: 509
		public const string SpecialAssessment = "SPCLA";

		// Token: 0x040001FE RID: 510
		public const string SpecialObligation = "SPCLO";

		// Token: 0x040001FF RID: 511
		public const string SpecialTax = "SPCLT";

		// Token: 0x04000200 RID: 512
		public const string TaxAnticipationNote = "TAN";

		// Token: 0x04000201 RID: 513
		public const string TaxAllocation = "TAXA";

		// Token: 0x04000202 RID: 514
		public const string TaxExemptCommercialPaper = "TECP";

		// Token: 0x04000203 RID: 515
		public const string TaxAndRevenueAnticipationNote = "TRAN";

		// Token: 0x04000204 RID: 516
		public const string VariableRateDemandNote = "VRDN";

		// Token: 0x04000205 RID: 517
		public const string Warrant = "WAR";

		// Token: 0x04000206 RID: 518
		public const string ExchangeTradedFund = "ETF";

		// Token: 0x04000207 RID: 519
		public const string MutualFund = "MF";

		// Token: 0x04000208 RID: 520
		public const string MultiLegInstrument = "MLEG";

		// Token: 0x04000209 RID: 521
		public const string Energy = "NRG";

		// Token: 0x0400020A RID: 522
		public const string NoSecurityType = "NONE";

		// Token: 0x0400020B RID: 523
		public const string Wildcard = "?";
	}
}
