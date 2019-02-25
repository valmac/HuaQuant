using System;

namespace SmartQuant.Testing.Components
{
	// Token: 0x02000025 RID: 37
	public class TesterComponentEventArgs : EventArgs
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x00006450 File Offset: 0x00005450
		public TesterComponentEventArgs(TesterComponentRecord component)
		{
			this.component = component;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000645F File Offset: 0x0000545F
		public TesterComponentRecord Component
		{
			get
			{
				return this.component;
			}
		}

		// Token: 0x04000046 RID: 70
		private TesterComponentRecord component;
	}
}
