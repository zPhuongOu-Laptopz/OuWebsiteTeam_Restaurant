using System;
using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.DBContext;
namespace OuWebsiteTeam_RestaurantService.InterfaceEx.Module
{
    public interface IUserlogins
    {
        /// <summary>
        /// Interface for Userlogin
        /// </summary>
        /// <returns></returns>
        IEnumerable<PdbUser> GetAll();
        bool Create(PdbUser us);
        bool Edit(PdbUser us);
        bool Delete(Guid id);
        PdbUser GetOne(Guid id);
    }
}
