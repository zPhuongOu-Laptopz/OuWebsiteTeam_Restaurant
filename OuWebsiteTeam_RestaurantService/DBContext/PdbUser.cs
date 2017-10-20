namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PdbUser")]
    public partial class PdbUser
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastLoginTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public bool isActive { get; set; }

        public bool isDeleted { get; set; }
    }
}
