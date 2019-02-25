using System;
using System.ComponentModel;
using System.Globalization;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x02000013 RID: 19
	internal class CommissionProviderTypeConverter : ExpandableObjectConverter
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00003C09 File Offset: 0x00002C09
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003C18 File Offset: 0x00002C18
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return value.ToString();
		}
	}
}
