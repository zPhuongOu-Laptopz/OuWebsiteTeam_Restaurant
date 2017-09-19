namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PdbCategory
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsStatus { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedDate { get; set; }

        public Guid? Modifedby { get; set; }

        public int Filter { get; set; }

        [Required]
        [StringLength(100)]
        public string HtmlIcon { get; set; }
    }
}
