using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using SmartQuant.Xml;

namespace SmartQuant
{
	// Token: 0x02000012 RID: 18
	public class Configuration
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600005F RID: 95 RVA: 0x00003478 File Offset: 0x00002478
		// (remove) Token: 0x06000060 RID: 96 RVA: 0x00003491 File Offset: 0x00002491
		public event ReferenceEventHandler ReferenceAdded;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000061 RID: 97 RVA: 0x000034AA File Offset: 0x000024AA
		// (remove) Token: 0x06000062 RID: 98 RVA: 0x000034C3 File Offset: 0x000024C3
		public event ReferenceEventHandler ReferenceRemoved;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000063 RID: 99 RVA: 0x000034DC File Offset: 0x000024DC
		// (remove) Token: 0x06000064 RID: 100 RVA: 0x000034F5 File Offset: 0x000024F5
		public event ReferenceEventHandler ReferenceEnabledChanged;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000065 RID: 101 RVA: 0x0000350E File Offset: 0x0000250E
		// (remove) Token: 0x06000066 RID: 102 RVA: 0x00003527 File Offset: 0x00002527
		public event PluginEventHandler PluginAdded;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000067 RID: 103 RVA: 0x00003540 File Offset: 0x00002540
		// (remove) Token: 0x06000068 RID: 104 RVA: 0x00003559 File Offset: 0x00002559
		public event PluginEventHandler PluginRemoved;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000069 RID: 105 RVA: 0x00003572 File Offset: 0x00002572
		// (remove) Token: 0x0600006A RID: 106 RVA: 0x0000358B File Offset: 0x0000258B
		public event PluginEventHandler PluginEnabledChanged;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600006B RID: 107 RVA: 0x000035A4 File Offset: 0x000025A4
		// (remove) Token: 0x0600006C RID: 108 RVA: 0x000035BD File Offset: 0x000025BD
		public event EventHandler TraceLevelChanged;

