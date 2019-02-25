using System;

namespace SmartQuant.Charting
{
	// Token: 0x0200003A RID: 58
	public class NewTickEventArgs : EventArgs
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000B656 File Offset: 0x0000A656
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000B65E File Offset: 0x0000A65E
		public DateTime DateTime
		{
			get
			{
				return this.fDateTime;
			}
			set
			{
				this.fDateTime = value;
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000B667 File Offset: 0x0000A667
		public NewTickEventArgs(DateTime datetime)
		{
			this.fDateTime = datetime;
		}

		// Token: 0x0400012C RID: 300
		private DateTime fDateTime;
	}
}
