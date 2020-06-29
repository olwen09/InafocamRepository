using Inafocam.core.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Interfaces
{
  public  interface IAgentType
    {
        IQueryable<AgentType> GetAll { get; }

        //IQueryable<AgentType> GetCoordinators { get; }
        //IQueryable<AgentType> GetTechnicals { get; }

        AgentType GetById(int id);


        void Save(AgentType model);
    }
}
