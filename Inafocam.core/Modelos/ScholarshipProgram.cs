using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgram
    {
        public ScholarshipProgram()
        {
            ScholarshipProgramUniversity = new HashSet<ScholarshipProgramUniversity>();
        }

        public long ScholarshipProgramId { get; set; }
        public string ScholarshipProgramName { get; set; }
        public long? ScholarshipLevelId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual ScholarshipLevel ScholarshipLevel { get; set; }
        public virtual Status Status { get; set; }




        /// <summary>
        /// This virtual property contains a list of objects type ScholarshipProgramUniversity
        /// </summary>
        public virtual ICollection<ScholarshipProgramUniversity> ScholarshipProgramUniversity { get; set; }
    }
}
