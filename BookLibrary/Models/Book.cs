namespace BookLibrary.Models
{
    public class Book
    { 
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
