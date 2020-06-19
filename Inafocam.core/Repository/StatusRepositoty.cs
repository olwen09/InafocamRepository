using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class StatusRepositoty : IStatus
    {
        private readonly inafocam_tracingContext _context;

        public StatusRepositoty(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<Status> Status => _context.Status;
    }
}
