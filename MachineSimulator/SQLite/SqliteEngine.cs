using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachineSimulator.Interfaces;

namespace MachineSimulator.SQLite
{
    public class SqliteEngine : IDatabaseEngine
    {
        // Private variables
        private string _extension = "db";

        private SQLiteConnection _dbConnection;

        // Public properties
        public string Extension
        {
            get
            {
                return _extension;
            }
        }


        // Methods
        public void Connect(string dbName)
        {
            _dbConnection = new SQLiteConnection($"Data Source={dbName};Version=3;");
            _dbConnection.Open();
        }

        public void Close()
        {
            _dbConnection.Close();
        }

        public void TruncateDatabase()
        {
            try
            {
                var tablesList = new List<string>();

                // Gather all tables in database
                var getAllTablesQuery = @"SELECT NAME from sqlite_master WHERE type='table' ORDER BY name";
                var command = new SQLiteCommand(getAllTablesQuery, _dbConnection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                    tablesList.Add(reader["name"].ToString());

                // Truncate 
                var query = tablesList.Aggregate(String.Empty, (current, table) => current + $"DELETE FROM {table}; ");

                var truncateCommand = new SQLiteCommand(query, _dbConnection);
                truncateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

    }
}
