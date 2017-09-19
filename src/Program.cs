//using System.Data.SQLite;
using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("temp dummy CWL");
            //new CommandBuilderTests().QuoteIdentifier_UseConnection();
            //new CommandBuilderTests().QuoteIdentifier_CustomPrefixSuffix();
            //new CommandBuilderTests().EmptyReader();
        }

        //private void DraftTest()
        //{
        //    SQLiteConnection.CreateFile(ConnectionStrings.WorkingConnection);

        //    SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
        //    m_dbConnection.Open();

        //    string sql = "create table highscrs (name varchar(20), score int)";
        //    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
        //    command.ExecuteNonQuery();

        //    sql = "insert into highscrs (name, score) values ('Me', 9001)";
        //    command = new SQLiteCommand(sql, m_dbConnection);
        //    command.ExecuteNonQuery();

        //    sql = "insert into highscrs (name, score) values ('Myself', 6000)";
        //    command = new SQLiteCommand(sql, m_dbConnection);
        //    command.ExecuteNonQuery();

        //    sql = "insert into highscrs (name, score) values ('And I', 9001)";
        //    command = new SQLiteCommand(sql, m_dbConnection);
        //    command.ExecuteNonQuery();

        //    m_dbConnection.Close();

        //    OdbcConnection DbConnection = new OdbcConnection(ConnectionStrings.WorkingConnection);
        //    DbConnection.Open();
        //    OdbcCommand DbCommand = DbConnection.CreateCommand();

        //    DbCommand.CommandText = "SELECT * FROM highscrs";
        //    OdbcDataReader DbReader = DbCommand.ExecuteReader();

        //    int fCount = DbReader.FieldCount;
        //    Console.Write(":");
        //    for (int i = 0; i < fCount; i++)
        //    {
        //        String fName = DbReader.GetName(i);
        //        Console.Write(fName + ":");
        //    }
        //    Console.WriteLine();

        //    while (DbReader.Read())
        //    {
        //        Console.Write(":");
        //        for (int i = 0; i < fCount; i++)
        //        {
        //            String col = DbReader.GetString(i);

        //            Console.Write(col + ":");
        //        }
        //        Console.WriteLine();
        //    }

        //    DbReader.Close();
        //    DbCommand.Dispose();
        //    DbConnection.Close();
        //}
    }
}
