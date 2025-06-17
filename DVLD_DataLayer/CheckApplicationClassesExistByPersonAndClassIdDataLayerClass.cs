using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class CheckApplicationClassesExistByPersonAndClassIdDataLayerClass
    {
        public static bool CheckApplicationClassExist(int personId, int classId)
        {
            bool result = false;
           
            SqlConnection connection = new SqlConnection(DB_Address.db_address);

            string query = @"Select Result=1 from Applications Where (ApplicantPersonID = @id and LicenseClassID=@classId) and (ApplicationStatus = 1 or ApplicationStatus = 3)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", personId);
            command.Parameters.AddWithValue("@classId", classId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    result = true;
                }
                else result = false;

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

            return result;
        }
    }
}
