using System;

namespace SmartQuant.Neural
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public class TKohonenData : TNeuralData
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000480D File Offset: 0x0000380D
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00004815 File Offset: 0x00003815
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000481E File Offset: 0x0000381E
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00004826 File Offset: 0x00003826
		public int X
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000482F File Offset: 0x0000382F
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00004837 File Offset: 0x00003837
		public int Y
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

		// Token: 0x060000B1 RID: 177 RVA: 0x00004840 File Offset: 0x00003840
		public TKohonenData()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004848 File Offset: 0x00003848
		public TKohonenData(TKohonenData Data) : base(Data)
		{
			this.fX = Data.fX;
			this.fY = Data.fY;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004869 File Offset: 0x00003869
		public TKohonenData(int NInput) : base(NInput, 0)
		{
			this.fX = 0;
			this.fY = 0;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004881 File Offset: 0x00003881
		public TKohonenData(int NInput, double[] Input) : base(NInput, 0, Input, null)
		{
			this.fX = 0;
			this.fY = 0;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000489B File Offset: 0x0000389B
		public TKohonenData(int NInput, int NOutput) : base(NInput, NOutput)
		{
			this.fX = 0;
			this.fY = 0;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000048B3 File Offset: 0x000038B3
		public TKohonenData(int NInput, int NOutput, double[] Input, double[] Output) : base(NInput, NOutput, Input, Output)
		{
			this.fX = 0;
			this.fY = 0;
		}

		// Token: 0x04000057 RID: 87
		private string fName;

		// Token: 0x04000058 RID: 88
		private int fX;

		// Token: 0x04000059 RID: 89
		private int fY;
	}
}
