using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class File
    {
        public File()
        {
            ScholarshipProgramTracingAgreementFile = new HashSet<ScholarshipProgramTracingAgreementFile>();
            ScholarshipProgramTracingCourseFile = new HashSet<ScholarshipProgramTracingCourseFile>();
            ScholarshipProgramTracingQualitySystem = new HashSet<ScholarshipProgramTracingQualitySystem>();
            TeacherFile = new HashSet<TeacherFile>();
        }

        public long FileId { get; set; }
        public long? FileTypeId { get; set; }
        public string FileName { get; set; }
        public string FileFullPath { get; set; }
        public string FilePath { get; set; }
        public string FileApplicationType { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual User CreationUser { get; set; }
        public virtual FileType FileType { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpgradeUser { get; set; }
        public virtual ICollection<ScholarshipProgramTracingAgreementFile> ScholarshipProgramTracingAgreementFile { get; set; }
        public virtual ICollection<ScholarshipProgramTracingCourseFile> ScholarshipProgramTracingCourseFile { get; set; }
        public virtual ICollection<ScholarshipProgramTracingQualitySystem> ScholarshipProgramTracingQualitySystem { get; set; }
        public virtual ICollection<TeacherFile> TeacherFile { get; set; }
    }
}
