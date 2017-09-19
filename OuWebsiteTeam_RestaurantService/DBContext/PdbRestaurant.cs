namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PdbRestaurant
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        public string FacebookAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string InstagramAddress { get; set; }

        [StringLength(100)]
        public string YoutubeAddress { get; set; }

        [StringLength(100)]
        public string TwitterAddress { get; set; }

        [Required]
        [StringLength(250)]
        public string Decriptions { get; set; }

        [Required]
        [StringLength(15)]
        public string Phone { get; set; }

        [Required]
        [StringLength(15)]
        public string Fax { get; set; }

        public int NumberStar { get; set; }

        [Required]
        [StringLength(10)]
        public string TimeOpen { get; set; }

        [Required]
        [StringLength(10)]
        public string TimeClose { get; set; }

        [StringLength(200)]
        public string LocationGoogleMap { get; set; }
    }
}
