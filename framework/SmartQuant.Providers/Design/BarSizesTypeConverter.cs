using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace SmartQuant.Providers.Design
{
	// Token: 0x02000040 RID: 64
	public class BarSizesTypeConverter : TypeConverter
	{
		// Token: 0x0600016F RID: 367 RVA: 0x00004B1E File Offset: 0x00003B1E
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00004B30 File Offset: 0x00003B30
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string) && value is int[])
			{
				List<string> list = new List<string>();
				int[] array = (int[])value;
				if (array.Length == 0)
				{
					list.Add("Not specified.");
				}
				else
				{
					foreach (int barSize in array)
					{
						list.Add(this.BarSizeToString(barSize));
					}
				}
				return string.Join(culture.TextInfo.ListSeparator, list.ToArray());
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00004BBC File Offset: 0x00003BBC
		private string BarSizeToString(int barSize)
		{
			if (barSize % 3600 == 0)
			{
				return string.Format("{0}hour", barSize / 3600);
			}
			if (barSize % 60 == 0)
			{
				return string.Format("{0}min", barSize / 60);
			}
			return string.Format("{0}sec", barSize);
		}
	}
}
