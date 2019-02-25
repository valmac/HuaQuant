using System;

namespace SmartQuant.Simulation
{
	// Token: 0x02000016 RID: 22
	public class Interval
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00003C64 File Offset: 0x00002C64
		public Interval(DateTime begin, DateTime end)
		{
			if (end < begin)
			{
				throw new ArgumentException("The end date/time less than begin");
			}
			this.begin = begin;
			this.end = end;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003C8E File Offset: 0x00002C8E
		public Interval() : this(new DateTime(1900, 1, 1), new DateTime(2100, 1, 1))
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003CAE File Offset: 0x00002CAE
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00003CB6 File Offset: 0x00002CB6
		public DateTime Begin
		{
			get
			{
				return this.begin;
			}
			set
			{
				this.begin = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00003CBF File Offset: 0x00002CBF
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00003CC7 File Offset: 0x00002CC7
		public DateTime End
		{
			get
			{
				return this.end;
			}
			set
			{
				this.end = value;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003CD0 File Offset: 0x00002CD0
		public override string ToString()
		{
			return "Interval";
		}

		// Token: 0x04000045 RID: 69
		private DateTime begin;

		// Token: 0x04000046 RID: 70
		private DateTime end;
	}
}
