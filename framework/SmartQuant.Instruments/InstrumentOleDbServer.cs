using System;
using System.Collections;
using System.Data.OleDb;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
	// Token: 0x02000049 RID: 73
	public class InstrumentOleDbServer : IInstrumentServer
	{
		// Token: 0x0600038A RID: 906 RVA: 0x0000B901 File Offset: 0x0000A901
		public InstrumentOleDbServer()
		{
			this.instrumentTypes = new Hashtable();
			this.instrumentIds = new Hashtable();
			this.pricerTypes = new Hashtable();
			this.pricerIds = new Hashtable();
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000B935 File Offset: 0x0000A935
		public void Open(string database)
		{
			this.fConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + database);
			this.fConnection.Open();
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000B958 File Offset: 0x0000A958
		public void Open()
		{
			this.Open(Framework.Installation.DataDir.FullName + "\\instrument.mdb");
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000B979 File Offset: 0x0000A979
		public void CreateDataBase()
		{
			throw new InvalidOperationException("The database definition is out of date");
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000B988 File Offset: 0x0000A988
		public void Save(Instrument instrument)
		{
			if (instrument.Id == -1)
			{
				int typeId = this.GetTypeId(instrument);
				int typeId2 = this.GetTypeId(instrument.Pricer);
				OleDbCommand oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "INSERT INTO INSTRUMENTS (InstrumentTypeID_, PricerTypeID_, Symbol_) VALUES (?,?,?)";
				oleDbCommand.Parameters.Add("@InstrumentTypeID_", OleDbType.Integer).Value = typeId;
				oleDbCommand.Parameters.Add("@PricerTypeID_", OleDbType.Integer).Value = typeId2;
				oleDbCommand.Parameters.Add("@Symbol_", OleDbType.VarChar).Value = instrument.Symbol;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
				oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "SELECT @@IDENTITY";
				instrument.Id = (int)oleDbCommand.ExecuteScalar();
				oleDbCommand.Dispose();
			}
			else
			{
				OleDbCommand oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "DELETE FROM INSTRUMENT_FIELDS WHERE OuterID_=?";
				oleDbCommand.Parameters.Add("@OuterID_", OleDbType.Integer).Value = instrument.Id;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
				oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "DELETE FROM LEGS WHERE ParentID_=?";
				oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = instrument.Id;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
				oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "DELETE FROM UNDERLYINGS WHERE ParentID_=?";
				oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = instrument.Id;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
				oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "DELETE FROM ALT_IDS WHERE ParentID_=?";
				oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = instrument.Id;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
				int typeId3 = this.GetTypeId(instrument.Pricer);
				oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "UPDATE INSTRUMENTS SET PricerTypeID_=? WHERE ID_=?";
				oleDbCommand.Parameters.Add("@PricerTypeID_", OleDbType.Integer).Value = typeId3;
				oleDbCommand.Parameters.Add("@ID_", OleDbType.Integer).Value = instrument.Id;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
			}
			FIXOleDbServer.SaveFIXGroup(this.fConnection, instrument, "INSTRUMENT_FIELDS", instrument.Id);
			foreach (object obj in instrument.Legs)
			{
				Leg leg = (Leg)obj;
				OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO LEGS (ParentID_, InstrumentID_) VALUES (?,?)", this.fConnection);
				oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = instrument.Id;
				oleDbCommand.Parameters.Add("@InstrumentID_", OleDbType.Integer).Value = leg.Instrument.Id;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand = new OleDbCommand("SELECT @@IDENTITY", this.fConnection);
				leg.Id = (int)oleDbCommand.ExecuteScalar();
				FIXOleDbServer.SaveFIXGroup(this.fConnection, leg, "LEG_FIELDS", leg.Id);
			}
			foreach (object obj2 in instrument.Underlyings)
			{
				Underlying underlying = (Underlying)obj2;
				OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO UNDERLYINGS (ParentID_, InstrumentID_) VALUES (?,?)", this.fConnection);
				oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = instrument.Id;
				oleDbCommand.Parameters.Add("@InstrumentID_", OleDbType.Integer).Value = underlying.Instrument.Id;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand = new OleDbCommand("SELECT @@IDENTITY", this.fConnection);
				underlying.Id = (int)oleDbCommand.ExecuteScalar();
				FIXOleDbServer.SaveFIXGroup(this.fConnection, underlying, "UNDERLYING_FIELDS", underlying.Id);
			}
			foreach (object obj3 in instrument.SecurityAltIDGroup)
			{
				FIXSecurityAltIDGroup fixsecurityAltIDGroup = (FIXSecurityAltIDGroup)obj3;
				OleDbCommand oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "INSERT INTO ALT_IDS (ParentID_) VALUES (?)";
				oleDbCommand.Parameters.Add("@ParentID_", OleDbType.Integer).Value = instrument.Id;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
				oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "SELECT @@IDENTITY";
				fixsecurityAltIDGroup.Id = (int)oleDbCommand.ExecuteScalar();
				oleDbCommand.Dispose();
				FIXOleDbServer.SaveFIXGroup(this.fConnection, fixsecurityAltIDGroup, "ALT_ID_FIELDS", fixsecurityAltIDGroup.Id);
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000BEB8 File Offset: 0x0000AEB8
		public void Remove(Instrument instrument)
		{
			OleDbCommand oleDbCommand = new OleDbCommand("DELETE FROM INSTRUMENTS WHERE ID_=?", this.fConnection);
			oleDbCommand.Parameters.Add("ID_", OleDbType.Integer).Value = instrument.Id;
			oleDbCommand.ExecuteNonQuery();
			oleDbCommand.Dispose();
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000BF04 File Offset: 0x0000AF04
		public void Close()
		{
			this.fConnection.Close();
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000BF14 File Offset: 0x0000AF14
		public InstrumentList Load()
		{
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM INSTRUMENT_TYPES", this.fConnection);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				int @int = oleDbDataReader.GetInt32(0);
				Type type = Type.GetType(oleDbDataReader.GetString(1));
				this.instrumentTypes.Add(@int, type);
				this.instrumentIds.Add(type, @int);
			}
			oleDbDataReader.Close();
			oleDbCommand.Dispose();
			oleDbCommand = new OleDbCommand("SELECT * FROM PRICER_TYPES", this.fConnection);
			oleDbDataReader = oleDbCommand.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				int int2 = oleDbDataReader.GetInt32(0);
				Type type2 = Type.GetType(oleDbDataReader.GetString(1));
				this.pricerTypes.Add(int2, type2);
				this.pricerIds.Add(type2, int2);
			}
			oleDbDataReader.Close();
			oleDbCommand.Dispose();
			InstrumentList instrumentList = new InstrumentList();
			oleDbCommand = new OleDbCommand("SELECT * FROM INSTRUMENTS", this.fConnection);
			oleDbDataReader = oleDbCommand.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				int int3 = oleDbDataReader.GetInt32(0);
				Type type3 = this.instrumentTypes[oleDbDataReader.GetInt32(1)] as Type;
				Type type4 = this.pricerTypes[oleDbDataReader.GetInt32(2)] as Type;
				string @string = oleDbDataReader.GetString(3);
				Instrument instrument = Activator.CreateInstance(type3, true) as Instrument;
				IPricer pricer = Activator.CreateInstance(type4) as IPricer;
				instrument.Symbol = @string;
				instrument.Id = int3;
				instrument.Pricer = pricer;
				if (instrumentList[@string] == null)
				{
					instrumentList.Add(instrument);
				}
			}
			oleDbDataReader.Close();
			FIXOleDbServer.LoadFIXGroups(this.fConnection, instrumentList, "INSTRUMENT_FIELDS");
			LegList legList = new LegList();
			oleDbCommand = new OleDbCommand("SELECT * FROM LEGS", this.fConnection);
			oleDbDataReader = oleDbCommand.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				int int4 = oleDbDataReader.GetInt32(0);
				int int5 = oleDbDataReader.GetInt32(1);
				int int6 = oleDbDataReader.GetInt32(2);
				Leg leg = new Leg(instrumentList.GetById(int6));
				leg.Id = int4;
				instrumentList.GetById(int5).Legs.Add(leg);
				legList.Add(leg);
			}
			oleDbDataReader.Close();
			FIXOleDbServer.LoadFIXGroups(this.fConnection, legList, "LEG_FIELDS");
			UnderlyingList underlyingList = new UnderlyingList();
			oleDbCommand = new OleDbCommand("SELECT * FROM UNDERLYINGS", this.fConnection);
			oleDbDataReader = oleDbCommand.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				int int7 = oleDbDataReader.GetInt32(0);
				int int8 = oleDbDataReader.GetInt32(1);
				int int9 = oleDbDataReader.GetInt32(2);
				Underlying underlying = new Underlying(instrumentList.GetById(int9));
				underlying.Id = int7;
				instrumentList.GetById(int8).Underlyings.Add(underlying);
				underlyingList.Add(underlying);
			}
			oleDbDataReader.Close();
			FIXOleDbServer.LoadFIXGroups(this.fConnection, underlyingList, "UNDERLYING_FIELDS");
			FIXSecurityAltIDGroupList fixsecurityAltIDGroupList = new FIXSecurityAltIDGroupList();
			oleDbCommand = this.fConnection.CreateCommand();
			oleDbCommand.CommandText = "SELECT * FROM ALT_IDS";
			oleDbDataReader = oleDbCommand.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				int int10 = oleDbDataReader.GetInt32(0);
				int int11 = oleDbDataReader.GetInt32(1);
				FIXSecurityAltIDGroup fixsecurityAltIDGroup = new FIXSecurityAltIDGroup();
				fixsecurityAltIDGroup.Id = int10;
				instrumentList.GetById(int11).SecurityAltIDGroup.Add(fixsecurityAltIDGroup);
				fixsecurityAltIDGroupList.Add(fixsecurityAltIDGroup);
			}
			oleDbDataReader.Close();
			FIXOleDbServer.LoadFIXGroups(this.fConnection, fixsecurityAltIDGroupList, "ALT_ID_FIELDS");
			return instrumentList;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000C290 File Offset: 0x0000B290
		private int GetTypeId(Instrument instrument)
		{
			Type type = instrument.GetType();
			if (!this.instrumentIds.ContainsKey(type))
			{
				string value = type.FullName + ", " + type.Assembly.GetName().Name;
				OleDbCommand oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "INSERT INTO INSTRUMENT_TYPES (Type_) VALUES (?)";
				oleDbCommand.Parameters.Add("@Type_", OleDbType.VarChar).Value = value;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
				oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "SELECT @@IDENTITY";
				int num = (int)oleDbCommand.ExecuteScalar();
				this.instrumentTypes.Add(num, type);
				this.instrumentIds.Add(type, num);
			}
			return (int)this.instrumentIds[type];
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000C370 File Offset: 0x0000B370
		private int GetTypeId(IPricer pricer)
		{
			Type type = pricer.GetType();
			if (!this.pricerIds.ContainsKey(type))
			{
				string value = type.FullName + ", " + type.Assembly.GetName().Name;
				OleDbCommand oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "INSERT INTO PRICER_TYPES (Type_) VALUES(?)";
				oleDbCommand.Parameters.Add("@Type_", OleDbType.VarChar).Value = value;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.Dispose();
				oleDbCommand = this.fConnection.CreateCommand();
				oleDbCommand.CommandText = "SELECT @@IDENTITY";
				int num = (int)oleDbCommand.ExecuteScalar();
				this.pricerTypes.Add(num, type);
				this.pricerIds.Add(type, num);
			}
			return (int)this.pricerIds[type];
		}

		// Token: 0x040000FF RID: 255
		private const string DATABASE_FILE = "instrument.mdb";

		// Token: 0x04000100 RID: 256
		private OleDbConnection fConnection;

		// Token: 0x04000101 RID: 257
		private Hashtable instrumentTypes;

		// Token: 0x04000102 RID: 258
		private Hashtable instrumentIds;

		// Token: 0x04000103 RID: 259
		private Hashtable pricerTypes;

		// Token: 0x04000104 RID: 260
		private Hashtable pricerIds;
	}
}
