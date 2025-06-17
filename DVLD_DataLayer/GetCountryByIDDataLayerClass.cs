using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class GetCountryByIDDataLayerClass
    {
        public static string GetCountry(int Id)
        {
            string country = "";
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = "Select  CountryName from Countries where CountryID = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", Id);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    country = (string)result;
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


            return country;
        }
    }
}
