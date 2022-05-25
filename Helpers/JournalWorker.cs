using LibraryApp.Models;

namespace LibraryApp.Helpers
{
    public class JournalWorker
    {
        private User _user;

        private DatabaseWorker _db = new DatabaseWorker();

        public JournalWorker(User user)
        {
            _user = user;
        }

        public void CreateRecord(string operation) 
        {
            var record = new Journal()
            {
                UserId = _user.Id,
                DateOfOperation = System.DateTime.UtcNow,
                Operation = operation
            };

            _db.AddJournalRecord(record);
        }
    }
}
