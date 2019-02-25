using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200010B RID: 267
	public class NYSEIndustrySubGroup : FIXStringField
	{
		// Token: 0x060031BA RID: 12730 RVA: 0x00034598 File Offset: 0x00033598
		public NYSEIndustrySubGroup(string val) : base(10103, val)
		{
		}

		// Token: 0x04000484 RID: 1156
		public const string Aircraft = "102A";

		// Token: 0x04000485 RID: 1157
		public const string PartsAndEquipmentExclComputers = "102B";

		// Token: 0x04000486 RID: 1158
		public const string MachinesAndEquipment = "104A";

		// Token: 0x04000487 RID: 1159
		public const string Supplies = "104B";

		// Token: 0x04000488 RID: 1160
		public const string Services = "104C";

		// Token: 0x04000489 RID: 1161
		public const string DiversifiedChemicals = "106A";

		// Token: 0x0400048A RID: 1162
		public const string Specialized = "106B";

		// Token: 0x0400048B RID: 1163
		public const string ComputerSystems = "108A";

		// Token: 0x0400048C RID: 1164
		public const string DataProcessingSoftware = "108B";

		// Token: 0x0400048D RID: 1165
		public const string PeripheralDevicesAndSupplies = "108C";

		// Token: 0x0400048E RID: 1166
		public const string Residential = "110A";

		// Token: 0x0400048F RID: 1167
		public const string Industrial = "110B";

		// Token: 0x04000490 RID: 1168
		public const string Cement = "110C";

		// Token: 0x04000491 RID: 1169
		public const string LumberWood = "110D";

		// Token: 0x04000492 RID: 1170
		public const string OtherBuildingMaterialsAndProducts = "110E";

		// Token: 0x04000493 RID: 1171
		public const string SemiConductorsAndOtherComponents = "114A";

		// Token: 0x04000494 RID: 1172
		public const string TelecommunicationsEquipment = "114B";

		// Token: 0x04000495 RID: 1173
		public const string OtherSystemsAndEquipment = "114D";

		// Token: 0x04000496 RID: 1174
		public const string Beverages = "118A";

		// Token: 0x04000497 RID: 1175
		public const string BrandedFoodProducts = "118B";

		// Token: 0x04000498 RID: 1176
		public const string ProcessingAndProduction = "118C";

		// Token: 0x04000499 RID: 1177
		public const string Wholesalers = "118D";

		// Token: 0x0400049A RID: 1178
		public const string PersonalHealthProducts = "120A";

		// Token: 0x0400049B RID: 1179
		public const string ToiletriesCosmeticsPerfumes = "120B";

		// Token: 0x0400049C RID: 1180
		public const string EquipmentAndSupplies = "122A";

		// Token: 0x0400049D RID: 1181
		public const string HealthCareFacilities = "122B";

		// Token: 0x0400049E RID: 1182
		public const string Appliances = "124A";

		// Token: 0x0400049F RID: 1183
		public const string FurnishingsAndFixtures = "124B";

		// Token: 0x040004A0 RID: 1184
		public const string HousekeepingProducts = "124C";

		// Token: 0x040004A1 RID: 1185
		public const string Housewares = "124D";

		// Token: 0x040004A2 RID: 1186
		public const string HeavyMachinery = "126A";

		// Token: 0x040004A3 RID: 1187
		public const string MachineTools = "126B";

		// Token: 0x040004A4 RID: 1188
		public const string MeasuringAndControlDevices = "126C";

		// Token: 0x040004A5 RID: 1189
		public const string TransmissionsAndEngines = "126D";

		// Token: 0x040004A6 RID: 1190
		public const string OtherIndustrialEquipment = "126E";

		// Token: 0x040004A7 RID: 1191
		public const string HotelsMotels = "128A";

		// Token: 0x040004A8 RID: 1192
		public const string Restaurants = "128B";

		// Token: 0x040004A9 RID: 1193
		public const string Aluminum = "130A";

		// Token: 0x040004AA RID: 1194
		public const string Coal = "130B";

		// Token: 0x040004AB RID: 1195
		public const string GoldSilver = "130C";

		// Token: 0x040004AC RID: 1196
		public const string SteelIron = "130D";

		// Token: 0x040004AD RID: 1197
		public const string OtherNonFerrousMetals = "130E";

		// Token: 0x040004AE RID: 1198
		public const string AutoAndTruck = "132A";

		// Token: 0x040004AF RID: 1199
		public const string PartsAndEquipment = "132B";

		// Token: 0x040004B0 RID: 1200
		public const string CrudeProduction = "134A";

		// Token: 0x040004B1 RID: 1201
		public const string ContractDrillingExploration = "134B";

		// Token: 0x040004B2 RID: 1202
		public const string IntegratedDomesticRefiners = "134C";

		// Token: 0x040004B3 RID: 1203
		public const string IntegratedInternationalRefiners = "134D";

		// Token: 0x040004B4 RID: 1204
		public const string NonIntegratedRefiners = "134E";

		// Token: 0x040004B5 RID: 1205
		public const string ServicesAndEquipment = "134F";

		// Token: 0x040004B6 RID: 1206
		public const string Glass = "136A";

		// Token: 0x040004B7 RID: 1207
		public const string Metal = "136B";

		// Token: 0x040004B8 RID: 1208
		public const string Paper = "136C";

		// Token: 0x040004B9 RID: 1209
		public const string Other = "136D";

		// Token: 0x040004BA RID: 1210
		public const string NewspaperChains = "142A";

		// Token: 0x040004BB RID: 1211
		public const string Magazines = "142B";

		// Token: 0x040004BC RID: 1212
		public const string Books = "142C";

		// Token: 0x040004BD RID: 1213
		public const string Broadcasting = "144A";

		// Token: 0x040004BE RID: 1214
		public const string GamingOperationsAndServices = "144B";

		// Token: 0x040004BF RID: 1215
		public const string LeisureTimeProducts = "144C";

		// Token: 0x040004C0 RID: 1216
		public const string MotionPicturesEntertainmentServices = "144D";

		// Token: 0x040004C1 RID: 1217
		public const string OutdoorRecreationalVehiclesAndEquipment = "144E";

		// Token: 0x040004C2 RID: 1218
		public const string DepartmentStoreChains = "146A";

		// Token: 0x040004C3 RID: 1219
		public const string DiscountVarietyChains = "146B";

		// Token: 0x040004C4 RID: 1220
		public const string DrugStoreChains = "146C";

		// Token: 0x040004C5 RID: 1221
		public const string SupermarketsFoodStores = "146D";

		// Token: 0x040004C6 RID: 1222
		public const string HardwareFurnitureStores = "146E";

		// Token: 0x040004C7 RID: 1223
		public const string SpecialtyApparelShips = "146F";

		// Token: 0x040004C8 RID: 1224
		public const string OtherRetailOperations = "146G";

		// Token: 0x040004C9 RID: 1225
		public const string TextileAndMillProducts = "148A";

		// Token: 0x040004CA RID: 1226
		public const string ClothingCompanies = "148B";

		// Token: 0x040004CB RID: 1227
		public const string Shoes = "148C";

		// Token: 0x040004CC RID: 1228
		public const string ConsumerProductsNonFood = "154A";

		// Token: 0x040004CD RID: 1229
		public const string IndustrialProducts = "154B";

		// Token: 0x040004CE RID: 1230
		public const string Manufacturing = "180A";

		// Token: 0x040004CF RID: 1231
		public const string OtherServices = "180B";

		// Token: 0x040004D0 RID: 1232
		public const string PassengerAirlines = "202A";

		// Token: 0x040004D1 RID: 1233
		public const string FreightAirlines = "220B";

		// Token: 0x040004D2 RID: 1234
		public const string DistributionAndIntegratedNaturalGasCos = "304A";

		// Token: 0x040004D3 RID: 1235
		public const string NaturalGasTransmissionCompanies = "304B";

		// Token: 0x040004D4 RID: 1236
		public const string OtherGasServices = "304C";

		// Token: 0x040004D5 RID: 1237
		public const string Multinational = "402A";

		// Token: 0x040004D6 RID: 1238
		public const string Regional = "402B";

		// Token: 0x040004D7 RID: 1239
		public const string SavingsAndLoanAssociations = "402C";

		// Token: 0x040004D8 RID: 1240
		public const string BondFunds = "406A";

		// Token: 0x040004D9 RID: 1241
		public const string StockFunds = "406B";

		// Token: 0x040004DA RID: 1242
		public const string SpecialtyFunds = "406C";

		// Token: 0x040004DB RID: 1243
		public const string BrokersAgents = "410A";

		// Token: 0x040004DC RID: 1244
		public const string Carriers = "410B";

		// Token: 0x040004DD RID: 1245
		public const string RealEstateInvestmentTrusts = "412A";

		// Token: 0x040004DE RID: 1246
		public const string OilRoyaltyTrust = "412B";

		// Token: 0x040004DF RID: 1247
		public const string OtherTrusts = "412C";
	}
}
