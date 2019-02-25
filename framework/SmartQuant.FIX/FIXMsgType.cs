using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200010A RID: 266
	public class FIXMsgType : FIXStringField
	{
		// Token: 0x060031B9 RID: 12729 RVA: 0x0003458D File Offset: 0x0003358D
		public FIXMsgType(string val) : base(35, val)
		{
		}

		// Token: 0x04000440 RID: 1088
		public const string HeartBeat = "0";

		// Token: 0x04000441 RID: 1089
		public const string TestRequest = "1";

		// Token: 0x04000442 RID: 1090
		public const string ResednRequest = "2";

		// Token: 0x04000443 RID: 1091
		public const string Reject = "3";

		// Token: 0x04000444 RID: 1092
		public const string SequenceReset = "4";

		// Token: 0x04000445 RID: 1093
		public const string Logout = "5";

		// Token: 0x04000446 RID: 1094
		public const string IndicationOfInterest = "6";

		// Token: 0x04000447 RID: 1095
		public const string Advertisement = "7";

		// Token: 0x04000448 RID: 1096
		public const string ExecutionReport = "8";

		// Token: 0x04000449 RID: 1097
		public const string OrderCancelReject = "9";

		// Token: 0x0400044A RID: 1098
		public const string Logon = "A";

		// Token: 0x0400044B RID: 1099
		public const string News = "B";

		// Token: 0x0400044C RID: 1100
		public const string Email = "C";

		// Token: 0x0400044D RID: 1101
		public const string OrderSingle = "D";

		// Token: 0x0400044E RID: 1102
		public const string OrderList = "E";

		// Token: 0x0400044F RID: 1103
		public const string OrderCancelRequest = "F";

		// Token: 0x04000450 RID: 1104
		public const string OrderCancelReplaceRequest = "G";

		// Token: 0x04000451 RID: 1105
		public const string OrderStatusRequest = "H";

		// Token: 0x04000452 RID: 1106
		public const string Allocation = "J";

		// Token: 0x04000453 RID: 1107
		public const string ListCancelRequest = "K";

		// Token: 0x04000454 RID: 1108
		public const string ListExecute = "L";

		// Token: 0x04000455 RID: 1109
		public const string ListStatusRequest = "M";

		// Token: 0x04000456 RID: 1110
		public const string ListStatus = "N";

		// Token: 0x04000457 RID: 1111
		public const string AllocationACK = "P";

		// Token: 0x04000458 RID: 1112
		public const string DontKnowTradeDK = "Q";

		// Token: 0x04000459 RID: 1113
		public const string QuoteRequest = "R";

		// Token: 0x0400045A RID: 1114
		public const string Quote = "S";

		// Token: 0x0400045B RID: 1115
		public const string SettlementInstructions = "T";

		// Token: 0x0400045C RID: 1116
		public const string MarketDataRequest = "V";

		// Token: 0x0400045D RID: 1117
		public const string MarketDataSnapshotFullRefresh = "W";

		// Token: 0x0400045E RID: 1118
		public const string MarketDataSnapshotIncrementalRefresh = "X";

		// Token: 0x0400045F RID: 1119
		public const string MarketDataRequestReject = "Y";

		// Token: 0x04000460 RID: 1120
		public const string QuoteCancel = "Z";

		// Token: 0x04000461 RID: 1121
		public const string QuoteStatusRequest = "a";

		// Token: 0x04000462 RID: 1122
		public const string MassQuoteAcknowledgement = "b";

		// Token: 0x04000463 RID: 1123
		public const string SecurityDefinitionRequest = "c";

		// Token: 0x04000464 RID: 1124
		public const string SecurityDefinition = "d";

		// Token: 0x04000465 RID: 1125
		public const string SecurityStatusRequest = "e";

		// Token: 0x04000466 RID: 1126
		public const string SecurityStatus = "f";

		// Token: 0x04000467 RID: 1127
		public const string TradingSessionStatusRequest = "g";

		// Token: 0x04000468 RID: 1128
		public const string TradingSessionStatus = "h";

		// Token: 0x04000469 RID: 1129
		public const string MassQuote = "i";

		// Token: 0x0400046A RID: 1130
		public const string BusinessMessageReject = "j";

		// Token: 0x0400046B RID: 1131
		public const string BidRequest = "k";

		// Token: 0x0400046C RID: 1132
		public const string BidResponse = "l";

		// Token: 0x0400046D RID: 1133
		public const string ListStrikePrice = "m";

		// Token: 0x0400046E RID: 1134
		public const string XMLMessage = "n";

		// Token: 0x0400046F RID: 1135
		public const string RegistrationInstructions = "o";

		// Token: 0x04000470 RID: 1136
		public const string RegistrationInstructionsResponse = "p";

		// Token: 0x04000471 RID: 1137
		public const string OrderMassCancelRequest = "q";

		// Token: 0x04000472 RID: 1138
		public const string OrderMassCancelReport = "r";

		// Token: 0x04000473 RID: 1139
		public const string NewOrderCross = "s";

		// Token: 0x04000474 RID: 1140
		public const string CrossOrderCancelReplaceRequest = "t";

		// Token: 0x04000475 RID: 1141
		public const string CrossOrderCancelRequest = "u";

		// Token: 0x04000476 RID: 1142
		public const string SecurityTypeRequest = "v";

		// Token: 0x04000477 RID: 1143
		public const string SecurityTypes = "w";

		// Token: 0x04000478 RID: 1144
		public const string SecurityListRequest = "x";

		// Token: 0x04000479 RID: 1145
		public const string SecurityList = "y";

		// Token: 0x0400047A RID: 1146
		public const string DerivativeSecurityListRequest = "z";

		// Token: 0x0400047B RID: 1147
		public const string DerivativeSecurityList = "AA";

		// Token: 0x0400047C RID: 1148
		public const string NewOrderMultileg = "AB";

		// Token: 0x0400047D RID: 1149
		public const string MultilegOrderCancelReplaceRequest = "AC";

		// Token: 0x0400047E RID: 1150
		public const string TradeCaptureReportRequest = "AD";

		// Token: 0x0400047F RID: 1151
		public const string TradeCaptureReport = "AE";

		// Token: 0x04000480 RID: 1152
		public const string OrderMassStatusRequest = "AF";

		// Token: 0x04000481 RID: 1153
		public const string QuoteRequestReject = "AG";

		// Token: 0x04000482 RID: 1154
		public const string RFQRequest = "AH";

		// Token: 0x04000483 RID: 1155
		public const string QuoteStatusReport = "AI";
	}
}
