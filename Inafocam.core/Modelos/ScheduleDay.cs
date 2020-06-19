using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScheduleDay
    {
        public long ScheduleDayId { get; set; }
        public long? ScheduleId { get; set; }
        public string ScheduleDay1 { get; set; }
        public TimeSpan? ScheduleStartTime { get; set; }
        public TimeSpan? ScheduleEndTime { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
