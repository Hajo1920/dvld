using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class RenewExpiredLicenseBusinessLayerClass
    {
        public static bool RenewExpiredLicense(int licenseId, DateTime issueDate, DateTime expireDate)
        {
            return RenewExpiredLicenseDataLayerClass.RenewExpiredLicense(licenseId, issueDate, expireDate);
        }
    }
}
