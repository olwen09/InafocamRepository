using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Nationality
    {
        public long NationalityId { get; set; }
        public string NationalityName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }
        public virtual Status Status { get; set; }
    }
}
