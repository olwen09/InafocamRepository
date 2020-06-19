using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Address
    {
        public Address()
        {
            Company = new HashSet<Company>();
            ContactAddress = new HashSet<ContactAddress>();
            Office = new HashSet<Office>();
            University = new HashSet<University>();
        }

        public long AddressId { get; set; }
        public long? AddressTypeId { get; set; }
        public long? CountryId { get; set; }
        public long? ProvinceId { get; set; }
        public long? CityId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string HomeNumber { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual AddressType AddressType { get; set; }
        public virtual City City { get; set; }
        public virtual User CreationUser { get; set; }
        public virtual Province Province { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpgradeUser { get; set; }
        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<ContactAddress> ContactAddress { get; set; }
        public virtual ICollection<Office> Office { get; set; }
        public virtual ICollection<University> University { get; set; }
    }
}
