using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLD_DataLayer
{
    public class AddNewUserDataLayerClass
    {
        public static int AddNewUser(int PersonId, string userName, string password, bool isActive)
        {
            int newId = -1;
            string hashed_pass = PassHasher.Hash256(password);
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Insert into Users values(@perosnId, @userName, @password, @isActive); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@perosnId", PersonId);
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@password", hashed_pass);
            command.Parameters.AddWithValue("@isActive", isActive);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int RetrivedID))
                {
                    newId = RetrivedID;
                }
                else
                {
                    newId = -1;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return newId;
        }
    }

    }
