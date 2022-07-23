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

        public void DisconnectDatabase()
        {
            dbConnection.Close();
        }

        public string GenerateTrait(string wantedTrait)
        {
            string returnedTrait;

            using (SqlConnection connection = new SqlConnection(connectionString)) // using statement doesn't leave the connection open
            {
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand(
                "SELECT TOP 1" + wantedTrait +" FROM dbo." + wantedTrait + " ORDER BY NEWID();", connection); //rearranges the target table and gets the top value 
                connection.Open();
                reader = command.ExecuteReader();
                reader.Read();
                returnedTrait = reader.GetString(0);
                reader.Close();
            }

            return returnedTrait;
        }

        public int GetID(string wantedID, string textboxcontent) 
        {
            int returnedID;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("SELECT Id FROM dbo." + wantedID + " WHERE " + wantedID + " = '" + textboxcontent+ "';", connection);
                connection.Open();
                reader = command.ExecuteReader();
                reader.Read();
                returnedID = (int)reader.GetValue(0);
                reader.Close();
            }
            return returnedID;
        }



        public bool SaveCharacter(CharacterModel newCharacter)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand savingCommand = new SqlCommand("INSERT INTO dbo.Characters (LifePhaseId, MainTraitId, MainStrengthId, MainFlawId, GoalId, SecretId)"
                        +"Values (" +
                        newCharacter.LifePhaseId + ", " +
                        newCharacter.MainTraitId + ", " +
                        newCharacter.MainStrengthId + ", " +
                        newCharacter.MainFlawId + ", " +
                        newCharacter.GoalId + ", " +
                        newCharacter.SecretId + ")", connection);
                    savingCommand.ExecuteNonQuery();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
            return true;
        }
       
    }
}

