using Book_Track.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Track.Data
{
    public class BookDbContext : DbContext
    {
        public DbSet<Book>? Books { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<CategoryType>? CategoryTypes { get; set; }

        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define your model configuration here if needed
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Fiction" },
                new Category { CategoryId = 2, Name = "Non-Fiction" }

                );
                
        }
    }
}
