using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgramUniversityAgent
    {
        public long ScholarshipProgramUniversityCordinatorId { get; set; }
        public long? ScholarshipProgramUniversityId { get; set; }
        public long? AgentId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual ScholarshipProgramUniversity ScholarshipProgramUniversity { get; set; }
        public virtual Status Status { get; set; }
    }
}
