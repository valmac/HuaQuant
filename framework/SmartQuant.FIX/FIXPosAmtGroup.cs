using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000108 RID: 264
	public class FIXPosAmtGroup : FIXGroup
	{
		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x00034490 File Offset: 0x00033490
		// (set) Token: 0x060031B2 RID: 12722 RVA: 0x000344A2 File Offset: 0x000334A2
		[FIXField("707", EFieldOption.Optional)]
		public string PosAmtType
		{
			get
			{
				return this.GetStringField(707).Value;
			}
			set
			{
				this.AddStringField(707, value);
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x060031B3 RID: 12723 RVA: 0x000344B0 File Offset: 0x000334B0
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x000344C2 File Offset: 0x000334C2
		[FIXField("708", EFieldOption.Optional)]
		public double PosAmt
		{
			get
			{
				return this.GetDoubleField(708).Value;
			}
			set
			{
				this.AddDoubleField(708, value);
			}
		}
	}
}
