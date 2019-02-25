using System;
using System.ComponentModel;
using System.Globalization;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Design
{
	// Token: 0x02000014 RID: 20
	internal class TesterComponentTypeConverter : TypeConverter
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00003D4F File Offset: 0x00002D4F
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003D60 File Offset: 0x00002D60
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			TesterItem testerItem = value as TesterItem;
			if (testerItem != null)
			{
				return testerItem.Name;
			}
			return "(none)";
		}
	}
}
