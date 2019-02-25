using System;

namespace SmartQuant.Instruments
{
	// Token: 0x02000030 RID: 48
	public class MarginPosition
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000893D File Offset: 0x0000793D
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00008945 File Offset: 0x00007945
		public Position Position
		{
			get
			{
				return this.fPosition;
			}
			set
			{
				this.fPosition = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000894E File Offset: 0x0000794E
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00008956 File Offset: 0x00007956
		public double Margin
		{
			get
			{
				return this.fMargin;
			}
			set
			{
				this.fMargin = value;
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000895F File Offset: 0x0000795F
		public MarginPosition(Position position)
		{
			this.fPosition = position;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000896E File Offset: 0x0000796E
		public MarginPosition(Position position, double margin)
		{
			this.fPosition = position;
			this.fMargin = margin;
		}

		// Token: 0x040000B4 RID: 180
		public Position fPosition;

		// Token: 0x040000B5 RID: 181
		public double fMargin;
	}
}
