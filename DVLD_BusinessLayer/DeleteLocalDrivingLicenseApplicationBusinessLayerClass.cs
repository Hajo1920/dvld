using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class DeleteLocalDrivingLicenseApplicationBusinessLayerClass
    {

        public static bool CheckApplicationIsCanceled(int id)
        {
            return DeleteLocalDrivingLicenseApplicationDataLayerClass.CheckLicenseIsCanceled(id);
        }

        public static bool DeleteLocalDrivingLicenseApplication(int id)
        {
            return DeleteLocalDrivingLicenseApplicationDataLayerClass.DeleteLocalDrivingLicenseApplication(id);
        }
    }
}
