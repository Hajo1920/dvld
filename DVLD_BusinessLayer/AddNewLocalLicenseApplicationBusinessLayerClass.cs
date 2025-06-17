using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;


namespace DVLD_BusinessLayer
{
    public class AddNewLocalLicenseApplicationBusinessLayerClass
    {
        public static DataTable LicenseClassesList()
        {
            return AddNewLocalLicenseApplicationDataLayerClass.LicenseClassesList();
        }

        public static int AddNewLocalDrivingApplication(int personId, DateTime applicationDate, int licenseClassId, int applicationTypeId, byte applicationStatus, DateTime lastStatusDate, decimal fee, int createdByUser)
        {
            return AddNewLocalLicenseApplicationDataLayerClass.AddNewLocalDrivingApplication(personId, applicationDate, licenseClassId, applicationTypeId, applicationStatus, lastStatusDate, fee, createdByUser);
        }
    }
}
