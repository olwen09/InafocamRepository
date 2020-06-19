using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class StudyPlanManagement
    {
        public long StudyPlanManagementId { get; set; }
        public long? ScholarshipProgramUniversityId { get; set; }
        public string StudyPlanManagementName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }
    }
}
