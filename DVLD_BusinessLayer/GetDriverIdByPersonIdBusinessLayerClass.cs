using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class GetDriverIdByPersonIdBusinessLayerClass
    {
        public static int GetDriverIdByPersonId(int personId)
        {
            return GetDriverIdByPersonIdDataLayerClass.GetDriverIdByPersonId(personId);
        }
    }
}
