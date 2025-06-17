using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Numerics;

namespace DVLD_DataLayer
{
    public class DeleteSelectedPersonDataLayerClass
    {

       

        public static bool DeletePerson(int id)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DB_Address.db_address);

            string query = @"Delete People where PersonID = @id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }


            return (rowsAffected != 0);
        }
    }
}
