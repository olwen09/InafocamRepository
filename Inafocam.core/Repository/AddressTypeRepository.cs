using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
   public class AddressTypeRepository : IAddressType
    {
        private readonly inafocam_tracingContext _context;

        public AddressTypeRepository(inafocam_tracingContext context)
        {
            _context = context;
        }
        public IQueryable<AddressType> addressTypes => _context.AddressType
            .Include(x=> x.Address)
            .Include(x => x.Status);
    }
}
