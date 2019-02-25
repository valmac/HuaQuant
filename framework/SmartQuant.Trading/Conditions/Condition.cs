using System;
using System.Collections;

namespace SmartQuant.Trading.Conditions
{
	// Token: 0x0200002B RID: 43
	public abstract class Condition : RuleItem
	{
		// Token: 0x060001B1 RID: 433
		public abstract string GetInitCode(string name);

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000066EE File Offset: 0x000056EE
		public Hashtable Childs
		{
			get
			{
				return this.childs;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000066F6 File Offset: 0x000056F6
		public Condition()
		{
			this.childs = new Hashtable();
		}

		// Token: 0x0400008C RID: 140
		protected Hashtable childs;
	}
}
