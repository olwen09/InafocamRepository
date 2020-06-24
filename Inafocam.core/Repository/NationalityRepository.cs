using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class NationalityRepository : INationality
    {
        private readonly inafocam_tracingContext _context;

        public NationalityRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<Nationality> GetAll => _context.Nationality
            .Include(x => x.Status);
            
    }
}
