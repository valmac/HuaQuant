using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000104 RID: 260
	public class NewOrderSingle : FIXNewOrderSingle
	{
		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x000342F8 File Offset: 0x000332F8
		// (set) Token: 0x06003193 RID: 12691 RVA: 0x00034305 File Offset: 0x00033305
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

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x00034313 File Offset: 0x00033313
		// (set) Token: 0x06003195 RID: 12693 RVA: 0x00034320 File Offset: 0x00033320
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

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x0003432E File Offset: 0x0003332E
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x0003433B File Offset: 0x0003333B
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

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x00034349 File Offset: 0x00033349
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x00034356 File Offset: 0x00033356
		public new FaMethod FaMethod
		{
			get
			{
				return FIXFaMethod.FromFIX(base.FaMethod);
			}
			set
			{
				base.FaMethod = FIXFaMethod.ToFIX(value);
			}
		}
	}
}
