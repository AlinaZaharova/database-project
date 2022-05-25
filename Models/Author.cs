using System;

namespace LibraryApp.Models
{
    public class Author
    {
         public int Id { get; set; }
         public string Name { get; set; }
         public DateTime DateOfBirth { get; set; }
         public Country Country { get; set; }
    }
}
