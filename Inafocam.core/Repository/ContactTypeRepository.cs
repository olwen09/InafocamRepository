using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class ContactTypeRepository : IContactType
    {
        private readonly inafocam_tracingContext _context;

        public ContactTypeRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<ContactType> GetAll => _context.ContactType
            .Include(x => x.DocumentType)
            .Include(x => x.Status)
            .Include(x => x.Contact);
    }
}
