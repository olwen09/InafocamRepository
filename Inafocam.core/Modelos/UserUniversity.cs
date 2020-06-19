using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class UserUniversity
    {
        public long UserUniversityId { get; set; }
        public long? UserId { get; set; }
        public long? UniversityId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? UserCreationId { get; set; }
        public long? UserUpgradeId { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual University University { get; set; }
        public virtual User User { get; set; }
    }
}
