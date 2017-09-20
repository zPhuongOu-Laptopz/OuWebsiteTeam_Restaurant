using OuWebsiteTeam_RestaurantService.DBContext;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;

namespace OuWebsiteTeam_RestaurantService.InterfaceEx.Module
{
    public interface ICategories
    {
        /// <summary>
        /// Interface for Category
        /// </summary>
        /// <returns></returns>
        IEnumerable<PdbCategory> GetAll();
        bool Create(PdbCategory cate);
        bool Edit(PdbCategory cate);
        bool Delete(Guid ID);
        PdbCategory GetOne(Guid ID);
    }
}
