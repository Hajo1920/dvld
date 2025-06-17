using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DVLD_DataLayer
{
    public class UpdateUserPasswordDataLayerClass
    {

        public static bool CheckCurrentPasswordCorrect(int personId, string password)
        {
            bool isCorrect = false;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);

            string query = "Select  Correct=1 from Users where PersonID = @id and Password=@password;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", personId);
            command.Parameters.AddWithValue("@password", password);


            try
            {
                connection.Open();
                
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                isCorrect = true;
                }else isCorrect = false;

                reader.Close();

            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }


            return isCorrect;
        }

        public static bool UpdateCurrentUserPassword(int personId, string password)
        {
            int rowsAffected = 0;

            string hashed_password = PassHasher.Hash256(password);

            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Update Users Set Password = @password where PersonID = @id";
            SqlCommand command = new SqlCommand(query, connection); 

            command.Parameters.AddWithValue("@id", personId);
            command.Parameters.AddWithValue("@password", hashed_password);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw; }
            finally {
            connection.Close();
            }
            return rowsAffected > 0;
        }

    }
}
