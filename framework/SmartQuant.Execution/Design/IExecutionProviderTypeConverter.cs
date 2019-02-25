using System;
using System.ComponentModel;
using System.Globalization;
using SmartQuant.Providers;

namespace SmartQuant.Execution.Design
{
	// Token: 0x0200000F RID: 15
	internal class IExecutionProviderTypeConverter : TypeConverter
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00003F49 File Offset: 0x00002F49
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003F58 File Offset: 0x00002F58
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			IExecutionProvider executionProvider = value as IExecutionProvider;
			if (executionProvider != null)
			{
				return executionProvider.Name;
			}
			return "(not set)";
		}
	}
}
