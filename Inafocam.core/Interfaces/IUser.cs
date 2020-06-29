using Inafocam.core.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Interfaces
{
   public  interface IUser
    {
       IQueryable<User> GetAll { get; }

        User GetByID(int id);

        void Save(User model);
    }
}
