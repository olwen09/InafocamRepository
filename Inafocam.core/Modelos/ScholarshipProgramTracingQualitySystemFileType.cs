using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgramTracingQualitySystemFileType
    {
        public long Id { get; set; }
        public string FileTypeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }
    }
}
