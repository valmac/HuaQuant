using System;
using System.ComponentModel;
using SmartQuant.FIX;

namespace SmartQuant.Simulation
{
	// Token: 0x02000006 RID: 6
	public class CommissionProvider : ICommissionProvider
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000025B8 File Offset: 0x000015B8
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000025C0 File Offset: 0x000015C0
		[Category("Parameter")]
		[Description("Commission value (depends on Commission Type)")]
		[DefaultValue(0.0)]
		public virtual double Commission
		{
			get
			{
				return this.fCommission;
			}
			set
			{
				this.fCommission = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000025C9 File Offset: 0x000015C9
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000025D1 File Offset: 0x000015D1
		[Description("Commission type (FIX definitions : 1 = per unit (implying shares, par, currency, etc) 2 = percentage 3 = absolute (total monetary amount))")]
		[DefaultValue(CommType.PerShare)]
		[Category("Parameter")]
		public virtual CommType CommType
		{
			get
			{
				return this.fCommType;
			}
			set
			{
				this.fCommType = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000025DA File Offset: 0x000015DA
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000025E2 File Offset: 0x000015E2
		[Description("Minimal commission, absolute value")]
		[Category("Parameter")]
		[DefaultValue(0.0)]
		public virtual double MinCommission
		{
			get
			{
				return this.fMinCommission;
			}
			set
			{
				this.fMinCommission = value;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000025EB File Offset: 0x000015EB
		public CommissionProvider()
		{
			this.fCommType = CommType.PerShare;
			this.fCommission = 0.0;
			this.fMinCommission = 0.0;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002618 File Offset: 0x00001618
		public virtual FIXCommissionData GetCommissionData(FIXExecutionReport report)
		{
			FIXCommissionData fixcommissionData = new FIXCommissionData();
			fixcommissionData.CommType = FIXCommType.ToFIX(this.fCommType);
			fixcommissionData.Commission = this.fCommission;
			if (this.fMinCommission != 0.0)
			{
				double num;
				switch (this.fCommType)
				{
				case CommType.PerShare:
					num = this.fCommission * report.CumQty;
					break;
				case CommType.Percent:
					num = this.fCommission * report.CumQty * report.AvgPx;
					break;
				case CommType.Absolute:
					num = this.fCommission;
					break;
				default:
					throw new NotSupportedException("Commission type is not supported : " + this.fCommType);
				}
				if (num < this.fMinCommission)
				{
					fixcommissionData.CommType = '3';
					fixcommissionData.Commission = this.fMinCommission;
				}
			}
			return fixcommissionData;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000026EA File Offset: 0x000016EA
		public override string ToString()
		{
			return "Commission Provider";
		}

		// Token: 0x04000012 RID: 18
		protected CommType fCommType;

		// Token: 0x04000013 RID: 19
		protected double fCommission;

		// Token: 0x04000014 RID: 20
		protected double fMinCommission;
	}
}
