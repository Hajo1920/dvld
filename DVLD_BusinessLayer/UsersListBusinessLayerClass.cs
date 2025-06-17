using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class UsersListBusinessLayerClass
    {
        public static DataTable ListUsers()
        {
            return UsersListDataLayerClass.UsersList();
        }

        public static DataTable GetUserByPersonId(int personId)
        {
            return UsersListDataLayerClass.GetUsersByPersonId(personId);
        }

        public static string GetUserNameByUserId(int userId)
        {
            return UsersListDataLayerClass.GetUserNameByUserId(userId);
        }

        public static string GetUserNameByPersonId(int userId)
        {
            return UsersListDataLayerClass.GetUserNameByPersonId(userId);
        }

       
    }
}
