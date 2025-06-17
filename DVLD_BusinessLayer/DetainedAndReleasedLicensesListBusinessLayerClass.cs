using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class DetainedAndReleasedLicensesListBusinessLayerClass
    {
        public static DataTable DetainedLicenseList()
        {
            return DetainedAndReleasedLicensesListDataLayerClass.DetainedLicenseList();
        }

        public static DataTable ReleasedLicenseList()
        {
            return DetainedAndReleasedLicensesListDataLayerClass.ReleasedLicenseList();
        }
    }
}
