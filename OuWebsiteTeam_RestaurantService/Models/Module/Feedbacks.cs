using System;
using System.Collections.Generic;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using OuWebsiteTeam_RestaurantService.DBContext;
using System.Linq;

namespace OuWebsiteTeam_RestaurantService.Models.Module
{
    public class Feedbacks : IFeedbacks
    {
        private readonly RestaurantDBContext _context;

        public Feedbacks(RestaurantDBContext context)
        {
            this._context = context;
        }

        public bool Create(PdbFeedback fe)
        {
            fe.ID = Guid.NewGuid();
            this._context.PdbFeedbacks.Add(fe);
            this._context.Entry(fe).State = System.Data.Entity.EntityState.Added;
            return this._context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(PdbFeedback fe)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PdbFeedback> GetAll()
        {
            return this._context.PdbFeedbacks;
        }

        public PdbFeedback GetOne(Guid id)
        {
            return _context.PdbFeedbacks.SingleOrDefault(item => item.ID == id);
        }
    }
}
