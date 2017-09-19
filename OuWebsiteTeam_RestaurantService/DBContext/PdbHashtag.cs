namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PdbHashtag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PdbHashtag()
        {
            PdbFoodHashtags = new HashSet<PdbFoodHashtag>();
        }

        public Guid ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string IsStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbFoodHashtag> PdbFoodHashtags { get; set; }
    }
}
