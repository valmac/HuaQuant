﻿using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200010C RID: 268
	public class FIXComponentBlock
	{
		// Token: 0x060031BB RID: 12731 RVA: 0x000345A8 File Offset: 0x000335A8
		public static void Copy(IFIXInstrument from, IFIXInstrument to)
		{
			if (from.ContainsField(461))
			{
				to.CFICode = from.CFICode;
			}
			if (from.ContainsField(231))
			{
				to.ContractMultiplier = from.ContractMultiplier;
			}
			if (from.ContainsField(667))
			{
				to.ContractSettlMonth = from.ContractSettlMonth;
			}
			if (from.ContainsField(470))
			{
				to.CountryOfIssue = from.CountryOfIssue;
			}
			if (from.ContainsField(224))
			{
				to.CouponPaymentDate = from.CouponPaymentDate;
			}
			if (from.ContainsField(223))
			{
				to.CouponRate = from.CouponRate;
			}
			if (from.ContainsField(875))
			{
				to.CPProgram = from.CPProgram;
			}
			if (from.ContainsField(876))
			{
				to.CPRegType = from.CPRegType;
			}
			if (from.ContainsField(255))
			{
				to.CreditRating = from.CreditRating;
			}
			if (from.ContainsField(873))
			{
				to.DatedDate = from.DatedDate;
			}
			if (from.ContainsField(349))
			{
				to.EncodedIssuer = from.EncodedIssuer;
			}
			if (from.ContainsField(348))
			{
				to.EncodedIssuerLen = from.EncodedIssuerLen;
			}
			if (from.ContainsField(351))
			{
				to.EncodedSecurityDesc = from.EncodedSecurityDesc;
			}
			if (from.ContainsField(350))
			{
				to.EncodedSecurityDescLen = from.EncodedSecurityDescLen;
			}
			if (from.ContainsField(228))
			{
				to.Factor = from.Factor;
			}
			if (from.ContainsField(543))
			{
				to.InstrRegistry = from.InstrRegistry;
			}
			if (from.ContainsField(874))
			{
				to.InterestAccrualDate = from.InterestAccrualDate;
			}
			if (from.ContainsField(225))
			{
				to.IssueDate = from.IssueDate;
			}
			if (from.ContainsField(106))
			{
				to.Issuer = from.Issuer;
			}
			if (from.ContainsField(472))
			{
				to.LocaleOfIssue = from.LocaleOfIssue;
			}
			if (from.ContainsField(541))
			{
				to.MaturityDate = from.MaturityDate;
			}
			if (from.ContainsField(200))
			{
				to.MaturityMonthYear = from.MaturityMonthYear;
			}
			if (from.ContainsField(206))
			{
				to.OptAttribute = from.OptAttribute;
			}
			if (from.ContainsField(691))
			{
				to.Pool = from.Pool;
			}
			if (from.ContainsField(460))
			{
				to.Product = from.Product;
			}
			if (from.ContainsField(240))
			{
				to.RedemptionDate = from.RedemptionDate;
			}
			if (from.ContainsField(239))
			{
				to.RepoCollateralSecurityType = from.RepoCollateralSecurityType;
			}
			if (from.ContainsField(227))
			{
				to.RepurchaseRate = from.RepurchaseRate;
			}
			if (from.ContainsField(226))
			{
				to.RepurchaseTerm = from.RepurchaseTerm;
			}
			if (from.ContainsField(107))
			{
				to.SecurityDesc = from.SecurityDesc;
			}
			if (from.ContainsField(207))
			{
				to.SecurityExchange = from.SecurityExchange;
			}
			if (from.ContainsField(48))
			{
				to.SecurityID = from.SecurityID;
			}
			if (from.ContainsField(22))
			{
				to.SecurityIDSource = from.SecurityIDSource;
			}
			if (from.ContainsField(762))
			{
				to.SecuritySubType = from.SecuritySubType;
			}
			if (from.ContainsField(167))
			{
				to.SecurityType = from.SecurityType;
			}
			if (from.ContainsField(471))
			{
				to.StateOrProvinceOfIssue = from.StateOrProvinceOfIssue;
			}
			if (from.ContainsField(947))
			{
				to.StrikeCurrency = from.StrikeCurrency;
			}
			if (from.ContainsField(202))
			{
				to.StrikePrice = from.StrikePrice;
			}
			if (from.ContainsField(55))
			{
				to.Symbol = from.Symbol;
			}
			if (from.ContainsField(65))
			{
				to.SymbolSfx = from.SymbolSfx;
			}
		}
	}
}
