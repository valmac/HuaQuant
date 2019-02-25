using System;

namespace SmartQuant.Instruments
{
	// Token: 0x0200004F RID: 79
	public class PositionEventArgs : EventArgs
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x0000CCA5 File Offset: 0x0000BCA5
		public PositionEventArgs(Position position)
		{
			this.position = position;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000CCB4 File Offset: 0x0000BCB4
		public Position Position
		{
			get
			{
				return this.position;
			}
		}

		// Token: 0x0400010F RID: 271
		private Position position;
	}
}
