using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DVLD_DataLayer
{
    public class EventLogger
    {

        public static void Log(string log, EventLogEntryType level)
        {
            string sourceName = "DVLD_App";


            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");

            }

            // Log an information event
            EventLog.WriteEntry(sourceName, log, level);
        }
    }
}
