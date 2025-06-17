using DVLD_DataLayer;
namespace DVLD_BusinessLayer
{
    public class LoginBusinessLayerClass
    {

        public static int CheckLogin(string username, string password)
        {
           return LoginDataLayerClass.ValidateLogin(username, password);
        }

    }
}
