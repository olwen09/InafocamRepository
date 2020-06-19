using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ContactType
    {
        public ContactType()
        {
            Contact = new HashSet<Contact>();
        }

        public long ContactTypeId { get; set; }
        public string ContactTypeName { get; set; }
        public long? DocumentTypeId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual DocumentType DocumentType { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
    }
}
