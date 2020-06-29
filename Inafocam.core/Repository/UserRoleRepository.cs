using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class UserRoleRepository : IUserRole
    {
        private readonly inafocam_tracingContext _context;

        public UserRoleRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<UserRole> GetAll => _context.UserRole
            .Include(x => x.User)
            .Include(x => x.Office)
            .Include(x => x.UpgradeUser)
            .Include(x => x.User)
            .Include(x => x.UserMapRole)
            .Include(x => x.UserRolePermission);
    }
}
