using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class CountryRepository : ICountry
    {
        private readonly inafocam_tracingContext _context;

        public CountryRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<Country> GetAll => _context.Country
            .Include(x => x.Status)
            .Include(x => x.City)
            .Include(x => x.Province);
    }
}
