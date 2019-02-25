using System;
using System.Collections;
using System.Drawing;

namespace SmartQuant.Charting
{
	// Token: 0x02000028 RID: 40
	[Serializable]
	public class TTitle
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000072DA File Offset: 0x000062DA
		public ArrayList Items
		{
			get
			{
				return this.fItems;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000072E2 File Offset: 0x000062E2
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000072EA File Offset: 0x000062EA
		public bool ItemsEnabled
		{
			get
			{
				return this.fItemsEnabled;
			}
			set
			{
				this.fItemsEnabled = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000072F3 File Offset: 0x000062F3
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000072FB File Offset: 0x000062FB
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00007304 File Offset: 0x00006304
		// (set) Token: 0x06000190 RID: 400 RVA: 0x0000730C File Offset: 0x0000630C
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00007315 File Offset: 0x00006315
		// (set) Token: 0x06000192 RID: 402 RVA: 0x0000731D File Offset: 0x0000631D
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00007326 File Offset: 0x00006326
		// (set) Token: 0x06000194 RID: 404 RVA: 0x0000732E File Offset: 0x0000632E
		public ETitlePosition Position
		{
			get
			{
				return this.fPosition;
			}
			set
			{
				this.fPosition = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00007337 File Offset: 0x00006337
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0000733F File Offset: 0x0000633F
		public int X
		{
			get
			{
				return this.fX;
			}
			set
			{
				this.fX = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00007348 File Offset: 0x00006348
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00007350 File Offset: 0x00006350
		public int Y
		{
			get
			{
				return this.fY;
			}
			set
			{
				this.fY = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000735C File Offset: 0x0000635C
		public int Width
		{
			get
			{
				return (int)this.fPad.Graphics.MeasureString(this.GetText(), this.fFont).Width;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00007390 File Offset: 0x00006390
		public int Height
		{
			get
			{
				return (int)this.fPad.Graphics.MeasureString(this.GetText(), this.fFont).Height;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000073C2 File Offset: 0x000063C2
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000073CA File Offset: 0x000063CA
		public ETitleStrategy Strategy
		{
			get
			{
				return this.fStrategy;
			}
			set
			{
				this.fStrategy = value;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000073D4 File Offset: 0x000063D4
		private void Init()
		{
			this.fItems = new ArrayList();
			this.fItemsEnabled = false;
			this.fText = "";
			this.fFont = new Font("Arial", 8f);
			this.fColor = Color.Black;
			this.fPosition = ETitlePosition.Left;
			this.fStrategy = ETitleStrategy.Smart;
			this.fX = 0;
			this.fY = 0;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000743A File Offset: 0x0000643A
		public TTitle(Pad Pad)
		{
			this.fPad = Pad;
			this.fText = "";
			this.Init();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000745A File Offset: 0x0000645A
		public TTitle(Pad Pad, string Text)
		{
			this.fPad = Pad;
			this.fText = Text;
			this.Init();
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00007476 File Offset: 0x00006476
		public void Add(string Text, Color Color)
		{
			this.fItems.Add(new TTitleItem(Text, Color));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000748C File Offset: 0x0000648C
		private string GetText()
		{
			string text = this.fText;
			foreach (object obj in this.fItems)
			{
				TTitleItem ttitleItem = (TTitleItem)obj;
				text = text + " " + ttitleItem.Text;
			}
			return text;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000074F8 File Offset: 0x000064F8
		public void Paint()
		{
			SolidBrush brush = new SolidBrush(this.fColor);
			if (this.fText != "")
			{
				this.fPad.Graphics.DrawString(this.fText, this.fFont, brush, (float)this.fX, (float)this.fY);
			}
			if (this.fStrategy == ETitleStrategy.Smart && this.fText == "" && !this.fItemsEnabled && this.fItems.Count != 0)
			{
				this.fPad.Graphics.DrawString(((TTitleItem)this.fItems[0]).Text, this.fFont, new SolidBrush(this.fColor), (float)this.fX, (float)this.fY);
			}
			if (this.fItemsEnabled)
			{
				string text = this.fText;
				foreach (object obj in this.fItems)
				{
					TTitleItem ttitleItem = (TTitleItem)obj;
					brush = new SolidBrush(ttitleItem.Color);
					text += " ";
					int num = this.fX + (int)this.fPad.Graphics.MeasureString(text, this.fFont).Width;
					this.fPad.Graphics.DrawString(ttitleItem.Text, this.fFont, brush, (float)num, (float)this.fY);
					text += ttitleItem.Text;
				}
			}
		}

		// Token: 0x040000B2 RID: 178
		private Pad fPad;

		// Token: 0x040000B3 RID: 179
		private ArrayList fItems;

		// Token: 0x040000B4 RID: 180
		private bool fItemsEnabled;

		// Token: 0x040000B5 RID: 181
		private string fText;

		// Token: 0x040000B6 RID: 182
		private Font fFont;

		// Token: 0x040000B7 RID: 183
		private Color fColor;

		// Token: 0x040000B8 RID: 184
		private ETitlePosition fPosition;

		// Token: 0x040000B9 RID: 185
		private int fX;

		// Token: 0x040000BA RID: 186
		private int fY;

		// Token: 0x040000BB RID: 187
		private ETitleStrategy fStrategy;
	}
}
