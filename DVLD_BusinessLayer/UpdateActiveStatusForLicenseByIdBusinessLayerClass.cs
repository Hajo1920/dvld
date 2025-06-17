using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class UpdateActiveStatusForLicenseByIdBusinessLayerClass
    {
        public static bool UpdateActiveStatusForLicenseById(int licenseId, bool status)
        {
            return UpdateActiveStatusForLicenseByIdDataLayerClass.UpdateActiveStatusForLicenseById(licenseId, status);
        }
    }
}
