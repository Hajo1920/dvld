using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class DetainLicenseDataLayerClass
    {
        public static int DetainLocalLicense(int licenseId, DateTime detainDate, decimal fee, int createdByUser, bool isReleased, DateTime releaseDate, int releasedByUserId, int releasedApplicationId)
        {
            int newId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"insert into DetainedLicenses values(@licenseId, @detainDate,@fee, @createdBy, @isReleased, @releaseDate, @releasedByUserId, @releasedApplicationId); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@licenseId", licenseId);
            command.Parameters.AddWithValue("@detainDate", detainDate);
            command.Parameters.AddWithValue("@fee", fee);
            command.Parameters.AddWithValue("@createdBy", createdByUser);
            command.Parameters.AddWithValue("@isReleased", isReleased);
            if(releaseDate == Convert.ToDateTime("9999-12-30"))
            {
                command.Parameters.AddWithValue("@releaseDate", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@releaseDate", releaseDate);
            }

            if (releasedByUserId == 0)
            {
                command.Parameters.AddWithValue("@releasedByUserId", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@releasedByUserId", releasedByUserId);
            }

            if (releasedApplicationId == 0)
            {
                command.Parameters.AddWithValue("@releasedApplicationId", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@releasedApplicationId", releasedApplicationId);
            }

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

        public static int GetDetainIdUsingLicenseId(int licenseId)
        {
            int applicaitonId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select DetainID from DetainedLicenses where LicenseID = @id and IsReleased = 0;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", licenseId);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    applicaitonId = id;
                }
                else applicaitonId = -1;
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return applicaitonId;

        }

    }
}
