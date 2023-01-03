using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class DatabaseManager
    {
        internal static void CheckDatabase()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(LocalDb)\\MSSQLLocalDB";
                builder.InitialCatalog = "FlashcardsDB";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    
                    String sql = @"IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'FlashcardsDB')
                                   BEGIN
                                   CREATE DATABASE FlashcardsDB;
                                   END";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    sql = @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Stacks')
                            CREATE TABLE Stacks (
                            StackId INT NOT NULL PRIMARY KEY,
                            Name VARCHAR(100) NOT NULL UNIQUE)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    sql = @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Flashcards')
                            CREATE TABLE Flashcards (
                            FlashCardId INT NOT NULL PRIMARY KEY,
                            Question VARCHAR(30) NOT NULL,
                            Answer VARCHAR(30) NOT NULL,
                            StackId INT NOT NULL FOREIGN KEY REFERENCES Stacks(StackId) ON DELETE CASCADE ON UPDATE CASCADE)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }


            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
