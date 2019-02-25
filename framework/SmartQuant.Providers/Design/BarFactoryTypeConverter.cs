using System;
using System.ComponentModel;
using System.Globalization;

namespace SmartQuant.Providers.Design
{
	// Token: 0x02000044 RID: 68
	internal class BarFactoryTypeConverter : ExpandableObjectConverter
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00004C4B File Offset: 0x00003C4B
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00004C5A File Offset: 0x00003C5A
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value != null)
			{
				return value.ToString();
			}
			return "(none)";
		}
	}
}
