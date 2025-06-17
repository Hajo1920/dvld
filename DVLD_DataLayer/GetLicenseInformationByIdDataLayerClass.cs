using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DVLD_DataLayer
{
    public class GetLicenseInformationByIdDataLayerClass
    {
        public static DataTable GetLicenseInformationById(int appId)
        {

            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select * from Licenses where (LicenseID = @id or ApplicationID = @id) and IsActive = 1;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", appId);

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

        public static DataTable GetLicenseInformationByIdWithoutIsActiveCheck(int appId)
        {

            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select * from Licenses where LicenseID = @id or ApplicationID = @id;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", appId);

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

        public static DataTable GetLicenseHistoryInformationById(int appId)
        {

            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select Licenses.LicenseID, 
                                    Licenses.ApplicationID, 
                                    LicenseClasses.ClassName, 
                                    Licenses.IssueDate, 
                                    Licenses.ExpirationDate, 
                                    Licenses.IsActive
                                    from Licenses inner join LicenseClasses on LicenseClasses.LicenseClassID = Licenses.LicenseClass where DriverID = @id;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", appId);

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

        public static int GetLicenseIdByApplicationId(int appid)
        {
            int applicaitonId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select LicenseID from Licenses where ApplicationID = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", appid);
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
