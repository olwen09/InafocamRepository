using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ContactAddress
    {
        public long ContactAddressId { get; set; }
        public long? ContactId { get; set; }
        public long? AddressId { get; set; }
        public string ContactAddressComment { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Status Status { get; set; }
    }
}
