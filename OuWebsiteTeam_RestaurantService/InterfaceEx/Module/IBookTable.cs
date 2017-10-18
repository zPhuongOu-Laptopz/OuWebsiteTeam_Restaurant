using System;
using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.DBContext;

namespace OuWebsiteTeam_RestaurantService.InterfaceEx.Module
{
    public interface IBookTable
    {
        /// <summary>
        /// Interface for Banner
        /// </summary>
        /// <returns></returns>
        IEnumerable<PdbBookTable> GetAll();
        bool Create(PdbBookTable ban);
        bool Edit(PdbBookTable ban);
        bool Delete(Guid id);
        PdbBookTable GetOne(Guid id);
    }
}
