using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200009D RID: 157
	public class FIXCommissionData : FIXMessage
	{
		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x00023A52 File Offset: 0x00022A52
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x00023A61 File Offset: 0x00022A61
		[FIXField("12", EFieldOption.Optional)]
		public double Commission
		{
			get
			{
				return this.GetDoubleField(12).Value;
			}
			set
			{
				this.AddDoubleField(12, value);
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x00023A6C File Offset: 0x00022A6C
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x00023A7B File Offset: 0x00022A7B
		[FIXField("13", EFieldOption.Optional)]
		public char CommType
		{
			get
			{
				return this.GetCharField(13).Value;
			}
			set
			{
				this.AddCharField(13, value);
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x00023A86 File Offset: 0x00022A86
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x00023A98 File Offset: 0x00022A98
		[FIXField("479", EFieldOption.Optional)]
		public double CommCurrency
		{
			get
			{
				return this.GetDoubleField(479).Value;
			}
			set
			{
				this.AddDoubleField(479, value);
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x00023AA6 File Offset: 0x00022AA6
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x00023AB8 File Offset: 0x00022AB8
		[FIXField("497", EFieldOption.Optional)]
		public char FundRenewWaiv
		{
			get
			{
				return this.GetCharField(497).Value;
			}
			set
			{
				this.AddCharField(497, value);
			}
		}
	}
}
