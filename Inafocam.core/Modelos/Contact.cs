using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Contact
    {
        public Contact()
        {
            Company = new HashSet<Company>();
            ContactAddress = new HashSet<ContactAddress>();
            ContactCommunication = new HashSet<ContactCommunication>();
            Teacher = new HashSet<Teacher>();
            User = new HashSet<User>();
        }

        public long ContactId { get; set; }
        public long? DocumentTypeId { get; set; }
        public string ContactDocumentNumber { get; set; }
        public string ContactName { get; set; }
        public string ContactLastname { get; set; }
        public string ContactGender { get; set; }
        public long? ContactTypeId { get; set; }
        public string ContactComment { get; set; }
        public DateTime? ContactBornDate { get; set; }
        public string ContactBornPlace { get; set; }
        public long? ContactNationalityId { get; set; }
        public long? ContactMaritalStatusId { get; set; }
        public long? ContactJobInformationId { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual ContactType ContactType { get; set; }
        public virtual User CreationUser { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpgradeUser { get; set; }
        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<ContactAddress> ContactAddress { get; set; }
        public virtual ICollection<ContactCommunication> ContactCommunication { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
