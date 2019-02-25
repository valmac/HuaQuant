using System;

namespace SmartQuant.Trading.Design
{
	// Token: 0x02000025 RID: 37
	internal class ComboBoxItem
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00006540 File Offset: 0x00005540
		public ComboBoxItem(object value)
		{
			this.value = value;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000654F File Offset: 0x0000554F
		public object Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00006557 File Offset: 0x00005557
		public override string ToString()
		{
			if (this.value != null)
			{
				return this.value.ToString();
			}
			return "(none)";
		}

		// Token: 0x04000086 RID: 134
		private object value;
	}
}
