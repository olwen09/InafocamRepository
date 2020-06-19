using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class UserRolePermission
    {
        public long UserRolePermissionId { get; set; }
        public long? UserRoleId { get; set; }
        public long? ObjectId { get; set; }
        public string UserRolePermissionName { get; set; }
        public string UserRolePermissionValue { get; set; }

        public virtual Object Object { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
