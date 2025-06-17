using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataLayer
{
    public class PeopleListDataClass
    {
        public static DataTable ListPeople()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = "Select  * from BasicPeopleInfo;";
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


        public static DataTable ListCountries()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = "Select  CountryName from Countries;";
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
