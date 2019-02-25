using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace SmartQuant.Charting
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class TTextBox : IDrawable
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002589 File Offset: 0x00001589
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002591 File Offset: 0x00001591
		[Description("")]
		[Category("ToolTip")]
		public bool ToolTipEnabled
		{
			get
			{
				return this.fToolTipEnabled;
			}
			set
			{
				this.fToolTipEnabled = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0000259A File Offset: 0x0000159A
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000025A2 File Offset: 0x000015A2
		[Description("")]
		[Category("ToolTip")]
		public string ToolTipFormat
		{
			get
			{
				return this.fToolTipFormat;
			}
			set
			{
				this.fToolTipFormat = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000025AB File Offset: 0x000015AB
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000025B3 File Offset: 0x000015B3
		public ETextBoxPosition Position
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

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000025BC File Offset: 0x000015BC
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000025C4 File Offset: 0x000015C4
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

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000025CD File Offset: 0x000015CD
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000025D5 File Offset: 0x000015D5
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000025DE File Offset: 0x000015DE
		public int Width
		{
			get
			{
				return this.fWidth;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000025E6 File Offset: 0x000015E6
		public int Height
		{
			get
			{
				return this.fHeight;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000025EE File Offset: 0x000015EE
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000025F6 File Offset: 0x000015F6
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

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000025FF File Offset: 0x000015FF
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002607 File Offset: 0x00001607
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002610 File Offset: 0x00001610
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002618 File Offset: 0x00001618
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

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002621 File Offset: 0x00001621
		public ArrayList Items
		{
			get
			{
				return this.fItems;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002629 File Offset: 0x00001629
		private void InitTextBox()
		{
			this.fWidth = -1;
			this.fHeight = -1;
			this.fPosition = ETextBoxPosition.TopRight;
			this.fBorderEnabled = true;
			this.fBorderColor = Color.Black;
			this.fBackColor = Color.LightYellow;
			this.fItems = new ArrayList();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002668 File Offset: 0x00001668
		public TTextBox()
		{
			this.fX = 10;
			this.fY = 10;
			this.InitTextBox();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002686 File Offset: 0x00001686
		public TTextBox(int X, int Y)
		{
			this.fX = X;
			this.fY = Y;
			this.InitTextBox();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000026A2 File Offset: 0x000016A2
		public void Add(string Text, Color Color)
		{
			this.fItems.Add(new TTextBoxItem(Text, Color));
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000026B7 File Offset: 0x000016B7
		public void Add(string Text, Color Color, Font Font)
		{
			this.fItems.Add(new TTextBoxItem(Text, Color, Font));
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000026CD File Offset: 0x000016CD
		public void Add(TTextBoxItem Item)
		{
			this.fItems.Add(Item);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000026DC File Offset: 0x000016DC
		public void Clear()
		{
			this.fItems.Clear();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000026E9 File Offset: 0x000016E9
		public virtual void Draw()
		{
			if (Chart.Pad == null)
			{
				new Canvas("Canvas", "Canvas");
			}
			Chart.Pad.Add(this);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002710 File Offset: 0x00001710
		private float GetWidth(Pad pad)
		{
			this.fWidth = 0;
			foreach (object obj in this.fItems)
			{
				TTextBoxItem ttextBoxItem = (TTextBoxItem)obj;
				int num = (int)pad.Graphics.MeasureString(ttextBoxItem.Text, ttextBoxItem.Font).Width;
				if (num > this.fWidth)
				{
					this.fWidth = num;
				}
			}
			this.fWidth += 12;
			return (float)this.fWidth;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000027B4 File Offset: 0x000017B4
		private float GetHeight(Pad pad)
		{
			this.fHeight = 0;
			foreach (object obj in this.fItems)
			{
				TTextBoxItem ttextBoxItem = (TTextBoxItem)obj;
				this.fHeight += (int)pad.Graphics.MeasureString(ttextBoxItem.Text, ttextBoxItem.Font).Height + 2;
			}
			this.fHeight += 2;
			return (float)this.fHeight;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002854 File Offset: 0x00001854
		public virtual void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			float height = this.GetHeight(Pad);
			float width = this.GetWidth(Pad);
			float num = 0f;
			float num2 = 0f;
			switch (this.fPosition)
			{
			case ETextBoxPosition.TopRight:
				num = (float)(Pad.ClientX() + Pad.ClientWidth() - this.fX) - width;
				num2 = (float)(Pad.ClientY() + this.fY);
				break;
			case ETextBoxPosition.TopLeft:
				num = (float)(Pad.ClientX() + this.fX);
				num2 = (float)(Pad.ClientY() + this.fY);
				break;
			case ETextBoxPosition.BottomRight:
				num = (float)(Pad.ClientX() + Pad.ClientWidth() - this.fX) - width;
				num2 = (float)(Pad.ClientY() + Pad.ClientHeight() - this.fY) - height;
				break;
			case ETextBoxPosition.BottomLeft:
				num = (float)(Pad.ClientX() + this.fX);
				num2 = (float)(Pad.ClientY() + Pad.ClientHeight() - this.fY) - height;
				break;
			}
			Pad.Graphics.FillRectangle(new SolidBrush(this.fBackColor), num, num2, width, height);
			if (this.fBorderEnabled)
			{
				Pad.Graphics.DrawRectangle(new Pen(this.fBorderColor), num, num2, width, height);
			}
			foreach (object obj in this.fItems)
			{
				TTextBoxItem ttextBoxItem = (TTextBoxItem)obj;
				int num3 = (int)Pad.Graphics.MeasureString(ttextBoxItem.Text, ttextBoxItem.Font).Height;
				Pad.Graphics.DrawString(ttextBoxItem.Text, ttextBoxItem.Font, new SolidBrush(ttextBoxItem.Color), num + 5f, num2);
				num2 += (float)(2 + num3);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002A28 File Offset: 0x00001A28
		public TDistance Distance(double X, double Y)
		{
			return null;
		}

		// Token: 0x04000018 RID: 24
		private ArrayList fItems;

		// Token: 0x04000019 RID: 25
		private int fX;

		// Token: 0x0400001A RID: 26
		private int fY;

		// Token: 0x0400001B RID: 27
		private int fWidth;

		// Token: 0x0400001C RID: 28
		private int fHeight;

		// Token: 0x0400001D RID: 29
		private ETextBoxPosition fPosition;

		// Token: 0x0400001E RID: 30
		private bool fBorderEnabled;

		// Token: 0x0400001F RID: 31
		private Color fBorderColor;

		// Token: 0x04000020 RID: 32
		private Color fBackColor;

		// Token: 0x04000021 RID: 33
		private bool fToolTipEnabled;

		// Token: 0x04000022 RID: 34
		private string fToolTipFormat;
	}
}
