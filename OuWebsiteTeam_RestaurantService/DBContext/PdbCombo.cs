namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PdbCombo")]
    public partial class PdbCombo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PdbCombo()
        {
            PdbFoodComboes = new HashSet<PdbFoodCombo>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name ="Mô tả")]        
        public string Decriptions { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã Combo")]
        public string Code { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Giá cũ")]
        public decimal OldPrice { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Giá mới")]
        public decimal RealPrice { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "Ngày hết hạn")]
        public DateTime OutDate { get; set; }

        public Guid? Modifedby { get; set; }

        [Display(Name = "Hiển thị")]
        public bool? IsDisplay { get; set; }

        [Display(Name = "Trạng thái")]
        public bool? IsStatus { get; set; }

        public int? BuyCount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbFoodCombo> PdbFoodComboes { get; set; }
    }
}
