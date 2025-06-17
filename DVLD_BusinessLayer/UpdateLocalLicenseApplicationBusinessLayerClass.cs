using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class UpdateLocalLicenseApplicationBusinessLayerClass
    {
        public static bool UpdateLocalLicenseApplication(int id, DateTime date, int licenseClassId, int typeId, DateTime statusDate, decimal fee, int userId)
        {
            return UpdateLocalLicenseApplicationDataLayerClass.UpdateLocalLicenseApplication(id, date, licenseClassId, typeId, statusDate, fee, userId);
        }
    }
}
