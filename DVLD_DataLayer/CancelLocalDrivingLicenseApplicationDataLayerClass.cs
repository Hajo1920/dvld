using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class CancelLocalDrivingLicenseApplicationDataLayerClass
    {

        public static bool CancelLocalLicenseApplication(int applicationId, byte status, DateTime statusDate, int userId)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Update Applications set LastStatusDate=@statusDate, ApplicationStatus=@status, CreatedByUserID = @userId where ApplicationID = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", applicationId);
            command.Parameters.AddWithValue("@status", status);;
            command.Parameters.AddWithValue("@statusDate", statusDate);
            command.Parameters.AddWithValue("@userId", userId);

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