		// Token: 0x0600006D RID: 109 RVA: 0x000035D8 File Offset: 0x000025D8
		internal Configuration()
		{
			this.references = new ReferenceList();
			this.plugins = new PluginList();
			this.traceLevel = System.Diagnostics.TraceLevel.Off;
			this.defaultCurrency = "";
			this.defaultExchange = "";
			this.defaultPortfolio = "";
			this.defaultMarketDataProvider = "";
			this.defaultExecutionProvider = "";
			this.LoadConfig();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003645 File Offset: 0x00002645
		internal void Init()
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003647 File Offset: 0x00002647
		[Browsable(false)]
		public ReferenceList References
		{
			get
			{
				return this.references;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000364F File Offset: 0x0000264F
		[Browsable(false)]
		public PluginList Plugins
		{
			get
			{
				return this.plugins;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00003657 File Offset: 0x00002657
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000365F File Offset: 0x0000265F
		[Description("Gets or sets trace level")]
		[DefaultValue(System.Diagnostics.TraceLevel.Info)]
		[Category("Trace")]
		public System.Diagnostics.TraceLevel TraceLevel
		{
			get
			{
				return this.traceLevel;
			}
			set
			{
				this.traceLevel = value;
				Trace.SetTraceLevel(this.traceLevel);
				this.SaveConfig();
				if (this.TraceLevelChanged != null)
				{
					this.TraceLevelChanged(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003692 File Offset: 0x00002692
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00003699 File Offset: 0x00002699
		[DefaultValue(true)]
		[DisplayName("Enabled")]
		[Category("Error Management")]
		public bool RuntimeErrorManagerEnabled
		{
			get
			{
				return RuntimeErrorManager.Enabled;
			}
			set
			{
				RuntimeErrorManager.Enabled = value;
				this.SaveConfig();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000036A7 File Offset: 0x000026A7
		// (set) Token: 0x06000076 RID: 118 RVA: 0x000036AE File Offset: 0x000026AE
		[DefaultValue(RuntimeErrorOutputTarget.PopupWindow)]
		[DisplayName("Target")]
		[Category("Error Management")]
		public RuntimeErrorOutputTarget RuntimeErrorOutputTarget
		{
			get
			{
				return RuntimeErrorManager.Target;
			}
			set
			{
				RuntimeErrorManager.Target = value;
				this.SaveConfig();
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000036BC File Offset: 0x000026BC
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000036C4 File Offset: 0x000026C4
		[Description("Gets or sets default currency")]
		[Category("Defaults")]
		public string DefaultCurrency
		{
			get
			{
				return this.defaultCurrency;
			}
			set
			{
				this.defaultCurrency = value.Trim();
				this.SaveConfig();
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000036D8 File Offset: 0x000026D8
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000036E0 File Offset: 0x000026E0
		[Description("Gets or sets default exchange")]
		[Category("Defaults")]
		public string DefaultExchange
		{
			get
			{
				return this.defaultExchange;
			}
			set
			{
				this.defaultExchange = value.Trim();
				this.SaveConfig();
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000036F4 File Offset: 0x000026F4
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000036FC File Offset: 0x000026FC
		[Category("Defaults")]
		[Description("Gets or sets default execution provider")]
		public string DefaultExecutionProvider
		{
			get
			{
				return this.defaultExecutionProvider;
			}
			set
			{
				this.defaultExecutionProvider = value.Trim();
				this.SaveConfig();
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00003710 File Offset: 0x00002710
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00003718 File Offset: 0x00002718
		[Description("Gets or sets default market data provider")]
		[Category("Defaults")]
		public string DefaultMarketDataProvider
		{
			get
			{
				return this.defaultMarketDataProvider;
			}
			set
			{
				this.defaultMarketDataProvider = value.Trim();
				this.SaveConfig();
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000372C File Offset: 0x0000272C
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00003734 File Offset: 0x00002734
		[Description("Gets or sets default portfolio")]
		[Category("Defaults")]
		public string DefaultPortfolio
		{
			get
			{
				return this.defaultPortfolio;
			}
			set
			{
				this.defaultPortfolio = value.Trim();
				this.SaveConfig();
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003748 File Offset: 0x00002748
		public void AddReference(Reference reference)
		{
			reference.Configuration = this;
			this.references.Add(reference);
			this.SaveConfig();
			this.EmitReferenceAdded(reference);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000376A File Offset: 0x0000276A
		public void RemoveReference(Reference reference)
		{
			reference.Configuration = null;
			this.references.Remove(reference);
			this.SaveConfig();
			this.EmitReferenceRemoved(reference);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000378C File Offset: 0x0000278C
		public void AddPlugin(Plugin plugin)
		{
			plugin.Configuration = this;
			this.plugins.Add(plugin);
			this.SaveConfig();
			this.EmitPluginAdded(plugin);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000037AE File Offset: 0x000027AE
		public void RemovePlugin(Plugin plugin)
		{
			plugin.Configuration = null;
			this.plugins.Remove(plugin);
			this.SaveConfig();
			this.EmitPluginRemoved(plugin);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000037D0 File Offset: 0x000027D0
		private void EmitReferenceAdded(Reference reference)
		{
			if (this.ReferenceAdded != null)
			{
				this.ReferenceAdded(new ReferenceEventArgs(reference));
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000037EB File Offset: 0x000027EB
		private void EmitReferenceRemoved(Reference reference)
		{
			if (this.ReferenceRemoved != null)
			{
				this.ReferenceRemoved(new ReferenceEventArgs(reference));
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003806 File Offset: 0x00002806
		internal void EmitReferenceEnabledChanged(Reference reference)
		{
			this.SaveConfig();
			if (this.ReferenceEnabledChanged != null)
			{
				this.ReferenceEnabledChanged(new ReferenceEventArgs(reference));
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003827 File Offset: 0x00002827
		private void EmitPluginAdded(Plugin plugin)
		{
			if (this.PluginAdded != null)
			{
				this.PluginAdded(new PluginEventArgs(plugin));
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003842 File Offset: 0x00002842
		private void EmitPluginRemoved(Plugin plugin)
		{
			if (this.PluginRemoved != null)
			{
				this.PluginRemoved(new PluginEventArgs(plugin));
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000385D File Offset: 0x0000285D
		internal void EmitPluginEnabledChanged(Plugin plugin)
		{
			this.SaveConfig();
			if (this.PluginEnabledChanged != null)
			{
				this.PluginEnabledChanged(new PluginEventArgs(plugin));
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003880 File Offset: 0x00002880
		private void LoadConfig()
		{
			string text = Framework.Installation.IniDir.FullName + "\\framework.xml";
			try
			{
				if (File.Exists(text))
				{
					FrameworkXmlDocument frameworkXmlDocument = new FrameworkXmlDocument();
					frameworkXmlDocument.Load(text);
					foreach (object obj in frameworkXmlDocument.References)
					{
						ReferenceXmlNode referenceXmlNode = (ReferenceXmlNode)obj;
						Reference reference = referenceXmlNode.Reference;
						reference.Configuration = this;
						this.references.Add(reference);
					}
					foreach (object obj2 in frameworkXmlDocument.Plugins)
					{
						PluginXmlNode pluginXmlNode = (PluginXmlNode)obj2;
						Plugin plugin = pluginXmlNode.Plugin;
						plugin.Configuration = this;
						this.plugins.Add(plugin);
					}
					this.defaultCurrency = frameworkXmlDocument.Defaults.GetValue("Currency", "USD");
					this.defaultPortfolio = frameworkXmlDocument.Defaults.GetValue("Portfolio", "");
					this.defaultExchange = frameworkXmlDocument.Defaults.GetValue("Exchange", "");
					this.defaultExecutionProvider = frameworkXmlDocument.Defaults.GetValue("ExecutionProvider", "");
					this.defaultMarketDataProvider = frameworkXmlDocument.Defaults.GetValue("MarketDataProvider", "");
					this.traceLevel = frameworkXmlDocument.TraceLevelNode.Level;
					RuntimeErrorManager.Enabled = frameworkXmlDocument.RuntimeErrorNode.Enabled;
					RuntimeErrorManager.Target = frameworkXmlDocument.RuntimeErrorNode.Target;
				}
				else
				{
					this.SaveConfig();
				}
			}
			catch (Exception ex)
			{
				if (Environment.UserInteractive)
				{
					MessageBox.Show("Could not parse configuration file!" + Environment.NewLine + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003AB0 File Offset: 0x00002AB0
		private void SaveConfig()
		{
			FrameworkXmlDocument frameworkXmlDocument = new FrameworkXmlDocument();
			foreach (object obj in this.references)
			{
				Reference reference = (Reference)obj;
				frameworkXmlDocument.References.Add(reference);
			}
			foreach (object obj2 in this.plugins)
			{
				Plugin plugin = (Plugin)obj2;
				frameworkXmlDocument.Plugins.Add(plugin);
			}
			frameworkXmlDocument.Defaults.Add("Currency", this.defaultCurrency);
			frameworkXmlDocument.Defaults.Add("Portfolio", this.defaultPortfolio);
			frameworkXmlDocument.Defaults.Add("Exchange", this.defaultExchange);
			frameworkXmlDocument.Defaults.Add("ExecutionProvider", this.defaultExecutionProvider);
			frameworkXmlDocument.Defaults.Add("MarketDataProvider", this.defaultMarketDataProvider);
			frameworkXmlDocument.TraceLevelNode.Level = this.traceLevel;
			frameworkXmlDocument.RuntimeErrorNode.Enabled = this.RuntimeErrorManagerEnabled;
			frameworkXmlDocument.RuntimeErrorNode.Target = this.RuntimeErrorOutputTarget;
			frameworkXmlDocument.Save(Framework.Installation.IniDir.FullName + "\\framework.xml");
		}

		// Token: 0x04000045 RID: 69
		private const string CATEGORY_TRACE = "Trace";

		// Token: 0x04000046 RID: 70
		private const string CATEGORY_DEFAULTS = "Defaults";

		// Token: 0x04000047 RID: 71
		private const string CATEGORY_ERRORS = "Error Management";

		// Token: 0x04000048 RID: 72
		private const string CONFIG_FILE = "framework.xml";

		// Token: 0x04000049 RID: 73
		private const System.Diagnostics.TraceLevel DEFAULT_TRACE_LEVEL = System.Diagnostics.TraceLevel.Info;

		// Token: 0x0400004A RID: 74
		private const string DEF_CURRENCY = "Currency";

		// Token: 0x0400004B RID: 75
		private const string DEF_PORTFOLIO = "Portfolio";

		// Token: 0x0400004C RID: 76
		private const string DEF_EXCHANGE = "Exchange";

		// Token: 0x0400004D RID: 77
		private const string DEF_EXECUTION_PROVIDER = "ExecutionProvider";

		// Token: 0x0400004E RID: 78
		private const string DEF_MARKET_DATA_PROVIDER = "MarketDataProvider";

		// Token: 0x0400004F RID: 79
		private ReferenceList references;

		// Token: 0x04000050 RID: 80
		private PluginList plugins;

		// Token: 0x04000051 RID: 81
		private System.Diagnostics.TraceLevel traceLevel;

		// Token: 0x04000052 RID: 82
		private string defaultExecutionProvider;

		// Token: 0x04000053 RID: 83
		private string defaultMarketDataProvider;

		// Token: 0x04000054 RID: 84
		private string defaultExchange;

		// Token: 0x04000055 RID: 85
		private string defaultPortfolio;

		// Token: 0x04000056 RID: 86
		private string defaultCurrency;
	}
}
