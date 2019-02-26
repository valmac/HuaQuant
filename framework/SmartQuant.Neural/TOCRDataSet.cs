﻿using System;

namespace SmartQuant.Neural
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	public class TOCRDataSet : TNeuralDataSet
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00004388 File Offset: 0x00003388
		public TOCRDataSet() : base(35, 10)
		{
			this.PrepareData();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000043DC File Offset: 0x000033DC
		public override void PrepareData()
		{
			double[] array = new double[35];
			double[] array2 = new double[10];
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 35; j++)
				{
					array[j] = this.fOCRInput[i, j];
				}
				for (int k = 0; k < 10; k++)
				{
					array2[k] = this.fOCRTarget[i, k];
				}
				base.AddData(this.fNInput, this.fNOutput, array, array2);
			}
			this.fIsChanged = false;
		}

		// Token: 0x04000051 RID: 81
		private double[,] fOCRInput = new double[,]
		{
			{
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0
			},
			{
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0
			},
			{
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0
			},
			{
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0
			},
			{
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0
			},
			{
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0
			},
			{
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0
			},
			{
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0
			},
			{
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0
			},
			{
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0
			}
		};

		// Token: 0x04000052 RID: 82
		private double[,] fOCRTarget = new double[,]
		{
			{
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0
			},
			{
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0
			},
			{
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0
			},
			{
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0
			},
			{
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0
			},
			{
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0,
				0.0
			},
			{
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0,
				0.0
			},
			{
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0,
				0.0
			},
			{
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0,
				0.0
			},
			{
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				0.0,
				1.0
			}
		};
	}
}