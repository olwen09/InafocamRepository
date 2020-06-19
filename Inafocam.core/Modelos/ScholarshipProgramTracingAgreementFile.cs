using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgramTracingAgreementFile
    {
        public long ScholarshipProgramTracingAgreementFileId { get; set; }
        public long ScholarshipProgramTracingAgreementId { get; set; }
        public string AgreementFileDescription { get; set; }
        public long? FileId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual File File { get; set; }
        public virtual Status Status { get; set; }
    }
}
