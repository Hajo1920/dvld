using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class DriversListBusinessLayerClass
    {
        public static DataTable ListDrivers()
        {
            return DriversListDataLayerClass.ListDrivers();
        }
    }
}
