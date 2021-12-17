using System;
using System.ComponentModel.DataAnnotations;

namespace TranAnhThang017.Models
{
    public class TAT0017
    {
        [Key]
        [StringLength(20)]
        [Display(Name = "Mã")]
        public string TATID { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên")]
        [Required]
        public string TATName { get; set; }

        [Display(Name = "Tran Anh Thang Gender")]
        [Required]
        public Boolean TATGender  { get; set; }
    }
}