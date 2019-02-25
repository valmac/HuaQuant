using System;
using System.Drawing;

namespace SmartQuant.Charting
{
	// Token: 0x0200001E RID: 30
	[Serializable]
	internal class TPieItem
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00005BB8 File Offset: 0x00004BB8
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00005BC0 File Offset: 0x00004BC0
		public double Weight
		{
			get
			{
				return this.fWeight;
			}
			set
			{
				this.fWeight = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00005BC9 File Offset: 0x00004BC9
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00005BD1 File Offset: 0x00004BD1
		public Color Color
		{
			get
			{
				return this.fColor;
			}
			set
			{
				this.fColor = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00005BDA File Offset: 0x00004BDA
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00005BE2 File Offset: 0x00004BE2
		public string Text
		{
			get
			{
				return this.fText;
			}
			set
			{
				this.fText = value;
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00005BEB File Offset: 0x00004BEB
		public TPieItem(double Weight, string Text, Color Color)
		{
			this.fWeight = Weight;
			this.fText = Text;
			this.fColor = Color;
		}

		// Token: 0x0400007E RID: 126
		private double fWeight;

		// Token: 0x0400007F RID: 127
		private Color fColor;

		// Token: 0x04000080 RID: 128
		private string fText;
	}
}
