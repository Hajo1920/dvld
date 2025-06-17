using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_BusinessLayer;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class FullPersonDetailBusinessLayerClass
    {
        public static DataTable FullPersonDetail(int id)
        {
           return FullPersonDetailDataLayerClass.GetFullPersonDetails(id);
        }

        public static DataTable FullPersonDetail(string  nationalNo)
        {
            return FullPersonDetailDataLayerClass.GetFullPersonDetails(nationalNo);
        }
    }
}
