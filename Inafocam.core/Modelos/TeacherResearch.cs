using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class TeacherResearch
    {
        public TeacherResearch()
        {
            TeacherFile = new HashSet<TeacherFile>();
        }

        public long TeacherResearchId { get; set; }
        public long TeacherId { get; set; }
        public string TeacherResearchName { get; set; }
        public int? TeacherResearchQuantity { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<TeacherFile> TeacherFile { get; set; }
    }
}
