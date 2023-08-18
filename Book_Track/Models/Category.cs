namespace Book_Track.Models
{
    public class Category
    {
        public int? CategoryId { get; set; }
        public string? NameToken { get; set; }
        public int? TypeId { get; set; }
        public string? Description { get; set; }

        public CategoryType? CategoryType { get; set; }
        public ICollection<Book>? Books { get; set; }
        public string Name { get; internal set; }
    }
}
