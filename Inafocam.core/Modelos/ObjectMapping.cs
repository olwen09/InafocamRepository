using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ObjectMapping
    {
        public long ObjectMappingId { get; set; }
        public long? ObjectId { get; set; }
        public string ObjectMappingName { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Object Object { get; set; }
        public virtual Status Status { get; set; }
    }
}
