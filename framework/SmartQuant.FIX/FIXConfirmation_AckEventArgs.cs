using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200018B RID: 395
	public class FIXConfirmation_AckEventArgs : EventArgs
	{
		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x06004B1E RID: 19230 RVA: 0x00053133 File Offset: 0x00052133
		// (set) Token: 0x06004B1F RID: 19231 RVA: 0x0005313B File Offset: 0x0005213B
		public FIXConfirmation_Ack Confirmation_Ack
		{
			get
			{
				return this.fConfirmation_Ack;
			}
			set
			{
				this.fConfirmation_Ack = value;
			}
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x00053144 File Offset: 0x00052144
		public FIXConfirmation_AckEventArgs(FIXConfirmation_Ack Confirmation_Ack)
		{
			this.fConfirmation_Ack = Confirmation_Ack;
		}

		// Token: 0x04000DBF RID: 3519
		private FIXConfirmation_Ack fConfirmation_Ack;
	}
}
