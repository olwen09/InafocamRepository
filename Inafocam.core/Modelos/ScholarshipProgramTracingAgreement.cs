using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgramTracingAgreement
    {
        public long ScholarshipProgramTracingAgreementId { get; set; }
        public long? ScholarshipProgramTracingId { get; set; }
        public long? ScholarshipProgramUniversityAgreementId { get; set; }
        public string ScholarshipProgramTracingAgreementDescription { get; set; }
        public string ScholarshipProgramTracingAgreementDescription2 { get; set; }
        public string ScholarshipProgramTracingAgreementDescription3 { get; set; }
        public long? CommentedUserId { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual User CommentedUser { get; set; }
        public virtual User CreationUser { get; set; }
        public virtual ScholarshipProgramTracing ScholarshipProgramTracing { get; set; }
        public virtual ScholarshipProgramUniversityAgreement ScholarshipProgramUniversityAgreement { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpgradeUser { get; set; }
    }
}
