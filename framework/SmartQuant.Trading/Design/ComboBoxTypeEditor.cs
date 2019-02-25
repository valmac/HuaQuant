using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace SmartQuant.Trading.Design
{
	// Token: 0x02000015 RID: 21
	public abstract class ComboBoxTypeEditor : ObjectSelectorEditor
	{
		// Token: 0x0600011E RID: 286 RVA: 0x000054A5 File Offset: 0x000044A5
		protected ComboBoxTypeEditor(bool allowNull)
		{
			this.allowNull = allowNull;
		}

		// Token: 0x0600011F RID: 287
		protected abstract List<KeyValuePair<string, object>> GetItems();

		// Token: 0x06000120 RID: 288 RVA: 0x000054B4 File Offset: 0x000044B4
		protected override void FillTreeWithData(ObjectSelectorEditor.Selector selector, ITypeDescriptorContext context, IServiceProvider provider)
		{
			if (context != null && context.Instance != null)
			{
				this.instance = context.Instance;
				selector.Clear();
				if (this.allowNull)
				{
					selector.AddNode("(none)", null, null);
				}
				foreach (KeyValuePair<string, object> keyValuePair in this.GetItems())
				{
					selector.AddNode(keyValuePair.Key, keyValuePair.Value, null);
				}
				object value = context.PropertyDescriptor.GetValue(context.Instance);
				if (value == null && this.allowNull)
				{
					selector.SelectedNode = selector.Nodes[0];
					return;
				}
				foreach (object obj in selector.Nodes)
				{
					ObjectSelectorEditor.SelectorNode selectorNode = (ObjectSelectorEditor.SelectorNode)obj;
					if (selectorNode.value != null && selectorNode.value.Equals(value))
					{
						selector.SelectedNode = selectorNode;
						break;
					}
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000121 RID: 289 RVA: 0x000055E8 File Offset: 0x000045E8
		public override bool IsDropDownResizable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0400005A RID: 90
		private bool allowNull;

		// Token: 0x0400005B RID: 91
		protected object instance;
	}
}
