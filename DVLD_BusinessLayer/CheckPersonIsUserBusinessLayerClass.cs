using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class CheckPersonIsUserBusinessLayerClass
    {

        public static bool CheckPersonIsUser(int id)
        {
            return CheckPersonIsUserDataLayerClass.isPersonUser(id);
        }
    }
}
