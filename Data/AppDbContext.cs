using Microsoft.EntityFrameworkCore;
using AprendizajeSoftware.Models;

namespace AprendizajeSoftware.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
        }
            public DbSet<Usuario> Usuarios {get;set;}
    }
}