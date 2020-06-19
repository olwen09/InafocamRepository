using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgramTracingCourseFileType
    {
        public ScholarshipProgramTracingCourseFileType()
        {
            ScholarshipProgramTracingCourseFile = new HashSet<ScholarshipProgramTracingCourseFile>();
        }

        public long Id { get; set; }
        public string FileTypeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual ICollection<ScholarshipProgramTracingCourseFile> ScholarshipProgramTracingCourseFile { get; set; }
    }
}
