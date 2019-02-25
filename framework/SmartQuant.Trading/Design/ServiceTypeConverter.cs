using System;
using System.ComponentModel;
using System.Globalization;
using SmartQuant.Services;

namespace SmartQuant.Trading.Design
{
	// Token: 0x02000043 RID: 67
	internal class ServiceTypeConverter : TypeConverter
	{
		// Token: 0x060002CE RID: 718 RVA: 0x0000B8B7 File Offset: 0x0000A8B7
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000B8C8 File Offset: 0x0000A8C8
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			IService service = value as IService;
			if (service != null)
			{
				return service.Name;
			}
			return "(none)";
		}
	}
}
