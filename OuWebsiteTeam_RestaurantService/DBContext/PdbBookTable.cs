namespace OuWebsiteTeam_RestaurantService.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PdbBookTable
    {
        [Key]
        public Guid ID { get; set; }

        [Required(ErrorMessage ="Bạn chưa nhập tên")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập tên")]
        [StringLength(50)]
        public string LastName  { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại")]
        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập số người")]
        public int NumberPerson { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập loại phòng")]
        [StringLength(100)]
        public string TypeRoom { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập thời gian")]
        public DateTime Time { get; set; }
        
        public string Note { get; set; }
    }
}
