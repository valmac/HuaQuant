using System;
using System.ComponentModel;
using System.Drawing;

namespace SmartQuant.Charting
{
	// Token: 0x02000034 RID: 52
	[Serializable]
	public class TText : IDrawable
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000A950 File Offset: 0x00009950
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0000A958 File Offset: 0x00009958
		[Category("ToolTip")]
		[Description("")]
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

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0000A961 File Offset: 0x00009961
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0000A969 File Offset: 0x00009969
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

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000A972 File Offset: 0x00009972
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0000A97A File Offset: 0x0000997A
		[Category("Position")]
		[Description("")]
		public double X
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0000A983 File Offset: 0x00009983
		// (set) Token: 0x06000282 RID: 642 RVA: 0x0000A98B File Offset: 0x0000998B
		[Category("Position")]
		[Description("")]
		public double Y
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000A994 File Offset: 0x00009994
		// (set) Token: 0x06000284 RID: 644 RVA: 0x0000A99C File Offset: 0x0000999C
		[Browsable(false)]
		public double Z
		{
			get
			{
				return this.fZ;
			}
			set
			{
				this.fZ = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000A9A5 File Offset: 0x000099A5
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0000A9AD File Offset: 0x000099AD
		[Category("Text")]
		[Description("")]
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000A9B6 File Offset: 0x000099B6
		// (set) Token: 0x06000288 RID: 648 RVA: 0x0000A9BE File Offset: 0x000099BE
		[Category("Text")]
		[Description("")]
		public ETextPosition Position
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000A9C7 File Offset: 0x000099C7
		// (set) Token: 0x0600028A RID: 650 RVA: 0x0000A9CF File Offset: 0x000099CF
		[Category("Text")]
		[Description("")]
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000A9D8 File Offset: 0x000099D8
		// (set) Token: 0x0600028C RID: 652 RVA: 0x0000A9E0 File Offset: 0x000099E0
		[Category("Text")]
		[Description("")]
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

		// Token: 0x0600028D RID: 653 RVA: 0x0000A9E9 File Offset: 0x000099E9
		private void Init()
		{
			this.fPosition = ETextPosition.RightBottom;
			this.fFont = new Font("Arial", 8f);
			this.fColor = Color.Black;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000AA12 File Offset: 0x00009A12
		public TText(string Text, double X, double Y)
		{
			this.fX = X;
			this.fY = Y;
			this.fZ = 0.0;
			this.fText = Text;
			this.Init();
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000AA44 File Offset: 0x00009A44
		public TText(string Text, double X, double Y, Color Color)
		{
			this.fX = X;
			this.fY = Y;
			this.fZ = 0.0;
			this.fText = Text;
			this.Init();
			this.fColor = Color;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000AA7E File Offset: 0x00009A7E
		public TText(string Text, DateTime X, double Y)
		{
			this.fX = (double)X.Ticks;
			this.fY = Y;
			this.fZ = 0.0;
			this.fText = Text;
			this.Init();
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000AAB8 File Offset: 0x00009AB8
		public TText(string Text, DateTime X, double Y, Color Color)
		{
			this.fX = (double)X.Ticks;
			this.fY = Y;
			this.fZ = 0.0;
			this.fText = Text;
			this.Init();
			this.fColor = Color;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000AB04 File Offset: 0x00009B04
		public virtual void Draw()
		{
			if (Chart.Pad == null)
			{
				new Canvas("Canvas", "Canvas");
			}
			Chart.Pad.Add(this);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000AB28 File Offset: 0x00009B28
		public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			if (this.fText != null)
			{
				int num = (int)Pad.Graphics.MeasureString(this.fText, this.fFont).Width;
				float height = Pad.Graphics.MeasureString(this.fText, this.fFont).Height;
				switch (this.fPosition)
				{
				case ETextPosition.RightBottom:
					Pad.Graphics.DrawString(this.fText, this.fFont, new SolidBrush(this.fColor), (float)Pad.ClientX(this.fX), (float)Pad.ClientY(this.fY));
					return;
				case ETextPosition.LeftBottom:
					Pad.Graphics.DrawString(this.fText, this.fFont, new SolidBrush(this.fColor), (float)(Pad.ClientX(this.fX) - num), (float)Pad.ClientY(this.fY));
					return;
				case ETextPosition.CentreBottom:
					Pad.Graphics.DrawString(this.fText, this.fFont, new SolidBrush(this.fColor), (float)(Pad.ClientX(this.fX) - num / 2), (float)Pad.ClientY(this.fY));
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000AC59 File Offset: 0x00009C59
		public TDistance Distance(double X, double Y)
		{
			return null;
		}

		// Token: 0x04000119 RID: 281
		protected double fX;

		// Token: 0x0400011A RID: 282
		protected double fY;

		// Token: 0x0400011B RID: 283
		protected double fZ;

		// Token: 0x0400011C RID: 284
		protected string fText;

		// Token: 0x0400011D RID: 285
		protected ETextPosition fPosition;

		// Token: 0x0400011E RID: 286
		protected Font fFont;

		// Token: 0x0400011F RID: 287
		protected Color fColor;

		// Token: 0x04000120 RID: 288
		private bool fToolTipEnabled;

		// Token: 0x04000121 RID: 289
		private string fToolTipFormat;
	}
}
