using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class CancelLocalDrivingLicenseApplicationBusinessLayerClass
    {

        public static bool CancelLocalDrivingLicenseApplication(int applicationId, byte status, DateTime statusDate, int userId)
        {
            return CancelLocalDrivingLicenseApplicationDataLayerClass.CancelLocalLicenseApplication(applicationId, status, statusDate, userId);
        }
    }
}
