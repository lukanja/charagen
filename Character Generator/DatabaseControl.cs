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

            // for connection testing purposes
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

        
        public int GetID(string wantedID, string textboxcontent)  //finds the ID of relevant trait via textbox
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



        public bool SaveCharacter(CharacterModel newCharacter) //for saving a character
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

        public CharacterModel GetCharacter() //for getting a random saved character
        {
            CharacterModel Character;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM dbo.Characters ORDER BY NEWID();", connection); //rearranges the table and picks the first row
                connection.Open();
                reader = command.ExecuteReader();
                reader.Read();
                
                int id = (int)reader.GetValue(0);
                int lifephase = (int)reader.GetValue(1);
                int trait = (int)reader.GetValue(2);
                int strength = (int)reader.GetValue(3);
                int flaw = (int)reader.GetValue(4);
                int goal = (int)reader.GetValue(5);
                int secret = (int)reader.GetValue(6);

                Character = new CharacterModel(id,lifephase,trait,strength,flaw,goal,secret); //saves the table values into a character object
            }
                return Character;
        }

        public string TraitFromId(int traitid, string wantedTrait) //finds the proper trait as string based on id
        {
            string resultTrait;

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("SELECT " +wantedTrait+ "." +wantedTrait+ " FROM dbo." +wantedTrait+
                    " INNER JOIN Characters ON " + wantedTrait+ ".Id=Characters." +wantedTrait+"Id" +
                    " WHERE " + wantedTrait + ".Id="+ traitid.ToString()+";", connection);
                connection.Open();
                reader = command.ExecuteReader();
                reader.Read();
                resultTrait = reader.GetString(0);
                reader.Close();
            }

            return resultTrait;
        }

        public bool DeleteCharacter(int delCharacter) //for deleting a character
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    SqlCommand command = new SqlCommand(
                        "DELETE FROM dbo.Characters WHERE Id ="+delCharacter, connection);
                    command.ExecuteNonQuery();
                    return true;
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }
       
    }

}

