using Inafocam.core.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.ProgramasDeBecas.Modelos
{
    public class ScholarshipProgramModel
    {
        public long ScholarshipProgramId { get; set; }
        public string ScholarshipProgramName { get; set; }
        public long? ScholarshipLevelId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual ScholarshipLevel ScholarshipLevel { get; set; }
        public virtual Status Status { get; set; }
        public virtual ScholarshipProgramUniversity ScholarshipProgramUniversity { get; set; }
        public virtual ICollection<ScholarshipProgramUniversity> ScholarshipProgramUniversityList { get; set; }
    }
}
