using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class AgreementType
    {
        public AgreementType()
        {
            ScholarshipProgramUniversityAgreement = new HashSet<ScholarshipProgramUniversityAgreement>();
        }

        public long AgreementTypeId { get; set; }
        public string AgreementTypeName { get; set; }
        public string AgreementPanelClass { get; set; }

        public virtual ICollection<ScholarshipProgramUniversityAgreement> ScholarshipProgramUniversityAgreement { get; set; }
    }
}
