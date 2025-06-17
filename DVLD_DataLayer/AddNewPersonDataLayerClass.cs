using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLD_DataLayer
{
    public class AddNewPersonDataLayerClass
    {

        public static int AddNewPersonToPeopleList( string FirstName,  string SecondName,  string ThirdName,
             string LastName,  string NationalID,
             string Email,  string Phone,  DateTime BirthDate, 
             int CountryID,
             string Address,  byte Gendor,  string ImagePath)
        {
            int newId = -1;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Insert into People values(@NationalNo, @First, @Second, @Third, @Last, @Birth, @Gendor, @Address, @Phone, @Email, @CountryID, @ImagePath); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalID);
            command.Parameters.AddWithValue("@First", FirstName);
            command.Parameters.AddWithValue("@Second", SecondName);
            if (ThirdName != "")
                command.Parameters.AddWithValue("@Third", ThirdName);
            else
            command.Parameters.AddWithValue("@Third", System.DBNull.Value);
            command.Parameters.AddWithValue("@Last", LastName);
            command.Parameters.AddWithValue("@Birth", BirthDate);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(), out int RetrivedID))
                {
                    newId = RetrivedID;
                }
                else
                {
                    newId = -1;
                }
            }catch(SqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return newId;
        }

        public static int GetCountryID(string comboxSelectedIndexName)
        {
            int Id = 0;

            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = @"Select CountryID from Countries Where CountryName = @name;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", comboxSelectedIndexName);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int RetrivedID))
                {
                    Id = RetrivedID;
                }

            }catch(SqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return Id;

        }
    }
}
