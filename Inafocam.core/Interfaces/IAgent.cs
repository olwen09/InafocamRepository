using Inafocam.core.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Interfaces
{
   public interface IAgent
    {
        IQueryable<Agent> Agents { get; }

        Agent GetById(int id);

        void Save(Agent model);

        //IEnumerable<Agent> GetCoordinators { get; }
        //IQueryable<Agent> GetTechnicals { get; }
    }
}
