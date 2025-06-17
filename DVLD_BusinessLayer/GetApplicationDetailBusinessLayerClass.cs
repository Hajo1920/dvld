using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class GetApplicationDetailBusinessLayerClass
    {
        public static DataTable GetApplicationDetailById(int ldl_id)
        {
            return GetApplicationDetailDataLayerClass.GetApplicationDatailById(ldl_id);
        }

        public static string GetApplicationType(int typeId)
        {
            return GetApplicationDetailDataLayerClass.GetApplicationType(typeId);
        }

        public static int GetApplicationID(int ldl_id) {
        return GetApplicationDetailDataLayerClass.GetApplicationId(ldl_id);
        }
    }
}
