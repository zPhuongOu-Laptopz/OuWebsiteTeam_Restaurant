namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PdbMeterial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PdbMeterial()
        {
            PdbFoodMeterials = new HashSet<PdbFoodMeterial>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Tên nguyên liệu")]
        public string Name { get; set; }

        [StringLength(50)]
        [Display(Name = "Nguồn gốc")]
        public string Origin { get; set; }

        [StringLength(250)]
        [Display(Name = "Mô tả")]
        public string Descriptions { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Kiểu nguyên liệu")]
        public string Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbFoodMeterial> PdbFoodMeterials { get; set; }
    }
}
