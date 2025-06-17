using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class GetLicenseValidityLengthBusinessLayerClass
    {
        public static int GetLicenseValidityLengthByLicenseClassID(int licenseClassId)
        {
            return GetLicenseValidityLengthDataLayerClass.GetLicenseValidityLengthByLicenseClassID(licenseClassId);
        }
    }
}
