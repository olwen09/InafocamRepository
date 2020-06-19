using Inafocam.core.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Interfaces
{
   public interface IScholarshipLevel
    {
        IQueryable<ScholarshipLevel> ScholarshipsLevel { get; }
    }
}
