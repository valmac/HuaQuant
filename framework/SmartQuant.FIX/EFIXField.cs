using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000143 RID: 323
	public sealed class EFIXField
	{
		// Token: 0x06003EEC RID: 16108 RVA: 0x000422F8 File Offset: 0x000412F8
		private EFIXField()
		{
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00042300 File Offset: 0x00041300
		public static string ToString(int tag)
		{
			if (tag <= 10500)
			{
				if (tag <= 10211)
				{
					switch (tag)
					{
					case 1:
						return "Account";
					case 2:
						return "AdvId";
					case 3:
						return "AdvRefID";
					case 4:
						return "AdvSide";
					case 5:
						return "AdvTransType";
					case 6:
						return "AvgPx";
					case 7:
						return "BeginSeqNo";
					case 8:
						return "BeginString";
					case 9:
						return "BodyLength";
					case 10:
						return "CheckSum";
					case 11:
						return "ClOrdID";
					case 12:
						return "Commission";
					case 13:
						return "CommType";
					case 14:
						return "CumQty";
					case 15:
						return "Currency";
					case 16:
						return "EndSeqNo";
					case 17:
						return "ExecID";
					case 18:
						return "ExecInst";
					case 19:
						return "ExecRefID";
					case 20:
						return "ExecTransType";
					case 21:
						return "HandlInst";
					case 22:
						return "SecurityIDSource";
					case 23:
						return "IOIID";
					case 24:
						return "IOIOthSvc";
					case 25:
						return "IOIQltyInd";
					case 26:
						return "IOIRefID";
					case 27:
						return "IOIQty";
					case 28:
						return "IOITransType";
					case 29:
						return "LastCapacity";
					case 30:
						return "LastMkt";
					case 31:
						return "LastPx";
					case 32:
						return "LastQty";
					case 33:
						return "NoLinesOfText";
					case 34:
						return "MsgSeqNum";
					case 35:
						return "MsgType";
					case 36:
						return "NewSeqNo";
					case 37:
						return "OrderID";
					case 38:
						return "OrderQty";
					case 39:
						return "OrdStatus";
					case 40:
						return "OrdType";
					case 41:
						return "OrigClOrdID";
					case 42:
						return "OrigTime";
					case 43:
						return "PossDupFlag";
					case 44:
						return "Price";
					case 45:
						return "RefSeqNum";
					case 46:
						return "RelatdSym";
					case 47:
						return "Rule80A";
					case 48:
						return "SecurityID";
					case 49:
						return "SenderCompID";
					case 50:
						return "SenderSubID";
					case 51:
						return "SendingDate";
					case 52:
						return "SendingTime";
					case 53:
						return "Quantity";
					case 54:
						return "Side";
					case 55:
						return "Symbol";
					case 56:
						return "TargetCompID";
					case 57:
						return "TargetSubID";
					case 58:
						return "Text";
					case 59:
						return "TimeInForce";
					case 60:
						return "TransactTime";
					case 61:
						return "Urgency";
					case 62:
						return "ValidUntilTime";
					case 63:
						return "SettlType";
					case 64:
						return "SettlDate";
					case 65:
						return "SymbolSfx";
					case 66:
						return "ListID";
					case 67:
						return "ListSeqNo";
					case 68:
						return "TotNoOrders";
					case 69:
						return "ListExecInst";
					case 70:
						return "AllocID";
					case 71:
						return "AllocTransType";
					case 72:
						return "RefAllocID";
					case 73:
						return "NoOrders";
					case 74:
						return "AvgPxPrecision";
					case 75:
						return "TradeDate";
					case 76:
						return "ExecBroker";
					case 77:
						return "PositionEffect";
					case 78:
						return "NoAllocs";
					case 79:
						return "AllocAccount";
					case 80:
						return "AllocQty";
					case 81:
						return "ProcessCode";
					case 82:
						return "NoRpts";
					case 83:
						return "RptSeq";
					case 84:
						return "CxlQty";
					case 85:
						return "NoDlvyInst";
					case 86:
						return "DlvyInst";
					case 87:
						return "AllocStatus";
					case 88:
						return "AllocRejCode";
					case 89:
						return "Signature";
					case 90:
						return "SecureDataLen";
					case 91:
						return "SecureData";
					case 92:
						return "BrokerOfCredit";
					case 93:
						return "SignatureLength";
					case 94:
						return "EmailType";
					case 95:
						return "RawDataLength";
					case 96:
						return "RawData";
					case 97:
						return "PossResend";
					case 98:
						return "EncryptMethod";
					case 99:
						return "StopPx";
					case 100:
						return "ExDestination";
					case 101:
					case 261:
					case 809:
						break;
					case 102:
						return "CxlRejReason";
					case 103:
						return "OrdRejReason";
					case 104:
						return "IOIQualifier";
					case 105:
						return "WaveNo";
					case 106:
						return "Issuer";
					case 107:
						return "SecurityDesc";
					case 108:
						return "HeartBtInt";
					case 109:
						return "ClientID";
					case 110:
						return "MinQty";
					case 111:
						return "MaxFloor";
					case 112:
						return "TestReqID";
					case 113:
						return "ReportToExch";
					case 114:
						return "LocateReqd";
					case 115:
						return "OnBehalfOfCompID";
					case 116:
						return "OnBehalfOfSubID";
					case 117:
						return "QuoteID";
					case 118:
						return "NetMoney";
					case 119:
						return "SettlCurrAmt";
					case 120:
						return "SettlCurrency";
					case 121:
						return "ForexReq";
					case 122:
						return "OrigSendingTime";
					case 123:
						return "GapFillFlag";
					case 124:
						return "NoExecs";
					case 125:
						return "CxlType";
					case 126:
						return "ExpireTime";
					case 127:
						return "DKReason";
					case 128:
						return "DeliverToCompID";
					case 129:
						return "DeliverToSubID";
					case 130:
						return "IOINaturalFlag";
					case 131:
						return "QuoteReqID";
					case 132:
						return "BidPx";
					case 133:
						return "OfferPx";
					case 134:
						return "BidSize";
					case 135:
						return "OfferSize";
					case 136:
						return "NoMiscFees";
					case 137:
						return "MiscFeeAmt";
					case 138:
						return "MiscFeeCurr";
					case 139:
						return "MiscFeeType";
					case 140:
						return "PrevClosePx";
					case 141:
						return "ResetSeqNumFlag";
					case 142:
						return "SenderLocationID";
					case 143:
						return "TargetLocationID";
					case 144:
						return "OnBehalfOfLocationID";
					case 145:
						return "DeliverToLocationID";
					case 146:
						return "NoRelatedSym";
					case 147:
						return "Subject";
					case 148:
						return "Headline";
					case 149:
						return "URLLink";
					case 150:
						return "ExecType";
					case 151:
						return "LeavesQty";
					case 152:
						return "CashOrderQty";
					case 153:
						return "AllocAvgPx";
					case 154:
						return "AllocNetMoney";
					case 155:
						return "SettlCurrFxRate";
					case 156:
						return "SettlCurrFxRateCalc";
					case 157:
						return "NumDaysInterest";
					case 158:
						return "AccruedInterestRate";
					case 159:
						return "AccruedInterestAmt";
					case 160:
						return "SettlInstMode";
					case 161:
						return "AllocText";
					case 162:
						return "SettlInstID";
					case 163:
						return "SettlInstTransType";
					case 164:
						return "EmailThreadID";
					case 165:
						return "SettlInstSource";
					case 166:
						return "SettlLocation";
					case 167:
						return "SecurityType";
					case 168:
						return "EffectiveTime";
					case 169:
						return "StandInstDbType";
					case 170:
						return "StandInstDbName";
					case 171:
						return "StandInstDbID";
					case 172:
						return "SettlDeliveryType";
					case 173:
						return "SettlDepositoryCode_";
					case 174:
						return "SettlBrkrCode_";
					case 175:
						return "SettlInstCode_";
					case 176:
						return "SecuritySettlAgentName";
					case 177:
						return "SecuritySettlAgentCode";
					case 178:
						return "SecuritySettlAgentAcctNum";
					case 179:
						return "SecuritySettlAgentAcctName";
					case 180:
						return "SecuritySettlAgentContactName";
					case 181:
						return "SecuritySettlAgentContactPhone";
					case 182:
						return "CashSettlAgentName";
					case 183:
						return "CashSettlAgentCode";
					case 184:
						return "CashSettlAgentAcctNum";
					case 185:
						return "CashSettlAgentAcctName";
					case 186:
						return "CashSettlAgentContactName";
					case 187:
						return "CashSettlAgentContactPhone";
					case 188:
						return "BidSpotRate";
					case 189:
						return "BidForwardPoints";
					case 190:
						return "OfferSpotRate";
					case 191:
						return "OfferForwardPoints";
					case 192:
						return "OrderQty2";
					case 193:
						return "SettlDate2";
					case 194:
						return "LastSpotRate";
					case 195:
						return "LastForwardPoints";
					case 196:
						return "AllocLinkID";
					case 197:
						return "AllocLinkType";
					case 198:
						return "SecondaryOrderID";
					case 199:
						return "NoIOIQualifiers";
					case 200:
						return "MaturityMonthYear";
					case 201:
						return "PutOrCall";
					case 202:
						return "StrikePrice";
					case 203:
						return "CoveredOrUncovered";
					case 204:
						return "CustomerOrFirm";
					case 205:
						return "MaturityDay";
					case 206:
						return "OptAttribute";
					case 207:
						return "SecurityExchange";
					case 208:
						return "NotifyBrokerOfCredit";
					case 209:
						return "AllocHandlInst";
					case 210:
						return "MaxShow";
					case 211:
						return "PegOffsetValue";
					case 212:
						return "XmlDataLen";
					case 213:
						return "XmlData";
					case 214:
						return "SettlInstRefID";
					case 215:
						return "NoRoutingIDs";
					case 216:
						return "RoutingType";
					case 217:
						return "RoutingID";
					case 218:
						return "Spread";
					case 219:
						return "Benchmark";
					case 220:
						return "BenchmarkCurveCurrency";
					case 221:
						return "BenchmarkCurveName";
					case 222:
						return "BenchmarkCurvePoint";
					case 223:
						return "CouponRate";
					case 224:
						return "CouponPaymentDate";
					case 225:
						return "IssueDate";
					case 226:
						return "RepurchaseTerm";
					case 227:
						return "RepurchaseRate";
					case 228:
						return "Factor";
					case 229:
						return "TradeOriginationDate";
					case 230:
						return "ExDate";
					case 231:
						return "ContractMultiplier";
					case 232:
						return "NoStipulations";
					case 233:
						return "StipulationType";
					case 234:
						return "StipulationValue";
					case 235:
						return "YieldType";
					case 236:
						return "Yield";
					case 237:
						return "TotalTakedown";
					case 238:
						return "Concession";
					case 239:
						return "RepoCollateralSecurityType";
					case 240:
						return "RedemptionDate";
					case 241:
						return "UnderlyingCouponPaymentDate";
					case 242:
						return "UnderlyingIssueDate";
					case 243:
						return "UnderlyingRepoCollateralSecurityType";
					case 244:
						return "UnderlyingRepurchaseTerm";
					case 245:
						return "UnderlyingRepurchaseRate";
					case 246:
						return "UnderlyingFactor";
					case 247:
						return "UnderlyingRedemptionDate";
					case 248:
						return "LegCouponPaymentDate";
					case 249:
						return "LegIssueDate";
					case 250:
						return "LegRepoCollateralSecurityType";
					case 251:
						return "LegRepurchaseTerm";
					case 252:
						return "LegRepurchaseRate";
					case 253:
						return "LegFactor";
					case 254:
						return "LegRedemptionDate";
					case 255:
						return "CreditRating";
					case 256:
						return "UnderlyingCreditRating";
					case 257:
						return "LegCreditRating";
					case 258:
						return "TradedFlatSwitch";
					case 259:
						return "BasisFeatureDate";
					case 260:
						return "BasisFeaturePrice";
					case 262:
						return "MDReqID";
					case 263:
						return "SubscriptionRequestType";
					case 264:
						return "MarketDepth";
					case 265:
						return "MDUpdateType";
					case 266:
						return "AggregatedBook";
					case 267:
						return "NoMDEntryTypes";
					case 268:
						return "NoMDEntries";
					case 269:
						return "MDEntryType";
					case 270:
						return "MDEntryPx";
					case 271:
						return "MDEntrySize";
					case 272:
						return "MDEntryDate";
					case 273:
						return "MDEntryTime";
					case 274:
						return "TickDirection";
					case 275:
						return "MDMkt";
					case 276:
						return "QuoteCondition";
					case 277:
						return "TradeCondition";
					case 278:
						return "MDEntryID";
					case 279:
						return "MDUpdateAction";
					case 280:
						return "MDEntryRefID";
					case 281:
						return "MDReqRejReason";
					case 282:
						return "MDEntryOriginator";
					case 283:
						return "LocationID";
					case 284:
						return "DeskID";
					case 285:
						return "DeleteReason";
					case 286:
						return "OpenCloseSettlFlag";
					case 287:
						return "SellerDays";
					case 288:
						return "MDEntryBuyer";
					case 289:
						return "MDEntrySeller";
					case 290:
						return "MDEntryPositionNo";
					case 291:
						return "FinancialStatus";
					case 292:
						return "CorporateAction";
					case 293:
						return "DefBidSize";
					case 294:
						return "DefOfferSize";
					case 295:
						return "NoQuoteEntries";
					case 296:
						return "NoQuoteSets";
					case 297:
						return "QuoteStatus";
					case 298:
						return "QuoteCancelType";
					case 299:
						return "QuoteEntryID";
					case 300:
						return "QuoteRejectReason";
					case 301:
						return "QuoteResponseLevel";
					case 302:
						return "QuoteSetID";
					case 303:
						return "QuoteRequestType";
					case 304:
						return "TotNoQuoteEntries";
					case 305:
						return "UnderlyingSecurityIDSource";
					case 306:
						return "UnderlyingIssuer";
					case 307:
						return "UnderlyingSecurityDesc";
					case 308:
						return "UnderlyingSecurityExchange";
					case 309:
						return "UnderlyingSecurityID";
					case 310:
						return "UnderlyingSecurityType";
					case 311:
						return "UnderlyingSymbol";
					case 312:
						return "UnderlyingSymbolSfx";
					case 313:
						return "UnderlyingMaturityMonthYear";
					case 314:
						return "UnderlyingMaturityDay";
					case 315:
						return "UnderlyingPutOrCall";
					case 316:
						return "UnderlyingStrikePrice";
					case 317:
						return "UnderlyingOptAttribute";
					case 318:
						return "UnderlyingCurrency";
					case 319:
						return "RatioQty";
					case 320:
						return "SecurityReqID";
					case 321:
						return "SecurityRequestType";
					case 322:
						return "SecurityResponseID";
					case 323:
						return "SecurityResponseType";
					case 324:
						return "SecurityStatusReqID";
					case 325:
						return "UnsolicitedIndicator";
					case 326:
						return "SecurityTradingStatus";
					case 327:
						return "HaltReason";
					case 328:
						return "InViewOfCommon";
					case 329:
						return "DueToRelated";
					case 330:
						return "BuyVolume";
					case 331:
						return "SellVolume";
					case 332:
						return "HighPx";
					case 333:
						return "LowPx";
					case 334:
						return "Adjustment";
					case 335:
						return "TradSesReqID";
					case 336:
						return "TradingSessionID";
					case 337:
						return "ContraTrader";
					case 338:
						return "TradSesMethod";
					case 339:
						return "TradSesMode";
					case 340:
						return "TradSesStatus";
					case 341:
						return "TradSesStartTime";
					case 342:
						return "TradSesOpenTime";
					case 343:
						return "TradSesPreCloseTime";
					case 344:
						return "TradSesCloseTime";
					case 345:
						return "TradSesEndTime";
					case 346:
						return "NumberOfOrders";
					case 347:
						return "MessageEncoding";
					case 348:
						return "EncodedIssuerLen";
					case 349:
						return "EncodedIssuer";
					case 350:
						return "EncodedSecurityDescLen";
					case 351:
						return "EncodedSecurityDesc";
					case 352:
						return "EncodedListExecInstLen";
					case 353:
						return "EncodedListExecInst";
					case 354:
						return "EncodedTextLen";
					case 355:
						return "EncodedText";
					case 356:
						return "EncodedSubjectLen";
					case 357:
						return "EncodedSubject";
					case 358:
						return "EncodedHeadlineLen";
					case 359:
						return "EncodedHeadline";
					case 360:
						return "EncodedAllocTextLen";
					case 361:
						return "EncodedAllocText";
					case 362:
						return "EncodedUnderlyingIssuerLen";
					case 363:
						return "EncodedUnderlyingIssuer";
					case 364:
						return "EncodedUnderlyingSecurityDescLen";
					case 365:
						return "EncodedUnderlyingSecurityDesc";
					case 366:
						return "AllocPrice";
					case 367:
						return "QuoteSetValidUntilTime";
					case 368:
						return "QuoteEntryRejectReason";
					case 369:
						return "LastMsgSeqNumProcessed";
					case 370:
						return "OnBehalfOfSendingTime";
					case 371:
						return "RefTagID";
					case 372:
						return "RefMsgType";
					case 373:
						return "SessionRejectReason";
					case 374:
						return "BidRequestTransType";
					case 375:
						return "ContraBroker";
					case 376:
						return "ComplianceID";
					case 377:
						return "SolicitedFlag";
					case 378:
						return "ExecRestatementReason";
					case 379:
						return "BusinessRejectRefID";
					case 380:
						return "BusinessRejectReason";
					case 381:
						return "GrossTradeAmt";
					case 382:
						return "NoContraBrokers";
					case 383:
						return "MaxMessageSize";
					case 384:
						return "NoMsgTypes";
					case 385:
						return "MsgDirection";
					case 386:
						return "NoTradingSessions";
					case 387:
						return "TotalVolumeTraded";
					case 388:
						return "DiscretionInst";
					case 389:
						return "DiscretionOffsetValue";
					case 390:
						return "BidID";
					case 391:
						return "ClientBidID";
					case 392:
						return "ListName";
					case 393:
						return "TotNoRelatedSym";
					case 394:
						return "BidType";
					case 395:
						return "NumTickets";
					case 396:
						return "SideValue1";
					case 397:
						return "SideValue2";
					case 398:
						return "NoBidDescriptors";
					case 399:
						return "BidDescriptorType";
					case 400:
						return "BidDescriptor";
					case 401:
						return "SideValueInd";
					case 402:
						return "LiquidityPctLow";
					case 403:
						return "LiquidityPctHigh";
					case 404:
						return "LiquidityValue";
					case 405:
						return "EFPTrackingError";
					case 406:
						return "FairValue";
					case 407:
						return "OutsideIndexPct";
					case 408:
						return "ValueOfFutures";
					case 409:
						return "LiquidityIndType";
					case 410:
						return "WtAverageLiquidity";
					case 411:
						return "ExchangeForPhysical";
					case 412:
						return "OutMainCntryUIndex";
					case 413:
						return "CrossPercent";
					case 414:
						return "ProgRptReqs";
					case 415:
						return "ProgPeriodInterval";
					case 416:
						return "IncTaxInd";
					case 417:
						return "NumBidders";
					case 418:
						return "BidTradeType";
					case 419:
						return "BasisPxType";
					case 420:
						return "NoBidComponents";
					case 421:
						return "Country";
					case 422:
						return "TotNoStrikes";
					case 423:
						return "PriceType";
					case 424:
						return "DayOrderQty";
					case 425:
						return "DayCumQty";
					case 426:
						return "DayAvgPx";
					case 427:
						return "GTBookingInst";
					case 428:
						return "NoStrikes";
					case 429:
						return "ListStatusType";
					case 430:
						return "NetGrossInd";
					case 431:
						return "ListOrderStatus";
					case 432:
						return "ExpireDate";
					case 433:
						return "ListExecInstType";
					case 434:
						return "CxlRejResponseTo";
					case 435:
						return "UnderlyingCouponRate";
					case 436:
						return "UnderlyingContractMultiplier";
					case 437:
						return "ContraTradeQty";
					case 438:
						return "ContraTradeTime";
					case 439:
						return "ClearingFirm";
					case 440:
						return "ClearingAccount";
					case 441:
						return "LiquidityNumSecurities";
					case 442:
						return "MultiLegReportingType";
					case 443:
						return "StrikeTime";
					case 444:
						return "ListStatusText";
					case 445:
						return "EncodedListStatusTextLen";
					case 446:
						return "EncodedListStatusText";
					case 447:
						return "PartyIDSource";
					case 448:
						return "PartyID";
					case 449:
						return "TotalVolumeTradedDate";
					case 450:
						return "TotalVolumeTraded_Time";
					case 451:
						return "NetChgPrevDay";
					case 452:
						return "PartyRole";
					case 453:
						return "NoPartyIDs";
					case 454:
						return "NoSecurityAltID";
					case 455:
						return "SecurityAltID";
					case 456:
						return "SecurityAltIDSource";
					case 457:
						return "NoUnderlyingSecurityAltID";
					case 458:
						return "UnderlyingSecurityAltID";
					case 459:
						return "UnderlyingSecurityAltIDSource";
					case 460:
						return "Product";
					case 461:
						return "CFICode";
					case 462:
						return "UnderlyingProduct";
					case 463:
						return "UnderlyingCFICode";
					case 464:
						return "TestMessageIndicator";
					case 465:
						return "QuantityType";
					case 466:
						return "BookingRefID";
					case 467:
						return "IndividualAllocID";
					case 468:
						return "RoundingDirection";
					case 469:
						return "RoundingModulus";
					case 470:
						return "CountryOfIssue";
					case 471:
						return "StateOrProvinceOfIssue";
					case 472:
						return "LocaleOfIssue";
					case 473:
						return "NoRegistDtls";
					case 474:
						return "MailingDtls";
					case 475:
						return "InvestorCountryOfResidence";
					case 476:
						return "PaymentRef";
					case 477:
						return "DistribPaymentMethod";
					case 478:
						return "CashDistribCurr";
					case 479:
						return "CommCurrency";
					case 480:
						return "CancellationRights";
					case 481:
						return "MoneyLaunderingStatus";
					case 482:
						return "MailingInst";
					case 483:
						return "TransBkdTime";
					case 484:
						return "ExecPriceType";
					case 485:
						return "ExecPriceAdjustment";
					case 486:
						return "DateOfBirth";
					case 487:
						return "TradeReportTransType";
					case 488:
						return "CardHolderName";
					case 489:
						return "CardNumber";
					case 490:
						return "CardExpDate";
					case 491:
						return "CardIssNum";
					case 492:
						return "PaymentMethod";
					case 493:
						return "RegistAcctType";
					case 494:
						return "Designation";
					case 495:
						return "TaxAdvantageType";
					case 496:
						return "RegistRejReasonText";
					case 497:
						return "FundRenewWaiv";
					case 498:
						return "CashDistribAgentName";
					case 499:
						return "CashDistribAgentCode";
					case 500:
						return "CashDistribAgentAcctNumber";
					case 501:
						return "CashDistribPayRef";
					case 502:
						return "CashDistribAgentAcctName";
					case 503:
						return "CardStartDate";
					case 504:
						return "PaymentDate";
					case 505:
						return "PaymentRemitterID";
					case 506:
						return "RegistStatus";
					case 507:
						return "RegistRejReasonCode";
					case 508:
						return "RegistRefID";
					case 509:
						return "RegistDtls";
					case 510:
						return "NoDistribInsts";
					case 511:
						return "RegistEmail";
					case 512:
						return "DistribPercentage";
					case 513:
						return "RegistID";
					case 514:
						return "RegistTransType";
					case 515:
						return "ExecValuationPoint";
					case 516:
						return "OrderPercent";
					case 517:
						return "OwnershipType";
					case 518:
						return "NoContAmts";
					case 519:
						return "ContAmtType";
					case 520:
						return "ContAmtValue";
					case 521:
						return "ContAmtCurr";
					case 522:
						return "OwnerType";
					case 523:
						return "PartySubID";
					case 524:
						return "NestedPartyID";
					case 525:
						return "NestedPartyIDSource";
					case 526:
						return "SecondaryClOrdID";
					case 527:
						return "SecondaryExecID";
					case 528:
						return "OrderCapacity";
					case 529:
						return "OrderRestrictions";
					case 530:
						return "MassCancelRequestType";
					case 531:
						return "MassCancelResponse";
					case 532:
						return "MassCancelRejectReason";
					case 533:
						return "TotalAffectedOrders";
					case 534:
						return "NoAffectedOrders";
					case 535:
						return "AffectedOrderID";
					case 536:
						return "AffectedSecondaryOrderID";
					case 537:
						return "QuoteType";
					case 538:
						return "NestedPartyRole";
					case 539:
						return "NoNestedPartyIDs";
					case 540:
						return "TotalAccruedInterestAmt";
					case 541:
						return "MaturityDate";
					case 542:
						return "UnderlyingMaturityDate";
					case 543:
						return "InstrRegistry";
					case 544:
						return "CashMargin";
					case 545:
						return "NestedPartySubID";
					case 546:
						return "Scope";
					case 547:
						return "MDImplicitDelete";
					case 548:
						return "CrossID";
					case 549:
						return "CrossType";
					case 550:
						return "CrossPrioritization";
					case 551:
						return "OrigCrossID";
					case 552:
						return "NoSides";
					case 553:
						return "Username";
					case 554:
						return "Password";
					case 555:
						return "NoLegs";
					case 556:
						return "LegCurrency";
					case 557:
						return "TotNoSecurityTypes";
					case 558:
						return "NoSecurityTypes";
					case 559:
						return "SecurityListRequestType";
					case 560:
						return "SecurityRequestResult";
					case 561:
						return "RoundLot";
					case 562:
						return "MinTradeVol";
					case 563:
						return "MultiLegRptTypeReq";
					case 564:
						return "LegPositionEffect";
					case 565:
						return "LegCoveredOrUncovered";
					case 566:
						return "LegPrice";
					case 567:
						return "TradSesStatusRejReason";
					case 568:
						return "TradeRequestID";
					case 569:
						return "TradeRequestType";
					case 570:
						return "PreviouslyReported";
					case 571:
						return "TradeReportID";
					case 572:
						return "TradeReportRefID";
					case 573:
						return "MatchStatus";
					case 574:
						return "MatchType";
					case 575:
						return "OddLot";
					case 576:
						return "NoClearingInstructions";
					case 577:
						return "ClearingInstruction";
					case 578:
						return "TradeInputSource";
					case 579:
						return "TradeInputDevice";
					case 580:
						return "NoDates";
					case 581:
						return "AccountType";
					case 582:
						return "CustOrderCapacity";
					case 583:
						return "ClOrdLinkID";
					case 584:
						return "MassStatusReqID";
					case 585:
						return "MassStatusReqType";
					case 586:
						return "OrigOrdModTime";
					case 587:
						return "LegSettlType";
					case 588:
						return "LegSettlDate";
					case 589:
						return "DayBookingInst";
					case 590:
						return "BookingUnit";
					case 591:
						return "PreallocMethod";
					case 592:
						return "UnderlyingCountryOfIssue";
					case 593:
						return "UnderlyingStateOrProvinceOfIssue";
					case 594:
						return "UnderlyingLocaleOfIssue";
					case 595:
						return "UnderlyingInstrRegistry";
					case 596:
						return "LegCountryOfIssue";
					case 597:
						return "LegStateOrProvinceOfIssue";
					case 598:
						return "LegLocaleOfIssue";
					case 599:
						return "LegInstrRegistry";
					case 600:
						return "LegSymbol";
					case 601:
						return "LegSymbolSfx";
					case 602:
						return "LegSecurityID";
					case 603:
						return "LegSecurityIDSource";
					case 604:
						return "NoLegSecurityAltID";
					case 605:
						return "LegSecurityAltID";
					case 606:
						return "LegSecurityAltIDSource";
					case 607:
						return "LegProduct";
					case 608:
						return "LegCFICode";
					case 609:
						return "LegSecurityType";
					case 610:
						return "LegMaturityMonthYear";
					case 611:
						return "LegMaturityDate";
					case 612:
						return "LegStrikePrice";
					case 613:
						return "LegOptAttribute";
					case 614:
						return "LegContractMultiplier";
					case 615:
						return "LegCouponRate";
					case 616:
						return "LegSecurityExchange";
					case 617:
						return "LegIssuer";
					case 618:
						return "EncodedLegIssuerLen";
					case 619:
						return "EncodedLegIssuer";
					case 620:
						return "LegSecurityDesc";
					case 621:
						return "EncodedLegSecurityDescLen";
					case 622:
						return "EncodedLegSecurityDesc";
					case 623:
						return "LegRatioQty";
					case 624:
						return "LegSide";
					case 625:
						return "TradingSessionSubID";
					case 626:
						return "AllocType";
					case 627:
						return "NoHops";
					case 628:
						return "HopCompID";
					case 629:
						return "HopSendingTime";
					case 630:
						return "HopRefID";
					case 631:
						return "MidPx";
					case 632:
						return "BidYield";
					case 633:
						return "MidYield";
					case 634:
						return "OfferYield";
					case 635:
						return "ClearingFeeIndicator";
					case 636:
						return "WorkingIndicator";
					case 637:
						return "LegLastPx";
					case 638:
						return "PriorityIndicator";
					case 639:
						return "PriceImprovement";
					case 640:
						return "Price2";
					case 641:
						return "LastForwardPoints2";
					case 642:
						return "BidForwardPoints2";
					case 643:
						return "OfferForwardPoints2";
					case 644:
						return "RFQReqID";
					case 645:
						return "MktBidPx";
					case 646:
						return "MktOfferPx";
					case 647:
						return "MinBidSize";
					case 648:
						return "MinOfferSize";
					case 649:
						return "QuoteStatusReqID";
					case 650:
						return "LegalConfirm";
					case 651:
						return "UnderlyingLastPx";
					case 652:
						return "UnderlyingLastQty";
					case 653:
						return "SecDefStatus";
					case 654:
						return "LegRefID";
					case 655:
						return "ContraLegRefID";
					case 656:
						return "SettlCurrBidFxRate";
					case 657:
						return "SettlCurrOfferFxRate";
					case 658:
						return "QuoteRequestRejectReason";
					case 659:
						return "SideComplianceID";
					case 660:
						return "AcctIDSource";
					case 661:
						return "AllocAcctIDSource";
					case 662:
						return "BenchmarkPrice";
					case 663:
						return "BenchmarkPriceType";
					case 664:
						return "ConfirmID";
					case 665:
						return "ConfirmStatus";
					case 666:
						return "ConfirmTransType";
					case 667:
						return "ContractSettlMonth";
					case 668:
						return "DeliveryForm";
					case 669:
						return "LastParPx";
					case 670:
						return "NoLegAllocs";
					case 671:
						return "LegAllocAccount";
					case 672:
						return "LegIndividualAllocID";
					case 673:
						return "LegAllocQty";
					case 674:
						return "LegAllocAcctIDSource";
					case 675:
						return "LegSettlCurrency";
					case 676:
						return "LegBenchmarkCurveCurrency";
					case 677:
						return "LegBenchmarkCurveName";
					case 678:
						return "LegBenchmarkCurvePoint";
					case 679:
						return "LegBenchmarkPrice";
					case 680:
						return "LegBenchmarkPriceType";
					case 681:
						return "LegBidPx";
					case 682:
						return "LegIOIQty";
					case 683:
						return "NoLegStipulations";
					case 684:
						return "LegOfferPx";
					case 685:
						return "LegOrderQty";
					case 686:
						return "LegPriceType";
					case 687:
						return "LegQty";
					case 688:
						return "LegStipulationType";
					case 689:
						return "LegStipulationValue";
					case 690:
						return "LegSwapType";
					case 691:
						return "Pool";
					case 692:
						return "QuotePriceType";
					case 693:
						return "QuoteRespID";
					case 694:
						return "QuoteRespType";
					case 695:
						return "QuoteQualifier";
					case 696:
						return "YieldRedemptionDate";
					case 697:
						return "YieldRedemptionPrice";
					case 698:
						return "YieldRedemptionPriceType";
					case 699:
						return "BenchmarkSecurityID";
					case 700:
						return "ReversalIndicator";
					case 701:
						return "YieldCalcDate";
					case 702:
						return "NoPositions";
					case 703:
						return "PosType";
					case 704:
						return "LongQty";
					case 705:
						return "ShortQty";
					case 706:
						return "PosQtyStatus";
					case 707:
						return "PosAmtType";
					case 708:
						return "PosAmt";
					case 709:
						return "PosTransType";
					case 710:
						return "PosReqID";
					case 711:
						return "NoUnderlyings";
					case 712:
						return "PosMaintAction";
					case 713:
						return "OrigPosReqRefID";
					case 714:
						return "PosMaintRptRefID";
					case 715:
						return "ClearingBusinessDate";
					case 716:
						return "SettlSessID";
					case 717:
						return "SettlSessSubID";
					case 718:
						return "AdjustmentType";
					case 719:
						return "ContraryInstructionIndicator";
					case 720:
						return "PriorSpreadIndicator";
					case 721:
						return "PosMaintRptID";
					case 722:
						return "PosMaintStatus";
					case 723:
						return "PosMaintResult";
					case 724:
						return "PosReqType";
					case 725:
						return "ResponseTransportType";
					case 726:
						return "ResponseDestination";
					case 727:
						return "TotalNumPosReports";
					case 728:
						return "PosReqResult";
					case 729:
						return "PosReqStatus";
					case 730:
						return "SettlPrice";
					case 731:
						return "SettlPriceType";
					case 732:
						return "UnderlyingSettlPrice";
					case 733:
						return "UnderlyingSettlPriceType";
					case 734:
						return "PriorSettlPrice";
					case 735:
						return "NoQuoteQualifiers";
					case 736:
						return "AllocSettlCurrency";
					case 737:
						return "AllocSettlCurrAmt";
					case 738:
						return "InterestAtMaturity";
					case 739:
						return "LegDatedDate";
					case 740:
						return "LegPool";
					case 741:
						return "AllocInterestAtMaturity";
					case 742:
						return "AllocAccruedInterestAmt";
					case 743:
						return "DeliveryDate";
					case 744:
						return "AssignmentMethod";
					case 745:
						return "AssignmentUnit";
					case 746:
						return "OpenInterest";
					case 747:
						return "ExerciseMethod";
					case 748:
						return "TotNumTradeReports";
					case 749:
						return "TradeRequestResult";
					case 750:
						return "TradeRequestStatus";
					case 751:
						return "TradeReportRejectReason";
					case 752:
						return "SideMultiLegReportingType";
					case 753:
						return "NoPosAmt";
					case 754:
						return "AutoAcceptIndicator";
					case 755:
						return "AllocReportID";
					case 756:
						return "NoNested2PartyIDs";
					case 757:
						return "Nested2PartyID";
					case 758:
						return "Nested2PartyIDSource";
					case 759:
						return "Nested2PartyRole";
					case 760:
						return "Nested2PartySubID";
					case 761:
						return "BenchmarkSecurityIDSource";
					case 762:
						return "SecuritySubType";
					case 763:
						return "UnderlyingSecuritySubType";
					case 764:
						return "LegSecuritySubType";
					case 765:
						return "AllowableOneSidednessPct";
					case 766:
						return "AllowableOneSidednessValue";
					case 767:
						return "AllowableOneSidednessCurr";
					case 768:
						return "NoTrdRegTimestamps";
					case 769:
						return "TrdRegTimestamp";
					case 770:
						return "TrdRegTimestampType";
					case 771:
						return "TrdRegTimestampOrigin";
					case 772:
						return "ConfirmRefID";
					case 773:
						return "ConfirmType";
					case 774:
						return "ConfirmRejReason";
					case 775:
						return "BookingType";
					case 776:
						return "IndividualAllocRejCode";
					case 777:
						return "SettlInstMsgID";
					case 778:
						return "NoSettlInst";
					case 779:
						return "LastUpdateTime";
					case 780:
						return "AllocSettlInstType";
					case 781:
						return "NoSettlPartyIDs";
					case 782:
						return "SettlPartyID";
					case 783:
						return "SettlPartyIDSource";
					case 784:
						return "SettlPartyRole";
					case 785:
						return "SettlPartySubID";
					case 786:
						return "SettlPartySubIDType";
					case 787:
						return "DlvyInstType";
					case 788:
						return "TerminationType";
					case 789:
						return "NextExpectedMsgSeqNum";
					case 790:
						return "OrdStatusReqID";
					case 791:
						return "SettlInstReqID";
					case 792:
						return "SettlInstReqRejCode";
					case 793:
						return "SecondaryAllocID";
					case 794:
						return "AllocReportType";
					case 795:
						return "AllocReportRefID";
					case 796:
						return "AllocCancReplaceReason";
					case 797:
						return "CopyMsgIndicator";
					case 798:
						return "AllocAccountType";
					case 799:
						return "OrderAvgPx";
					case 800:
						return "OrderBookingQty";
					case 801:
						return "NoSettlPartySubIDs";
					case 802:
						return "NoPartySubIDs";
					case 803:
						return "PartySubIDType";
					case 804:
						return "NoNestedPartySubIDs";
					case 805:
						return "NestedPartySubIDType";
					case 806:
						return "NoNested2PartySubIDs";
					case 807:
						return "Nested2PartySubIDType";
					case 808:
						return "AllocIntermedReqType";
					case 810:
						return "UnderlyingPx";
					case 811:
						return "PriceDelta";
					case 812:
						return "ApplQueueMax";
					case 813:
						return "ApplQueueDepth";
					case 814:
						return "ApplQueueResolution";
					case 815:
						return "ApplQueueAction";
					case 816:
						return "NoAltMDSource";
					case 817:
						return "AltMDSourceID";
					case 818:
						return "SecondaryTradeReportID";
					case 819:
						return "AvgPxIndicator";
					case 820:
						return "TradeLinkID";
					case 821:
						return "OrderInputDevice";
					case 822:
						return "UnderlyingTradingSessionID";
					case 823:
						return "UnderlyingTradingSessionSubID";
					case 824:
						return "TradeLegRefID";
					case 825:
						return "ExchangeRule";
					case 826:
						return "TradeAllocIndicator";
					case 827:
						return "ExpirationCycle";
					case 828:
						return "TrdType";
					case 829:
						return "TrdSubType";
					case 830:
						return "TransferReason";
					case 831:
						return "AsgnReqID";
					case 832:
						return "TotNumAssignmentReports";
					case 833:
						return "AsgnRptID";
					case 834:
						return "ThresholdAmount";
					case 835:
						return "PegMoveType";
					case 836:
						return "PegOffsetType";
					case 837:
						return "PegLimitType";
					case 838:
						return "PegRoundDirection";
					case 839:
						return "PeggedPrice";
					case 840:
						return "PegScope";
					case 841:
						return "DiscretionMoveType";
					case 842:
						return "DiscretionOffsetType";
					case 843:
						return "DiscretionLimitType";
					case 844:
						return "DiscretionRoundDirection";
					case 845:
						return "DiscretionPrice";
					case 846:
						return "DiscretionScope";
					case 847:
						return "TargetStrategy";
					case 848:
						return "TargetStrategyParameters";
					case 849:
						return "ParticipationRate";
					case 850:
						return "TargetStrategyPerformance";
					case 851:
						return "LastLiquidityInd";
					case 852:
						return "PublishTrdIndicator";
					case 853:
						return "ShortSaleReason";
					case 854:
						return "QtyType";
					case 855:
						return "SecondaryTrdType";
					case 856:
						return "TradeReportType";
					case 857:
						return "AllocNoOrdersType";
					case 858:
						return "SharedCommission";
					case 859:
						return "ConfirmReqID";
					case 860:
						return "AvgParPx";
					case 861:
						return "ReportedPx";
					case 862:
						return "NoCapacities";
					case 863:
						return "OrderCapacityQty";
					case 864:
						return "NoEvents";
					case 865:
						return "EventType";
					case 866:
						return "EventDate";
					case 867:
						return "EventPx";
					case 868:
						return "EventText";
					case 869:
						return "PctAtRisk";
					case 870:
						return "NoInstrAttrib";
					case 871:
						return "InstrAttribType";
					case 872:
						return "InstrAttribValue";
					case 873:
						return "DatedDate";
					case 874:
						return "InterestAccrualDate";
					case 875:
						return "CPProgram";
					case 876:
						return "CPRegType";
					case 877:
						return "UnderlyingCPProgram";
					case 878:
						return "UnderlyingCPRegType";
					case 879:
						return "UnderlyingQty";
					case 880:
						return "TrdMatchID";
					case 881:
						return "SecondaryTradeReportRefID";
					case 882:
						return "UnderlyingDirtyPrice";
					case 883:
						return "UnderlyingEndPrice";
					case 884:
						return "UnderlyingStartValue";
					case 885:
						return "UnderlyingCurrentValue";
					case 886:
						return "UnderlyingEndValue";
					case 887:
						return "NoUnderlyingStips";
					case 888:
						return "UnderlyingStipType";
					case 889:
						return "UnderlyingStipValue";
					case 890:
						return "MaturityNetMoney";
					case 891:
						return "MiscFeeBasis";
					case 892:
						return "TotNoAllocs";
					case 893:
						return "LastFragment";
					case 894:
						return "CollReqID";
					case 895:
						return "CollAsgnReason";
					case 896:
						return "CollInquiryQualifier";
					case 897:
						return "NoTrades";
					case 898:
						return "MarginRatio";
					case 899:
						return "MarginExcess";
					case 900:
						return "TotalNetValue";
					case 901:
						return "CashOutstanding";
					case 902:
						return "CollAsgnID";
					case 903:
						return "CollAsgnTransType";
					case 904:
						return "CollRespID";
					case 905:
						return "CollAsgnRespType";
					case 906:
						return "CollAsgnRejectReason";
					case 907:
						return "CollAsgnRefID";
					case 908:
						return "CollRptID";
					case 909:
						return "CollInquiryID";
					case 910:
						return "CollStatus";
					case 911:
						return "TotNumReports";
					case 912:
						return "LastRptRequested";
					case 913:
						return "AgreementDesc";
					case 914:
						return "AgreementID";
					case 915:
						return "AgreementDate";
					case 916:
						return "StartDate";
					case 917:
						return "EndDate";
					case 918:
						return "AgreementCurrency";
					case 919:
						return "DeliveryType";
					case 920:
						return "EndAccruedInterestAmt";
					case 921:
						return "StartCash";
					case 922:
						return "EndCash";
					case 923:
						return "UserRequestID";
					case 924:
						return "UserRequestType";
					case 925:
						return "NewPassword";
					case 926:
						return "UserStatus";
					case 927:
						return "UserStatusText";
					case 928:
						return "StatusValue";
					case 929:
						return "StatusText";
					case 930:
						return "RefCompID";
					case 931:
						return "RefSubID";
					case 932:
						return "NetworkResponseID";
					case 933:
						return "NetworkRequestID";
					case 934:
						return "LastNetworkResponseID";
					case 935:
						return "NetworkRequestType";
					case 936:
						return "NoCompIDs";
					case 937:
						return "NetworkStatusResponseType";
					case 938:
						return "NoCollInquiryQualifier";
					case 939:
						return "TrdRptStatus";
					case 940:
						return "AffirmStatus";
					case 941:
						return "UnderlyingStrikeCurrency";
					case 942:
						return "LegStrikeCurrency";
					case 943:
						return "TimeBracket";
					case 944:
						return "CollAction";
					case 945:
						return "CollInquiryStatus";
					case 946:
						return "CollInquiryResult";
					case 947:
						return "StrikeCurrency";
					case 948:
						return "NoNested3PartyIDs";
					case 949:
						return "Nested3PartyID";
					case 950:
						return "Nested3PartyIDSource";
					case 951:
						return "Nested3PartyRole";
					case 952:
						return "NoNested3PartySubIDs";
					case 953:
						return "Nested3PartySubID";
					case 954:
						return "Nested3PartySubIDType";
					case 955:
						return "LegContractSettlMonth";
					case 956:
						return "LegInterestAccrualDate";
					default:
						switch (tag)
						{
						case 10100:
							return "IndustryCode";
						case 10101:
							return "IndustrySector";
						case 10102:
							return "IndustryGroup";
						case 10103:
							return "IndustrySubGroup";
						default:
							switch (tag)
							{
							case 10200:
								return "CorporateActionType";
							case 10201:
								return "DeclaredDate";
							case 10202:
								return "RecordDate";
							case 10203:
								return "PayDate";
							case 10204:
								return "DividendType";
							case 10205:
								return "SplitType";
							case 10206:
								return "RightsIssueType";
							case 10207:
								return "NetAmount";
							case 10208:
								return "GrossAmount";
							case 10209:
								return "Ratio";
							case 10210:
								return "Percent";
							case 10211:
								return "AdjustmentFactor";
							}
							break;
						}
						break;
					}
				}
				else
				{
					switch (tag)
					{
					case 10300:
						return "EarningsPerShare";
					case 10301:
						return "BookValuePerShare";
					case 10302:
						return "CashPerShare";
					case 10303:
						return "RevenuePerShare";
					case 10304:
						return "DebtPerShare";
					case 10305:
						return "CashFlowPerShare";
					case 10306:
						return "InterestPaymentPerShare";
					default:
						if (tag == 10400)
						{
							return "TickSize";
						}
						if (tag == 10500)
						{
							return "OCAGroup";
						}
						break;
					}
				}
			}
			else if (tag <= 10713)
			{
				if (tag == 10600)
				{
					return "Margin";
				}
				if (tag == 10700)
				{
					return "Hidden";
				}
				switch (tag)
				{
				case 10710:
					return "FaMethod";
				case 10711:
					return "FaGroup";
				case 10712:
					return "FaProfile";
				case 10713:
					return "FaPercentage";
				}
			}
			else
			{
				switch (tag)
				{
				case 11100:
					return "Strategy";
				case 11101:
					return "StrategyComponent";
				case 11102:
					return "StrategyPrice";
				case 11103:
					return "StrategyFill";
				case 11104:
					return "StrategyMode";
				case 11105:
					return "PriceDisplay";
				default:
					switch (tag)
					{
					case 11200:
						return "ForceMarketOrder";
					case 11201:
						return "FillOnBarMode";
					default:
						if (tag == 12100)
						{
							return "SecurityAltExchange";
						}
						break;
					}
					break;
				}
			}
			return "CustomTag#" + tag;
		}

		// Token: 0x04000559 RID: 1369
		public const int Account = 1;

		// Token: 0x0400055A RID: 1370
		public const int AdvId = 2;

		// Token: 0x0400055B RID: 1371
		public const int AdvRefID = 3;

		// Token: 0x0400055C RID: 1372
		public const int AdvSide = 4;

		// Token: 0x0400055D RID: 1373
		public const int AdvTransType = 5;

		// Token: 0x0400055E RID: 1374
		public const int AvgPx = 6;

		// Token: 0x0400055F RID: 1375
		public const int BeginSeqNo = 7;

		// Token: 0x04000560 RID: 1376
		public const int BeginString = 8;

		// Token: 0x04000561 RID: 1377
		public const int BodyLength = 9;

		// Token: 0x04000562 RID: 1378
		public const int CheckSum = 10;

		// Token: 0x04000563 RID: 1379
		public const int ClOrdID = 11;

		// Token: 0x04000564 RID: 1380
		public const int Commission = 12;

		// Token: 0x04000565 RID: 1381
		public const int CommType = 13;

		// Token: 0x04000566 RID: 1382
		public const int CumQty = 14;

		// Token: 0x04000567 RID: 1383
		public const int Currency = 15;

		// Token: 0x04000568 RID: 1384
		public const int EndSeqNo = 16;

		// Token: 0x04000569 RID: 1385
		public const int ExecID = 17;

		// Token: 0x0400056A RID: 1386
		public const int ExecInst = 18;

		// Token: 0x0400056B RID: 1387
		public const int ExecRefID = 19;

		// Token: 0x0400056C RID: 1388
		public const int ExecTransType = 20;

		// Token: 0x0400056D RID: 1389
		public const int HandlInst = 21;

		// Token: 0x0400056E RID: 1390
		public const int SecurityIDSource = 22;

		// Token: 0x0400056F RID: 1391
		public const int IOIID = 23;

		// Token: 0x04000570 RID: 1392
		public const int IOIOthSvc = 24;

		// Token: 0x04000571 RID: 1393
		public const int IOIQltyInd = 25;

		// Token: 0x04000572 RID: 1394
		public const int IOIRefID = 26;

		// Token: 0x04000573 RID: 1395
		public const int IOIQty = 27;

		// Token: 0x04000574 RID: 1396
		public const int IOITransType = 28;

		// Token: 0x04000575 RID: 1397
		public const int LastCapacity = 29;

		// Token: 0x04000576 RID: 1398
		public const int LastMkt = 30;

		// Token: 0x04000577 RID: 1399
		public const int LastPx = 31;

		// Token: 0x04000578 RID: 1400
		public const int LastQty = 32;

		// Token: 0x04000579 RID: 1401
		public const int NoLinesOfText = 33;

		// Token: 0x0400057A RID: 1402
		public const int MsgSeqNum = 34;

		// Token: 0x0400057B RID: 1403
		public const int MsgType = 35;

		// Token: 0x0400057C RID: 1404
		public const int NewSeqNo = 36;

		// Token: 0x0400057D RID: 1405
		public const int OrderID = 37;

		// Token: 0x0400057E RID: 1406
		public const int OrderQty = 38;

		// Token: 0x0400057F RID: 1407
		public const int OrdStatus = 39;

		// Token: 0x04000580 RID: 1408
		public const int OrdType = 40;

		// Token: 0x04000581 RID: 1409
		public const int OrigClOrdID = 41;

		// Token: 0x04000582 RID: 1410
		public const int OrigTime = 42;

		// Token: 0x04000583 RID: 1411
		public const int PossDupFlag = 43;

		// Token: 0x04000584 RID: 1412
		public const int Price = 44;

		// Token: 0x04000585 RID: 1413
		public const int RefSeqNum = 45;

		// Token: 0x04000586 RID: 1414
		public const int RelatdSym = 46;

		// Token: 0x04000587 RID: 1415
		public const int Rule80A = 47;

		// Token: 0x04000588 RID: 1416
		public const int SecurityID = 48;

		// Token: 0x04000589 RID: 1417
		public const int SenderCompID = 49;

		// Token: 0x0400058A RID: 1418
		public const int SenderSubID = 50;

		// Token: 0x0400058B RID: 1419
		public const int SendingDate = 51;

		// Token: 0x0400058C RID: 1420
		public const int SendingTime = 52;

		// Token: 0x0400058D RID: 1421
		public const int Quantity = 53;

		// Token: 0x0400058E RID: 1422
		public const int Side = 54;

		// Token: 0x0400058F RID: 1423
		public const int Symbol = 55;

		// Token: 0x04000590 RID: 1424
		public const int TargetCompID = 56;

		// Token: 0x04000591 RID: 1425
		public const int TargetSubID = 57;

		// Token: 0x04000592 RID: 1426
		public const int Text = 58;

		// Token: 0x04000593 RID: 1427
		public const int TimeInForce = 59;

		// Token: 0x04000594 RID: 1428
		public const int TransactTime = 60;

		// Token: 0x04000595 RID: 1429
		public const int Urgency = 61;

		// Token: 0x04000596 RID: 1430
		public const int ValidUntilTime = 62;

		// Token: 0x04000597 RID: 1431
		public const int SettlType = 63;

		// Token: 0x04000598 RID: 1432
		public const int SettlDate = 64;

		// Token: 0x04000599 RID: 1433
		public const int SymbolSfx = 65;

		// Token: 0x0400059A RID: 1434
		public const int ListID = 66;

		// Token: 0x0400059B RID: 1435
		public const int ListSeqNo = 67;

		// Token: 0x0400059C RID: 1436
		public const int TotNoOrders = 68;

		// Token: 0x0400059D RID: 1437
		public const int ListExecInst = 69;

		// Token: 0x0400059E RID: 1438
		public const int AllocID = 70;

		// Token: 0x0400059F RID: 1439
		public const int AllocTransType = 71;

		// Token: 0x040005A0 RID: 1440
		public const int RefAllocID = 72;

		// Token: 0x040005A1 RID: 1441
		public const int NoOrders = 73;

		// Token: 0x040005A2 RID: 1442
		public const int AvgPxPrecision = 74;

		// Token: 0x040005A3 RID: 1443
		public const int TradeDate = 75;

		// Token: 0x040005A4 RID: 1444
		public const int ExecBroker = 76;

		// Token: 0x040005A5 RID: 1445
		public const int PositionEffect = 77;

		// Token: 0x040005A6 RID: 1446
		public const int NoAllocs = 78;

		// Token: 0x040005A7 RID: 1447
		public const int AllocAccount = 79;

		// Token: 0x040005A8 RID: 1448
		public const int AllocQty = 80;

		// Token: 0x040005A9 RID: 1449
		public const int ProcessCode = 81;

		// Token: 0x040005AA RID: 1450
		public const int NoRpts = 82;

		// Token: 0x040005AB RID: 1451
		public const int RptSeq = 83;

		// Token: 0x040005AC RID: 1452
		public const int CxlQty = 84;

		// Token: 0x040005AD RID: 1453
		public const int NoDlvyInst = 85;

		// Token: 0x040005AE RID: 1454
		public const int DlvyInst = 86;

		// Token: 0x040005AF RID: 1455
		public const int AllocStatus = 87;

		// Token: 0x040005B0 RID: 1456
		public const int AllocRejCode = 88;

		// Token: 0x040005B1 RID: 1457
		public const int Signature = 89;

		// Token: 0x040005B2 RID: 1458
		public const int SecureDataLen = 90;

		// Token: 0x040005B3 RID: 1459
		public const int SecureData = 91;

		// Token: 0x040005B4 RID: 1460
		public const int BrokerOfCredit = 92;

		// Token: 0x040005B5 RID: 1461
		public const int SignatureLength = 93;

		// Token: 0x040005B6 RID: 1462
		public const int EmailType = 94;

		// Token: 0x040005B7 RID: 1463
		public const int RawDataLength = 95;

		// Token: 0x040005B8 RID: 1464
		public const int RawData = 96;

		// Token: 0x040005B9 RID: 1465
		public const int PossResend = 97;

		// Token: 0x040005BA RID: 1466
		public const int EncryptMethod = 98;

		// Token: 0x040005BB RID: 1467
		public const int StopPx = 99;

		// Token: 0x040005BC RID: 1468
		public const int ExDestination = 100;

		// Token: 0x040005BD RID: 1469
		public const int CxlRejReason = 102;

		// Token: 0x040005BE RID: 1470
		public const int OrdRejReason = 103;

		// Token: 0x040005BF RID: 1471
		public const int IOIQualifier = 104;

		// Token: 0x040005C0 RID: 1472
		public const int WaveNo = 105;

		// Token: 0x040005C1 RID: 1473
		public const int Issuer = 106;

		// Token: 0x040005C2 RID: 1474
		public const int SecurityDesc = 107;

		// Token: 0x040005C3 RID: 1475
		public const int HeartBtInt = 108;

		// Token: 0x040005C4 RID: 1476
		public const int ClientID = 109;

		// Token: 0x040005C5 RID: 1477
		public const int MinQty = 110;

		// Token: 0x040005C6 RID: 1478
		public const int MaxFloor = 111;

		// Token: 0x040005C7 RID: 1479
		public const int TestReqID = 112;

		// Token: 0x040005C8 RID: 1480
		public const int ReportToExch = 113;

		// Token: 0x040005C9 RID: 1481
		public const int LocateReqd = 114;

		// Token: 0x040005CA RID: 1482
		public const int OnBehalfOfCompID = 115;

		// Token: 0x040005CB RID: 1483
		public const int OnBehalfOfSubID = 116;

		// Token: 0x040005CC RID: 1484
		public const int QuoteID = 117;

		// Token: 0x040005CD RID: 1485
		public const int NetMoney = 118;

		// Token: 0x040005CE RID: 1486
		public const int SettlCurrAmt = 119;

		// Token: 0x040005CF RID: 1487
		public const int SettlCurrency = 120;

		// Token: 0x040005D0 RID: 1488
		public const int ForexReq = 121;

		// Token: 0x040005D1 RID: 1489
		public const int OrigSendingTime = 122;

		// Token: 0x040005D2 RID: 1490
		public const int GapFillFlag = 123;

		// Token: 0x040005D3 RID: 1491
		public const int NoExecs = 124;

		// Token: 0x040005D4 RID: 1492
		public const int CxlType = 125;

		// Token: 0x040005D5 RID: 1493
		public const int ExpireTime = 126;

		// Token: 0x040005D6 RID: 1494
		public const int DKReason = 127;

		// Token: 0x040005D7 RID: 1495
		public const int DeliverToCompID = 128;

		// Token: 0x040005D8 RID: 1496
		public const int DeliverToSubID = 129;

		// Token: 0x040005D9 RID: 1497
		public const int IOINaturalFlag = 130;

		// Token: 0x040005DA RID: 1498
		public const int QuoteReqID = 131;

		// Token: 0x040005DB RID: 1499
		public const int BidPx = 132;

		// Token: 0x040005DC RID: 1500
		public const int OfferPx = 133;

		// Token: 0x040005DD RID: 1501
		public const int BidSize = 134;

		// Token: 0x040005DE RID: 1502
		public const int OfferSize = 135;

		// Token: 0x040005DF RID: 1503
		public const int NoMiscFees = 136;

		// Token: 0x040005E0 RID: 1504
		public const int MiscFeeAmt = 137;

		// Token: 0x040005E1 RID: 1505
		public const int MiscFeeCurr = 138;

		// Token: 0x040005E2 RID: 1506
		public const int MiscFeeType = 139;

		// Token: 0x040005E3 RID: 1507
		public const int PrevClosePx = 140;

		// Token: 0x040005E4 RID: 1508
		public const int ResetSeqNumFlag = 141;

		// Token: 0x040005E5 RID: 1509
		public const int SenderLocationID = 142;

		// Token: 0x040005E6 RID: 1510
		public const int TargetLocationID = 143;

		// Token: 0x040005E7 RID: 1511
		public const int OnBehalfOfLocationID = 144;

		// Token: 0x040005E8 RID: 1512
		public const int DeliverToLocationID = 145;

		// Token: 0x040005E9 RID: 1513
		public const int NoRelatedSym = 146;

		// Token: 0x040005EA RID: 1514
		public const int Subject = 147;

		// Token: 0x040005EB RID: 1515
		public const int Headline = 148;

		// Token: 0x040005EC RID: 1516
		public const int URLLink = 149;

		// Token: 0x040005ED RID: 1517
		public const int ExecType = 150;

		// Token: 0x040005EE RID: 1518
		public const int LeavesQty = 151;

		// Token: 0x040005EF RID: 1519
		public const int CashOrderQty = 152;

		// Token: 0x040005F0 RID: 1520
		public const int AllocAvgPx = 153;

		// Token: 0x040005F1 RID: 1521
		public const int AllocNetMoney = 154;

		// Token: 0x040005F2 RID: 1522
		public const int SettlCurrFxRate = 155;

		// Token: 0x040005F3 RID: 1523
		public const int SettlCurrFxRateCalc = 156;

		// Token: 0x040005F4 RID: 1524
		public const int NumDaysInterest = 157;

		// Token: 0x040005F5 RID: 1525
		public const int AccruedInterestRate = 158;

		// Token: 0x040005F6 RID: 1526
		public const int AccruedInterestAmt = 159;

		// Token: 0x040005F7 RID: 1527
		public const int SettlInstMode = 160;

		// Token: 0x040005F8 RID: 1528
		public const int AllocText = 161;

		// Token: 0x040005F9 RID: 1529
		public const int SettlInstID = 162;

		// Token: 0x040005FA RID: 1530
		public const int SettlInstTransType = 163;

		// Token: 0x040005FB RID: 1531
		public const int EmailThreadID = 164;

		// Token: 0x040005FC RID: 1532
		public const int SettlInstSource = 165;

		// Token: 0x040005FD RID: 1533
		public const int SettlLocation = 166;

		// Token: 0x040005FE RID: 1534
		public const int SecurityType = 167;

		// Token: 0x040005FF RID: 1535
		public const int EffectiveTime = 168;

		// Token: 0x04000600 RID: 1536
		public const int StandInstDbType = 169;

		// Token: 0x04000601 RID: 1537
		public const int StandInstDbName = 170;

		// Token: 0x04000602 RID: 1538
		public const int StandInstDbID = 171;

		// Token: 0x04000603 RID: 1539
		public const int SettlDeliveryType = 172;

		// Token: 0x04000604 RID: 1540
		public const int SettlDepositoryCode_ = 173;

		// Token: 0x04000605 RID: 1541
		public const int SettlBrkrCode_ = 174;

		// Token: 0x04000606 RID: 1542
		public const int SettlInstCode_ = 175;

		// Token: 0x04000607 RID: 1543
		public const int SecuritySettlAgentName = 176;

		// Token: 0x04000608 RID: 1544
		public const int SecuritySettlAgentCode = 177;

		// Token: 0x04000609 RID: 1545
		public const int SecuritySettlAgentAcctNum = 178;

		// Token: 0x0400060A RID: 1546
		public const int SecuritySettlAgentAcctName = 179;

		// Token: 0x0400060B RID: 1547
		public const int SecuritySettlAgentContactName = 180;

		// Token: 0x0400060C RID: 1548
		public const int SecuritySettlAgentContactPhone = 181;

		// Token: 0x0400060D RID: 1549
		public const int CashSettlAgentName = 182;

		// Token: 0x0400060E RID: 1550
		public const int CashSettlAgentCode = 183;

		// Token: 0x0400060F RID: 1551
		public const int CashSettlAgentAcctNum = 184;

		// Token: 0x04000610 RID: 1552
		public const int CashSettlAgentAcctName = 185;

		// Token: 0x04000611 RID: 1553
		public const int CashSettlAgentContactName = 186;

		// Token: 0x04000612 RID: 1554
		public const int CashSettlAgentContactPhone = 187;

		// Token: 0x04000613 RID: 1555
		public const int BidSpotRate = 188;

		// Token: 0x04000614 RID: 1556
		public const int BidForwardPoints = 189;

		// Token: 0x04000615 RID: 1557
		public const int OfferSpotRate = 190;

		// Token: 0x04000616 RID: 1558
		public const int OfferForwardPoints = 191;

		// Token: 0x04000617 RID: 1559
		public const int OrderQty2 = 192;

		// Token: 0x04000618 RID: 1560
		public const int SettlDate2 = 193;

		// Token: 0x04000619 RID: 1561
		public const int LastSpotRate = 194;

		// Token: 0x0400061A RID: 1562
		public const int LastForwardPoints = 195;

		// Token: 0x0400061B RID: 1563
		public const int AllocLinkID = 196;

		// Token: 0x0400061C RID: 1564
		public const int AllocLinkType = 197;

		// Token: 0x0400061D RID: 1565
		public const int SecondaryOrderID = 198;

		// Token: 0x0400061E RID: 1566
		public const int NoIOIQualifiers = 199;

		// Token: 0x0400061F RID: 1567
		public const int MaturityMonthYear = 200;

		// Token: 0x04000620 RID: 1568
		public const int PutOrCall = 201;

		// Token: 0x04000621 RID: 1569
		public const int StrikePrice = 202;

		// Token: 0x04000622 RID: 1570
		public const int CoveredOrUncovered = 203;

		// Token: 0x04000623 RID: 1571
		public const int CustomerOrFirm = 204;

		// Token: 0x04000624 RID: 1572
		public const int MaturityDay = 205;

		// Token: 0x04000625 RID: 1573
		public const int OptAttribute = 206;

		// Token: 0x04000626 RID: 1574
		public const int SecurityExchange = 207;

		// Token: 0x04000627 RID: 1575
		public const int NotifyBrokerOfCredit = 208;

		// Token: 0x04000628 RID: 1576
		public const int AllocHandlInst = 209;

		// Token: 0x04000629 RID: 1577
		public const int MaxShow = 210;

		// Token: 0x0400062A RID: 1578
		public const int PegOffsetValue = 211;

		// Token: 0x0400062B RID: 1579
		public const int XmlDataLen = 212;

		// Token: 0x0400062C RID: 1580
		public const int XmlData = 213;

		// Token: 0x0400062D RID: 1581
		public const int SettlInstRefID = 214;

		// Token: 0x0400062E RID: 1582
		public const int NoRoutingIDs = 215;

		// Token: 0x0400062F RID: 1583
		public const int RoutingType = 216;

		// Token: 0x04000630 RID: 1584
		public const int RoutingID = 217;

		// Token: 0x04000631 RID: 1585
		public const int Spread = 218;

		// Token: 0x04000632 RID: 1586
		public const int Benchmark = 219;

		// Token: 0x04000633 RID: 1587
		public const int BenchmarkCurveCurrency = 220;

		// Token: 0x04000634 RID: 1588
		public const int BenchmarkCurveName = 221;

		// Token: 0x04000635 RID: 1589
		public const int BenchmarkCurvePoint = 222;

		// Token: 0x04000636 RID: 1590
		public const int CouponRate = 223;

		// Token: 0x04000637 RID: 1591
		public const int CouponPaymentDate = 224;

		// Token: 0x04000638 RID: 1592
		public const int IssueDate = 225;

		// Token: 0x04000639 RID: 1593
		public const int RepurchaseTerm = 226;

		// Token: 0x0400063A RID: 1594
		public const int RepurchaseRate = 227;

		// Token: 0x0400063B RID: 1595
		public const int Factor = 228;

		// Token: 0x0400063C RID: 1596
		public const int TradeOriginationDate = 229;

		// Token: 0x0400063D RID: 1597
		public const int ExDate = 230;

		// Token: 0x0400063E RID: 1598
		public const int ContractMultiplier = 231;

		// Token: 0x0400063F RID: 1599
		public const int NoStipulations = 232;

		// Token: 0x04000640 RID: 1600
		public const int StipulationType = 233;

		// Token: 0x04000641 RID: 1601
		public const int StipulationValue = 234;

		// Token: 0x04000642 RID: 1602
		public const int YieldType = 235;

		// Token: 0x04000643 RID: 1603
		public const int Yield = 236;

		// Token: 0x04000644 RID: 1604
		public const int TotalTakedown = 237;

		// Token: 0x04000645 RID: 1605
		public const int Concession = 238;

		// Token: 0x04000646 RID: 1606
		public const int RepoCollateralSecurityType = 239;

		// Token: 0x04000647 RID: 1607
		public const int RedemptionDate = 240;

		// Token: 0x04000648 RID: 1608
		public const int UnderlyingCouponPaymentDate = 241;

		// Token: 0x04000649 RID: 1609
		public const int UnderlyingIssueDate = 242;

		// Token: 0x0400064A RID: 1610
		public const int UnderlyingRepoCollateralSecurityType = 243;

		// Token: 0x0400064B RID: 1611
		public const int UnderlyingRepurchaseTerm = 244;

		// Token: 0x0400064C RID: 1612
		public const int UnderlyingRepurchaseRate = 245;

		// Token: 0x0400064D RID: 1613
		public const int UnderlyingFactor = 246;

		// Token: 0x0400064E RID: 1614
		public const int UnderlyingRedemptionDate = 247;

		// Token: 0x0400064F RID: 1615
		public const int LegCouponPaymentDate = 248;

		// Token: 0x04000650 RID: 1616
		public const int LegIssueDate = 249;

		// Token: 0x04000651 RID: 1617
		public const int LegRepoCollateralSecurityType = 250;

		// Token: 0x04000652 RID: 1618
		public const int LegRepurchaseTerm = 251;

		// Token: 0x04000653 RID: 1619
		public const int LegRepurchaseRate = 252;

		// Token: 0x04000654 RID: 1620
		public const int LegFactor = 253;

		// Token: 0x04000655 RID: 1621
		public const int LegRedemptionDate = 254;

		// Token: 0x04000656 RID: 1622
		public const int CreditRating = 255;

		// Token: 0x04000657 RID: 1623
		public const int UnderlyingCreditRating = 256;

		// Token: 0x04000658 RID: 1624
		public const int LegCreditRating = 257;

		// Token: 0x04000659 RID: 1625
		public const int TradedFlatSwitch = 258;

		// Token: 0x0400065A RID: 1626
		public const int BasisFeatureDate = 259;

		// Token: 0x0400065B RID: 1627
		public const int BasisFeaturePrice = 260;

		// Token: 0x0400065C RID: 1628
		public const int MDReqID = 262;

		// Token: 0x0400065D RID: 1629
		public const int SubscriptionRequestType = 263;

		// Token: 0x0400065E RID: 1630
		public const int MarketDepth = 264;

		// Token: 0x0400065F RID: 1631
		public const int MDUpdateType = 265;

		// Token: 0x04000660 RID: 1632
		public const int AggregatedBook = 266;

		// Token: 0x04000661 RID: 1633
		public const int NoMDEntryTypes = 267;

		// Token: 0x04000662 RID: 1634
		public const int NoMDEntries = 268;

		// Token: 0x04000663 RID: 1635
		public const int MDEntryType = 269;

		// Token: 0x04000664 RID: 1636
		public const int MDEntryPx = 270;

		// Token: 0x04000665 RID: 1637
		public const int MDEntrySize = 271;

		// Token: 0x04000666 RID: 1638
		public const int MDEntryDate = 272;

		// Token: 0x04000667 RID: 1639
		public const int MDEntryTime = 273;

		// Token: 0x04000668 RID: 1640
		public const int TickDirection = 274;

		// Token: 0x04000669 RID: 1641
		public const int MDMkt = 275;

		// Token: 0x0400066A RID: 1642
		public const int QuoteCondition = 276;

		// Token: 0x0400066B RID: 1643
		public const int TradeCondition = 277;

		// Token: 0x0400066C RID: 1644
		public const int MDEntryID = 278;

		// Token: 0x0400066D RID: 1645
		public const int MDUpdateAction = 279;

		// Token: 0x0400066E RID: 1646
		public const int MDEntryRefID = 280;

		// Token: 0x0400066F RID: 1647
		public const int MDReqRejReason = 281;

		// Token: 0x04000670 RID: 1648
		public const int MDEntryOriginator = 282;

		// Token: 0x04000671 RID: 1649
		public const int LocationID = 283;

		// Token: 0x04000672 RID: 1650
		public const int DeskID = 284;

		// Token: 0x04000673 RID: 1651
		public const int DeleteReason = 285;

		// Token: 0x04000674 RID: 1652
		public const int OpenCloseSettlFlag = 286;

		// Token: 0x04000675 RID: 1653
		public const int SellerDays = 287;

		// Token: 0x04000676 RID: 1654
		public const int MDEntryBuyer = 288;

		// Token: 0x04000677 RID: 1655
		public const int MDEntrySeller = 289;

		// Token: 0x04000678 RID: 1656
		public const int MDEntryPositionNo = 290;

		// Token: 0x04000679 RID: 1657
		public const int FinancialStatus = 291;

		// Token: 0x0400067A RID: 1658
		public const int CorporateAction = 292;

		// Token: 0x0400067B RID: 1659
		public const int DefBidSize = 293;

		// Token: 0x0400067C RID: 1660
		public const int DefOfferSize = 294;

		// Token: 0x0400067D RID: 1661
		public const int NoQuoteEntries = 295;

		// Token: 0x0400067E RID: 1662
		public const int NoQuoteSets = 296;

		// Token: 0x0400067F RID: 1663
		public const int QuoteStatus = 297;

		// Token: 0x04000680 RID: 1664
		public const int QuoteCancelType = 298;

		// Token: 0x04000681 RID: 1665
		public const int QuoteEntryID = 299;

		// Token: 0x04000682 RID: 1666
		public const int QuoteRejectReason = 300;

		// Token: 0x04000683 RID: 1667
		public const int QuoteResponseLevel = 301;

		// Token: 0x04000684 RID: 1668
		public const int QuoteSetID = 302;

		// Token: 0x04000685 RID: 1669
		public const int QuoteRequestType = 303;

		// Token: 0x04000686 RID: 1670
		public const int TotNoQuoteEntries = 304;

		// Token: 0x04000687 RID: 1671
		public const int UnderlyingSecurityIDSource = 305;

		// Token: 0x04000688 RID: 1672
		public const int UnderlyingIssuer = 306;

		// Token: 0x04000689 RID: 1673
		public const int UnderlyingSecurityDesc = 307;

		// Token: 0x0400068A RID: 1674
		public const int UnderlyingSecurityExchange = 308;

		// Token: 0x0400068B RID: 1675
		public const int UnderlyingSecurityID = 309;

		// Token: 0x0400068C RID: 1676
		public const int UnderlyingSecurityType = 310;

		// Token: 0x0400068D RID: 1677
		public const int UnderlyingSymbol = 311;

		// Token: 0x0400068E RID: 1678
		public const int UnderlyingSymbolSfx = 312;

		// Token: 0x0400068F RID: 1679
		public const int UnderlyingMaturityMonthYear = 313;

		// Token: 0x04000690 RID: 1680
		public const int UnderlyingMaturityDay = 314;

		// Token: 0x04000691 RID: 1681
		public const int UnderlyingPutOrCall = 315;

		// Token: 0x04000692 RID: 1682
		public const int UnderlyingStrikePrice = 316;

		// Token: 0x04000693 RID: 1683
		public const int UnderlyingOptAttribute = 317;

		// Token: 0x04000694 RID: 1684
		public const int UnderlyingCurrency = 318;

		// Token: 0x04000695 RID: 1685
		public const int RatioQty = 319;

		// Token: 0x04000696 RID: 1686
		public const int SecurityReqID = 320;

		// Token: 0x04000697 RID: 1687
		public const int SecurityRequestType = 321;

		// Token: 0x04000698 RID: 1688
		public const int SecurityResponseID = 322;

		// Token: 0x04000699 RID: 1689
		public const int SecurityResponseType = 323;

		// Token: 0x0400069A RID: 1690
		public const int SecurityStatusReqID = 324;

		// Token: 0x0400069B RID: 1691
		public const int UnsolicitedIndicator = 325;

		// Token: 0x0400069C RID: 1692
		public const int SecurityTradingStatus = 326;

		// Token: 0x0400069D RID: 1693
		public const int HaltReason = 327;

		// Token: 0x0400069E RID: 1694
		public const int InViewOfCommon = 328;

		// Token: 0x0400069F RID: 1695
		public const int DueToRelated = 329;

		// Token: 0x040006A0 RID: 1696
		public const int BuyVolume = 330;

		// Token: 0x040006A1 RID: 1697
		public const int SellVolume = 331;

		// Token: 0x040006A2 RID: 1698
		public const int HighPx = 332;

		// Token: 0x040006A3 RID: 1699
		public const int LowPx = 333;

		// Token: 0x040006A4 RID: 1700
		public const int Adjustment = 334;

		// Token: 0x040006A5 RID: 1701
		public const int TradSesReqID = 335;

		// Token: 0x040006A6 RID: 1702
		public const int TradingSessionID = 336;

		// Token: 0x040006A7 RID: 1703
		public const int ContraTrader = 337;

		// Token: 0x040006A8 RID: 1704
		public const int TradSesMethod = 338;

		// Token: 0x040006A9 RID: 1705
		public const int TradSesMode = 339;

		// Token: 0x040006AA RID: 1706
		public const int TradSesStatus = 340;

		// Token: 0x040006AB RID: 1707
		public const int TradSesStartTime = 341;

		// Token: 0x040006AC RID: 1708
		public const int TradSesOpenTime = 342;

		// Token: 0x040006AD RID: 1709
		public const int TradSesPreCloseTime = 343;

		// Token: 0x040006AE RID: 1710
		public const int TradSesCloseTime = 344;

		// Token: 0x040006AF RID: 1711
		public const int TradSesEndTime = 345;

		// Token: 0x040006B0 RID: 1712
		public const int NumberOfOrders = 346;

		// Token: 0x040006B1 RID: 1713
		public const int MessageEncoding = 347;

		// Token: 0x040006B2 RID: 1714
		public const int EncodedIssuerLen = 348;

		// Token: 0x040006B3 RID: 1715
		public const int EncodedIssuer = 349;

		// Token: 0x040006B4 RID: 1716
		public const int EncodedSecurityDescLen = 350;

		// Token: 0x040006B5 RID: 1717
		public const int EncodedSecurityDesc = 351;

		// Token: 0x040006B6 RID: 1718
		public const int EncodedListExecInstLen = 352;

		// Token: 0x040006B7 RID: 1719
		public const int EncodedListExecInst = 353;

		// Token: 0x040006B8 RID: 1720
		public const int EncodedTextLen = 354;

		// Token: 0x040006B9 RID: 1721
		public const int EncodedText = 355;

		// Token: 0x040006BA RID: 1722
		public const int EncodedSubjectLen = 356;

		// Token: 0x040006BB RID: 1723
		public const int EncodedSubject = 357;

		// Token: 0x040006BC RID: 1724
		public const int EncodedHeadlineLen = 358;

		// Token: 0x040006BD RID: 1725
		public const int EncodedHeadline = 359;

		// Token: 0x040006BE RID: 1726
		public const int EncodedAllocTextLen = 360;

		// Token: 0x040006BF RID: 1727
		public const int EncodedAllocText = 361;

		// Token: 0x040006C0 RID: 1728
		public const int EncodedUnderlyingIssuerLen = 362;

		// Token: 0x040006C1 RID: 1729
		public const int EncodedUnderlyingIssuer = 363;

		// Token: 0x040006C2 RID: 1730
		public const int EncodedUnderlyingSecurityDescLen = 364;

		// Token: 0x040006C3 RID: 1731
		public const int EncodedUnderlyingSecurityDesc = 365;

		// Token: 0x040006C4 RID: 1732
		public const int AllocPrice = 366;

		// Token: 0x040006C5 RID: 1733
		public const int QuoteSetValidUntilTime = 367;

		// Token: 0x040006C6 RID: 1734
		public const int QuoteEntryRejectReason = 368;

		// Token: 0x040006C7 RID: 1735
		public const int LastMsgSeqNumProcessed = 369;

		// Token: 0x040006C8 RID: 1736
		public const int OnBehalfOfSendingTime = 370;

		// Token: 0x040006C9 RID: 1737
		public const int RefTagID = 371;

		// Token: 0x040006CA RID: 1738
		public const int RefMsgType = 372;

		// Token: 0x040006CB RID: 1739
		public const int SessionRejectReason = 373;

		// Token: 0x040006CC RID: 1740
		public const int BidRequestTransType = 374;

		// Token: 0x040006CD RID: 1741
		public const int ContraBroker = 375;

		// Token: 0x040006CE RID: 1742
		public const int ComplianceID = 376;

		// Token: 0x040006CF RID: 1743
		public const int SolicitedFlag = 377;

		// Token: 0x040006D0 RID: 1744
		public const int ExecRestatementReason = 378;

		// Token: 0x040006D1 RID: 1745
		public const int BusinessRejectRefID = 379;

		// Token: 0x040006D2 RID: 1746
		public const int BusinessRejectReason = 380;

		// Token: 0x040006D3 RID: 1747
		public const int GrossTradeAmt = 381;

		// Token: 0x040006D4 RID: 1748
		public const int NoContraBrokers = 382;

		// Token: 0x040006D5 RID: 1749
		public const int MaxMessageSize = 383;

		// Token: 0x040006D6 RID: 1750
		public const int NoMsgTypes = 384;

		// Token: 0x040006D7 RID: 1751
		public const int MsgDirection = 385;

		// Token: 0x040006D8 RID: 1752
		public const int NoTradingSessions = 386;

		// Token: 0x040006D9 RID: 1753
		public const int TotalVolumeTraded = 387;

		// Token: 0x040006DA RID: 1754
		public const int DiscretionInst = 388;

		// Token: 0x040006DB RID: 1755
		public const int DiscretionOffsetValue = 389;

		// Token: 0x040006DC RID: 1756
		public const int BidID = 390;

		// Token: 0x040006DD RID: 1757
		public const int ClientBidID = 391;

		// Token: 0x040006DE RID: 1758
		public const int ListName = 392;

		// Token: 0x040006DF RID: 1759
		public const int TotNoRelatedSym = 393;

		// Token: 0x040006E0 RID: 1760
		public const int BidType = 394;

		// Token: 0x040006E1 RID: 1761
		public const int NumTickets = 395;

		// Token: 0x040006E2 RID: 1762
		public const int SideValue1 = 396;

		// Token: 0x040006E3 RID: 1763
		public const int SideValue2 = 397;

		// Token: 0x040006E4 RID: 1764
		public const int NoBidDescriptors = 398;

		// Token: 0x040006E5 RID: 1765
		public const int BidDescriptorType = 399;

		// Token: 0x040006E6 RID: 1766
		public const int BidDescriptor = 400;

		// Token: 0x040006E7 RID: 1767
		public const int SideValueInd = 401;

		// Token: 0x040006E8 RID: 1768
		public const int LiquidityPctLow = 402;

		// Token: 0x040006E9 RID: 1769
		public const int LiquidityPctHigh = 403;

		// Token: 0x040006EA RID: 1770
		public const int LiquidityValue = 404;

		// Token: 0x040006EB RID: 1771
		public const int EFPTrackingError = 405;

		// Token: 0x040006EC RID: 1772
		public const int FairValue = 406;

		// Token: 0x040006ED RID: 1773
		public const int OutsideIndexPct = 407;

		// Token: 0x040006EE RID: 1774
		public const int ValueOfFutures = 408;

		// Token: 0x040006EF RID: 1775
		public const int LiquidityIndType = 409;

		// Token: 0x040006F0 RID: 1776
		public const int WtAverageLiquidity = 410;

		// Token: 0x040006F1 RID: 1777
		public const int ExchangeForPhysical = 411;

		// Token: 0x040006F2 RID: 1778
		public const int OutMainCntryUIndex = 412;

		// Token: 0x040006F3 RID: 1779
		public const int CrossPercent = 413;

		// Token: 0x040006F4 RID: 1780
		public const int ProgRptReqs = 414;

		// Token: 0x040006F5 RID: 1781
		public const int ProgPeriodInterval = 415;

		// Token: 0x040006F6 RID: 1782
		public const int IncTaxInd = 416;

		// Token: 0x040006F7 RID: 1783
		public const int NumBidders = 417;

		// Token: 0x040006F8 RID: 1784
		public const int BidTradeType = 418;

		// Token: 0x040006F9 RID: 1785
		public const int BasisPxType = 419;

		// Token: 0x040006FA RID: 1786
		public const int NoBidComponents = 420;

		// Token: 0x040006FB RID: 1787
		public const int Country = 421;

		// Token: 0x040006FC RID: 1788
		public const int TotNoStrikes = 422;

		// Token: 0x040006FD RID: 1789
		public const int PriceType = 423;

		// Token: 0x040006FE RID: 1790
		public const int DayOrderQty = 424;

		// Token: 0x040006FF RID: 1791
		public const int DayCumQty = 425;

		// Token: 0x04000700 RID: 1792
		public const int DayAvgPx = 426;

		// Token: 0x04000701 RID: 1793
		public const int GTBookingInst = 427;

		// Token: 0x04000702 RID: 1794
		public const int NoStrikes = 428;

		// Token: 0x04000703 RID: 1795
		public const int ListStatusType = 429;

		// Token: 0x04000704 RID: 1796
		public const int NetGrossInd = 430;

		// Token: 0x04000705 RID: 1797
		public const int ListOrderStatus = 431;

		// Token: 0x04000706 RID: 1798
		public const int ExpireDate = 432;

		// Token: 0x04000707 RID: 1799
		public const int ListExecInstType = 433;

		// Token: 0x04000708 RID: 1800
		public const int CxlRejResponseTo = 434;

		// Token: 0x04000709 RID: 1801
		public const int UnderlyingCouponRate = 435;

		// Token: 0x0400070A RID: 1802
		public const int UnderlyingContractMultiplier = 436;

		// Token: 0x0400070B RID: 1803
		public const int ContraTradeQty = 437;

		// Token: 0x0400070C RID: 1804
		public const int ContraTradeTime = 438;

		// Token: 0x0400070D RID: 1805
		public const int ClearingFirm = 439;

		// Token: 0x0400070E RID: 1806
		public const int ClearingAccount = 440;

		// Token: 0x0400070F RID: 1807
		public const int LiquidityNumSecurities = 441;

		// Token: 0x04000710 RID: 1808
		public const int MultiLegReportingType = 442;

		// Token: 0x04000711 RID: 1809
		public const int StrikeTime = 443;

		// Token: 0x04000712 RID: 1810
		public const int ListStatusText = 444;

		// Token: 0x04000713 RID: 1811
		public const int EncodedListStatusTextLen = 445;

		// Token: 0x04000714 RID: 1812
		public const int EncodedListStatusText = 446;

		// Token: 0x04000715 RID: 1813
		public const int PartyIDSource = 447;

		// Token: 0x04000716 RID: 1814
		public const int PartyID = 448;

		// Token: 0x04000717 RID: 1815
		public const int TotalVolumeTradedDate = 449;

		// Token: 0x04000718 RID: 1816
		public const int TotalVolumeTraded_Time = 450;

		// Token: 0x04000719 RID: 1817
		public const int NetChgPrevDay = 451;

		// Token: 0x0400071A RID: 1818
		public const int PartyRole = 452;

		// Token: 0x0400071B RID: 1819
		public const int NoPartyIDs = 453;

		// Token: 0x0400071C RID: 1820
		public const int NoSecurityAltID = 454;

		// Token: 0x0400071D RID: 1821
		public const int SecurityAltID = 455;

		// Token: 0x0400071E RID: 1822
		public const int SecurityAltIDSource = 456;

		// Token: 0x0400071F RID: 1823
		public const int NoUnderlyingSecurityAltID = 457;

		// Token: 0x04000720 RID: 1824
		public const int UnderlyingSecurityAltID = 458;

		// Token: 0x04000721 RID: 1825
		public const int UnderlyingSecurityAltIDSource = 459;

		// Token: 0x04000722 RID: 1826
		public const int Product = 460;

		// Token: 0x04000723 RID: 1827
		public const int CFICode = 461;

		// Token: 0x04000724 RID: 1828
		public const int UnderlyingProduct = 462;

		// Token: 0x04000725 RID: 1829
		public const int UnderlyingCFICode = 463;

		// Token: 0x04000726 RID: 1830
		public const int TestMessageIndicator = 464;

		// Token: 0x04000727 RID: 1831
		public const int QuantityType = 465;

		// Token: 0x04000728 RID: 1832
		public const int BookingRefID = 466;

		// Token: 0x04000729 RID: 1833
		public const int IndividualAllocID = 467;

		// Token: 0x0400072A RID: 1834
		public const int RoundingDirection = 468;

		// Token: 0x0400072B RID: 1835
		public const int RoundingModulus = 469;

		// Token: 0x0400072C RID: 1836
		public const int CountryOfIssue = 470;

		// Token: 0x0400072D RID: 1837
		public const int StateOrProvinceOfIssue = 471;

		// Token: 0x0400072E RID: 1838
		public const int LocaleOfIssue = 472;

		// Token: 0x0400072F RID: 1839
		public const int NoRegistDtls = 473;

		// Token: 0x04000730 RID: 1840
		public const int MailingDtls = 474;

		// Token: 0x04000731 RID: 1841
		public const int InvestorCountryOfResidence = 475;

		// Token: 0x04000732 RID: 1842
		public const int PaymentRef = 476;

		// Token: 0x04000733 RID: 1843
		public const int DistribPaymentMethod = 477;

		// Token: 0x04000734 RID: 1844
		public const int CashDistribCurr = 478;

		// Token: 0x04000735 RID: 1845
		public const int CommCurrency = 479;

		// Token: 0x04000736 RID: 1846
		public const int CancellationRights = 480;

		// Token: 0x04000737 RID: 1847
		public const int MoneyLaunderingStatus = 481;

		// Token: 0x04000738 RID: 1848
		public const int MailingInst = 482;

		// Token: 0x04000739 RID: 1849
		public const int TransBkdTime = 483;

		// Token: 0x0400073A RID: 1850
		public const int ExecPriceType = 484;

		// Token: 0x0400073B RID: 1851
		public const int ExecPriceAdjustment = 485;

		// Token: 0x0400073C RID: 1852
		public const int DateOfBirth = 486;

		// Token: 0x0400073D RID: 1853
		public const int TradeReportTransType = 487;

		// Token: 0x0400073E RID: 1854
		public const int CardHolderName = 488;

		// Token: 0x0400073F RID: 1855
		public const int CardNumber = 489;

		// Token: 0x04000740 RID: 1856
		public const int CardExpDate = 490;

		// Token: 0x04000741 RID: 1857
		public const int CardIssNum = 491;

		// Token: 0x04000742 RID: 1858
		public const int PaymentMethod = 492;

		// Token: 0x04000743 RID: 1859
		public const int RegistAcctType = 493;

		// Token: 0x04000744 RID: 1860
		public const int Designation = 494;

		// Token: 0x04000745 RID: 1861
		public const int TaxAdvantageType = 495;

		// Token: 0x04000746 RID: 1862
		public const int RegistRejReasonText = 496;

		// Token: 0x04000747 RID: 1863
		public const int FundRenewWaiv = 497;

		// Token: 0x04000748 RID: 1864
		public const int CashDistribAgentName = 498;

		// Token: 0x04000749 RID: 1865
		public const int CashDistribAgentCode = 499;

		// Token: 0x0400074A RID: 1866
		public const int CashDistribAgentAcctNumber = 500;

		// Token: 0x0400074B RID: 1867
		public const int CashDistribPayRef = 501;

		// Token: 0x0400074C RID: 1868
		public const int CashDistribAgentAcctName = 502;

		// Token: 0x0400074D RID: 1869
		public const int CardStartDate = 503;

		// Token: 0x0400074E RID: 1870
		public const int PaymentDate = 504;

		// Token: 0x0400074F RID: 1871
		public const int PaymentRemitterID = 505;

		// Token: 0x04000750 RID: 1872
		public const int RegistStatus = 506;

		// Token: 0x04000751 RID: 1873
		public const int RegistRejReasonCode = 507;

		// Token: 0x04000752 RID: 1874
		public const int RegistRefID = 508;

		// Token: 0x04000753 RID: 1875
		public const int RegistDtls = 509;

		// Token: 0x04000754 RID: 1876
		public const int NoDistribInsts = 510;

		// Token: 0x04000755 RID: 1877
		public const int RegistEmail = 511;

		// Token: 0x04000756 RID: 1878
		public const int DistribPercentage = 512;

		// Token: 0x04000757 RID: 1879
		public const int RegistID = 513;

		// Token: 0x04000758 RID: 1880
		public const int RegistTransType = 514;

		// Token: 0x04000759 RID: 1881
		public const int ExecValuationPoint = 515;

		// Token: 0x0400075A RID: 1882
		public const int OrderPercent = 516;

		// Token: 0x0400075B RID: 1883
		public const int OwnershipType = 517;

		// Token: 0x0400075C RID: 1884
		public const int NoContAmts = 518;

		// Token: 0x0400075D RID: 1885
		public const int ContAmtType = 519;

		// Token: 0x0400075E RID: 1886
		public const int ContAmtValue = 520;

		// Token: 0x0400075F RID: 1887
		public const int ContAmtCurr = 521;

		// Token: 0x04000760 RID: 1888
		public const int OwnerType = 522;

		// Token: 0x04000761 RID: 1889
		public const int PartySubID = 523;

		// Token: 0x04000762 RID: 1890
		public const int NestedPartyID = 524;

		// Token: 0x04000763 RID: 1891
		public const int NestedPartyIDSource = 525;

		// Token: 0x04000764 RID: 1892
		public const int SecondaryClOrdID = 526;

		// Token: 0x04000765 RID: 1893
		public const int SecondaryExecID = 527;

		// Token: 0x04000766 RID: 1894
		public const int OrderCapacity = 528;

		// Token: 0x04000767 RID: 1895
		public const int OrderRestrictions = 529;

		// Token: 0x04000768 RID: 1896
		public const int MassCancelRequestType = 530;

		// Token: 0x04000769 RID: 1897
		public const int MassCancelResponse = 531;

		// Token: 0x0400076A RID: 1898
		public const int MassCancelRejectReason = 532;

		// Token: 0x0400076B RID: 1899
		public const int TotalAffectedOrders = 533;

		// Token: 0x0400076C RID: 1900
		public const int NoAffectedOrders = 534;

		// Token: 0x0400076D RID: 1901
		public const int AffectedOrderID = 535;

		// Token: 0x0400076E RID: 1902
		public const int AffectedSecondaryOrderID = 536;

		// Token: 0x0400076F RID: 1903
		public const int QuoteType = 537;

		// Token: 0x04000770 RID: 1904
		public const int NestedPartyRole = 538;

		// Token: 0x04000771 RID: 1905
		public const int NoNestedPartyIDs = 539;

		// Token: 0x04000772 RID: 1906
		public const int TotalAccruedInterestAmt = 540;

		// Token: 0x04000773 RID: 1907
		public const int MaturityDate = 541;

		// Token: 0x04000774 RID: 1908
		public const int UnderlyingMaturityDate = 542;

		// Token: 0x04000775 RID: 1909
		public const int InstrRegistry = 543;

		// Token: 0x04000776 RID: 1910
		public const int CashMargin = 544;

		// Token: 0x04000777 RID: 1911
		public const int NestedPartySubID = 545;

		// Token: 0x04000778 RID: 1912
		public const int Scope = 546;

		// Token: 0x04000779 RID: 1913
		public const int MDImplicitDelete = 547;

		// Token: 0x0400077A RID: 1914
		public const int CrossID = 548;

		// Token: 0x0400077B RID: 1915
		public const int CrossType = 549;

		// Token: 0x0400077C RID: 1916
		public const int CrossPrioritization = 550;

		// Token: 0x0400077D RID: 1917
		public const int OrigCrossID = 551;

		// Token: 0x0400077E RID: 1918
		public const int NoSides = 552;

		// Token: 0x0400077F RID: 1919
		public const int Username = 553;

		// Token: 0x04000780 RID: 1920
		public const int Password = 554;

		// Token: 0x04000781 RID: 1921
		public const int NoLegs = 555;

		// Token: 0x04000782 RID: 1922
		public const int LegCurrency = 556;

		// Token: 0x04000783 RID: 1923
		public const int TotNoSecurityTypes = 557;

		// Token: 0x04000784 RID: 1924
		public const int NoSecurityTypes = 558;

		// Token: 0x04000785 RID: 1925
		public const int SecurityListRequestType = 559;

		// Token: 0x04000786 RID: 1926
		public const int SecurityRequestResult = 560;

		// Token: 0x04000787 RID: 1927
		public const int RoundLot = 561;

		// Token: 0x04000788 RID: 1928
		public const int MinTradeVol = 562;

		// Token: 0x04000789 RID: 1929
		public const int MultiLegRptTypeReq = 563;

		// Token: 0x0400078A RID: 1930
		public const int LegPositionEffect = 564;

		// Token: 0x0400078B RID: 1931
		public const int LegCoveredOrUncovered = 565;

		// Token: 0x0400078C RID: 1932
		public const int LegPrice = 566;

		// Token: 0x0400078D RID: 1933
		public const int TradSesStatusRejReason = 567;

		// Token: 0x0400078E RID: 1934
		public const int TradeRequestID = 568;

		// Token: 0x0400078F RID: 1935
		public const int TradeRequestType = 569;

		// Token: 0x04000790 RID: 1936
		public const int PreviouslyReported = 570;

		// Token: 0x04000791 RID: 1937
		public const int TradeReportID = 571;

		// Token: 0x04000792 RID: 1938
		public const int TradeReportRefID = 572;

		// Token: 0x04000793 RID: 1939
		public const int MatchStatus = 573;

		// Token: 0x04000794 RID: 1940
		public const int MatchType = 574;

		// Token: 0x04000795 RID: 1941
		public const int OddLot = 575;

		// Token: 0x04000796 RID: 1942
		public const int NoClearingInstructions = 576;

		// Token: 0x04000797 RID: 1943
		public const int ClearingInstruction = 577;

		// Token: 0x04000798 RID: 1944
		public const int TradeInputSource = 578;

		// Token: 0x04000799 RID: 1945
		public const int TradeInputDevice = 579;

		// Token: 0x0400079A RID: 1946
		public const int NoDates = 580;

		// Token: 0x0400079B RID: 1947
		public const int AccountType = 581;

		// Token: 0x0400079C RID: 1948
		public const int CustOrderCapacity = 582;

		// Token: 0x0400079D RID: 1949
		public const int ClOrdLinkID = 583;

		// Token: 0x0400079E RID: 1950
		public const int MassStatusReqID = 584;

		// Token: 0x0400079F RID: 1951
		public const int MassStatusReqType = 585;

		// Token: 0x040007A0 RID: 1952
		public const int OrigOrdModTime = 586;

		// Token: 0x040007A1 RID: 1953
		public const int LegSettlType = 587;

		// Token: 0x040007A2 RID: 1954
		public const int LegSettlDate = 588;

		// Token: 0x040007A3 RID: 1955
		public const int DayBookingInst = 589;

		// Token: 0x040007A4 RID: 1956
		public const int BookingUnit = 590;

		// Token: 0x040007A5 RID: 1957
		public const int PreallocMethod = 591;

		// Token: 0x040007A6 RID: 1958
		public const int UnderlyingCountryOfIssue = 592;

		// Token: 0x040007A7 RID: 1959
		public const int UnderlyingStateOrProvinceOfIssue = 593;

		// Token: 0x040007A8 RID: 1960
		public const int UnderlyingLocaleOfIssue = 594;

		// Token: 0x040007A9 RID: 1961
		public const int UnderlyingInstrRegistry = 595;

		// Token: 0x040007AA RID: 1962
		public const int LegCountryOfIssue = 596;

		// Token: 0x040007AB RID: 1963
		public const int LegStateOrProvinceOfIssue = 597;

		// Token: 0x040007AC RID: 1964
		public const int LegLocaleOfIssue = 598;

		// Token: 0x040007AD RID: 1965
		public const int LegInstrRegistry = 599;

		// Token: 0x040007AE RID: 1966
		public const int LegSymbol = 600;

		// Token: 0x040007AF RID: 1967
		public const int LegSymbolSfx = 601;

		// Token: 0x040007B0 RID: 1968
		public const int LegSecurityID = 602;

		// Token: 0x040007B1 RID: 1969
		public const int LegSecurityIDSource = 603;

		// Token: 0x040007B2 RID: 1970
		public const int NoLegSecurityAltID = 604;

		// Token: 0x040007B3 RID: 1971
		public const int LegSecurityAltID = 605;

		// Token: 0x040007B4 RID: 1972
		public const int LegSecurityAltIDSource = 606;

		// Token: 0x040007B5 RID: 1973
		public const int LegProduct = 607;

		// Token: 0x040007B6 RID: 1974
		public const int LegCFICode = 608;

		// Token: 0x040007B7 RID: 1975
		public const int LegSecurityType = 609;

		// Token: 0x040007B8 RID: 1976
		public const int LegMaturityMonthYear = 610;

		// Token: 0x040007B9 RID: 1977
		public const int LegMaturityDate = 611;

		// Token: 0x040007BA RID: 1978
		public const int LegStrikePrice = 612;

		// Token: 0x040007BB RID: 1979
		public const int LegOptAttribute = 613;

		// Token: 0x040007BC RID: 1980
		public const int LegContractMultiplier = 614;

		// Token: 0x040007BD RID: 1981
		public const int LegCouponRate = 615;

		// Token: 0x040007BE RID: 1982
		public const int LegSecurityExchange = 616;

		// Token: 0x040007BF RID: 1983
		public const int LegIssuer = 617;

		// Token: 0x040007C0 RID: 1984
		public const int EncodedLegIssuerLen = 618;

		// Token: 0x040007C1 RID: 1985
		public const int EncodedLegIssuer = 619;

		// Token: 0x040007C2 RID: 1986
		public const int LegSecurityDesc = 620;

		// Token: 0x040007C3 RID: 1987
		public const int EncodedLegSecurityDescLen = 621;

		// Token: 0x040007C4 RID: 1988
		public const int EncodedLegSecurityDesc = 622;

		// Token: 0x040007C5 RID: 1989
		public const int LegRatioQty = 623;

		// Token: 0x040007C6 RID: 1990
		public const int LegSide = 624;

		// Token: 0x040007C7 RID: 1991
		public const int TradingSessionSubID = 625;

		// Token: 0x040007C8 RID: 1992
		public const int AllocType = 626;

		// Token: 0x040007C9 RID: 1993
		public const int NoHops = 627;

		// Token: 0x040007CA RID: 1994
		public const int HopCompID = 628;

		// Token: 0x040007CB RID: 1995
		public const int HopSendingTime = 629;

		// Token: 0x040007CC RID: 1996
		public const int HopRefID = 630;

		// Token: 0x040007CD RID: 1997
		public const int MidPx = 631;

		// Token: 0x040007CE RID: 1998
		public const int BidYield = 632;

		// Token: 0x040007CF RID: 1999
		public const int MidYield = 633;

		// Token: 0x040007D0 RID: 2000
		public const int OfferYield = 634;

		// Token: 0x040007D1 RID: 2001
		public const int ClearingFeeIndicator = 635;

		// Token: 0x040007D2 RID: 2002
		public const int WorkingIndicator = 636;

		// Token: 0x040007D3 RID: 2003
		public const int LegLastPx = 637;

		// Token: 0x040007D4 RID: 2004
		public const int PriorityIndicator = 638;

		// Token: 0x040007D5 RID: 2005
		public const int PriceImprovement = 639;

		// Token: 0x040007D6 RID: 2006
		public const int Price2 = 640;

		// Token: 0x040007D7 RID: 2007
		public const int LastForwardPoints2 = 641;

		// Token: 0x040007D8 RID: 2008
		public const int BidForwardPoints2 = 642;

		// Token: 0x040007D9 RID: 2009
		public const int OfferForwardPoints2 = 643;

		// Token: 0x040007DA RID: 2010
		public const int RFQReqID = 644;

		// Token: 0x040007DB RID: 2011
		public const int MktBidPx = 645;

		// Token: 0x040007DC RID: 2012
		public const int MktOfferPx = 646;

		// Token: 0x040007DD RID: 2013
		public const int MinBidSize = 647;

		// Token: 0x040007DE RID: 2014
		public const int MinOfferSize = 648;

		// Token: 0x040007DF RID: 2015
		public const int QuoteStatusReqID = 649;

		// Token: 0x040007E0 RID: 2016
		public const int LegalConfirm = 650;

		// Token: 0x040007E1 RID: 2017
		public const int UnderlyingLastPx = 651;

		// Token: 0x040007E2 RID: 2018
		public const int UnderlyingLastQty = 652;

		// Token: 0x040007E3 RID: 2019
		public const int SecDefStatus = 653;

		// Token: 0x040007E4 RID: 2020
		public const int LegRefID = 654;

		// Token: 0x040007E5 RID: 2021
		public const int ContraLegRefID = 655;

		// Token: 0x040007E6 RID: 2022
		public const int SettlCurrBidFxRate = 656;

		// Token: 0x040007E7 RID: 2023
		public const int SettlCurrOfferFxRate = 657;

		// Token: 0x040007E8 RID: 2024
		public const int QuoteRequestRejectReason = 658;

		// Token: 0x040007E9 RID: 2025
		public const int SideComplianceID = 659;

		// Token: 0x040007EA RID: 2026
		public const int AcctIDSource = 660;

		// Token: 0x040007EB RID: 2027
		public const int AllocAcctIDSource = 661;

		// Token: 0x040007EC RID: 2028
		public const int BenchmarkPrice = 662;

		// Token: 0x040007ED RID: 2029
		public const int BenchmarkPriceType = 663;

		// Token: 0x040007EE RID: 2030
		public const int ConfirmID = 664;

		// Token: 0x040007EF RID: 2031
		public const int ConfirmStatus = 665;

		// Token: 0x040007F0 RID: 2032
		public const int ConfirmTransType = 666;

		// Token: 0x040007F1 RID: 2033
		public const int ContractSettlMonth = 667;

		// Token: 0x040007F2 RID: 2034
		public const int DeliveryForm = 668;

		// Token: 0x040007F3 RID: 2035
		public const int LastParPx = 669;

		// Token: 0x040007F4 RID: 2036
		public const int NoLegAllocs = 670;

		// Token: 0x040007F5 RID: 2037
		public const int LegAllocAccount = 671;

		// Token: 0x040007F6 RID: 2038
		public const int LegIndividualAllocID = 672;

		// Token: 0x040007F7 RID: 2039
		public const int LegAllocQty = 673;

		// Token: 0x040007F8 RID: 2040
		public const int LegAllocAcctIDSource = 674;

		// Token: 0x040007F9 RID: 2041
		public const int LegSettlCurrency = 675;

		// Token: 0x040007FA RID: 2042
		public const int LegBenchmarkCurveCurrency = 676;

		// Token: 0x040007FB RID: 2043
		public const int LegBenchmarkCurveName = 677;

		// Token: 0x040007FC RID: 2044
		public const int LegBenchmarkCurvePoint = 678;

		// Token: 0x040007FD RID: 2045
		public const int LegBenchmarkPrice = 679;

		// Token: 0x040007FE RID: 2046
		public const int LegBenchmarkPriceType = 680;

		// Token: 0x040007FF RID: 2047
		public const int LegBidPx = 681;

		// Token: 0x04000800 RID: 2048
		public const int LegIOIQty = 682;

		// Token: 0x04000801 RID: 2049
		public const int NoLegStipulations = 683;

		// Token: 0x04000802 RID: 2050
		public const int LegOfferPx = 684;

		// Token: 0x04000803 RID: 2051
		public const int LegOrderQty = 685;

		// Token: 0x04000804 RID: 2052
		public const int LegPriceType = 686;

		// Token: 0x04000805 RID: 2053
		public const int LegQty = 687;

		// Token: 0x04000806 RID: 2054
		public const int LegStipulationType = 688;

		// Token: 0x04000807 RID: 2055
		public const int LegStipulationValue = 689;

		// Token: 0x04000808 RID: 2056
		public const int LegSwapType = 690;

		// Token: 0x04000809 RID: 2057
		public const int Pool = 691;

		// Token: 0x0400080A RID: 2058
		public const int QuotePriceType = 692;

		// Token: 0x0400080B RID: 2059
		public const int QuoteRespID = 693;

		// Token: 0x0400080C RID: 2060
		public const int QuoteRespType = 694;

		// Token: 0x0400080D RID: 2061
		public const int QuoteQualifier = 695;

		// Token: 0x0400080E RID: 2062
		public const int YieldRedemptionDate = 696;

		// Token: 0x0400080F RID: 2063
		public const int YieldRedemptionPrice = 697;

		// Token: 0x04000810 RID: 2064
		public const int YieldRedemptionPriceType = 698;

		// Token: 0x04000811 RID: 2065
		public const int BenchmarkSecurityID = 699;

		// Token: 0x04000812 RID: 2066
		public const int ReversalIndicator = 700;

		// Token: 0x04000813 RID: 2067
		public const int YieldCalcDate = 701;

		// Token: 0x04000814 RID: 2068
		public const int NoPositions = 702;

		// Token: 0x04000815 RID: 2069
		public const int PosType = 703;

		// Token: 0x04000816 RID: 2070
		public const int LongQty = 704;

		// Token: 0x04000817 RID: 2071
		public const int ShortQty = 705;

		// Token: 0x04000818 RID: 2072
		public const int PosQtyStatus = 706;

		// Token: 0x04000819 RID: 2073
		public const int PosAmtType = 707;

		// Token: 0x0400081A RID: 2074
		public const int PosAmt = 708;

		// Token: 0x0400081B RID: 2075
		public const int PosTransType = 709;

		// Token: 0x0400081C RID: 2076
		public const int PosReqID = 710;

		// Token: 0x0400081D RID: 2077
		public const int NoUnderlyings = 711;

		// Token: 0x0400081E RID: 2078
		public const int PosMaintAction = 712;

		// Token: 0x0400081F RID: 2079
		public const int OrigPosReqRefID = 713;

		// Token: 0x04000820 RID: 2080
		public const int PosMaintRptRefID = 714;

		// Token: 0x04000821 RID: 2081
		public const int ClearingBusinessDate = 715;

		// Token: 0x04000822 RID: 2082
		public const int SettlSessID = 716;

		// Token: 0x04000823 RID: 2083
		public const int SettlSessSubID = 717;

		// Token: 0x04000824 RID: 2084
		public const int AdjustmentType = 718;

		// Token: 0x04000825 RID: 2085
		public const int ContraryInstructionIndicator = 719;

		// Token: 0x04000826 RID: 2086
		public const int PriorSpreadIndicator = 720;

		// Token: 0x04000827 RID: 2087
		public const int PosMaintRptID = 721;

		// Token: 0x04000828 RID: 2088
		public const int PosMaintStatus = 722;

		// Token: 0x04000829 RID: 2089
		public const int PosMaintResult = 723;

		// Token: 0x0400082A RID: 2090
		public const int PosReqType = 724;

		// Token: 0x0400082B RID: 2091
		public const int ResponseTransportType = 725;

		// Token: 0x0400082C RID: 2092
		public const int ResponseDestination = 726;

		// Token: 0x0400082D RID: 2093
		public const int TotalNumPosReports = 727;

		// Token: 0x0400082E RID: 2094
		public const int PosReqResult = 728;

		// Token: 0x0400082F RID: 2095
		public const int PosReqStatus = 729;

		// Token: 0x04000830 RID: 2096
		public const int SettlPrice = 730;

		// Token: 0x04000831 RID: 2097
		public const int SettlPriceType = 731;

		// Token: 0x04000832 RID: 2098
		public const int UnderlyingSettlPrice = 732;

		// Token: 0x04000833 RID: 2099
		public const int UnderlyingSettlPriceType = 733;

		// Token: 0x04000834 RID: 2100
		public const int PriorSettlPrice = 734;

		// Token: 0x04000835 RID: 2101
		public const int NoQuoteQualifiers = 735;

		// Token: 0x04000836 RID: 2102
		public const int AllocSettlCurrency = 736;

		// Token: 0x04000837 RID: 2103
		public const int AllocSettlCurrAmt = 737;

		// Token: 0x04000838 RID: 2104
		public const int InterestAtMaturity = 738;

		// Token: 0x04000839 RID: 2105
		public const int LegDatedDate = 739;

		// Token: 0x0400083A RID: 2106
		public const int LegPool = 740;

		// Token: 0x0400083B RID: 2107
		public const int AllocInterestAtMaturity = 741;

		// Token: 0x0400083C RID: 2108
		public const int AllocAccruedInterestAmt = 742;

		// Token: 0x0400083D RID: 2109
		public const int DeliveryDate = 743;

		// Token: 0x0400083E RID: 2110
		public const int AssignmentMethod = 744;

		// Token: 0x0400083F RID: 2111
		public const int AssignmentUnit = 745;

		// Token: 0x04000840 RID: 2112
		public const int OpenInterest = 746;

		// Token: 0x04000841 RID: 2113
		public const int ExerciseMethod = 747;

		// Token: 0x04000842 RID: 2114
		public const int TotNumTradeReports = 748;

		// Token: 0x04000843 RID: 2115
		public const int TradeRequestResult = 749;

		// Token: 0x04000844 RID: 2116
		public const int TradeRequestStatus = 750;

		// Token: 0x04000845 RID: 2117
		public const int TradeReportRejectReason = 751;

		// Token: 0x04000846 RID: 2118
		public const int SideMultiLegReportingType = 752;

		// Token: 0x04000847 RID: 2119
		public const int NoPosAmt = 753;

		// Token: 0x04000848 RID: 2120
		public const int AutoAcceptIndicator = 754;

		// Token: 0x04000849 RID: 2121
		public const int AllocReportID = 755;

		// Token: 0x0400084A RID: 2122
		public const int NoNested2PartyIDs = 756;

		// Token: 0x0400084B RID: 2123
		public const int Nested2PartyID = 757;

		// Token: 0x0400084C RID: 2124
		public const int Nested2PartyIDSource = 758;

		// Token: 0x0400084D RID: 2125
		public const int Nested2PartyRole = 759;

		// Token: 0x0400084E RID: 2126
		public const int Nested2PartySubID = 760;

		// Token: 0x0400084F RID: 2127
		public const int BenchmarkSecurityIDSource = 761;

		// Token: 0x04000850 RID: 2128
		public const int SecuritySubType = 762;

		// Token: 0x04000851 RID: 2129
		public const int UnderlyingSecuritySubType = 763;

		// Token: 0x04000852 RID: 2130
		public const int LegSecuritySubType = 764;

		// Token: 0x04000853 RID: 2131
		public const int AllowableOneSidednessPct = 765;

		// Token: 0x04000854 RID: 2132
		public const int AllowableOneSidednessValue = 766;

		// Token: 0x04000855 RID: 2133
		public const int AllowableOneSidednessCurr = 767;

		// Token: 0x04000856 RID: 2134
		public const int NoTrdRegTimestamps = 768;

		// Token: 0x04000857 RID: 2135
		public const int TrdRegTimestamp = 769;

		// Token: 0x04000858 RID: 2136
		public const int TrdRegTimestampType = 770;

		// Token: 0x04000859 RID: 2137
		public const int TrdRegTimestampOrigin = 771;

		// Token: 0x0400085A RID: 2138
		public const int ConfirmRefID = 772;

		// Token: 0x0400085B RID: 2139
		public const int ConfirmType = 773;

		// Token: 0x0400085C RID: 2140
		public const int ConfirmRejReason = 774;

		// Token: 0x0400085D RID: 2141
		public const int BookingType = 775;

		// Token: 0x0400085E RID: 2142
		public const int IndividualAllocRejCode = 776;

		// Token: 0x0400085F RID: 2143
		public const int SettlInstMsgID = 777;

		// Token: 0x04000860 RID: 2144
		public const int NoSettlInst = 778;

		// Token: 0x04000861 RID: 2145
		public const int LastUpdateTime = 779;

		// Token: 0x04000862 RID: 2146
		public const int AllocSettlInstType = 780;

		// Token: 0x04000863 RID: 2147
		public const int NoSettlPartyIDs = 781;

		// Token: 0x04000864 RID: 2148
		public const int SettlPartyID = 782;

		// Token: 0x04000865 RID: 2149
		public const int SettlPartyIDSource = 783;

		// Token: 0x04000866 RID: 2150
		public const int SettlPartyRole = 784;

		// Token: 0x04000867 RID: 2151
		public const int SettlPartySubID = 785;

		// Token: 0x04000868 RID: 2152
		public const int SettlPartySubIDType = 786;

		// Token: 0x04000869 RID: 2153
		public const int DlvyInstType = 787;

		// Token: 0x0400086A RID: 2154
		public const int TerminationType = 788;

		// Token: 0x0400086B RID: 2155
		public const int NextExpectedMsgSeqNum = 789;

		// Token: 0x0400086C RID: 2156
		public const int OrdStatusReqID = 790;

		// Token: 0x0400086D RID: 2157
		public const int SettlInstReqID = 791;

		// Token: 0x0400086E RID: 2158
		public const int SettlInstReqRejCode = 792;

		// Token: 0x0400086F RID: 2159
		public const int SecondaryAllocID = 793;

		// Token: 0x04000870 RID: 2160
		public const int AllocReportType = 794;

		// Token: 0x04000871 RID: 2161
		public const int AllocReportRefID = 795;

		// Token: 0x04000872 RID: 2162
		public const int AllocCancReplaceReason = 796;

		// Token: 0x04000873 RID: 2163
		public const int CopyMsgIndicator = 797;

		// Token: 0x04000874 RID: 2164
		public const int AllocAccountType = 798;

		// Token: 0x04000875 RID: 2165
		public const int OrderAvgPx = 799;

		// Token: 0x04000876 RID: 2166
		public const int OrderBookingQty = 800;

		// Token: 0x04000877 RID: 2167
		public const int NoSettlPartySubIDs = 801;

		// Token: 0x04000878 RID: 2168
		public const int NoPartySubIDs = 802;

		// Token: 0x04000879 RID: 2169
		public const int PartySubIDType = 803;

		// Token: 0x0400087A RID: 2170
		public const int NoNestedPartySubIDs = 804;

		// Token: 0x0400087B RID: 2171
		public const int NestedPartySubIDType = 805;

		// Token: 0x0400087C RID: 2172
		public const int NoNested2PartySubIDs = 806;

		// Token: 0x0400087D RID: 2173
		public const int Nested2PartySubIDType = 807;

		// Token: 0x0400087E RID: 2174
		public const int AllocIntermedReqType = 808;

		// Token: 0x0400087F RID: 2175
		public const int UnderlyingPx = 810;

		// Token: 0x04000880 RID: 2176
		public const int PriceDelta = 811;

		// Token: 0x04000881 RID: 2177
		public const int ApplQueueMax = 812;

		// Token: 0x04000882 RID: 2178
		public const int ApplQueueDepth = 813;

		// Token: 0x04000883 RID: 2179
		public const int ApplQueueResolution = 814;

		// Token: 0x04000884 RID: 2180
		public const int ApplQueueAction = 815;

		// Token: 0x04000885 RID: 2181
		public const int NoAltMDSource = 816;

		// Token: 0x04000886 RID: 2182
		public const int AltMDSourceID = 817;

		// Token: 0x04000887 RID: 2183
		public const int SecondaryTradeReportID = 818;

		// Token: 0x04000888 RID: 2184
		public const int AvgPxIndicator = 819;

		// Token: 0x04000889 RID: 2185
		public const int TradeLinkID = 820;

		// Token: 0x0400088A RID: 2186
		public const int OrderInputDevice = 821;

		// Token: 0x0400088B RID: 2187
		public const int UnderlyingTradingSessionID = 822;

		// Token: 0x0400088C RID: 2188
		public const int UnderlyingTradingSessionSubID = 823;

		// Token: 0x0400088D RID: 2189
		public const int TradeLegRefID = 824;

		// Token: 0x0400088E RID: 2190
		public const int ExchangeRule = 825;

		// Token: 0x0400088F RID: 2191
		public const int TradeAllocIndicator = 826;

		// Token: 0x04000890 RID: 2192
		public const int ExpirationCycle = 827;

		// Token: 0x04000891 RID: 2193
		public const int TrdType = 828;

		// Token: 0x04000892 RID: 2194
		public const int TrdSubType = 829;

		// Token: 0x04000893 RID: 2195
		public const int TransferReason = 830;

		// Token: 0x04000894 RID: 2196
		public const int AsgnReqID = 831;

		// Token: 0x04000895 RID: 2197
		public const int TotNumAssignmentReports = 832;

		// Token: 0x04000896 RID: 2198
		public const int AsgnRptID = 833;

		// Token: 0x04000897 RID: 2199
		public const int ThresholdAmount = 834;

		// Token: 0x04000898 RID: 2200
		public const int PegMoveType = 835;

		// Token: 0x04000899 RID: 2201
		public const int PegOffsetType = 836;

		// Token: 0x0400089A RID: 2202
		public const int PegLimitType = 837;

		// Token: 0x0400089B RID: 2203
		public const int PegRoundDirection = 838;

		// Token: 0x0400089C RID: 2204
		public const int PeggedPrice = 839;

		// Token: 0x0400089D RID: 2205
		public const int PegScope = 840;

		// Token: 0x0400089E RID: 2206
		public const int DiscretionMoveType = 841;

		// Token: 0x0400089F RID: 2207
		public const int DiscretionOffsetType = 842;

		// Token: 0x040008A0 RID: 2208
		public const int DiscretionLimitType = 843;

		// Token: 0x040008A1 RID: 2209
		public const int DiscretionRoundDirection = 844;

		// Token: 0x040008A2 RID: 2210
		public const int DiscretionPrice = 845;

		// Token: 0x040008A3 RID: 2211
		public const int DiscretionScope = 846;

		// Token: 0x040008A4 RID: 2212
		public const int TargetStrategy = 847;

		// Token: 0x040008A5 RID: 2213
		public const int TargetStrategyParameters = 848;

		// Token: 0x040008A6 RID: 2214
		public const int ParticipationRate = 849;

		// Token: 0x040008A7 RID: 2215
		public const int TargetStrategyPerformance = 850;

		// Token: 0x040008A8 RID: 2216
		public const int LastLiquidityInd = 851;

		// Token: 0x040008A9 RID: 2217
		public const int PublishTrdIndicator = 852;

		// Token: 0x040008AA RID: 2218
		public const int ShortSaleReason = 853;

		// Token: 0x040008AB RID: 2219
		public const int QtyType = 854;

		// Token: 0x040008AC RID: 2220
		public const int SecondaryTrdType = 855;

		// Token: 0x040008AD RID: 2221
		public const int TradeReportType = 856;

		// Token: 0x040008AE RID: 2222
		public const int AllocNoOrdersType = 857;

		// Token: 0x040008AF RID: 2223
		public const int SharedCommission = 858;

		// Token: 0x040008B0 RID: 2224
		public const int ConfirmReqID = 859;

		// Token: 0x040008B1 RID: 2225
		public const int AvgParPx = 860;

		// Token: 0x040008B2 RID: 2226
		public const int ReportedPx = 861;

		// Token: 0x040008B3 RID: 2227
		public const int NoCapacities = 862;

		// Token: 0x040008B4 RID: 2228
		public const int OrderCapacityQty = 863;

		// Token: 0x040008B5 RID: 2229
		public const int NoEvents = 864;

		// Token: 0x040008B6 RID: 2230
		public const int EventType = 865;

		// Token: 0x040008B7 RID: 2231
		public const int EventDate = 866;

		// Token: 0x040008B8 RID: 2232
		public const int EventPx = 867;

		// Token: 0x040008B9 RID: 2233
		public const int EventText = 868;

		// Token: 0x040008BA RID: 2234
		public const int PctAtRisk = 869;

		// Token: 0x040008BB RID: 2235
		public const int NoInstrAttrib = 870;

		// Token: 0x040008BC RID: 2236
		public const int InstrAttribType = 871;

		// Token: 0x040008BD RID: 2237
		public const int InstrAttribValue = 872;

		// Token: 0x040008BE RID: 2238
		public const int DatedDate = 873;

		// Token: 0x040008BF RID: 2239
		public const int InterestAccrualDate = 874;

		// Token: 0x040008C0 RID: 2240
		public const int CPProgram = 875;

		// Token: 0x040008C1 RID: 2241
		public const int CPRegType = 876;

		// Token: 0x040008C2 RID: 2242
		public const int UnderlyingCPProgram = 877;

		// Token: 0x040008C3 RID: 2243
		public const int UnderlyingCPRegType = 878;

		// Token: 0x040008C4 RID: 2244
		public const int UnderlyingQty = 879;

		// Token: 0x040008C5 RID: 2245
		public const int TrdMatchID = 880;

		// Token: 0x040008C6 RID: 2246
		public const int SecondaryTradeReportRefID = 881;

		// Token: 0x040008C7 RID: 2247
		public const int UnderlyingDirtyPrice = 882;

		// Token: 0x040008C8 RID: 2248
		public const int UnderlyingEndPrice = 883;

		// Token: 0x040008C9 RID: 2249
		public const int UnderlyingStartValue = 884;

		// Token: 0x040008CA RID: 2250
		public const int UnderlyingCurrentValue = 885;

		// Token: 0x040008CB RID: 2251
		public const int UnderlyingEndValue = 886;

		// Token: 0x040008CC RID: 2252
		public const int NoUnderlyingStips = 887;

		// Token: 0x040008CD RID: 2253
		public const int UnderlyingStipType = 888;

		// Token: 0x040008CE RID: 2254
		public const int UnderlyingStipValue = 889;

		// Token: 0x040008CF RID: 2255
		public const int MaturityNetMoney = 890;

		// Token: 0x040008D0 RID: 2256
		public const int MiscFeeBasis = 891;

		// Token: 0x040008D1 RID: 2257
		public const int TotNoAllocs = 892;

		// Token: 0x040008D2 RID: 2258
		public const int LastFragment = 893;

		// Token: 0x040008D3 RID: 2259
		public const int CollReqID = 894;

		// Token: 0x040008D4 RID: 2260
		public const int CollAsgnReason = 895;

		// Token: 0x040008D5 RID: 2261
		public const int CollInquiryQualifier = 896;

		// Token: 0x040008D6 RID: 2262
		public const int NoTrades = 897;

		// Token: 0x040008D7 RID: 2263
		public const int MarginRatio = 898;

		// Token: 0x040008D8 RID: 2264
		public const int MarginExcess = 899;

		// Token: 0x040008D9 RID: 2265
		public const int TotalNetValue = 900;

		// Token: 0x040008DA RID: 2266
		public const int CashOutstanding = 901;

		// Token: 0x040008DB RID: 2267
		public const int CollAsgnID = 902;

		// Token: 0x040008DC RID: 2268
		public const int CollAsgnTransType = 903;

		// Token: 0x040008DD RID: 2269
		public const int CollRespID = 904;

		// Token: 0x040008DE RID: 2270
		public const int CollAsgnRespType = 905;

		// Token: 0x040008DF RID: 2271
		public const int CollAsgnRejectReason = 906;

		// Token: 0x040008E0 RID: 2272
		public const int CollAsgnRefID = 907;

		// Token: 0x040008E1 RID: 2273
		public const int CollRptID = 908;

		// Token: 0x040008E2 RID: 2274
		public const int CollInquiryID = 909;

		// Token: 0x040008E3 RID: 2275
		public const int CollStatus = 910;

		// Token: 0x040008E4 RID: 2276
		public const int TotNumReports = 911;

		// Token: 0x040008E5 RID: 2277
		public const int LastRptRequested = 912;

		// Token: 0x040008E6 RID: 2278
		public const int AgreementDesc = 913;

		// Token: 0x040008E7 RID: 2279
		public const int AgreementID = 914;

		// Token: 0x040008E8 RID: 2280
		public const int AgreementDate = 915;

		// Token: 0x040008E9 RID: 2281
		public const int StartDate = 916;

		// Token: 0x040008EA RID: 2282
		public const int EndDate = 917;

		// Token: 0x040008EB RID: 2283
		public const int AgreementCurrency = 918;

		// Token: 0x040008EC RID: 2284
		public const int DeliveryType = 919;

		// Token: 0x040008ED RID: 2285
		public const int EndAccruedInterestAmt = 920;

		// Token: 0x040008EE RID: 2286
		public const int StartCash = 921;

		// Token: 0x040008EF RID: 2287
		public const int EndCash = 922;

		// Token: 0x040008F0 RID: 2288
		public const int UserRequestID = 923;

		// Token: 0x040008F1 RID: 2289
		public const int UserRequestType = 924;

		// Token: 0x040008F2 RID: 2290
		public const int NewPassword = 925;

		// Token: 0x040008F3 RID: 2291
		public const int UserStatus = 926;

		// Token: 0x040008F4 RID: 2292
		public const int UserStatusText = 927;

		// Token: 0x040008F5 RID: 2293
		public const int StatusValue = 928;

		// Token: 0x040008F6 RID: 2294
		public const int StatusText = 929;

		// Token: 0x040008F7 RID: 2295
		public const int RefCompID = 930;

		// Token: 0x040008F8 RID: 2296
		public const int RefSubID = 931;

		// Token: 0x040008F9 RID: 2297
		public const int NetworkResponseID = 932;

		// Token: 0x040008FA RID: 2298
		public const int NetworkRequestID = 933;

		// Token: 0x040008FB RID: 2299
		public const int LastNetworkResponseID = 934;

		// Token: 0x040008FC RID: 2300
		public const int NetworkRequestType = 935;

		// Token: 0x040008FD RID: 2301
		public const int NoCompIDs = 936;

		// Token: 0x040008FE RID: 2302
		public const int NetworkStatusResponseType = 937;

		// Token: 0x040008FF RID: 2303
		public const int NoCollInquiryQualifier = 938;

		// Token: 0x04000900 RID: 2304
		public const int TrdRptStatus = 939;

		// Token: 0x04000901 RID: 2305
		public const int AffirmStatus = 940;

		// Token: 0x04000902 RID: 2306
		public const int UnderlyingStrikeCurrency = 941;

		// Token: 0x04000903 RID: 2307
		public const int LegStrikeCurrency = 942;

		// Token: 0x04000904 RID: 2308
		public const int TimeBracket = 943;

		// Token: 0x04000905 RID: 2309
		public const int CollAction = 944;

		// Token: 0x04000906 RID: 2310
		public const int CollInquiryStatus = 945;

		// Token: 0x04000907 RID: 2311
		public const int CollInquiryResult = 946;

		// Token: 0x04000908 RID: 2312
		public const int StrikeCurrency = 947;

		// Token: 0x04000909 RID: 2313
		public const int NoNested3PartyIDs = 948;

		// Token: 0x0400090A RID: 2314
		public const int Nested3PartyID = 949;

		// Token: 0x0400090B RID: 2315
		public const int Nested3PartyIDSource = 950;

		// Token: 0x0400090C RID: 2316
		public const int Nested3PartyRole = 951;

		// Token: 0x0400090D RID: 2317
		public const int NoNested3PartySubIDs = 952;

		// Token: 0x0400090E RID: 2318
		public const int Nested3PartySubID = 953;

		// Token: 0x0400090F RID: 2319
		public const int Nested3PartySubIDType = 954;

		// Token: 0x04000910 RID: 2320
		public const int LegContractSettlMonth = 955;

		// Token: 0x04000911 RID: 2321
		public const int LegInterestAccrualDate = 956;

		// Token: 0x04000912 RID: 2322
		public const int IndustryCode = 10100;

		// Token: 0x04000913 RID: 2323
		public const int IndustrySector = 10101;

		// Token: 0x04000914 RID: 2324
		public const int IndustryGroup = 10102;

		// Token: 0x04000915 RID: 2325
		public const int IndustrySubGroup = 10103;

		// Token: 0x04000916 RID: 2326
		public const int CorporateActionType = 10200;

		// Token: 0x04000917 RID: 2327
		public const int DeclaredDate = 10201;

		// Token: 0x04000918 RID: 2328
		public const int RecordDate = 10202;

		// Token: 0x04000919 RID: 2329
		public const int PayDate = 10203;

		// Token: 0x0400091A RID: 2330
		public const int DividendType = 10204;

		// Token: 0x0400091B RID: 2331
		public const int SplitType = 10205;

		// Token: 0x0400091C RID: 2332
		public const int RightsIssueType = 10206;

		// Token: 0x0400091D RID: 2333
		public const int NetAmount = 10207;

		// Token: 0x0400091E RID: 2334
		public const int GrossAmount = 10208;

		// Token: 0x0400091F RID: 2335
		public const int Ratio = 10209;

		// Token: 0x04000920 RID: 2336
		public const int Percent = 10210;

		// Token: 0x04000921 RID: 2337
		public const int AdjustmentFactor = 10211;

		// Token: 0x04000922 RID: 2338
		public const int EarningsPerShare = 10300;

		// Token: 0x04000923 RID: 2339
		public const int BookValuePerShare = 10301;

		// Token: 0x04000924 RID: 2340
		public const int CashPerShare = 10302;

		// Token: 0x04000925 RID: 2341
		public const int RevenuePerShare = 10303;

		// Token: 0x04000926 RID: 2342
		public const int DebtPerShare = 10304;

		// Token: 0x04000927 RID: 2343
		public const int CashFlowPerShare = 10305;

		// Token: 0x04000928 RID: 2344
		public const int InterestPaymentPerShare = 10306;

		// Token: 0x04000929 RID: 2345
		public const int Strategy = 11100;

		// Token: 0x0400092A RID: 2346
		public const int StrategyComponent = 11101;

		// Token: 0x0400092B RID: 2347
		public const int StrategyPrice = 11102;

		// Token: 0x0400092C RID: 2348
		public const int StrategyFill = 11103;

		// Token: 0x0400092D RID: 2349
		public const int StrategyMode = 11104;

		// Token: 0x0400092E RID: 2350
		public const int ForceMarketOrder = 11200;

		// Token: 0x0400092F RID: 2351
		public const int FillOnBarMode = 11201;

		// Token: 0x04000930 RID: 2352
		public const int TickSize = 10400;

		// Token: 0x04000931 RID: 2353
		public const int PriceDisplay = 11105;

		// Token: 0x04000932 RID: 2354
		public const int OCAGroup = 10500;

		// Token: 0x04000933 RID: 2355
		public const int SecurityAltExchange = 12100;

		// Token: 0x04000934 RID: 2356
		public const int Margin = 10600;

		// Token: 0x04000935 RID: 2357
		public const int Hidden = 10700;

		// Token: 0x04000936 RID: 2358
		public const int FaMethod = 10710;

		// Token: 0x04000937 RID: 2359
		public const int FaGroup = 10711;

		// Token: 0x04000938 RID: 2360
		public const int FaProfile = 10712;

		// Token: 0x04000939 RID: 2361
		public const int FaPercentage = 10713;

		// Token: 0x0400093A RID: 2362
		public const int ClientOrderRefID = 10800;
	}
}
