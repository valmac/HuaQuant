using System;
using System.Drawing;

namespace SmartQuant.Charting
{
	// Token: 0x0200002A RID: 42
	public class TTextBoxItem
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000078D8 File Offset: 0x000068D8
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x000078E0 File Offset: 0x000068E0
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000078E9 File Offset: 0x000068E9
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x000078F1 File Offset: 0x000068F1
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x000078FA File Offset: 0x000068FA
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00007902 File Offset: 0x00006902
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

		// Token: 0x060001B8 RID: 440 RVA: 0x0000790B File Offset: 0x0000690B
		public TTextBoxItem(string Text, Color Color, Font Font)
		{
			this.fText = Text;
			this.fColor = Color;
			this.fFont = Font;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00007928 File Offset: 0x00006928
		public TTextBoxItem(string Text, Color Color)
		{
			this.fText = Text;
			this.fColor = Color;
			this.fFont = new Font("Arial", 8f);
		}

		// Token: 0x040000C1 RID: 193
		private string fText;

		// Token: 0x040000C2 RID: 194
		private Color fColor;

		// Token: 0x040000C3 RID: 195
		private Font fFont;
	}
}
