using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using SmartQuant.Services;
using SmartQuant.Simulation.Xml;

namespace SmartQuant.Simulation
{
	// Token: 0x02000002 RID: 2
	public class SimulationExecutionService : ServiceBase, IExecutionService, IMarketService, IService
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		public SimulationExecutionService()
		{
			this.entries = new OrderEntryList();
			this.entryQueue = new List<OrderEntry>();
			this.LoadConfiguration();
			ServiceManager.Add(this);
			ServiceManager.ExecutionSimulator = this;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002080 File Offset: 0x00001080
		[Category("Settings")]
		public OrderEntryList Entries
		{
			get
			{
				return this.entries;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002088 File Offset: 0x00001088
		[Category("Information")]
		public override byte Id
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000208B File Offset: 0x0000108B
		[Category("Information")]
		public override string Name
		{
			get
			{
				return "Simulator(execution)";
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002092 File Offset: 0x00001092
		[Category("Information")]
		public override string Description
		{
			get
			{
				return "Simulation Execution Service";
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002099 File Offset: 0x00001099
		[Category("Status")]
		public override ServiceStatus Status
		{
			get
			{
				return base.Status;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020A4 File Offset: 0x000010A4
		public override void Start()
		{
			if (this.status == ServiceStatus.Stopped)
			{
				Simulator simulator = ((SimulationDataProvider)ProviderManager.MarketDataSimulator).Simulator;
				simulator.StateChanged += this.simulator_StateChanged;
				simulator.NewObject += this.simulator_NewObject;
				base.SetServiceStatus(ServiceStatus.Started);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020F4 File Offset: 0x000010F4
		public override void Stop()
		{
			if (this.status == ServiceStatus.Started)
			{
				Simulator simulator = ((SimulationDataProvider)ProviderManager.MarketDataSimulator).Simulator;
				simulator.StateChanged -= this.simulator_StateChanged;
				simulator.NewObject -= this.simulator_NewObject;
				base.SetServiceStatus(ServiceStatus.Stopped);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000009 RID: 9 RVA: 0x00002145 File Offset: 0x00001145
		// (remove) Token: 0x0600000A RID: 10 RVA: 0x0000215E File Offset: 0x0000115E
		public event FIXNewOrderSingleEventHandler NewOrderSingle;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600000B RID: 11 RVA: 0x00002177 File Offset: 0x00001177
		// (remove) Token: 0x0600000C RID: 12 RVA: 0x00002190 File Offset: 0x00001190
		public event FIXOrderCancelRequestEventHandler OrderCancelRequest;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600000D RID: 13 RVA: 0x000021A9 File Offset: 0x000011A9
		// (remove) Token: 0x0600000E RID: 14 RVA: 0x000021C2 File Offset: 0x000011C2
		public event FIXOrderCancelReplaceRequestEventHandler OrderCancelReplaceRequest;

		// Token: 0x0600000F RID: 15 RVA: 0x000021DB File Offset: 0x000011DB
		public void Send(FIXExecutionReport message)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021DD File Offset: 0x000011DD
		public void Send(FIXOrderCancelReject message)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000011 RID: 17 RVA: 0x000021E9 File Offset: 0x000011E9
		// (remove) Token: 0x06000012 RID: 18 RVA: 0x00002202 File Offset: 0x00001202
		public event FIXLogonEventHandler Logon;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000013 RID: 19 RVA: 0x0000221B File Offset: 0x0000121B
		// (remove) Token: 0x06000014 RID: 20 RVA: 0x00002234 File Offset: 0x00001234
		public event FIXLogoutEventHandler Logout;

		// Token: 0x06000015 RID: 21 RVA: 0x0000224D File Offset: 0x0000124D
		public void Send(FIXLogon message)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002259 File Offset: 0x00001259
		public void Send(FIXLogout message)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002268 File Offset: 0x00001268
		private void simulator_StateChanged(object sender, EventArgs e)
		{
			Simulator simulator = ((SimulationDataProvider)ProviderManager.MarketDataSimulator).Simulator;
			switch (simulator.CurrentState)
			{
			case SimulatorState.Stopped:
				this.entryQueue.Clear();
				return;
			case SimulatorState.Running:
				this.entryQueue.Clear();
				foreach (object obj in this.entries)
				{
					OrderEntry orderEntry = (OrderEntry)obj;
					if (orderEntry.Enabled)
					{
						this.entryQueue.Add(orderEntry);
					}
				}
				return;
			default:
				return;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002310 File Offset: 0x00001310
		private void simulator_NewObject(SeriesObjectEventArgs args)
		{
			while (this.entryQueue.Count > 0)
			{
				OrderEntry orderEntry = this.entryQueue[0];
				if (!(orderEntry.DateTime <= args.Object.DateTime))
				{
					break;
				}
				this.entryQueue.RemoveAt(0);
				this.EmitNewOrderSingle(orderEntry);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002368 File Offset: 0x00001368
		private void EmitNewOrderSingle(OrderEntry entry)
		{
			SingleOrder singleOrder = new SingleOrder();
			singleOrder.TransactTime = Clock.Now;
			singleOrder.Instrument = entry.Instrument;
			singleOrder.Side = entry.Side;
			singleOrder.OrdType = entry.OrdType;
			singleOrder.Price = entry.Price;
			singleOrder.StopPx = entry.StopPx;
			singleOrder.OrderQty = entry.OrderQty;
			singleOrder.Text = entry.Text;
			if (this.NewOrderSingle != null)
			{
				this.NewOrderSingle(this, new FIXNewOrderSingleEventArgs(singleOrder));
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000023F4 File Offset: 0x000013F4
		internal void SaveConfiguration()
		{
			SimulationExecutionServiceXmlDocument simulationExecutionServiceXmlDocument = new SimulationExecutionServiceXmlDocument();
			foreach (object obj in this.entries)
			{
				OrderEntry entry = (OrderEntry)obj;
				simulationExecutionServiceXmlDocument.Entries.Add(entry);
			}
			simulationExecutionServiceXmlDocument.Save(this.GetConfigurationFileName());
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002468 File Offset: 0x00001468
		private void LoadConfiguration()
		{
			string configurationFileName = this.GetConfigurationFileName();
			if (File.Exists(configurationFileName))
			{
				SimulationExecutionServiceXmlDocument simulationExecutionServiceXmlDocument = new SimulationExecutionServiceXmlDocument();
				simulationExecutionServiceXmlDocument.Load(configurationFileName);
				foreach (object obj in simulationExecutionServiceXmlDocument.Entries)
				{
					OrderEntryXmlNode orderEntryXmlNode = (OrderEntryXmlNode)obj;
					OrderEntry orderEntry = new OrderEntry();
					orderEntry.Enabled = orderEntryXmlNode.Enabled;
					orderEntry.DateTime = orderEntryXmlNode.DateTime.Value;
					orderEntry.Instrument = InstrumentManager.Instruments[orderEntryXmlNode.Symbol.Value];
					orderEntry.Side = orderEntryXmlNode.Side.Value;
					orderEntry.OrdType = orderEntryXmlNode.OrdType.Value;
					orderEntry.Price = orderEntryXmlNode.Price.Value;
					orderEntry.StopPx = orderEntryXmlNode.StopPx.Value;
					orderEntry.OrderQty = orderEntryXmlNode.OrderQty.Value;
					orderEntry.Text = orderEntryXmlNode.Text.Value;
					this.entries.Add(orderEntry);
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002598 File Offset: 0x00001598
		private string GetConfigurationFileName()
		{
			return string.Format("{0}\\{1}", Framework.Installation.IniDir.FullName, "simulator.execution.xml");
		}

		// Token: 0x04000001 RID: 1
		private const string CATEGORY_INFO = "Information";

		// Token: 0x04000002 RID: 2
		private const string CATEGORY_STATUS = "Status";

		// Token: 0x04000003 RID: 3
		private const string CATEGORY_SETTINGS = "Settings";

		// Token: 0x04000004 RID: 4
		private const string CONFIGURATION_FILE_NAME = "simulator.execution.xml";

		// Token: 0x04000005 RID: 5
		private OrderEntryList entries;

		// Token: 0x04000006 RID: 6
		private List<OrderEntry> entryQueue;
	}
}
