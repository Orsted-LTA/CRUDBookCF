using Microsoft.EntityFrameworkCore;
using CRUDSachCF.Models;

namespace CRUDSachCF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
