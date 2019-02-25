using System;
using System.Collections;
using System.Data.OleDb;

namespace SmartQuant.FIX
{
	// Token: 0x0200001A RID: 26
	public class FIXOleDbServer
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x000078D5 File Offset: 0x000068D5
		public static void SaveFIXGroup(OleDbConnection connection, FIXGroup group, string table, int outerID)
		{
			FIXOleDbServer.SaveFIXGroup(connection, group, table, outerID, -1);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000078E4 File Offset: 0x000068E4
		public static void SaveFIXGroup(OleDbConnection connection, FIXGroup group, string table, int outerID, int innerID)
		{
			foreach (object obj in group.Fields.Values)
			{
				FIXField fixfield = (FIXField)obj;
				if (fixfield.FIXType != FIXType.NumInGroup)
				{
					OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO " + table + " (OuterID_, InnerID_, Type_, Tag_, Value_) VALUES (?, ?, ?, ?, ?)", connection);
					oleDbCommand.Parameters.Add("@OuterID_", OleDbType.Integer).Value = outerID;
					oleDbCommand.Parameters.Add("@InnerID_", OleDbType.Integer).Value = innerID;
					oleDbCommand.Parameters.Add("@Type_", OleDbType.Integer).Value = (int)fixfield.FIXType;
					oleDbCommand.Parameters.Add("@Tag_", OleDbType.VarChar).Value = fixfield.Tag;
					oleDbCommand.Parameters.Add("@Value_", OleDbType.VarChar).Value = fixfield.ToInvariantString();
					oleDbCommand.ExecuteNonQuery();
				}
			}
			foreach (object obj2 in group.Groups)
			{
				ArrayList arrayList = (ArrayList)obj2;
				OleDbCommand oleDbCommand = new OleDbCommand("SELECT @@IDENTITY", connection);
				int num = (int)oleDbCommand.ExecuteScalar();
				oleDbCommand = new OleDbCommand("INSERT INTO " + table + " (OuterID_,InnerID_,Type_,Tag_,Value_) VALUES (?,-1,-1,-1,-1)", connection);
				oleDbCommand.Parameters.Add("@OuterID_", OleDbType.Integer).Value = outerID;
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand = new OleDbCommand("SELECT @@IDENTITY", connection);
				num = (int)oleDbCommand.ExecuteScalar();
				foreach (object obj3 in arrayList)
				{
					FIXGroup group2 = (FIXGroup)obj3;
					oleDbCommand = new OleDbCommand("INSERT INTO " + table + " (OuterID_,InnerID_,Type_,Tag_,Value_) VALUES (?,?,-1,-1,-1)", connection);
					oleDbCommand.Parameters.Add("@OuterID_", OleDbType.Integer).Value = outerID;
					oleDbCommand.Parameters.Add("@InnerID_", OleDbType.Integer).Value = num;
					oleDbCommand.ExecuteNonQuery();
					oleDbCommand = new OleDbCommand("SELECT @@IDENTITY", connection);
					int innerID2 = (int)oleDbCommand.ExecuteScalar();
					FIXOleDbServer.SaveFIXGroup(connection, group2, table, outerID, innerID2);
				}
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00007BB4 File Offset: 0x00006BB4
		public static void LoadFIXGroups(OleDbConnection connection, FIXGroupList groups, string table)
		{
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM " + table, connection);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				oleDbDataReader.GetInt32(0);
				oleDbDataReader.GetInt32(1);
				int @int = oleDbDataReader.GetInt32(2);
				int int2 = oleDbDataReader.GetInt32(3);
				int int3 = oleDbDataReader.GetInt32(4);
				string @string = oleDbDataReader.GetString(5);
				if (int3 != -1 && int3 != 55)
				{
					FIXField field = FIXField.Field((FIXType)int2, int3, @string, true);
					FIXGroup byId = groups.GetById(@int);
					byId.AddField(field);
				}
			}
			oleDbDataReader.Close();
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00007C48 File Offset: 0x00006C48
		public static void RemoveFIXGroup(OleDbConnection connection, string table, int outerId)
		{
			OleDbCommand oleDbCommand = new OleDbCommand("DELETE * FROM " + table + " WHERE OuterID_=?", connection);
			oleDbCommand.Parameters.Add("@OuterID_", OleDbType.Integer).Value = outerId;
			oleDbCommand.ExecuteNonQuery();
		}
	}
}
