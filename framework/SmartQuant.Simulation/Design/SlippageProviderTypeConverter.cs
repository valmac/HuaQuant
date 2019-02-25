using System;
using System.ComponentModel;
using System.Globalization;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x02000012 RID: 18
	internal class SlippageProviderTypeConverter : ExpandableObjectConverter
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00003BEA File Offset: 0x00002BEA
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003BF9 File Offset: 0x00002BF9
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return value.ToString();
		}
	}
}
