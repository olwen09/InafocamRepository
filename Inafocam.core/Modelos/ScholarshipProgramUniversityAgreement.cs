using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgramUniversityAgreement
    {
        public ScholarshipProgramUniversityAgreement()
        {
            ScholarshipProgramTracingAgreement = new HashSet<ScholarshipProgramTracingAgreement>();
        }

        public long ScholarshipProgramUniversityAgreementId { get; set; }
        public long? ScholarshipProgramUniversityId { get; set; }
        public string ScholarshipProgramUniversityAgreement1 { get; set; }
        public long? AgreementTypeId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public long? StatusId { get; set; }

        public virtual AgreementType AgreementType { get; set; }
        public virtual User CreationUser { get; set; }
        public virtual ScholarshipProgramUniversity ScholarshipProgramUniversity { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpgradeUser { get; set; }
        public virtual ICollection<ScholarshipProgramTracingAgreement> ScholarshipProgramTracingAgreement { get; set; }
    }
}
