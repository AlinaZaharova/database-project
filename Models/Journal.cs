using System;

namespace LibraryApp.Models
{
    public class Journal
    {
        public int Id { get; set; }
        public DateTime DateOfOperation { get; set; }
        public int UserId { get; set; }
        public string Operation { get; set; }
    }
}
