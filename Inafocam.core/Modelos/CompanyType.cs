using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class CompanyType
    {
        public CompanyType()
        {
            Company = new HashSet<Company>();
        }

        public long CompanyTypeId { get; set; }
        public string CompanyTypeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<Company> Company { get; set; }
    }
}
