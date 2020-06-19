using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ContactCommunication
    {
        public long ContactCommunicationId { get; set; }
        public long? ContactId { get; set; }
        public long? CommunicationId { get; set; }
        public string ContactCommunicationComment { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Communication Communication { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Status Status { get; set; }
    }
}
