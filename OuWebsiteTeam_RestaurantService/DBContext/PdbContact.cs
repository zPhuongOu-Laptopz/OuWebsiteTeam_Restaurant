namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PdbContact
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Kiểu")]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Giá trị")]
        public string Value { get; set; }
    }
}
