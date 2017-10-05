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
        public string Decriptions { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Column(TypeName = "money")]
        public decimal OldPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal RealPrice { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime OutDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedDate { get; set; }

        public Guid? Modifedby { get; set; }

        public bool? IsStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbFoodCombo> PdbFoodComboes { get; set; }
    }
}
