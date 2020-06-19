using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgramTracingStudentSupport
    {
        public long Id { get; set; }
        public long TracingId { get; set; }
        public long? IndicatorId { get; set; }
        public long? QuestionId { get; set; }
        public string Answer { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ScholarshipProgramTracing Tracing { get; set; }
    }
}
