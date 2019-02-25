using System;
using SmartQuant.Data;

namespace SmartQuant.DataCenterLib
{
	// Token: 0x02000007 RID: 7
	public interface IDataSeriesEnumerator
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15
		int Count { get; }

		// Token: 0x06000010 RID: 16
		IDataObject[] GetNextObjects(int count);
	}
}
