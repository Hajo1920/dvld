using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class CheckLInternationalLicenseExistByLicenseIdDataLayerClass
    {

        public static int CheckLInternationalLicenseExistByLicenseId(int licenseId)
        {
            int applicaitonId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @" select InternationalLicenses.InternationalLicenseID from Licenses 
                              join InternationalLicenses on InternationalLicenses.DriverID = Licenses.DriverID
                              where Licenses.LicenseID = @id;";
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

/* */