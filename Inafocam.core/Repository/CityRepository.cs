using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class CityRepository : ICity
    {
        private readonly inafocam_tracingContext _context;

        public CityRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<City> Cities => _context.City
            .Include(x => x.Country)
            .Include(x => x.Province)
            .Include(x => x.Status)
            .Include(x => x.Address);
    }
}
