using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Menu
    {
        public Menu()
        {
            InverseMenuParent = new HashSet<Menu>();
        }

        public long MenuId { get; set; }
        public long? MenuParentId { get; set; }
        public long? MenuTypeId { get; set; }
        public string MenuCaption { get; set; }
        public string MenuLink { get; set; }
        public string MenuIcon { get; set; }
        public int? MenuPosition { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Menu MenuParent { get; set; }
        public virtual MenuType MenuType { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Menu> InverseMenuParent { get; set; }
    }
}
