using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class AgentRepository : IAgent
    {
        private readonly inafocam_tracingContext _context;

        public AgentRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<Agent> Agents => _context.Agent
            .Include(x => x.Contact)
            .Include(x => x.AgentType)
            .Include(x => x.Status);
        //.Include(x => x.Contact.ContactCommunicatio);
        //.Include(x => x.Contact.ContactCommunication);
        //.Include(x => x.CreationUser)
        //.Include(x => x.UpgradeUser)
        //.Include(x => x.User)
        //.Include(x => x.ScholarshipProgramTracingCoordinator)
        //.Include(x => x.ScholarshipProgramTracingTechnical)
        //.Include(x => x.ScholarshipProgramUniversityAgent)
        //.Include(x => x.ScholarshipProgramUniversityCoordinator)
        //.Include(x => x.ScholarshipProgramUniversityTechnical);


        public Agent GetById(int id)
        {
            return Agents.FirstOrDefault(x => x.AgentId == id);
        }

        public void Save(Agent model)
        {
            if(model.AgentId != 0)
            {
                _context.Agent.Update(model);
            }
            else
            {
                _context.Add(model);
            }
        }
    }
}
