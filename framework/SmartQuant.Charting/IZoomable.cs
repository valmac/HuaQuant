using System;

namespace SmartQuant.Charting
{
	// Token: 0x02000015 RID: 21
	public interface IZoomable
	{
		// Token: 0x060000BF RID: 191
		bool IsPadRangeX();

		// Token: 0x060000C0 RID: 192
		bool IsPadRangeY();

		// Token: 0x060000C1 RID: 193
		PadRange GetPadRangeX(Pad pad);

		// Token: 0x060000C2 RID: 194
		PadRange GetPadRangeY(Pad pad);
	}
}
