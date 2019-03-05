using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Reflection;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
    public class PortfolioSQLiteServer : IPortfolioServer
    {
        // Token: 0x060002EB RID: 747 RVA: 0x00009307 File Offset: 0x00008307
        public void Open(string database)
        {
            this.connection = new SQLiteConnection("Data Source=" + database);
            this.connection.Open();
            this.UpdateDatabase();
        }

        // Token: 0x060002EC RID: 748 RVA: 0x00009330 File Offset: 0x00008330
        public void Open()
        {
            this.Open(Framework.Installation.DataDir.FullName + "\\"+DATABASE_FILE);
        }

        // Token: 0x060002ED RID: 749 RVA: 0x00009351 File Offset: 0x00008351
        public void Close()
        {
            this.connection.Close();
        }

        // Token: 0x060002EE RID: 750 RVA: 0x00009360 File Offset: 0x00008360
        public PortfolioList Load()
        {
            PortfolioList portfolioList = new PortfolioList();
            SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT * FROM PORTFOLIOS", this.connection);
            SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {
                int @int = sqliteDataReader.GetInt32(0);
                string @string = sqliteDataReader.GetString(1);
                string string2 = sqliteDataReader.GetString(2);
                string string3 = sqliteDataReader.GetString(3);
                string string4 = sqliteDataReader.GetString(4);
                bool persistent = !sqliteDataReader.IsDBNull(5) && sqliteDataReader.GetBoolean(5);
                Portfolio portfolio = Activator.CreateInstance(@string, string2, true, BindingFlags.Instance | BindingFlags.Public, null, null, null, null, null).Unwrap() as Portfolio;
                portfolio.Id = @int;
                portfolio.Name = string3;
                portfolio.Description = string4;
                portfolio.SetPersistent(persistent);
                portfolioList.Add(portfolio);
            }
            sqliteDataReader.Close();
            foreach (object obj in portfolioList)
            {
                Portfolio portfolio2 = (Portfolio)obj;
                this.LoadPortfolio(portfolio2);
            }
            return portfolioList;
        }

        // Token: 0x060002EF RID: 751 RVA: 0x0000947C File Offset: 0x0000847C
        private void LoadPortfolio(Portfolio portfolio)
        {
            portfolio.SetIsLoading(true);
            Dictionary<int, Instrument> dictionary = new Dictionary<int, Instrument>();
            SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT * FROM TRANSACTIONS WHERE ParentID_=? ORDER BY ID_ ASC", this.connection);
            sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = portfolio.Id;
            SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {
                int @int = sqliteDataReader.GetInt32(0);
                sqliteDataReader.GetInt32(1);
                string @string = sqliteDataReader.GetString(2);
                int int2 = sqliteDataReader.GetInt32(3);
                DateTime dateTime = sqliteDataReader.GetDateTime(4);
                int int3 = sqliteDataReader.GetInt32(5);
                string string2 = sqliteDataReader.GetString(6);
                double @double = sqliteDataReader.GetDouble(7);
                double double2 = sqliteDataReader.GetDouble(8);
                string string3 = sqliteDataReader.GetString(9);
                string string4 = sqliteDataReader.GetString(10);
                string string5 = sqliteDataReader.GetString(11);
                double double3 = sqliteDataReader.GetDouble(12);
                string string6 = sqliteDataReader.GetString(13);
                Transaction transaction = new Transaction();
                transaction.Id = @int;
                transaction.ClOrdID = @string;
                transaction.ReportId = int2;
                transaction.DateTime = dateTime;
                transaction.Instrument = InstrumentManager.Instruments.GetById(int3);
                transaction.Side = FIXSide.FromFIX(string2[0]);
                transaction.Price = @double;
                transaction.Qty = double2;
                transaction.Text = string3;
                TransactionCost transactionCost = Activator.CreateInstance(string4, string5, true, BindingFlags.Instance | BindingFlags.Public, null, null, null, null, null).Unwrap() as TransactionCost;
                transactionCost.CommType = FIXCommType.FromFIX(string6[0]);
                transactionCost.Commission = double3;
                transaction.TransactionCost = transactionCost;
                if (transaction.Instrument == null)
                {
                    if (!dictionary.ContainsKey(int3))
                    {
                        Instrument instrument = (Instrument)Activator.CreateInstance(typeof(Instrument), true);
                        instrument.Symbol = string.Format("<unknown,id={0}>", int3);
                        dictionary.Add(int3, instrument);
                    }
                    transaction.Instrument = dictionary[int3];
                }
                portfolio.Add(transaction);
            }
            sqliteDataReader.Close();
            sqliteCommand = new SQLiteCommand("SELECT * FROM ACCOUNT_TRANSACTIONS WHERE ParentID_=? ORDER BY ID_ ASC", this.connection);
            sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = portfolio.Id;
            sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {
                int int4 = sqliteDataReader.GetInt32(0);
                sqliteDataReader.GetInt32(1);
                DateTime dateTime2 = sqliteDataReader.GetDateTime(2);
                string string7 = sqliteDataReader.GetString(3);
                double double4 = sqliteDataReader.GetDouble(4);
                string text = sqliteDataReader.IsDBNull(5) ? "" : sqliteDataReader.GetString(5);
                AccountTransaction accountTransaction = new AccountTransaction();
                accountTransaction.Id = int4;
                accountTransaction.DateTime = dateTime2;
                accountTransaction.Currency = CurrencyManager.Currencies[string7];
                accountTransaction.Value = double4;
                accountTransaction.Text = text;
                portfolio.Account.Add(accountTransaction);
            }
            sqliteDataReader.Close();
            portfolio.SetIsLoading(false);
        }

        // Token: 0x060002F0 RID: 752 RVA: 0x00009764 File Offset: 0x00008764
        public void Save(Portfolio portfolio)
        {
            try
            {
                if (portfolio.Id != -1)
                {
                    SQLiteCommand sqliteCommand = new SQLiteCommand("DELETE FROM TRANSACTIONS WHERE ParentID_=?", this.connection);
                    sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = portfolio.Id;
                    sqliteCommand.ExecuteNonQuery();
                    sqliteCommand = new SQLiteCommand("DELETE FROM ACCOUNT_TRANSACTIONS WHERE ParentID_=?", this.connection);
                    sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = portfolio.Id;
                    sqliteCommand.ExecuteNonQuery();
                    sqliteCommand = new SQLiteCommand("UPDATE PORTFOLIOS SET Description_=?,Persistent_=? WHERE ID_=?", this.connection);
                    sqliteCommand.Parameters.Add("@Description_", DbType.String).Value = portfolio.Description;
                    sqliteCommand.Parameters.Add("@Persistent_", DbType.Boolean).Value = portfolio.Persistent;
                    sqliteCommand.Parameters.Add("@ID_", DbType.Int32).Value = portfolio.Id;
                    sqliteCommand.ExecuteNonQuery();
                }
                else
                {
                    SQLiteCommand sqliteCommand = new SQLiteCommand("INSERT INTO PORTFOLIOS (Assembly_,Type_,Name_,Description_,Persistent_) VALUES (?,?,?,?,?)", this.connection);
                    sqliteCommand.Parameters.Add("@Assembly_", DbType.String).Value = portfolio.GetType().Assembly.FullName;
                    sqliteCommand.Parameters.Add("@Type_", DbType.String).Value = portfolio.GetType().FullName;
                    sqliteCommand.Parameters.Add("@Name_", DbType.String).Value = portfolio.Name;
                    sqliteCommand.Parameters.Add("@Description_", DbType.String).Value = portfolio.Description;
                    sqliteCommand.Parameters.Add("@Persistent_", DbType.Boolean).Value = portfolio.Persistent;
                    sqliteCommand.ExecuteNonQuery();
                    sqliteCommand = new SQLiteCommand("SELECT LAST_INSERT_ROWID()", this.connection);
                    portfolio.Id = Convert.ToInt32(sqliteCommand.ExecuteScalar());
                }
                foreach (object obj in portfolio.Transactions)
                {
                    Transaction transaction = (Transaction)obj;
                    SQLiteCommand sqliteCommand = new SQLiteCommand("INSERT INTO TRANSACTIONS (ParentID_,ClOrdID_,ReportId_,DateTime_,InstrumentId_,Side_,Price_,Qty_,Text_,CostAssembly_,CostType_,Commission_,CommType_) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?)", this.connection);
                    sqliteCommand.Parameters.Add("@ParentID_    ", DbType.Int32).Value = portfolio.Id;
                    sqliteCommand.Parameters.Add("@ClOrdID_     ", DbType.String).Value = transaction.ClOrdID;
                    sqliteCommand.Parameters.Add("@ReportId_    ", DbType.Int32).Value = transaction.ReportId;
                    sqliteCommand.Parameters.Add("@DateTime_    ", DbType.Date).Value = transaction.DateTime;
                    sqliteCommand.Parameters.Add("@InstrumentId_", DbType.Int32).Value = transaction.Instrument.Id;
                    sqliteCommand.Parameters.Add("@Side_        ", DbType.Byte).Value = FIXSide.ToFIX(transaction.Side);
                    sqliteCommand.Parameters.Add("@Price_       ", DbType.Double).Value = transaction.Price;
                    sqliteCommand.Parameters.Add("@Qty_         ", DbType.Double).Value = transaction.Qty;
                    sqliteCommand.Parameters.Add("@Text_        ", DbType.String).Value = transaction.Text;
                    sqliteCommand.Parameters.Add("@CostAssembly_", DbType.String).Value = transaction.TransactionCost.GetType().Assembly.FullName;
                    sqliteCommand.Parameters.Add("@CostType_    ", DbType.String).Value = transaction.TransactionCost.GetType().FullName;
                    sqliteCommand.Parameters.Add("@Commission_  ", DbType.Double).Value = transaction.TransactionCost.Commission;
                    sqliteCommand.Parameters.Add("@CommType_    ", DbType.Byte).Value = FIXCommType.ToFIX(transaction.TransactionCost.CommType);
                    sqliteCommand.ExecuteNonQuery();
                    sqliteCommand = new SQLiteCommand("SELECT LAST_INSERT_ROWID()", this.connection);
                    transaction.Id = Convert.ToInt32(sqliteCommand.ExecuteScalar());
                }
                foreach (object obj2 in portfolio.Account.Transactions)
                {
                    AccountTransaction accountTransaction = (AccountTransaction)obj2;
                    SQLiteCommand sqliteCommand = new SQLiteCommand("INSERT INTO ACCOUNT_TRANSACTIONS (ParentID_,DateTime_,Currency_,Value_,Text_) VALUES (?,?,?,?,?)", this.connection);
                    sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = portfolio.Id;
                    sqliteCommand.Parameters.Add("@DateTime_", DbType.Date).Value = accountTransaction.DateTime;
                    sqliteCommand.Parameters.Add("@Currency_", DbType.String).Value = accountTransaction.Currency.Code;
                    sqliteCommand.Parameters.Add("@Value_", DbType.Double).Value = accountTransaction.Value;
                    sqliteCommand.Parameters.Add("@Text_", DbType.String).Value = accountTransaction.Text;
                    sqliteCommand.ExecuteNonQuery();
                    sqliteCommand = new SQLiteCommand("SELECT LAST_INSERT_ROWID()", this.connection);
                    accountTransaction.Id = Convert.ToInt32(sqliteCommand.ExecuteScalar());
                }
            }
            catch (Exception innerException)
            {
                throw new ApplicationException("PortfolioSQliteServer::Save", innerException);
            }
        }

        // Token: 0x060002F1 RID: 753 RVA: 0x00009D40 File Offset: 0x00008D40
        public void Remove(Portfolio portfolio)
        {
            SQLiteCommand sqliteCommand = new SQLiteCommand("DELETE * FROM ACCOUNT_TRANSACTIONS WHERE ParentID_=?", this.connection);
            sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = portfolio.Id;
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand = new SQLiteCommand("DELETE * FROM TRANSACTIONS WHERE ParentID_=?", this.connection);
            sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = portfolio.Id;
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand = new SQLiteCommand("DELETE * FROM PORTFOLIOS WHERE ID_=?", this.connection);
            sqliteCommand.Parameters.Add("@ID_", DbType.Int32).Value = portfolio.Id;
            sqliteCommand.ExecuteNonQuery();
        }

        // Token: 0x060002F2 RID: 754 RVA: 0x00009DF8 File Offset: 0x00008DF8
        public void Update(Portfolio portfolio)
        {
            if (portfolio.Id == -1)
            {
                try
                {
                    SQLiteCommand sqliteCommand = new SQLiteCommand("INSERT INTO PORTFOLIOS (Assembly_,Type_,Name_,Description_,Persistent_) VALUES (?,?,?,?,?)", this.connection);
                    sqliteCommand.Parameters.Add("@Assembly_", DbType.String).Value = portfolio.GetType().Assembly.FullName;
                    sqliteCommand.Parameters.Add("@Type_", DbType.String).Value = portfolio.GetType().FullName;
                    sqliteCommand.Parameters.Add("@Name_", DbType.String).Value = portfolio.Name;
                    sqliteCommand.Parameters.Add("@Description_", DbType.String).Value = portfolio.Description;
                    sqliteCommand.Parameters.Add("@Persistent_", DbType.Boolean).Value = portfolio.Persistent;
                    sqliteCommand.ExecuteNonQuery();
                    sqliteCommand.Dispose();
                    sqliteCommand = new SQLiteCommand("SELECT LAST_INSERT_ROWID()", this.connection);
                    portfolio.Id = Convert.ToInt32(sqliteCommand.ExecuteScalar());
                    sqliteCommand.Dispose();
                    return;
                }
                catch (Exception innerException)
                {
                    throw new ApplicationException("PortfolioSQliteServer::Update", innerException);
                }
            }
            try
            {
                SQLiteCommand sqliteCommand = new SQLiteCommand("UPDATE PORTFOLIOS SET Description_=?,Persistent_=? WHERE ID_=?", this.connection);
                sqliteCommand.Parameters.Add("@Description_", DbType.String).Value = portfolio.Description;
                sqliteCommand.Parameters.Add("@Persistent_", DbType.Boolean).Value = portfolio.Persistent;
                sqliteCommand.Parameters.Add("@ID_", DbType.Int32).Value = portfolio.Id;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
            }
            catch (Exception innerException2)
            {
                throw new ApplicationException("PortfolioSQLiteServer::Update", innerException2);
            }
        }

        // Token: 0x060002F3 RID: 755 RVA: 0x00009FC8 File Offset: 0x00008FC8
        public void Add(Portfolio portfolio, Transaction transaction)
        {
            if (portfolio.Id != -1)
            {
                try
                {
                    SQLiteCommand sqliteCommand = this.connection.CreateCommand();
                    sqliteCommand.CommandText = "INSERT INTO TRANSACTIONS (ParentID_,ClOrdID_,ReportId_,DateTime_,InstrumentId_,Side_,Price_,Qty_,Text_,CostAssembly_,CostType_,Commission_,CommType_) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?)";
                    sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = portfolio.Id;
                    sqliteCommand.Parameters.Add("@ClOrdID_", DbType.String).Value = transaction.ClOrdID;
                    sqliteCommand.Parameters.Add("@ReportId_", DbType.Int32).Value = transaction.ReportId;
                    sqliteCommand.Parameters.Add("@DateTime_", DbType.Date).Value = transaction.DateTime;
                    sqliteCommand.Parameters.Add("@InstrumentId_", DbType.Int32).Value = transaction.Instrument.Id;
                    sqliteCommand.Parameters.Add("@Side_", DbType.Byte).Value = FIXSide.ToFIX(transaction.Side);
                    sqliteCommand.Parameters.Add("@Price_", DbType.Double).Value = transaction.Price;
                    sqliteCommand.Parameters.Add("@Qty_", DbType.Double).Value = transaction.Qty;
                    sqliteCommand.Parameters.Add("@Text_", DbType.String).Value = transaction.Text;
                    sqliteCommand.Parameters.Add("@CostAssembly_", DbType.String).Value = transaction.TransactionCost.GetType().Assembly.FullName;
                    sqliteCommand.Parameters.Add("@CostType_", DbType.String).Value = transaction.TransactionCost.GetType().FullName;
                    sqliteCommand.Parameters.Add("@Commission_", DbType.Double).Value = transaction.TransactionCost.Commission;
                    sqliteCommand.Parameters.Add("@CommType_", DbType.Byte).Value = FIXCommType.ToFIX(transaction.TransactionCost.CommType);
                    sqliteCommand.ExecuteNonQuery();
                    sqliteCommand = this.connection.CreateCommand();
                    sqliteCommand.CommandText = "SELECT LAST_INSERT_ROWID()";
                    transaction.Id = Convert.ToInt32(sqliteCommand.ExecuteScalar());
                }
                catch (Exception innerException)
                {
                    throw new ApplicationException("PortolioSQliteServer::Add", innerException);
                }
            }
        }

        // Token: 0x060002F4 RID: 756 RVA: 0x0000A238 File Offset: 0x00009238
        public void Add(Portfolio portfolio, AccountTransaction transaction)
        {
            if (portfolio.Id != -1)
            {
                try
                {
                    SQLiteCommand sqliteCommand = this.connection.CreateCommand();
                    sqliteCommand.CommandText = "INSERT INTO ACCOUNT_TRANSACTIONS (ParentID_,DateTime_,Currency_,Value_,Text_) VALUES (?,?,?,?,?)";
                    sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = portfolio.Id;
                    sqliteCommand.Parameters.Add("@DateTime_", DbType.Date).Value = transaction.DateTime;
                    sqliteCommand.Parameters.Add("@Currency_", DbType.String).Value = transaction.Currency.Code;
                    sqliteCommand.Parameters.Add("@Value_", DbType.Double).Value = transaction.Value;
                    sqliteCommand.Parameters.Add("@Text_", DbType.String).Value = transaction.Text;
                    sqliteCommand.ExecuteNonQuery();
                    sqliteCommand = this.connection.CreateCommand();
                    sqliteCommand.CommandText = "SELECT LAST_INSERT_ROWID()";
                    transaction.Id = Convert.ToInt32(sqliteCommand.ExecuteScalar());
                }
                catch (Exception innerException)
                {
                    throw new ApplicationException("PortfolioSQliteServer::Add", innerException);
                }
            }
        }

        // Token: 0x060002F5 RID: 757 RVA: 0x0000A360 File Offset: 0x00009360
        public void Clear(Portfolio portfolio)
        {
            if (portfolio.Id != -1)
            {
                try
                {
                    SQLiteCommand sqliteCommand = this.connection.CreateCommand();
                    sqliteCommand.CommandText = "DELETE * FROM ACCOUNT_TRANSACTIONS WHERE ParentID_=?";
                    sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = portfolio.Id;
                    sqliteCommand.ExecuteNonQuery();
                    sqliteCommand = this.connection.CreateCommand();
                    sqliteCommand.CommandText = "DELETE * FROM TRANSACTIONS WHERE ParentID_=?";
                    sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = portfolio.Id;
                    sqliteCommand.ExecuteNonQuery();
                }
                catch (Exception innerException)
                {
                    throw new ApplicationException("PortfolioSQliteServer::Clear", innerException);
                }
            }
        }

        // Token: 0x060002F6 RID: 758 RVA: 0x0000A418 File Offset: 0x00009418
        private void UpdateDatabase()
        {
            this.AddDatabaseField("PORTFOLIOS", "Persistent_", "LOGICAL");
            this.AddDatabaseField("ACCOUNT_TRANSACTIONS", "Text_", "VARCHAR(255)");
        }

        // Token: 0x060002F7 RID: 759 RVA: 0x0000A444 File Offset: 0x00009444
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

        // Token: 0x060002F8 RID: 760 RVA: 0x0000A4CC File Offset: 0x000094CC
        private void CreateDataBase()
        {
            SQLiteCommand sqliteCommand;
            try
            {
                sqliteCommand = new SQLiteCommand("DROP TABLE PORTFOLIOS", this.connection);
                sqliteCommand.ExecuteNonQuery();
            }
            catch
            {
            }
            try
            {
                sqliteCommand = new SQLiteCommand("DROP TABLE TRANSACTIONS", this.connection);
                sqliteCommand.ExecuteNonQuery();
            }
            catch
            {
            }
            try
            {
                sqliteCommand = new SQLiteCommand("DROP TABLE TRANSACTION_COST_FIELDS", this.connection);
                sqliteCommand.ExecuteNonQuery();
            }
            catch
            {
            }
            try
            {
                sqliteCommand = new SQLiteCommand("DROP TABLE ACCOUNT_TRANSACTIONS", this.connection);
                sqliteCommand.ExecuteNonQuery();
            }
            catch
            {
            }
            sqliteCommand = new SQLiteCommand("CREATE TABLE PORTFOLIOS (ID_ int IDENTITY (1, 1) PRIMARY KEY,Assembly_ varchar(255),Type_ varchar(255),Name_ varchar(255),Description_ varchar(255))", this.connection);
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand = new SQLiteCommand("CREATE TABLE TRANSACTIONS (ID_ int IDENTITY (1, 1) PRIMARY KEY,ParentID_ int,ClOrdID_ varchar(255),ReportId_ int,DateTime_ datetime,InstrumentId_ int,Side_ char,Price_ double,Qty_ double,Text_ varchar(255),CostAssembly_ varchar(255),CostType_ varchar(255),Commission_ double,CommType_ char)", this.connection);
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand = new SQLiteCommand("CREATE TABLE ACCOUNT_TRANSACTIONS (ID_ int IDENTITY (1, 1) PRIMARY KEY,ParentID_ int,DateTime_ datetime,Currency_ varchar(255),Value_ double)", this.connection);
            sqliteCommand.ExecuteNonQuery();
        }

        // Token: 0x040000C8 RID: 200
        private const string DATABASE_FILE = "portfolio.db";

        // Token: 0x040000C9 RID: 201
        private SQLiteConnection connection;
    }
}
