using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class UserMapRole
    {
        public long UserMapRoleId { get; set; }
        public long? UserId { get; set; }
        public long? UserRoleId { get; set; }

        public virtual User User { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
