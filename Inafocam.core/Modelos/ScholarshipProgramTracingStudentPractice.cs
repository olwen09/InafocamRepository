using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgramTracingStudentPractice
    {
        public long Id { get; set; }
        public long? TracingId { get; set; }
        public string PracticeType { get; set; }
        public int? StudentsQuantity { get; set; }
        public int? PracticeCenterQuantity { get; set; }
        public int? SupervisorQuantity { get; set; }
        public int? TeacherQuantity { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ScholarshipProgramTracing Tracing { get; set; }
    }
}
