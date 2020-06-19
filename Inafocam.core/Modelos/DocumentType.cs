using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            Contact = new HashSet<Contact>();
            ContactType = new HashSet<ContactType>();
        }

        public long DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string DocumentTypePattern { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<ContactType> ContactType { get; set; }
    }
}
