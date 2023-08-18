namespace Book_Track.Models
{
    public class Book
    {
        public int? BookId { get; set; }
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public int? CategoryId { get; set; }
        public string? Author { get; set; }

        public Category? Category { get; set; }
    }
}
