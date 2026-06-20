using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _2526_2221050613_BaiThi.Models
{
    public class PhuongXa
    {
        [Key]
        public string MaPhuongXa { get; set; }
        [Required(ErrorMessage = "k duoc de trong thuoc tinh")]
        public string TenPhuongXa { get; set; }
        public string MaTinh { get; set}
        [ForeignKey("MaTinh")]
        public TinhThanh? TenTinh { get; set; }

    }
}