using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class TeacherFileType
    {
        public TeacherFileType()
        {
            TeacherFile = new HashSet<TeacherFile>();
        }

        public long TeacherFileTypeId { get; set; }
        public string TeacherFileTypeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<TeacherFile> TeacherFile { get; set; }
    }
}
