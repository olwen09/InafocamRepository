using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class DocumentTypeRepository : IDocumentType
    {
        private readonly inafocam_tracingContext _context;

        public DocumentTypeRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<DocumentType> GetAll => _context.DocumentType
            .Include(x => x.Status)
            .Include(x => x.Contact)
            .Include(x => x.ContactType);
    }
}
