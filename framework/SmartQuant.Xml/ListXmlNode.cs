using System;
using System.Collections;

namespace SmartQuant.Xml
{
	// Token: 0x02000006 RID: 6
	public abstract class ListXmlNode<T> : XmlNodeBase, IEnumerable where T : XmlNodeBase, new()
	{
		// Token: 0x06000063 RID: 99 RVA: 0x000028FE File Offset: 0x000018FE
		protected T AppendChildNode()
		{
			return base.AppendChildNode<T>();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002906 File Offset: 0x00001906
		public IEnumerator GetEnumerator()
		{
			return base.GetChildNodes<T>().GetEnumerator();
		}
	}
}
