using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class SubjectMatterRepository : ISubjectMatter
    {
        private readonly inafocam_tracingContext _context;

        public SubjectMatterRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<SubjectMatter> GetAll => _context.SubjectMatter
            .Include(x => x.CreationUser)
            .Include(x => x.Status)
            .Include(x => x.UpgradeUser)
            .Include(x => x.ScholarshipProgramUniversitySubjectMatter)
            .Include(x => x.TracingStudyPlanDevelopment);

        public SubjectMatter GetById(int id)
        {
            return GetAll.FirstOrDefault(x => x.SubjectMatterId == id);
        }

        public void Save(SubjectMatter model)
        {
           if(model.SubjectMatterId != 0)
            {
                _context.SubjectMatter.Update(model);
            }
            else
            {
                _context.Add(model);
            }

            _context.SaveChanges();
        }
    }
}
