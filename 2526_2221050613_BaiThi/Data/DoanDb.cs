using Microsoft.EntityFrameworkCore;
using _2526_2221050613_BaiThi.Models;

namespace _2526_2221050613_BaiThi.Data
{
    public class DoanDb : DbContext
    {
        public DoanDb(
            DbContextOptions<DoanDb> options)
            : base(options)
        {
        }
        public DbSet<TinhThanh> TinhThanhs { get; set; }
        public DbSet<PhuongXa> PhuongXas { get; set; }

    }
}
