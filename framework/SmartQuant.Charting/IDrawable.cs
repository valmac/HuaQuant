using System;

namespace SmartQuant.Charting
{
	// Token: 0x02000007 RID: 7
	public interface IDrawable
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000035 RID: 53
		// (set) Token: 0x06000036 RID: 54
		bool ToolTipEnabled { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000037 RID: 55
		// (set) Token: 0x06000038 RID: 56
		string ToolTipFormat { get; set; }

		// Token: 0x06000039 RID: 57
		void Draw();

		// Token: 0x0600003A RID: 58
		void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY);

		// Token: 0x0600003B RID: 59
		TDistance Distance(double X, double Y);
	}
}
