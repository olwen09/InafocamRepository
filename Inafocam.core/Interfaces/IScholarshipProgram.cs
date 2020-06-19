using Inafocam.core.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Interfaces
{
   public interface IScholarshipProgram
    {
        IQueryable<ScholarshipProgram> GetAll { get; }

        ScholarshipProgram GetById(int? id);

        void GuardarScholarshipProgram(ScholarshipProgram model);
    }
}
