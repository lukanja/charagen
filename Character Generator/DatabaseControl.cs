using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Character_Generator
{
    public class DatabaseControl
    {
        public string connectionString;
        SqlConnection dbConnection;

        public DatabaseControl()
        {
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=CharacterGenerator;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False";
        }

        public bool ConnectDatabase()
        {
            dbConnection = new SqlConnection(connectionString);

            try
            {
                dbConnection.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                return false;
            }
        }

         public string GenerateTrait()
        {
            string wantedTrait;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand(
                "SELECT TOP 1 LifePhase FROM dbo.LifePhase ORDER BY NEWID();", connection); //change to variable later
                connection.Open();
                reader = command.ExecuteReader();
                reader.Read();
                wantedTrait = reader.GetString(0);
                reader.Close();
            }

            return wantedTrait;
        }

        public void DisconnectDatabase()
        {
            dbConnection.Close();
        }
    }
}

