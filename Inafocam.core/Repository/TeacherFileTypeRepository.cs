using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class TeacherFileTypeRepository : ITeacherFileType
    {
        private readonly inafocam_tracingContext _context;

        public TeacherFileTypeRepository(inafocam_tracingContext context)
        {
            _context = context;
        }
        public IQueryable<TeacherFileType> GetAll => _context.TeacherFileType
            .Include(x => x.Status)
            .Include(x => x.TeacherFile);
    }
}
