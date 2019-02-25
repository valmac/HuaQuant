using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace SmartQuant.Trading.Design
{
	// Token: 0x02000008 RID: 8
	internal class RequestListEditor : CollectionEditor
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00004E61 File Offset: 0x00003E61
		public RequestListEditor() : base(typeof(RequestList))
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004E74 File Offset: 0x00003E74
		protected override object CreateInstance(Type itemType)
		{
			if (itemType != typeof(string))
			{
				throw new ArgumentException("Cannot create an instance of the type - " + itemType.ToString());
			}
			string result = null;
			NewRequestForm newRequestForm = new NewRequestForm();
			if (newRequestForm.ShowDialog() == DialogResult.OK)
			{
				result = newRequestForm.Request;
			}
			newRequestForm.Dispose();
			return result;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004EC3 File Offset: 0x00003EC3
		protected override IList GetObjectsFromInstance(object instance)
		{
			if (instance == null)
			{
				return null;
			}
			return base.GetObjectsFromInstance(instance);
		}
	}
}
