using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class ScheduleAppointmentBusinessLayerClass
    {
        public static int BookTestAppointment(int testTypeId, int ldlId, DateTime appDate, decimal paidFee, int createdBy, bool isLocked)
        {
            return SchedulAppointmentDataLayerClass.BookTestAppointment(testTypeId, ldlId, appDate, paidFee, createdBy, isLocked);
        }

       
    }
}
