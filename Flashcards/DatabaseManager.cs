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
                builder.DataSource = "Server=(LocalDb)\\MSSQLLocalDB";

                using (SqlConnection connection = new SqlConnection(builder.DataSource))
                {
                    connection.Open();
                    String sql = @"IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'FlashCardsDB')
                                   BEGIN
                                   CREATE DATABASE FlashCardsDB;
                                   END";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
