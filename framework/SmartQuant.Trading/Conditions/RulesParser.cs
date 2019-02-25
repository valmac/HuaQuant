using System;
using System.Collections;

namespace SmartQuant.Trading.Conditions
{
	// Token: 0x0200000B RID: 11
	public class RulesParser
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00004FCA File Offset: 0x00003FCA
		public RulesParser(string text)
		{
			this.text = text;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004FDC File Offset: 0x00003FDC
		public ArrayList Parse()
		{
			ArrayList arrayList = new ArrayList();
			this.Parse(this.text, 0, arrayList);
			return arrayList;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004FFE File Offset: 0x00003FFE
		private void Parse(string text, int level, ArrayList ruleList)
		{
		}

		// Token: 0x04000044 RID: 68
		protected string text;
	}
}
