using System.Configuration;
using System.Data.SqlClient;
using System.Numerics;
namespace DVLD_DataLayer
{

    class DB_Address
    {
        public static string db_address = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
    }
    public class LoginDataLayerClass
    {

        public static int ValidateLogin(string username, string password)
        {
            int personId = -1;
            string hashed_password = PassHasher.Hash256(password);
            SqlConnection connection = new SqlConnection(DB_Address.db_address);
            string query = "Select PersonID from Users where UserName=@user and Password=@password; select scope_identity();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@user", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id)) {
                    personId = id;
                }else personId = -1;
            }
            catch(SqlException ex) { throw; }
            finally { connection.Close(); }


            return personId;
        } 

    }
}
