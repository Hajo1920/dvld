using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataLayer
{
    public class GetApplicationDetailDataLayerClass
    {

        public static DataTable GetApplicationDatailById(int ldl_ID)
        {

            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select * from Applications where ApplicationID = (Select ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @id) or ApplicationID = @id;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", ldl_ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) { 
                table.Load(reader);
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally {
            
                connection.Close();
            }

            return table;

        }

       

        public static string GetApplicationType(int typeId)
        {
            string typeName = "";
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select ApplicationTypeTitle from ApplicationTypes where ApplicationTypeID = @id ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", typeId);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value) {
                    typeName = Convert.ToString(result);
                }
            }catch(SqlException ex)
            {
                throw;
            }finally
            {
                connection.Close();
            }

            return typeName;

        }

        public static int GetApplicationId(int ldl_id)
        {
            int applicaitonId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @id ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", ldl_id);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value && int.TryParse(result.ToString(), out int id))
                {
                    applicaitonId = id;
                }else applicaitonId = -1;
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
