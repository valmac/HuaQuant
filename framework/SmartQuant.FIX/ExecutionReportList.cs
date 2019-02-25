using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000E8 RID: 232
	public class ExecutionReportList : FIXGroupList
	{
		// Token: 0x06002E4A RID: 11850 RVA: 0x0003103E File Offset: 0x0003003E
		public new ExecutionReport GetById(int id)
		{
			return base.GetById(id) as ExecutionReport;
		}

		// Token: 0x170014F2 RID: 5362
		public new ExecutionReport this[int index]
		{
			get
			{
				return this.fList[index] as ExecutionReport;
			}
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x00031060 File Offset: 0x00030060
		public static implicit operator ExecutionReport[](ExecutionReportList list)
		{
			ExecutionReport[] array = new ExecutionReport[list.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = list[i];
			}
			return array;
		}
	}
}
