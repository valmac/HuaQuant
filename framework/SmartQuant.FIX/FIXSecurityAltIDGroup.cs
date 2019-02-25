using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200018D RID: 397
	public class FIXSecurityAltIDGroup : FIXGroup
	{
		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x06004B76 RID: 19318 RVA: 0x0005366B File Offset: 0x0005266B
		public override int Tag
		{
			get
			{
				return 454;
			}
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x06004B77 RID: 19319 RVA: 0x00053672 File Offset: 0x00052672
		// (set) Token: 0x06004B78 RID: 19320 RVA: 0x0005367F File Offset: 0x0005267F
		[FIXField("455", EFieldOption.Optional)]
		public string SecurityAltID
		{
			get
			{
				return this.GetStringValue(455);
			}
			set
			{
				this.SetStringValue(455, value);
			}
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x06004B79 RID: 19321 RVA: 0x0005368D File Offset: 0x0005268D
		// (set) Token: 0x06004B7A RID: 19322 RVA: 0x0005369A File Offset: 0x0005269A
		[FIXField("456", EFieldOption.Optional)]
		public string SecurityAltIDSource
		{
			get
			{
				return this.GetStringValue(456);
			}
			set
			{
				this.SetStringValue(456, value);
			}
		}

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x06004B7B RID: 19323 RVA: 0x000536A8 File Offset: 0x000526A8
		// (set) Token: 0x06004B7C RID: 19324 RVA: 0x000536B5 File Offset: 0x000526B5
		[FIXField("12100", EFieldOption.Optional)]
		public string SecurityAltExchange
		{
			get
			{
				return this.GetStringValue(12100);
			}
			set
			{
				this.SetStringValue(12100, value);
			}
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x000536C4 File Offset: 0x000526C4
		public override string ToString()
		{
			if (this.SecurityAltID == "")
			{
				return "Not Defined";
			}
			if (this.SecurityAltExchange == "")
			{
				return string.Format("{0} - {1}", this.SecurityAltIDSource, this.SecurityAltID);
			}
			return string.Format("{0} - {1}.{2}", this.SecurityAltIDSource, this.SecurityAltID, this.SecurityAltExchange);
		}
	}
}
