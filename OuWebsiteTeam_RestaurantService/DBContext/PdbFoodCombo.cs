namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PdbFoodCombo")]
    public partial class PdbFoodCombo
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDCombo { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDFood { get; set; }

        public bool? IsStatus { get; set; }

        public virtual PdbCombo PdbCombo { get; set; }

        public virtual PdbFood PdbFood { get; set; }
    }
}
