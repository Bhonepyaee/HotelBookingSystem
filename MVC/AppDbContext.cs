using Microsoft.EntityFrameworkCore;
using MVC.DB;

namespace MVC
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Tbl_Blog> Tbl_Blogs { get; set; }
    }
}
