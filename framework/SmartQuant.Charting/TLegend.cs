using System;
using System.Collections;
using System.Drawing;

namespace SmartQuant.Charting
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	public class TLegend
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020CB File Offset: 0x000010CB
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020D3 File Offset: 0x000010D3
		public Pad Pad
		{
			get
			{
				return this.fPad;
			}
			set
			{
				this.fPad = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020DC File Offset: 0x000010DC
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020E4 File Offset: 0x000010E4
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

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020ED File Offset: 0x000010ED
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020F5 File Offset: 0x000010F5
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

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002100 File Offset: 0x00001100
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000021A8 File Offset: 0x000011A8
		public int Width
		{
			get
			{
				this.fWidth = 0;
				foreach (object obj in this.fItems)
				{
					TLegendItem tlegendItem = (TLegendItem)obj;
					int num = (int)this.fPad.Graphics.MeasureString(tlegendItem.Text, tlegendItem.Font).Width;
					if (num > this.fWidth)
					{
						this.fWidth = num;
					}
				}
				this.fWidth += 12;
				return this.fWidth;
			}
			set
			{
				this.fWidth = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000021B4 File Offset: 0x000011B4
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002258 File Offset: 0x00001258
		public int Height
		{
			get
			{
				this.fHeight = 0;
				foreach (object obj in this.fItems)
				{
					TLegendItem tlegendItem = (TLegendItem)obj;
					this.fHeight += (int)this.fPad.Graphics.MeasureString(tlegendItem.Text, tlegendItem.Font).Height + 2;
				}
				this.fHeight += 2;
				return this.fHeight;
			}
			set
			{
				this.fHeight = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002261 File Offset: 0x00001261
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002269 File Offset: 0x00001269
		public bool BorderEnabled
		{
			get
			{
				return this.fBorderEnabled;
			}
			set
			{
				this.fBorderEnabled = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002272 File Offset: 0x00001272
		// (set) Token: 0x06000016 RID: 22 RVA: 0x0000227A File Offset: 0x0000127A
		public Color BorderColor
		{
			get
			{
				return this.fBorderColor;
			}
			set
			{
				this.fBorderColor = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002283 File Offset: 0x00001283
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000228B File Offset: 0x0000128B
		public Color BackColor
		{
			get
			{
				return this.fBackColor;
			}
			set
			{
				this.fBackColor = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002294 File Offset: 0x00001294
		public ArrayList Items
		{
			get
			{
				return this.fItems;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000229C File Offset: 0x0000129C
		private void InitLegend()
		{
			this.fBorderEnabled = true;
			this.fBorderColor = Color.Black;
			this.fBackColor = Color.LightYellow;
			this.fItems = new ArrayList();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000022C6 File Offset: 0x000012C6
		public TLegend(Pad Pad)
		{
			this.fPad = Pad;
			this.InitLegend();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000022DB File Offset: 0x000012DB
		public void Add(string Text, Color Color)
		{
			this.fItems.Add(new TLegendItem(Text, Color));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000022F0 File Offset: 0x000012F0
		public void Add(string Text, Color Color, Font Font)
		{
			this.fItems.Add(new TLegendItem(Text, Color, Font));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002306 File Offset: 0x00001306
		public void Add(TLegendItem Item)
		{
			this.fItems.Add(Item);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002318 File Offset: 0x00001318
		public virtual void Paint()
		{
			this.fPad.Graphics.FillRectangle(new SolidBrush(this.fBackColor), this.fX, this.fY, this.Width, this.Height);
			if (this.fBorderEnabled)
			{
				this.fPad.Graphics.DrawRectangle(new Pen(this.fBorderColor), this.fX, this.fY, this.Width, this.Height);
			}
			int num = this.fX + 5;
			int num2 = this.fY + 2;
			foreach (object obj in this.fItems)
			{
				TLegendItem tlegendItem = (TLegendItem)obj;
				int num3 = (int)this.fPad.Graphics.MeasureString(tlegendItem.Text, tlegendItem.Font).Height;
				this.fPad.Graphics.DrawLine(new Pen(tlegendItem.Color), num, num2 + num3 / 2, num + 5, num2 + num3 / 2);
				this.fPad.Graphics.DrawString(tlegendItem.Text, tlegendItem.Font, new SolidBrush(Color.Black), (float)(num + 5 + 2), (float)num2);
				num2 += 2 + num3;
			}
		}

		// Token: 0x04000009 RID: 9
		private Pad fPad;

		// Token: 0x0400000A RID: 10
		private ArrayList fItems;

		// Token: 0x0400000B RID: 11
		private int fX;

		// Token: 0x0400000C RID: 12
		private int fY;

		// Token: 0x0400000D RID: 13
		private int fWidth;

		// Token: 0x0400000E RID: 14
		private int fHeight;

		// Token: 0x0400000F RID: 15
		private bool fBorderEnabled;

		// Token: 0x04000010 RID: 16
		private Color fBorderColor;

		// Token: 0x04000011 RID: 17
		private Color fBackColor;
	}
}
