using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class ReleaseDetainedLicenseDataLayerClass
    {
        public static bool ReleaseDetainedLocalLicense(int licenseId, bool isReleased, DateTime releaseDate, int releasedByUserId, int releaseApplicationId)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Update DetainedLicenses set IsReleased=@isReleased, ReleaseDate=@releaseDate, ReleasedByUserID=@releasedByUserId, ReleaseApplicationID=@releaseApplicationId  where LicenseID = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", licenseId);
            command.Parameters.AddWithValue("@isReleased", isReleased);
            command.Parameters.AddWithValue("@releaseDate", releaseDate);
            command.Parameters.AddWithValue("@releasedByUserId", releasedByUserId);
            command.Parameters.AddWithValue("@releaseApplicationId", releaseApplicationId); 
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
