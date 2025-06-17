using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class UpdateUserPasswordBusinessLayerClass
    {

        public static bool CheckCurrentUserPassword(int personId, string password)
        {
            return UpdateUserPasswordDataLayerClass.CheckCurrentPasswordCorrect(personId, password);
        }
        public static bool UpdateCurrentUserPassword(int personId, string password)
        {
            return UpdateUserPasswordDataLayerClass.UpdateCurrentUserPassword(personId, password);
        }
    }
}
