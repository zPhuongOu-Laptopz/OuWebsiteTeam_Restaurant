using OuWebsiteTeam_RestaurantService.DBContext;
using System;
using System.Collections.Generic;

namespace OuWebsiteTeam_RestaurantService.InterfaceEx.Module
{
    public interface IFoods
    {
        /// <summary>
        /// Interface for Category
        /// </summary>
        /// <returns></returns>
        IEnumerable<PdbFood> GetAll();
        bool Create(PdbFood cate);
        bool Edit(PdbFood cate);
        bool Delete(Guid id);
        PdbFood GetOne(Guid id);

        IEnumerable<PdbFood> GetForIndex();

        PdbFood GetOneBestSale(Guid id);
        IEnumerable<PdbFood> GetFourFoodForBreakfast();

        IEnumerable<PdbFood> GetFourFoodForDrink();

        IEnumerable<PdbFood> GetFourFoodForLunch();

        IEnumerable<PdbFood> GetFourFoodForDinner();

        IEnumerable<PdbFood> GetFourFoodForCake();
    }
}
