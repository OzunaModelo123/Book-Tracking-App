using Book_Track.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Track.Data
{
    public class BookDbContext
    {
        public DbSet<Book>? Books { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<CategoryType>? CategoryTypes { get; set; }
    }
}
