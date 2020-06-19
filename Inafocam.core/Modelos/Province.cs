using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Province
    {
        public Province()
        {
            Address = new HashSet<Address>();
            City = new HashSet<City>();
        }

        public long ProvinceId { get; set; }
        public long? CountryId { get; set; }
        public string ProvinceName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Country Country { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<City> City { get; set; }
    }
}
