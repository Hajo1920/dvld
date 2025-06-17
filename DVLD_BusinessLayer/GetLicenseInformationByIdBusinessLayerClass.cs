using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class GetLicenseInformationByIdBusinessLayerClass
    {
        public static DataTable GetLicenseInformationById(int appId)
        {
            return GetLicenseInformationByIdDataLayerClass.GetLicenseInformationById(appId);
        }

        public static DataTable GetLicenseInformationByIdWithoutIsActiveCheck(int appId)
        {
            return GetLicenseInformationByIdDataLayerClass.GetLicenseInformationByIdWithoutIsActiveCheck(appId);
        }

        public static int GetLicenseIdByApplicationId(int appid)
        {
            return GetLicenseInformationByIdDataLayerClass.GetLicenseIdByApplicationId(appid);
        }

        public static DataTable GetLicenseHistoryInformationById(int appId)
        {
            return GetLicenseInformationByIdDataLayerClass.GetLicenseHistoryInformationById(appId);
        }
    }
}
