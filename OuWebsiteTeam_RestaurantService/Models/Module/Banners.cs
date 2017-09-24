using System;
using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;

namespace OuWebsiteTeam_RestaurantService.Models.Module
{
    public class Banners : IBanners
    {
        private readonly RestaurantDBContext _context;

        public Banners(RestaurantDBContext context)
        {
            this._context = context;
        }

        public bool Create(PdbBanner ban)
        {
            _context.PdbBanners.Add(ban);
            _context.Entry(ban).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(PdbBanner ban)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PdbBanner> GetAll()
        {
            throw new NotImplementedException();
        }

        public PdbBanner GetOne(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
