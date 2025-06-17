using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class TableRecordCountBusinessLayerClass
    {
        public static int TotalPeopleCount()
        {
            return TableRecordsCountDataLayerClass.TotalRegisteredPeopleCount();
        }

        public static int TotalUsersCount()
        {
            return TableRecordsCountDataLayerClass.TotalUsersCount();
        }

        public static int TotalDriversCount()
        {
            return TableRecordsCountDataLayerClass.TotalDriversCount();
        }

        public static int TotalPendingApplications()
        {
            return TableRecordsCountDataLayerClass.TotalPendingApplications();
        }

        public static int TotalDetainedLicenses()
        {
            return TableRecordsCountDataLayerClass.TotalDetainedLicenses();
        }

        public static int TotalInternationalLicenses()
        {
            return TableRecordsCountDataLayerClass.TotalInternationalLicenses();
        }

    }
}
