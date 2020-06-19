using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgramUniversityTeacherHiring
    {
        public long ScholarshipProgramUniversityTeacherHiringId { get; set; }
        public long? TeacherHiringTypeId { get; set; }
        public long? TeacherId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }
    }
}
