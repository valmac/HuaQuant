using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Windows.Forms;
using SmartQuant.Data;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x02000028 RID: 40
	internal class DataSeriesListEditor : CollectionEditor
	{
		// Token: 0x06000182 RID: 386 RVA: 0x000084D2 File Offset: 0x000074D2
		public DataSeriesListEditor() : base(typeof(DataSeriesList))
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000084E4 File Offset: 0x000074E4
		protected override object CreateInstance(Type itemType)
		{
			if (itemType == typeof(IDataSeries))
			{
				IDataSeries[] result = null;
				DataSeriesForm dataSeriesForm = new DataSeriesForm();
				if (dataSeriesForm.ShowDialog() == DialogResult.OK)
				{
					result = dataSeriesForm.Series;
				}
				dataSeriesForm.Dispose();
				return result;
			}
			throw new ArgumentException("Cannot create an instance of the type - " + itemType.ToString());
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00008534 File Offset: 0x00007534
		protected override IList GetObjectsFromInstance(object instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ArrayList(instance as ICollection);
		}
	}
}
