using System;
using System.Collections;
using System.Drawing;

namespace SmartQuant.Charting
{
	// Token: 0x0200001F RID: 31
	[Serializable]
	public class Pie : IDrawable
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00005C08 File Offset: 0x00004C08
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00005C10 File Offset: 0x00004C10
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

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00005C19 File Offset: 0x00004C19
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00005C21 File Offset: 0x00004C21
		public string Title
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

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00005C2A File Offset: 0x00004C2A
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00005C32 File Offset: 0x00004C32
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00005C3B File Offset: 0x00004C3B
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00005C43 File Offset: 0x00004C43
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00005C4C File Offset: 0x00004C4C
		public ArrayList Pieces
		{
			get
			{
				return this.fItems;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00005C54 File Offset: 0x00004C54
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00005C5C File Offset: 0x00004C5C
		public bool EnableContour
		{
			get
			{
				return this.fEnableContour;
			}
			set
			{
				this.fEnableContour = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00005C65 File Offset: 0x00004C65
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00005C6D File Offset: 0x00004C6D
		public Color ContourColor
		{
			get
			{
				return this.fContourColor;
			}
			set
			{
				this.fContourColor = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00005C76 File Offset: 0x00004C76
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00005C7E File Offset: 0x00004C7E
		public int Gap
		{
			get
			{
				return this.fGap;
			}
			set
			{
				this.fGap = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00005C87 File Offset: 0x00004C87
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00005C8F File Offset: 0x00004C8F
		public string Format
		{
			get
			{
				return this.fFormat;
			}
			set
			{
				this.fFormat = value;
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00005C98 File Offset: 0x00004C98
		private void InitPie()
		{
			this.fItems = new ArrayList();
			this.fEnableContour = true;
			this.fContourColor = Color.Gray;
			this.fGap = 0;
			this.fFormat = "F1";
			this.fPalette = this.CreateRainbowPalette();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00005CD5 File Offset: 0x00004CD5
		public Pie()
		{
			this.InitPie();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00005CE3 File Offset: 0x00004CE3
		public Pie(string Name)
		{
			this.fName = Name;
			this.InitPie();
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005CF8 File Offset: 0x00004CF8
		public Pie(string Name, string Title)
		{
			this.fName = Name;
			this.fTitle = Title;
			this.InitPie();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005D14 File Offset: 0x00004D14
		public void Add(double Weight)
		{
			this.fItems.Add(new TPieItem(Weight, "", Color.Empty));
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00005D32 File Offset: 0x00004D32
		public void Add(double Weight, string Text, Color Color)
		{
			this.fItems.Add(new TPieItem(Weight, Text, Color));
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00005D48 File Offset: 0x00004D48
		public void Add(double Weight, string Text)
		{
			this.fItems.Add(new TPieItem(Weight, Text, Color.Empty));
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00005D64 File Offset: 0x00004D64
		public virtual void Draw(string Option)
		{
			if (Chart.Pad == null)
			{
				new Canvas("Canvas", "Canvas");
			}
			Chart.Pad.AxisBottom.Enabled = false;
			Chart.Pad.AxisLeft.Enabled = false;
			Chart.Pad.AxisRight.Enabled = false;
			Chart.Pad.AxisTop.Enabled = false;
			Chart.Pad.ForeColor = Color.LightGray;
			Chart.Pad.Title.Text = this.fName;
			this.MakeLegend();
			Chart.Pad.Add(this);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00005E00 File Offset: 0x00004E00
		private void MakeLegend()
		{
			int num = 0;
			foreach (object obj in this.fItems)
			{
				TPieItem tpieItem = (TPieItem)obj;
				if (tpieItem.Color == Color.Empty)
				{
					tpieItem.Color = this.fPalette[num * 160 / this.fItems.Count];
				}
				num++;
			}
			double num2 = 0.0;
			foreach (object obj2 in this.fItems)
			{
				TPieItem tpieItem2 = (TPieItem)obj2;
				num2 += tpieItem2.Weight;
			}
			foreach (object obj3 in this.fItems)
			{
				TPieItem tpieItem3 = (TPieItem)obj3;
				double num3 = tpieItem3.Weight / num2;
				string text = tpieItem3.Text;
				text = text.Replace("&%", (num3 * 100.0).ToString(this.fFormat));
				Chart.Pad.Title.Add(text, tpieItem3.Color);
				Chart.Pad.Legend.Add(text, tpieItem3.Color);
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00005FB0 File Offset: 0x00004FB0
		public virtual void Draw()
		{
			this.Draw("");
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00005FC0 File Offset: 0x00004FC0
		private Color[] CreatePalette(Color LowColor, Color HighColor, int NColors)
		{
			Color[] array = new Color[NColors];
			double num = (double)(HighColor.R - LowColor.R) / (double)NColors;
			double num2 = (double)(HighColor.G - LowColor.G) / (double)NColors;
			double num3 = (double)(HighColor.B - LowColor.B) / (double)NColors;
			double num4 = (double)LowColor.R;
			double num5 = (double)LowColor.G;
			double num6 = (double)LowColor.B;
			array[0] = LowColor;
			for (int i = 1; i < NColors; i++)
			{
				num4 += num;
				num5 += num2;
				num6 += num3;
				array[i] = Color.FromArgb((int)num4, (int)num5, (int)num6);
			}
			return array;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000607C File Offset: 0x0000507C
		private Color[] CreateRainbowPalette()
		{
			Color[] array = new Color[160];
			int num = 0;
			Color[] array2 = this.CreatePalette(Color.Purple, Color.Blue, 32);
			foreach (Color color in array2)
			{
				array[num++] = color;
			}
			array2 = this.CreatePalette(Color.Blue, Color.Green, 32);
			foreach (Color color2 in array2)
			{
				array[num++] = color2;
			}
			array2 = this.CreatePalette(Color.Green, Color.Yellow, 32);
			foreach (Color color3 in array2)
			{
				array[num++] = color3;
			}
			array2 = this.CreatePalette(Color.Yellow, Color.Orange, 32);
			foreach (Color color4 in array2)
			{
				array[num++] = color4;
			}
			array2 = this.CreatePalette(Color.Orange, Color.Red, 32);
			foreach (Color color5 in array2)
			{
				array[num++] = color5;
			}
			return array;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000620C File Offset: 0x0000520C
		public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
		{
			double num = 0.0;
			for (int i = 0; i < this.fItems.Count; i++)
			{
				num += ((TPieItem)this.fItems[i]).Weight;
			}
			int num2 = Pad.ClientX(0.0);
			int num3 = Pad.ClientY(100.0);
			int num4 = Math.Abs(Pad.ClientX(100.0) - Pad.ClientX(0.0));
			int num5 = Math.Abs(Pad.ClientY(100.0) - Pad.ClientY(0.0));
			int num6 = 0;
			int num7 = 0;
			if (num4 > num5)
			{
				num6 = (num4 - num5) / 2;
				num4 = num5;
			}
			else
			{
				num7 = (num5 - num4) / 2;
				num5 = num4;
			}
			int num8 = num5 / 10;
			double num9 = 0.0;
			for (int j = 0; j < this.fItems.Count; j++)
			{
				double num10 = ((TPieItem)this.fItems[j]).Weight / num;
				Brush brush = new SolidBrush(((TPieItem)this.fItems[j]).Color);
				double num11 = num9 + (double)this.fGap;
				num9 += 360.0 * num10;
				double num12 = num9 - num11 + 1.0;
				Pad.Graphics.FillPie(brush, num2 + num6 + num8, num3 + num7 + num8, num4 - 2 * num8, num5 - 2 * num8, (int)num11, (int)num12);
			}
			if (this.fEnableContour)
			{
				num9 = 0.0;
				for (int k = 0; k < this.fItems.Count; k++)
				{
					double num13 = ((TPieItem)this.fItems[k]).Weight / num;
					Pen pen = new Pen(this.fContourColor);
					double num11 = num9 + (double)this.fGap;
					num9 += 360.0 * num13;
					double num12 = num9 - num11 + 1.0;
					Pad.Graphics.DrawPie(pen, (float)(num2 + num6 + num8), (float)(num3 + num7 + num8), (float)(num4 - 2 * num8), (float)(num5 - 2 * num8), (float)num11, (float)num12);
				}
			}
			num9 = 0.0;
			for (int l = 0; l < this.fItems.Count; l++)
			{
				double num14 = ((TPieItem)this.fItems[l]).Weight / num;
				new Pen(this.fContourColor);
				double num11 = num9 + (double)this.fGap;
				num9 += 360.0 * num14;
				double num15 = num11 + (num9 - num11) / 2.0 + 90.0;
				int num16 = (num4 - 2 * num8) / 4;
				int num17 = (num4 - 2 * num8) / 2;
				Math.Sin(0.017453292519943295 * num15);
				int num18 = (num4 - 2 * num8) / 2;
				Math.Cos(0.017453292519943295 * num15);
				int num19 = (num4 - 2 * num8) / 2;
				int num20 = (num4 - 2 * num8) / 2 + 10;
				int x = (int)((double)(num2 + num6 + num8 + (num4 - 2 * num8) / 2) + (double)num19 * Math.Sin(0.017453292519943295 * num15));
				int y = (int)((double)(num3 + num7 + num8 + (num4 - 2 * num8) / 2) - (double)num19 * Math.Cos(0.017453292519943295 * num15));
				int num21 = (int)((double)(num2 + num6 + num8 + (num4 - 2 * num8) / 2) + (double)num20 * Math.Sin(0.017453292519943295 * num15));
				int num22 = (int)((double)(num3 + num7 + num8 + (num4 - 2 * num8) / 2) - (double)num20 * Math.Cos(0.017453292519943295 * num15));
				Font font = new Font("Arial", 8f);
				Pad.Graphics.DrawLine(new Pen(Color.Gray), x, y, num21, num22);
				string text = ((TPieItem)this.fItems[l]).Text;
				text = text.Replace("&%", (num14 * 100.0).ToString(this.fFormat));
				if (num21 > num2 + num6 + num4 / 2)
				{
					Pad.Graphics.DrawLine(new Pen(Color.Gray), num21, num22, num21 + 5, num22);
					SizeF sizeF = Pad.Graphics.MeasureString(text, font);
					Pad.Graphics.DrawString(text, font, new SolidBrush(Color.Black), (float)(num21 + 5), (float)num22 - sizeF.Height / 2f);
				}
				else
				{
					Pad.Graphics.DrawLine(new Pen(Color.Gray), num21, num22, num21 - 5, num22);
					SizeF sizeF2 = Pad.Graphics.MeasureString(text, font);
					Pad.Graphics.DrawString(text, font, new SolidBrush(Color.Black), (float)(num21 - 5) - sizeF2.Width, (float)num22 - sizeF2.Height / 2f);
				}
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006773 File Offset: 0x00005773
		public TDistance Distance(double X, double Y)
		{
			return null;
		}

		// Token: 0x04000081 RID: 129
		private string fName;

		// Token: 0x04000082 RID: 130
		private string fTitle;

		// Token: 0x04000083 RID: 131
		private ArrayList fItems;

		// Token: 0x04000084 RID: 132
		private bool fEnableContour;

		// Token: 0x04000085 RID: 133
		private Color fContourColor;

		// Token: 0x04000086 RID: 134
		private int fGap;

		// Token: 0x04000087 RID: 135
		private string fFormat;

		// Token: 0x04000088 RID: 136
		private Color[] fPalette;

		// Token: 0x04000089 RID: 137
		private bool fToolTipEnabled;

		// Token: 0x0400008A RID: 138
		private string fToolTipFormat;
	}
}
