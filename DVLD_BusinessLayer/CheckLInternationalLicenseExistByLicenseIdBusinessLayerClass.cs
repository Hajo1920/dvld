using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class CheckLInternationalLicenseExistByLicenseIdBusinessLayerClass
    {
        public static int CheckLInternationalLicenseExistByLicenseId(int licenseId)
        {
            return CheckLInternationalLicenseExistByLicenseIdDataLayerClass.CheckLInternationalLicenseExistByLicenseId(licenseId);
        }
    }
}
