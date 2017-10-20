namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantDBContext : DbContext
    {
        public RestaurantDBContext()
            : base("name=RestaurantDBContext")
        {
        }

        public virtual DbSet<PdbBanner> PdbBanners { get; set; }
        public virtual DbSet<PdbBookTable> PdbBookTables { get; set; }
        public virtual DbSet<PdbFeedback> PdbFeedbacks { get; set; }
        public virtual DbSet<PdbFood> PdbFoods { get; set; }
        public virtual DbSet<PdbRestaurant> PdbRestaurants { get; set; }
        public virtual DbSet<PdbUser> PdbUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PdbFeedback>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<PdbFood>()
                .Property(e => e.PriceBigSize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PdbFood>()
                .Property(e => e.PriceSmallSize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PdbFood>()
                .Property(e => e.PriceDiscountForBigSize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PdbFood>()
                .Property(e => e.PriceDiscountForSmallSize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PdbRestaurant>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<PdbRestaurant>()
                .Property(e => e.Fax)
                .IsFixedLength();

            modelBuilder.Entity<PdbRestaurant>()
                .Property(e => e.TimeOpen)
                .IsFixedLength();

            modelBuilder.Entity<PdbRestaurant>()
                .Property(e => e.TimeClose)
                .IsFixedLength();

            modelBuilder.Entity<PdbUser>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<PdbUser>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<PdbUser>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();
        }
    }
}
