using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class UpdateLicenseApplicationStatusBusinessLayerClass
    {
        public static bool UpdateLicenseApplicationStatus(int applicationId, byte status)
        {
            return UpdateLicenseApplicationStatusDataLayerClass.UpdateLicenseApplicationStatus(applicationId, status);
        }
    }
}
