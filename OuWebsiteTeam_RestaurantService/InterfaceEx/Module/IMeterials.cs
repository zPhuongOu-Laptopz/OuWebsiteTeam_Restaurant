using System;
using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.DBContext;

namespace OuWebsiteTeam_RestaurantService.InterfaceEx.Module
{
    public interface IMeterials
    {
        /// <summary>
        /// Interface for Meterials
        /// </summary>
        /// <returns></returns>
        IEnumerable<PdbMeterial> GetAll();
        bool Create(PdbMeterial met);
        bool Edit(PdbMeterial met);
        bool Delete(Guid id);
        PdbMeterial GetOne(Guid id);
    }
}
