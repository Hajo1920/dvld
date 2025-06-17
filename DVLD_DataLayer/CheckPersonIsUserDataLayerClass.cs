using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLD_DataLayer
{
    public class CheckPersonIsUserDataLayerClass
    {

        public static bool isPersonUser(int id)
        {
            bool isUser = false;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);

            string query = @"Select Result=1 from Users Where PersonID = @id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    isUser = true;
                }
                else isUser = false;

                reader.Close();

            }catch(SqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return isUser;
        }
    }
}
