using System;
using System.Drawing;

namespace SmartQuant.Charting
{
	// Token: 0x02000002 RID: 2
	[Serializable]
	public class TLegendItem
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00001058
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

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00001061
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00001069
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00001072
		// (set) Token: 0x06000006 RID: 6 RVA: 0x0000207A File Offset: 0x0000107A
		public Font Font
		{
			get
			{
				return this.fFont;
			}
			set
			{
				this.fFont = value;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002083 File Offset: 0x00001083
		public TLegendItem(string Text, Color Color, Font Font)
		{
			this.fText = Text;
			this.fColor = Color;
			this.fFont = Font;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020A0 File Offset: 0x000010A0
		public TLegendItem(string Text, Color Color)
		{
			this.fText = Text;
			this.fColor = Color;
			this.fFont = new Font("Arial", 8f);
		}

		// Token: 0x04000001 RID: 1
		private string fText;

		// Token: 0x04000002 RID: 2
		private Color fColor;

		// Token: 0x04000003 RID: 3
		private Font fFont;
	}
}
