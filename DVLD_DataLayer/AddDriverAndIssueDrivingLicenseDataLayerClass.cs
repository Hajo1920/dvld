using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLD_DataLayer
{
    public class AddDriverAndIssueDrivingLicenseDataLayerClass
    {
        public static int AddDriverAndIssueDrivingLicense( int personId, int applicationId, int licenseClass, DateTime createDate, DateTime expireDate, string note, decimal paidFee, bool isActive, byte issueReason, int createdBy)
        {
            int newId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"insert into Drivers values(@personId, @createdBy, @createDate); 
                             insert into Licenses values(@appId, (Select Scope_Identity()),@licenseClass, @createDate, @expireDate, @note, @fee, @isActive, @issueReason, @createdBy); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personId", personId);
            command.Parameters.AddWithValue("@appId", applicationId);
            command.Parameters.AddWithValue("@licenseClass", licenseClass);
            command.Parameters.AddWithValue("@createDate", createDate);
            command.Parameters.AddWithValue("@expireDate", expireDate);
            if(note != "")
            {
                command.Parameters.AddWithValue("@note", note);
            }
            else
            {
                command.Parameters.AddWithValue("@note", DBNull.Value);
            }
            command.Parameters.AddWithValue("@fee", paidFee);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@issueReason", issueReason);
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

        public static int AddLicenseReplacementForExistingDriver(int driverId, int applicationId, int licenseClass, DateTime createDate, DateTime expireDate, string note, decimal paidFee, bool isActive, byte issueReason, int createdBy)
        {
            int newId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"insert into Licenses values(@appId, @driverId,@licenseClass, @createDate, @expireDate, @note, @fee, @isActive, @issueReason, @createdBy); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@driverId", driverId);
            command.Parameters.AddWithValue("@appId", applicationId);
            command.Parameters.AddWithValue("@licenseClass", licenseClass);
            command.Parameters.AddWithValue("@createDate", createDate);
            command.Parameters.AddWithValue("@expireDate", expireDate);
            if (note != "")
            {
                command.Parameters.AddWithValue("@note", note);
            }
            else
            {
                command.Parameters.AddWithValue("@note", DBNull.Value);
            }
            command.Parameters.AddWithValue("@fee", paidFee);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@issueReason", issueReason);
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
