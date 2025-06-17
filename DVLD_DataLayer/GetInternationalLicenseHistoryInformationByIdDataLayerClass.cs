using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class GetInternationalLicenseHistoryInformationByIdDataLayerClass
    {
        public static DataTable GetInternationalLicenseHistoryInformationById(int appId)
        {

            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select InternationalLicenses.InternationalLicenseID, 
                                    InternationalLicenses.ApplicationID, 
                                    InternationalLicenses.DriverID, 
                                    InternationalLicenses.IssuedUsingLocalLicenseID, 
                                    InternationalLicenses.IssueDate, 
                                    InternationalLicenses.ExpirationDate,
                                    InternationalLicenses.IsActive
                                    from InternationalLicenses where DriverID = @id;";
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
    }
}
