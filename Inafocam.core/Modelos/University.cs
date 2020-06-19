using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class University
    {
        public University()
        {
            ScholarshipProgramTracing = new HashSet<ScholarshipProgramTracing>();
            ScholarshipProgramUniversity = new HashSet<ScholarshipProgramUniversity>();
            UserUniversity = new HashSet<UserUniversity>();
        }

        public long UniversityId { get; set; }
        public string UniversityName { get; set; }
        public string UniversityAcronym { get; set; }
        public string UniversityCampus { get; set; }
        public long? AddressId { get; set; }
        public long? CommunicationId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Communication Communication { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<ScholarshipProgramTracing> ScholarshipProgramTracing { get; set; }
        public virtual ICollection<ScholarshipProgramUniversity> ScholarshipProgramUniversity { get; set; }
        public virtual ICollection<UserUniversity> UserUniversity { get; set; }
    }
}
