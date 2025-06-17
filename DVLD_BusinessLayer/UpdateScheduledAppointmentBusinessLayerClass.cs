using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class UpdateScheduledAppointmentBusinessLayerClass
    {
        public static bool UpdateBookedAppointment(int appointmentId, DateTime date, int createdBy)
        {
            return UpdateScheduledAppointmentDataLayerClass.UpdateBookedAppointment(appointmentId, date, createdBy);
        }

        public static bool UpdateBookedAppointment(int appointmentId, bool isLocked)
        {
            return UpdateScheduledAppointmentDataLayerClass.UpdateBookedAppointment(appointmentId, isLocked);
        }
    }
}
