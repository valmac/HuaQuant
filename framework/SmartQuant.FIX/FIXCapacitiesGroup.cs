using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000041 RID: 65
	public class FIXCapacitiesGroup : FIXGroup
	{
		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00011D41 File Offset: 0x00010D41
		// (set) Token: 0x06000F4B RID: 3915 RVA: 0x00011D53 File Offset: 0x00010D53
		[FIXField("528", EFieldOption.Required)]
		public char OrderCapacity
		{
			get
			{
				return this.GetCharField(528).Value;
			}
			set
			{
				this.AddCharField(528, value);
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x00011D61 File Offset: 0x00010D61
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x00011D73 File Offset: 0x00010D73
		[FIXField("529", EFieldOption.Optional)]
		public string OrderRestrictions
		{
			get
			{
				return this.GetStringField(529).Value;
			}
			set
			{
				this.AddStringField(529, value);
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x00011D81 File Offset: 0x00010D81
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x00011D93 File Offset: 0x00010D93
		[FIXField("863", EFieldOption.Required)]
		public double OrderCapacityQty
		{
			get
			{
				return this.GetDoubleField(863).Value;
			}
			set
			{
				this.AddDoubleField(863, value);
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00011DA1 File Offset: 0x00010DA1
		public FIXCapacitiesGroup()
		{
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00011DA9 File Offset: 0x00010DA9
		public FIXCapacitiesGroup(char OrderCapacity, double OrderCapacityQty)
		{
			this.OrderCapacity = OrderCapacity;
			this.OrderCapacityQty = OrderCapacityQty;
		}
	}
}
