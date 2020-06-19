using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class MenuType
    {
        public MenuType()
        {
            Menu = new HashSet<Menu>();
        }

        public long MenuTypeId { get; set; }
        public string MenuTypeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
    }
}
