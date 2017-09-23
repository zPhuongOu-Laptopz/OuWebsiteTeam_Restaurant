using System;
using System.Collections.Generic;
using System.Linq;
using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;

namespace OuWebsiteTeam_RestaurantService.Models.Module {
    public class Foods : IFoods {
        private readonly RestaurantDBContext _context;

        public Foods (RestaurantDBContext context) {
            this._context = context;
        }

        public bool Create (PdbFood fo) {
            _context.PdbFoods.Add (fo);
            _context.Entry (fo).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges () == 1;
        }

        public bool Delete (Guid id) {
            PdbFood fo = _context.PdbFoods.SingleOrDefault (item => item.ID == id);
            _context.PdbFoods.DefaultIfEmpty (fo);
            _context.Entry (fo).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges () == 1;
        }

        public bool Edit (PdbFood fo) {
            _context.PdbFoods.Attach (fo);
            _context.Entry (fo).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges () == 1;;
        }

        public IEnumerable<PdbFood> GetAll () {
            return _context.PdbFoods;
        }

        public IEnumerable<PdbFood> GetForIndex () {
            return _context.PdbFoods.OrderBy(item=>item.ID).Take(6);
        }

        public PdbFood GetOne (Guid id) {
            return _context.PdbFoods.SingleOrDefault (item => item.ID == id);
        }

        public PdbFood GetOneBestSale(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}