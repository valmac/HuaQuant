using System;
using System.ComponentModel;
using System.Globalization;

namespace SmartQuant.Trading.Design
{
	// Token: 0x02000076 RID: 118
	public class ComponentTypeConverter : TypeConverter
	{
		// Token: 0x06000508 RID: 1288 RVA: 0x0001198F File Offset: 0x0001098F
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000119A0 File Offset: 0x000109A0
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			IComponentBase componentBase = value as IComponentBase;
			if (componentBase != null)
			{
				return componentBase.Name;
			}
			return "(none)";
		}
	}
}
