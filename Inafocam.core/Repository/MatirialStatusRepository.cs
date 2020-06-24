using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class MatirialStatusRepository : IMatirialStatus
    {
        private readonly inafocam_tracingContext _context;

        public MatirialStatusRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<MaritalStatus> GetAll => _context.MaritalStatus;
    }
}
