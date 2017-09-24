using System;
using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.DBContext;

namespace OuWebsiteTeam_RestaurantService.InterfaceEx.Module
{
    public interface ICombos
    {
        /// <summary>
        /// Interface for Combo
        /// </summary>
        /// <returns></returns>
        IEnumerable<PdbCombo> GetAll();
        bool Create(PdbCombo co);
        bool Edit(PdbCombo co);
        bool Delete(Guid id);
        PdbCombo GetOne(Guid id);
    }
}
