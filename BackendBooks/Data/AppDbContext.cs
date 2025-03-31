using Microsoft.EntityFrameworkCore;
using BackendBooks.models;

namespace BackendBooks.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book");
        }
            public DbSet<Book> Books {get;set;}
    }
}
