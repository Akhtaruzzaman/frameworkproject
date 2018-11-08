using Microsoft.EntityFrameworkCore;
using Core.Information;

namespace RazorPagesContacts.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Information> Information { get; set; }
    }
}