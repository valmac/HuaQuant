using System;

namespace SmartQuant.Quant
{
	// Token: 0x0200000A RID: 10
	public class Vector
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000474C File Offset: 0x0000374C
		public int NRows
		{
			get
			{
				return this.fNRows;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00004754 File Offset: 0x00003754
		public double[] Elements
		{
			get
			{
				return this.fElements;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000475C File Offset: 0x0000375C
		private void Allocate(int nrows, int row_lwb)
		{
			if (nrows <= 0)
			{
				throw new ArgumentException("Number of rows has to be positive");
			}
			this.fNRows = nrows;
			this.fElements = new double[this.fNRows];
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004785 File Offset: 0x00003785
		public Vector()
		{
			this.fNRows = -1;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004794 File Offset: 0x00003794
		public Vector(int nrows)
		{
			this.Allocate(nrows, 0);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000047A4 File Offset: 0x000037A4
		public bool IsValid()
		{
			return this.fNRows != -1;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000047B2 File Offset: 0x000037B2
		public static bool AreCompatible(Vector v1, Vector v2)
		{
			if (!v1.IsValid())
			{
				throw new ArgumentException("Vector 1 is not initialized");
			}
			if (!v2.IsValid())
			{
				throw new ArgumentException("Vector 2 is not initialized");
			}
			return v1.fNRows == v2.fNRows;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000047EC File Offset: 0x000037EC
		public void Zero()
		{
			for (int i = 0; i < this.fNRows; i++)
			{
				this.fElements[i] = 0.0;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000481C File Offset: 0x0000381C
		public void ResizeTo(int newNRows)
		{
			if (newNRows <= 0)
			{
				throw new ArgumentException("Number of rows has to be positive");
			}
			double[] array = new double[newNRows];
			int num = Math.Min(this.fNRows, newNRows);
			for (int i = 0; i < num; i++)
			{
				array[i] = this.fElements[i];
			}
			this.fNRows = newNRows;
			this.fElements = array;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004874 File Offset: 0x00003874
		public double Norm1()
		{
			if (!this.IsValid())
			{
				throw new ApplicationException("Vector is not initialized");
			}
			double num = 0.0;
			foreach (double num2 in this.fElements)
			{
				num += num2;
			}
			return num;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000048C0 File Offset: 0x000038C0
		public double Norm2Sqr()
		{
			if (!this.IsValid())
			{
				throw new ApplicationException("Vector is not initialized");
			}
			double num = 0.0;
			foreach (double num2 in this.fElements)
			{
				num += num2 * num2;
			}
			return num;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000490C File Offset: 0x0000390C
		public double NormInf()
		{
			if (!this.IsValid())
			{
				throw new ApplicationException("Vector is not initialized");
			}
			double num = 0.0;
			foreach (double value in this.fElements)
			{
				num = Math.Max(num, Math.Abs(value));
			}
			return num;
		}

		// Token: 0x1700000F RID: 15
		public double this[int index]
		{
			get
			{
				return this.fElements[index];
			}
			set
			{
				this.fElements[index] = value;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004974 File Offset: 0x00003974
		public static double operator *(Vector v1, Vector v2)
		{
			if (!Vector.AreCompatible(v1, v2))
			{
				throw new ApplicationException("Vectors are not compatible");
			}
			double num = 0.0;
			for (int i = 0; i < v1.fNRows; i++)
			{
				num += v1[i] * v2[i];
			}
			return num;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000049C4 File Offset: 0x000039C4
		public static Vector operator *(Vector vector, double val)
		{
			if (!vector.IsValid())
			{
				throw new ApplicationException("Vector is not initialized");
			}
			Vector vector2 = new Vector(vector.fNRows);
			for (int i = 0; i < vector.fNRows; i++)
			{
				vector2[i] = vector[i] * val;
			}
			return vector2;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004A14 File Offset: 0x00003A14
		public static Vector operator +(Vector vector, double val)
		{
			if (!vector.IsValid())
			{
				throw new ApplicationException("Vector is not initialized");
			}
			Vector vector2 = new Vector(vector.fNRows);
			for (int i = 0; i < vector.fNRows; i++)
			{
				vector2[i] = vector[i] + val;
			}
			return vector2;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004A64 File Offset: 0x00003A64
		public static Vector operator -(Vector vector, double val)
		{
			if (!vector.IsValid())
			{
				throw new ApplicationException("Vector is not initialized");
			}
			Vector vector2 = new Vector(vector.fNRows);
			for (int i = 0; i < vector.fNRows; i++)
			{
				vector2[i] = vector[i] - val;
			}
			return vector2;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004AB4 File Offset: 0x00003AB4
		public Vector Abs()
		{
			if (!this.IsValid())
			{
				throw new ApplicationException("Vector is not initialized");
			}
			Vector vector = new Vector(this.fNRows);
			for (int i = 0; i < this.fNRows; i++)
			{
				vector[i] = Math.Abs(this.fElements[i]);
			}
			return vector;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004B08 File Offset: 0x00003B08
		public Vector Sqr()
		{
			if (!this.IsValid())
			{
				throw new ApplicationException("Vector is not initialized");
			}
			Vector vector = new Vector(this.fNRows);
			for (int i = 0; i < this.fNRows; i++)
			{
				vector[i] = this.fElements[i] * this.fElements[i];
			}
			return vector;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004B60 File Offset: 0x00003B60
		public Vector Sqrt()
		{
			if (!this.IsValid())
			{
				throw new ApplicationException("Vector is not initialized");
			}
			Vector vector = new Vector(this.fNRows);
			for (int i = 0; i < this.fNRows; i++)
			{
				vector[i] = Math.Sqrt(this.fElements[i]);
			}
			return vector;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004BB4 File Offset: 0x00003BB4
		public static Vector operator +(Vector target, Vector source)
		{
			if (!source.IsValid())
			{
				throw new ApplicationException("Source vector is not initialized");
			}
			if (!target.IsValid())
			{
				throw new ApplicationException("Target vector is not initialized");
			}
			if (!Vector.AreCompatible(target, source))
			{
				throw new ApplicationException("Vectors are not compatible");
			}
			Vector vector = new Vector(target.fNRows);
			for (int i = 0; i < target.fNRows; i++)
			{
				vector[i] = target[i] + source[i];
			}
			return vector;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004C30 File Offset: 0x00003C30
		public static Vector operator -(Vector target, Vector source)
		{
			if (!source.IsValid())
			{
				throw new ApplicationException("Source vector is not initialized");
			}
			if (!target.IsValid())
			{
				throw new ApplicationException("Target vector is not initialized");
			}
			if (!Vector.AreCompatible(target, source))
			{
				throw new ApplicationException("Vectors are not compatible");
			}
			Vector vector = new Vector(target.fNRows);
			for (int i = 0; i < target.fNRows; i++)
			{
				vector[i] = target[i] - source[i];
			}
			return vector;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004CAC File Offset: 0x00003CAC
		public Vector ElementMult(Vector target, Vector source)
		{
			if (!source.IsValid())
			{
				throw new ApplicationException("Source vector is not initialized");
			}
			if (!target.IsValid())
			{
				throw new ApplicationException("Target vector is not initialized");
			}
			if (!Vector.AreCompatible(target, source))
			{
				throw new ApplicationException("Vectors are not compatible");
			}
			Vector vector = new Vector(target.fNRows);
			for (int i = 0; i < this.fNRows; i++)
			{
				vector[i] = target[i] * source[i];
			}
			return vector;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004D28 File Offset: 0x00003D28
		public Vector ElementDiv(Vector target, Vector source)
		{
			if (!source.IsValid())
			{
				throw new ApplicationException("Source vector is not initialized");
			}
			if (!target.IsValid())
			{
				throw new ApplicationException("Target vector is not initialized");
			}
			if (!Vector.AreCompatible(target, source))
			{
				throw new ApplicationException("Vectors are not compatible");
			}
			Vector vector = new Vector(target.fNRows);
			for (int i = 0; i < this.fNRows; i++)
			{
				vector[i] = target[i] / source[i];
			}
			return vector;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004DA4 File Offset: 0x00003DA4
		public override bool Equals(object vector)
		{
			Vector vector2 = (Vector)vector;
			if (this.fNRows != vector2.fNRows)
			{
				return false;
			}
			for (int i = 0; i < vector2.fNRows; i++)
			{
				if (this[i] != vector2[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004DEC File Offset: 0x00003DEC
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004DF4 File Offset: 0x00003DF4
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004DFC File Offset: 0x00003DFC
		public void Print()
		{
			this.Print("F2");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004E0C File Offset: 0x00003E0C
		public void Print(string Format)
		{
			for (int i = 0; i < this.fNRows; i++)
			{
				Console.WriteLine(this.fElements[i].ToString(Format) + " ");
			}
		}

		// Token: 0x04000019 RID: 25
		private int fNRows;

		// Token: 0x0400001A RID: 26
		private double[] fElements;
	}
}
