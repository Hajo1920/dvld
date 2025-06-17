using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class AddNewUserBusinessLayerClass
    {
        public static int AddNewSystemUser(int personId, string userName, string password, bool isactive)
        {
            return AddNewUserDataLayerClass.AddNewUser(personId, userName, password, isactive);
        }
    }
}
