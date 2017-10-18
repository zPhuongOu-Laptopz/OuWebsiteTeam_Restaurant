using System;
using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using System.Linq;

namespace OuWebsiteTeam_RestaurantService.Models.Module
{
    public class BookTable : IBookTable
    {
        private readonly RestaurantDBContext _context;

        public BookTable(RestaurantDBContext context)
        {
            this._context = context;
        }

        public bool Create(PdbBookTable ban)
        {
            _context.PdbBookTables.Add(ban);
            _context.Entry(ban).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            PdbBookTable itemc = _context.PdbBookTables.SingleOrDefault(item => item.ID == id);
            _context.PdbBookTables.DefaultIfEmpty(itemc);
            _context.Entry(itemc).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges() == 1;
        }

        public bool Edit(PdbBookTable met)
        {
            _context.PdbBookTables.Attach(met);
            _context.Entry(met).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() == 1; ;
        }

        public IEnumerable<PdbBookTable> GetAll()
        {
            return this._context.PdbBookTables;
        }

        public PdbBookTable GetOne(Guid id)
        {
            return _context.PdbBookTables.SingleOrDefault(item => item.ID == id);
        }
    }
}
