using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgramTracingPracticePlanning
    {
        public long Id { get; set; }
        public long? TracingId { get; set; }
        public string Action { get; set; }
        public short? Started { get; set; }
        public short? Finished { get; set; }
        public string Comment { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ScholarshipProgramTracing Tracing { get; set; }
    }
}
