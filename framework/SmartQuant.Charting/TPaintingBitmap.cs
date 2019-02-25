using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SmartQuant.Charting
{
	// Token: 0x02000029 RID: 41
	[Serializable]
	public class TPaintingBitmap
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x0000769C File Offset: 0x0000669C
		public TPaintingBitmap()
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000076A4 File Offset: 0x000066A4
		public TPaintingBitmap(int W, int H)
		{
			this.BeginDrawing(W, H);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x000076B5 File Offset: 0x000066B5
		public int Width
		{
			get
			{
				return this.W;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000076BD File Offset: 0x000066BD
		public int Height
		{
			get
			{
				return this.H;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000076C5 File Offset: 0x000066C5
		public bool Valid
		{
			get
			{
				return this.M != null;
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000076D3 File Offset: 0x000066D3
		public bool BeginDrawing(int W, int H)
		{
			this.W = W;
			this.H = H;
			this.Sz = W * H;
			this.M = new int[this.Sz];
			return true;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00007700 File Offset: 0x00006700
		public Bitmap Get()
		{
			Bitmap bitmap = new Bitmap(this.W, this.H, PixelFormat.Format32bppRgb);
			Rectangle rect = new Rectangle(0, 0, this.W, this.H);
			BitmapData bitmapData = bitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
			Marshal.Copy(this.M, 0, bitmapData.Scan0, this.Sz);
			bitmap.UnlockBits(bitmapData);
			return bitmap;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00007767 File Offset: 0x00006767
		public int intGetPixel(int x, int y)
		{
			return this.M[this.W * y + x];
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000777A File Offset: 0x0000677A
		public Color ColorGetPixel(int x, int y)
		{
			return Color.FromArgb(this.M[this.W * y + x]);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00007792 File Offset: 0x00006792
		public void SetPixel(int x, int y, int c)
		{
			this.M[this.W * y + x] = c;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000077A6 File Offset: 0x000067A6
		public void SetPixel(int x, int y, Color c)
		{
			this.M[this.W * y + x] = c.ToArgb();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000077C0 File Offset: 0x000067C0
		public void Fill(int c)
		{
			for (int i = 0; i < this.Sz; i++)
			{
				this.M[i] = c;
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000077E7 File Offset: 0x000067E7
		public void Fill(Color c)
		{
			this.Fill(c.ToArgb());
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000077F8 File Offset: 0x000067F8
		public unsafe void FillRectangle(int c, int x, int y, int w, int h)
		{
			if (x + w > this.W)
			{
				w -= x + w - this.W;
			}
			if (y + h > this.H)
			{
				h -= y + h - this.H;
			}
			if (x < 0)
			{
				w += x;
				x = 0;
			}
			if (y < 0)
			{
				h += y;
				y = 0;
			}
			fixed (int* m = this.M)
			{
				int* ptr = m + this.W * y + x;
				int num = y + h;
				while (y < num)
				{
					int* ptr2 = ptr;
					int* ptr3 = ptr + w;
					while (ptr2 < ptr3)
					{
						*ptr2 = c;
						ptr2++;
					}
					y++;
					ptr += this.W;
				}
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000078C3 File Offset: 0x000068C3
		public void FillRectangle(Color c, int x, int y, int w, int h)
		{
			this.FillRectangle(c.ToArgb(), x, y, w, h);
		}

		// Token: 0x040000BC RID: 188
		public const PixelFormat pixel_format = PixelFormat.Format32bppRgb;

		// Token: 0x040000BD RID: 189
		private int[] M;

		// Token: 0x040000BE RID: 190
		private int W;

		// Token: 0x040000BF RID: 191
		private int H;

		// Token: 0x040000C0 RID: 192
		private int Sz;
	}
}
