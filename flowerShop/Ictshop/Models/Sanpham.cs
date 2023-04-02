namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sanpham")]
    public partial class Sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sanpham()
        {
            Chitietdonhang = new HashSet<Chitietdonhang>();
        }

        [Key]
        public int Masp { get; set; }

        [StringLength(50)]
        [Display(Name = "Product Name")]

        public string Tensp { get; set; }
        [Display(Name = "Price  ")]

        public decimal? Giatien { get; set; }
        [Display(Name = "quantity ")]

        public int? Soluong { get; set; }
        [Display(Name = "Discription ")]

        [Column(TypeName = "ntext")]
        public string Mota { get; set; }
    
        [Display(Name = "Img ")]

        [StringLength(50)]
        public string Anhbia { get; set; }
        [Display(Name = "Occasion ")]

        public int? Mahang { get; set; }
        [Display(Name = "Flower ")]

        public int? Mahdh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdonhang> Chitietdonhang { get; set; }

        public virtual Hangsanxuat Hangsanxuat { get; set; }

        public virtual Hedieuhanh Hedieuhanh { get; set; }
    }
}
