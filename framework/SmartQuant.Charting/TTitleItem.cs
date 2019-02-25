using System;
using System.Drawing;

namespace SmartQuant.Charting
{
	// Token: 0x02000046 RID: 70
	[Serializable]
	public class TTitleItem
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0000F152 File Offset: 0x0000E152
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x0000F15A File Offset: 0x0000E15A
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0000F163 File Offset: 0x0000E163
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x0000F16B File Offset: 0x0000E16B
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

		// Token: 0x06000410 RID: 1040 RVA: 0x0000F174 File Offset: 0x0000E174
		public TTitleItem()
		{
			this.fText = "";
			this.fColor = Color.Black;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000F192 File Offset: 0x0000E192
		public TTitleItem(string Text)
		{
			this.fText = Text;
			this.fColor = Color.Black;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000F1AC File Offset: 0x0000E1AC
		public TTitleItem(string Text, Color Color)
		{
			this.fText = Text;
			this.fColor = Color;
		}

		// Token: 0x040001B2 RID: 434
		private string fText;

		// Token: 0x040001B3 RID: 435
		private Color fColor;
	}
}
