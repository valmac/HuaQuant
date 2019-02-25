using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000046 RID: 70
	public class NYSEIndustryCode : FIXStringField
	{
		// Token: 0x06000F65 RID: 3941 RVA: 0x00011F27 File Offset: 0x00010F27
		public NYSEIndustryCode(string val) : base(10100, val)
		{
		}

		// Token: 0x040000D9 RID: 217
		public const string Industrials = "100";

		// Token: 0x040000DA RID: 218
		public const string Transportation = "200";

		// Token: 0x040000DB RID: 219
		public const string Utilities = "300";

		// Token: 0x040000DC RID: 220
		public const string FinanceRealEstate = "400";

		// Token: 0x040000DD RID: 221
		public const string Aerospace = "102";

		// Token: 0x040000DE RID: 222
		public const string BusinessSuppliesAndServices = "104";

		// Token: 0x040000DF RID: 223
		public const string Chemicals = "106";

		// Token: 0x040000E0 RID: 224
		public const string ComputersAndDataProcessing = "108";

		// Token: 0x040000E1 RID: 225
		public const string Construction = "110";

		// Token: 0x040000E2 RID: 226
		public const string ElectricalEquipment = "112";

		// Token: 0x040000E3 RID: 227
		public const string Electronics = "114";

		// Token: 0x040000E4 RID: 228
		public const string EnvironmentalControl = "116";

		// Token: 0x040000E5 RID: 229
		public const string FoodsBeverages = "118";

		// Token: 0x040000E6 RID: 230
		public const string HealthAndBeautyProducts = "120";

		// Token: 0x040000E7 RID: 231
		public const string HealthCareServices = "122";

		// Token: 0x040000E8 RID: 232
		public const string HouseholdGoods = "124";

		// Token: 0x040000E9 RID: 233
		public const string IndustrialMachineryAndEquipment = "126";

		// Token: 0x040000EA RID: 234
		public const string LodgingRestaurants = "128";

		// Token: 0x040000EB RID: 235
		public const string MiningRefiningFabricating = "130";

		// Token: 0x040000EC RID: 236
		public const string MotorVehicles = "132";

		// Token: 0x040000ED RID: 237
		public const string OilAndGas = "134";

		// Token: 0x040000EE RID: 238
		public const string Packaging = "136";

		// Token: 0x040000EF RID: 239
		public const string PaperProduction = "138";

		// Token: 0x040000F0 RID: 240
		public const string Pharmaceuticals = "140";

		// Token: 0x040000F1 RID: 241
		public const string Publishing = "142";

		// Token: 0x040000F2 RID: 242
		public const string RecreationServicesAndProducts = "144";

		// Token: 0x040000F3 RID: 243
		public const string RetailTrade = "146";

		// Token: 0x040000F4 RID: 244
		public const string TextilesApparel = "148";

		// Token: 0x040000F5 RID: 245
		public const string TiresRubber = "150";

		// Token: 0x040000F6 RID: 246
		public const string Tobacco = "152";

		// Token: 0x040000F7 RID: 247
		public const string WholesalersDistributors = "154";

		// Token: 0x040000F8 RID: 248
		public const string MultiIndustry = "170";

		// Token: 0x040000F9 RID: 249
		public const string Other = "180";

		// Token: 0x040000FA RID: 250
		public const string Air = "202";

		// Token: 0x040000FB RID: 251
		public const string Rail = "204";

		// Token: 0x040000FC RID: 252
		public const string Trucking = "206";

		// Token: 0x040000FD RID: 253
		public const string OtherTransportationServices = "208";

		// Token: 0x040000FE RID: 254
		public const string ElectricServices = "302";

		// Token: 0x040000FF RID: 255
		public const string GasServices = "304";

		// Token: 0x04000100 RID: 256
		public const string Telecommunications = "306";

		// Token: 0x04000101 RID: 257
		public const string WaterSupplyCompanies = "308";

		// Token: 0x04000102 RID: 258
		public const string MultiServiceCompanies = "310";

		// Token: 0x04000103 RID: 259
		public const string Banks = "402";

		// Token: 0x04000104 RID: 260
		public const string BrokerageServices = "404";

		// Token: 0x04000105 RID: 261
		public const string ClosedEndInvestmentCompanies = "406";

		// Token: 0x04000106 RID: 262
		public const string FinanceCompanies = "408";

		// Token: 0x04000107 RID: 263
		public const string Insurance = "410";

		// Token: 0x04000108 RID: 264
		public const string Trusts = "412";

		// Token: 0x04000109 RID: 265
		public const string RealEstate = "414";

		// Token: 0x0400010A RID: 266
		public const string DiversifiedFinancialServices = "416";

		// Token: 0x0400010B RID: 267
		public const string Aircraft = "102A";

		// Token: 0x0400010C RID: 268
		public const string PartsAndEquipmentExclComputers = "102B";

		// Token: 0x0400010D RID: 269
		public const string MachinesAndEquipment = "104A";

		// Token: 0x0400010E RID: 270
		public const string Supplies = "104B";

		// Token: 0x0400010F RID: 271
		public const string Services = "104C";

		// Token: 0x04000110 RID: 272
		public const string DiversifiedChemicals = "106A";

		// Token: 0x04000111 RID: 273
		public const string Specialized = "106B";

		// Token: 0x04000112 RID: 274
		public const string ComputerSystems = "108A";

		// Token: 0x04000113 RID: 275
		public const string DataProcessingSoftware = "108B";

		// Token: 0x04000114 RID: 276
		public const string PeripheralDevicesAndSupplies = "108C";

		// Token: 0x04000115 RID: 277
		public const string Residential = "110A";

		// Token: 0x04000116 RID: 278
		public const string Industrial = "110B";

		// Token: 0x04000117 RID: 279
		public const string Cement = "110C";

		// Token: 0x04000118 RID: 280
		public const string LumberWood = "110D";

		// Token: 0x04000119 RID: 281
		public const string OtherBuildingMaterialsAndProducts = "110E";

		// Token: 0x0400011A RID: 282
		public const string SemiConductorsAndOtherComponents = "114A";

		// Token: 0x0400011B RID: 283
		public const string TelecommunicationsEquipment = "114B";

		// Token: 0x0400011C RID: 284
		public const string OtherSystemsAndEquipment = "114D";

		// Token: 0x0400011D RID: 285
		public const string Beverages = "118A";

		// Token: 0x0400011E RID: 286
		public const string BrandedFoodProducts = "118B";

		// Token: 0x0400011F RID: 287
		public const string ProcessingAndProduction = "118C";

		// Token: 0x04000120 RID: 288
		public const string Wholesalers = "118D";

		// Token: 0x04000121 RID: 289
		public const string PersonalHealthProducts = "120A";

		// Token: 0x04000122 RID: 290
		public const string ToiletriesCosmeticsPerfumes = "120B";

		// Token: 0x04000123 RID: 291
		public const string EquipmentAndSupplies = "122A";

		// Token: 0x04000124 RID: 292
		public const string HealthCareFacilities = "122B";

		// Token: 0x04000125 RID: 293
		public const string Appliances = "124A";

		// Token: 0x04000126 RID: 294
		public const string FurnishingsAndFixtures = "124B";

		// Token: 0x04000127 RID: 295
		public const string HousekeepingProducts = "124C";

		// Token: 0x04000128 RID: 296
		public const string Housewares = "124D";

		// Token: 0x04000129 RID: 297
		public const string HeavyMachinery = "126A";

		// Token: 0x0400012A RID: 298
		public const string MachineTools = "126B";

		// Token: 0x0400012B RID: 299
		public const string MeasuringAndControlDevices = "126C";

		// Token: 0x0400012C RID: 300
		public const string TransmissionsAndEngines = "126D";

		// Token: 0x0400012D RID: 301
		public const string OtherIndustrialEquipment = "126E";

		// Token: 0x0400012E RID: 302
		public const string HotelsMotels = "128A";

		// Token: 0x0400012F RID: 303
		public const string Restaurants = "128B";

		// Token: 0x04000130 RID: 304
		public const string Aluminum = "130A";

		// Token: 0x04000131 RID: 305
		public const string Coal = "130B";

		// Token: 0x04000132 RID: 306
		public const string GoldSilver = "130C";

		// Token: 0x04000133 RID: 307
		public const string SteelIron = "130D";

		// Token: 0x04000134 RID: 308
		public const string OtherNonFerrousMetals = "130E";

		// Token: 0x04000135 RID: 309
		public const string AutoAndTruck = "132A";

		// Token: 0x04000136 RID: 310
		public const string PartsAndEquipment = "132B";

		// Token: 0x04000137 RID: 311
		public const string CrudeProduction = "134A";

		// Token: 0x04000138 RID: 312
		public const string ContractDrillingExploration = "134B";

		// Token: 0x04000139 RID: 313
		public const string IntegratedDomesticRefiners = "134C";

		// Token: 0x0400013A RID: 314
		public const string IntegratedInternationalRefiners = "134D";

		// Token: 0x0400013B RID: 315
		public const string NonIntegratedRefiners = "134E";

		// Token: 0x0400013C RID: 316
		public const string ServicesAndEquipment = "134F";

		// Token: 0x0400013D RID: 317
		public const string Glass = "136A";

		// Token: 0x0400013E RID: 318
		public const string Metal = "136B";

		// Token: 0x0400013F RID: 319
		public const string Paper = "136C";

		// Token: 0x04000140 RID: 320
		public const string OtherPackaging = "136D";

		// Token: 0x04000141 RID: 321
		public const string NewspaperChains = "142A";

		// Token: 0x04000142 RID: 322
		public const string Magazines = "142B";

		// Token: 0x04000143 RID: 323
		public const string Books = "142C";

		// Token: 0x04000144 RID: 324
		public const string Broadcasting = "144A";

		// Token: 0x04000145 RID: 325
		public const string GamingOperationsAndServices = "144B";

		// Token: 0x04000146 RID: 326
		public const string LeisureTimeProducts = "144C";

		// Token: 0x04000147 RID: 327
		public const string MotionPicturesEntertainmentServices = "144D";

		// Token: 0x04000148 RID: 328
		public const string OutdoorRecreationalVehiclesAndEquipment = "144E";

		// Token: 0x04000149 RID: 329
		public const string DepartmentStoreChains = "146A";

		// Token: 0x0400014A RID: 330
		public const string DiscountVarietyChains = "146B";

		// Token: 0x0400014B RID: 331
		public const string DrugStoreChains = "146C";

		// Token: 0x0400014C RID: 332
		public const string SupermarketsFoodStores = "146D";

		// Token: 0x0400014D RID: 333
		public const string HardwareFurnitureStores = "146E";

		// Token: 0x0400014E RID: 334
		public const string SpecialtyApparelShips = "146F";

		// Token: 0x0400014F RID: 335
		public const string OtherRetailOperations = "146G";

		// Token: 0x04000150 RID: 336
		public const string TextileAndMillProducts = "148A";

		// Token: 0x04000151 RID: 337
		public const string ClothingCompanies = "148B";

		// Token: 0x04000152 RID: 338
		public const string Shoes = "148C";

		// Token: 0x04000153 RID: 339
		public const string ConsumerProductsNonFood = "154A";

		// Token: 0x04000154 RID: 340
		public const string IndustrialProducts = "154B";

		// Token: 0x04000155 RID: 341
		public const string Manufacturing = "180A";

		// Token: 0x04000156 RID: 342
		public const string OtherServices = "180B";

		// Token: 0x04000157 RID: 343
		public const string PassengerAirlines = "202A";

		// Token: 0x04000158 RID: 344
		public const string FreightAirlines = "220B";

		// Token: 0x04000159 RID: 345
		public const string DistributionAndIntegratedNaturalGasCos = "304A";

		// Token: 0x0400015A RID: 346
		public const string NaturalGasTransmissionCompanies = "304B";

		// Token: 0x0400015B RID: 347
		public const string OtherGasServices = "304C";

		// Token: 0x0400015C RID: 348
		public const string Multinational = "402A";

		// Token: 0x0400015D RID: 349
		public const string Regional = "402B";

		// Token: 0x0400015E RID: 350
		public const string SavingsAndLoanAssociations = "402C";

		// Token: 0x0400015F RID: 351
		public const string BondFunds = "406A";

		// Token: 0x04000160 RID: 352
		public const string StockFunds = "406B";

		// Token: 0x04000161 RID: 353
		public const string SpecialtyFunds = "406C";

		// Token: 0x04000162 RID: 354
		public const string BrokersAgents = "410A";

		// Token: 0x04000163 RID: 355
		public const string Carriers = "410B";

		// Token: 0x04000164 RID: 356
		public const string RealEstateInvestmentTrusts = "412A";

		// Token: 0x04000165 RID: 357
		public const string OilRoyaltyTrust = "412B";

		// Token: 0x04000166 RID: 358
		public const string OtherTrusts = "412C";
	}
}
