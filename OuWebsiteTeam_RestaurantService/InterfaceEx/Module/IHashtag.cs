using System;
using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.DBContext;

namespace OuWebsiteTeam_RestaurantService.InterfaceEx.Module
{
    public interface IHashtag
    {
        /// <summary>
        /// Interface for Hashtag
        /// </summary>
        /// <returns></returns>
        IEnumerable<PdbHashtag> GetAll();
        bool Create(PdbHashtag has);
        bool Edit(PdbHashtag has);
        bool Delete(Guid id);
        PdbHashtag GetOne(Guid id);
    }
}
