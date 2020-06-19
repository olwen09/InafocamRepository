using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgramTracingCourse
    {
        public long Id { get; set; }
        public long? TracingId { get; set; }
        public string CourseName { get; set; }
        public int? HoursTaken { get; set; }
        public DateTime? CourseStartDate { get; set; }
        public DateTime? CourseEndDate { get; set; }
        public int? StudentsQuantity { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ScholarshipProgramTracing Tracing { get; set; }
    }
}
