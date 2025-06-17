using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace DVLD_DataLayer
{
    public class DeleteLocalDrivingLicenseApplicationDataLayerClass
    {

        public static bool CheckLicenseIsCanceled(int id)
        {
            bool isCompelte = false;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Select canceled=1 from Applications Where ApplicationID = @id and ApplicationStatus=2";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);


            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    isCompelte = true;
                }
                else isCompelte = false;

                reader.Close();

            }catch(SqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return isCompelte;

        }

        public static bool DeleteLocalDrivingLicenseApplication(int id)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DB_Address.db_address);

            string query = @"delete LocalDrivingLicenseApplications where ApplicationID = @id

                            delete Applications where ApplicationID = @id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }


            return (rowsAffected != 0);
        }
    }
}
