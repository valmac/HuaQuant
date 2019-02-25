using System;

namespace SmartQuant.Instruments.Design
{
	// Token: 0x02000029 RID: 41
	internal class InstrumentTypeEditor : ComboBoxTypeEditor
	{
		// Token: 0x06000262 RID: 610 RVA: 0x00008229 File Offset: 0x00007229
		protected override object[] GetItems()
		{
			return InstrumentManager.Instruments;
		}
	}
}
