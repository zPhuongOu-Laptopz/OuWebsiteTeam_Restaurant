using System;
using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using System.Linq;

namespace OuWebsiteTeam_RestaurantService.Models.Module
{
    public class Categories : ICategories
    {
        private readonly RestaurantDBContext _context;

        public Categories(RestaurantDBContext context)
        {
            this._context = context;
        }
      
        public bool Create(PdbCategory cate)
        {
            _context.PdbCategories.Add(cate);
            _context.Entry(cate).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            PdbCategory cate = _context.PdbCategories.SingleOrDefault(cate1 => cate1.ID == id);
            _context.PdbCategories.DefaultIfEmpty(cate);
            _context.Entry(cate).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges() == 1;
        }

        public bool Edit(PdbCategory cate)
        {
            _context.PdbCategories.Attach(cate);
            _context.Entry(cate).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() == 1;
        }

        public IEnumerable<PdbCategory> GetAll()
        {
            return _context.PdbCategories;
        }

        public PdbCategory GetOne(Guid id)
        {
            return _context.PdbCategories.SingleOrDefault(cate => cate.ID == id);
        }
    }
}
