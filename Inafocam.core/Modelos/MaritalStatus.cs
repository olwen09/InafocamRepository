using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class MaritalStatus
    {
        public long MaritalStatusId { get; set; }
        public string MaritalStatusName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }
    }
}
