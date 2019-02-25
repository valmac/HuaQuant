using System;
using System.ComponentModel;
using System.Globalization;
using SmartQuant.Providers;

namespace SmartQuant.Trading.Design
{
	// Token: 0x02000087 RID: 135
	public class ProviderTypeConverter : TypeConverter
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x00013ADF File Offset: 0x00012ADF
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00013AF0 File Offset: 0x00012AF0
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			IProvider provider = value as IProvider;
			if (provider != null)
			{
				return provider.Name;
			}
			return "(none)";
		}
	}
}
