using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLD_DataLayer
{
    public class GetAppointmentInformationListDataLayerClass
    {

        public static DataTable GetAppointmentList(int ldlID, int testTypeID)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Select TestAppointmentID, AppointmentDate, PaidFees, IsLocked from TestAppointments where LocalDrivingLicenseApplicationID = @ldlID and TestTypeID = @testTypeId;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ldlID", ldlID);
            command.Parameters.AddWithValue("@testTypeId", testTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }
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
    }
}
