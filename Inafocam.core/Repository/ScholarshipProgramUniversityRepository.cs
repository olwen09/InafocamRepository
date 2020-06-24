using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
   public class ScholarshipProgramUniversityRepository : IScholarshipProgramUniversity
    {
        private readonly inafocam_tracingContext _context;

        public ScholarshipProgramUniversityRepository(inafocam_tracingContext context)
        {
            _context = context;
        }
        public IQueryable<ScholarshipProgramUniversity> ScholarshipProgramUniversity => _context.ScholarshipProgramUniversity
            .Include(x => x.Coordinator)
            .Include(x => x.ScholarshipLevel)
            .Include(x => x.ScholarshipProgram)
            .Include(x => x.Status)
            .Include(x => x.Technical)
            .Include(x => x.Technical.AgentType)
            .Include(x => x.University)
            .Include(x => x.ScholarshipProgramTracing)
            .Include(x => x.ScholarshipProgramUniversityAgent)
            .Include(x => x.ScholarshipProgramUniversityAgreement)
            .Include(x => x.ScholarshipProgramUniversitySubjectMatter);

        public ScholarshipProgramUniversity GetById(int id)
        {
            return _context.ScholarshipProgramUniversity.Include(x => x.Coordinator)
            .Include(x => x.ScholarshipLevel)
            .Include(x => x.ScholarshipProgram)
            .Include(x => x.Status)
            .Include(x => x.Technical)
            .Include(x => x.Technical.Contact)
            .Include(x => x.Coordinator)
            .Include(x => x.Coordinator.Contact)
            .Include(x => x.University)
            .Include(x => x.ScholarshipProgramTracing)
            .Include(x => x.ScholarshipProgramUniversityAgent)
            .Include(x => x.ScholarshipProgramUniversityAgreement)
            .Include(x => x.ScholarshipProgramUniversitySubjectMatter).FirstOrDefault(x=> x.ScholarshipProgramUniversityId == id);
        }

        public void Save(ScholarshipProgramUniversity model)
        {
            if(model.ScholarshipProgramUniversityId != 0)
            {
                _context.Add(model);
            
            }
            else
            {
                _context.ScholarshipProgramUniversity.Update(model);
            }

            _context.SaveChanges();
        }
    }
}
