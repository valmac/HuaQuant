using System;

namespace SmartQuant.Charting
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	public class TDistance
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000041DB File Offset: 0x000031DB
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000041E3 File Offset: 0x000031E3
		public double dX
		{
			get
			{
				return this.fdX;
			}
			set
			{
				this.fdX = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000041EC File Offset: 0x000031EC
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000041F4 File Offset: 0x000031F4
		public double dY
		{
			get
			{
				return this.fdY;
			}
			set
			{
				this.fdY = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000041FD File Offset: 0x000031FD
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00004205 File Offset: 0x00003205
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

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000420E File Offset: 0x0000320E
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00004216 File Offset: 0x00003216
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000421F File Offset: 0x0000321F
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00004227 File Offset: 0x00003227
		public string ToolTipText
		{
			get
			{
				return this.fToolTipText;
			}
			set
			{
				this.fToolTipText = value;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004230 File Offset: 0x00003230
		public TDistance()
		{
			this.fdX = double.MaxValue;
			this.fdY = double.MaxValue;
			this.fToolTipText = null;
		}

		// Token: 0x0400004E RID: 78
		private double fdX;

		// Token: 0x0400004F RID: 79
		private double fdY;

		// Token: 0x04000050 RID: 80
		private double fX;

		// Token: 0x04000051 RID: 81
		private double fY;

		// Token: 0x04000052 RID: 82
		private string fToolTipText;
	}
}
