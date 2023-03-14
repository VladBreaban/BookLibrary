namespace BookLibrary.ApiModels
{
    public class BookApiModel
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
