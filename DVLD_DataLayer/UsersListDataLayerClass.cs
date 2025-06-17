using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataLayer
{
    public class UsersListDataLayerClass
    {
        public static DataTable UsersList()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = "Select * from UsersInformation;";
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

        public static DataTable GetUsersByPersonId( int id)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = "Select * from UsersInformation where PersonID = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

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

        public static string GetUserNameByUserId(int userId)
        {
            string username = "";
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select UserName from Users where UserID = @id ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", userId);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    username = Convert.ToString(result);
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

            return username;

        }
    

    

        public static string GetUserNameByPersonId(int userId)
        {
            string name = "";
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"select UserName from Users where PersonID = @id ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", userId);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    name = Convert.ToString(result);
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

            return name;

        }
    }
}
