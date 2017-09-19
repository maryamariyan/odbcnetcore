using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
    public static class ConnectionStrings
    {
        // Requires http://www.ch-werner.de/sqliteodbc/
        public const string WorkingConnection =
            "Driver=SQLite3 ODBC Driver;" +
            "Database=smoketests.sqlite;";
    }
}
