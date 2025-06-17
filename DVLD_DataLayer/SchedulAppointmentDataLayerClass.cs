using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataLayer
{
    public class SchedulAppointmentDataLayerClass
    {
        public static int BookTestAppointment(int testTypeId, int ldlId, DateTime appointmentDate, decimal paidFee, int createdBy, bool isLocked)
        {
            int newId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Insert into TestAppointments values(@testTypeId, @ldlId, @appointmentDate, @paidFee, @createdBy, @isLocked); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testTypeId", testTypeId);
            command.Parameters.AddWithValue("@ldlId", ldlId);
            command.Parameters.AddWithValue("@appointmentDate", appointmentDate);
            command.Parameters.AddWithValue("@paidFee", paidFee);
            command.Parameters.AddWithValue("@createdBy", createdBy);
            command.Parameters.AddWithValue("@isLocked", isLocked);
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
