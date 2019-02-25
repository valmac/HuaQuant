using System;

namespace SmartQuant
{
	// Token: 0x02000024 RID: 36
	public class ReferenceEventArgs : EventArgs
	{
		// Token: 0x060000CF RID: 207 RVA: 0x000045AF File Offset: 0x000035AF
		public ReferenceEventArgs(Reference reference)
		{
			this.reference = reference;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000045BE File Offset: 0x000035BE
		public Reference Reference
		{
			get
			{
				return this.reference;
			}
		}

		// Token: 0x04000088 RID: 136
		private Reference reference;
	}
}
