using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class TeacherFile
    {
        public long TeacherFileId { get; set; }
        public long TeacherId { get; set; }
        public long? TeacherResearchId { get; set; }
        public long? FileId { get; set; }
        public long? TeacherFileTypeId { get; set; }
        public string TeacherFileComment { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual File File { get; set; }
        public virtual Status Status { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual TeacherFileType TeacherFileType { get; set; }
        public virtual TeacherResearch TeacherResearch { get; set; }
    }
}
