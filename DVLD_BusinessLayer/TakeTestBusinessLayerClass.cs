using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class TakeTestBusinessLayerClass
    {
        public static int TakeTest(int appointmentId, bool testResult, string note, int createdBy)
        {
           return TakeTestDataLayerClass.TakeTest(appointmentId, testResult, note, createdBy);
        }
    }
}
