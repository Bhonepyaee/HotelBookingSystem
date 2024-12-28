using Microsoft.EntityFrameworkCore;

namespace MVC.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Tbl_Blog> Tbl_Blogs { get; set; }
    }
}
