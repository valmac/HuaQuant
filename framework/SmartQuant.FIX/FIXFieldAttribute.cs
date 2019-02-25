using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000158 RID: 344
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true)]
	public class FIXFieldAttribute : Attribute
	{
		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06004033 RID: 16435 RVA: 0x00046420 File Offset: 0x00045420
		// (set) Token: 0x06004034 RID: 16436 RVA: 0x00046428 File Offset: 0x00045428
		public int Tag
		{
			get
			{
				return this.fTag;
			}
			set
			{
				this.fTag = value;
			}
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06004035 RID: 16437 RVA: 0x00046431 File Offset: 0x00045431
		// (set) Token: 0x06004036 RID: 16438 RVA: 0x00046439 File Offset: 0x00045439
		public bool Required
		{
			get
			{
				return this.fRequired;
			}
			set
			{
				this.fRequired = value;
			}
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x00046442 File Offset: 0x00045442
		public FIXFieldAttribute(int tag)
		{
			this.fTag = tag;
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00046451 File Offset: 0x00045451
		public FIXFieldAttribute(string Tag, EFieldOption Required)
		{
			this.fTag = int.Parse(Tag);
			if (Required == EFieldOption.Required)
			{
				this.fRequired = true;
			}
		}

		// Token: 0x04000982 RID: 2434
		protected int fTag;

		// Token: 0x04000983 RID: 2435
		protected bool fRequired;
	}
}
