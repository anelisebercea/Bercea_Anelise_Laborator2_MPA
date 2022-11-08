using Microsoft.EntityFrameworkCore;
using Bercea_Anelise_Laborator2_MPA.Models;

namespace Bercea_Anelise_Laborator2_MPA.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) :
       base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Book>().ToTable("Book");
        }
        public DbSet<Bercea_Anelise_Laborator2_MPA.Models.Author> Author { get; set; }
    }
}
