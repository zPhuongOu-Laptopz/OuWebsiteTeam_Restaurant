namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class PdbRestaurant
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Tên Nhà Hàng")]        
        public string RealName { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên viết tắt")]
        public string ShortName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Địa chỉ Facebook")]
        public string FacebookAddress { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Địa chỉ Instragram")]
        public string InstagramAddress { get; set; }

        [StringLength(100)]
        [Display(Name = "Địa chỉ Youtube")]
        public string YoutubeAddress { get; set; }

        [StringLength(100)]
        [Display(Name = "Địa chỉ Twitter")]
        public string TwitterAddress { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Mô Tả")]
        public string Decriptions { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Số Điện Thoại")]
        public string Phone { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Số Fax")]
        public string Fax { get; set; }

        [Display(Name = "Số Sao")]
        public int NumberStar { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Thời gian mở cửa")]
        public string TimeOpen { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Thời gian đóng cửa")]
        public string TimeClose { get; set; }

        [StringLength(200)]
        [Display(Name = "Địa chỉ trên GoogleMap(dev)")]
        public string LocationGoogleMap { get; set; }
    }
}
