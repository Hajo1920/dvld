using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLD_DataLayer
{
    public class UpdatePersonDataLayerClass
    {

        public static bool UpdatePerson(int ID, string NationalNo, string FirstName, string SecondName,string ThirdName, 
            string LastName, byte Gendor,
            string Email, string Phone, string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DB_Address.db_address);

            string query = @"Update People Set 
                                NationalNo = @nationalNo,
                                FirstName = @first, 
                                SecondName = @second, 
                                ThirdName = @third, 
                                LastName = @last, 
                                DateOfBirth = @birth, 
                                Gendor = @gendor, 
                                Address = @address, 
                                Phone = @phone, 
                                Email = @email, 
                                NationalityCountryID = @countryId, 
                                ImagePath = @img where PersonID = @personId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personId", ID);
            command.Parameters.AddWithValue("@nationalNo", NationalNo);
            command.Parameters.AddWithValue("@first", FirstName);
            command.Parameters.AddWithValue("@second", SecondName);
            if(ThirdName != "")
            {
                command.Parameters.AddWithValue("@third", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@third", System.DBNull.Value);
            }
            command.Parameters.AddWithValue("@last", LastName);
            command.Parameters.AddWithValue("@gendor", Gendor);
            if (Email != "")
            {
                command.Parameters.AddWithValue("@email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@email", System.DBNull.Value);
            }
            command.Parameters.AddWithValue("@phone", Phone);
            command.Parameters.AddWithValue("@address", Address);
            command.Parameters.AddWithValue("@birth", DateOfBirth);
            command.Parameters.AddWithValue("@countryId", CountryID);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@img", ImagePath);
            else
                command.Parameters.AddWithValue("@img", System.DBNull.Value);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }
    }
}
