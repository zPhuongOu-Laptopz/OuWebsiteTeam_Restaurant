using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using OuWebsiteTeam_RestaurantService.DBContext;
using System;

namespace OuWebsiteTeam_RestaurantService.Models.Module
{
    public class Hashtags : IHashtag
    {
        public bool Create(PdbHashtag has)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(PdbHashtag has)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PdbHashtag> GetAll()
        {
            throw new NotImplementedException();
        }

        public PdbHashtag GetOne(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
