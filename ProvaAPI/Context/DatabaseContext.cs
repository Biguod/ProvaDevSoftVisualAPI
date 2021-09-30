using Microsoft.EntityFrameworkCore;
using ProvaAPI.Models;

namespace ProvaAPI.Context
{
    public class DatabaseContext : DbContext
    {        
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Automobile> Automobiles { get; set; }   

    }
}
