using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class DriversListDataLayerClass
    {
        public static DataTable ListDrivers()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = "Select * from Drivers_View";
            SqlCommand command = new SqlCommand(query, connection);
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
