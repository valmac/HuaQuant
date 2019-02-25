using System;
using SmartQuant.File.Indexing;

namespace SmartQuant.File
{
	// Token: 0x0200000A RID: 10
	internal class CacheUnit
	{
		// Token: 0x17000002 RID: 2
		internal Block this[long position]
		{
			get
			{
				if (this.Block == null || this.Block.Position != position)
				{
					return null;
				}
				return this.Block;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000024D2 File Offset: 0x000014D2
		internal bool ContainsBlock(Block block)
		{
			return this.Block != null && this.Block.Position == block.Position;
		}

		// Token: 0x04000011 RID: 17
		internal FileSeries Series;

		// Token: 0x04000012 RID: 18
		internal Block Block;

		// Token: 0x04000013 RID: 19
		internal Block Block2;

		// Token: 0x04000014 RID: 20
		internal int CurrentPosition;

		// Token: 0x04000015 RID: 21
		internal int FirstObjectPosition;

		// Token: 0x04000016 RID: 22
		internal Index Index;
	}
}
