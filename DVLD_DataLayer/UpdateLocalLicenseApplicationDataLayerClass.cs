using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLD_DataLayer
{
    public class UpdateLocalLicenseApplicationDataLayerClass
    {

        public static bool UpdateLocalLicenseApplication(int applicationId, DateTime date, int licenseClassId, int typeId, DateTime statusDate, decimal fee, int userId)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Update Applications set ApplicationDate=@date, LicenseClassID=@licenseClassId, ApplicationTypeID=@typeId, LastStatusDate=@statusDate, PaidFees=@fee, CreatedByUserID = @userId where ApplicationID = @id; update LocalDrivingLicenseApplications set LicenseClassID=@licenseClassId where ApplicationID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", applicationId);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@licenseClassId", licenseClassId);
            command.Parameters.AddWithValue("@typeId", typeId);
            command.Parameters.AddWithValue("@statusDate", statusDate);
            command.Parameters.AddWithValue("@fee", fee);
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
            finally {
            connection.Close();
            }


            return rowsAffected > 0;
        }
    }
}
