using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class GetInternationalLicenseInformationByIdDataLayerClass
    {
        public static DataTable GetInternationalLicenseInformationById(int licenseId)
        {

            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Select * from InternationalLicenses where InternationalLicenseID = @id;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", licenseId);

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
