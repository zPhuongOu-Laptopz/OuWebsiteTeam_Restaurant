namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PdbFood
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PdbFood()
        {
            PdbFoodComboes = new HashSet<PdbFoodCombo>();
            PdbFoodHashtags = new HashSet<PdbFoodHashtag>();
            PdbFoodMeterials = new HashSet<PdbFoodMeterial>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Tên món ăn")]
        public string NameFood { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Mô tả")]
        public string Decriptions { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Giá cỡ Lớn")]
        [Required(ErrorMessage = "Nhập giá")]
        public decimal? PriceBigSize { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Giá cỡ Nhỏ")]
        [Required(ErrorMessage = "Nhập giá")]
        public decimal? PriceSmallSize { get; set; }

        [Display(Name = "Phần trăm giảm giá (lớn)")]
        [Required(ErrorMessage = "Nhập phần trăm giảm giá")]
        public int PercentDiscountForBigSize { get; set; }

        [Display(Name = "Phần trăm giảm giá (nhỏ)")]
        [Required(ErrorMessage = "Nhập phần trăm giảm giá")]
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

        [Display(Name = "Kích hoạt")]
        public bool IsStatus { get; set; }

        [Display(Name = "Cho phép đặt hàng")]
        public bool IsAllowOrder { get; set; }

        [Display(Name = "Sản phẩm hot")]
        public bool IsHot { get; set; }

        [Required]
        public int ViewCount { get; set; }

        [Required]
        public int BuyCount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbFoodCombo> PdbFoodComboes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbFoodHashtag> PdbFoodHashtags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbFoodMeterial> PdbFoodMeterials { get; set; }
    }
}
