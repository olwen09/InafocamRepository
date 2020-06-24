using Inafocam.core.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Interfaces
{
   public interface ICountry
    {
        IQueryable<Country> GetAll { get; }
    }
}
