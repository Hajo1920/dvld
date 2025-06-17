using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataLayer
{
    public class AddNewLocalLicenseApplicationDataLayerClass
    {
        public static DataTable LicenseClassesList()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Select * from LicenseClasses;";
            SqlCommand commmand = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = commmand.ExecuteReader();

                if (reader.HasRows)
                {
                    table.Load(reader);
                }
            }catch(SqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return table;
        }

        public static int AddNewLocalDrivingApplication(int personId, DateTime applicationDate, int licenseClassId, int applicationTypeId, byte applicationStatus, DateTime lastStatusDate, decimal fee, int createdByUser)
        {
            int newId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"insert into Applications values(@personId, @applicationDate,@licenseClassId, @applicationTypeId, @applicationStatus, @lastStatusDate, @fee, @createdBy); insert into LocalDrivingLicenseApplications values(SCOPE_IDENTITY(), @licenseClassId) SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personId", personId);
            command.Parameters.AddWithValue("@applicationDate", applicationDate);
            command.Parameters.AddWithValue("@licenseClassId", licenseClassId);
            command.Parameters.AddWithValue("@applicationTypeId", applicationTypeId);
            command.Parameters.AddWithValue("@applicationStatus", applicationStatus);
            command.Parameters.AddWithValue("@lastStatusDate", lastStatusDate);
            command.Parameters.AddWithValue("@fee", fee);
            command.Parameters.AddWithValue("@createdBy", createdByUser);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    newId = id;
                }
                else newId = -1;

            }catch(SqlException ex)
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
