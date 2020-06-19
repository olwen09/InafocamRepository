using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipLevel
    {
        public ScholarshipLevel()
        {
            ScholarshipProgram = new HashSet<ScholarshipProgram>();
            ScholarshipProgramUniversity = new HashSet<ScholarshipProgramUniversity>();
        }

        public long ScholarshipLevelId { get; set; }
        public string ScholarshipLevelName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<ScholarshipProgram> ScholarshipProgram { get; set; }
        public virtual ICollection<ScholarshipProgramUniversity> ScholarshipProgramUniversity { get; set; }
    }
}
