using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class TeacherEducationRepository : ITeacherEducation
    {
        private readonly inafocam_tracingContext _context;

        public TeacherEducationRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<TeacherEducation> GetAll => _context.TeacherEducation
            .Include(x => x.EducationType)
            .Include(x => x.Status)
            .Include(x => x.TeacherNavigation)
            .Include(x => x.Teacher)
            .Include(x => x.TracingStudyPlanDevelopment);
    }
}
