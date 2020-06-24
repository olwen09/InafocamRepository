using Inafocam.core.Modelos;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Interfaces
{
   public interface ITeacher
    {
        IQueryable<Teacher> GetAll { get; }

        Teacher GetById(int id);

        void Save(Teacher model);
    }
}
