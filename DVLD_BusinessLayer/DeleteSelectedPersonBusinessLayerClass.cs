using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class DeleteSelectedPersonBusinessLayerClass
    {
        public static bool DeletePerson(int id)
        {
            return DeleteSelectedPersonDataLayerClass.DeletePerson(id);
        }
    }
}
