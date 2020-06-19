using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Object
    {
        public Object()
        {
            ObjectMapping = new HashSet<ObjectMapping>();
            UserRolePermission = new HashSet<UserRolePermission>();
        }

        public long ObjectId { get; set; }
        public string ObjectName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<ObjectMapping> ObjectMapping { get; set; }
        public virtual ICollection<UserRolePermission> UserRolePermission { get; set; }
    }
}
