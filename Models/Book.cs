namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public int BookedUser { get; set; }
        public int OwnerUser { get; set; }
    }
}
