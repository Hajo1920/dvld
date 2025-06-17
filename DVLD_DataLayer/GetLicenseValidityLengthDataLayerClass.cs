using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLD_DataLayer
{
    public class GetLicenseValidityLengthDataLayerClass
    {
        public static int GetLicenseValidityLengthByLicenseClassID(int licenseClassId)
        {
            int applicaitonId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select DefaultValidityLength from LicenseClasses where LicenseClassID = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", licenseClassId);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value && int.TryParse(result.ToString(), out int id))
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
