using System;
using System.Collections.Generic;
using System.Linq;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using OuWebsiteTeam_RestaurantService.DBContext;

namespace OuWebsiteTeam_RestaurantService.Models.Module
{
    public class Userlogins : IUserlogins
    {
        public bool Create(PdbUser us)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(PdbUser us)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PdbUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public PdbUser GetOne(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
