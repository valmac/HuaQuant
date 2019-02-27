using System;
using System.Collections;
using System.Data.SQLite;
using System.Data;

namespace SmartQuant.FIX
{
    public class FIXSQLiteServer
    {
        // Token: 0x06000521 RID: 1313 RVA: 0x000078D5 File Offset: 0x000068D5
        public static void SaveFIXGroup(SQLiteConnection connection, FIXGroup group, string table, int outerID)
        {
            FIXSQLiteServer.SaveFIXGroup(connection, group, table, outerID, -1);
        }

        // Token: 0x06000522 RID: 1314 RVA: 0x000078E4 File Offset: 0x000068E4
        public static void SaveFIXGroup(SQLiteConnection connection, FIXGroup group, string table, int outerID, int innerID)
        {
            foreach (object obj in group.Fields.Values)
            {
                FIXField fixfield = (FIXField)obj;
                if (fixfield.FIXType != FIXType.NumInGroup)
                {
                    SQLiteCommand sqliteCommand = new SQLiteCommand("INSERT INTO " + table + " (OuterID_, InnerID_, Type_, Tag_, Value_) VALUES (?, ?, ?, ?, ?)", connection);
                    sqliteCommand.Parameters.Add("@OuterID_", DbType.Int32).Value = outerID;
                    sqliteCommand.Parameters.Add("@InnerID_", DbType.Int32).Value = innerID;
                    sqliteCommand.Parameters.Add("@Type_", DbType.Int32).Value = (int)fixfield.FIXType;
                    sqliteCommand.Parameters.Add("@Tag_", DbType.String).Value = fixfield.Tag;
                    sqliteCommand.Parameters.Add("@Value_", DbType.String).Value = fixfield.ToInvariantString();
                    sqliteCommand.ExecuteNonQuery();
                }
            }
            foreach (object obj2 in group.Groups)
            {
                ArrayList arrayList = (ArrayList)obj2;
                SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT LAST_INSERT_ROWID()", connection);
                int num = (int)sqliteCommand.ExecuteScalar();
                sqliteCommand = new SQLiteCommand("INSERT INTO " + table + " (OuterID_,InnerID_,Type_,Tag_,Value_) VALUES (?,-1,-1,-1,-1)", connection);
                sqliteCommand.Parameters.Add("@OuterID_", DbType.Int32).Value = outerID;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand = new SQLiteCommand("SELECT LAST_INSERT_ROWID()", connection);
                num = (int)sqliteCommand.ExecuteScalar();
                foreach (object obj3 in arrayList)
                {
                    FIXGroup group2 = (FIXGroup)obj3;
                    sqliteCommand = new SQLiteCommand("INSERT INTO " + table + " (OuterID_,InnerID_,Type_,Tag_,Value_) VALUES (?,?,-1,-1,-1)", connection);
                    sqliteCommand.Parameters.Add("@OuterID_", DbType.Int32).Value = outerID;
                    sqliteCommand.Parameters.Add("@InnerID_", DbType.Int32).Value = num;
                    sqliteCommand.ExecuteNonQuery();
                    sqliteCommand = new SQLiteCommand("SELECT LAST_INSERT_ROWID()", connection);
                    int innerID2 = (int)sqliteCommand.ExecuteScalar();
                    FIXSQLiteServer.SaveFIXGroup(connection, group2, table, outerID, innerID2);
                }
            }
        }

        // Token: 0x06000523 RID: 1315 RVA: 0x00007BB4 File Offset: 0x00006BB4
        public static void LoadFIXGroups(SQLiteConnection connection, FIXGroupList groups, string table)
        {
            SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT * FROM " + table, connection);
            SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {
                sqliteDataReader.GetInt32(0);
                sqliteDataReader.GetInt32(1);
                int @int = sqliteDataReader.GetInt32(2);
                int int2 = sqliteDataReader.GetInt32(3);
                int int3 = sqliteDataReader.GetInt32(4);
                string @string = sqliteDataReader.GetString(5);
                if (int3 != -1 && int3 != 55)
                {
                    FIXField field = FIXField.Field((FIXType)int2, int3, @string, true);
                    FIXGroup byId = groups.GetById(@int);
                    byId.AddField(field);
                }
            }
            sqliteDataReader.Close();
        }

        // Token: 0x06000524 RID: 1316 RVA: 0x00007C48 File Offset: 0x00006C48
        public static void RemoveFIXGroup(SQLiteConnection connection, string table, int outerId)
        {
            SQLiteCommand sqliteCommand = new SQLiteCommand("DELETE * FROM " + table + " WHERE OuterID_=?", connection);
            sqliteCommand.Parameters.Add("@OuterID_", DbType.Int32).Value = outerId;
            sqliteCommand.ExecuteNonQuery();
        }
    }
}
