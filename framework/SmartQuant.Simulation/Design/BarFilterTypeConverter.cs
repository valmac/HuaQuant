using System;
using System.ComponentModel;
using System.Globalization;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x02000014 RID: 20
	internal class BarFilterTypeConverter : ExpandableObjectConverter
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00003C20 File Offset: 0x00002C20
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003C2F File Offset: 0x00002C2F
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return "";
		}
	}
}
