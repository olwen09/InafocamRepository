using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class TeacherHiringType
    {
        public TeacherHiringType()
        {
            Teacher = new HashSet<Teacher>();
        }

        public long TeacherHiringTypeId { get; set; }
        public string TeacherHiringTypeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
