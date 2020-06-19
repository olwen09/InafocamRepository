using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class City
    {
        public City()
        {
            Address = new HashSet<Address>();
        }

        public long CityId { get; set; }
        public long? CountryId { get; set; }
        public long? ProvinceId { get; set; }
        public string CityName { get; set; }
        public string CityShortName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Country Country { get; set; }
        public virtual Province Province { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}
