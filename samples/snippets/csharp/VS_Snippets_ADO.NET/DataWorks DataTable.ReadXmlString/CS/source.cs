﻿using System;
using System.Data;

class Program
{
    static void Main()
    {
        DemonstrateReadWriteXMLDocumentWithString();
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
    // <Snippet1>
    private static void DemonstrateReadWriteXMLDocumentWithString()
    {
        DataTable table = CreateTestTable("XmlDemo");
        PrintValues(table, "Original table");

        string fileName = "C:\\TestData.xml";
        table.WriteXml(fileName, XmlWriteMode.WriteSchema);

        DataTable newTable = new DataTable();
        newTable.ReadXml(fileName);

        // Print out values in the table.
        PrintValues(newTable, "New table");
    }

    private static DataTable CreateTestTable(string tableName)
    {
        // Create a test DataTable with two columns and a few rows.
        DataTable table = new DataTable(tableName);
        DataColumn column = new DataColumn("id", typeof(System.Int32));
        column.AutoIncrement = true;
        table.Columns.Add(column);

        column = new DataColumn("item", typeof(System.String));
        table.Columns.Add(column);

        // Add ten rows.
        DataRow row;
        for (int i = 0; i <= 9; i++)
        {
            row = table.NewRow();
            row["item"] = "item " + i;
            table.Rows.Add(row);
        }

        table.AcceptChanges();
        return table;
    }

    private static void PrintValues(DataTable table, string label)
    {
        Console.WriteLine(label);
        foreach (DataRow row in table.Rows)
        {
            foreach (DataColumn column in table.Columns)
            {
                Console.Write("\t{0}", row[column]);
            }
            Console.WriteLine();
        }
    }
    // </Snippet1>
}
