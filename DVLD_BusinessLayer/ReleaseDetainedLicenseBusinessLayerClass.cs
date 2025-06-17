using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class ReleaseDetainedLicenseBusinessLayerClass
    {
        public static bool ReleaseDetainedLocalLicense(int licenseId, bool isReleased, DateTime releaseDate, int releasedByUserId, int releaseApplicationId)
        {
            return ReleaseDetainedLicenseDataLayerClass.ReleaseDetainedLocalLicense(licenseId, isReleased, releaseDate, releasedByUserId, releaseApplicationId);
        }
    }
}
