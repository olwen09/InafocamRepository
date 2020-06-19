using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
            Province = new HashSet<Province>();
        }

        public long CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryShortName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<Province> Province { get; set; }
    }
}
