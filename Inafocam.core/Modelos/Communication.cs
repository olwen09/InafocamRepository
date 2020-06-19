using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Communication
    {
        public Communication()
        {
            Company = new HashSet<Company>();
            ContactCommunication = new HashSet<ContactCommunication>();
            Office = new HashSet<Office>();
            University = new HashSet<University>();
        }

        public long CommunicationId { get; set; }
        public string CommunicationPhoneNumber1 { get; set; }
        public string CommunicationPhoneNumber2 { get; set; }
        public string CommunicationEmail { get; set; }
        public string CommunicationWebsite { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual User CreationUser { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpgradeUser { get; set; }
        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<ContactCommunication> ContactCommunication { get; set; }
        public virtual ICollection<Office> Office { get; set; }
        public virtual ICollection<University> University { get; set; }
    }
}
