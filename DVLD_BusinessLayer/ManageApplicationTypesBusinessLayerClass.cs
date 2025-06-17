using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class ManageApplicationTypesBusinessLayerClass
    {
        public static DataTable GetApplicationTypes()
        {
            return ManageApplicationTypesDataLayerClass.GetApplicationTypes();
        }

        public static bool UpdateApplicationTypesSetting(int id, string title, decimal fee)
        {
            return ManageApplicationTypesDataLayerClass.UpdateApplicationTypesSetting(id, title, fee);
        }
    }
}
