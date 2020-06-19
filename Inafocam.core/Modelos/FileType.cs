using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class FileType
    {
        public FileType()
        {
            File = new HashSet<File>();
        }

        public long FileTypeId { get; set; }
        public string FileTypeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<File> File { get; set; }
    }
}
