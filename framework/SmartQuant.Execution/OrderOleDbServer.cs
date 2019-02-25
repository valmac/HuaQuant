using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace SmartQuant.Execution
{
	// Token: 0x02000012 RID: 18
	public class OrderOleDbServer : IOrderServer
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00003FE7 File Offset: 0x00002FE7
		public OrderOleDbServer()
		{
			this.orderTypes = new Hashtable();
			this.orderIds = new Hashtable();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004005 File Offset: 0x00003005
		public void Open()
		{
			this.Open(Framework.Installation.DataDir.FullName + "\\execution.mdb");
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004026 File Offset: 0x00003026
		public void Open(string database)
		{
			this.connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + database);
			this.connection.Open();
			this.UpdateDatabase();
			this.LoadTypes();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004058 File Offset: 0x00003058
		public void AddOrder(IOrder order)
		{
			if (order.Id != -1)
			{
				throw new InvalidOperationException("Cannot add an order.Order already exists in the database");
			}
			lock (this)
			{
				OleDbCommand oleDbCommand = this.connection.CreateCommand();
				oleDbCommand.CommandText = "INSERT INTO ORDERS (TypeID_,InstrumentID_,ProviderID_,PortfolioID_) VALUES(?,?,?,?)";
				oleDbCommand.Parameters.Add("@TypeID_", OleDbType.Integer).Value = this.GetTypeId(order);
				oleDbCommand.Parameters.Add("@InstrumentID_", OleDbType.Integer).Value = order.Instrument.Id;
				oleDbCommand.Parameters.Add("@ProviderID_", OleDbType.Integer).Value = order.Provider.Id;
				oleDbCommand.Parameters.Add("@PortfolioID_", OleDbType.Integer).Value = order.Portfolio.Id;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
				oleDbCommand = this.connection.CreateCommand();
				oleDbCommand.CommandText = "SELECT @@IDENTITY";
				order.Id = (int)oleDbCommand.ExecuteScalar();
				oleDbCommand.Dispose();
				FIXOleDbServer.SaveFIXGroup(this.connection, order as SingleOrder, "ORDER_FIELDS", order.Id);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000041AC File Offset: 0x000031AC
		public void AddReport(IOrder order, FIXExecutionReport report)
		{
			lock (this)
			{
				FIXOleDbServer.RemoveFIXGroup(this.connection, "ORDER_FIELDS", order.Id);
				FIXOleDbServer.SaveFIXGroup(this.connection, order as SingleOrder, "ORDER_FIELDS", order.Id);
				OleDbCommand oleDbCommand = this.connection.CreateCommand();
				oleDbCommand.CommandText = "INSERT INTO REPORTS (ParentID_) VALUES(?)";
				oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = order.Id;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
				oleDbCommand = this.connection.CreateCommand();
				oleDbCommand.CommandText = "SELECT @@IDENTITY";
				report.Id = (int)oleDbCommand.ExecuteScalar();
				oleDbCommand.Dispose();
				FIXOleDbServer.SaveFIXGroup(this.connection, report, "REPORT_FIELDS", report.Id);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004298 File Offset: 0x00003298
		public void Remove(IOrder order)
		{
			lock (this)
			{
				OleDbCommand oleDbCommand = this.connection.CreateCommand();
				oleDbCommand.CommandText = "DELETE FROM ORDERS WHERE ID_=?";
				oleDbCommand.Parameters.Add("@ID_", OleDbType.Integer).Value = order.Id;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000430C File Offset: 0x0000330C
		public void Close()
		{
			this.connection.Close();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000431C File Offset: 0x0000331C
		private void LoadTypes()
		{
			OleDbCommand oleDbCommand = this.connection.CreateCommand();
			oleDbCommand.CommandText = "SELECT * FROM ORDER_TYPES";
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				int @int = oleDbDataReader.GetInt32(0);
				Type type = Type.GetType(oleDbDataReader.GetString(1));
				this.orderTypes.Add(@int, type);
				this.orderIds.Add(type, @int);
			}
			oleDbDataReader.Close();
			oleDbCommand.Dispose();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004398 File Offset: 0x00003398
		public OrderList Load()
		{
			OrderList result;
			lock (this)
			{
				OrderList orderList = new OrderList();
				OleDbCommand oleDbCommand = this.connection.CreateCommand();
				oleDbCommand.CommandText = "SELECT * FROM ORDERS";
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					int @int = oleDbDataReader.GetInt32(0);
					Type type = this.orderTypes[oleDbDataReader.GetInt32(1)] as Type;
					int id = oleDbDataReader.IsDBNull(2) ? -1 : oleDbDataReader.GetInt32(2);
					int num = oleDbDataReader.IsDBNull(3) ? -1 : oleDbDataReader.GetInt32(3);
					int id2 = oleDbDataReader.IsDBNull(4) ? -1 : oleDbDataReader.GetInt32(4);
					IOrder order = Activator.CreateInstance(type, true) as IOrder;
					order.Id = @int;
					order.Instrument = InstrumentManager.Instruments.GetById(id);
					order.Provider = ProviderManager.ExecutionProviders[(byte)num];
					order.Portfolio = PortfolioManager.Portfolios.GetById(id2);
					order.Persistent = true;
					orderList.Add(order);
				}
				oleDbDataReader.Close();
				oleDbCommand.Dispose();
				FIXOleDbServer.LoadFIXGroups(this.connection, orderList, "ORDER_FIELDS");
				ExecutionReportList executionReportList = new ExecutionReportList();
				oleDbCommand = this.connection.CreateCommand();
				oleDbCommand.CommandText = "SELECT * FROM REPORTS";
				oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					int int2 = oleDbDataReader.GetInt32(0);
					int int3 = oleDbDataReader.GetInt32(1);
					ExecutionReport executionReport = new ExecutionReport();
					executionReport.Id = int2;
					orderList.GetById(int3).Reports.Add(executionReport);
					executionReportList.Add(executionReport);
				}
				oleDbDataReader.Close();
				oleDbCommand.Dispose();
				FIXOleDbServer.LoadFIXGroups(this.connection, executionReportList, "REPORT_FIELDS");
				result = orderList;
			}
			return result;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004584 File Offset: 0x00003584
		private int GetTypeId(IOrder order)
		{
			Type type = order.GetType();
			if (!this.orderIds.ContainsKey(type))
			{
				string value = type.FullName + ", " + type.Assembly.GetName().Name;
				OleDbCommand oleDbCommand = this.connection.CreateCommand();
				oleDbCommand.CommandText = "INSERT INTO ORDER_TYPES (Type_) VALUES(?)";
				oleDbCommand.Parameters.Add("@Type_", OleDbType.VarChar).Value = value;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
				oleDbCommand = this.connection.CreateCommand();
				oleDbCommand.CommandText = "SELECT @@IDENTITY";
				int num = (int)oleDbCommand.ExecuteScalar();
				oleDbCommand.Dispose();
				this.orderTypes.Add(num, type);
				this.orderIds.Add(type, num);
			}
			return (int)this.orderIds[type];
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004668 File Offset: 0x00003668
		private void UpdateDatabase()
		{
			this.AddDatabaseField("ORDERS", "InstrumentID_", "INT");
			this.AddDatabaseField("ORDERS", "ProviderID_", "INT");
			this.AddDatabaseField("ORDERS", "PortfolioID_", "INT");
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000046B4 File Offset: 0x000036B4
		private void AddDatabaseField(string table, string field, string definition)
		{
			try
			{
				DataTable oleDbSchemaTable = this.connection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[]
				{
					null,
					null,
					table,
					field
				});
				if (oleDbSchemaTable.Rows.Count == 0)
				{
					OleDbCommand oleDbCommand = this.connection.CreateCommand();
					oleDbCommand.CommandText = string.Format("ALTER TABLE {0} ADD {1} {2}", table, field, definition);
					oleDbCommand.ExecuteNonQuery();
					oleDbCommand.Dispose();
				}
			}
			catch (Exception e)
			{
				RuntimeErrorManager.ReportError(new RuntimeError(RuntimeErrorLevel.Critical, e));
			}
		}

		// Token: 0x04000029 RID: 41
		private const string DATABASE_FILE = "execution.mdb";

		// Token: 0x0400002A RID: 42
		private OleDbConnection connection;

		// Token: 0x0400002B RID: 43
		private Hashtable orderTypes;

		// Token: 0x0400002C RID: 44
		private Hashtable orderIds;
	}
}
