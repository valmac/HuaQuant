using System;
using System.ComponentModel;

namespace SmartQuant.FIX
{
	// Token: 0x02000106 RID: 262
	public class ExecutionReport : FIXExecutionReport
	{
		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x00034383 File Offset: 0x00033383
		// (set) Token: 0x0600319E RID: 12702 RVA: 0x00034390 File Offset: 0x00033390
		[Category("Attributes")]
		public new Side Side
		{
			get
			{
				return FIXSide.FromFIX(base.Side);
			}
			set
			{
				base.Side = FIXSide.ToFIX(value);
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x0003439E File Offset: 0x0003339E
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x000343AB File Offset: 0x000333AB
		[Category("Attributes")]
		public new OrdType OrdType
		{
			get
			{
				return FIXOrdType.FromFIX(base.OrdType);
			}
			set
			{
				base.OrdType = FIXOrdType.ToFIX(value);
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x000343B9 File Offset: 0x000333B9
		// (set) Token: 0x060031A2 RID: 12706 RVA: 0x000343C6 File Offset: 0x000333C6
		[Category("Attributes")]
		public new OrdStatus OrdStatus
		{
			get
			{
				return FIXOrdStatus.FromFIX(base.OrdStatus);
			}
			set
			{
				base.OrdStatus = FIXOrdStatus.ToFIX(value);
			}
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x060031A3 RID: 12707 RVA: 0x000343D4 File Offset: 0x000333D4
		// (set) Token: 0x060031A4 RID: 12708 RVA: 0x000343E1 File Offset: 0x000333E1
		[Category("Attributes")]
		public new TimeInForce TimeInForce
		{
			get
			{
				return FIXTimeInForce.FromFIX(base.TimeInForce);
			}
			set
			{
				base.TimeInForce = FIXTimeInForce.ToFIX(value);
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x060031A5 RID: 12709 RVA: 0x000343EF File Offset: 0x000333EF
		// (set) Token: 0x060031A6 RID: 12710 RVA: 0x000343FC File Offset: 0x000333FC
		[Category("Attributes")]
		public new ExecTransType ExecTransType
		{
			get
			{
				return FIXExecTransType.FromFIX(base.ExecTransType);
			}
			set
			{
				base.ExecTransType = FIXExecTransType.ToFIX(value);
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x0003440A File Offset: 0x0003340A
		// (set) Token: 0x060031A8 RID: 12712 RVA: 0x00034417 File Offset: 0x00033417
		[Category("Attributes")]
		public new ExecType ExecType
		{
			get
			{
				return FIXExecType.FromFIX(base.ExecType);
			}
			set
			{
				base.ExecType = FIXExecType.ToFIX(value);
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x00034425 File Offset: 0x00033425
		// (set) Token: 0x060031AA RID: 12714 RVA: 0x00034432 File Offset: 0x00033432
		[Category("Commission")]
		public new CommType CommType
		{
			get
			{
				return FIXCommType.FromFIX(base.CommType);
			}
			set
			{
				base.CommType = FIXCommType.ToFIX(value);
			}
		}
	}
}
