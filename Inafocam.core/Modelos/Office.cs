using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Office
    {
        public Office()
        {
            User = new HashSet<User>();
            UserRole = new HashSet<UserRole>();
        }

        public long OfficeId { get; set; }
        public long? CompanyId { get; set; }
        public string OfficeName { get; set; }
        public long? AddressId { get; set; }
        public long? CommunicationId { get; set; }
        public long? ManagerId { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Communication Communication { get; set; }
        public virtual Company Company { get; set; }
        public virtual User CreationUser { get; set; }
        public virtual User Manager { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpgradeUser { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
