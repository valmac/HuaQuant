using System;
using System.ComponentModel;

namespace SmartQuant.Optimization
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	public class ParamSet
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		[Browsable(false)]
		public int Count
		{
			get
			{
				return this.fNParam;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00001058
		public ParamSet()
		{
			this.fNParam = 0;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002067 File Offset: 0x00001067
		public ParamSet(double Param1)
		{
			this.fNParam = 0;
			this.SetNParam(1);
			this.fParam[0] = Param1;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002086 File Offset: 0x00001086
		public ParamSet(double Param1, double Param2)
		{
			this.fNParam = 0;
			this.SetNParam(2);
			this.fParam[0] = Param1;
			this.fParam[1] = Param2;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020AE File Offset: 0x000010AE
		public ParamSet(double Param1, double Param2, double Param3)
		{
			this.fNParam = 0;
			this.SetNParam(3);
			this.fParam[0] = Param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020DF File Offset: 0x000010DF
		public ParamSet(double Param1, double Param2, double Param3, double Param4)
		{
			this.fNParam = 0;
			this.SetNParam(4);
			this.fParam[0] = Param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000211C File Offset: 0x0000111C
		public ParamSet(double Param1, double Param2, double Param3, double Param4, double Param5)
		{
			this.fNParam = 0;
			this.SetNParam(5);
			this.fParam[0] = Param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
			this.fParam[4] = Param5;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000216C File Offset: 0x0000116C
		public ParamSet(double Param1, double Param2, double Param3, double Param4, double Param5, double Param6)
		{
			this.fNParam = 0;
			this.SetNParam(6);
			this.fParam[0] = Param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
			this.fParam[4] = Param5;
			this.fParam[5] = Param6;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021C8 File Offset: 0x000011C8
		public ParamSet(double Param1, double Param2, double Param3, double Param4, double Param5, double Param6, double Param7)
		{
			this.fNParam = 0;
			this.SetNParam(7);
			this.fParam[0] = Param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
			this.fParam[4] = Param5;
			this.fParam[5] = Param6;
			this.fParam[6] = Param7;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000222C File Offset: 0x0000122C
		public ParamSet(double Param1, double Param2, double Param3, double Param4, double Param5, double Param6, double Param7, double Param8)
		{
			this.fNParam = 0;
			this.SetNParam(8);
			this.fParam[0] = Param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
			this.fParam[4] = Param5;
			this.fParam[5] = Param6;
			this.fParam[6] = Param7;
			this.fParam[7] = Param8;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000229C File Offset: 0x0000129C
		public ParamSet(double Param1, double Param2, double Param3, double Param4, double Param5, double Param6, double Param7, double Param8, double Param9)
		{
			this.fNParam = 0;
			this.SetNParam(9);
			this.fParam[0] = Param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
			this.fParam[4] = Param5;
			this.fParam[5] = Param6;
			this.fParam[6] = Param7;
			this.fParam[7] = Param8;
			this.fParam[8] = Param9;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002318 File Offset: 0x00001318
		public ParamSet(double Param1, double Param2, double Param3, double Param4, double Param5, double Param6, double Param7, double Param8, double Param9, double Param10)
		{
			this.fNParam = 0;
			this.SetNParam(10);
			this.fParam[0] = Param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
			this.fParam[4] = Param5;
			this.fParam[5] = Param6;
			this.fParam[6] = Param7;
			this.fParam[7] = Param8;
			this.fParam[8] = Param9;
			this.fParam[9] = Param10;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000239C File Offset: 0x0000139C
		public int GetNParam()
		{
			return this.fNParam;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000023A4 File Offset: 0x000013A4
		public double GetParam(int NParam)
		{
			return this.fParam[NParam];
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000023AE File Offset: 0x000013AE
		public EParamType GetParamType(int NParam)
		{
			return this.fParamType[NParam];
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000023B8 File Offset: 0x000013B8
		public string GetParamName(int NParam)
		{
			return this.fParamName[NParam];
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023C2 File Offset: 0x000013C2
		public double GetLowerBound(int NParam)
		{
			return this.fLowerBound[NParam];
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023CC File Offset: 0x000013CC
		public double GetUpperBound(int NParam)
		{
			return this.fUpperBound[NParam];
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023D6 File Offset: 0x000013D6
		public double GetSteps(int NParam)
		{
			return this.fSteps[NParam];
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000023E0 File Offset: 0x000013E0
		public void SetNParam(int NParam)
		{
			if (NParam > this.fNParam)
			{
				double[] array = new double[NParam];
				EParamType[] array2 = new EParamType[NParam];
				string[] array3 = new string[NParam];
				double[] array4 = new double[NParam];
				double[] array5 = new double[NParam];
				bool[] array6 = new bool[NParam];
				double[] array7 = new double[NParam];
				int num = Math.Min(this.fNParam, NParam);
				if (this.fNParam != 0)
				{
					for (int i = 0; i < num; i++)
					{
						array[i] = this.fParam[i];
						array2[i] = this.fParamType[i];
						array3[i] = this.fParamName[i];
						array4[i] = this.fLowerBound[i];
						array5[i] = this.fUpperBound[i];
						array6[i] = this.fIsParamFixed[i];
						array7[i] = this.fSteps[i];
					}
				}
				this.fParam = array;
				this.fParamType = array2;
				this.fParamName = array3;
				this.fLowerBound = array4;
				this.fUpperBound = array5;
				this.fIsParamFixed = array6;
				this.fSteps = array7;
				for (int j = this.fNParam; j < NParam; j++)
				{
					this.fParamType[j] = EParamType.Float;
					this.fParamName[j] = "";
					this.fLowerBound[j] = double.NegativeInfinity;
					this.fUpperBound[j] = double.PositiveInfinity;
					this.fIsParamFixed[j] = false;
					this.fSteps[j] = 0.0;
				}
				this.fNParam = NParam;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000255A File Offset: 0x0000155A
		public void Clear()
		{
			this.fNParam = 0;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002563 File Offset: 0x00001563
		public void SetParam(int NParam, double Param)
		{
			if (NParam + 1 > this.fNParam)
			{
				this.SetNParam(NParam + 1);
			}
			this.fParam[NParam] = Param;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002582 File Offset: 0x00001582
		public void SetParam(int NParam, string ParamName, double Param)
		{
			if (NParam + 1 > this.fNParam)
			{
				this.SetNParam(NParam + 1);
			}
			this.fParamName[NParam] = ParamName;
			this.fParam[NParam] = Param;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000025AA File Offset: 0x000015AA
		public void SetParamName(int NParam, string ParamName)
		{
			if (NParam + 1 > this.fNParam)
			{
				this.SetNParam(NParam + 1);
			}
			this.fParamName[NParam] = ParamName;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000025C9 File Offset: 0x000015C9
		public void SetParamType(int NParam, EParamType Type)
		{
			if (NParam + 1 > this.fNParam)
			{
				this.SetNParam(NParam + 1);
			}
			this.fParamType[NParam] = Type;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000025E8 File Offset: 0x000015E8
		public void SetLowerBound(int NParam, double Bound)
		{
			if (NParam + 1 > this.fNParam)
			{
				this.SetNParam(NParam + 1);
			}
			this.fLowerBound[NParam] = Bound;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002607 File Offset: 0x00001607
		public void SetUpperBound(int NParam, double Bound)
		{
			if (NParam + 1 > this.fNParam)
			{
				this.SetNParam(NParam + 1);
			}
			this.fUpperBound[NParam] = Bound;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002626 File Offset: 0x00001626
		public void SetParamBounds(int NParam, double LowerBound, double UpperBound)
		{
			if (NParam + 1 > this.fNParam)
			{
				this.SetNParam(NParam + 1);
			}
			this.fLowerBound[NParam] = LowerBound;
			this.fUpperBound[NParam] = UpperBound;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000264E File Offset: 0x0000164E
		public void FixParam(int NParam, bool Fixed)
		{
			if (NParam + 1 > this.fNParam)
			{
				this.SetNParam(NParam + 1);
			}
			this.fIsParamFixed[NParam] = Fixed;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000266D File Offset: 0x0000166D
		public void SetSteps(int NParam, double Steps)
		{
			if (NParam + 1 > this.fNParam)
			{
				this.SetNParam(NParam + 1);
			}
			this.fSteps[NParam] = Steps;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000268C File Offset: 0x0000168C
		public bool IsParamFixed(int NParam)
		{
			return this.fIsParamFixed[NParam];
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002698 File Offset: 0x00001698
		public int GetNFixedParam()
		{
			int num = 0;
			for (int i = 0; i < this.fNParam; i++)
			{
				if (this.IsParamFixed(i))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000026C8 File Offset: 0x000016C8
		public double GetMinLowerBound()
		{
			double num = this.fLowerBound[0];
			for (int i = 1; i < this.fNParam; i++)
			{
				num = Math.Min(num, this.fLowerBound[i]);
			}
			return num;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002700 File Offset: 0x00001700
		public double GetMaxLowerBound()
		{
			double num = this.fLowerBound[0];
			for (int i = 1; i < this.fNParam; i++)
			{
				num = Math.Max(num, this.fLowerBound[i]);
			}
			return num;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002738 File Offset: 0x00001738
		public double GetMinUpperBound()
		{
			double num = this.fUpperBound[0];
			for (int i = 1; i < this.fNParam; i++)
			{
				num = Math.Min(num, this.fUpperBound[i]);
			}
			return num;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002770 File Offset: 0x00001770
		public double GetMaxUpperBound()
		{
			double num = this.fUpperBound[0];
			for (int i = 1; i < this.fNParam; i++)
			{
				num = Math.Max(num, this.fUpperBound[i]);
			}
			return num;
		}

		// Token: 0x17000002 RID: 2
		public double this[int Index]
		{
			get
			{
				return this.GetParam(Index);
			}
			set
			{
				this.SetParam(Index, value);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000027BC File Offset: 0x000017BC
		public void Print(string Option)
		{
			Console.WriteLine("NParam = {0}", this.fNParam);
			for (int i = 0; i < this.fNParam; i++)
			{
				Console.WriteLine("param({0}) = {1} : {2}", i, this.fParam[i], this.fParamName[i]);
			}
		}

		// Token: 0x0400000C RID: 12
		protected int fNParam;

		// Token: 0x0400000D RID: 13
		protected double[] fParam;

		// Token: 0x0400000E RID: 14
		protected string[] fParamName;

		// Token: 0x0400000F RID: 15
		protected EParamType[] fParamType;

		// Token: 0x04000010 RID: 16
		protected double[] fLowerBound;

		// Token: 0x04000011 RID: 17
		protected double[] fUpperBound;

		// Token: 0x04000012 RID: 18
		protected bool[] fIsParamFixed;

		// Token: 0x04000013 RID: 19
		protected double[] fSteps;
	}
}
