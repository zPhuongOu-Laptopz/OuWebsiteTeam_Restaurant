using System;
using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;

namespace OuWebsiteTeam_RestaurantService.InterfaceEx.Module
{
    public interface IFeedbacks
    {
        /// <summary>
        /// Interface for Feedback
        /// </summary>
        /// <returns></returns>
        IEnumerable<PdbFeedback> GetAll();
        bool Create(PdbFeedback fe);
        bool Edit(PdbFeedback fe);
        bool Delete(Guid id);
        PdbFeedback GetOne(Guid id);
    }
}
