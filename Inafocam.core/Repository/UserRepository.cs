using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class UserRepository : IUser
    {
        private readonly inafocam_tracingContext _cotext;

        public UserRepository(inafocam_tracingContext context)
        {
            _cotext = context;
        }

        public IQueryable<User> GetAll => _cotext.User
            .Include(x => x.Company)
            .Include(x => x.Contact)
            .Include(x => x.CreationUser)
            .Include(x => x.Office)
            .Include(x => x.Status)
            .Include(x => x.UpgradeUser)
            .Include(x => x.UserRole)
            .Include(x => x.UserSchedule)
            .Include(x => x.AddressCreationUser)
            .Include(x => x.AddressUpgradeUser)
            .Include(x => x.AgentCreationUser)
            .Include(x => x.AgentUpgradeUser)
            .Include(x => x.AgentUser)
            .Include(x => x.CommunicationCreationUser)
            .Include(x => x.CommunicationUpgradeUser)
            .Include(x => x.CompanyCreationUser)
            .Include(x => x.CompanyManager)
            .Include(x => x.CompanyOwner)
            .Include(x => x.CompanyUpgradeUser);


        public User GetByID(int id)
        {
            return GetAll.FirstOrDefault(x => x.UserId == id);
        }

        public void Save(User model)
        {
            if(model.UserId != 0)
            {
                _cotext.User.Update(model);
            }
            else
            {
                _cotext.Add(model);
            }

            _cotext.SaveChanges();
        
        }
    }
}
