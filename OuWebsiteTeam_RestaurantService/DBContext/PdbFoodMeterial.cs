namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PdbFoodMeterial
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDFood { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid IDMeterials { get; set; }

        public bool IsStatus { get; set; }

        public virtual PdbFood PdbFood { get; set; }

        public virtual PdbMeterial PdbMeterial { get; set; }
    }
}
