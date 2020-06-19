using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class EducationType
    {
        public EducationType()
        {
            TeacherEducation = new HashSet<TeacherEducation>();
        }

        public long EducationTypeId { get; set; }
        public string EducationTypeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<TeacherEducation> TeacherEducation { get; set; }
    }
}
