namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chitietdonhang")]
    public partial class Chitietdonhang
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Madon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Masp { get; set; }
        [Display(Name = "Quantity")]

        public int? Soluong { get; set; }
        [Display(Name = "Payment")]

        public int? Phuongthucthanhtoan { get; set; }
        [Display(Name = "Price")]

        public decimal? Dongia { get; set; }
        [Display(Name = "Total ")]

        public decimal? Thanhtien { get; set; }

        public virtual Donhang Donhang { get; set; }

        public virtual Sanpham Sanpham { get; set; }
    }
}
