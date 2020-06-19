using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Agent
    {
        public Agent()
        {
            ScholarshipProgramTracingCoordinator = new HashSet<ScholarshipProgramTracing>();
            ScholarshipProgramTracingTechnical = new HashSet<ScholarshipProgramTracing>();
            ScholarshipProgramUniversityAgent = new HashSet<ScholarshipProgramUniversityAgent>();
            ScholarshipProgramUniversityCoordinator = new HashSet<ScholarshipProgramUniversity>();
            ScholarshipProgramUniversityTechnical = new HashSet<ScholarshipProgramUniversity>();
        }

        public long AgentId { get; set; }
        public long AgentTypeId { get; set; }
        public long UserId { get; set; }
        public long ContactId { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual AgentType AgentType { get; set; }
        public virtual User CreationUser { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpgradeUser { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ScholarshipProgramTracing> ScholarshipProgramTracingCoordinator { get; set; }
        public virtual ICollection<ScholarshipProgramTracing> ScholarshipProgramTracingTechnical { get; set; }
        public virtual ICollection<ScholarshipProgramUniversityAgent> ScholarshipProgramUniversityAgent { get; set; }
        public virtual ICollection<ScholarshipProgramUniversity> ScholarshipProgramUniversityCoordinator { get; set; }
        public virtual ICollection<ScholarshipProgramUniversity> ScholarshipProgramUniversityTechnical { get; set; }
    }
}
