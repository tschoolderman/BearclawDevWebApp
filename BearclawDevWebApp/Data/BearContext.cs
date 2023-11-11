using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace BearclawDevWebApp.Data
{
    public class BearContext : DbContext
    {
        public BearContext(DbContextOptions<BearContext> options) : base(options)
        {
        }
        public DbSet<Post> Post { get; set; }
    }
}
