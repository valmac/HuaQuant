using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200005B RID: 91
	public class NYSEIndustryGroup : FIXStringField
	{
		// Token: 0x0600110E RID: 4366 RVA: 0x0001366C File Offset: 0x0001266C
		public NYSEIndustryGroup(string val) : base(10102, val)
		{
		}

		// Token: 0x04000211 RID: 529
		public const string Aerospace = "102";

		// Token: 0x04000212 RID: 530
		public const string BusinessSuppliesAndServices = "104";

		// Token: 0x04000213 RID: 531
		public const string Chemicals = "106";

		// Token: 0x04000214 RID: 532
		public const string ComputersAndDataProcessing = "108";

		// Token: 0x04000215 RID: 533
		public const string Construction = "110";

		// Token: 0x04000216 RID: 534
		public const string ElectricalEquipment = "112";

		// Token: 0x04000217 RID: 535
		public const string Electronics = "114";

		// Token: 0x04000218 RID: 536
		public const string EnvironmentalControl = "116";

		// Token: 0x04000219 RID: 537
		public const string FoodsBeverages = "118";

		// Token: 0x0400021A RID: 538
		public const string HealthAndBeautyProducts = "120";

		// Token: 0x0400021B RID: 539
		public const string HealthCareServices = "122";

		// Token: 0x0400021C RID: 540
		public const string HouseholdGoods = "124";

		// Token: 0x0400021D RID: 541
		public const string IndustrialMachineryAndEquipment = "126";

		// Token: 0x0400021E RID: 542
		public const string LodgingRestaurants = "128";

		// Token: 0x0400021F RID: 543
		public const string MiningRefiningFabricating = "130";

		// Token: 0x04000220 RID: 544
		public const string MotorVehicles = "132";

		// Token: 0x04000221 RID: 545
		public const string OilAndGas = "134";

		// Token: 0x04000222 RID: 546
		public const string Packaging = "136";

		// Token: 0x04000223 RID: 547
		public const string PaperProduction = "138";

		// Token: 0x04000224 RID: 548
		public const string Pharmaceuticals = "140";

		// Token: 0x04000225 RID: 549
		public const string Publishing = "142";

		// Token: 0x04000226 RID: 550
		public const string RecreationServicesAndProducts = "144";

		// Token: 0x04000227 RID: 551
		public const string RetailTrade = "146";

		// Token: 0x04000228 RID: 552
		public const string TextilesApparel = "148";

		// Token: 0x04000229 RID: 553
		public const string TiresRubber = "150";

		// Token: 0x0400022A RID: 554
		public const string Tobacco = "152";

		// Token: 0x0400022B RID: 555
		public const string WholesalersDistributors = "154";

		// Token: 0x0400022C RID: 556
		public const string MultiIndustry = "170";

		// Token: 0x0400022D RID: 557
		public const string Other = "180";

		// Token: 0x0400022E RID: 558
		public const string Air = "202";

		// Token: 0x0400022F RID: 559
		public const string Rail = "204";

		// Token: 0x04000230 RID: 560
		public const string Trucking = "206";

		// Token: 0x04000231 RID: 561
		public const string OtherTransportationServices = "208";

		// Token: 0x04000232 RID: 562
		public const string ElectricServices = "302";

		// Token: 0x04000233 RID: 563
		public const string GasServices = "304";

		// Token: 0x04000234 RID: 564
		public const string Telecommunications = "306";

		// Token: 0x04000235 RID: 565
		public const string WaterSupplyCompanies = "308";

		// Token: 0x04000236 RID: 566
		public const string MultiServiceCompanies = "310";

		// Token: 0x04000237 RID: 567
		public const string Banks = "402";

		// Token: 0x04000238 RID: 568
		public const string BrokerageServices = "404";

		// Token: 0x04000239 RID: 569
		public const string ClosedEndInvestmentCompanies = "406";

		// Token: 0x0400023A RID: 570
		public const string FinanceCompanies = "408";

		// Token: 0x0400023B RID: 571
		public const string Insurance = "410";

		// Token: 0x0400023C RID: 572
		public const string Trusts = "412";

		// Token: 0x0400023D RID: 573
		public const string RealEstate = "414";

		// Token: 0x0400023E RID: 574
		public const string DiversifiedFinancialServices = "416";
	}
}
