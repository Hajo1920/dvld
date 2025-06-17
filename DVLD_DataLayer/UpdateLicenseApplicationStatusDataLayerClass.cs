using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_DataLayer
{
    public class UpdateLicenseApplicationStatusDataLayerClass
    {
        public static bool UpdateLicenseApplicationStatus(int applicationId, byte status)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Update Applications set ApplicationStatus=@status where ApplicationID = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", applicationId);
            command.Parameters.AddWithValue("@status", status); ;
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
