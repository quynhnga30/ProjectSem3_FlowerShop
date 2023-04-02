namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nguoidung")]
    public partial class Nguoidung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nguoidung()
        {
            Donhang = new HashSet<Donhang>();
        }

        [Key]
        public int MaNguoiDung { get; set; }
        [Display(Name = "Img ")]
        public string Anhdaidien { get; set; }

        [StringLength(50)]
        [Display(Name = "Name ")]
        [Required(ErrorMessage = "name is required")]
        public string Hoten { get; set; }

        [StringLength(50)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail defail")]
        public string Email { get; set; }

        [StringLength(10)]
        [Display(Name = "Phone")]
        [Required(ErrorMessage = "phone is required")]
        public string Dienthoai { get; set; }

        [Required(ErrorMessage = "password is required ")]
        [StringLength(maximumLength: 20, MinimumLength = 8, ErrorMessage = "Password length from 8-20 characters")]
        [Display(Name = "Password")]
        public string Matkhau { get; set; }

        public int? IDQuyen { get; set; }

        [StringLength(100)]
        [Display(Name = "Address ")]
        public string Diachi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donhang> Donhang { get; set; }

        public virtual PhanQuyen PhanQuyen { get; set; }
    }
}
