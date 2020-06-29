using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
  public  class ScholarshipProgramTracingRepository : IScholarshipProgramTracing
    {

        private readonly inafocam_tracingContext _context;

        public ScholarshipProgramTracingRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<ScholarshipProgramTracing> ScholarshipProgramTracing => _context.ScholarshipProgramTracing
            .Include(x => x.Coordinator)
            .Include(x => x.Coordinator.Contact)
            .Include(x => x.ScholarshipProgramUniversity)
            .Include(x => x.ScholarshipProgramUniversity.ScholarshipProgram)
            .Include(x => x.Status)
            .Include(x => x.Technical.Contact)
            .Include(x => x.University)
            .Include(x => x.UpgradeUser)
            .Include(x => x.ScholarshipProgramTracingAgreement)
            .Include(x => x.ScholarshipProgramTracingCourse)
            .Include(x => x.ScholarshipProgramTracingCourseFile)
            .Include(x => x.ScholarshipProgramTracingPractice)
            .Include(x => x.ScholarshipProgramTracingPracticePlanning)
            .Include(x => x.ScholarshipProgramTracingQualitySystem)
            .Include(x => x.ScholarshipProgramTracingStudentPractice)
            .Include(x => x.ScholarshipProgramTracingStudentSupport);

        public ScholarshipProgramTracing GetById(int id)
        {
            return ScholarshipProgramTracing.FirstOrDefault(x => x.ScholarshipProgramTracingId == id);
        }
    }
}
