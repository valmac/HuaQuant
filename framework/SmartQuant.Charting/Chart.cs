using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace SmartQuant.Charting
{
	// Token: 0x02000030 RID: 48
	[Serializable]
	public class Chart : UserControl
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600021C RID: 540 RVA: 0x00008EBE File Offset: 0x00007EBE
		// (remove) Token: 0x0600021D RID: 541 RVA: 0x00008ED7 File Offset: 0x00007ED7
		public event EventHandler PadSplitMouseUp;

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00008EF0 File Offset: 0x00007EF0
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00008EF8 File Offset: 0x00007EF8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public PadList Pads
		{
			get
			{
				return this.fPads;
			}
			set
			{
				this.fPads = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00008F01 File Offset: 0x00007F01
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00008F09 File Offset: 0x00007F09
		public bool GroupLeftMarginEnabled
		{
			get
			{
				return this.fGroupLeftMarginEnabled;
			}
			set
			{
				this.fGroupLeftMarginEnabled = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00008F12 File Offset: 0x00007F12
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00008F1A File Offset: 0x00007F1A
		public bool GroupRightMarginEnabled
		{
			get
			{
				return this.fGroupRightMarginEnabled;
			}
			set
			{
				this.fGroupRightMarginEnabled = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00008F23 File Offset: 0x00007F23
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00008F2B File Offset: 0x00007F2B
		public bool GroupZoomEnabled
		{
			get
			{
				return this.fGroupZoomEnabled;
			}
			set
			{
				this.fGroupZoomEnabled = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00008F34 File Offset: 0x00007F34
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00008F3C File Offset: 0x00007F3C
		public bool DoubleBufferingEnabled
		{
			get
			{
				return this.fDoubleBufferingEnabled;
			}
			set
			{
				this.fDoubleBufferingEnabled = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00008F45 File Offset: 0x00007F45
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00008F4D File Offset: 0x00007F4D
		public bool SmoothingEnabled
		{
			get
			{
				return this.fSmoothingEnabled;
			}
			set
			{
				this.fSmoothingEnabled = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00008F56 File Offset: 0x00007F56
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00008F5E File Offset: 0x00007F5E
		public bool AntiAliasingEnabled
		{
			get
			{
				return this.fAntiAliasingEnabled;
			}
			set
			{
				this.fAntiAliasingEnabled = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00008F67 File Offset: 0x00007F67
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00008F6E File Offset: 0x00007F6E
		public static Pad Pad
		{
			get
			{
				return Chart.fPad;
			}
			set
			{
				Chart.fPad = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00008F76 File Offset: 0x00007F76
		public ToolTip ToolTip
		{
			get
			{
				return this.fToolTip;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00008F80 File Offset: 0x00007F80
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00008FEA File Offset: 0x00007FEA
		public PrintDocument PrintDocument
		{
			get
			{
				if (this.fPrintDocument == null)
				{
					this.fPrintDocument = new PrintDocument();
					this.fPrintDocument.PrintPage += this.OnPrintPage;
					if (this.fPrintLayout == EPrintLayout.Landscape)
					{
						this.fPrintDocument.DefaultPageSettings.Landscape = true;
					}
					else
					{
						this.fPrintDocument.DefaultPageSettings.Landscape = false;
					}
				}
				return this.fPrintDocument;
			}
			set
			{
				if (this.fPrintDocument != null)
				{
					this.fPrintDocument.PrintPage -= this.OnPrintPage;
				}
				this.fPrintDocument = value;
				this.fPrintDocument.PrintPage += this.OnPrintPage;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00009029 File Offset: 0x00008029
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00009031 File Offset: 0x00008031
		public int PrintX
		{
			get
			{
				return this.fPrintX;
			}
			set
			{
				this.fPrintX = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000903A File Offset: 0x0000803A
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00009042 File Offset: 0x00008042
		public int PrintY
		{
			get
			{
				return this.fPrintY;
			}
			set
			{
				this.fPrintY = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000904B File Offset: 0x0000804B
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00009053 File Offset: 0x00008053
		public int PrintWidth
		{
			get
			{
				return this.fPrintWidth;
			}
			set
			{
				this.fPrintWidth = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000905C File Offset: 0x0000805C
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00009064 File Offset: 0x00008064
		public int PrintHeight
		{
			get
			{
				return this.fPrintHeight;
			}
			set
			{
				this.fPrintHeight = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000906D File Offset: 0x0000806D
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00009075 File Offset: 0x00008075
		public EPrintAlign PrintAlign
		{
			get
			{
				return this.fPrintAlign;
			}
			set
			{
				this.fPrintAlign = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000907E File Offset: 0x0000807E
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00009086 File Offset: 0x00008086
		public EPrintLayout PrintLayout
		{
			get
			{
				return this.fPrintLayout;
			}
			set
			{
				this.fPrintLayout = value;
				if (this.fPrintDocument != null)
				{
					if (this.fPrintLayout == EPrintLayout.Landscape)
					{
						this.fPrintDocument.DefaultPageSettings.Landscape = true;
						return;
					}
					this.fPrintDocument.DefaultPageSettings.Landscape = false;
				}
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000090C4 File Offset: 0x000080C4
		protected virtual void Init()
		{
			this.InitializeComponent();
			base.ResizeRedraw = true;
			this.fPadsForeColor = Color.White;
			this.fPads = new PadList();
			this.AddPad(0.0, 0.0, 1.0, 1.0);
			this.fPadSplit = false;
			this.fPadSplitIndex = 0;
			this.fDoubleBufferingEnabled = true;
			this.fSmoothingEnabled = false;
			this.fAntiAliasingEnabled = false;
			this.fToolTip = new ToolTip();
			this.fIsUpdating = false;
			base.SetStyle(ControlStyles.StandardClick, true);
			base.SetStyle(ControlStyles.StandardDoubleClick, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.fPrintX = 10;
			this.fPrintY = 10;
			this.fPrintWidth = 600;
			this.fPrintHeight = 400;
			this.fPrintAlign = EPrintAlign.None;
			this.fPrintLayout = EPrintLayout.Portrait;
			this.fSessionGridColor = Color.Blue;
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600023E RID: 574 RVA: 0x000091B3 File Offset: 0x000081B3
		// (set) Token: 0x0600023F RID: 575 RVA: 0x000091BB File Offset: 0x000081BB
		public string FileName
		{
			get
			{
				return this.fFileName;
			}
			set
			{
				this.fFileName = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000240 RID: 576 RVA: 0x000091C4 File Offset: 0x000081C4
		// (set) Token: 0x06000241 RID: 577 RVA: 0x000091CC File Offset: 0x000081CC
		public Color PadsForeColor
		{
			get
			{
				return this.fPadsForeColor;
			}
			set
			{
				this.fPadsForeColor = value;
				foreach (object obj in this.fPads)
				{
					Pad pad = (Pad)obj;
					pad.ForeColor = this.fPadsForeColor;
				}
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00009234 File Offset: 0x00008234
		public Chart()
		{
			this.Init();
			base.Name = "";
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000924D File Offset: 0x0000824D
		public Chart(string Name)
		{
			this.Init();
			base.Name = Name;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00009262 File Offset: 0x00008262
		public Chart(DateTime date)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000926A File Offset: 0x0000826A
		public Pad cd(int padIndex)
		{
			if (padIndex < 1)
			{
				padIndex = 1;
			}
			if (padIndex > this.fPads.Count)
			{
				padIndex = this.fPads.Count;
			}
			Chart.fPad = this.fPads[padIndex - 1];
			return Chart.fPad;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000092A6 File Offset: 0x000082A6
		public void Clear()
		{
			this.fPads.Clear();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000092B4 File Offset: 0x000082B4
		public void SetRangeX(double Min, double Max)
		{
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				pad.SetRangeX(Min, Max);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00009310 File Offset: 0x00008310
		public void SetRangeX(DateTime Min, DateTime Max)
		{
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				pad.SetRangeX(Min, Max);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000936C File Offset: 0x0000836C
		public void SetRangeY(double Min, double Max)
		{
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				pad.SetRangeY(Min, Max);
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000093C8 File Offset: 0x000083C8
		public virtual Pad AddPad(double X1, double Y1, double X2, double Y2)
		{
			Chart.fPad = new Pad(this, X1, Y1, X2, Y2);
			Chart.fPad.Name = "Pad " + (this.fPads.Count + 1).ToString();
			Chart.fPad.ForeColor = this.fPadsForeColor;
			this.fPads.Add(Chart.fPad);
			Chart.fPad.Zoom += this.ZoomChanged;
			return Chart.fPad;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000944A File Offset: 0x0000844A
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00009454 File Offset: 0x00008454
		[RefreshProperties(RefreshProperties.All)]
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
				this.fSessionStart = new TimeSpan(0, 0, 0, 0);
				this.fSessionEnd = new TimeSpan(0, 24, 0, 0);
				foreach (object obj in this.fPads)
				{
					Pad pad = (Pad)obj;
					pad.TransformationType = value;
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000094D4 File Offset: 0x000084D4
		// (set) Token: 0x0600024E RID: 590 RVA: 0x000094DC File Offset: 0x000084DC
		[Description("")]
		[Category("Transformation")]
		public bool SessionGridEnabled
		{
			get
			{
				return this.fSessionGridEnabled;
			}
			set
			{
				this.fSessionGridEnabled = value;
				foreach (object obj in this.fPads)
				{
					Pad pad = (Pad)obj;
					pad.SessionGridEnabled = value;
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000953C File Offset: 0x0000853C
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00009544 File Offset: 0x00008544
		[Category("Transformation")]
		[Description("")]
		public Color SessionGridColor
		{
			get
			{
				return this.fSessionGridColor;
			}
			set
			{
				this.fSessionGridColor = value;
				foreach (object obj in this.fPads)
				{
					Pad pad = (Pad)obj;
					pad.SessionGridColor = value;
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000095A4 File Offset: 0x000085A4
		// (set) Token: 0x06000252 RID: 594 RVA: 0x000095AC File Offset: 0x000085AC
		[Description("")]
		[Category("Transformation")]
		public TimeSpan SessionStart
		{
			get
			{
				return this.fSessionStart;
			}
			set
			{
				this.fSessionStart = value;
				foreach (object obj in this.fPads)
				{
					Pad pad = (Pad)obj;
					pad.SessionStart = value;
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000960C File Offset: 0x0000860C
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00009614 File Offset: 0x00008614
		[Description("")]
		[Category("Transformation")]
		public TimeSpan SessionEnd
		{
			get
			{
				return this.fSessionEnd;
			}
			set
			{
				this.fSessionEnd = value;
				foreach (object obj in this.fPads)
				{
					Pad pad = (Pad)obj;
					pad.SessionEnd = value;
				}
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00009674 File Offset: 0x00008674
		public void Connect()
		{
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				pad.Zoom += this.ZoomChanged;
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000096D8 File Offset: 0x000086D8
		public void Disconnect()
		{
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				pad.Zoom -= this.ZoomChanged;
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000973C File Offset: 0x0000873C
		protected void ZoomChanged(object sender, ZoomEventArgs e)
		{
			if (this.GroupZoomEnabled)
			{
				foreach (object obj in this.fPads)
				{
					Pad pad = (Pad)obj;
					if (e.fZoomUnzoom)
					{
						pad.AxisBottom.SetRange(e.XMin, e.XMax);
						pad.AxisTop.SetRange(e.XMin, e.XMax);
						pad.AxisBottom.Zoomed = true;
						pad.AxisTop.Zoomed = true;
					}
					else
					{
						pad.UnZoom();
					}
				}
				this.UpdatePads();
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000097F8 File Offset: 0x000087F8
		private void AdaptLeftMargin()
		{
			int num = 0;
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				num = Math.Max(num, pad.AxisLeft.LastValidAxisWidth);
			}
			foreach (object obj2 in this.fPads)
			{
				Pad pad2 = (Pad)obj2;
				pad2.MarginLeft = num - pad2.AxisLeft.LastValidAxisWidth;
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000098BC File Offset: 0x000088BC
		private void AdaptRightMargin()
		{
			int num = 0;
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				num = Math.Max(num, pad.AxisRight.LastValidAxisWidth);
			}
			foreach (object obj2 in this.fPads)
			{
				Pad pad2 = (Pad)obj2;
				pad2.MarginRight = num - pad2.AxisRight.LastValidAxisWidth;
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00009980 File Offset: 0x00008980
		public void Divide(int X, int Y)
		{
			this.fPads.Clear();
			double num = 1.0 / (double)X;
			double num2 = 1.0 / (double)Y;
			for (int i = 0; i < Y; i++)
			{
				for (int j = 0; j < X; j++)
				{
					double x = (double)j * num;
					double x2 = (double)(j + 1) * num;
					double y = (double)i * num2;
					double y2 = (double)(i + 1) * num2;
					this.AddPad(x, y, x2, y2);
				}
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00009A00 File Offset: 0x00008A00
		public void Divide(int X, int Y, double[] Widths, double[] Heights)
		{
			this.fPads.Clear();
			double num = 0.0;
			double num2 = 0.0;
			for (int i = 0; i < Y; i++)
			{
				if (i > 0)
				{
					num += Heights[i - 1];
				}
				num2 += Heights[i];
				double x = 0.0;
				double num3 = 0.0;
				for (int j = 0; j < X; j++)
				{
					if (j > 0)
					{
						x = Widths[j - 1];
					}
					num3 += Widths[j];
					this.AddPad(x, num, num3, num2);
				}
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00009A94 File Offset: 0x00008A94
		public void UpdatePads(Graphics PadGraphics, int X, int Y, int Width, int Height)
		{
			PadGraphics.Clear(this.BackColor);
			if (this.SmoothingEnabled)
			{
				PadGraphics.SmoothingMode = SmoothingMode.AntiAlias;
			}
			if (this.AntiAliasingEnabled)
			{
				PadGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
			}
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				pad.SetCanvas(Width, Height);
				pad.X1 += X;
				pad.X2 += X;
				pad.Y1 += Y;
				pad.Y2 += Y;
				pad.Update(PadGraphics);
				pad.X1 -= X;
				pad.X2 -= X;
				pad.Y1 -= Y;
				pad.Y2 -= Y;
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00009B98 File Offset: 0x00008B98
		public Bitmap GetBitmap()
		{
			return new Bitmap(this.GetMetafile(EmfType.EmfPlusOnly));
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00009BA8 File Offset: 0x00008BA8
		public Bitmap GetBitmap(float Dpi)
		{
			Graphics graphics = base.CreateGraphics();
			int width = (int)((float)base.ClientRectangle.Width * Dpi / graphics.DpiX);
			int height = (int)((float)base.ClientRectangle.Height * Dpi / graphics.DpiY);
			Bitmap bitmap = new Bitmap(width, height);
			bitmap.SetResolution(Dpi, Dpi);
			graphics = Graphics.FromImage(bitmap);
			graphics.Clear(this.BackColor);
			if (this.SmoothingEnabled)
			{
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
			}
			if (this.AntiAliasingEnabled)
			{
				graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
			}
			if (this.GroupLeftMarginEnabled)
			{
				this.AdaptLeftMargin();
			}
			if (this.GroupRightMarginEnabled)
			{
				this.AdaptRightMargin();
			}
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				pad.SetCanvas(width, height);
				pad.Update(graphics);
			}
			graphics.Dispose();
			return bitmap;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00009CB4 File Offset: 0x00008CB4
		public Metafile GetMetafile(EmfType type)
		{
			int width = base.ClientRectangle.Width;
			int height = base.ClientRectangle.Height;
			Graphics graphics = base.CreateGraphics();
			IntPtr hdc = graphics.GetHdc();
			Metafile metafile = new Metafile(hdc, type);
			graphics.ReleaseHdc(hdc);
			graphics.Dispose();
			graphics = Graphics.FromImage(metafile);
			graphics.Clear(this.BackColor);
			if (this.SmoothingEnabled)
			{
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
			}
			if (this.AntiAliasingEnabled)
			{
				graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
			}
			if (this.GroupLeftMarginEnabled)
			{
				this.AdaptLeftMargin();
			}
			if (this.GroupRightMarginEnabled)
			{
				this.AdaptRightMargin();
			}
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				pad.SetCanvas(width, height);
				pad.Update(graphics);
			}
			graphics.Dispose();
			return metafile;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00009DBC File Offset: 0x00008DBC
		public void SaveImage(string filename, ImageFormat format)
		{
			Metafile metafile = this.GetMetafile(EmfType.EmfPlusOnly);
			metafile.Save(filename, format);
			metafile.Dispose();
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00009DDF File Offset: 0x00008DDF
		public void UpdatePads()
		{
			base.Invalidate();
			Application.DoEvents();
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00009DEC File Offset: 0x00008DEC
		public void UpdatePads(Graphics g)
		{
			if (base.Disposing)
			{
				return;
			}
			if (this.fIsUpdating)
			{
				return;
			}
			this.fIsUpdating = true;
			int width = base.ClientRectangle.Width;
			int height = base.ClientRectangle.Height;
			Bitmap bitmap = null;
			Graphics graphics;
			try
			{
				if (this.fDoubleBufferingEnabled)
				{
					bitmap = new Bitmap(width, height);
					graphics = Graphics.FromImage(bitmap);
				}
				else
				{
					graphics = g;
				}
			}
			catch
			{
				this.fIsUpdating = false;
				return;
			}
			graphics.Clear(this.BackColor);
			if (this.SmoothingEnabled)
			{
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
			}
			if (this.AntiAliasingEnabled)
			{
				graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
			}
			if (this.GroupLeftMarginEnabled)
			{
				this.AdaptLeftMargin();
			}
			if (this.GroupRightMarginEnabled)
			{
				this.AdaptRightMargin();
			}
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				pad.SetCanvas(width, height);
				pad.Update(graphics);
			}
			if (this.fDoubleBufferingEnabled)
			{
				Graphics graphics2 = null;
				try
				{
					graphics2 = g;
				}
				catch
				{
					this.fIsUpdating = false;
					return;
				}
				if (graphics2 != null)
				{
					graphics2.DrawImage(bitmap, 0, 0);
					if (this.fFileName != null)
					{
						bitmap.Save(this.FileName, ImageFormat.Gif);
					}
					bitmap.Dispose();
					graphics2.Dispose();
				}
			}
			graphics.Dispose();
			this.fIsUpdating = false;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00009F78 File Offset: 0x00008F78
		public virtual void Print()
		{
			this.PrintDocument.Print();
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00009F88 File Offset: 0x00008F88
		public virtual void PrintPreview()
		{
			new PrintPreviewDialog
			{
				Document = this.PrintDocument
			}.Show();
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00009FB0 File Offset: 0x00008FB0
		public virtual void PrintSetup()
		{
			new PrintDialog
			{
				Document = this.PrintDocument
			}.ShowDialog();
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00009FD8 File Offset: 0x00008FD8
		public virtual void PrintPageSetup()
		{
			new PageSetupDialog
			{
				Document = this.PrintDocument
			}.ShowDialog();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000A000 File Offset: 0x00009000
		private void OnPrintPage(object sender, PrintPageEventArgs Args)
		{
			int x = this.fPrintX;
			int y = this.fPrintY;
			switch (this.fPrintAlign)
			{
			case EPrintAlign.Veritcal:
				y = (Args.PageBounds.Height - this.fPrintHeight) / 2;
				break;
			case EPrintAlign.Horizontal:
				x = (Args.PageBounds.Width - this.fPrintWidth) / 2;
				break;
			case EPrintAlign.Center:
				x = (Args.PageBounds.Width - this.fPrintWidth) / 2;
				y = (Args.PageBounds.Height - this.fPrintHeight) / 2;
				break;
			}
			this.UpdatePads(Args.Graphics, x, y, this.fPrintWidth, this.fPrintHeight);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000A0B7 File Offset: 0x000090B7
		protected void InitializeComponent()
		{
			base.Size = new Size(272, 168);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000A0CE File Offset: 0x000090CE
		protected override void OnPaint(PaintEventArgs pe)
		{
			this.UpdatePads(pe.Graphics);
			base.OnPaint(pe);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000A0E3 File Offset: 0x000090E3
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000A0E8 File Offset: 0x000090E8
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (this.fPadSplit)
			{
				Pad pad = this.fPads[this.fPadSplitIndex];
				int width = base.ClientRectangle.Width;
				int height = base.ClientRectangle.Height;
				double num = (double)e.Y / (double)height;
				pad.SetCanvas(pad.CanvasX1, num, pad.CanvasX2, pad.CanvasY2, width, height);
				if (this.fPadSplitIndex != 0)
				{
					pad = this.fPads[this.fPadSplitIndex - 1];
					pad.SetCanvas(pad.CanvasX1, pad.CanvasY1, pad.CanvasX2, num, width, height);
				}
				this.UpdatePads();
			}
			foreach (object obj in this.fPads)
			{
				Pad pad2 = (Pad)obj;
				if (pad2.Y1 - 1 <= e.Y && e.Y <= pad2.Y1 + 1)
				{
					if (Cursor.Current != Cursors.HSplit)
					{
						Cursor.Current = Cursors.HSplit;
					}
					return;
				}
			}
			foreach (object obj2 in this.fPads)
			{
				Pad pad3 = (Pad)obj2;
				if (pad3.X1 <= e.X && pad3.X2 >= e.X && pad3.Y1 <= e.Y && pad3.Y2 >= e.Y)
				{
					pad3.MouseMove(e);
				}
			}
			base.OnMouseMove(e);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000A2B8 File Offset: 0x000092B8
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				if (pad.X1 <= e.X && pad.X2 >= e.X && pad.Y1 <= e.Y && pad.Y2 >= e.Y)
				{
					pad.MouseWheel(e);
				}
			}
			base.OnMouseWheel(e);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000A350 File Offset: 0x00009350
		protected override void OnMouseDown(MouseEventArgs e)
		{
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				if (pad.Y1 - 1 <= e.Y && e.Y <= pad.Y1 + 1)
				{
					this.fPadSplit = true;
					this.fPadSplitIndex = this.fPads.IndexOf(pad);
					return;
				}
			}
			foreach (object obj2 in this.fPads)
			{
				Pad pad2 = (Pad)obj2;
				if (pad2.X1 <= e.X && pad2.X2 >= e.X && pad2.Y1 <= e.Y && pad2.Y2 >= e.Y)
				{
					pad2.MouseDown(e);
				}
			}
			base.OnMouseDown(e);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000A470 File Offset: 0x00009470
		protected override void OnMouseUp(MouseEventArgs e)
		{
			if (this.fPadSplit)
			{
				this.fPadSplit = false;
				if (this.PadSplitMouseUp != null)
				{
					this.PadSplitMouseUp(this, EventArgs.Empty);
				}
				return;
			}
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				pad.MouseUp(e);
			}
			base.OnMouseUp(e);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000A4FC File Offset: 0x000094FC
		protected override void OnDoubleClick(EventArgs e)
		{
			Point point = base.PointToClient(Cursor.Position);
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				if (pad.X1 <= point.X && pad.X2 >= point.X && pad.Y1 <= point.Y && pad.Y2 >= point.Y)
				{
					pad.DoubleClick(point.X, point.Y);
				}
			}
			base.OnDoubleClick(e);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000A5B4 File Offset: 0x000095B4
		protected override void Dispose(bool disposing)
		{
			foreach (object obj in this.fPads)
			{
				Pad pad = (Pad)obj;
				pad.Monitored = false;
			}
			base.Dispose(disposing);
		}

		// Token: 0x040000EE RID: 238
		protected static Pad fPad;

		// Token: 0x040000EF RID: 239
		protected PadList fPads;

		// Token: 0x040000F0 RID: 240
		protected bool fPadSplit;

		// Token: 0x040000F1 RID: 241
		protected int fPadSplitIndex;

		// Token: 0x040000F2 RID: 242
		protected bool fDoubleBufferingEnabled;

		// Token: 0x040000F3 RID: 243
		protected bool fSmoothingEnabled;

		// Token: 0x040000F4 RID: 244
		protected bool fAntiAliasingEnabled;

		// Token: 0x040000F5 RID: 245
		protected bool fIsUpdating;

		// Token: 0x040000F6 RID: 246
		protected bool fGroupZoomEnabled;

		// Token: 0x040000F7 RID: 247
		protected bool fGroupLeftMarginEnabled;

		// Token: 0x040000F8 RID: 248
		protected bool fGroupRightMarginEnabled;

		// Token: 0x040000F9 RID: 249
		protected string fFileName;

		// Token: 0x040000FA RID: 250
		protected ToolTip fToolTip;

		// Token: 0x040000FB RID: 251
		protected PrintDocument fPrintDocument;

		// Token: 0x040000FC RID: 252
		protected int fPrintX;

		// Token: 0x040000FD RID: 253
		protected int fPrintY;

		// Token: 0x040000FE RID: 254
		protected int fPrintWidth;

		// Token: 0x040000FF RID: 255
		protected int fPrintHeight;

		// Token: 0x04000100 RID: 256
		protected EPrintAlign fPrintAlign;

		// Token: 0x04000101 RID: 257
		protected EPrintLayout fPrintLayout;

		// Token: 0x04000102 RID: 258
		protected ETransformationType fTransformationType;

		// Token: 0x04000103 RID: 259
		protected Color fSessionGridColor;

		// Token: 0x04000104 RID: 260
		protected TimeSpan fSessionStart;

		// Token: 0x04000105 RID: 261
		protected TimeSpan fSessionEnd;

		// Token: 0x04000106 RID: 262
		protected bool fSessionGridEnabled;

		// Token: 0x04000107 RID: 263
		protected Color fPadsForeColor;
	}
}
