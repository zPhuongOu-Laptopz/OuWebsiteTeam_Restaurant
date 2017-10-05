namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PdbFeedback
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int NumberStar { get; set; }

        public string Message { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }
    }
}
