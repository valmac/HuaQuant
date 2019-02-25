using System;
using System.ComponentModel;
using System.Drawing;

namespace SmartQuant.Charting
{
	// Token: 0x0200002C RID: 44
	[Serializable]
	public class TLabel : TMarker
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000893E File Offset: 0x0000793E
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00008946 File Offset: 0x00007946
		[Category("Text")]
		[Description("Text that this label displays")]
		public new string Text
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000894F File Offset: 0x0000794F
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00008957 File Offset: 0x00007957
		[Description("Text position of this label")]
		[Category("Text")]
		public new ETextPosition TextPosition
		{
			get
			{
				return this.fTextPosition;
			}
			set
			{
				this.fTextPosition = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00008960 File Offset: 0x00007960
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00008968 File Offset: 0x00007968
		[Category("Text")]
		[Description("Text font of this label")]
		public new Font TextFont
		{
			get
			{
				return this.fTextFont;
			}
			set
			{
				this.fTextFont = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00008971 File Offset: 0x00007971
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00008979 File Offset: 0x00007979
		[Description("Text color of this label")]
		[Category("Text")]
		public new Color TextColor
		{
			get
			{
				return this.fTextColor;
			}
			set
			{
				this.fTextColor = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00008982 File Offset: 0x00007982
		// (set) Token: 0x06000201 RID: 513 RVA: 0x0000898A File Offset: 0x0000798A
		[Category("Text")]
		[Description("Text offset in pixels alone X coordinate")]
		public int TextOffsetX
		{
			get
			{
				return this.fTextOffsetX;
			}
			set
			{
				this.fTextOffsetX = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00008993 File Offset: 0x00007993
		// (set) Token: 0x06000203 RID: 515 RVA: 0x0000899B File Offset: 0x0000799B
		[Category("Text")]
		[Description("Text offset in pixels alone Y coordinate")]
		public int TextOffsetY
		{
			get
			{
				return this.fTextOffsetY;
			}
			set
			{
				this.fTextOffsetY = value;
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000089A4 File Offset: 0x000079A4
		private void InitLabel()
		{
			this.fTextFont = new Font("Arial", 8f);
			this.fTextPosition = ETextPosition.RightBottom;
			this.fTextColor = Color.Black;
			this.fTextOffsetX = 0;
			this.fTextOffsetY = 2;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000089DB File Offset: 0x000079DB
		public TLabel(string Text, double X, double Y) : base(X, Y)
		{
			this.fText = Text;
			this.InitLabel();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000089F2 File Offset: 0x000079F2
		public TLabel(string Text, double X, double Y, Color MarkerColor) : base(X, Y, MarkerColor)
		{
			this.fText = Text;
			this.InitLabel();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00008A0B File Offset: 0x00007A0B
		public TLabel(string Text, double X, double Y, Color MarkerColor, Color TextColor) : base(X, Y, MarkerColor)
		{
			this.fText = Text;
			this.InitLabel();
			this.fTextColor = TextColor;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00008A2C File Offset: 0x00007A2C
		public override void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			base.Paint(Pad, MinX, MaxX, MinY, MaxY);
			if (this.fText != null)
			{
				int num = (int)Pad.Graphics.MeasureString(this.fText, this.fTextFont).Width;
				int num2 = (int)Pad.Graphics.MeasureString(this.fText, this.fTextFont).Height;
				switch (this.fTextPosition)
				{
				case ETextPosition.RightTop:
					Pad.Graphics.DrawString(this.fText, this.fTextFont, new SolidBrush(this.fTextColor), (float)(Pad.ClientX(this.fX) + this.fTextOffsetX), (float)(Pad.ClientY(this.fY) - num2 - this.fTextOffsetY));
					return;
				case ETextPosition.LeftTop:
					Pad.Graphics.DrawString(this.fText, this.fTextFont, new SolidBrush(this.fTextColor), (float)(Pad.ClientX(this.fX) - num - this.fTextOffsetX), (float)(Pad.ClientY(this.fY) - num2 - this.fTextOffsetY));
					return;
				case ETextPosition.CentreTop:
					Pad.Graphics.DrawString(this.fText, this.fTextFont, new SolidBrush(this.fTextColor), (float)(Pad.ClientX(this.fX) - num / 2 - this.fTextOffsetX), (float)(Pad.ClientY(this.fY) - num2 - this.fTextOffsetY));
					break;
				case ETextPosition.RightBottom:
					Pad.Graphics.DrawString(this.fText, this.fTextFont, new SolidBrush(this.fTextColor), (float)(Pad.ClientX(this.fX) + this.fTextOffsetX), (float)(Pad.ClientY(this.fY) + base.Size / 2 + this.fTextOffsetY));
					return;
				case ETextPosition.LeftBottom:
					Pad.Graphics.DrawString(this.fText, this.fTextFont, new SolidBrush(this.fTextColor), (float)(Pad.ClientX(this.fX) - num - this.fTextOffsetX), (float)(Pad.ClientY(this.fY) + base.Size / 2 + this.fTextOffsetY));
					return;
				case ETextPosition.CentreBottom:
					Pad.Graphics.DrawString(this.fText, this.fTextFont, new SolidBrush(this.fTextColor), (float)(Pad.ClientX(this.fX) - num / 2 - this.fTextOffsetX), (float)(Pad.ClientY(this.fY) + base.Size / 2 + this.fTextOffsetY));
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x040000DB RID: 219
		private new string fText;

		// Token: 0x040000DC RID: 220
		private new ETextPosition fTextPosition;

		// Token: 0x040000DD RID: 221
		private new Font fTextFont;

		// Token: 0x040000DE RID: 222
		private new Color fTextColor;

		// Token: 0x040000DF RID: 223
		private int fTextOffsetX;

		// Token: 0x040000E0 RID: 224
		private int fTextOffsetY;
	}
}
