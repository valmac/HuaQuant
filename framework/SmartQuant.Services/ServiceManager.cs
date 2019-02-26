using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using SmartQuant.FIX;
using SmartQuant.Services.Xml;
using SmartQuant.Xml;

namespace SmartQuant.Services
{
	// Token: 0x02000015 RID: 21
	public class ServiceManager
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000054 RID: 84 RVA: 0x00002412 File Offset: 0x00001412
		// (remove) Token: 0x06000055 RID: 85 RVA: 0x00002429 File Offset: 0x00001429
		public static event ServiceEventHandler ServiceAdded;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000056 RID: 86 RVA: 0x00002440 File Offset: 0x00001440
		// (remove) Token: 0x06000057 RID: 87 RVA: 0x00002457 File Offset: 0x00001457
		public static event ServiceEventHandler ServiceStatusChanged;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000058 RID: 88 RVA: 0x0000246E File Offset: 0x0000146E
		// (remove) Token: 0x06000059 RID: 89 RVA: 0x00002485 File Offset: 0x00001485
		public static event ServiceErrorEventHandler ServiceError;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600005A RID: 90 RVA: 0x0000249C File Offset: 0x0000149C
		// (remove) Token: 0x0600005B RID: 91 RVA: 0x000024B3 File Offset: 0x000014B3
		public static event LogonEventHandler Logon;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600005C RID: 92 RVA: 0x000024CA File Offset: 0x000014CA
		// (remove) Token: 0x0600005D RID: 93 RVA: 0x000024E1 File Offset: 0x000014E1
		public static event LogoutEventHandler Logout;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600005E RID: 94 RVA: 0x000024F8 File Offset: 0x000014F8
		// (remove) Token: 0x0600005F RID: 95 RVA: 0x0000250F File Offset: 0x0000150F
		public static event NewOrderSingleEventHandler NewOrderSingle;

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002546 File Offset: 0x00001546
		public static ServiceList Services
		{
			get
			{
				return ServiceManager.services;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000254D File Offset: 0x0000154D
		public static ExecutionServiceList ExecutionServices
		{
			get
			{
				return ServiceManager.executionServices;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002554 File Offset: 0x00001554
		public static ServiceErrorList ServiceErrors
		{
			get
			{
				return ServiceManager.serviceErrors;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000255B File Offset: 0x0000155B
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002562 File Offset: 0x00001562
		public static IExecutionService ExecutionSimulator
		{
			get
			{
				return ServiceManager.executionSimulator;
			}
			set
			{
				ServiceManager.executionSimulator = value;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000256C File Offset: 0x0000156C
		public static void Add(IService service)
		{
			if (Framework.Installation.Edition == Edition.Research)
			{
				byte id = service.Id;
				if (id != 1)
				{
					return;
				}
			}
			ServiceManager.services.Add(service);
			ServiceManager.LoadServiceProperties(service);
			service.StatusChanged += ServiceManager.service_StatusChanged;
			service.Error += ServiceManager.service_Error;
			if (service is IMarketService)
			{
				IMarketService marketService = service as IMarketService;
				marketService.Logon += ServiceManager.marketService_Logon;
				marketService.Logout += ServiceManager.marketService_Logout;
			}
			if (service is IExecutionService)
			{
				IExecutionService executionService = service as IExecutionService;
				ServiceManager.executionServices.Add(executionService);
				executionService.NewOrderSingle += ServiceManager.executionService_NewOrderSingle;
				executionService.OrderCancelRequest += ServiceManager.executionService_OrderCancelRequest;
				executionService.OrderCancelReplaceRequest += ServiceManager.executionService_OrderCancelReplaceRequest;
			}
			if (ServiceManager.ServiceAdded != null)
			{
				ServiceManager.ServiceAdded(typeof(ServiceManager), new ServiceEventArgs(service));
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000266B File Offset: 0x0000166B
		private static void service_StatusChanged(object sender, EventArgs e)
		{
			if (ServiceManager.ServiceStatusChanged != null)
			{
				ServiceManager.ServiceStatusChanged(typeof(ServiceManager), new ServiceEventArgs(sender as IService));
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002693 File Offset: 0x00001693
		private static void service_Error(object sender, ServiceErrorEventArgs args)
		{
			ServiceManager.AddServiceError(args.Error);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000026A0 File Offset: 0x000016A0
		private static void AddServiceError(ServiceError error)
		{
			ServiceManager.serviceErrors.Add(error);
			bool flag;
			switch (error.ErrorType)
			{
			case ServiceErrorType.Message:
				flag = Trace.IsLevelEnabled(TraceLevel.Info);
				break;
			case ServiceErrorType.Warning:
				flag = Trace.IsLevelEnabled(TraceLevel.Warning);
				break;
			case ServiceErrorType.Error:
				flag = Trace.IsLevelEnabled(TraceLevel.Error);
				break;
			default:
				flag = false;
				break;
			}
			if (flag)
			{
				Trace.WriteLine(error.ToString());
			}
			if (ServiceManager.ServiceError != null)
			{
				ServiceManager.ServiceError(typeof(ServiceManager), new ServiceErrorEventArgs(error));
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000272C File Offset: 0x0000172C
		private static void AddServiceWarning(IService service, string text)
		{
			ServiceError error = new ServiceError(service, ServiceErrorType.Warning, Clock.Now, text);
			ServiceManager.AddServiceError(error);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002750 File Offset: 0x00001750
		private static void marketService_Logon(object sender, FIXLogonEventArgs e)
		{
			if (ServiceManager.Logon != null)
			{
				LogonEventArgs args = new LogonEventArgs(sender as IMarketService, e.Logon);
				ServiceManager.Logon(typeof(ServiceManager), args);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000278C File Offset: 0x0000178C
		private static void marketService_Logout(object sender, FIXLogoutEventArgs e)
		{
			if (ServiceManager.Logout != null)
			{
				LogoutEventArgs args = new LogoutEventArgs(sender as IMarketService, e.Logout);
				ServiceManager.Logout(typeof(ServiceManager), args);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000027C8 File Offset: 0x000017C8
		private static void executionService_NewOrderSingle(object sender, FIXNewOrderSingleEventArgs e)
		{
			NewOrderSingle order = e.NewOrderSingle as NewOrderSingle;
			if (ServiceManager.NewOrderSingle != null)
			{
				NewOrderSingleEventArgs args = new NewOrderSingleEventArgs(sender as IExecutionService, order);
				ServiceManager.NewOrderSingle(typeof(ServiceManager), args);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000280A File Offset: 0x0000180A
		private static void executionService_OrderCancelRequest(object sender, FIXOrderCancelRequestEventArgs e)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000280C File Offset: 0x0000180C
		private static void executionService_OrderCancelReplaceRequest(object sender, FIXOrderCancelReplaceRequestEventArgs e)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002810 File Offset: 0x00001810
		public static void SaveServiceProperties()
		{
			ServicePropertiesXmlDocument servicePropertiesXmlDocument = new ServicePropertiesXmlDocument();
			foreach (object obj in ServiceManager.services)
			{
				IService service = (IService)obj;
				ServiceXmlNode serviceXmlNode = servicePropertiesXmlDocument.Services.Add(service);
				serviceXmlNode.ServiceName = service.Name;
				foreach (PropertyInfo propertyInfo in service.GetType().GetProperties())
				{
					if (propertyInfo.CanRead && propertyInfo.CanWrite && (propertyInfo.PropertyType.IsValueType || propertyInfo.PropertyType.IsEnum || propertyInfo.PropertyType == typeof(string) || propertyInfo.PropertyType == typeof(TimeSpan)))
					{
						object value = propertyInfo.GetValue(service, null);
						if (value != null)
						{
							serviceXmlNode.Properties.Add(propertyInfo.Name, propertyInfo.PropertyType, Convert.ToString(value, CultureInfo.InvariantCulture));
						}
					}
				}
			}
			servicePropertiesXmlDocument.Save(ServiceManager.GetPropertiesFileName());
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002944 File Offset: 0x00001944
		private static void LoadServiceProperties(IService service)
		{
			string propertiesFileName = ServiceManager.GetPropertiesFileName();
			if (File.Exists(propertiesFileName))
			{
				ServicePropertiesXmlDocument servicePropertiesXmlDocument = new ServicePropertiesXmlDocument();
				servicePropertiesXmlDocument.Load(propertiesFileName);
				ServiceXmlNode serviceXmlNode = servicePropertiesXmlDocument.Services[service.Name];
				if (serviceXmlNode != null)
				{
					foreach (object obj in serviceXmlNode.Properties)
					{
						PropertyXmlNode propertyXmlNode = (PropertyXmlNode)obj;
						if (propertyXmlNode.Type == null)
						{
							ServiceManager.AddServiceWarning(service, string.Format("PropertyName={0}. PropertyValue={1}. Property type is null.", propertyXmlNode.Name, propertyXmlNode.Value));
						}
						else
						{
							PropertyInfo property = service.GetType().GetProperty(propertyXmlNode.Name, propertyXmlNode.Type);
							if (property == null)
							{
								ServiceManager.AddServiceWarning(service, string.Format("PropertyName={0}. PropertyType={1}. PropertyValue={2}. Cannot find property.", propertyXmlNode.Name, propertyXmlNode.Type, propertyXmlNode.Value));
							}
							else
							{
								try
								{
									object obj2;
									if (propertyXmlNode.Type.IsEnum)
									{
										obj2 = Enum.Parse(propertyXmlNode.Type, propertyXmlNode.Value);
									}
									else if (propertyXmlNode.Type == typeof(string))
									{
										obj2 = propertyXmlNode.Value;
									}
									else if (propertyXmlNode.Type == typeof(TimeSpan))
									{
										obj2 = TimeSpan.Parse(propertyXmlNode.Value);
									}
									else
									{
										obj2 = Convert.ChangeType(propertyXmlNode.Value, propertyXmlNode.Type, CultureInfo.InvariantCulture);
									}
									if (obj2 == null)
									{
										ServiceManager.AddServiceWarning(service, string.Format("PropertyName={0}. PropertyType={1}. PropertyValue={2}. Cannot convert value to specified type.", propertyXmlNode.Name, propertyXmlNode.Type, propertyXmlNode.Value));
									}
									else
									{
										property.SetValue(service, obj2, null);
									}
								}
								catch (Exception ex)
								{
									ServiceManager.AddServiceWarning(service, string.Format("PropertyName={0}. PropertyType={1}. PropertyValue={2}. {3}", new object[]
									{
										propertyXmlNode.Name,
										propertyXmlNode.Type,
										propertyXmlNode.Value,
										ex.Message
									}));
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002B68 File Offset: 0x00001B68
		private static string GetPropertiesFileName()
		{
			return string.Format("{0}\\{1}", Framework.Installation.IniDir.FullName, "service.properties.xml");
		}

		// Token: 0x04000010 RID: 16
		private const string PROPERTIES_FILE_NAME = "service.properties.xml";

		// Token: 0x04000011 RID: 17
		private static ServiceList services = new ServiceList();

		// Token: 0x04000012 RID: 18
		private static ExecutionServiceList executionServices = new ExecutionServiceList();

		// Token: 0x04000013 RID: 19
		private static IExecutionService executionSimulator;

		// Token: 0x04000014 RID: 20
		private static ServiceErrorList serviceErrors = new ServiceErrorList();
	}
}
