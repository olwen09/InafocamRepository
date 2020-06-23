using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class ProvinceRepository : IProvince
    {
        private readonly inafocam_tracingContext _context;

        public ProvinceRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<Province> Provinces => _context.Province
            .Include(x => x.Country)
            .Include(x => x.Status)
            .Include(x => x.Address)
            .Include(x => x.City);
    }
}
