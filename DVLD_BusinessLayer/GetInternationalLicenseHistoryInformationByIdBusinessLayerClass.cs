using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class GetInternationalLicenseHistoryInformationByIdBusinessLayerClass
    {
        public static DataTable GetInternationalLicenseHistoryInformationById(int appId)
        {
            return GetInternationalLicenseHistoryInformationByIdDataLayerClass.GetInternationalLicenseHistoryInformationById(appId);
        }
    }
}
