using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataLayer
{
    public class FullPersonDetailDataLayerClass
    {
        public static DataTable GetFullPersonDetails(int id)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = "Select  * from People where PersonID = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }

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


            return table;
        }

        public static DataTable GetFullPersonDetails(string nationalNo)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = "Select  * from People where NationalNo = @nationalNo;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nationalNo", nationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }

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


            return table;
        }

    }
}
