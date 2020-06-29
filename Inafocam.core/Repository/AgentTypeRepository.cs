using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class AgentTypeRepository : IAgentType
    {
        private readonly inafocam_tracingContext _context;

        public AgentTypeRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<AgentType> GetAll => _context.AgentType
            .Include(x => x.Status)
            .Include(x => x.Agent);

        //public IQueryable<AgentType> GetCoordinators => _context.AgentType
        //    .Include(x => x.Status)
        //    .Include(x => x.Agent)
        //    .Where(x => x.AgentTypeId == 1);

        //public IQueryable<AgentType> GetTechnicals => _context.AgentType
        //    .Include(x => x.Status)
        //    .Include(x => x.Agent)
        //    .Where(x => x.AgentTypeId == 2);

        public AgentType GetById(int id)
        {
            return GetAll.FirstOrDefault(x => x.AgentTypeId == id);
        }

        public void Save(AgentType model)
        {
            if(model.AgentTypeId != 0)
            {
                _context.AgentType.Update(model);
            }
            else
            {
                _context.Add(model);
            }

            _context.SaveChanges();
        }
    }
}
