using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLD_DataLayer
{
    public class TableRecordsCountDataLayerClass
    {

        public static int TotalRegisteredPeopleCount()
        {
            int count = 0;

            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Select TotalPeople=COUNT(*) From People;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(), out int countResult)){
                    count = countResult;
                }

            }catch(SqlException ex) { throw; }
            finally
            {
                connection.Close();
            }

            return count;
        }

        public static int TotalUsersCount()
        {
            int count = 0;

            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Select TotalUsers=COUNT(*) From Users;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int countResult)){
                    count = countResult;
                }

            }
            catch (SqlException ex) { throw; }
            finally
            {
                connection.Close();
            }

            return count;
        }

        public static int TotalDriversCount()
        {
            int count = 0;

            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Select TotalUsers=COUNT(*) From Drivers;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int countResult))
                {
                    count = countResult;
                }

            }
            catch (SqlException ex) { throw; }
            finally
            {
                connection.Close();
            }

            return count;
        }

        public static int TotalPendingApplications()
        {
            int count = 0;

            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Select TotaPendingApplications=COUNT(*) From LocalDrivingLicenseApplications_View where Status='New';";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int countResult))
                {
                    count = countResult;
                }

            }
            catch (SqlException ex) { throw; }
            finally
            {
                connection.Close();
            }

            return count;
        }

        public static int TotalDetainedLicenses()
        {
            int count = 0;

            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Select TotalDetainedLicenses=COUNT(*) From DetainedLicenses where IsReleased=0;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int countResult))
                {
                    count = countResult;
                }

            }
            catch (SqlException ex) { throw; }
            finally
            {
                connection.Close();
            }

            return count;
        }
        public static int TotalInternationalLicenses()
        {
            int count = 0;

            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Select TotalInternationalLicenses=COUNT(*) From InternationalLicenses;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int countResult))
                {
                    count = countResult;
                }

            }
            catch (SqlException ex) { throw; }
            finally
            {
                connection.Close();
            }

            return count;
        }
    }
}
