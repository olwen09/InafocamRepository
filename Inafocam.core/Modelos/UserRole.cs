using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class UserRole
    {
        public UserRole()
        {
            User = new HashSet<User>();
            UserMapRole = new HashSet<UserMapRole>();
            UserRolePermission = new HashSet<UserRolePermission>();
        }

        public long UserRoleId { get; set; }
        public long OfficeId { get; set; }
        public string UserRoleName { get; set; }
        public string UserRoleDescription { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual User CreationUser { get; set; }
        public virtual Office Office { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpgradeUser { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserMapRole> UserMapRole { get; set; }
        public virtual ICollection<UserRolePermission> UserRolePermission { get; set; }
    }
}
