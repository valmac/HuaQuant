using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200017F RID: 383
	public class FIXPositionAmountDataEventArgs : EventArgs
	{
		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x0600473A RID: 18234 RVA: 0x0004F0B6 File Offset: 0x0004E0B6
		// (set) Token: 0x0600473B RID: 18235 RVA: 0x0004F0BE File Offset: 0x0004E0BE
		public FIXPositionAmountData PositionAmountData
		{
			get
			{
				return this.fPositionAmountData;
			}
			set
			{
				this.fPositionAmountData = value;
			}
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x0004F0C7 File Offset: 0x0004E0C7
		public FIXPositionAmountDataEventArgs(FIXPositionAmountData PositionAmountData)
		{
			this.fPositionAmountData = PositionAmountData;
		}

		// Token: 0x04000D9B RID: 3483
		private FIXPositionAmountData fPositionAmountData;
	}
}
