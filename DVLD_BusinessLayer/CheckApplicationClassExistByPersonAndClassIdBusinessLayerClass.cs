using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class CheckApplicationClassExistByPersonAndClassIdBusinessLayerClass
    {
        public static bool CheckApplicationClassExist(int personId, int classId)
        {
          return  CheckApplicationClassesExistByPersonAndClassIdDataLayerClass.CheckApplicationClassExist(personId, classId);
        }
    }
}
