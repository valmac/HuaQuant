using System;

namespace SmartQuant.Charting
{
	// Token: 0x02000020 RID: 32
	[Serializable]
	public class PadRange
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00006776 File Offset: 0x00005776
		public bool IsValid
		{
			get
			{
				return this.isValid;
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000677E File Offset: 0x0000577E
		public PadRange(double min, double max)
		{
			this.Min = min;
			this.Max = max;
			this.isValid = (max - min > double.Epsilon);
		}

		// Token: 0x0400008B RID: 139
		public double Min;

		// Token: 0x0400008C RID: 140
		public double Max;

		// Token: 0x0400008D RID: 141
		protected bool isValid;
	}
}
