using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class ManageTestTypesBusinessLayerClass
    {
        public static DataTable GetTestTypes()
        {
            return ManageTestTypesDataLayerClass.GetTestTypes();
        }

        public static bool UpdateTestTypesSetting(int id, string title, string description, decimal fee)
        {
            return ManageTestTypesDataLayerClass.UpdateTestTypesSetting(id, title, description, fee);
        }
    }
}
