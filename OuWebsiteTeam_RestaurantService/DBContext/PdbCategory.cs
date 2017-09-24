namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PdbCategory
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên Danh Mục")]
        public string Name { get; set; }

        [Display(Name = "Kích hoạt")]
        public bool IsStatus { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedDate { get; set; }

        public Guid? Modifedby { get; set; }

        [Display(Name = "Thứ tự")]
        public int Filter { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Hình Icon")]
        public string HtmlIcon { get; set; }
    }
}
