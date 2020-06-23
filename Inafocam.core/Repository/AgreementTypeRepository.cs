using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
   public class AgreementTypeRepository : IAgreementType
    {
        private readonly inafocam_tracingContext _context;

        public AgreementTypeRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<AgreementType> GetAll => _context.AgreementType;
            //.Include(x => x.ScholarshipProgramUniversityAgreement);
    }
}
