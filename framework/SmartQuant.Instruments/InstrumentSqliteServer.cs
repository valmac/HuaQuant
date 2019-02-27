using System;
using System.Collections;
using System.Data;
using System.Data.SQLite;
using SmartQuant.FIX;
namespace SmartQuant.Instruments
{
    public class InstrumentSQLiteServer : IInstrumentServer
    {
        public InstrumentSQLiteServer()
        {
            this.instrumentTypes = new Hashtable();
            this.instrumentIds = new Hashtable();
            this.pricerTypes = new Hashtable();
            this.pricerIds = new Hashtable();
        }

        public void Open(string dataBase)
        {
            this.fConnection = new SQLiteConnection("Data Source="+dataBase);
            this.fConnection.Open();
        }

        public void Open()
        {
            this.Open(Framework.Installation.DataDir.FullName + "\\"+ DATABASE_FILE);
        }
        public void Close()
        {
            this.fConnection.Close();
        }

        // Token: 0x0600038D RID: 909 RVA: 0x0000B979 File Offset: 0x0000A979
        public void CreateDataBase()
        {
            throw new InvalidOperationException("The database definition is out of date");
        }

        public InstrumentList Load()
        {
            SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT * FROM INSTRUMENT_TYPES", this.fConnection);
            SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {
                int @int = sqliteDataReader.GetInt32(0);
                Type type = Type.GetType(sqliteDataReader.GetString(1));
                this.instrumentTypes.Add(@int, type);
                this.instrumentIds.Add(type, @int);
            }
            sqliteDataReader.Close();
            sqliteCommand.Dispose();
            sqliteCommand = new SQLiteCommand("SELECT * FROM PRICER_TYPES", this.fConnection);
            sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {
                int int2 = sqliteDataReader.GetInt32(0);
                Type type2 = Type.GetType(sqliteDataReader.GetString(1));
                this.pricerTypes.Add(int2, type2);
                this.pricerIds.Add(type2, int2);
            }
            sqliteDataReader.Close();
            sqliteCommand.Dispose();
            InstrumentList instrumentList = new InstrumentList();
            sqliteCommand = new SQLiteCommand("SELECT * FROM INSTRUMENTS", this.fConnection);
            sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {
                int int3 = sqliteDataReader.GetInt32(0);
                Type type3 = this.instrumentTypes[sqliteDataReader.GetInt32(1)] as Type;
                Type type4 = this.pricerTypes[sqliteDataReader.GetInt32(2)] as Type;
                string @string = sqliteDataReader.GetString(3);
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
            sqliteDataReader.Close();
            FIXSQLiteServer.LoadFIXGroups(this.fConnection, instrumentList, "INSTRUMENT_FIELDS");
            LegList legList = new LegList();
            sqliteCommand = new SQLiteCommand("SELECT * FROM LEGS", this.fConnection);
            sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {
                int int4 = sqliteDataReader.GetInt32(0);
                int int5 = sqliteDataReader.GetInt32(1);
                int int6 = sqliteDataReader.GetInt32(2);
                Leg leg = new Leg(instrumentList.GetById(int6));
                leg.Id = int4;
                instrumentList.GetById(int5).Legs.Add(leg);
                legList.Add(leg);
            }
            sqliteDataReader.Close();
            FIXSQLiteServer.LoadFIXGroups(this.fConnection, legList, "LEG_FIELDS");
            UnderlyingList underlyingList = new UnderlyingList();
            sqliteCommand = new SQLiteCommand("SELECT * FROM UNDERLYINGS", this.fConnection);
            sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {
                int int7 = sqliteDataReader.GetInt32(0);
                int int8 = sqliteDataReader.GetInt32(1);
                int int9 = sqliteDataReader.GetInt32(2);
                Underlying underlying = new Underlying(instrumentList.GetById(int9));
                underlying.Id = int7;
                instrumentList.GetById(int8).Underlyings.Add(underlying);
                underlyingList.Add(underlying);
            }
            sqliteDataReader.Close();
            FIXSQLiteServer.LoadFIXGroups(this.fConnection, underlyingList, "UNDERLYING_FIELDS");
            FIXSecurityAltIDGroupList fixsecurityAltIDGroupList = new FIXSecurityAltIDGroupList();
            sqliteCommand = this.fConnection.CreateCommand();
            sqliteCommand.CommandText = "SELECT * FROM ALT_IDS";
            sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {
                int int10 = sqliteDataReader.GetInt32(0);
                int int11 = sqliteDataReader.GetInt32(1);
                FIXSecurityAltIDGroup fixsecurityAltIDGroup = new FIXSecurityAltIDGroup();
                fixsecurityAltIDGroup.Id = int10;
                instrumentList.GetById(int11).SecurityAltIDGroup.Add(fixsecurityAltIDGroup);
                fixsecurityAltIDGroupList.Add(fixsecurityAltIDGroup);
            }
            sqliteDataReader.Close();
            FIXSQLiteServer.LoadFIXGroups(this.fConnection, fixsecurityAltIDGroupList, "ALT_ID_FIELDS");
            return instrumentList;
        }

        public void Remove(Instrument instrument)
        {
            SQLiteCommand sqliteCommand = new SQLiteCommand("DELETE FROM INSTRUMENTS WHERE ID_=?", this.fConnection);
            sqliteCommand.Parameters.Add("ID_", DbType.Int32).Value = instrument.Id;
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand.Dispose();
        }

        public void Save(Instrument instrument)
        {
            if (instrument.Id == -1)
            {
                int typeId = this.GetTypeId(instrument);
                int typeId2 = this.GetTypeId(instrument.Pricer);
                SQLiteCommand sqliteCommand = this.fConnection.CreateCommand();
                sqliteCommand.CommandText = "INSERT INTO INSTRUMENTS (InstrumentTypeID_, PricerTypeID_, Symbol_) VALUES (?,?,?)";
                sqliteCommand.Parameters.Add("@InstrumentTypeID_", DbType.Int32).Value = typeId;
                sqliteCommand.Parameters.Add("@PricerTypeID_", DbType.Int32).Value = typeId2;
                sqliteCommand.Parameters.Add("@Symbol_", DbType.String).Value = instrument.Symbol;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
                sqliteCommand = this.fConnection.CreateCommand();
                sqliteCommand.CommandText = "SELECT LAST_INSERT_ROWID()";
                instrument.Id = (int)sqliteCommand.ExecuteScalar();
                sqliteCommand.Dispose();
            }
            else
            {
                SQLiteCommand sqliteCommand = this.fConnection.CreateCommand();
                sqliteCommand.CommandText = "DELETE FROM INSTRUMENT_FIELDS WHERE OuterID_=?";
                sqliteCommand.Parameters.Add("@OuterID_", DbType.Int32).Value = instrument.Id;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
                sqliteCommand = this.fConnection.CreateCommand();
                sqliteCommand.CommandText = "DELETE FROM LEGS WHERE ParentID_=?";
                sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = instrument.Id;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
                sqliteCommand = this.fConnection.CreateCommand();
                sqliteCommand.CommandText = "DELETE FROM UNDERLYINGS WHERE ParentID_=?";
                sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = instrument.Id;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
                sqliteCommand = this.fConnection.CreateCommand();
                sqliteCommand.CommandText = "DELETE FROM ALT_IDS WHERE ParentID_=?";
                sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = instrument.Id;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
                int typeId3 = this.GetTypeId(instrument.Pricer);
                sqliteCommand = this.fConnection.CreateCommand();
                sqliteCommand.CommandText = "UPDATE INSTRUMENTS SET PricerTypeID_=? WHERE ID_=?";
                sqliteCommand.Parameters.Add("@PricerTypeID_", DbType.Int32).Value = typeId3;
                sqliteCommand.Parameters.Add("@ID_", DbType.Int32).Value = instrument.Id;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
            }
            FIXSQLiteServer.SaveFIXGroup(this.fConnection, instrument, "INSTRUMENT_FIELDS", instrument.Id);
            foreach (object obj in instrument.Legs)
            {
                Leg leg = (Leg)obj;
                SQLiteCommand sqliteCommand = new SQLiteCommand("INSERT INTO LEGS (ParentID_, InstrumentID_) VALUES (?,?)", this.fConnection);
                sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = instrument.Id;
                sqliteCommand.Parameters.Add("@InstrumentID_", DbType.Int32).Value = leg.Instrument.Id;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand = new SQLiteCommand("SELECT LAST_INSERT_ROWID()", this.fConnection);
                leg.Id = (int)sqliteCommand.ExecuteScalar();
                FIXSQLiteServer.SaveFIXGroup(this.fConnection, leg, "LEG_FIELDS", leg.Id);
            }
            foreach (object obj2 in instrument.Underlyings)
            {
                Underlying underlying = (Underlying)obj2;
                SQLiteCommand sqliteCommand = new SQLiteCommand("INSERT INTO UNDERLYINGS (ParentID_, InstrumentID_) VALUES (?,?)", this.fConnection);
                sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = instrument.Id;
                sqliteCommand.Parameters.Add("@InstrumentID_", DbType.Int32).Value = underlying.Instrument.Id;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand = new SQLiteCommand("SELECT LAST_INSERT_ROWID()", this.fConnection);
                underlying.Id = (int)sqliteCommand.ExecuteScalar();
                FIXSQLiteServer.SaveFIXGroup(this.fConnection, underlying, "UNDERLYING_FIELDS", underlying.Id);
            }
            foreach (object obj3 in instrument.SecurityAltIDGroup)
            {
                FIXSecurityAltIDGroup fixsecurityAltIDGroup = (FIXSecurityAltIDGroup)obj3;
                SQLiteCommand sqliteCommand = this.fConnection.CreateCommand();
                sqliteCommand.CommandText = "INSERT INTO ALT_IDS (ParentID_) VALUES (?)";
                sqliteCommand.Parameters.Add("@ParentID_", DbType.Int32).Value = instrument.Id;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
                sqliteCommand = this.fConnection.CreateCommand();
                sqliteCommand.CommandText = "SELECT LAST_INSERT_ROWID()";
                fixsecurityAltIDGroup.Id = (int)sqliteCommand.ExecuteScalar();
                sqliteCommand.Dispose();
                FIXSQLiteServer.SaveFIXGroup(this.fConnection, fixsecurityAltIDGroup, "ALT_ID_FIELDS", fixsecurityAltIDGroup.Id);
            }
        }

        // Token: 0x06000392 RID: 914 RVA: 0x0000C290 File Offset: 0x0000B290
        private int GetTypeId(Instrument instrument)
        {
            Type type = instrument.GetType();
            if (!this.instrumentIds.ContainsKey(type))
            {
                string value = type.FullName + ", " + type.Assembly.GetName().Name;
                SQLiteCommand sqliteCommand = this.fConnection.CreateCommand();
                sqliteCommand.CommandText = "INSERT INTO INSTRUMENT_TYPES (Type_) VALUES (?)";
                sqliteCommand.Parameters.Add("@Type_", DbType.String).Value = value;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Dispose();
                sqliteCommand = this.fConnection.CreateCommand();
                sqliteCommand.CommandText = "SELECT LAST_INSERT_ROWID()";
                int num = (int)sqliteCommand.ExecuteScalar();
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
                SQLiteCommand oleDbCommand = this.fConnection.CreateCommand();
                oleDbCommand.CommandText = "INSERT INTO PRICER_TYPES (Type_) VALUES(?)";
                oleDbCommand.Parameters.Add("@Type_", DbType.String).Value = value;
                oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Dispose();
                oleDbCommand = this.fConnection.CreateCommand();
                oleDbCommand.CommandText = "SELECT LAST_INSERT_ROWID()";
                int num = (int)oleDbCommand.ExecuteScalar();
                this.pricerTypes.Add(num, type);
                this.pricerIds.Add(type, num);
            }
            return (int)this.pricerIds[type];
        }
        // Token: 0x040000FF RID: 255
        private const string DATABASE_FILE = "instrument.db";

        // Token: 0x04000100 RID: 256
        private SQLiteConnection fConnection;

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
