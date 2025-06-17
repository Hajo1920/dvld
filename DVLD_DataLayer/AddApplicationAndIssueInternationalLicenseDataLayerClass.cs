using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class AddApplicationAndIssueInternationalLicenseDataLayerClass
    {

        public static int AddApplicationAndIssueInternationalLicense(int personId, int driverId, int localLicenseId,  int licenseClass, int applicationType, byte status, DateTime createDate, DateTime expireDate, decimal fee, bool isActive, int createdBy)
        {
            int newId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"insert into Applications values(@personId, @createDate, @licenseClass, @applicationType, @status, @lastStatusDate, @fee, @createdBy); 
                             insert into InternationalLicenses values((Select Scope_Identity()), @driverId, @LocalLicenseId, @createDate, @expireDate, @isActive, @createdBy); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personId", personId);
            command.Parameters.AddWithValue("@driverId", driverId);
            command.Parameters.AddWithValue("@LocalLicenseId", localLicenseId);
            command.Parameters.AddWithValue("@licenseClass", licenseClass);
            command.Parameters.AddWithValue("@applicationType", applicationType);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@lastStatusDate", createDate);
            command.Parameters.AddWithValue("@createDate", createDate);
            command.Parameters.AddWithValue("@expireDate", expireDate);
            command.Parameters.AddWithValue("@fee", fee);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@createdBy", createdBy);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    newId = id;
                }
                else newId = -1;

            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return newId;
        }

    }
}
