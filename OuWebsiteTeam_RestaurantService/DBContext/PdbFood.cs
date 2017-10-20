namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PdbFood
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PdbFood()
        {

        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NameFood { get; set; }

        [Required]
        [StringLength(100)]
        public string Type { get; set; }

        [Required]
        [StringLength(100)]
        public string Decriptions { get; set; }

        [Column(TypeName = "image")]
        public byte[] Images { get; set; }

        [Column(TypeName = "money")]
        public decimal PriceBigSize { get; set; }

        [Column(TypeName = "money")]
        public decimal PriceSmallSize { get; set; }

        public int PercentDiscountForBigSize { get; set; }

        public int PercentDiscountForSmallSize { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceDiscountForBigSize { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceDiscountForSmallSize { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedDate { get; set; }

        public Guid? Modifedby { get; set; }

        public bool IsStatus { get; set; }

        public bool IsAllowOrder { get; set; }

        public bool IsHot { get; set; }

        public int ViewCount { get; set; }

        public int BuyCount { get; set; }
    }
}
