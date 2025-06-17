using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class TakeTestDataLayerClass
    {
        public static int TakeTest(int appointmentId, bool testResult, string note, int createdBy)
        {
            int newId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Insert into Tests values(@appointmentId, @testResult, @note, @createdBy); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@appointmentId", appointmentId);
            command.Parameters.AddWithValue("@testResult", testResult);
            
            if (note != "")
                command.Parameters.AddWithValue("@note", note);
            else
            command.Parameters.AddWithValue("@note", System.DBNull.Value);
            command.Parameters.AddWithValue("@createdBy", createdBy);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int RetrivedID))
                {
                    newId = RetrivedID;
                }
                else
                {
                    newId = -1;
                }
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
    }
}
