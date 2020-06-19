using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Company
    {
        public Company()
        {
            Office = new HashSet<Office>();
            User = new HashSet<User>();
        }

        public long CompanyId { get; set; }
        public long? ContactId { get; set; }
        public long? AddressId { get; set; }
        public long? CommunicationId { get; set; }
        public long? CompanyTypeId { get; set; }
        public long? ManagerId { get; set; }
        public long? OwnerId { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Communication Communication { get; set; }
        public virtual CompanyType CompanyType { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual User CreationUser { get; set; }
        public virtual User Manager { get; set; }
        public virtual User Owner { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpgradeUser { get; set; }
        public virtual ICollection<Office> Office { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
