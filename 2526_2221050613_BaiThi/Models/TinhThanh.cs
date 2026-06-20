using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using _2526_2221050613_BaiThi.Migrations;

namespace _2526_2221050613_BaiThi.Models
{
    public class TinhThanh
    {
        [Key]
        public string MaTinh { get; set; }
        [Required(ErrorMessage = "thuoc tinh nay khong duoc de trong")]
        public String TenTinh { get; set; }
        public ICollection<PhuongXa>? Phuongxas { get; set; }
    }
}