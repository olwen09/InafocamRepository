using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class AgentType
    {
        public AgentType()
        {
            Agent = new HashSet<Agent>();
        }

        public long AgentTypeId { get; set; }
        public string AgentTypeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<Agent> Agent { get; set; }
    }
}
