using System;

namespace SmartQuant.DataCenterLib
{
	// Token: 0x02000004 RID: 4
	public class ConnectorEventArgs : EventArgs
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00001050
		public ConnectorEventArgs(IConnector connector)
		{
			this.connector = connector;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000205F File Offset: 0x0000105F
		public IConnector Connector
		{
			get
			{
				return this.connector;
			}
		}

		// Token: 0x04000001 RID: 1
		private IConnector connector;
	}
}
