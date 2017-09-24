namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PdbUser")]
    public partial class PdbUser
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Tài khoản")]
        public string Username { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Tên")]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        [Display(Name = "Địa chỉ Email")]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastLoginTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Display(Name = "Kích hoạt")]
        public bool isActive { get; set; }

        [Display(Name = "Xóa tài khoản")]
        public bool isDeleted { get; set; }

        public int AccessFailedCount { get; set; }

        public int AccessCount { get; set; }

        public Guid? AuthenticationSource { get; set; }

        [StringLength(50)]
        [Display(Name = "Chọn hình")]
        public string Avatar { get; set; }
    }
}
