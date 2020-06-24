using Inafocam.core.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Interfaces
{
   public interface IScholarshipProgramUniversity
    {
        IQueryable<ScholarshipProgramUniversity> ScholarshipProgramUniversity { get; }

        ScholarshipProgramUniversity GetById(int id);

        void Save(ScholarshipProgramUniversity model);
    }
}
