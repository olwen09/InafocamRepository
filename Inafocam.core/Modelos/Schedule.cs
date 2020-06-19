using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Schedule
    {
        public Schedule()
        {
            ScheduleDay = new HashSet<ScheduleDay>();
            User = new HashSet<User>();
        }

        public long ScheduleId { get; set; }
        public string ScheduleName { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpdatingUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdatingDate { get; set; }
        public long? StatusId { get; set; }

        public virtual User CreationUser { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpdatingUser { get; set; }
        public virtual ICollection<ScheduleDay> ScheduleDay { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
