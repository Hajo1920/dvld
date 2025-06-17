using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class AddApplicationAndIssueInternationalLicenseBusinessLayerClass
    {

        public static int AddApplicationAndIssueInternationalLicense(int personId, int driverId, int localLicenseId, int licenseClass, int applicationType, byte status, DateTime createDate, DateTime expireDate, decimal fee, bool isActive, int createdBy)
        {
            return AddApplicationAndIssueInternationalLicenseDataLayerClass.AddApplicationAndIssueInternationalLicense(personId, driverId, localLicenseId, licenseClass, applicationType, status, createDate, expireDate, fee, isActive, createdBy);
        }
    }
}
