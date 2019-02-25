using System;
using System.Windows.Forms;

namespace SmartQuant
{
	// Token: 0x02000009 RID: 9
	public class Win32Window : IWin32Window
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002D60 File Offset: 0x00001D60
		public Win32Window(IntPtr handle)
		{
			this.handle = handle;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002D6F File Offset: 0x00001D6F
		public IntPtr Handle
		{
			get
			{
				return this.handle;
			}
		}

		// Token: 0x04000030 RID: 48
		private IntPtr handle;
	}
}
