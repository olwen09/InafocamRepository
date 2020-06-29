using Inafocam.core.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.Seguimientos.Models
{
    public class ScholarshipProgramTracingModel
    {
        public long ScholarshipProgramTracingId { get; set; }
        public long? UniversityId { get; set; }
        public long? ScholarshipProgramUniversityId { get; set; }
        public long? CoordinatorId { get; set; }
        public long? TechnicalId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Agent Coordinator { get; set; }
        public virtual User CreationUser { get; set; }
        public virtual ScholarshipProgramUniversity ScholarshipProgramUniversity { get; set; }
        public virtual Status Status { get; set; }
        public virtual Agent Technical { get; set; }
        public virtual University University { get; set; }
        public virtual User UpgradeUser { get; set; }
        public virtual ICollection<ScholarshipProgramTracingAgreement> ScholarshipProgramTracingAgreement { get; set; }
        public virtual ICollection<ScholarshipProgramTracingCourse> ScholarshipProgramTracingCourse { get; set; }
        public virtual ICollection<ScholarshipProgramTracingCourseFile> ScholarshipProgramTracingCourseFile { get; set; }
        public virtual ICollection<ScholarshipProgramTracingPractice> ScholarshipProgramTracingPractice { get; set; }
        public virtual ICollection<ScholarshipProgramTracingPracticePlanning> ScholarshipProgramTracingPracticePlanning { get; set; }
        public virtual ICollection<ScholarshipProgramTracingQualitySystem> ScholarshipProgramTracingQualitySystem { get; set; }
        public virtual ICollection<ScholarshipProgramTracingStudentPractice> ScholarshipProgramTracingStudentPractice { get; set; }
        public virtual ICollection<ScholarshipProgramTracingStudentSupport> ScholarshipProgramTracingStudentSupport { get; set; }
        public virtual ICollection<TracingStudyPlanDevelopment> TracingStudyPlanDevelopment { get; set; }
    }
}
