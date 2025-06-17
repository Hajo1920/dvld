using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DVLD_DataLayer
{
    public class ManageApplicationTypesDataLayerClass
    {
        public static DataTable GetApplicationTypes()
        {

            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select * from ApplicationTypes";
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

        public static bool UpdateApplicationTypesSetting(int id, string title, decimal fee)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Update ApplicationTypes set ApplicationTypeTitle=@title, ApplicationFees=@fee where ApplicationTypeID = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@fee", fee);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }


            return rowsAffected > 0;
        }
    }
}
