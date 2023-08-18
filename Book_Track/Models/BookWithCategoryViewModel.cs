namespace Book_Track.Models
{
    public class BookWithCategoryViewModel
    {
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        // Other properties you need
        public string? CategoryName { get; set; } // Property for the category name
    }
}
