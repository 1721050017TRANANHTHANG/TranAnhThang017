using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using TranAnhThang017.Models;

namespace TranAnhThang017.Models
{
    public class CompanyTAT017 
    {
        [Key]
        [StringLength(20)]
        [Display(Name = "Mã")]
        [Required]
        public string CompanyId { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên")]
        [Required]
        public string CompanyName { get; set; }
    }
}