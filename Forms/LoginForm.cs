using LibraryApp.Helpers;
using LibraryApp.Models;
using LibraryApp.UserControls;
using System;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class LoginForm : Form
    {
        private DatabaseWorker _db = new DatabaseWorker();
        private BooksUC _bookForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        private User Login(string name, string password)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Заполните все необходимые поля!");
            }

            var userFromDb = _db.GetUserByName(txt_login.Text);

            if (userFromDb == null)
            {
                throw new Exception("Такого пользователя не существует!");
            }

            if (name != userFromDb.Name || password != userFromDb.Password)
            {
                throw new Exception("Неправильный логин или пароль!");
            }

            return userFromDb;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                 var user = Login(txt_login.Text, txt_pass.Text);
                _bookForm = new BooksUC(user);
                _bookForm.Dock = DockStyle.Fill;
                ParentForm.Controls.Add(_bookForm);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
