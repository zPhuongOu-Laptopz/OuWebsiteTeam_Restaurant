using System;
using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.DBContext;

namespace OuWebsiteTeam_RestaurantService.InterfaceEx.Module
{
    public interface IBanners
    {
        /// <summary>
        /// Interface for Banner
        /// </summary>
        /// <returns></returns>
        IEnumerable<PdbBanner> GetAll();
        bool Create(PdbBanner ban);
        bool Edit(PdbBanner ban);
        bool Delete(Guid id);
        PdbBanner GetOne(Guid id);
    }
}
