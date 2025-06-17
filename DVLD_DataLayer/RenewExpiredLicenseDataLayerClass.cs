using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class RenewExpiredLicenseDataLayerClass
    {
        public static bool RenewExpiredLicense(int licenseId, DateTime issueDate, DateTime expireDate)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Update Licenses set IssueDate=@issueDate, ExpirationDate=@expireDate where LicenseID = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", licenseId);
            command.Parameters.AddWithValue("@issueDate", issueDate);
            command.Parameters.AddWithValue("@expireDate", expireDate);

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
