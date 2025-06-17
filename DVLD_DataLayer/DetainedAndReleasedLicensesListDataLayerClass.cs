using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataLayer
{
    public class DetainedAndReleasedLicensesListDataLayerClass
    {
      public static DataTable DetainedLicenseList()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select DetainID, DetainedLicenses.LicenseID, Licenses.ApplicationID, 
                                                         Licenses.DriverID, DetainDate, FineFees, 
                                           DetainedLicenses.CreatedByUserID from DetainedLicenses
                              inner join Licenses on Licenses.LicenseID = DetainedLicenses.LicenseID where IsReleased=0;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }
                reader.Close();

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

        public static DataTable ReleasedLicenseList()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select DetainID, DetainedLicenses.LicenseID, 
                                    Licenses.ApplicationID, Licenses.DriverID, 
                                    DetainDate, DetainedLicenses.ReleaseDate, FineFees, DetainedByUser = DetainedLicenses.CreatedByUserID, 
                                    ReleasedByUser = DetainedLicenses.ReleasedByUserID
                                    from DetainedLicenses inner join Licenses on Licenses.LicenseID = DetainedLicenses.LicenseID where IsReleased=1;";

            SqlCommand command = new SqlCommand(query, connection);

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
