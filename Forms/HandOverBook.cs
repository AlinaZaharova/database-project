using LibraryApp.Helpers;
using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class HandOverBook : BaseForm
    {
        private Book _book;
        private DatabaseWorker _db = new DatabaseWorker();
        public HandOverBook(User user, Book book) : base(user)
        {
            InitializeComponent();
            _book = book;
        }

        private void HandOverBook_Load(object sender, EventArgs e)
        {
            List<User> users = _db.GetAllUsers().Where(x => x.IsAdmin == false).ToList();
            cb_users.DataSource = users;
            cb_users.DisplayMember = "Name";

            if (_book.OwnerUser != 0) 
            {
                cb_users.SelectedItem = users.FirstOrDefault(x => x.Id == _book.OwnerUser);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cb_users.SelectedItem == null)
                return;
            User user = (User)cb_users.SelectedItem;
            _book.OwnerUser = user.Id;
            _book.BookedUser = 0;
            _db.EditBook(_book);
            Logger.CreateRecord($"Выдана книга {_book.Title} пользователю: {_book.OwnerUser}");
            Close();
        }

        private void cb_users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
