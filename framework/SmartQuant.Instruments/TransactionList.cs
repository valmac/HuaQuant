using System;
using System.Collections;
using System.ComponentModel;
using System.Text;
using SmartQuant.Charting;

namespace SmartQuant.Instruments
{
	// Token: 0x0200004D RID: 77
	public class TransactionList : IEnumerable, IDrawable, IZoomable
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000C81A File Offset: 0x0000B81A
		public int Count
		{
			get
			{
				return this.fList.Count;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000C827 File Offset: 0x0000B827
		public Transaction First
		{
			get
			{
				if (this.fList.Count != 0)
				{
					return this.fList[0] as Transaction;
				}
				return null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000C849 File Offset: 0x0000B849
		public Transaction Last
		{
			get
			{
				if (this.fList.Count != 0)
				{
					return this.fList[this.fList.Count - 1] as Transaction;
				}
				return null;
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000C8A7 File Offset: 0x0000B8A7
		public void Add(Transaction transaction)
		{
			this.Add(transaction, true);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000C8B4 File Offset: 0x0000B8B4
		public void Add(Transaction transaction, bool sort)
		{
			this.fList.Add(transaction);
			if (sort && this.fList.Count != 1 && transaction.DateTime < this[this.fList.Count - 2].DateTime)
			{
				this.fList.Sort();
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000C90F File Offset: 0x0000B90F
		public void Remove(Transaction transaction)
		{
			this.fList.Remove(transaction);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000C91D File Offset: 0x0000B91D
		public void RemoveAt(int index)
		{
			this.fList.RemoveAt(index);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000C92B File Offset: 0x0000B92B
		public void Clear()
		{
			this.fList.Clear();
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000C938 File Offset: 0x0000B938
		public bool Contains(Transaction transaction)
		{
			return this.fList.Contains(transaction);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000C946 File Offset: 0x0000B946
		public void Sort()
		{
			this.fList.Sort();
		}

		// Token: 0x170000DB RID: 219
		public Transaction this[int index]
		{
			get
			{
				return this.fList[index] as Transaction;
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000C966 File Offset: 0x0000B966
		public IEnumerator GetEnumerator()
		{
			return this.fList.GetEnumerator();
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000C974 File Offset: 0x0000B974
		public override string ToString()
		{
			string text = "";
			foreach (object obj in this.fList)
			{
				Transaction transaction = (Transaction)obj;
				text = text + transaction.ToString() + Environment.NewLine;
			}
			return text;
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000C9E0 File Offset: 0x0000B9E0
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x0000C9E8 File Offset: 0x0000B9E8
		[Description("Enable or disable tooltip appearance for this marker.")]
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0000C9F1 File Offset: 0x0000B9F1
		// (set) Token: 0x060003BB RID: 955 RVA: 0x0000C9F9 File Offset: 0x0000B9F9
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

		// Token: 0x060003BC RID: 956 RVA: 0x0000CA04 File Offset: 0x0000BA04
		public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			foreach (object obj in this)
			{
				Transaction transaction = (Transaction)obj;
				transaction.Paint(Pad, MinX, MaxX, MinY, MaxY);
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000CA60 File Offset: 0x0000BA60
		public TDistance Distance(double X, double Y)
		{
			Transaction transaction = null;
			double num = double.MaxValue;
			TDistance tdistance = new TDistance();
			foreach (object obj in this)
			{
				Transaction transaction2 = (Transaction)obj;
				double num2 = Math.Abs((double)transaction2.DateTime.Ticks - X);
				if (num2 < num)
				{
					num = num2;
					transaction = transaction2;
				}
			}
			if (transaction != null)
			{
				tdistance.X = (double)transaction.DateTime.Ticks;
				tdistance.Y = transaction.Price;
				tdistance.dX = Math.Abs(X - tdistance.X);
				tdistance.dY = Math.Abs(Y - tdistance.Y);
				StringBuilder stringBuilder = new StringBuilder();
				if (transaction.DateTime.Second != 0 || transaction.DateTime.Minute != 0 || transaction.DateTime.Hour != 0)
				{
					stringBuilder.AppendFormat(this.fToolTipFormat, new object[]
					{
						transaction.Side.ToString(),
						transaction.Instrument.Symbol,
						transaction.Qty,
						transaction.Price,
						transaction.DateTime
					});
				}
				else
				{
					stringBuilder.AppendFormat(this.fToolTipFormat, new object[]
					{
						transaction.Side.ToString(),
						transaction.Instrument.Symbol,
						transaction.Qty,
						transaction.Price,
						transaction.DateTime.ToShortDateString()
					});
				}
				tdistance.ToolTipText = stringBuilder.ToString();
			}
			else
			{
				tdistance.dX = double.MaxValue;
				tdistance.dY = double.MaxValue;
			}
			return tdistance;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000CC78 File Offset: 0x0000BC78
		public void Draw(string option)
		{
			this.fDrawingOption = option;
			Chart.Pad.Add(this);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000CC8C File Offset: 0x0000BC8C
		public void Draw()
		{
			this.Draw("");
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000CC99 File Offset: 0x0000BC99
		public bool IsPadRangeY()
		{
			return false;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000CC9C File Offset: 0x0000BC9C
		public PadRange GetPadRangeY(Pad pad)
		{
			return null;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000CC9F File Offset: 0x0000BC9F
		public bool IsPadRangeX()
		{
			return false;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000CCA2 File Offset: 0x0000BCA2
		public PadRange GetPadRangeX(Pad pad)
		{
			return null;
		}

		// Token: 0x0400010B RID: 267
		private ArrayList fList = new ArrayList();

		// Token: 0x0400010C RID: 268
		protected string fDrawingOption = "";

		// Token: 0x0400010D RID: 269
		protected bool fToolTipEnabled = true;

		// Token: 0x0400010E RID: 270
		protected string fToolTipFormat = "{0} {2} {1} @ {3} {4}";
	}
}
