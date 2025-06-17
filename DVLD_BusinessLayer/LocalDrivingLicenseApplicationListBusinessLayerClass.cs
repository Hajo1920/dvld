using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class LocalDrivingLicenseApplicationListBusinessLayerClass
    {
        public static DataTable LocalLicenseApplicationsList()
        {
            return LocalDrivingLicenseApplicationsListDataLayerClass.ListApplications();
        }

        public static DataTable GetLocalDrivingLicenseApplicationDetailById(int id) { 
        
            return LocalDrivingLicenseApplicationsListDataLayerClass.GetLocalDrivingLicenseApplcationDetailById(id);
        }

        public static int GetLocalDrivingLicenseApplicationIdByApplicationID(int appID)
        {
            return LocalDrivingLicenseApplicationsListDataLayerClass.GetLocalDrivingLicenseApplicationIdByApplicationID(appID);
        }
    }
}
