using Microsoft.EntityFrameworkCore;
using CoreMvc.Information;

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