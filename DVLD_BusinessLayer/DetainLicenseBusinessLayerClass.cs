using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class DetainLicenseBusinessLayerClass
    {
        public static int DetainLocalLicense(int licenseId, DateTime detainDate, decimal fee, int createdByUser, bool isReleased, DateTime releaseDate, int releasedByUserId, int releasedApplicationId)
        {
            return DetainLicenseDataLayerClass.DetainLocalLicense(licenseId, detainDate, fee, createdByUser, isReleased, releaseDate, releasedByUserId, releasedApplicationId);
        }
        public static int GetDetainIdUsingLicenseId(int licenseId)
        {
            return DetainLicenseDataLayerClass.GetDetainIdUsingLicenseId(licenseId);
        }
    }
}
