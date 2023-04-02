namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Donhang")]
    public partial class Donhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donhang()
        {
            Chitietdonhang = new HashSet<Chitietdonhang>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Madon { get; set; }
        [Display(Name = "Datetime ")]

        public DateTime? Ngaydat { get; set; }

        public int? Tinhtrang { get; set; }
        [Display(Name = "Payment ")]

        public int? Thanhtoan { get; set; }

        [Display(Name = "Total ")]

        public decimal? Tongtien { get; set; }
        [Display(Name = "User name ")]

        public int? MaNguoidung { get; set; }
        [Display(Name = "Address ")]

        public string Diachinhanhang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdonhang> Chitietdonhang { get; set; }

        public virtual Nguoidung Nguoidung { get; set; }
    }
}
