using OuWebsiteTeam_RestaurantService.DBContext;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;


namespace OuWebsiteTeam_RestaurantService.InterfaceEx.Module
{
    public interface IRestaurantInfo
    {
        /// <summary>
        /// Interface for RestaurantInfo
        /// </summary>
        /// <returns></returns>
        IEnumerable<PdbRestaurant> GetAll();
        bool Create(PdbRestaurant res);
        bool Edit(PdbRestaurant res);
        bool Delete(Guid id);
        PdbRestaurant GetOne(Guid id);
    }
}
