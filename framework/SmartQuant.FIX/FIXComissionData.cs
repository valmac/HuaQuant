using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200008D RID: 141
	public class FIXComissionData : FIXGroup
	{
		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0001DB39 File Offset: 0x0001CB39
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x0001DB43 File Offset: 0x0001CB43
		[FIXField("12", EFieldOption.Optional)]
		public double Commission
		{
			get
			{
				return this.GetDoubleValue(12);
			}
			set
			{
				this.SetDoubleValue(12, value);
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0001DB4E File Offset: 0x0001CB4E
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x0001DB58 File Offset: 0x0001CB58
		[FIXField("13", EFieldOption.Optional)]
		public char CommType
		{
			get
			{
				return this.GetCharValue(13);
			}
			set
			{
				this.SetCharValue(13, value);
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0001DB63 File Offset: 0x0001CB63
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x0001DB70 File Offset: 0x0001CB70
		[FIXField("479", EFieldOption.Optional)]
		public string CommCurrency
		{
			get
			{
				return this.GetStringValue(479);
			}
			set
			{
				this.SetStringValue(479, value);
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0001DB7E File Offset: 0x0001CB7E
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x0001DB8B File Offset: 0x0001CB8B
		[FIXField("497", EFieldOption.Optional)]
		public char FundRenewWaiv
		{
			get
			{
				return this.GetCharValue(497);
			}
			set
			{
				this.SetCharValue(497, value);
			}
		}
	}
}
