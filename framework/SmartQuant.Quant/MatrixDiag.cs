using System;

namespace SmartQuant.Quant
{
	// Token: 0x0200000B RID: 11
	public class MatrixDiag
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00004E4B File Offset: 0x00003E4B
		public MatrixDiag(Matrix matrix)
		{
			this.fMatrix = matrix;
		}

		// Token: 0x17000010 RID: 16
		public double this[int i]
		{
			get
			{
				if (i >= 0 && i < this.NDiag)
				{
					return this.fMatrix.fElements[i, i];
				}
				this.Error("this[]", "Out of boundry");
				return 0.0;
			}
			set
			{
				if (i >= 0 && i < this.NDiag)
				{
					this.fMatrix.fElements[i, i] = value;
					return;
				}
				this.Error("this[]", "Out of boundry");
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004EC8 File Offset: 0x00003EC8
		public void Assign(MatrixDiag matrixDiag)
		{
			if (Matrix.AreComparable(this.fMatrix, matrixDiag.fMatrix))
			{
				for (int i = 0; i < this.NDiag; i++)
				{
					this[i] = matrixDiag[i];
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004F07 File Offset: 0x00003F07
		public int NDiag
		{
			get
			{
				return Math.Min(this.fMatrix.fCols, this.fMatrix.fRows);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004F24 File Offset: 0x00003F24
		protected void Error(string Where, string What)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004F28 File Offset: 0x00003F28
		public override bool Equals(object matrixDiag)
		{
			MatrixDiag matrixDiag2 = (MatrixDiag)matrixDiag;
			return this.fMatrix.Equals(matrixDiag2.fMatrix);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004F4D File Offset: 0x00003F4D
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004F55 File Offset: 0x00003F55
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0400001B RID: 27
		internal Matrix fMatrix;
	}
}
