using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLD_DataLayer
{
    public class UpdateScheduledAppointmentDataLayerClass
    {
        public static bool UpdateBookedAppointment(int appointmentId, DateTime date, int createdBy)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Update TestAppointments set AppointmentDate=@date, CreatedByUserID = @userId where TestAppointmentID = @appointmentId;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@appointmentId", appointmentId);
            command.Parameters.AddWithValue("@userId", createdBy);

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


            return rowsAffected > 0;
        }
        public static bool UpdateBookedAppointment(int appointmentId, bool isLocked)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Update TestAppointments set IsLocked = @isLocked where TestAppointmentID = @appointmentId;";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@appointmentId", appointmentId);
            command.Parameters.AddWithValue("@isLocked", isLocked);

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


            return rowsAffected > 0;
        }
    }
}
