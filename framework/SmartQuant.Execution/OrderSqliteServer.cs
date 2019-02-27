using System;
using System.Collections;
using System.Data;
using System.Data.SQLite;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace SmartQuant.Execution
{
    public class OrderSQLiteServer: IOrderServer
    {
        // Token: 0x060000D2 RID: 210 RVA: 0x00003FE7 File Offset: 0x00002FE7
        public OrderSQLiteServer()
        {
            this.orderTypes = new Hashtable();
            this.orderIds = new Hashtable();
        }

        // Token: 0x060000D3 RID: 211 RVA: 0x00004005 File Offset: 0x00003005
        public void Open()
        {
            this.Open(Framework.Installation.DataDir.FullName + "\\"+DATABASE_FILE);
        }

        // Token: 0x060000D4 RID: 212 RVA: 0x00004026 File Offset: 0x00003026
        public void Open(string database)
        {
            this.connection = new SQLiteConnection("Data Source="+database);
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
                SQLiteCommand sqliteCommand = this.connection.CreateCommand();
                sqliteCommand.CommandText = "INSERT INTO ORDERS (TypeID_,InstrumentID_,ProviderID_,PortfolioID_) VALUES(?,?,?,?)";
                sqliteCommand.Parameters.Add("@TypeID_", DbType.Int32).Value = this.GetTypeId(order);
                sqliteCommand.Parameters.Add("@InstrumentID_", DbType.Int32).Value = order.Instrument.Id;
                sqliteCommand.Parameters.Add("@ProviderID_", DbType.Int32).Value = order.Provider.Id;
                sqliteCommand.Parameters.Add("@PortfolioID_", DbType.Int32).Value = order.Portfolio.Id;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
                sqliteCommand = this.connection.CreateCommand();
                sqliteCommand.CommandText = "SELECT LAST_INSERT_ROWID()";
                order.Id = (int)sqliteCommand.ExecuteScalar();
                sqliteCommand.Dispose();
                FIXSQLiteServer.SaveFIXGroup(this.connection, order as SingleOrder, "ORDER_FIELDS", order.Id);
            }
        }

        // Token: 0x060000D6 RID: 214 RVA: 0x000041AC File Offset: 0x000031AC
        public void AddReport(IOrder order, FIXExecutionReport report)
        {
            lock (this)
            {
                FIXSQLiteServer.RemoveFIXGroup(this.connection, "ORDER_FIELDS", order.Id);
                FIXSQLiteServer.SaveFIXGroup(this.connection, order as SingleOrder, "ORDER_FIELDS", order.Id);
                SQLiteCommand sqliteCommand = this.connection.CreateCommand();
                sqliteCommand.CommandText = "INSERT INTO REPORTS (ParentID_) VALUES(?)";
                sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = order.Id;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
                sqliteCommand = this.connection.CreateCommand();
                sqliteCommand.CommandText = "SELECT LAST_INSERT_ROWID()";
                report.Id = (int)sqliteCommand.ExecuteScalar();
                sqliteCommand.Dispose();
                FIXSQLiteServer.SaveFIXGroup(this.connection, report, "REPORT_FIELDS", report.Id);
            }
        }

        // Token: 0x060000D7 RID: 215 RVA: 0x00004298 File Offset: 0x00003298
        public void Remove(IOrder order)
        {
            lock (this)
            {
                SQLiteCommand sqliteCommand = this.connection.CreateCommand();
                sqliteCommand.CommandText = "DELETE FROM ORDERS WHERE ID_=?";
                sqliteCommand.Parameters.Add("@ID_", DbType.Int32).Value = order.Id;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
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
            SQLiteCommand sqliteCommand = this.connection.CreateCommand();
            sqliteCommand.CommandText = "SELECT * FROM ORDER_TYPES";
            SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {
                int @int = sqliteDataReader.GetInt32(0);
                Type type = Type.GetType(sqliteDataReader.GetString(1));
                this.orderTypes.Add(@int, type);
                this.orderIds.Add(type, @int);
            }
            sqliteDataReader.Close();
            sqliteCommand.Dispose();
        }

        // Token: 0x060000DA RID: 218 RVA: 0x00004398 File Offset: 0x00003398
        public OrderList Load()
        {
            OrderList result;
            lock (this)
            {
                OrderList orderList = new OrderList();
                SQLiteCommand sqliteCommand = this.connection.CreateCommand();
                sqliteCommand.CommandText = "SELECT * FROM ORDERS";
                SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
                while (sqliteDataReader.Read())
                {
                    int @int = sqliteDataReader.GetInt32(0);
                    Type type = this.orderTypes[sqliteDataReader.GetInt32(1)] as Type;
                    int id = sqliteDataReader.IsDBNull(2) ? -1 : sqliteDataReader.GetInt32(2);
                    int num = sqliteDataReader.IsDBNull(3) ? -1 : sqliteDataReader.GetInt32(3);
                    int id2 = sqliteDataReader.IsDBNull(4) ? -1 : sqliteDataReader.GetInt32(4);
                    IOrder order = Activator.CreateInstance(type, true) as IOrder;
                    order.Id = @int;
                    order.Instrument = InstrumentManager.Instruments.GetById(id);
                    order.Provider = ProviderManager.ExecutionProviders[(byte)num];
                    order.Portfolio = PortfolioManager.Portfolios.GetById(id2);
                    order.Persistent = true;
                    orderList.Add(order);
                }
                sqliteDataReader.Close();
                sqliteCommand.Dispose();
                FIXSQLiteServer.LoadFIXGroups(this.connection, orderList, "ORDER_FIELDS");
                ExecutionReportList executionReportList = new ExecutionReportList();
                sqliteCommand = this.connection.CreateCommand();
                sqliteCommand.CommandText = "SELECT * FROM REPORTS";
                sqliteDataReader = sqliteCommand.ExecuteReader();
                while (sqliteDataReader.Read())
                {
                    int int2 = sqliteDataReader.GetInt32(0);
                    int int3 = sqliteDataReader.GetInt32(1);
                    ExecutionReport executionReport = new ExecutionReport();
                    executionReport.Id = int2;
                    orderList.GetById(int3).Reports.Add(executionReport);
                    executionReportList.Add(executionReport);
                }
                sqliteDataReader.Close();
                sqliteCommand.Dispose();
                FIXSQLiteServer.LoadFIXGroups(this.connection, executionReportList, "REPORT_FIELDS");
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
                SQLiteCommand sqliteCommand = this.connection.CreateCommand();
                sqliteCommand.CommandText = "INSERT INTO ORDER_TYPES (Type_) VALUES(?)";
                sqliteCommand.Parameters.Add("@Type_", DbType.String).Value = value;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
                sqliteCommand = this.connection.CreateCommand();
                sqliteCommand.CommandText = "SELECT LAST_INSERT_ROWID()";
                int num = (int)sqliteCommand.ExecuteScalar();
                sqliteCommand.Dispose();
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
                DataTable sqliteSchemaTable = this.connection.GetSchema("Columns", new string[]
                {
                    null,
                    null,
                    table,
                    field
                });
                if (sqliteSchemaTable.Rows.Count == 0)
                {
                    SQLiteCommand sqliteCommand = this.connection.CreateCommand();
                    sqliteCommand.CommandText = string.Format("ALTER TABLE {0} ADD {1} {2}", table, field, definition);
                    sqliteCommand.ExecuteNonQuery();
                    sqliteCommand.Dispose();
                }
            }
            catch (Exception e)
            {
                RuntimeErrorManager.ReportError(new RuntimeError(RuntimeErrorLevel.Critical, e));
            }
        }

        // Token: 0x04000029 RID: 41
        private const string DATABASE_FILE = "execution.db";

        // Token: 0x0400002A RID: 42
        private SQLiteConnection connection;

        // Token: 0x0400002B RID: 43
        private Hashtable orderTypes;

        // Token: 0x0400002C RID: 44
        private Hashtable orderIds;
    }
}
