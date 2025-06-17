using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class AddDriverAndIssueDrivingLicenseBusinessLayerClass
    {
      public static int AddDriverAndIssueDrivingLicense(int personId, int applicationId, int licenseClass, DateTime createDate, DateTime expireDate, string note, decimal paidFee, bool isActive, byte issueReason, int createdBy)
        {
            return AddDriverAndIssueDrivingLicenseDataLayerClass.AddDriverAndIssueDrivingLicense(personId, applicationId, licenseClass, createDate, expireDate, note, paidFee, isActive, issueReason, createdBy);
        }

        public static int AddLicenseReplacementForExistingDriver(int driverId, int applicationId, int licenseClass, DateTime createDate, DateTime expireDate, string note, decimal paidFee, bool isActive, byte issueReason, int createdBy)
        {
            return AddDriverAndIssueDrivingLicenseDataLayerClass.AddLicenseReplacementForExistingDriver(driverId, applicationId, licenseClass, createDate, expireDate, note, paidFee, isActive, issueReason, createdBy);
        }
    }
}
