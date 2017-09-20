using System;
using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using System.Linq;

namespace OuWebsiteTeam_RestaurantService.Models.Module
{
    public class RestaurantInfo : IRestaurantInfo
    {
        private readonly RestaurantDBContext _context;

        public RestaurantInfo(RestaurantDBContext context)
        {
            this._context = context;
        }

        public bool Create(PdbRestaurant res)
        {
            _context.PdbRestaurants.Add(res);
            _context.Entry(res).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            PdbRestaurant res = _context.PdbRestaurants.SingleOrDefault(res1 => res1.ID == id);
            _context.PdbRestaurants.DefaultIfEmpty(res);
            _context.Entry(res).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges() == 1;
        }

        public bool Edit(PdbRestaurant res)
        {
            _context.PdbRestaurants.Attach(res);
            _context.Entry(res).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() == 1;
        }

        public IEnumerable<PdbRestaurant> GetAll()
        {
            return _context.PdbRestaurants;
        }

        public PdbRestaurant GetOne(Guid id)
        {
            return _context.PdbRestaurants.SingleOrDefault(res => res.ID == id);
        }
    }
}
