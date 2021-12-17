using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TranAnhThang017.Models
{
    [Table(Company)]
    public class Company : StringProcessTAT017
    {
        [Key]
        [StringLength(20)]
        [Display(Name = "Mã")]
        public string CompanyId { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên")]
        public string CompanyName { get; set; }

    }
}