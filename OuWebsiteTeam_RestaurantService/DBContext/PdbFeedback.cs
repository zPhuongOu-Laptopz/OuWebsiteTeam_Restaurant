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
        [Display(Name = "Họ")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên")]
        public string LastName { get; set; }

        [Display(Name = "Đánh giá")]
        public int NumberStar { get; set; }

        [Display(Name = "Nội dung")]
        public string Message { get; set; }

        [StringLength(100)]
        [Display(Name = "Địa chỉ Email")]
        public string Email { get; set; }

        [StringLength(15)]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
    }
}
