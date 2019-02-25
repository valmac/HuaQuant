using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace SmartQuant.Charting
{
	// Token: 0x0200002D RID: 45
	public class TImage : IDrawable, IMovable
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00008CA9 File Offset: 0x00007CA9
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00008CB1 File Offset: 0x00007CB1
		private Image Image
		{
			get
			{
				return this.fImage;
			}
			set
			{
				this.fImage = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00008CBA File Offset: 0x00007CBA
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00008CC2 File Offset: 0x00007CC2
		[Category("Position")]
		[Description("X position of this image on the pad. (World coordinate system)")]
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

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00008CCB File Offset: 0x00007CCB
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00008CD3 File Offset: 0x00007CD3
		[Description("Y position of this image on the pad. (World coordinate system)")]
		[Category("Position")]
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

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00008CDC File Offset: 0x00007CDC
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00008CE4 File Offset: 0x00007CE4
		[Description("Enable or disable tooltip appearance for this image.")]
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00008CED File Offset: 0x00007CED
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00008CF5 File Offset: 0x00007CF5
		[Category("ToolTip")]
		[Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
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

		// Token: 0x06000213 RID: 531 RVA: 0x00008CFE File Offset: 0x00007CFE
		private void InitImage()
		{
			this.fToolTipEnabled = true;
			this.fToolTipFormat = "X = {0:F2} Y = {1:F2}";
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00008D12 File Offset: 0x00007D12
		public TImage(Image Image, double X, double Y)
		{
			this.fImage = Image;
			this.fX = X;
			this.fY = Y;
			this.InitImage();
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00008D35 File Offset: 0x00007D35
		public TImage(Image Image, DateTime X, double Y)
		{
			this.fImage = Image;
			this.fX = (double)X.Ticks;
			this.fY = Y;
			this.InitImage();
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00008D5F File Offset: 0x00007D5F
		public TImage(string FileName, double X, double Y)
		{
			this.fImage = Image.FromFile(FileName);
			this.fX = X;
			this.fY = Y;
			this.InitImage();
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00008D87 File Offset: 0x00007D87
		public TImage(string FileName, DateTime X, double Y)
		{
			this.fImage = Image.FromFile(FileName);
			this.fX = (double)X.Ticks;
			this.fY = Y;
			this.InitImage();
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00008DB6 File Offset: 0x00007DB6
		public virtual void Draw()
		{
			if (Chart.Pad == null)
			{
				new Canvas("Canvas", "Canvas");
			}
			Chart.Pad.Add(this);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00008DDC File Offset: 0x00007DDC
		public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
		{
			int x = Pad.ClientX(this.fX);
			int y = Pad.ClientY(this.fY);
			Pad.Graphics.DrawImage(this.fImage, x, y);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00008E18 File Offset: 0x00007E18
		public TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			tdistance.X = this.fX;
			tdistance.Y = this.fY;
			tdistance.dX = Math.Abs(X - this.fX);
			tdistance.dY = Math.Abs(Y - this.fY);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(this.fToolTipFormat, this.fX, this.fY);
			tdistance.ToolTipText = stringBuilder.ToString();
			return tdistance;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00008E9F File Offset: 0x00007E9F
		public void Move(double X, double Y, double dX, double dY)
		{
			this.fX += dX;
			this.fY += dY;
		}

		// Token: 0x040000E1 RID: 225
		private Image fImage;

		// Token: 0x040000E2 RID: 226
		private double fX;

		// Token: 0x040000E3 RID: 227
		private double fY;

		// Token: 0x040000E4 RID: 228
		private bool fToolTipEnabled;

		// Token: 0x040000E5 RID: 229
		private string fToolTipFormat;
	}
}
