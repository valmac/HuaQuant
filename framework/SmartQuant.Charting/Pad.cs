using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartQuant.Charting
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public class Pad
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000B6C5 File Offset: 0x0000A6C5
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0000B6D2 File Offset: 0x0000A6D2
		[Browsable(false)]
		public bool For3D
		{
			get
			{
				return this.Features3D.Active;
			}
			set
			{
				this.Features3D.Active = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0000B6E0 File Offset: 0x0000A6E0
		// (set) Token: 0x060002CD RID: 717 RVA: 0x0000B6ED File Offset: 0x0000A6ED
		[Browsable(false)]
		public object View3D
		{
			get
			{
				return this.Features3D.View;
			}
			set
			{
				this.Features3D.View = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000B6FB File Offset: 0x0000A6FB
		[Browsable(false)]
		public Axis[] Axes3D
		{
			get
			{
				return this.Features3D.Axes;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000B708 File Offset: 0x0000A708
		[Browsable(false)]
		public Axis AxisX3D
		{
			get
			{
				return this.Features3D.Axes[0];
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000B717 File Offset: 0x0000A717
		[Browsable(false)]
		public Axis AxisY3D
		{
			get
			{
				return this.Features3D.Axes[1];
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000B726 File Offset: 0x0000A726
		[Browsable(false)]
		public Axis AxisZ3D
		{
			get
			{
				return this.Features3D.Axes[2];
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060002D2 RID: 722 RVA: 0x0000B735 File Offset: 0x0000A735
		// (remove) Token: 0x060002D3 RID: 723 RVA: 0x0000B74C File Offset: 0x0000A74C
		public static event NewTickEventHandler NewTick;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060002D4 RID: 724 RVA: 0x0000B763 File Offset: 0x0000A763
		// (remove) Token: 0x060002D5 RID: 725 RVA: 0x0000B77C File Offset: 0x0000A77C
		public event ZoomEventHandler Zoom;

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000B795 File Offset: 0x0000A795
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x0000B79D File Offset: 0x0000A79D
		[Browsable(false)]
		public Chart Chart
		{
			get
			{
				return this.fChart;
			}
			set
			{
				this.fChart = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000B7A6 File Offset: 0x0000A7A6
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0000B7B3 File Offset: 0x0000A7B3
		[Description("Enable or disable double buffering")]
		[Category("Appearance")]
		public bool DoubleBufferingEnabled
		{
			get
			{
				return this.fChart.DoubleBufferingEnabled;
			}
			set
			{
				this.fChart.DoubleBufferingEnabled = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000B7C1 File Offset: 0x0000A7C1
		// (set) Token: 0x060002DB RID: 731 RVA: 0x0000B7CE File Offset: 0x0000A7CE
		[Category("Appearance")]
		[Description("Enable or disable smoothing")]
		public bool SmoothingEnabled
		{
			get
			{
				return this.fChart.SmoothingEnabled;
			}
			set
			{
				this.fChart.SmoothingEnabled = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0000B7DC File Offset: 0x0000A7DC
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0000B7E9 File Offset: 0x0000A7E9
		[Category("Appearance")]
		[Description("Enable or disable antialiasing")]
		public bool AntiAliasingEnabled
		{
			get
			{
				return this.fChart.AntiAliasingEnabled;
			}
			set
			{
				this.fChart.AntiAliasingEnabled = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000B7F7 File Offset: 0x0000A7F7
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0000B7FF File Offset: 0x0000A7FF
		[Description("")]
		[Category("Position")]
		public double CanvasX1
		{
			get
			{
				return this.fCanvasX1;
			}
			set
			{
				this.fCanvasX1 = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000B808 File Offset: 0x0000A808
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x0000B810 File Offset: 0x0000A810
		[Description("")]
		[Category("Position")]
		public double CanvasX2
		{
			get
			{
				return this.fCanvasX2;
			}
			set
			{
				this.fCanvasX2 = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000B819 File Offset: 0x0000A819
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0000B821 File Offset: 0x0000A821
		[Description("")]
		[Category("Position")]
		public double CanvasY1
		{
			get
			{
				return this.fCanvasY1;
			}
			set
			{
				this.fCanvasY1 = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000B82A File Offset: 0x0000A82A
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x0000B832 File Offset: 0x0000A832
		[Category("Position")]
		[Description("")]
		public double CanvasY2
		{
			get
			{
				return this.fCanvasY2;
			}
			set
			{
				this.fCanvasY2 = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000B83B File Offset: 0x0000A83B
		[Browsable(false)]
		public double CanvasWidth
		{
			get
			{
				return Math.Abs(this.fCanvasX2 - this.fCanvasX1);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000B84F File Offset: 0x0000A84F
		[Browsable(false)]
		public double CanvasHeight
		{
			get
			{
				return Math.Abs(this.fCanvasY2 - this.fCanvasY1);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000B863 File Offset: 0x0000A863
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000B86B File Offset: 0x0000A86B
		[Browsable(false)]
		public virtual int X1
		{
			get
			{
				return this.fX1;
			}
			set
			{
				this.fX1 = value;
				this.fWidth = this.fX2 - this.fX1;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000B887 File Offset: 0x0000A887
		// (set) Token: 0x060002EB RID: 747 RVA: 0x0000B88F File Offset: 0x0000A88F
		[Browsable(false)]
		public virtual int X2
		{
			get
			{
				return this.fX2;
			}
			set
			{
				this.fX2 = value;
				this.fWidth = this.fX2 - this.fX1;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000B8AB File Offset: 0x0000A8AB
		// (set) Token: 0x060002ED RID: 749 RVA: 0x0000B8B3 File Offset: 0x0000A8B3
		[Browsable(false)]
		public int Y1
		{
			get
			{
				return this.fY1;
			}
			set
			{
				this.fY1 = value;
				this.fHeight = this.fY2 - this.fY1;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000B8CF File Offset: 0x0000A8CF
		// (set) Token: 0x060002EF RID: 751 RVA: 0x0000B8D7 File Offset: 0x0000A8D7
		[Browsable(false)]
		public int Y2
		{
			get
			{
				return this.fY2;
			}
			set
			{
				this.fY2 = value;
				this.fHeight = this.fY2 - this.fY1;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000B8F3 File Offset: 0x0000A8F3
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x0000B8FB File Offset: 0x0000A8FB
		[Browsable(false)]
		public int Width
		{
			get
			{
				return this.fWidth;
			}
			set
			{
				this.fWidth = value;
				this.fX2 = this.fX1 + this.fWidth;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000B917 File Offset: 0x0000A917
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x0000B91F File Offset: 0x0000A91F
		[Browsable(false)]
		public int Height
		{
			get
			{
				return this.fHeight;
			}
			set
			{
				this.fHeight = value;
				this.fY2 = this.fY1 + this.fHeight;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000B93B File Offset: 0x0000A93B
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x0000B969 File Offset: 0x0000A969
		[Browsable(false)]
		public double XMin
		{
			get
			{
				if (this.fAxisBottom.Enabled && this.fAxisBottom.Zoomed)
				{
					return this.fAxisBottom.Min;
				}
				return this.fXMin;
			}
			set
			{
				this.fXMin = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000B972 File Offset: 0x0000A972
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x0000B9A0 File Offset: 0x0000A9A0
		[Browsable(false)]
		public double XMax
		{
			get
			{
				if (this.fAxisBottom.Enabled && this.fAxisBottom.Zoomed)
				{
					return this.fAxisBottom.Max;
				}
				return this.fXMax;
			}
			set
			{
				this.fXMax = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000B9A9 File Offset: 0x0000A9A9
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x0000B9D7 File Offset: 0x0000A9D7
		[Browsable(false)]
		public double YMin
		{
			get
			{
				if (this.fAxisLeft.Enabled && this.fAxisLeft.Zoomed)
				{
					return this.fAxisLeft.Min;
				}
				return this.fYMin;
			}
			set
			{
				this.fYMin = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000B9E0 File Offset: 0x0000A9E0
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0000BA0E File Offset: 0x0000AA0E
		[Browsable(false)]
		public double YMax
		{
			get
			{
				if (this.fAxisLeft.Enabled && this.fAxisLeft.Zoomed)
				{
					return this.fAxisLeft.Max;
				}
				return this.fYMax;
			}
			set
			{
				this.fYMax = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000BA17 File Offset: 0x0000AA17
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0000BA1F File Offset: 0x0000AA1F
		[Browsable(false)]
		public double XRangeMin
		{
			get
			{
				return this.fXMin;
			}
			set
			{
				this.fXMin = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000BA28 File Offset: 0x0000AA28
		// (set) Token: 0x060002FF RID: 767 RVA: 0x0000BA30 File Offset: 0x0000AA30
		[Browsable(false)]
		public double XRangeMax
		{
			get
			{
				return this.fXMax;
			}
			set
			{
				this.fXMax = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000BA39 File Offset: 0x0000AA39
		// (set) Token: 0x06000301 RID: 769 RVA: 0x0000BA41 File Offset: 0x0000AA41
		[Browsable(false)]
		public double YRangeMin
		{
			get
			{
				return this.fYMin;
			}
			set
			{
				this.fYMin = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000BA4A File Offset: 0x0000AA4A
		// (set) Token: 0x06000303 RID: 771 RVA: 0x0000BA52 File Offset: 0x0000AA52
		[Browsable(false)]
		public double YRangeMax
		{
			get
			{
				return this.fYMax;
			}
			set
			{
				this.fYMax = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0000BA5B File Offset: 0x0000AA5B
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0000BA63 File Offset: 0x0000AA63
		[Category("Margin")]
		[Description("")]
		public int MarginLeft
		{
			get
			{
				return this.fMarginLeft;
			}
			set
			{
				this.fMarginLeft = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0000BA6C File Offset: 0x0000AA6C
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0000BA74 File Offset: 0x0000AA74
		[Category("Margin")]
		[Description("")]
		public int MarginRight
		{
			get
			{
				return this.fMarginRight;
			}
			set
			{
				this.fMarginRight = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0000BA7D File Offset: 0x0000AA7D
		// (set) Token: 0x06000309 RID: 777 RVA: 0x0000BA85 File Offset: 0x0000AA85
		[Category("Margin")]
		[Description("")]
		public int MarginTop
		{
			get
			{
				return this.fMarginTop;
			}
			set
			{
				this.fMarginTop = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0000BA8E File Offset: 0x0000AA8E
		// (set) Token: 0x0600030B RID: 779 RVA: 0x0000BA96 File Offset: 0x0000AA96
		[Category("Margin")]
		[Description("")]
		public int MarginBottom
		{
			get
			{
				return this.fMarginBottom;
			}
			set
			{
				this.fMarginBottom = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000BA9F File Offset: 0x0000AA9F
		// (set) Token: 0x0600030D RID: 781 RVA: 0x0000BAA7 File Offset: 0x0000AAA7
		public string Name
		{
			get
			{
				return this.fName;
			}
			set
			{
				this.fName = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0000BAB0 File Offset: 0x0000AAB0
		// (set) Token: 0x0600030F RID: 783 RVA: 0x0000BAB8 File Offset: 0x0000AAB8
		[Browsable(false)]
		public TTitle Title
		{
			get
			{
				return this.fTitle;
			}
			set
			{
				this.fTitle = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0000BAC1 File Offset: 0x0000AAC1
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0000BAC9 File Offset: 0x0000AAC9
		[Category("Title")]
		[Description("")]
		public bool TitleEnabled
		{
			get
			{
				return this.fTitleEnabled;
			}
			set
			{
				this.fTitleEnabled = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000BAD2 File Offset: 0x0000AAD2
		[Description("")]
		[Category("Title")]
		public ArrayList TitleItems
		{
			get
			{
				return this.fTitle.Items;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0000BADF File Offset: 0x0000AADF
		// (set) Token: 0x06000314 RID: 788 RVA: 0x0000BAEC File Offset: 0x0000AAEC
		[Description("")]
		[Category("Title")]
		public bool TitleItemsEnabled
		{
			get
			{
				return this.fTitle.ItemsEnabled;
			}
			set
			{
				this.fTitle.ItemsEnabled = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0000BAFA File Offset: 0x0000AAFA
		// (set) Token: 0x06000316 RID: 790 RVA: 0x0000BB07 File Offset: 0x0000AB07
		[Category("Title")]
		[Description("")]
		public string TitleText
		{
			get
			{
				return this.fTitle.Text;
			}
			set
			{
				this.fTitle.Text = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0000BB15 File Offset: 0x0000AB15
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0000BB22 File Offset: 0x0000AB22
		[Category("Title")]
		[Description("")]
		public Font TitleFont
		{
			get
			{
				return this.fTitle.Font;
			}
			set
			{
				this.fTitle.Font = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000BB30 File Offset: 0x0000AB30
		// (set) Token: 0x0600031A RID: 794 RVA: 0x0000BB3D File Offset: 0x0000AB3D
		[Description("")]
		[Category("Title")]
		public Color TitleColor
		{
			get
			{
				return this.fTitle.Color;
			}
			set
			{
				this.fTitle.Color = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0000BB4B File Offset: 0x0000AB4B
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0000BB53 File Offset: 0x0000AB53
		[Description("Title offset alone X axis")]
		[Category("Title")]
		public int TitleOffsetX
		{
			get
			{
				return this.fTitleOffsetX;
			}
			set
			{
				this.fTitleOffsetX = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000BB5C File Offset: 0x0000AB5C
		// (set) Token: 0x0600031E RID: 798 RVA: 0x0000BB64 File Offset: 0x0000AB64
		[Category("Title")]
		[Description("Title offset alone Y axis")]
		public int TitleOffsetY
		{
			get
			{
				return this.fTitleOffsetY;
			}
			set
			{
				this.fTitleOffsetY = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0000BB6D File Offset: 0x0000AB6D
		// (set) Token: 0x06000320 RID: 800 RVA: 0x0000BB7A File Offset: 0x0000AB7A
		[Category("Title")]
		[Description("")]
		public ETitlePosition TitlePosition
		{
			get
			{
				return this.fTitle.Position;
			}
			set
			{
				this.fTitle.Position = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000BB88 File Offset: 0x0000AB88
		// (set) Token: 0x06000322 RID: 802 RVA: 0x0000BB95 File Offset: 0x0000AB95
		[Description("")]
		[Category("Title")]
		public ETitleStrategy TitleStrategy
		{
			get
			{
				return this.fTitle.Strategy;
			}
			set
			{
				this.fTitle.Strategy = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000BBA3 File Offset: 0x0000ABA3
		// (set) Token: 0x06000324 RID: 804 RVA: 0x0000BBAB File Offset: 0x0000ABAB
		[Category("Color")]
		[Description("")]
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000BBB4 File Offset: 0x0000ABB4
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0000BBBC File Offset: 0x0000ABBC
		[Description("")]
		[Category("Color")]
		public Color ForeColor
		{
			get
			{
				return this.fForeColor;
			}
			set
			{
				this.fForeColor = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000BBC5 File Offset: 0x0000ABC5
		// (set) Token: 0x06000328 RID: 808 RVA: 0x0000BBCD File Offset: 0x0000ABCD
		[Browsable(false)]
		public ArrayList Primitives
		{
			get
			{
				return this.fPrimitives;
			}
			set
			{
				this.fPrimitives = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000BBD6 File Offset: 0x0000ABD6
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0000BBDE File Offset: 0x0000ABDE
		[Browsable(false)]
		public Graphics Graphics
		{
			get
			{
				return this.fGraphics;
			}
			set
			{
				this.fGraphics = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0000BBE7 File Offset: 0x0000ABE7
		[Browsable(false)]
		public Axis AxisLeft
		{
			get
			{
				return this.fAxisLeft;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000BBEF File Offset: 0x0000ABEF
		[Browsable(false)]
		public Axis AxisRight
		{
			get
			{
				return this.fAxisRight;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0000BBF7 File Offset: 0x0000ABF7
		[Browsable(false)]
		public Axis AxisTop
		{
			get
			{
				return this.fAxisTop;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000BBFF File Offset: 0x0000ABFF
		[Browsable(false)]
		public Axis AxisBottom
		{
			get
			{
				return this.fAxisBottom;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000BC07 File Offset: 0x0000AC07
		// (set) Token: 0x06000330 RID: 816 RVA: 0x0000BC14 File Offset: 0x0000AC14
		[Description("")]
		[Category("Grid")]
		public bool XGridEnabled
		{
			get
			{
				return this.fAxisLeft.GridEnabled;
			}
			set
			{
				this.fAxisLeft.GridEnabled = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000BC22 File Offset: 0x0000AC22
		// (set) Token: 0x06000332 RID: 818 RVA: 0x0000BC2F File Offset: 0x0000AC2F
		[Category("Grid")]
		[Description("")]
		public bool YGridEnabled
		{
			get
			{
				return this.fAxisBottom.GridEnabled;
			}
			set
			{
				this.fAxisBottom.GridEnabled = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0000BC3D File Offset: 0x0000AC3D
		// (set) Token: 0x06000334 RID: 820 RVA: 0x0000BC4A File Offset: 0x0000AC4A
		[Description("")]
		[Category("Grid")]
		public float XGridWidth
		{
			get
			{
				return this.fAxisLeft.GridWidth;
			}
			set
			{
				this.fAxisLeft.GridWidth = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0000BC58 File Offset: 0x0000AC58
		// (set) Token: 0x06000336 RID: 822 RVA: 0x0000BC65 File Offset: 0x0000AC65
		[Category("Grid")]
		[Description("")]
		public float YGridWidth
		{
			get
			{
				return this.fAxisBottom.GridWidth;
			}
			set
			{
				this.fAxisBottom.GridWidth = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000337 RID: 823 RVA: 0x0000BC73 File Offset: 0x0000AC73
		// (set) Token: 0x06000338 RID: 824 RVA: 0x0000BC80 File Offset: 0x0000AC80
		[Description("")]
		[Category("Grid")]
		public Color XGridColor
		{
			get
			{
				return this.fAxisLeft.GridColor;
			}
			set
			{
				this.fAxisLeft.GridColor = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0000BC8E File Offset: 0x0000AC8E
		// (set) Token: 0x0600033A RID: 826 RVA: 0x0000BC9B File Offset: 0x0000AC9B
		[Category("Grid")]
		[Description("")]
		public Color YGridColor
		{
			get
			{
				return this.fAxisBottom.GridColor;
			}
			set
			{
				this.fAxisBottom.GridColor = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0000BCA9 File Offset: 0x0000ACA9
		// (set) Token: 0x0600033C RID: 828 RVA: 0x0000BCB6 File Offset: 0x0000ACB6
		[Category("Grid")]
		[Description("")]
		public DashStyle XGridDashStyle
		{
			get
			{
				return this.fAxisLeft.GridDashStyle;
			}
			set
			{
				this.fAxisLeft.GridDashStyle = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000BCC4 File Offset: 0x0000ACC4
		// (set) Token: 0x0600033E RID: 830 RVA: 0x0000BCD1 File Offset: 0x0000ACD1
		[Category("Grid")]
		[Description("")]
		public DashStyle YGridDashStyle
		{
			get
			{
				return this.fAxisBottom.GridDashStyle;
			}
			set
			{
				this.fAxisBottom.GridDashStyle = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0000BCDF File Offset: 0x0000ACDF
		// (set) Token: 0x06000340 RID: 832 RVA: 0x0000BCEC File Offset: 0x0000ACEC
		[Category("XAxis")]
		[Description("")]
		public EAxisType XAxisType
		{
			get
			{
				return this.fAxisBottom.Type;
			}
			set
			{
				this.fAxisBottom.Type = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000BCFA File Offset: 0x0000ACFA
		// (set) Token: 0x06000342 RID: 834 RVA: 0x0000BD07 File Offset: 0x0000AD07
		[Category("XAxis")]
		[Description("")]
		public EAxisPosition XAxisPosition
		{
			get
			{
				return this.fAxisBottom.Position;
			}
			set
			{
				this.fAxisBottom.Position = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000BD15 File Offset: 0x0000AD15
		// (set) Token: 0x06000344 RID: 836 RVA: 0x0000BD22 File Offset: 0x0000AD22
		[Description("")]
		[Category("XAxis")]
		public bool XAxisMajorTicksEnabled
		{
			get
			{
				return this.fAxisBottom.MajorTicksEnabled;
			}
			set
			{
				this.fAxisBottom.MajorTicksEnabled = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0000BD30 File Offset: 0x0000AD30
		// (set) Token: 0x06000346 RID: 838 RVA: 0x0000BD3D File Offset: 0x0000AD3D
		[Category("XAxis")]
		[Description("")]
		public bool XAxisMinorTicksEnabled
		{
			get
			{
				return this.fAxisBottom.MinorTicksEnabled;
			}
			set
			{
				this.fAxisBottom.MinorTicksEnabled = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0000BD4B File Offset: 0x0000AD4B
		// (set) Token: 0x06000348 RID: 840 RVA: 0x0000BD58 File Offset: 0x0000AD58
		[Description("")]
		[Category("XAxis")]
		public bool XAxisTitleEnabled
		{
			get
			{
				return this.fAxisBottom.TitleEnabled;
			}
			set
			{
				this.fAxisBottom.TitleEnabled = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000349 RID: 841 RVA: 0x0000BD66 File Offset: 0x0000AD66
		// (set) Token: 0x0600034A RID: 842 RVA: 0x0000BD73 File Offset: 0x0000AD73
		[Description("")]
		[Category("XAxis")]
		public string XAxisTitle
		{
			get
			{
				return this.fAxisBottom.Title;
			}
			set
			{
				this.fAxisBottom.Title = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0000BD81 File Offset: 0x0000AD81
		// (set) Token: 0x0600034C RID: 844 RVA: 0x0000BD8E File Offset: 0x0000AD8E
		[Category("XAxis")]
		[Description("")]
		public Font XAxisTitleFont
		{
			get
			{
				return this.fAxisBottom.TitleFont;
			}
			set
			{
				this.fAxisBottom.TitleFont = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600034D RID: 845 RVA: 0x0000BD9C File Offset: 0x0000AD9C
		// (set) Token: 0x0600034E RID: 846 RVA: 0x0000BDA9 File Offset: 0x0000ADA9
		[Category("XAxis")]
		[Description("")]
		public Color XAxisTitleColor
		{
			get
			{
				return this.fAxisBottom.TitleColor;
			}
			set
			{
				this.fAxisBottom.TitleColor = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0000BDB7 File Offset: 0x0000ADB7
		// (set) Token: 0x06000350 RID: 848 RVA: 0x0000BDC4 File Offset: 0x0000ADC4
		[Category("XAxis")]
		[Description("")]
		public int XAxisTitleOffset
		{
			get
			{
				return this.fAxisBottom.TitleOffset;
			}
			set
			{
				this.fAxisBottom.TitleOffset = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000BDD2 File Offset: 0x0000ADD2
		// (set) Token: 0x06000352 RID: 850 RVA: 0x0000BDDF File Offset: 0x0000ADDF
		[Description("")]
		[Category("XAxis")]
		public EAxisTitlePosition XAxisTitlePosition
		{
			get
			{
				return this.fAxisBottom.TitlePosition;
			}
			set
			{
				this.fAxisBottom.TitlePosition = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000BDED File Offset: 0x0000ADED
		// (set) Token: 0x06000354 RID: 852 RVA: 0x0000BDFA File Offset: 0x0000ADFA
		[Category("XAxis")]
		[Description("")]
		public bool XAxisLabelEnabled
		{
			get
			{
				return this.fAxisBottom.LabelEnabled;
			}
			set
			{
				this.fAxisBottom.LabelEnabled = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0000BE08 File Offset: 0x0000AE08
		// (set) Token: 0x06000356 RID: 854 RVA: 0x0000BE15 File Offset: 0x0000AE15
		[Description("")]
		[Category("XAxis")]
		public Font XAxisLabelFont
		{
			get
			{
				return this.fAxisBottom.LabelFont;
			}
			set
			{
				this.fAxisBottom.LabelFont = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0000BE23 File Offset: 0x0000AE23
		// (set) Token: 0x06000358 RID: 856 RVA: 0x0000BE30 File Offset: 0x0000AE30
		[Category("XAxis")]
		[Description("")]
		public Color XAxisLabelColor
		{
			get
			{
				return this.fAxisBottom.LabelColor;
			}
			set
			{
				this.fAxisBottom.LabelColor = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000BE3E File Offset: 0x0000AE3E
		// (set) Token: 0x0600035A RID: 858 RVA: 0x0000BE4B File Offset: 0x0000AE4B
		[Category("XAxis")]
		[Description("")]
		public int XAxisLabelOffset
		{
			get
			{
				return this.fAxisBottom.LabelOffset;
			}
			set
			{
				this.fAxisBottom.LabelOffset = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0000BE59 File Offset: 0x0000AE59
		// (set) Token: 0x0600035C RID: 860 RVA: 0x0000BE66 File Offset: 0x0000AE66
		[Description("")]
		[Category("XAxis")]
		public string XAxisLabelFormat
		{
			get
			{
				return this.fAxisBottom.LabelFormat;
			}
			set
			{
				this.fAxisBottom.LabelFormat = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000BE74 File Offset: 0x0000AE74
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0000BE81 File Offset: 0x0000AE81
		[Category("XAxis")]
		[Description("")]
		public EAxisLabelAlignment XAxisLabelAlignment
		{
			get
			{
				return this.fAxisBottom.LabelAlignment;
			}
			set
			{
				this.fAxisBottom.LabelAlignment = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0000BE8F File Offset: 0x0000AE8F
		// (set) Token: 0x06000360 RID: 864 RVA: 0x0000BE9C File Offset: 0x0000AE9C
		[Category("YAxis")]
		[Description("")]
		public EAxisType YAxisType
		{
			get
			{
				return this.fAxisLeft.Type;
			}
			set
			{
				this.fAxisLeft.Type = value;
				this.fAxisRight.Type = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0000BEB6 File Offset: 0x0000AEB6
		// (set) Token: 0x06000362 RID: 866 RVA: 0x0000BEC3 File Offset: 0x0000AEC3
		[Description("")]
		[Category("YAxis")]
		public EAxisPosition YAxisPosition
		{
			get
			{
				return this.fAxisLeft.Position;
			}
			set
			{
				this.fAxisLeft.Position = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0000BED1 File Offset: 0x0000AED1
		// (set) Token: 0x06000364 RID: 868 RVA: 0x0000BEDE File Offset: 0x0000AEDE
		[Category("YAxis")]
		[Description("")]
		public bool YAxisMajorTicksEnabled
		{
			get
			{
				return this.fAxisLeft.MajorTicksEnabled;
			}
			set
			{
				this.fAxisLeft.MajorTicksEnabled = value;
				this.fAxisRight.MajorTicksEnabled = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0000BEF8 File Offset: 0x0000AEF8
		// (set) Token: 0x06000366 RID: 870 RVA: 0x0000BF05 File Offset: 0x0000AF05
		[Category("YAxis")]
		[Description("")]
		public bool YAxisMinorTicksEnabled
		{
			get
			{
				return this.fAxisLeft.MinorTicksEnabled;
			}
			set
			{
				this.fAxisLeft.MinorTicksEnabled = value;
				this.fAxisRight.MinorTicksEnabled = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0000BF1F File Offset: 0x0000AF1F
		// (set) Token: 0x06000368 RID: 872 RVA: 0x0000BF2C File Offset: 0x0000AF2C
		[Description("")]
		[Category("YAxis")]
		public bool YAxisTitleEnabled
		{
			get
			{
				return this.fAxisLeft.TitleEnabled;
			}
			set
			{
				this.fAxisLeft.TitleEnabled = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000BF3A File Offset: 0x0000AF3A
		// (set) Token: 0x0600036A RID: 874 RVA: 0x0000BF47 File Offset: 0x0000AF47
		[Category("YAxis")]
		[Description("")]
		public string YAxisTitle
		{
			get
			{
				return this.fAxisLeft.Title;
			}
			set
			{
				this.fAxisLeft.Title = value;
				this.fAxisRight.Title = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0000BF61 File Offset: 0x0000AF61
		// (set) Token: 0x0600036C RID: 876 RVA: 0x0000BF6E File Offset: 0x0000AF6E
		[Description("")]
		[Category("YAxis")]
		public Font YAxisTitleFont
		{
			get
			{
				return this.fAxisLeft.TitleFont;
			}
			set
			{
				this.fAxisLeft.TitleFont = value;
				this.fAxisRight.TitleFont = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000BF88 File Offset: 0x0000AF88
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0000BF95 File Offset: 0x0000AF95
		[Category("YAxis")]
		[Description("")]
		public Color YAxisTitleColor
		{
			get
			{
				return this.fAxisLeft.TitleColor;
			}
			set
			{
				this.fAxisLeft.TitleColor = value;
				this.fAxisRight.TitleColor = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000BFAF File Offset: 0x0000AFAF
		// (set) Token: 0x06000370 RID: 880 RVA: 0x0000BFBC File Offset: 0x0000AFBC
		[Description("")]
		[Category("YAxis")]
		public int YAxisTitleOffset
		{
			get
			{
				return this.fAxisLeft.TitleOffset;
			}
			set
			{
				this.fAxisLeft.TitleOffset = value;
				this.fAxisRight.TitleOffset = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0000BFD6 File Offset: 0x0000AFD6
		// (set) Token: 0x06000372 RID: 882 RVA: 0x0000BFE3 File Offset: 0x0000AFE3
		[Description("")]
		[Category("YAxis")]
		public EAxisTitlePosition YAxisTitlePosition
		{
			get
			{
				return this.fAxisLeft.TitlePosition;
			}
			set
			{
				this.fAxisLeft.TitlePosition = value;
				this.fAxisRight.TitlePosition = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0000BFFD File Offset: 0x0000AFFD
		// (set) Token: 0x06000374 RID: 884 RVA: 0x0000C00A File Offset: 0x0000B00A
		[Category("YAxis")]
		[Description("")]
		public bool YAxisLabelEnabled
		{
			get
			{
				return this.fAxisLeft.LabelEnabled;
			}
			set
			{
				this.fAxisLeft.LabelEnabled = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0000C018 File Offset: 0x0000B018
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0000C025 File Offset: 0x0000B025
		[Description("")]
		[Category("YAxis")]
		public Font YAxisLabelFont
		{
			get
			{
				return this.fAxisLeft.LabelFont;
			}
			set
			{
				this.fAxisLeft.LabelFont = value;
				this.fAxisRight.LabelFont = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000C03F File Offset: 0x0000B03F
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0000C04C File Offset: 0x0000B04C
		[Category("YAxis")]
		[Description("")]
		public Color YAxisLabelColor
		{
			get
			{
				return this.fAxisLeft.LabelColor;
			}
			set
			{
				this.fAxisLeft.LabelColor = value;
				this.fAxisRight.LabelColor = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0000C066 File Offset: 0x0000B066
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0000C073 File Offset: 0x0000B073
		[Description("")]
		[Category("YAxis")]
		public int YAxisLabelOffset
		{
			get
			{
				return this.fAxisLeft.LabelOffset;
			}
			set
			{
				this.fAxisLeft.LabelOffset = value;
				this.fAxisRight.LabelOffset = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0000C08D File Offset: 0x0000B08D
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0000C09A File Offset: 0x0000B09A
		[Description("")]
		[Category("YAxis")]
		public string YAxisLabelFormat
		{
			get
			{
				return this.fAxisLeft.LabelFormat;
			}
			set
			{
				this.fAxisLeft.LabelFormat = value;
				this.fAxisRight.LabelFormat = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0000C0B4 File Offset: 0x0000B0B4
		// (set) Token: 0x0600037E RID: 894 RVA: 0x0000C0C1 File Offset: 0x0000B0C1
		[Category("YAxis")]
		[Description("")]
		public EAxisLabelAlignment YAxisLabelAlignment
		{
			get
			{
				return this.fAxisLeft.LabelAlignment;
			}
			set
			{
				this.fAxisLeft.LabelAlignment = value;
				this.fAxisRight.LabelAlignment = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000C0DB File Offset: 0x0000B0DB
		[Browsable(false)]
		public TLegend Legend
		{
			get
			{
				return this.fLegend;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000C0E3 File Offset: 0x0000B0E3
		// (set) Token: 0x06000381 RID: 897 RVA: 0x0000C0EB File Offset: 0x0000B0EB
		[Description("")]
		[Category("Legend")]
		public bool LegendEnabled
		{
			get
			{
				return this.fLegendEnabled;
			}
			set
			{
				this.fLegendEnabled = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000C0F4 File Offset: 0x0000B0F4
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0000C0FC File Offset: 0x0000B0FC
		[Description("")]
		[Category("Legend")]
		public ELegendPosition LegendPosition
		{
			get
			{
				return this.fLegendPosition;
			}
			set
			{
				this.fLegendPosition = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000C105 File Offset: 0x0000B105
		// (set) Token: 0x06000385 RID: 901 RVA: 0x0000C10D File Offset: 0x0000B10D
		[Category("Legend")]
		[Description("")]
		public int LegendOffsetX
		{
			get
			{
				return this.fLegendOffsetX;
			}
			set
			{
				this.fLegendOffsetX = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000C116 File Offset: 0x0000B116
		// (set) Token: 0x06000387 RID: 903 RVA: 0x0000C11E File Offset: 0x0000B11E
		[Description("")]
		[Category("Legend")]
		public int LegendOffsetY
		{
			get
			{
				return this.fLegendOffsetY;
			}
			set
			{
				this.fLegendOffsetY = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0000C127 File Offset: 0x0000B127
		// (set) Token: 0x06000389 RID: 905 RVA: 0x0000C134 File Offset: 0x0000B134
		[Description("")]
		[Category("Legend")]
		public bool LegendBorderEnabled
		{
			get
			{
				return this.fLegend.BorderEnabled;
			}
			set
			{
				this.fLegend.BorderEnabled = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0000C142 File Offset: 0x0000B142
		// (set) Token: 0x0600038B RID: 907 RVA: 0x0000C14F File Offset: 0x0000B14F
		[Category("Legend")]
		[Description("")]
		public Color LegendBorderColor
		{
			get
			{
				return this.fLegend.BorderColor;
			}
			set
			{
				this.fLegend.BorderColor = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000C15D File Offset: 0x0000B15D
		// (set) Token: 0x0600038D RID: 909 RVA: 0x0000C16A File Offset: 0x0000B16A
		[Description("")]
		[Category("Legend")]
		public Color LegendBackColor
		{
			get
			{
				return this.fLegend.BackColor;
			}
			set
			{
				this.fLegend.BackColor = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000C178 File Offset: 0x0000B178
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0000C180 File Offset: 0x0000B180
		[Category("Border")]
		[Description("")]
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

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000C189 File Offset: 0x0000B189
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0000C191 File Offset: 0x0000B191
		[Description("")]
		[Category("Border")]
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0000C19A File Offset: 0x0000B19A
		// (set) Token: 0x06000393 RID: 915 RVA: 0x0000C1A2 File Offset: 0x0000B1A2
		[Description("")]
		[Category("Border")]
		public int BorderWidth
		{
			get
			{
				return this.fBorderWidth;
			}
			set
			{
				this.fBorderWidth = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0000C1AB File Offset: 0x0000B1AB
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0000C1B3 File Offset: 0x0000B1B3
		[Description("")]
		[Category("Mouse")]
		public bool MouseZoomEnabled
		{
			get
			{
				return this.fMouseZoomEnabled;
			}
			set
			{
				this.fMouseZoomEnabled = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000C1BC File Offset: 0x0000B1BC
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0000C1C4 File Offset: 0x0000B1C4
		[Category("Mouse")]
		[Description("")]
		public bool MouseZoomXAxisEnabled
		{
			get
			{
				return this.fMouseZoomXAxisEnabled;
			}
			set
			{
				this.fMouseZoomXAxisEnabled = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0000C1CD File Offset: 0x0000B1CD
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000C1D5 File Offset: 0x0000B1D5
		[Category("Mouse")]
		[Description("")]
		public bool MouseZoomYAxisEnabled
		{
			get
			{
				return this.fMouseZoomYAxisEnabled;
			}
			set
			{
				this.fMouseZoomYAxisEnabled = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000C1DE File Offset: 0x0000B1DE
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0000C1E6 File Offset: 0x0000B1E6
		[Category("Mouse")]
		[Description("")]
		public bool MouseUnzoomEnabled
		{
			get
			{
				return this.fMouseUnzoomEnabled;
			}
			set
			{
				this.fMouseUnzoomEnabled = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000C1EF File Offset: 0x0000B1EF
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0000C1F7 File Offset: 0x0000B1F7
		[Description("")]
		[Category("Mouse")]
		public bool MouseUnzoomXAxisEnabled
		{
			get
			{
				return this.fMouseUnzoomXAxisEnabled;
			}
			set
			{
				this.fMouseUnzoomXAxisEnabled = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0000C200 File Offset: 0x0000B200
		// (set) Token: 0x0600039F RID: 927 RVA: 0x0000C208 File Offset: 0x0000B208
		[Category("Mouse")]
		[Description("")]
		public bool MouseUnzoomYAxisEnabled
		{
			get
			{
				return this.fMouseUnzoomYAxisEnabled;
			}
			set
			{
				this.fMouseUnzoomYAxisEnabled = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0000C211 File Offset: 0x0000B211
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x0000C219 File Offset: 0x0000B219
		[Category("Mouse")]
		[Description("")]
		public bool MouseMoveContentEnabled
		{
			get
			{
				return this.fMouseMoveContentEnabled;
			}
			set
			{
				this.fMouseMoveContentEnabled = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000C222 File Offset: 0x0000B222
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x0000C22A File Offset: 0x0000B22A
		[Category("Mouse")]
		[Description("")]
		public bool MouseMovePrimitiveEnabled
		{
			get
			{
				return this.fMouseMovePrimitiveEnabled;
			}
			set
			{
				this.fMouseMovePrimitiveEnabled = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0000C233 File Offset: 0x0000B233
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0000C23B File Offset: 0x0000B23B
		[Description("")]
		[Category("Mouse")]
		public bool MouseDeletePrimitiveEnabled
		{
			get
			{
				return this.fMouseDeletePrimitiveEnabled;
			}
			set
			{
				this.fMouseDeletePrimitiveEnabled = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0000C244 File Offset: 0x0000B244
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x0000C24C File Offset: 0x0000B24C
		[Description("")]
		[Category("Mouse")]
		public bool MousePadPropertiesEnabled
		{
			get
			{
				return this.fMousePadPropertiesEnabled;
			}
			set
			{
				this.fMousePadPropertiesEnabled = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000C255 File Offset: 0x0000B255
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x0000C25D File Offset: 0x0000B25D
		[Category("Mouse")]
		[Description("")]
		public bool MousePrimitivePropertiesEnabled
		{
			get
			{
				return this.fMousePrimitivePropertiesEnabled;
			}
			set
			{
				this.fMousePrimitivePropertiesEnabled = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000C266 File Offset: 0x0000B266
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0000C26E File Offset: 0x0000B26E
		[Category("Mouse")]
		[Description("")]
		public bool MouseContextMenuEnabled
		{
			get
			{
				return this.fMouseContextMenuEnabled;
			}
			set
			{
				this.fMouseContextMenuEnabled = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000C277 File Offset: 0x0000B277
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0000C27F File Offset: 0x0000B27F
		[Category("Mouse")]
		[Description("Enable or disable mouse wheel")]
		public bool MouseWheelEnabled
		{
			get
			{
				return this.fMouseWheelEnabled;
			}
			set
			{
				this.fMouseWheelEnabled = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0000C288 File Offset: 0x0000B288
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0000C290 File Offset: 0x0000B290
		[Description("")]
		[Category("Mouse")]
		public double MouseWheelSensitivity
		{
			get
			{
				return this.fMouseWheelSensitivity;
			}
			set
			{
				this.fMouseWheelSensitivity = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000C299 File Offset: 0x0000B299
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0000C2A1 File Offset: 0x0000B2A1
		[Category("Mouse")]
		[Description("")]
		public EMouseWheelMode MouseWheelMode
		{
			get
			{
				return this.fMouseWheelMode;
			}
			set
			{
				this.fMouseWheelMode = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000C2AA File Offset: 0x0000B2AA
		[Browsable(false)]
		public IChartTransformation Transformation
		{
			get
			{
				return this.fTransformation;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000C2B2 File Offset: 0x0000B2B2
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x0000C2BC File Offset: 0x0000B2BC
		[Category("Transformation")]
		[Description("")]
		public ETransformationType TransformationType
		{
			get
			{
				return this.fTransformationType;
			}
			set
			{
				this.fTransformationType = value;
				double num = this.fXMin + this.CalculateRealQuantityOfTicks_Right(this.fXMin, this.fXMax);
				double num2 = this.fAxisBottom.Min + this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Max);
				if (this.fTransformationType == ETransformationType.Empty)
				{
					this.fTransformation = new TEmptyTransformation();
				}
				if (this.fTransformationType == ETransformationType.Intraday)
				{
					this.fTransformation = new TIntradayTransformation();
				}
				this.fXMax = num - this.CalculateNotInSessionTicks(this.fXMin, num);
				this.fAxisBottom.Max = num2 - this.CalculateNotInSessionTicks(this.fAxisBottom.Min, num2);
				this.Update();
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000C374 File Offset: 0x0000B374
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x0000C391 File Offset: 0x0000B391
		[Description("")]
		[Category("Transformation")]
		public bool SessionGridEnabled
		{
			get
			{
				return this.fTransformationType == ETransformationType.Intraday && ((TIntradayTransformation)this.Transformation).SessionGridEnabled;
			}
			set
			{
				if (this.fTransformationType == ETransformationType.Intraday)
				{
					((TIntradayTransformation)this.Transformation).SessionGridEnabled = value;
				}
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0000C3AD File Offset: 0x0000B3AD
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x0000C3B5 File Offset: 0x0000B3B5
		[Description("")]
		[Category("Transformation")]
		public Color SessionGridColor
		{
			get
			{
				return this.fSessionGridColor;
			}
			set
			{
				this.fSessionGridColor = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0000C3BE File Offset: 0x0000B3BE
		// (set) Token: 0x060003BA RID: 954 RVA: 0x0000C3E8 File Offset: 0x0000B3E8
		[Description("")]
		[Category("Transformation")]
		public TimeSpan SessionStart
		{
			get
			{
				if (this.fTransformationType == ETransformationType.Intraday)
				{
					return new TimeSpan(((TIntradayTransformation)this.fTransformation).FirstSessionTick);
				}
				return new TimeSpan(0, 0, 0, 0);
			}
			set
			{
				double num = this.fXMin + this.CalculateRealQuantityOfTicks_Right(this.fXMin, this.fXMax);
				double num2 = this.fAxisBottom.Min + this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Max);
				if (this.fTransformationType == ETransformationType.Intraday)
				{
					((TIntradayTransformation)this.fTransformation).FirstSessionTick = value.Ticks;
				}
				this.fXMax = num - this.CalculateNotInSessionTicks(this.fXMin, num);
				this.fAxisBottom.Max = num2 - this.CalculateNotInSessionTicks(this.fAxisBottom.Min, num2);
				this.Update();
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0000C492 File Offset: 0x0000B492
		// (set) Token: 0x060003BC RID: 956 RVA: 0x0000C4C0 File Offset: 0x0000B4C0
		[Category("Transformation")]
		[Description("")]
		public TimeSpan SessionEnd
		{
			get
			{
				if (this.fTransformationType == ETransformationType.Intraday)
				{
					return new TimeSpan(((TIntradayTransformation)this.fTransformation).LastSessionTick);
				}
				return new TimeSpan(0, 24, 0, 0);
			}
			set
			{
				double num = this.fXMin + this.CalculateRealQuantityOfTicks_Right(this.fXMin, this.fXMax);
				double num2 = this.fAxisBottom.Min + this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Max);
				if (this.fTransformationType == ETransformationType.Intraday)
				{
					((TIntradayTransformation)this.fTransformation).LastSessionTick = value.Ticks;
				}
				this.fXMax = num - this.CalculateNotInSessionTicks(this.fXMin, num);
				this.fAxisBottom.Max = num2 - this.CalculateNotInSessionTicks(this.fAxisBottom.Min, num2);
				this.Update();
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000C56A File Offset: 0x0000B56A
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0000C574 File Offset: 0x0000B574
		[Browsable(false)]
		public bool Monitored
		{
			get
			{
				return this.fMonitored;
			}
			set
			{
				this.fMonitored = value;
				if (this.fMonitored)
				{
					Pad.NewTick = (NewTickEventHandler)Delegate.Combine(Pad.NewTick, new NewTickEventHandler(this.OnNewTick));
					return;
				}
				Pad.NewTick = (NewTickEventHandler)Delegate.Remove(Pad.NewTick, new NewTickEventHandler(this.OnNewTick));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000C5D1 File Offset: 0x0000B5D1
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x0000C5D9 File Offset: 0x0000B5D9
		[Browsable(false)]
		public int WindowSize
		{
			get
			{
				return this.fWindowSize;
			}
			set
			{
				this.fWindowSize = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000C5E2 File Offset: 0x0000B5E2
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x0000C5EA File Offset: 0x0000B5EA
		[Browsable(false)]
		public int UpdateInterval
		{
			get
			{
				return this.fUpdateInterval;
			}
			set
			{
				this.fUpdateInterval = value;
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000C5F3 File Offset: 0x0000B5F3
		public void ResetLastTickTime()
		{
			this.fLastTickTime = 0;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000C5FC File Offset: 0x0000B5FC
		public void Init()
		{
			this.fPrimitives = new ArrayList();
			Chart.Pad = this;
			this.Features3D = new Pad.TFeatures3D(this);
			this.fBackColor = Color.LightGray;
			this.fForeColor = Color.White;
			this.fX1 = 0;
			this.fX2 = 1;
			this.fY1 = 0;
			this.fY2 = 1;
			this.fWidth = this.fChart.ClientSize.Width;
			this.fHeight = this.fChart.ClientSize.Height;
			this.fClientX = 10;
			this.fClientY = 10;
			this.fClientWidth = 0;
			this.fClientHeight = 0;
			this.fMarginLeft = 10;
			this.fMarginRight = 20;
			this.fMarginTop = 10;
			this.fMarginBottom = 10;
			this.fTitle = new TTitle(this, "");
			this.fTitleEnabled = true;
			this.fTitleOffsetX = 5;
			this.fTitleOffsetY = 5;
			this.fTransformation = new TIntradayTransformation();
			this.fTransformationType = ETransformationType.Empty;
			this.fSessionGridColor = Color.Blue;
			this.fAxisLeft = new Axis(this, EAxisPosition.Left);
			this.fAxisRight = new Axis(this, EAxisPosition.Right);
			this.fAxisTop = new Axis(this, EAxisPosition.Top);
			this.fAxisBottom = new Axis(this, EAxisPosition.Bottom);
			this.fAxisRight.LabelEnabled = false;
			this.fAxisRight.TitleEnabled = false;
			this.fAxisTop.LabelEnabled = false;
			this.fAxisTop.TitleEnabled = false;
			this.fLegend = new TLegend(this);
			this.fLegendEnabled = false;
			this.fLegendPosition = ELegendPosition.TopRight;
			this.fLegendOffsetX = 5;
			this.fLegendOffsetY = 5;
			this.fBorderEnabled = true;
			this.fBorderColor = Color.Black;
			this.fBorderWidth = 1;
			this.SetRange(0.0, 100.0, 0.0, 100.0);
			this.fGraphics = null;
			this.fOnAxis = false;
			this.fOnPrimitive = false;
			this.fMouseDown = false;
			this.fMouseDownX = 0;
			this.fMouseDownY = 0;
			this.fOutlineEnabled = false;
			this.fWindowSize = 600;
			this.fLastTickTime = 0;
			this.fUpdateInterval = 1;
			this.fLastUpdateDateTime = DateTime.Now;
			this.Monitored = false;
			this.fUpdating = false;
			this.fMouseZoomEnabled = true;
			this.fMouseZoomXAxisEnabled = true;
			this.fMouseZoomYAxisEnabled = true;
			this.fMouseUnzoomEnabled = true;
			this.fMouseUnzoomXAxisEnabled = true;
			this.fMouseUnzoomYAxisEnabled = true;
			this.fMouseMoveContentEnabled = true;
			this.fMouseMovePrimitiveEnabled = true;
			this.fMouseDeletePrimitiveEnabled = true;
			this.fMousePadPropertiesEnabled = true;
			this.fMousePrimitivePropertiesEnabled = true;
			this.fMouseContextMenuEnabled = true;
			this.fMouseWheelEnabled = true;
			this.fMouseWheelSensitivity = 0.1;
			this.fMouseWheelMode = EMouseWheelMode.ZoomX;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000C8B0 File Offset: 0x0000B8B0
		private void InitContextMenu()
		{
			if (this.PrimitiveContextMenu == null)
			{
				this.PrimitiveContextMenu = new ContextMenu();
				this.DeleteMenuItem = new MenuItem();
				this.PropertiesMenuItem = new MenuItem();
				MenuItem menuItem = new MenuItem();
				this.PrimitiveContextMenu.MenuItems.AddRange(new MenuItem[]
				{
					this.DeleteMenuItem,
					menuItem,
					this.PropertiesMenuItem
				});
				this.DeleteMenuItem.Index = 0;
				this.DeleteMenuItem.Text = "Delete";
				this.DeleteMenuItem.Click += this.DeleteMenuItem_Click;
				menuItem.Index = 1;
				menuItem.Text = "-";
				this.PropertiesMenuItem.Index = 2;
				this.PropertiesMenuItem.Text = "Properties";
				this.PropertiesMenuItem.Click += this.PropertiesMenuItem_Click;
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000C995 File Offset: 0x0000B995
		public Pad()
		{
			this.Init();
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000C9A3 File Offset: 0x0000B9A3
		public Pad(Chart Chart)
		{
			this.fChart = Chart;
			this.Init();
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000C9B8 File Offset: 0x0000B9B8
		public Pad(Chart Chart, double X1, double Y1, double X2, double Y2)
		{
			this.fChart = Chart;
			this.fCanvasX1 = X1;
			this.fCanvasX2 = X2;
			this.fCanvasY1 = Y1;
			this.fCanvasY2 = Y2;
			this.Init();
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000C9EB File Offset: 0x0000B9EB
		public virtual void SetCanvas(double X1, double Y1, double X2, double Y2, int Width, int Height)
		{
			this.fCanvasX1 = X1;
			this.fCanvasX2 = X2;
			this.fCanvasY1 = Y1;
			this.fCanvasY2 = Y2;
			this.SetCanvas(Width, Height);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000CA14 File Offset: 0x0000BA14
		public virtual void SetCanvas(double X1, double Y1, double X2, double Y2)
		{
			this.fCanvasX1 = X1;
			this.fCanvasX2 = X2;
			this.fCanvasY1 = Y1;
			this.fCanvasY2 = Y2;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000CA34 File Offset: 0x0000BA34
		public virtual void SetCanvas(int Width, int Height)
		{
			this.fX1 = (int)((double)Width * this.fCanvasX1);
			this.fX2 = (int)((double)Width * this.fCanvasX2);
			this.fY1 = (int)((double)Height * this.fCanvasY1);
			this.fY2 = (int)((double)Height * this.fCanvasY2);
			this.fWidth = this.fX2 - this.fX1;
			this.fHeight = this.fY2 - this.fY1;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000CAA8 File Offset: 0x0000BAA8
		public void SetRangeX(double XMin, double XMax)
		{
			this.fXMin = XMin;
			this.fXMax = XMax - this.CalculateNotInSessionTicks(XMin, XMax);
			this.fAxisBottom.SetRange(this.fXMin, this.fXMax);
			this.fAxisTop.SetRange(this.fXMin, this.fXMax);
			this.Features3D.SetRangeX(this.fXMin, this.fXMax);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000CB11 File Offset: 0x0000BB11
		public void SetRangeX(DateTime XMin, DateTime XMax)
		{
			this.SetRangeX((double)XMin.Ticks, (double)XMax.Ticks);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000CB2C File Offset: 0x0000BB2C
		public void SetRangeY(double YMin, double YMax)
		{
			this.fYMin = YMin;
			this.fYMax = YMax;
			this.fAxisLeft.SetRange(this.fYMin, this.fYMax);
			this.fAxisRight.SetRange(this.fYMin, this.fYMax);
			this.Features3D.SetRangeY(this.fYMin, this.fYMax);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000CB8C File Offset: 0x0000BB8C
		public void SetRange(double XMin, double XMax, double YMin, double YMax)
		{
			this.fXMin = XMin;
			this.fXMax = XMax - this.CalculateNotInSessionTicks(XMin, XMax);
			this.fYMin = YMin;
			this.fYMax = YMax;
			this.fAxisBottom.SetRange(this.fXMin, this.fXMax);
			this.fAxisTop.SetRange(this.fXMin, this.fXMax);
			this.fAxisLeft.SetRange(this.fYMin, this.fYMax);
			this.fAxisRight.SetRange(this.fYMin, this.fYMax);
			this.Features3D.SetRange(this.fXMin, this.fXMax, this.fYMin, this.fYMax);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000CC3E File Offset: 0x0000BC3E
		public void SetRange(DateTime XMin, DateTime XMax, double YMin, double YMax)
		{
			this.SetRange((double)XMin.Ticks, (double)XMax.Ticks, YMin, YMax);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000CC5C File Offset: 0x0000BC5C
		public void SetRange(string XMin, string XMax, double YMin, double YMax)
		{
			this.SetRange((double)DateTime.Parse(XMin).Ticks, (double)DateTime.Parse(XMax).Ticks, YMin, YMax);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000CC90 File Offset: 0x0000BC90
		public bool IsInRange(double X, double Y)
		{
			return X >= this.XMin && X <= this.XMin + this.CalculateRealQuantityOfTicks_Right(this.XMin, this.XMax) && Y >= this.YMin && Y <= this.YMax;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000CCCC File Offset: 0x0000BCCC
		public void UnZoomX()
		{
			this.fAxisBottom.UnZoom();
			this.fAxisTop.UnZoom();
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000CCE4 File Offset: 0x0000BCE4
		public void UnZoomY()
		{
			this.fAxisLeft.UnZoom();
			this.fAxisRight.UnZoom();
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000CCFC File Offset: 0x0000BCFC
		public void UnZoom()
		{
			this.fAxisBottom.SetRange(this.fXMin, this.fXMax);
			this.fAxisTop.SetRange(this.fXMin, this.fXMax);
			this.fAxisLeft.SetRange(this.fYMin, this.fYMax);
			this.fAxisRight.SetRange(this.fYMin, this.fYMax);
			this.fAxisBottom.Zoomed = false;
			this.fAxisTop.Zoomed = false;
			this.fAxisLeft.Zoomed = false;
			this.fAxisRight.Zoomed = false;
			if (!this.fChart.GroupZoomEnabled)
			{
				this.Update();
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000CDA8 File Offset: 0x0000BDA8
		public double GetNextGridDivision(double FirstTick, double PrevMajor, int MajorCount, EGridSize GridSize)
		{
			return this.fTransformation.GetNextGridDivision(FirstTick, PrevMajor, MajorCount, GridSize);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000CDBA File Offset: 0x0000BDBA
		public double CalculateRealQuantityOfTicks_Right(double X, double Y)
		{
			return this.fTransformation.CalculateRealQuantityOfTicks_Right(X, Y);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000CDC9 File Offset: 0x0000BDC9
		public double CalculateRealQuantityOfTicks_Left(double X, double Y)
		{
			return this.fTransformation.CalculateRealQuantityOfTicks_Left(X, Y);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000CDD8 File Offset: 0x0000BDD8
		public void GetFirstGridDivision(ref EGridSize GridSize, ref double Min, ref double Max, ref DateTime FirstDateTime)
		{
			this.fTransformation.GetFirstGridDivision(ref GridSize, ref Min, ref Max, ref FirstDateTime);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000CDEA File Offset: 0x0000BDEA
		public double CalculateNotInSessionTicks(double X, double Y)
		{
			return this.fTransformation.CalculateNotInSessionTicks(X, Y);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000CDF9 File Offset: 0x0000BDF9
		public int ClientX(double WorldX)
		{
			return (int)((double)this.fClientX + (WorldX - this.XMin - this.CalculateNotInSessionTicks(this.XMin, WorldX)) * ((double)this.fClientWidth / (this.XMax - this.XMin)));
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000CE30 File Offset: 0x0000BE30
		public int ClientY(double WorldY)
		{
			return (int)((double)this.fClientY + (double)this.fClientHeight * (1.0 - (WorldY - this.YMin) / (this.YMax - this.YMin)));
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000CE63 File Offset: 0x0000BE63
		public int ClientX()
		{
			return this.fClientX;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000CE6B File Offset: 0x0000BE6B
		public int ClientY()
		{
			return this.fClientY;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000CE73 File Offset: 0x0000BE73
		public int ClientHeight()
		{
			return this.fClientHeight;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000CE7B File Offset: 0x0000BE7B
		public int ClientWidth()
		{
			return this.fClientWidth;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000CE84 File Offset: 0x0000BE84
		public double WorldX(int ClientX)
		{
			return this.fAxisBottom.Min + this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.XMin + (double)(ClientX - this.fClientX) / (double)this.fClientWidth * (this.XMax - this.XMin));
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000CED4 File Offset: 0x0000BED4
		public double WorldY(int ClientY)
		{
			return this.YMin + (1.0 - (double)(ClientY - this.fClientY) / (double)this.fClientHeight) * (this.YMax - this.YMin);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000CF06 File Offset: 0x0000BF06
		public void Add(IDrawable Primitive)
		{
			this.fPrimitives.Add(Primitive);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000CF15 File Offset: 0x0000BF15
		public void Remove(IDrawable Primitive)
		{
			this.fPrimitives.Remove(Primitive);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000CF23 File Offset: 0x0000BF23
		public void Clear()
		{
			this.fPrimitives.Clear();
			this.fLegend.Items.Clear();
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000CF40 File Offset: 0x0000BF40
		public static Graphics GetGraphics()
		{
			if (Chart.Pad != null)
			{
				return Chart.Pad.Graphics;
			}
			return null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000CF55 File Offset: 0x0000BF55
		public virtual void Update()
		{
			if (!this.fUpdating)
			{
				this.fUpdating = true;
				this.fChart.UpdatePads();
				this.fUpdating = false;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000CF78 File Offset: 0x0000BF78
		public virtual void Update(Graphics Graphics)
		{
			double num = double.MaxValue;
			double num2 = double.MinValue;
			double num3 = double.MaxValue;
			double num4 = double.MinValue;
			bool flag = false;
			bool flag2 = false;
			try
			{
				foreach (object obj in this.fPrimitives)
				{
					IDrawable drawable = (IDrawable)obj;
					if (drawable is IZoomable)
					{
						IZoomable zoomable = (IZoomable)drawable;
						if (zoomable.IsPadRangeX())
						{
							PadRange padRange = zoomable.GetPadRangeX(this);
							if (padRange.IsValid)
							{
								num = Math.Min(num, padRange.Min);
								num2 = Math.Max(num2, padRange.Max);
								flag = true;
							}
						}
						if (zoomable.IsPadRangeY())
						{
							double max = this.fAxisBottom.Max;
							double num5 = this.fXMax;
							this.fAxisBottom.Max = this.fAxisBottom.Min + this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Max);
							this.fXMax = this.fAxisBottom.Max;
							PadRange padRange = zoomable.GetPadRangeY(this);
							if (padRange.IsValid)
							{
								num3 = Math.Min(num3, padRange.Min);
								num4 = Math.Max(num4, padRange.Max);
								flag2 = true;
							}
							this.fAxisBottom.Max = max;
							this.fXMax = num5;
						}
					}
				}
			}
			catch
			{
			}
			if (flag)
			{
				this.SetRangeX(num - (num2 - num) / 20.0, num2 + (num2 - num) / 20.0);
			}
			if (flag2)
			{
				this.SetRangeY(num3 - (num4 - num3) / 20.0, num4 + (num4 - num3) / 20.0);
			}
			this.fGraphics = Graphics;
			this.fGraphics.Clip = new Region(new Rectangle(this.fX1, this.fY1, this.fWidth + 1, this.fHeight + 1));
			this.fGraphics.FillRectangle(new SolidBrush(this.fBackColor), this.fX1, this.fY1, this.fWidth, this.fHeight);
			if (this.fBorderEnabled)
			{
				int height = this.fHeight;
				int width = this.fWidth;
				int num6 = this.fChart.ClientRectangle.Height - this.fY1 - 1;
				int num7 = this.fChart.ClientRectangle.Width - this.fX1 - 1;
				if (this.fHeight > num6)
				{
					height = num6;
				}
				if (this.fWidth > num7)
				{
					width = num7;
				}
				Pen pen = new Pen(this.fBorderColor);
				pen.Width = (float)this.fBorderWidth;
				this.fGraphics.DrawRectangle(pen, this.fX1, this.fY1, width, height);
			}
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			if (this.fTitleEnabled)
			{
				switch (this.fTitle.Position)
				{
				case ETitlePosition.Left:
					num8 = this.Title.Height + this.fTitleOffsetY;
					break;
				case ETitlePosition.Right:
					num8 = this.Title.Height + this.fTitleOffsetY;
					break;
				case ETitlePosition.Centre:
					num8 = this.Title.Height + this.fTitleOffsetY;
					break;
				case ETitlePosition.InsideLeft:
					num8 = 0;
					break;
				case ETitlePosition.InsideRight:
					num8 = 0;
					break;
				case ETitlePosition.InsideCentre:
					num8 = 0;
					break;
				}
			}
			if (this.fAxisBottom.Enabled)
			{
				num9 = this.fAxisBottom.Height;
			}
			if (this.fAxisTop.Enabled)
			{
				num10 = this.fAxisTop.Height;
			}
			if (this.fAxisRight.Enabled)
			{
				num11 = this.fAxisRight.Width;
			}
			if (this.fAxisLeft.Enabled)
			{
				num12 = this.fAxisLeft.Width;
			}
			this.fClientX = this.fX1 + num12 + this.fMarginLeft;
			this.fClientY = this.fY1 + num8 + num10 + this.fMarginTop;
			this.fClientWidth = this.fWidth - num12 - num11 - this.fMarginLeft - this.fMarginRight;
			this.fClientHeight = this.fHeight - num8 - num10 - num9 - this.fMarginTop - this.fMarginBottom;
			this.fGraphics.FillRectangle(new SolidBrush(this.fForeColor), this.fClientX, this.fClientY, this.fClientWidth, this.fClientHeight);
			if (this.fAxisBottom.Enabled)
			{
				this.fAxisBottom.SetLocation((double)this.fClientX, (double)(this.fClientY + this.fClientHeight), (double)(this.fClientX + this.fClientWidth), (double)(this.fClientY + this.fClientHeight));
				this.fAxisBottom.Paint();
			}
			if (this.fAxisLeft.Enabled)
			{
				this.fGraphics.Clip = new Region(new Rectangle(this.fX1, this.fY1, this.fWidth, this.fHeight));
				this.fAxisLeft.SetLocation((double)this.fClientX, (double)this.fClientY, (double)this.fClientX, (double)(this.fClientY + this.fClientHeight));
				this.fAxisLeft.Paint();
			}
			if (this.fAxisTop.Enabled)
			{
				this.fAxisTop.SetLocation((double)this.fClientX, (double)this.fClientY, (double)(this.fClientX + this.fClientWidth), (double)this.fClientY);
				this.fAxisTop.Paint();
			}
			if (this.fAxisRight.Enabled)
			{
				this.fAxisRight.SetLocation((double)(this.fClientX + this.fClientWidth), (double)this.fClientY, (double)(this.fClientX + this.fClientWidth), (double)(this.fClientY + this.fClientHeight));
				this.fAxisRight.Paint();
			}
			this.fGraphics.Clip = new Region(new Rectangle(this.fClientX + 1, this.fClientY + 1, this.fClientWidth - 1, this.fClientHeight - 1));
			try
			{
				foreach (object obj2 in this.fPrimitives)
				{
					IDrawable drawable2 = (IDrawable)obj2;
					drawable2.Paint(this, this.XMin, this.XMin + this.CalculateRealQuantityOfTicks_Right(this.XMin, this.XMax), this.YMin, this.YMax);
				}
			}
			catch
			{
			}
			if (this.fOutlineEnabled)
			{
				this.fGraphics.DrawRectangle(new Pen(Color.Green), this.fOutlineRectangle);
			}
			if (this.fTitleEnabled)
			{
				switch (this.fTitle.Position)
				{
				case ETitlePosition.Left:
					this.fGraphics.Clip = new Region(new Rectangle(this.fX1, this.fY1, this.fWidth, this.fHeight));
					this.fTitle.Y = this.fY1 + this.fMarginTop;
					this.fTitle.X = this.fClientX + this.fTitleOffsetX;
					break;
				case ETitlePosition.Right:
					this.fGraphics.Clip = new Region(new Rectangle(this.fX1, this.fY1, this.fWidth, this.fHeight));
					this.fTitle.Y = this.fY1 + this.fMarginTop;
					this.fTitle.X = this.fClientX + this.fClientWidth - this.fTitle.Width - this.fTitleOffsetX;
					break;
				case ETitlePosition.Centre:
					this.fGraphics.Clip = new Region(new Rectangle(this.fX1, this.fY1, this.fWidth, this.fHeight));
					this.fTitle.Y = this.fY1 + this.fMarginTop;
					this.fTitle.X = this.fClientX + this.fClientWidth / 2 - this.fTitle.Width / 2 + this.fTitleOffsetX;
					break;
				case ETitlePosition.InsideLeft:
					this.fTitle.Y = this.fClientY + this.fTitleOffsetY;
					this.fTitle.X = this.fClientX + this.fTitleOffsetX;
					this.fGraphics.FillRectangle(new SolidBrush(this.fForeColor), this.fTitle.X, this.fTitle.Y, this.fTitle.Width, this.fTitle.Height);
					break;
				case ETitlePosition.InsideRight:
					this.fTitle.Y = this.fClientY + this.fTitleOffsetY;
					this.fTitle.X = this.fClientX + this.fClientWidth - this.fTitle.Width - this.fTitleOffsetX;
					this.fGraphics.FillRectangle(new SolidBrush(this.fForeColor), this.fTitle.X, this.fTitle.Y, this.fTitle.Width, this.fTitle.Height);
					break;
				case ETitlePosition.InsideCentre:
					this.fTitle.Y = this.fClientY + this.fTitleOffsetY;
					this.fTitle.X = this.fClientX + this.fClientWidth / 2 - this.fTitle.Width / 2 + this.fTitleOffsetX;
					this.fGraphics.FillRectangle(new SolidBrush(this.fForeColor), this.fTitle.X, this.fTitle.Y, this.fTitle.Width, this.fTitle.Height);
					break;
				}
				this.fTitle.Paint();
			}
			if (this.fLegendEnabled)
			{
				switch (this.fLegendPosition)
				{
				case ELegendPosition.TopRight:
					this.fLegend.X = this.fClientX + this.fClientWidth - this.fLegendOffsetX - this.fLegend.Width;
					this.fLegend.Y = this.fClientY + this.fLegendOffsetY;
					break;
				case ELegendPosition.TopLeft:
					this.fLegend.X = this.fClientX + this.fLegendOffsetX;
					this.fLegend.Y = this.fClientY + this.fLegendOffsetY;
					break;
				case ELegendPosition.BottomRight:
					this.fLegend.X = this.fClientX + this.fClientWidth - this.fLegendOffsetX - this.fLegend.Width;
					this.fLegend.Y = this.fClientY + this.fClientHeight - this.fLegendOffsetY - this.fLegend.Height;
					break;
				case ELegendPosition.BottomLeft:
					this.fLegend.X = this.fClientX + this.fLegendOffsetX;
					this.fLegend.Y = this.fClientY + this.fClientHeight - this.fLegendOffsetY - this.fLegend.Height;
					break;
				}
				this.fLegend.Paint();
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000DAF8 File Offset: 0x0000CAF8
		public void DrawLine(Pen Pen, double X1, double Y1, double X2, double Y2, bool DoTransform)
		{
			if (DoTransform)
			{
				this.fGraphics.DrawLine(Pen, this.ClientX(X1), this.ClientY(Y1), this.ClientX(X2), this.ClientY(Y2));
				return;
			}
			this.fGraphics.DrawLine(Pen, (int)X1, (int)Y1, (int)X2, (int)Y2);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000DB4C File Offset: 0x0000CB4C
		public void DrawVerticalTick(Pen Pen, double X, double Y, int Length)
		{
			try
			{
				this.fGraphics.DrawLine(Pen, this.ClientX(X), (int)Y, this.ClientX(X), (int)Y + Length);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000DB90 File Offset: 0x0000CB90
		public void DrawHorizontalTick(Pen Pen, double X, double Y, int Length)
		{
			try
			{
				this.fGraphics.DrawLine(Pen, (int)X, this.ClientY(Y), (int)X + Length, this.ClientY(Y));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000DBD4 File Offset: 0x0000CBD4
		public void DrawVerticalGrid(Pen Pen, double X)
		{
			this.fGraphics.DrawLine(Pen, this.ClientX(X), this.fClientY, this.ClientX(X), this.fClientY + this.fClientHeight);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000DC03 File Offset: 0x0000CC03
		public void DrawHorizontalGrid(Pen Pen, double Y)
		{
			this.fGraphics.DrawLine(Pen, this.fClientX, this.ClientY(Y), this.fClientX + this.fClientWidth, this.ClientY(Y));
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000DC32 File Offset: 0x0000CC32
		public void DrawLine(Pen Pen, double X1, double Y1, double X2, double Y2)
		{
			this.DrawLine(Pen, X1, Y1, X2, Y2, true);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000DC42 File Offset: 0x0000CC42
		public void DrawRectangle(Pen Pen, double X, double Y, int Width, int Height)
		{
			this.fGraphics.DrawRectangle(Pen, this.ClientX(X), this.ClientY(Y), Width, Height);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000DC62 File Offset: 0x0000CC62
		public void DrawEllipse(Pen Pen, double X, double Y, int Width, int Height)
		{
			this.fGraphics.DrawEllipse(Pen, this.ClientX(X), this.ClientY(Y), Width, Height);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000DC84 File Offset: 0x0000CC84
		public void DrawBeziers(Pen Pen, PointF[] Points)
		{
			Point[] array = new Point[Points.Length];
			for (int i = 0; i < Points.Length; i++)
			{
				PointF pointF = Points[i];
				array[i] = new Point(this.ClientX((double)pointF.X), this.ClientY((double)pointF.Y));
			}
			this.fGraphics.DrawBeziers(Pen, array);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000DCEF File Offset: 0x0000CCEF
		public void DrawText(string Text, Font Font, Brush Brush, int X, int Y)
		{
			this.fGraphics.DrawString(Text, Font, Brush, (float)X, (float)Y);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000DD05 File Offset: 0x0000CD05
		private bool IsInsideClient(int X, int Y)
		{
			return X > this.fClientX && X < this.fClientX + this.fClientWidth && Y > this.fClientY && Y < this.fClientY + this.fClientHeight;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000DD3C File Offset: 0x0000CD3C
		public virtual void MouseMove(MouseEventArgs Event)
		{
			try
			{
				if (!this.fMouseDown)
				{
					double num = (this.fXMax - this.fXMin) / 100.0;
					double num2 = (this.fYMax - this.fYMin) / 100.0;
					double x = this.WorldX(Event.X);
					double y = this.WorldY(Event.Y);
					bool flag = false;
					string text = "";
					this.fSelectedPrimitive = null;
					this.fSelectedPrimitiveDistance = null;
					this.fOnPrimitive = false;
					foreach (object obj in this.fPrimitives)
					{
						IDrawable drawable = (IDrawable)obj;
						TDistance tdistance = drawable.Distance(x, y);
						if (tdistance != null && tdistance.dX < num && tdistance.dY < num2)
						{
							if (drawable.ToolTipEnabled)
							{
								if (text != "")
								{
									text += "\n\n";
								}
								text += tdistance.ToolTipText;
								flag = true;
							}
							this.fOnPrimitive = true;
							this.fSelectedPrimitive = drawable;
							this.fSelectedPrimitiveDistance = tdistance;
						}
					}
					if (flag)
					{
						this.fChart.ToolTip.SetToolTip(this.fChart, text);
						this.fChart.ToolTip.Active = true;
					}
					else
					{
						this.fChart.ToolTip.Active = false;
					}
				}
				if (this.fMouseMovePrimitiveEnabled && this.fMouseDown && this.fMouseDownButton == MouseButtons.Left && this.fOnPrimitive && this.fSelectedPrimitive is IMovable)
				{
					double num3 = this.WorldX(Event.X);
					double num4 = this.WorldY(Event.Y);
					double dX = num3 - this.fSelectedPrimitiveDistance.X;
					double dY = num4 - this.fSelectedPrimitiveDistance.Y;
					((IMovable)this.fSelectedPrimitive).Move(this.fSelectedPrimitiveDistance.X, this.fSelectedPrimitiveDistance.Y, dX, dY);
					this.fSelectedPrimitiveDistance.X = num3;
					this.fSelectedPrimitiveDistance.Y = num4;
					this.fOnPrimitive = true;
					this.Update();
				}
				if (this.fMouseZoomEnabled && this.fMouseDown && this.fMouseDownButton == MouseButtons.Left && !this.fOnPrimitive)
				{
					int width = Math.Abs(this.fMouseDownX - Event.X);
					int height = Math.Abs(this.fMouseDownY - Event.Y);
					int x2;
					if (this.fMouseDownX < Event.X)
					{
						x2 = this.fMouseDownX;
					}
					else
					{
						x2 = Event.X;
					}
					int y2;
					if (this.fMouseDownY < Event.Y)
					{
						y2 = this.fMouseDownY;
					}
					else
					{
						y2 = Event.Y;
					}
					this.fOutlineRectangle.X = x2;
					this.fOutlineRectangle.Y = y2;
					this.fOutlineRectangle.Width = width;
					this.fOutlineRectangle.Height = height;
					this.Update();
				}
				if (this.fMouseMoveContentEnabled && this.fMouseDown && this.fMouseDownButton == MouseButtons.Right)
				{
					double num5 = (double)(this.fMouseDownX - Event.X) / (double)this.fClientWidth * (this.XMax - this.XMin);
					double num6 = this.WorldY(this.fMouseDownY) - this.WorldY(Event.Y);
					if (num5 > 0.0)
					{
						num5 = this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Min + num5);
					}
					else
					{
						num5 = this.CalculateRealQuantityOfTicks_Left(this.fAxisBottom.Min, this.fAxisBottom.Min + num5);
					}
					this.fMouseDownX = Event.X;
					this.fMouseDownY = Event.Y;
					this.fAxisBottom.SetRange(this.fAxisBottom.Min + num5, this.fAxisBottom.Max + num5);
					this.fAxisTop.SetRange(this.fAxisTop.Min + num5, this.fAxisTop.Max + num5);
					this.fAxisLeft.SetRange(this.fAxisLeft.Min + num6, this.fAxisLeft.Max + num6);
					this.fAxisRight.SetRange(this.fAxisRight.Min + num6, this.fAxisRight.Max + num6);
					this.fAxisBottom.Zoomed = true;
					this.fAxisTop.Zoomed = true;
					this.fAxisLeft.Zoomed = true;
					this.fAxisRight.Zoomed = true;
					if (!this.fChart.GroupZoomEnabled)
					{
						this.Update();
					}
					this.EmitZoom(true);
				}
				else
				{
					this.fOnAxis = false;
					this.fAxisLeft.MouseMove(Event);
					this.fAxisBottom.MouseMove(Event);
					if (this.fAxisLeft.X1 - 10.0 <= (double)Event.X && this.fAxisLeft.X1 >= (double)Event.X && this.fAxisLeft.Y1 <= (double)Event.Y && this.fAxisLeft.Y2 >= (double)Event.Y)
					{
						this.fOnAxis = true;
					}
					if (this.fAxisBottom.X1 <= (double)Event.X && this.fAxisBottom.X2 >= (double)Event.X && this.fAxisBottom.Y1 <= (double)Event.Y && this.fAxisBottom.Y1 + 10.0 >= (double)Event.Y)
					{
						this.fOnAxis = true;
					}
					if (this.fOnAxis || this.fOnPrimitive)
					{
						if (Cursor.Current != Cursors.Hand)
						{
							Cursor.Current = Cursors.Hand;
						}
					}
					else if (Cursor.Current != Cursors.Default)
					{
						Cursor.Current = Cursors.Default;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000E370 File Offset: 0x0000D370
		public virtual void MouseWheel(MouseEventArgs Event)
		{
			if (this.fMouseWheelEnabled)
			{
				double min = this.fAxisBottom.Min;
				double max = this.fAxisBottom.Max;
				switch (this.fMouseWheelMode)
				{
				case EMouseWheelMode.MoveX:
				{
					double num = (double)Event.Delta / 120.0 * (this.fAxisBottom.Max - this.fAxisBottom.Min) * this.fMouseWheelSensitivity;
					if (num > 0.0)
					{
						num = this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Min + num);
					}
					else
					{
						num = this.CalculateRealQuantityOfTicks_Left(this.fAxisBottom.Min, this.fAxisBottom.Min + num);
					}
					this.fAxisBottom.SetRange(this.fAxisBottom.Min + num, this.fAxisBottom.Max + num);
					this.fAxisTop.SetRange(this.fAxisTop.Min + num, this.fAxisTop.Max + num);
					this.fAxisBottom.Zoomed = true;
					this.fAxisTop.Zoomed = true;
					this.EmitZoom(true);
					break;
				}
				case EMouseWheelMode.MoveY:
				{
					double num = (double)Event.Delta / 120.0 * (this.fYMax - this.fYMin) * this.fMouseWheelSensitivity;
					this.fAxisLeft.SetRange(this.fAxisLeft.Min + num, this.fAxisLeft.Max + num);
					this.fAxisRight.SetRange(this.fAxisRight.Min + num, this.fAxisRight.Max + num);
					this.fAxisLeft.Zoomed = true;
					this.fAxisRight.Zoomed = true;
					this.EmitZoom(true);
					break;
				}
				case EMouseWheelMode.ZoomX:
				{
					double num = (double)Event.Delta / 120.0 * (this.fAxisBottom.Max - this.fAxisBottom.Min) * this.fMouseWheelSensitivity;
					double num2;
					if (num > 0.0)
					{
						num2 = this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Min + num);
					}
					else
					{
						num2 = this.CalculateRealQuantityOfTicks_Left(this.fAxisBottom.Min, this.fAxisBottom.Min + num);
					}
					double num3 = num2 - num;
					this.fAxisBottom.SetRange(this.fAxisBottom.Min + num2, this.fAxisBottom.Max + num3);
					this.fAxisTop.SetRange(this.fAxisTop.Min + num2, this.fAxisTop.Max + num3);
					this.fAxisBottom.Zoomed = true;
					this.fAxisTop.Zoomed = true;
					this.EmitZoom(true);
					break;
				}
				case EMouseWheelMode.ZoomY:
				{
					double num = (double)Event.Delta / 120.0 * (this.fYMax - this.fYMin) * this.fMouseWheelSensitivity;
					this.fAxisLeft.SetRange(this.fAxisLeft.Min + num, this.fAxisLeft.Max);
					this.fAxisRight.SetRange(this.fAxisRight.Min + num, this.fAxisRight.Max);
					this.fAxisLeft.Zoomed = true;
					this.fAxisRight.Zoomed = true;
					this.EmitZoom(true);
					break;
				}
				case EMouseWheelMode.Zoom:
				{
					double num4 = this.fAxisBottom.Min + this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Max);
					double num5 = (double)Event.Delta / 120.0 * (num4 - this.fAxisBottom.Min) * this.fMouseWheelSensitivity;
					double num6 = (double)Event.Delta / 120.0 * (this.fYMax - this.fYMin) * this.fMouseWheelSensitivity;
					double num7 = this.WorldX(Event.X);
					double num8 = this.WorldY(Event.Y);
					double num9 = (num7 - this.fAxisBottom.Min) / (num4 - this.fAxisBottom.Min) * num5;
					double num10 = (num4 - num7) / (num4 - this.fAxisBottom.Min) * num5;
					double num11 = (num8 - this.fYMin) / (this.fYMax - this.fYMin) * num6;
					double num12 = (this.fYMax - num8) / (this.fYMax - this.fYMin) * num6;
					double num2;
					if (num9 > 0.0)
					{
						num2 = this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Min + num9);
					}
					else
					{
						num2 = this.CalculateRealQuantityOfTicks_Left(this.fAxisBottom.Min, this.fAxisBottom.Min + num9);
					}
					double num3 = -num2 + num9 + num10;
					this.fAxisBottom.SetRange(this.fAxisBottom.Min + num2, this.fAxisBottom.Max - num3);
					this.fAxisTop.SetRange(this.fAxisTop.Min + num2, this.fAxisTop.Max - num3);
					this.fAxisLeft.SetRange(this.fAxisLeft.Min + num11, this.fAxisLeft.Max - num12);
					this.fAxisRight.SetRange(this.fAxisRight.Min + num11, this.fAxisRight.Max - num12);
					this.fAxisBottom.Zoomed = true;
					this.fAxisTop.Zoomed = true;
					this.fAxisLeft.Zoomed = true;
					this.fAxisRight.Zoomed = true;
					this.EmitZoom(true);
					break;
				}
				}
				if (!this.fChart.GroupZoomEnabled)
				{
					this.Update();
				}
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000E908 File Offset: 0x0000D908
		public virtual void MouseDown(MouseEventArgs Event)
		{
			if (this.IsInsideClient(Event.X, Event.Y))
			{
				this.fMouseDown = true;
				this.fMouseDownX = Event.X;
				this.fMouseDownY = Event.Y;
				this.fMouseDownButton = Event.Button;
				if (this.fMouseZoomEnabled && this.fMouseDownButton == MouseButtons.Left && this.fSelectedPrimitive == null)
				{
					this.fOutlineEnabled = true;
				}
				if (this.fMouseContextMenuEnabled && this.fMouseDownButton == MouseButtons.Right && this.fOnPrimitive)
				{
					this.InitContextMenu();
					this.DeleteMenuItem.Text = "Delete " + this.fSelectedPrimitive.GetType().Name;
					this.PrimitiveContextMenu.Show(this.fChart, new Point(Event.X, Event.Y));
				}
			}
			this.fAxisLeft.MouseDown(Event);
			this.fAxisBottom.MouseDown(Event);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000EA00 File Offset: 0x0000DA00
		public virtual void MouseUp(MouseEventArgs Event)
		{
			if (this.fMouseZoomEnabled && this.fMouseDown && this.fMouseDownButton == MouseButtons.Left && !this.fOnPrimitive)
			{
				this.fOutlineEnabled = false;
				if (Math.Abs(this.fMouseDownX - Event.X) > 2 && Math.Abs(this.fMouseDownY - Event.Y) > 2)
				{
					double num = this.WorldX(this.fMouseDownX);
					double num2 = this.WorldX(Event.X);
					double num3 = this.WorldY(this.fMouseDownY);
					double num4 = this.WorldY(Event.Y);
					double num5;
					double num6;
					if (num < num2)
					{
						num5 = num;
						num6 = num2;
					}
					else
					{
						num5 = num2;
						num6 = num;
					}
					double min;
					double max;
					if (num3 < num4)
					{
						min = num3;
						max = num4;
					}
					else
					{
						min = num4;
						max = num3;
					}
					num6 -= this.CalculateNotInSessionTicks(num5, num6);
					this.fAxisBottom.SetRange(num5, num6);
					this.fAxisTop.SetRange(num5, num6);
					this.fAxisLeft.SetRange(min, max);
					this.fAxisRight.SetRange(min, max);
					this.fAxisBottom.Zoomed = true;
					this.fAxisTop.Zoomed = true;
					this.fAxisLeft.Zoomed = true;
					this.fAxisRight.Zoomed = true;
					if (!this.fChart.GroupZoomEnabled)
					{
						this.Update();
					}
					this.EmitZoom(true);
				}
				this.fMouseDown = false;
				return;
			}
			this.fAxisLeft.MouseUp(Event);
			this.fAxisBottom.MouseUp(Event);
			this.fMouseDown = false;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000EB88 File Offset: 0x0000DB88
		public virtual void DoubleClick(int X, int Y)
		{
			if (this.IsInsideClient(X, Y))
			{
				if (this.fOnPrimitive)
				{
					if (this.fMousePrimitivePropertiesEnabled)
					{
						this.fChart.ToolTip.Active = false;
						PadProperyForm padProperyForm = new PadProperyForm(this.fSelectedPrimitive, this);
						padProperyForm.ShowDialog();
						return;
					}
				}
				else if (this.fMouseUnzoomEnabled && (this.AxisLeft.Zoomed || this.AxisBottom.Zoomed))
				{
					this.fOutlineEnabled = false;
					if (!this.fChart.GroupZoomEnabled)
					{
						this.UnZoom();
					}
					this.EmitZoom(false);
					return;
				}
			}
			else if (this.fMousePadPropertiesEnabled)
			{
				PadProperyForm padProperyForm2 = new PadProperyForm(this, this);
				padProperyForm2.ShowDialog();
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000EC33 File Offset: 0x0000DC33
		public static void EmitNewTick(DateTime datetime)
		{
			if (Pad.NewTick != null)
			{
				Pad.NewTick(null, new NewTickEventArgs(datetime));
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000EC50 File Offset: 0x0000DC50
		private void OnNewTick(object sender, NewTickEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int num = EventArgs.DateTime.Hour * 60 * 60 + EventArgs.DateTime.Minute * 60 + EventArgs.DateTime.Second;
				if (num - this.fLastTickTime >= this.fUpdateInterval)
				{
					DateTime dateTime = EventArgs.DateTime;
					double num2 = (double)dateTime.AddSeconds((double)(-(double)this.fWindowSize)).Ticks;
					double num3 = (double)dateTime.Ticks;
					this.SetRangeX(num2, num3 + (num3 - num2) / 20.0);
					if ((DateTime.Now.Ticks - this.fLastUpdateDateTime.Ticks) / 1000000L > 1L)
					{
						if (!this.fChart.GroupZoomEnabled)
						{
							this.Update();
						}
						this.EmitZoom(true);
						this.fLastUpdateDateTime = DateTime.Now;
					}
					this.fLastTickTime = num;
				}
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000ED47 File Offset: 0x0000DD47
		public void EmitZoom(bool zoom)
		{
			if (this.Zoom != null)
			{
				this.Zoom(null, new ZoomEventArgs(this.XMin, this.XMax, this.YMin, this.YMax, zoom));
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000ED7B File Offset: 0x0000DD7B
		private void DeleteMenuItem_Click(object sender, EventArgs e)
		{
			this.fPrimitives.Remove(this.fSelectedPrimitive);
			this.Update();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000ED94 File Offset: 0x0000DD94
		private void PropertiesMenuItem_Click(object sender, EventArgs e)
		{
			PadProperyForm padProperyForm = new PadProperyForm(this.fSelectedPrimitive, this);
			padProperyForm.ShowDialog();
		}

		// Token: 0x0400013B RID: 315
		private Pad.TFeatures3D Features3D;

		// Token: 0x0400013C RID: 316
		[Browsable(false)]
		public bool Grid3D;

		// Token: 0x0400013F RID: 319
		protected int fX1;

		// Token: 0x04000140 RID: 320
		protected int fX2;

		// Token: 0x04000141 RID: 321
		protected int fY1;

		// Token: 0x04000142 RID: 322
		protected int fY2;

		// Token: 0x04000143 RID: 323
		protected double fCanvasX1;

		// Token: 0x04000144 RID: 324
		protected double fCanvasX2;

		// Token: 0x04000145 RID: 325
		protected double fCanvasY1;

		// Token: 0x04000146 RID: 326
		protected double fCanvasY2;

		// Token: 0x04000147 RID: 327
		protected int fClientX;

		// Token: 0x04000148 RID: 328
		protected int fClientY;

		// Token: 0x04000149 RID: 329
		protected int fClientWidth;

		// Token: 0x0400014A RID: 330
		protected int fClientHeight;

		// Token: 0x0400014B RID: 331
		protected double fXMin;

		// Token: 0x0400014C RID: 332
		protected double fXMax;

		// Token: 0x0400014D RID: 333
		protected double fYMin;

		// Token: 0x0400014E RID: 334
		protected double fYMax;

		// Token: 0x0400014F RID: 335
		protected int fMarginLeft;

		// Token: 0x04000150 RID: 336
		protected int fMarginRight;

		// Token: 0x04000151 RID: 337
		protected int fMarginTop;

		// Token: 0x04000152 RID: 338
		protected int fMarginBottom;

		// Token: 0x04000153 RID: 339
		protected int fWidth;

		// Token: 0x04000154 RID: 340
		protected int fHeight;

		// Token: 0x04000155 RID: 341
		[NonSerialized]
		protected Chart fChart;

		// Token: 0x04000156 RID: 342
		[NonSerialized]
		protected Graphics fGraphics;

		// Token: 0x04000157 RID: 343
		protected ArrayList fPrimitives;

		// Token: 0x04000158 RID: 344
		protected Color fBackColor;

		// Token: 0x04000159 RID: 345
		protected Color fForeColor;

		// Token: 0x0400015A RID: 346
		protected string fName;

		// Token: 0x0400015B RID: 347
		protected TTitle fTitle;

		// Token: 0x0400015C RID: 348
		protected bool fTitleEnabled;

		// Token: 0x0400015D RID: 349
		protected int fTitleOffsetX;

		// Token: 0x0400015E RID: 350
		protected int fTitleOffsetY;

		// Token: 0x0400015F RID: 351
		protected Axis fAxisLeft;

		// Token: 0x04000160 RID: 352
		protected Axis fAxisRight;

		// Token: 0x04000161 RID: 353
		protected Axis fAxisTop;

		// Token: 0x04000162 RID: 354
		protected Axis fAxisBottom;

		// Token: 0x04000163 RID: 355
		protected TLegend fLegend;

		// Token: 0x04000164 RID: 356
		protected bool fLegendEnabled;

		// Token: 0x04000165 RID: 357
		protected ELegendPosition fLegendPosition;

		// Token: 0x04000166 RID: 358
		protected int fLegendOffsetX;

		// Token: 0x04000167 RID: 359
		protected int fLegendOffsetY;

		// Token: 0x04000168 RID: 360
		protected bool fBorderEnabled;

		// Token: 0x04000169 RID: 361
		protected Color fBorderColor;

		// Token: 0x0400016A RID: 362
		protected int fBorderWidth;

		// Token: 0x0400016B RID: 363
		protected IDrawable fSelectedPrimitive;

		// Token: 0x0400016C RID: 364
		protected TDistance fSelectedPrimitiveDistance;

		// Token: 0x0400016D RID: 365
		protected bool fOnAxis;

		// Token: 0x0400016E RID: 366
		protected bool fOnPrimitive;

		// Token: 0x0400016F RID: 367
		protected bool fMouseDown;

		// Token: 0x04000170 RID: 368
		protected int fMouseDownX;

		// Token: 0x04000171 RID: 369
		protected int fMouseDownY;

		// Token: 0x04000172 RID: 370
		[NonSerialized]
		protected MouseButtons fMouseDownButton;

		// Token: 0x04000173 RID: 371
		protected bool fOutlineEnabled;

		// Token: 0x04000174 RID: 372
		protected Rectangle fOutlineRectangle;

		// Token: 0x04000175 RID: 373
		protected bool fMouseZoomEnabled;

		// Token: 0x04000176 RID: 374
		protected bool fMouseZoomXAxisEnabled;

		// Token: 0x04000177 RID: 375
		protected bool fMouseZoomYAxisEnabled;

		// Token: 0x04000178 RID: 376
		protected bool fMouseUnzoomEnabled;

		// Token: 0x04000179 RID: 377
		protected bool fMouseUnzoomXAxisEnabled;

		// Token: 0x0400017A RID: 378
		protected bool fMouseUnzoomYAxisEnabled;

		// Token: 0x0400017B RID: 379
		protected bool fMouseMoveContentEnabled;

		// Token: 0x0400017C RID: 380
		protected bool fMouseMovePrimitiveEnabled;

		// Token: 0x0400017D RID: 381
		protected bool fMouseDeletePrimitiveEnabled;

		// Token: 0x0400017E RID: 382
		protected bool fMousePadPropertiesEnabled;

		// Token: 0x0400017F RID: 383
		protected bool fMousePrimitivePropertiesEnabled;

		// Token: 0x04000180 RID: 384
		protected bool fMouseContextMenuEnabled;

		// Token: 0x04000181 RID: 385
		protected bool fMouseWheelEnabled;

		// Token: 0x04000182 RID: 386
		protected double fMouseWheelSensitivity;

		// Token: 0x04000183 RID: 387
		protected EMouseWheelMode fMouseWheelMode;

		// Token: 0x04000184 RID: 388
		protected int fWindowSize;

		// Token: 0x04000185 RID: 389
		protected bool fMonitored;

		// Token: 0x04000186 RID: 390
		protected bool fUpdating;

		// Token: 0x04000187 RID: 391
		protected int fLastTickTime;

		// Token: 0x04000188 RID: 392
		protected int fUpdateInterval;

		// Token: 0x04000189 RID: 393
		protected DateTime fLastUpdateDateTime;

		// Token: 0x0400018A RID: 394
		protected ETransformationType fTransformationType;

		// Token: 0x0400018B RID: 395
		protected IChartTransformation fTransformation;

		// Token: 0x0400018C RID: 396
		protected Color fSessionGridColor;

		// Token: 0x0400018D RID: 397
		[NonSerialized]
		private ContextMenu PrimitiveContextMenu;

		// Token: 0x0400018E RID: 398
		[NonSerialized]
		private MenuItem DeleteMenuItem;

		// Token: 0x0400018F RID: 399
		[NonSerialized]
		private MenuItem PropertiesMenuItem;

		// Token: 0x02000041 RID: 65
		[Serializable]
		private class TFeatures3D
		{
			// Token: 0x060003FE RID: 1022 RVA: 0x0000EDB8 File Offset: 0x0000DDB8
			public TFeatures3D(Pad Pad)
			{
				this.Pad = Pad;
				this.Axes2D = new Pad.TFeatures3D.TAxes2D(Pad);
				this.Axes = new Axis[]
				{
					new Axis(Pad),
					new Axis(Pad),
					new Axis(Pad)
				};
				for (int i = 0; i < this.Axes.Length; i++)
				{
					this.Axes[i].Max = 1.0;
					this.Axes[i].Min = 0.0;
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060003FF RID: 1023 RVA: 0x0000EE46 File Offset: 0x0000DE46
			// (set) Token: 0x06000400 RID: 1024 RVA: 0x0000EE50 File Offset: 0x0000DE50
			public bool Active
			{
				get
				{
					return this.fActive;
				}
				set
				{
					this.fActive = value;
					if (value)
					{
						this.Axes2D.SetFor3D();
						this.Pad.ForeColor = this.Pad.BackColor;
						this.Pad.AntiAliasingEnabled = true;
						return;
					}
					this.Axes2D.Restore();
				}
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x0000EEA0 File Offset: 0x0000DEA0
			public void SetRangeX(double XMin, double XMax)
			{
				this.Axes[0].SetRange(XMin, XMax);
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x0000EEB1 File Offset: 0x0000DEB1
			public void SetRangeY(double YMin, double YMax)
			{
				this.Axes[1].SetRange(YMin, YMax);
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x0000EEC2 File Offset: 0x0000DEC2
			public void SetRangeZ(double ZMin, double ZMax)
			{
				this.Axes[2].SetRange(ZMin, ZMax);
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x0000EED3 File Offset: 0x0000DED3
			public void SetRange(double XMin, double XMax, double YMin, double YMax)
			{
				this.SetRangeX(XMin, XMax);
				this.SetRangeY(YMin, YMax);
			}

			// Token: 0x04000190 RID: 400
			private Pad Pad;

			// Token: 0x04000191 RID: 401
			private Pad.TFeatures3D.TAxes2D Axes2D;

			// Token: 0x04000192 RID: 402
			public Axis[] Axes;

			// Token: 0x04000193 RID: 403
			private bool fActive;

			// Token: 0x04000194 RID: 404
			public object View;

			// Token: 0x02000042 RID: 66
			[Serializable]
			private class TAxes2D
			{
				// Token: 0x06000405 RID: 1029 RVA: 0x0000EEE6 File Offset: 0x0000DEE6
				public TAxes2D(Pad Pad)
				{
					this.Pad = Pad;
					this.Top = new Axis(Pad);
					this.Bottom = new Axis(Pad);
					this.Left = new Axis(Pad);
					this.Right = new Axis(Pad);
				}

				// Token: 0x06000406 RID: 1030 RVA: 0x0000EF28 File Offset: 0x0000DF28
				private void Copy(Axis dst, Axis src)
				{
					dst.LabelEnabled = src.LabelEnabled;
					dst.MajorTicksEnabled = src.MajorTicksEnabled;
					dst.MinorTicksEnabled = src.MinorTicksEnabled;
					dst.GridEnabled = src.GridEnabled;
					dst.MinorGridEnabled = src.MinorGridEnabled;
					dst.SetRange(src.Min, src.Max);
					dst.Enabled = src.Enabled;
				}

				// Token: 0x06000407 RID: 1031 RVA: 0x0000EF90 File Offset: 0x0000DF90
				private void SetFor3D(Axis a)
				{
					a.LabelEnabled = false;
					a.MajorTicksEnabled = false;
					a.MinorTicksEnabled = false;
					a.GridEnabled = false;
					a.MinorGridEnabled = false;
					a.SetRange(0.0, 1.0);
					a.Enabled = false;
				}

				// Token: 0x06000408 RID: 1032 RVA: 0x0000EFE0 File Offset: 0x0000DFE0
				public void Save()
				{
					this.Copy(this.Top, this.Pad.fAxisTop);
					this.Copy(this.Bottom, this.Pad.fAxisBottom);
					this.Copy(this.Left, this.Pad.fAxisLeft);
					this.Copy(this.Right, this.Pad.fAxisRight);
					this.Saved = true;
				}

				// Token: 0x06000409 RID: 1033 RVA: 0x0000F050 File Offset: 0x0000E050
				public void SetFor3D()
				{
					this.Save();
					this.SetFor3D(this.Pad.AxisTop);
					this.SetFor3D(this.Pad.AxisBottom);
					this.SetFor3D(this.Pad.AxisLeft);
					this.SetFor3D(this.Pad.AxisRight);
				}

				// Token: 0x0600040A RID: 1034 RVA: 0x0000F0A8 File Offset: 0x0000E0A8
				public void Restore()
				{
					if (!this.Saved)
					{
						return;
					}
					this.Copy(this.Pad.fAxisTop, this.Top);
					this.Copy(this.Pad.fAxisBottom, this.Bottom);
					this.Copy(this.Pad.fAxisLeft, this.Left);
					this.Copy(this.Pad.fAxisRight, this.Right);
				}

				// Token: 0x04000195 RID: 405
				private Pad Pad;

				// Token: 0x04000196 RID: 406
				private bool Saved;

				// Token: 0x04000197 RID: 407
				private Axis Top;

				// Token: 0x04000198 RID: 408
				private Axis Bottom;

				// Token: 0x04000199 RID: 409
				private Axis Left;

				// Token: 0x0400019A RID: 410
				private Axis Right;
			}
		}
	}
}
