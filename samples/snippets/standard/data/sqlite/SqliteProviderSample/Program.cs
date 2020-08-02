﻿using System;
using Microsoft.Data.Sqlite;

namespace SqliteProviderSample
{
    class Program
    {
        static void Main()
        {
            SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_sqlite3());

            using var connection = new SqliteConnection();
            Console.WriteLine($"System SQLite version: {connection.ServerVersion}");
        }
    }
}
