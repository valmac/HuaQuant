using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
	// Token: 0x02000037 RID: 55
	public class PortfolioOleDbServer : IPortfolioServer
	{
		// Token: 0x060002EB RID: 747 RVA: 0x00009307 File Offset: 0x00008307
		public void Open(string database)
		{
			this.connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + database);
			this.connection.Open();
			this.UpdateDatabase();
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00009330 File Offset: 0x00008330
		public void Open()
		{
			this.Open(Framework.Installation.DataDir.FullName + "\\portfolio.mdb");
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
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM PORTFOLIOS", this.connection);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				int @int = oleDbDataReader.GetInt32(0);
				string @string = oleDbDataReader.GetString(1);
				string string2 = oleDbDataReader.GetString(2);
				string string3 = oleDbDataReader.GetString(3);
				string string4 = oleDbDataReader.GetString(4);
				bool persistent = !oleDbDataReader.IsDBNull(5) && oleDbDataReader.GetBoolean(5);
				Portfolio portfolio = Activator.CreateInstance(@string, string2, true, BindingFlags.Instance | BindingFlags.Public, null, null, null, null, null).Unwrap() as Portfolio;
				portfolio.Id = @int;
				portfolio.Name = string3;
				portfolio.Description = string4;
				portfolio.SetPersistent(persistent);
				portfolioList.Add(portfolio);
			}
			oleDbDataReader.Close();
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
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM TRANSACTIONS WHERE ParentID_=? ORDER BY ID_ ASC", this.connection);
			oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = portfolio.Id;
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				int @int = oleDbDataReader.GetInt32(0);
				oleDbDataReader.GetInt32(1);
				string @string = oleDbDataReader.GetString(2);
				int int2 = oleDbDataReader.GetInt32(3);
				DateTime dateTime = oleDbDataReader.GetDateTime(4);
				int int3 = oleDbDataReader.GetInt32(5);
				string string2 = oleDbDataReader.GetString(6);
				double @double = oleDbDataReader.GetDouble(7);
				double double2 = oleDbDataReader.GetDouble(8);
				string string3 = oleDbDataReader.GetString(9);
				string string4 = oleDbDataReader.GetString(10);
				string string5 = oleDbDataReader.GetString(11);
				double double3 = oleDbDataReader.GetDouble(12);
				string string6 = oleDbDataReader.GetString(13);
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
			oleDbDataReader.Close();
			oleDbCommand = new OleDbCommand("SELECT * FROM ACCOUNT_TRANSACTIONS WHERE ParentID_=? ORDER BY ID_ ASC", this.connection);
			oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = portfolio.Id;
			oleDbDataReader = oleDbCommand.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				int int4 = oleDbDataReader.GetInt32(0);
				oleDbDataReader.GetInt32(1);
				DateTime dateTime2 = oleDbDataReader.GetDateTime(2);
				string string7 = oleDbDataReader.GetString(3);
				double double4 = oleDbDataReader.GetDouble(4);
				string text = oleDbDataReader.IsDBNull(5) ? "" : oleDbDataReader.GetString(5);
				AccountTransaction accountTransaction = new AccountTransaction();
				accountTransaction.Id = int4;
				accountTransaction.DateTime = dateTime2;
				accountTransaction.Currency = CurrencyManager.Currencies[string7];
				accountTransaction.Value = double4;
				accountTransaction.Text = text;
				portfolio.Account.Add(accountTransaction);
			}
			oleDbDataReader.Close();
			portfolio.SetIsLoading(false);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00009764 File Offset: 0x00008764
		public void Save(Portfolio portfolio)
		{
			try
			{
				if (portfolio.Id != -1)
				{
					OleDbCommand oleDbCommand = new OleDbCommand("DELETE FROM TRANSACTIONS WHERE ParentID_=?", this.connection);
					oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = portfolio.Id;
					oleDbCommand.ExecuteNonQuery();
					oleDbCommand = new OleDbCommand("DELETE FROM ACCOUNT_TRANSACTIONS WHERE ParentID_=?", this.connection);
					oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = portfolio.Id;
					oleDbCommand.ExecuteNonQuery();
					oleDbCommand = new OleDbCommand("UPDATE PORTFOLIOS SET Description_=?,Persistent_=? WHERE ID_=?", this.connection);
					oleDbCommand.Parameters.Add("@Description_", OleDbType.VarChar).Value = portfolio.Description;
					oleDbCommand.Parameters.Add("@Persistent_", OleDbType.Boolean).Value = portfolio.Persistent;
					oleDbCommand.Parameters.Add("@ID_", OleDbType.Integer).Value = portfolio.Id;
					oleDbCommand.ExecuteNonQuery();
				}
				else
				{
					OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO PORTFOLIOS (Assembly_,Type_,Name_,Description_,Persistent_) VALUES (?,?,?,?,?)", this.connection);
					oleDbCommand.Parameters.Add("@Assembly_", OleDbType.VarChar).Value = portfolio.GetType().Assembly.FullName;
					oleDbCommand.Parameters.Add("@Type_", OleDbType.VarChar).Value = portfolio.GetType().FullName;
					oleDbCommand.Parameters.Add("@Name_", OleDbType.VarChar).Value = portfolio.Name;
					oleDbCommand.Parameters.Add("@Description_", OleDbType.VarChar).Value = portfolio.Description;
					oleDbCommand.Parameters.Add("@Persistent_", OleDbType.Boolean).Value = portfolio.Persistent;
					oleDbCommand.ExecuteNonQuery();
					oleDbCommand = new OleDbCommand("SELECT @@IDENTITY", this.connection);
					portfolio.Id = (int)oleDbCommand.ExecuteScalar();
				}
				foreach (object obj in portfolio.Transactions)
				{
					Transaction transaction = (Transaction)obj;
					OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO TRANSACTIONS (ParentID_,ClOrdID_,ReportId_,DateTime_,InstrumentId_,Side_,Price_,Qty_,Text_,CostAssembly_,CostType_,Commission_,CommType_) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?)", this.connection);
					oleDbCommand.Parameters.Add("@ParentID_    ", OleDbType.Integer).Value = portfolio.Id;
					oleDbCommand.Parameters.Add("@ClOrdID_     ", OleDbType.VarChar).Value = transaction.ClOrdID;
					oleDbCommand.Parameters.Add("@ReportId_    ", OleDbType.Integer).Value = transaction.ReportId;
					oleDbCommand.Parameters.Add("@DateTime_    ", OleDbType.Date).Value = transaction.DateTime;
					oleDbCommand.Parameters.Add("@InstrumentId_", OleDbType.Integer).Value = transaction.Instrument.Id;
					oleDbCommand.Parameters.Add("@Side_        ", OleDbType.Char).Value = FIXSide.ToFIX(transaction.Side);
					oleDbCommand.Parameters.Add("@Price_       ", OleDbType.Double).Value = transaction.Price;
					oleDbCommand.Parameters.Add("@Qty_         ", OleDbType.Double).Value = transaction.Qty;
					oleDbCommand.Parameters.Add("@Text_        ", OleDbType.VarChar).Value = transaction.Text;
					oleDbCommand.Parameters.Add("@CostAssembly_", OleDbType.VarChar).Value = transaction.TransactionCost.GetType().Assembly.FullName;
					oleDbCommand.Parameters.Add("@CostType_    ", OleDbType.VarChar).Value = transaction.TransactionCost.GetType().FullName;
					oleDbCommand.Parameters.Add("@Commission_  ", OleDbType.Double).Value = transaction.TransactionCost.Commission;
					oleDbCommand.Parameters.Add("@CommType_    ", OleDbType.Char).Value = FIXCommType.ToFIX(transaction.TransactionCost.CommType);
					oleDbCommand.ExecuteNonQuery();
					oleDbCommand = new OleDbCommand("SELECT @@IDENTITY", this.connection);
					transaction.Id = (int)oleDbCommand.ExecuteScalar();
				}
				foreach (object obj2 in portfolio.Account.Transactions)
				{
					AccountTransaction accountTransaction = (AccountTransaction)obj2;
					OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO ACCOUNT_TRANSACTIONS (ParentID_,DateTime_,Currency_,Value_,Text_) VALUES (?,?,?,?,?)", this.connection);
					oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = portfolio.Id;
					oleDbCommand.Parameters.Add("@DateTime_", OleDbType.Date).Value = accountTransaction.DateTime;
					oleDbCommand.Parameters.Add("@Currency_", OleDbType.VarChar).Value = accountTransaction.Currency.Code;
					oleDbCommand.Parameters.Add("@Value_", OleDbType.Double).Value = accountTransaction.Value;
					oleDbCommand.Parameters.Add("@Text_", OleDbType.VarChar).Value = accountTransaction.Text;
					oleDbCommand.ExecuteNonQuery();
					oleDbCommand = new OleDbCommand("SELECT @@IDENTITY", this.connection);
					accountTransaction.Id = (int)oleDbCommand.ExecuteScalar();
				}
			}
			catch (Exception innerException)
			{
				throw new ApplicationException("PortfolioOleDbServer::Save", innerException);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00009D40 File Offset: 0x00008D40
		public void Remove(Portfolio portfolio)
		{
			OleDbCommand oleDbCommand = new OleDbCommand("DELETE * FROM ACCOUNT_TRANSACTIONS WHERE ParentID_=?", this.connection);
			oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = portfolio.Id;
			oleDbCommand.ExecuteNonQuery();
			oleDbCommand = new OleDbCommand("DELETE * FROM TRANSACTIONS WHERE ParentID_=?", this.connection);
			oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = portfolio.Id;
			oleDbCommand.ExecuteNonQuery();
			oleDbCommand = new OleDbCommand("DELETE * FROM PORTFOLIOS WHERE ID_=?", this.connection);
			oleDbCommand.Parameters.Add("@ID_", OleDbType.Integer).Value = portfolio.Id;
			oleDbCommand.ExecuteNonQuery();
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00009DF8 File Offset: 0x00008DF8
		public void Update(Portfolio portfolio)
		{
			if (portfolio.Id == -1)
			{
				try
				{
					OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO PORTFOLIOS (Assembly_,Type_,Name_,Description_,Persistent_) VALUES (?,?,?,?,?)", this.connection);
					oleDbCommand.Parameters.Add("@Assembly_", OleDbType.VarChar).Value = portfolio.GetType().Assembly.FullName;
					oleDbCommand.Parameters.Add("@Type_", OleDbType.VarChar).Value = portfolio.GetType().FullName;
					oleDbCommand.Parameters.Add("@Name_", OleDbType.VarChar).Value = portfolio.Name;
					oleDbCommand.Parameters.Add("@Description_", OleDbType.VarChar).Value = portfolio.Description;
					oleDbCommand.Parameters.Add("@Persistent_", OleDbType.Boolean).Value = portfolio.Persistent;
					oleDbCommand.ExecuteNonQuery();
					oleDbCommand.Dispose();
					oleDbCommand = new OleDbCommand("SELECT @@IDENTITY", this.connection);
					portfolio.Id = (int)oleDbCommand.ExecuteScalar();
					oleDbCommand.Dispose();
					return;
				}
				catch (Exception innerException)
				{
					throw new ApplicationException("PortfolioOleDbServer::Update", innerException);
				}
			}
			try
			{
				OleDbCommand oleDbCommand = new OleDbCommand("UPDATE PORTFOLIOS SET Description_=?,Persistent_=? WHERE ID_=?", this.connection);
				oleDbCommand.Parameters.Add("@Description_", OleDbType.VarChar).Value = portfolio.Description;
				oleDbCommand.Parameters.Add("@Persistent_", OleDbType.Boolean).Value = portfolio.Persistent;
				oleDbCommand.Parameters.Add("@ID_", OleDbType.Integer).Value = portfolio.Id;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
			}
			catch (Exception innerException2)
			{
				throw new ApplicationException("PortfolioOleDbServer::Update", innerException2);
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00009FC8 File Offset: 0x00008FC8
		public void Add(Portfolio portfolio, Transaction transaction)
		{
			if (portfolio.Id != -1)
			{
				try
				{
					OleDbCommand oleDbCommand = this.connection.CreateCommand();
					oleDbCommand.CommandText = "INSERT INTO TRANSACTIONS (ParentID_,ClOrdID_,ReportId_,DateTime_,InstrumentId_,Side_,Price_,Qty_,Text_,CostAssembly_,CostType_,Commission_,CommType_) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?)";
					oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = portfolio.Id;
					oleDbCommand.Parameters.Add("@ClOrdID_", OleDbType.VarChar).Value = transaction.ClOrdID;
					oleDbCommand.Parameters.Add("@ReportId_", OleDbType.Integer).Value = transaction.ReportId;
					oleDbCommand.Parameters.Add("@DateTime_", OleDbType.Date).Value = transaction.DateTime;
					oleDbCommand.Parameters.Add("@InstrumentId_", OleDbType.Integer).Value = transaction.Instrument.Id;
					oleDbCommand.Parameters.Add("@Side_", OleDbType.Char).Value = FIXSide.ToFIX(transaction.Side);
					oleDbCommand.Parameters.Add("@Price_", OleDbType.Double).Value = transaction.Price;
					oleDbCommand.Parameters.Add("@Qty_", OleDbType.Double).Value = transaction.Qty;
					oleDbCommand.Parameters.Add("@Text_", OleDbType.VarChar).Value = transaction.Text;
					oleDbCommand.Parameters.Add("@CostAssembly_", OleDbType.VarChar).Value = transaction.TransactionCost.GetType().Assembly.FullName;
					oleDbCommand.Parameters.Add("@CostType_", OleDbType.VarChar).Value = transaction.TransactionCost.GetType().FullName;
					oleDbCommand.Parameters.Add("@Commission_", OleDbType.Double).Value = transaction.TransactionCost.Commission;
					oleDbCommand.Parameters.Add("@CommType_", OleDbType.Char).Value = FIXCommType.ToFIX(transaction.TransactionCost.CommType);
					oleDbCommand.ExecuteNonQuery();
					oleDbCommand = this.connection.CreateCommand();
					oleDbCommand.CommandText = "SELECT @@IDENTITY";
					transaction.Id = (int)oleDbCommand.ExecuteScalar();
				}
				catch (Exception innerException)
				{
					throw new ApplicationException("PortolioOleDbServer::Add", innerException);
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
					OleDbCommand oleDbCommand = this.connection.CreateCommand();
					oleDbCommand.CommandText = "INSERT INTO ACCOUNT_TRANSACTIONS (ParentID_,DateTime_,Currency_,Value_,Text_) VALUES (?,?,?,?,?)";
					oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = portfolio.Id;
					oleDbCommand.Parameters.Add("@DateTime_", OleDbType.Date).Value = transaction.DateTime;
					oleDbCommand.Parameters.Add("@Currency_", OleDbType.VarChar).Value = transaction.Currency.Code;
					oleDbCommand.Parameters.Add("@Value_", OleDbType.Double).Value = transaction.Value;
					oleDbCommand.Parameters.Add("@Text_", OleDbType.VarChar).Value = transaction.Text;
					oleDbCommand.ExecuteNonQuery();
					oleDbCommand = this.connection.CreateCommand();
					oleDbCommand.CommandText = "SELECT @@IDENTITY";
					transaction.Id = (int)oleDbCommand.ExecuteScalar();
				}
				catch (Exception innerException)
				{
					throw new ApplicationException("PortfolioOleDbServer::Add", innerException);
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
					OleDbCommand oleDbCommand = this.connection.CreateCommand();
					oleDbCommand.CommandText = "DELETE * FROM ACCOUNT_TRANSACTIONS WHERE ParentID_=?";
					oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = portfolio.Id;
					oleDbCommand.ExecuteNonQuery();
					oleDbCommand = this.connection.CreateCommand();
					oleDbCommand.CommandText = "DELETE * FROM TRANSACTIONS WHERE ParentID_=?";
					oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = portfolio.Id;
					oleDbCommand.ExecuteNonQuery();
				}
				catch (Exception innerException)
				{
					throw new ApplicationException("PortfolioOleDbServer::Clear", innerException);
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

		// Token: 0x060002F8 RID: 760 RVA: 0x0000A4CC File Offset: 0x000094CC
		private void CreateDataBase()
		{
			OleDbCommand oleDbCommand;
			try
			{
				oleDbCommand = new OleDbCommand("DROP TABLE PORTFOLIOS", this.connection);
				oleDbCommand.ExecuteNonQuery();
			}
			catch
			{
			}
			try
			{
				oleDbCommand = new OleDbCommand("DROP TABLE TRANSACTIONS", this.connection);
				oleDbCommand.ExecuteNonQuery();
			}
			catch
			{
			}
			try
			{
				oleDbCommand = new OleDbCommand("DROP TABLE TRANSACTION_COST_FIELDS", this.connection);
				oleDbCommand.ExecuteNonQuery();
			}
			catch
			{
			}
			try
			{
				oleDbCommand = new OleDbCommand("DROP TABLE ACCOUNT_TRANSACTIONS", this.connection);
				oleDbCommand.ExecuteNonQuery();
			}
			catch
			{
			}
			oleDbCommand = new OleDbCommand("CREATE TABLE PORTFOLIOS (ID_ int IDENTITY (1, 1) PRIMARY KEY,Assembly_ varchar(255),Type_ varchar(255),Name_ varchar(255),Description_ varchar(255))", this.connection);
			oleDbCommand.ExecuteNonQuery();
			oleDbCommand = new OleDbCommand("CREATE TABLE TRANSACTIONS (ID_ int IDENTITY (1, 1) PRIMARY KEY,ParentID_ int,ClOrdID_ varchar(255),ReportId_ int,DateTime_ datetime,InstrumentId_ int,Side_ char,Price_ double,Qty_ double,Text_ varchar(255),CostAssembly_ varchar(255),CostType_ varchar(255),Commission_ double,CommType_ char)", this.connection);
			oleDbCommand.ExecuteNonQuery();
			oleDbCommand = new OleDbCommand("CREATE TABLE ACCOUNT_TRANSACTIONS (ID_ int IDENTITY (1, 1) PRIMARY KEY,ParentID_ int,DateTime_ datetime,Currency_ varchar(255),Value_ double)", this.connection);
			oleDbCommand.ExecuteNonQuery();
		}

		// Token: 0x040000C8 RID: 200
		private const string DATABASE_FILE = "portfolio.mdb";

		// Token: 0x040000C9 RID: 201
		private OleDbConnection connection;
	}
}
